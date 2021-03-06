﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NMF.Expressions.Linq
{
    internal sealed class ObservableJoin<TOuter, TInner, TKey, TResult> : ObservableEnumerable<TResult>
    {
        private INotifyEnumerable<TOuter> outerSource;
        private IEnumerable<TInner> innerSource;
        private INotifyEnumerable<TInner> observableInnerSource;
        private ObservingFunc<TOuter, TKey> outerKeySelector;
        private ObservingFunc<TInner, TKey> innerKeySelector;
        private ObservingFunc<TOuter, TInner, TResult> resultSelector;

        private Dictionary<TKey, KeyGroup> groups;
        private Dictionary<TInner, Stack<TaggedObservableValue<TKey, TInner>>> innerValues = new Dictionary<TInner, Stack<TaggedObservableValue<TKey, TInner>>>();
        private Dictionary<TOuter, Stack<TaggedObservableValue<TKey, TOuter>>> outerValues = new Dictionary<TOuter, Stack<TaggedObservableValue<TKey, TOuter>>>();

        public override IEnumerable<INotifiable> Dependencies
        {
            get
            {
                yield return outerSource;
                if (observableInnerSource != null)
                    yield return observableInnerSource;
                foreach (var stack in outerValues.Values)
                {
                    foreach (var tagged in stack)
                        yield return tagged;
                }
                foreach (var stack in innerValues.Values)
                {
                    foreach (var tagged in stack)
                        yield return tagged;
                }
                foreach (var group in groups.Values)
                {
                    foreach (var stack in group.Results.Values)
                    {
                        foreach (var result in stack)
                            yield return result;
                    }
                }
            }
        }

        public ObservableJoin(INotifyEnumerable<TOuter> outerSource, IEnumerable<TInner> innerSource, ObservingFunc<TOuter, TKey> outerKeySelector, ObservingFunc<TInner, TKey> innerKeySelector, ObservingFunc<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
            if (outerSource == null) throw new ArgumentNullException("outerSource");
            if (innerSource == null) throw new ArgumentNullException("innerSource");
            if (outerKeySelector == null) throw new ArgumentNullException("outerKeySelector");
            if (innerKeySelector == null) throw new ArgumentNullException("innerKeySelector");
            if (resultSelector == null) throw new ArgumentNullException("resultSelector");

            this.outerSource = outerSource;
            this.innerSource = innerSource;
            this.outerKeySelector = outerKeySelector;
            this.innerKeySelector = innerKeySelector;
            this.resultSelector = resultSelector;

            this.observableInnerSource = innerSource as INotifyEnumerable<TInner>;
            if (observableInnerSource == null)
                observableInnerSource = (innerSource as IEnumerableExpression<TInner>)?.AsNotifiable();
            groups = new Dictionary<TKey, KeyGroup>(comparer);
        }

        private class KeyGroup
        {
            public List<TaggedObservableValue<TKey, TOuter>> OuterKeys = new List<TaggedObservableValue<TKey, TOuter>>();
            public List<TaggedObservableValue<TKey, TInner>> InnerKeys = new List<TaggedObservableValue<TKey, TInner>>();
            public Dictionary<Match, Stack<INotifyValue<TResult>>> Results = new Dictionary<Match, Stack<INotifyValue<TResult>>>();
        }

        private struct Match : IEquatable<Match>
        {
            public TInner Inner;
            public TOuter Outer;

            public Match(TOuter outer, TInner inner)
            {
                Outer = outer;
                Inner = inner;
            }

            public override int GetHashCode()
            {
                int hash = 0;
                if (Outer != null)
                {
                    hash ^= Outer.GetHashCode();
                }
                if (Inner != null)
                {
                    hash ^= Inner.GetHashCode();
                }
                return hash;
            }

            public override bool Equals(object obj)
            {
                if (obj != null && obj is Match)
                {
                    return Equals((Match)obj);
                }
                else
                {
                    return false;
                }
            }

            public bool Equals(Match other)
            {
                return EqualityComparer<TOuter>.Default.Equals(Outer, other.Outer)
                    && EqualityComparer<TInner>.Default.Equals(Inner, other.Inner);
            }
        }

        public override IEnumerator<TResult> GetEnumerator()
        {
            return groups.Values.SelectMany(group => group.Results.Values.SelectMany(val => val).Select(val => val.Value)).GetEnumerator();
        }

        public override int Count
        {
            get
            {
                return groups.Values.Sum(group => group.Results.Count);
            }
        }
        
        private void AttachOuter(TOuter item, ICollection<TResult> added)
        {
            var keyValue = outerKeySelector.InvokeTagged(item, item);
            keyValue.Successors.Set(this);
            Stack<TaggedObservableValue<TKey, TOuter>> valueStack;
            if (!outerValues.TryGetValue(item, out valueStack))
            {
                valueStack = new Stack<TaggedObservableValue<TKey, TOuter>>();
                outerValues.Add(item, valueStack);
            }
            valueStack.Push(keyValue);
            KeyGroup group;
            if (!groups.TryGetValue(keyValue.Value, out group))
            {
                group = new KeyGroup();
                groups.Add(keyValue.Value, group);
            }
            group.OuterKeys.Add(keyValue);

            if (added != null)
            {
                foreach (var inner in group.InnerKeys)
                {
                    added.Add(AttachResult(group, item, inner.Tag));
                }
            }
            else
            {
                foreach (var inner in group.InnerKeys)
                {
                    AttachResult(group, item, inner.Tag);
                }
            }
        }

        private void AttachInner(TInner item, ICollection<TResult> added)
        {
            var keyValue = innerKeySelector.InvokeTagged(item, item);
            keyValue.Successors.Set(this);
            Stack<TaggedObservableValue<TKey, TInner>> valueStack;
            if (!innerValues.TryGetValue(item, out valueStack))
            {
                valueStack = new Stack<TaggedObservableValue<TKey, TInner>>();
                innerValues.Add(item, valueStack);
            }
            valueStack.Push(keyValue);
            KeyGroup group;
            if (!groups.TryGetValue(keyValue.Value, out group))
            {
                group = new KeyGroup();
                groups.Add(keyValue.Value, group);
            }
            group.InnerKeys.Add(keyValue);
            if (added == null)
            {
                foreach (var outer in group.OuterKeys)
                {
                    AttachResult(group, outer.Tag, item);
                }
            }
            else
            {
                foreach (var outer in group.OuterKeys)
                {
                    added.Add(AttachResult(group, outer.Tag, item));
                }
            }
        }

        private TResult AttachResult(KeyGroup group, TOuter outer, TInner inner)
        {
            var match = new Match(outer, inner);
            Stack<INotifyValue<TResult>> resultStack;
            if (!group.Results.TryGetValue(match, out resultStack))
            {
                resultStack = new Stack<INotifyValue<TResult>>();
                group.Results.Add(match, resultStack);
            }
            var result = resultSelector.Observe(outer, inner);
            result.Successors.Set(this);
            resultStack.Push(result);
            return result.Value;
        }

        private TResult DetachResult(KeyGroup group, TOuter outer, TInner inner)
        {
            var match = new Match(outer, inner);
            var resultStack = group.Results[match];
            var result = resultStack.Pop();
            var value = result.Value;
            result.Successors.Unset(this);
            if (resultStack.Count == 0)
            {
                group.Results.Remove(match);
            }
            return value;
        }

        protected override void OnAttach()
        {
            foreach (var item in outerSource)
            {
                AttachOuter(item, null);
            }
            foreach (var item in innerSource)
            {
                AttachInner(item, null);
            }
        }

        protected override void OnDetach()
        {
            foreach (var group in groups.Values)
            {
                foreach (var val in group.OuterKeys)
                {
                    val.Successors.Unset(this);
                }
                foreach (var val in group.InnerKeys)
                {
                    val.Successors.Unset(this);
                }
                foreach (var stack in group.Results.Values)
                {
                    foreach (var val in stack)
                    {
                        val.Successors.Unset(this);
                    }
                }
            }

            groups.Clear();
            outerValues.Clear();
            innerValues.Clear();
        }

        public override INotificationResult Notify(IList<INotificationResult> sources)
        {
            var added = new List<TResult>();
            var removed = new List<TResult>();
            var replaceAdded = new List<TResult>();
            var replaceRemoved = new List<TResult>();
            bool reset = false;

            foreach (var change in sources)
            {
                if (change.Source == outerSource)
                {
                    var outerChange = (CollectionChangedNotificationResult<TOuter>)change;
                    if (outerChange.IsReset)
                    {
                        foreach (var group in groups.Values)
                        {
                            foreach (var val in group.OuterKeys)
                            {
                                val.Successors.Unset(this);
                            }
                            group.OuterKeys.Clear();
                            foreach (var stack in group.Results.Values)
                            {
                                removed.AddRange(stack.Select(s => s.Value));
                                foreach (var val in stack)
                                {
                                    val.Successors.Unset(this);
                                }
                            }
                            group.Results.Clear();
                        }
                        outerValues.Clear();

                        if (reset || observableInnerSource == null) //both source collections may be reset, only return after handling both
                        {
                            OnCleared();
                            return new CollectionChangedNotificationResult<TResult>(this);
                        }
                        reset = true;
                    }
                    else
                    {
                        NotifyOuter(outerChange, added, removed);
                    }
                }
                else if (change.Source == observableInnerSource)
                {
                    var innerChange = (CollectionChangedNotificationResult<TInner>)change;
                    if (innerChange.IsReset)
                    {
                        foreach (var group in groups.Values)
                        {
                            foreach (var val in group.InnerKeys)
                            {
                                val.Successors.Unset(this);
                            }
                            group.InnerKeys.Clear();
                            foreach (var stack in group.Results.Values)
                            {
                                removed.AddRange(stack.Select(s => s.Value));
                                foreach (var val in stack)
                                {
                                    val.Successors.Unset(this);
                                }
                            }
                            group.Results.Clear();
                        }
                        innerValues.Clear();

                        if (reset) //both source collections may be reset, only return after handling both
                        {
                            OnCleared();
                            return new CollectionChangedNotificationResult<TResult>(this);
                        }
                        reset = true;
                    }
                    else
                    {
                        NotifyInner(innerChange, added, removed);
                    }
                }
                else if (change is ValueChangedNotificationResult<TKey>)
                {
                    var keyChange = (ValueChangedNotificationResult<TKey>)change;
                    if (keyChange.Source is TaggedObservableValue<TKey, TOuter>)
                        NotifyOuterKey(keyChange, replaceAdded, replaceRemoved);
                    else
                        NotifyInnerKey(keyChange, replaceAdded, replaceRemoved);
                }
                else
                {
                    var resultChange = (ValueChangedNotificationResult<TResult>)change;
                    replaceRemoved.Add(resultChange.OldValue);
                    replaceAdded.Add(resultChange.NewValue);
                }
            }

            if (reset) //only one source was reset
            {
                OnCleared();
                return new CollectionChangedNotificationResult<TResult>(this);
            }

            if (added.Count == 0 && removed.Count == 0 && replaceAdded.Count == 0)
                return UnchangedNotificationResult.Instance;

            OnRemoveItems(removed);
            OnAddItems(added);
            OnReplaceItems(replaceRemoved, replaceAdded);
            return new CollectionChangedNotificationResult<TResult>(this, added, removed, replaceAdded, replaceRemoved);
        }

        private void NotifyOuter(CollectionChangedNotificationResult<TOuter> outerChange, List<TResult> added, List<TResult> removed)
        {
            foreach (var outer in outerChange.AllRemovedItems)
            {
                var valueStack = outerValues[outer];
                var value = valueStack.Pop();
                if (valueStack.Count == 0)
                {
                    outerValues.Remove(outer);
                }
                var group = groups[value.Value];
                group.OuterKeys.Remove(value);
                if (group.OuterKeys.Count == 0 && group.InnerKeys.Count == 0)
                {
                    groups.Remove(value.Value);
                }
                foreach (var inner in group.InnerKeys)
                {
                    removed.Add(DetachResult(group, outer, inner.Tag));
                }
                value.Successors.Unset(this);
            }
                
            foreach (var outer in outerChange.AllAddedItems)
            {
                AttachOuter(outer, added);
            }
        }

        private void NotifyInner(CollectionChangedNotificationResult<TInner> innerChange, List<TResult> added, List<TResult> removed)
        {
            foreach (var inner in innerChange.AllRemovedItems)
            {
                var valueStack = innerValues[inner];
                var value = valueStack.Pop();
                if (valueStack.Count == 0)
                {
                    innerValues.Remove(inner);
                }
                var group = groups[value.Value];
                group.InnerKeys.Remove(value);
                if (group.InnerKeys.Count == 0 && group.OuterKeys.Count == 0)
                {
                    groups.Remove(value.Value);
                }
                foreach (var outer in group.OuterKeys)
                {
                    removed.Add(DetachResult(group, outer.Tag, inner));
                }
                value.Successors.Unset(this);
            }
                
            foreach (var inner in innerChange.AllAddedItems)
            {
                AttachInner(inner, added);
            }
        }

        private void NotifyOuterKey(ValueChangedNotificationResult<TKey> keyChange, List<TResult> replaceAdded, List<TResult> replaceRemoved)
        {
            var value = (TaggedObservableValue<TKey, TOuter>)keyChange.Source;
            var group = groups[keyChange.OldValue];
            group.OuterKeys.Remove(value);
            foreach (var inner in group.InnerKeys)
            {
                replaceRemoved.Add(DetachResult(group, value.Tag, inner.Tag));
            }

            if (!groups.TryGetValue(value.Value, out group))
            {
                group = new KeyGroup();
                groups.Add(value.Value, group);
            }
            group.OuterKeys.Add(value);

            foreach (var inner in group.InnerKeys)
            {
                replaceAdded.Add(AttachResult(group, value.Tag, inner.Tag));
            }
        }

        private void NotifyInnerKey(ValueChangedNotificationResult<TKey> keyChange, List<TResult> replaceAdded, List<TResult> replaceRemoved)
        {
            var value = (TaggedObservableValue<TKey, TInner>)keyChange.Source;
            var group = groups[keyChange.OldValue];
            group.InnerKeys.Remove(value);
            foreach (var outer in group.OuterKeys)
            {
                replaceRemoved.Add(DetachResult(group, outer.Tag, value.Tag));
            }

            if (!groups.TryGetValue(value.Value, out group))
            {
                group = new KeyGroup();
                groups.Add(value.Value, group);
            }
            group.InnerKeys.Add(value);
            
            foreach (var outer in group.OuterKeys)
            {
                replaceAdded.Add(AttachResult(group, outer.Tag, value.Tag));
            }
        }
    }
}

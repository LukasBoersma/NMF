//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Identifier;
using NMFExamples.Pcm.Core;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Reliability;
using NMFExamples.Pcm.Repository;
using NMFExamples.Pcm.Seff.Seff_performance;
using NMFExamples.Pcm.Seff.Seff_reliability;
using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Collections.ObjectModel;
using global::System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.Pcm.Seff
{
    
    
    /// <summary>
    /// The default implementation of the CallReturnAction class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/SEFF/5.0")]
    [XmlNamespacePrefixAttribute("seff")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/CallReturnAction")]
    public partial class CallReturnAction : CallAction, ICallReturnAction, IModelElement
    {
        
        private static Lazy<ITypedElement> _returnVariableUsage__CallReturnActionReference = new Lazy<ITypedElement>(RetrieveReturnVariableUsage__CallReturnActionReference);
        
        /// <summary>
        /// The backing field for the ReturnVariableUsage__CallReturnAction property
        /// </summary>
        private CallReturnActionReturnVariableUsage__CallReturnActionCollection _returnVariableUsage__CallReturnAction;
        
        private static IClass _classInstance;
        
        public CallReturnAction()
        {
            this._returnVariableUsage__CallReturnAction = new CallReturnActionReturnVariableUsage__CallReturnActionCollection(this);
            this._returnVariableUsage__CallReturnAction.CollectionChanging += this.ReturnVariableUsage__CallReturnActionCollectionChanging;
            this._returnVariableUsage__CallReturnAction.CollectionChanged += this.ReturnVariableUsage__CallReturnActionCollectionChanged;
        }
        
        /// <summary>
        /// The returnVariableUsage__CallReturnAction property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("returnVariableUsage__CallReturnAction")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("callReturnAction__VariableUsage")]
        [ConstantAttribute()]
        public IListExpression<IVariableUsage> ReturnVariableUsage__CallReturnAction
        {
            get
            {
                return this._returnVariableUsage__CallReturnAction;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new CallReturnActionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CallReturnActionReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/CallReturnAction")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveReturnVariableUsage__CallReturnActionReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Seff.CallReturnAction.ClassInstance)).Resolve("returnVariableUsage__CallReturnAction")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ReturnVariableUsage__CallReturnAction property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ReturnVariableUsage__CallReturnActionCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ReturnVariableUsage__CallReturnAction", e, _returnVariableUsage__CallReturnActionReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ReturnVariableUsage__CallReturnAction property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ReturnVariableUsage__CallReturnActionCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ReturnVariableUsage__CallReturnAction", e, _returnVariableUsage__CallReturnActionReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int returnVariableUsage__CallReturnActionIndex = ModelHelper.IndexOfReference(this.ReturnVariableUsage__CallReturnAction, element);
            if ((returnVariableUsage__CallReturnActionIndex != -1))
            {
                return ModelHelper.CreatePath("returnVariableUsage__CallReturnAction", returnVariableUsage__CallReturnActionIndex);
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "RETURNVARIABLEUSAGE__CALLRETURNACTION"))
            {
                if ((index < this.ReturnVariableUsage__CallReturnAction.Count))
                {
                    return this.ReturnVariableUsage__CallReturnAction[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override global::System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "RETURNVARIABLEUSAGE__CALLRETURNACTION"))
            {
                return this._returnVariableUsage__CallReturnAction;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._returnVariableUsage__CallReturnAction))
            {
                return "returnVariableUsage__CallReturnAction";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/CallReturnAction")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CallReturnAction class
        /// </summary>
        public class CallReturnActionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CallReturnAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CallReturnActionChildrenCollection(CallReturnAction parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.ReturnVariableUsage__CallReturnAction.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ReturnVariableUsage__CallReturnAction.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ReturnVariableUsage__CallReturnAction.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IVariableUsage returnVariableUsage__CallReturnActionCasted = item.As<IVariableUsage>();
                if ((returnVariableUsage__CallReturnActionCasted != null))
                {
                    this._parent.ReturnVariableUsage__CallReturnAction.Add(returnVariableUsage__CallReturnActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ReturnVariableUsage__CallReturnAction.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ReturnVariableUsage__CallReturnAction.Contains(item))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> returnVariableUsage__CallReturnActionEnumerator = this._parent.ReturnVariableUsage__CallReturnAction.GetEnumerator();
                try
                {
                    for (
                    ; returnVariableUsage__CallReturnActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = returnVariableUsage__CallReturnActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    returnVariableUsage__CallReturnActionEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IVariableUsage variableUsageItem = item.As<IVariableUsage>();
                if (((variableUsageItem != null) 
                            && this._parent.ReturnVariableUsage__CallReturnAction.Remove(variableUsageItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ReturnVariableUsage__CallReturnAction).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CallReturnAction class
        /// </summary>
        public class CallReturnActionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CallReturnAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CallReturnActionReferencedElementsCollection(CallReturnAction parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.ReturnVariableUsage__CallReturnAction.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ReturnVariableUsage__CallReturnAction.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ReturnVariableUsage__CallReturnAction.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IVariableUsage returnVariableUsage__CallReturnActionCasted = item.As<IVariableUsage>();
                if ((returnVariableUsage__CallReturnActionCasted != null))
                {
                    this._parent.ReturnVariableUsage__CallReturnAction.Add(returnVariableUsage__CallReturnActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ReturnVariableUsage__CallReturnAction.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ReturnVariableUsage__CallReturnAction.Contains(item))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> returnVariableUsage__CallReturnActionEnumerator = this._parent.ReturnVariableUsage__CallReturnAction.GetEnumerator();
                try
                {
                    for (
                    ; returnVariableUsage__CallReturnActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = returnVariableUsage__CallReturnActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    returnVariableUsage__CallReturnActionEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IVariableUsage variableUsageItem = item.As<IVariableUsage>();
                if (((variableUsageItem != null) 
                            && this._parent.ReturnVariableUsage__CallReturnAction.Remove(variableUsageItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ReturnVariableUsage__CallReturnAction).GetEnumerator();
            }
        }
    }
}


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
    
    
    public class InternalActionInternalFailureOccurrenceDescriptions__InternalActionCollection : ObservableOppositeList<IInternalAction, IInternalFailureOccurrenceDescription>
    {
        
        public InternalActionInternalFailureOccurrenceDescriptions__InternalActionCollection(IInternalAction parent) : 
                base(parent)
        {
        }
        
        private void OnItemParentChanged(object sender, ValueChangedEventArgs e)
        {
            if ((e.NewValue != this.Parent))
            {
                this.Remove(((IInternalFailureOccurrenceDescription)(sender)));
            }
        }
        
        protected override void SetOpposite(IInternalFailureOccurrenceDescription item, IInternalAction parent)
        {
            if ((parent != null))
            {
                item.ParentChanged += this.OnItemParentChanged;
                item.InternalAction__InternalFailureOccurrenceDescription = parent;
            }
            else
            {
                item.ParentChanged -= this.OnItemParentChanged;
                if ((item.InternalAction__InternalFailureOccurrenceDescription == this.Parent))
                {
                    item.InternalAction__InternalFailureOccurrenceDescription = parent;
                }
            }
        }
    }
}


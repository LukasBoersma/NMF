//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Interop.Ecore;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Interop.Layout
{
    
    
    /// <summary>
    /// The default implementation of the LayoutInformation class
    /// </summary>
    [XmlNamespaceAttribute("http://www.emftext.org/commons/layout")]
    [XmlNamespacePrefixAttribute("layout")]
    [ModelRepresentationClassAttribute("http://www.emftext.org/commons/layout#//LayoutInformation/")]
    public abstract class LayoutInformation : ModelElement, ILayoutInformation, IModelElement
    {
        
        /// <summary>
        /// The backing field for the StartOffset property
        /// </summary>
        private int _startOffset;
        
        /// <summary>
        /// The backing field for the HiddenTokenText property
        /// </summary>
        private string _hiddenTokenText;
        
        /// <summary>
        /// The backing field for the VisibleTokenText property
        /// </summary>
        private string _visibleTokenText;
        
        /// <summary>
        /// The backing field for the SyntaxElementID property
        /// </summary>
        private string _syntaxElementID;
        
        /// <summary>
        /// The startOffset property
        /// </summary>
        [XmlElementNameAttribute("startOffset")]
        [XmlAttributeAttribute(true)]
        public virtual int StartOffset
        {
            get
            {
                return this._startOffset;
            }
            set
            {
                if ((this._startOffset != value))
                {
                    int old = this._startOffset;
                    this._startOffset = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnStartOffsetChanged(e);
                    this.OnPropertyChanged("StartOffset", e);
                }
            }
        }
        
        /// <summary>
        /// The hiddenTokenText property
        /// </summary>
        [XmlElementNameAttribute("hiddenTokenText")]
        [XmlAttributeAttribute(true)]
        public virtual string HiddenTokenText
        {
            get
            {
                return this._hiddenTokenText;
            }
            set
            {
                if ((this._hiddenTokenText != value))
                {
                    string old = this._hiddenTokenText;
                    this._hiddenTokenText = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnHiddenTokenTextChanged(e);
                    this.OnPropertyChanged("HiddenTokenText", e);
                }
            }
        }
        
        /// <summary>
        /// The visibleTokenText property
        /// </summary>
        [XmlElementNameAttribute("visibleTokenText")]
        [XmlAttributeAttribute(true)]
        public virtual string VisibleTokenText
        {
            get
            {
                return this._visibleTokenText;
            }
            set
            {
                if ((this._visibleTokenText != value))
                {
                    string old = this._visibleTokenText;
                    this._visibleTokenText = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnVisibleTokenTextChanged(e);
                    this.OnPropertyChanged("VisibleTokenText", e);
                }
            }
        }
        
        /// <summary>
        /// The syntaxElementID property
        /// </summary>
        [XmlElementNameAttribute("syntaxElementID")]
        [XmlAttributeAttribute(true)]
        public virtual string SyntaxElementID
        {
            get
            {
                return this._syntaxElementID;
            }
            set
            {
                if ((this._syntaxElementID != value))
                {
                    string old = this._syntaxElementID;
                    this._syntaxElementID = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSyntaxElementIDChanged(e);
                    this.OnPropertyChanged("SyntaxElementID", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://www.emftext.org/commons/layout#//LayoutInformation/");
            }
        }
        
        /// <summary>
        /// Gets fired when the StartOffset property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> StartOffsetChanged;
        
        /// <summary>
        /// Gets fired when the HiddenTokenText property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> HiddenTokenTextChanged;
        
        /// <summary>
        /// Gets fired when the VisibleTokenText property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> VisibleTokenTextChanged;
        
        /// <summary>
        /// Gets fired when the SyntaxElementID property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> SyntaxElementIDChanged;
        
        /// <summary>
        /// Raises the StartOffsetChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStartOffsetChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.StartOffsetChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the HiddenTokenTextChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHiddenTokenTextChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.HiddenTokenTextChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the VisibleTokenTextChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVisibleTokenTextChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.VisibleTokenTextChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SyntaxElementIDChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSyntaxElementIDChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.SyntaxElementIDChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "STARTOFFSET"))
            {
                return this.StartOffset;
            }
            if ((attribute == "HIDDENTOKENTEXT"))
            {
                return this.HiddenTokenText;
            }
            if ((attribute == "VISIBLETOKENTEXT"))
            {
                return this.VisibleTokenText;
            }
            if ((attribute == "SYNTAXELEMENTID"))
            {
                return this.SyntaxElementID;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "STARTOFFSET"))
            {
                this.StartOffset = ((int)(value));
                return;
            }
            if ((feature == "HIDDENTOKENTEXT"))
            {
                this.HiddenTokenText = ((string)(value));
                return;
            }
            if ((feature == "VISIBLETOKENTEXT"))
            {
                this.VisibleTokenText = ((string)(value));
                return;
            }
            if ((feature == "SYNTAXELEMENTID"))
            {
                this.SyntaxElementID = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://www.emftext.org/commons/layout#//LayoutInformation/")));
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the startOffset property
        /// </summary>
        private sealed class StartOffsetProxy : ModelPropertyChange<ILayoutInformation, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public StartOffsetProxy(ILayoutInformation modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.StartOffset;
                }
                set
                {
                    this.ModelElement.StartOffset = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.StartOffsetChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.StartOffsetChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the hiddenTokenText property
        /// </summary>
        private sealed class HiddenTokenTextProxy : ModelPropertyChange<ILayoutInformation, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public HiddenTokenTextProxy(ILayoutInformation modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.HiddenTokenText;
                }
                set
                {
                    this.ModelElement.HiddenTokenText = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.HiddenTokenTextChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.HiddenTokenTextChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the visibleTokenText property
        /// </summary>
        private sealed class VisibleTokenTextProxy : ModelPropertyChange<ILayoutInformation, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public VisibleTokenTextProxy(ILayoutInformation modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.VisibleTokenText;
                }
                set
                {
                    this.ModelElement.VisibleTokenText = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.VisibleTokenTextChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.VisibleTokenTextChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the syntaxElementID property
        /// </summary>
        private sealed class SyntaxElementIDProxy : ModelPropertyChange<ILayoutInformation, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SyntaxElementIDProxy(ILayoutInformation modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.SyntaxElementID;
                }
                set
                {
                    this.ModelElement.SyntaxElementID = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SyntaxElementIDChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SyntaxElementIDChanged -= handler;
            }
        }
    }
}


// <auto-generated/>
// Contents of: hl7.fhir.r3.core version: 3.0.2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model
{
  /// <summary>
  /// A record of information transmitted from a sender to a receiver
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("Communication","http://hl7.org/fhir/StructureDefinition/Communication", IsResource=true)]
  public partial class Communication : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "Communication"; } }

    /// <summary>
    /// Message payload
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("Communication#Payload", IsNestedType=true)]
    public partial class PayloadComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Communication#Payload"; } }

      /// <summary>
      /// Message part content
      /// </summary>
      [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [References("Resource")]
      [AllowedTypes(typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.Attachment),typeof(Hl7.Fhir.Model.ResourceReference))]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.DataType Content
      {
        get { return _Content; }
        set { _Content = value; OnPropertyChanged("Content"); }
      }

      private Hl7.Fhir.Model.DataType _Content;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as PayloadComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Content != null) dest.Content = (Hl7.Fhir.Model.DataType)Content.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new PayloadComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as PayloadComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Content, otherT.Content)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as PayloadComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Content, otherT.Content)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Content != null) yield return Content;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Content != null) yield return new ElementValue("content", Content);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "content":
            value = Content;
            return Content is not null;
          default:
            return base.TryGetValue(key, out value);
        }
      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Content is not null) yield return new KeyValuePair<string,object>("content",Content);
      }

    }

    /// <summary>
    /// Unique identifier
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// Instantiates protocol or definition
    /// </summary>
    [FhirElement("definition", InSummary=true, Order=100)]
    [CLSCompliant(false)]
    [References("PlanDefinition","ActivityDefinition")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Definition
    {
      get { if(_Definition==null) _Definition = new List<Hl7.Fhir.Model.ResourceReference>(); return _Definition; }
      set { _Definition = value; OnPropertyChanged("Definition"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Definition;

    /// <summary>
    /// Request fulfilled by this communication
    /// </summary>
    [FhirElement("basedOn", InSummary=true, Order=110)]
    [CLSCompliant(false)]
    [References("Resource")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> BasedOn
    {
      get { if(_BasedOn==null) _BasedOn = new List<Hl7.Fhir.Model.ResourceReference>(); return _BasedOn; }
      set { _BasedOn = value; OnPropertyChanged("BasedOn"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _BasedOn;

    /// <summary>
    /// Part of this action
    /// </summary>
    [FhirElement("partOf", InSummary=true, Order=120)]
    [CLSCompliant(false)]
    [References("Resource")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> PartOf
    {
      get { if(_PartOf==null) _PartOf = new List<Hl7.Fhir.Model.ResourceReference>(); return _PartOf; }
      set { _PartOf = value; OnPropertyChanged("PartOf"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _PartOf;

    /// <summary>
    /// preparation | in-progress | suspended | aborted | completed | entered-in-error
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=130)]
    [DeclaredType(Type = typeof(Code))]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.EventStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.EventStatus> _StatusElement;

    /// <summary>
    /// preparation | in-progress | suspended | aborted | completed | entered-in-error
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.EventStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.EventStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Communication did not occur
    /// </summary>
    [FhirElement("notDone", InSummary=true, IsModifier=true, Order=140)]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean NotDoneElement
    {
      get { return _NotDoneElement; }
      set { _NotDoneElement = value; OnPropertyChanged("NotDoneElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _NotDoneElement;

    /// <summary>
    /// Communication did not occur
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? NotDone
    {
      get { return NotDoneElement != null ? NotDoneElement.Value : null; }
      set
      {
        if (value == null)
          NotDoneElement = null;
        else
          NotDoneElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("NotDone");
      }
    }

    /// <summary>
    /// Why communication did not occur
    /// </summary>
    [FhirElement("notDoneReason", InSummary=true, Order=150)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept NotDoneReason
    {
      get { return _NotDoneReason; }
      set { _NotDoneReason = value; OnPropertyChanged("NotDoneReason"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _NotDoneReason;

    /// <summary>
    /// Message category
    /// </summary>
    [FhirElement("category", Order=160)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Category
    {
      get { if(_Category==null) _Category = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Category; }
      set { _Category = value; OnPropertyChanged("Category"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Category;

    /// <summary>
    /// A channel of communication
    /// </summary>
    [FhirElement("medium", Order=170)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Medium
    {
      get { if(_Medium==null) _Medium = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Medium; }
      set { _Medium = value; OnPropertyChanged("Medium"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Medium;

    /// <summary>
    /// Focus of message
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=180)]
    [CLSCompliant(false)]
    [References("Patient","Group")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Subject
    {
      get { return _Subject; }
      set { _Subject = value; OnPropertyChanged("Subject"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Subject;

    /// <summary>
    /// Message recipient
    /// </summary>
    [FhirElement("recipient", Order=190)]
    [CLSCompliant(false)]
    [References("Device","Organization","Patient","Practitioner","RelatedPerson","Group")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Recipient
    {
      get { if(_Recipient==null) _Recipient = new List<Hl7.Fhir.Model.ResourceReference>(); return _Recipient; }
      set { _Recipient = value; OnPropertyChanged("Recipient"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Recipient;

    /// <summary>
    /// Focal resources
    /// </summary>
    [FhirElement("topic", Order=200)]
    [CLSCompliant(false)]
    [References("Resource")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Topic
    {
      get { if(_Topic==null) _Topic = new List<Hl7.Fhir.Model.ResourceReference>(); return _Topic; }
      set { _Topic = value; OnPropertyChanged("Topic"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Topic;

    /// <summary>
    /// Encounter or episode leading to message
    /// </summary>
    [FhirElement("context", InSummary=true, Order=210)]
    [CLSCompliant(false)]
    [References("Encounter","EpisodeOfCare")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Context
    {
      get { return _Context; }
      set { _Context = value; OnPropertyChanged("Context"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Context;

    /// <summary>
    /// When sent
    /// </summary>
    [FhirElement("sent", Order=220)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime SentElement
    {
      get { return _SentElement; }
      set { _SentElement = value; OnPropertyChanged("SentElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _SentElement;

    /// <summary>
    /// When sent
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Sent
    {
      get { return SentElement != null ? SentElement.Value : null; }
      set
      {
        if (value == null)
          SentElement = null;
        else
          SentElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("Sent");
      }
    }

    /// <summary>
    /// When received
    /// </summary>
    [FhirElement("received", Order=230)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime ReceivedElement
    {
      get { return _ReceivedElement; }
      set { _ReceivedElement = value; OnPropertyChanged("ReceivedElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _ReceivedElement;

    /// <summary>
    /// When received
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Received
    {
      get { return ReceivedElement != null ? ReceivedElement.Value : null; }
      set
      {
        if (value == null)
          ReceivedElement = null;
        else
          ReceivedElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("Received");
      }
    }

    /// <summary>
    /// Message sender
    /// </summary>
    [FhirElement("sender", Order=240)]
    [CLSCompliant(false)]
    [References("Device","Organization","Patient","Practitioner","RelatedPerson")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Sender
    {
      get { return _Sender; }
      set { _Sender = value; OnPropertyChanged("Sender"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Sender;

    /// <summary>
    /// Indication for message
    /// </summary>
    [FhirElement("reasonCode", InSummary=true, Order=250)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> ReasonCode
    {
      get { if(_ReasonCode==null) _ReasonCode = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ReasonCode; }
      set { _ReasonCode = value; OnPropertyChanged("ReasonCode"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _ReasonCode;

    /// <summary>
    /// Why was communication done?
    /// </summary>
    [FhirElement("reasonReference", InSummary=true, Order=260)]
    [CLSCompliant(false)]
    [References("Condition","Observation")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> ReasonReference
    {
      get { if(_ReasonReference==null) _ReasonReference = new List<Hl7.Fhir.Model.ResourceReference>(); return _ReasonReference; }
      set { _ReasonReference = value; OnPropertyChanged("ReasonReference"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _ReasonReference;

    /// <summary>
    /// Message payload
    /// </summary>
    [FhirElement("payload", Order=270)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Communication.PayloadComponent> Payload
    {
      get { if(_Payload==null) _Payload = new List<Hl7.Fhir.Model.Communication.PayloadComponent>(); return _Payload; }
      set { _Payload = value; OnPropertyChanged("Payload"); }
    }

    private List<Hl7.Fhir.Model.Communication.PayloadComponent> _Payload;

    /// <summary>
    /// Comments made about the communication
    /// </summary>
    [FhirElement("note", Order=280)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Annotation> Note
    {
      get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
      set { _Note = value; OnPropertyChanged("Note"); }
    }

    private List<Hl7.Fhir.Model.Annotation> _Note;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as Communication;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(Definition != null) dest.Definition = new List<Hl7.Fhir.Model.ResourceReference>(Definition.DeepCopy());
      if(BasedOn != null) dest.BasedOn = new List<Hl7.Fhir.Model.ResourceReference>(BasedOn.DeepCopy());
      if(PartOf != null) dest.PartOf = new List<Hl7.Fhir.Model.ResourceReference>(PartOf.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.EventStatus>)StatusElement.DeepCopy();
      if(NotDoneElement != null) dest.NotDoneElement = (Hl7.Fhir.Model.FhirBoolean)NotDoneElement.DeepCopy();
      if(NotDoneReason != null) dest.NotDoneReason = (Hl7.Fhir.Model.CodeableConcept)NotDoneReason.DeepCopy();
      if(Category != null) dest.Category = new List<Hl7.Fhir.Model.CodeableConcept>(Category.DeepCopy());
      if(Medium != null) dest.Medium = new List<Hl7.Fhir.Model.CodeableConcept>(Medium.DeepCopy());
      if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
      if(Recipient != null) dest.Recipient = new List<Hl7.Fhir.Model.ResourceReference>(Recipient.DeepCopy());
      if(Topic != null) dest.Topic = new List<Hl7.Fhir.Model.ResourceReference>(Topic.DeepCopy());
      if(Context != null) dest.Context = (Hl7.Fhir.Model.ResourceReference)Context.DeepCopy();
      if(SentElement != null) dest.SentElement = (Hl7.Fhir.Model.FhirDateTime)SentElement.DeepCopy();
      if(ReceivedElement != null) dest.ReceivedElement = (Hl7.Fhir.Model.FhirDateTime)ReceivedElement.DeepCopy();
      if(Sender != null) dest.Sender = (Hl7.Fhir.Model.ResourceReference)Sender.DeepCopy();
      if(ReasonCode != null) dest.ReasonCode = new List<Hl7.Fhir.Model.CodeableConcept>(ReasonCode.DeepCopy());
      if(ReasonReference != null) dest.ReasonReference = new List<Hl7.Fhir.Model.ResourceReference>(ReasonReference.DeepCopy());
      if(Payload != null) dest.Payload = new List<Hl7.Fhir.Model.Communication.PayloadComponent>(Payload.DeepCopy());
      if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new Communication());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as Communication;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(Definition, otherT.Definition)) return false;
      if( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(NotDoneElement, otherT.NotDoneElement)) return false;
      if( !DeepComparable.Matches(NotDoneReason, otherT.NotDoneReason)) return false;
      if( !DeepComparable.Matches(Category, otherT.Category)) return false;
      if( !DeepComparable.Matches(Medium, otherT.Medium)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
      if( !DeepComparable.Matches(Topic, otherT.Topic)) return false;
      if( !DeepComparable.Matches(Context, otherT.Context)) return false;
      if( !DeepComparable.Matches(SentElement, otherT.SentElement)) return false;
      if( !DeepComparable.Matches(ReceivedElement, otherT.ReceivedElement)) return false;
      if( !DeepComparable.Matches(Sender, otherT.Sender)) return false;
      if( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
      if( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
      if( !DeepComparable.Matches(Payload, otherT.Payload)) return false;
      if( !DeepComparable.Matches(Note, otherT.Note)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as Communication;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
      if( !DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(NotDoneElement, otherT.NotDoneElement)) return false;
      if( !DeepComparable.IsExactly(NotDoneReason, otherT.NotDoneReason)) return false;
      if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
      if( !DeepComparable.IsExactly(Medium, otherT.Medium)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
      if( !DeepComparable.IsExactly(Topic, otherT.Topic)) return false;
      if( !DeepComparable.IsExactly(Context, otherT.Context)) return false;
      if( !DeepComparable.IsExactly(SentElement, otherT.SentElement)) return false;
      if( !DeepComparable.IsExactly(ReceivedElement, otherT.ReceivedElement)) return false;
      if( !DeepComparable.IsExactly(Sender, otherT.Sender)) return false;
      if( !DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
      if( !DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
      if( !DeepComparable.IsExactly(Payload, otherT.Payload)) return false;
      if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        foreach (var elem in Definition) { if (elem != null) yield return elem; }
        foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
        foreach (var elem in PartOf) { if (elem != null) yield return elem; }
        if (StatusElement != null) yield return StatusElement;
        if (NotDoneElement != null) yield return NotDoneElement;
        if (NotDoneReason != null) yield return NotDoneReason;
        foreach (var elem in Category) { if (elem != null) yield return elem; }
        foreach (var elem in Medium) { if (elem != null) yield return elem; }
        if (Subject != null) yield return Subject;
        foreach (var elem in Recipient) { if (elem != null) yield return elem; }
        foreach (var elem in Topic) { if (elem != null) yield return elem; }
        if (Context != null) yield return Context;
        if (SentElement != null) yield return SentElement;
        if (ReceivedElement != null) yield return ReceivedElement;
        if (Sender != null) yield return Sender;
        foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
        foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
        foreach (var elem in Payload) { if (elem != null) yield return elem; }
        foreach (var elem in Note) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        foreach (var elem in Definition) { if (elem != null) yield return new ElementValue("definition", elem); }
        foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
        foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (NotDoneElement != null) yield return new ElementValue("notDone", NotDoneElement);
        if (NotDoneReason != null) yield return new ElementValue("notDoneReason", NotDoneReason);
        foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
        foreach (var elem in Medium) { if (elem != null) yield return new ElementValue("medium", elem); }
        if (Subject != null) yield return new ElementValue("subject", Subject);
        foreach (var elem in Recipient) { if (elem != null) yield return new ElementValue("recipient", elem); }
        foreach (var elem in Topic) { if (elem != null) yield return new ElementValue("topic", elem); }
        if (Context != null) yield return new ElementValue("context", Context);
        if (SentElement != null) yield return new ElementValue("sent", SentElement);
        if (ReceivedElement != null) yield return new ElementValue("received", ReceivedElement);
        if (Sender != null) yield return new ElementValue("sender", Sender);
        foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
        foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
        foreach (var elem in Payload) { if (elem != null) yield return new ElementValue("payload", elem); }
        foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "definition":
          value = Definition;
          return Definition?.Any() == true;
        case "basedOn":
          value = BasedOn;
          return BasedOn?.Any() == true;
        case "partOf":
          value = PartOf;
          return PartOf?.Any() == true;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "notDone":
          value = NotDoneElement;
          return NotDoneElement is not null;
        case "notDoneReason":
          value = NotDoneReason;
          return NotDoneReason is not null;
        case "category":
          value = Category;
          return Category?.Any() == true;
        case "medium":
          value = Medium;
          return Medium?.Any() == true;
        case "subject":
          value = Subject;
          return Subject is not null;
        case "recipient":
          value = Recipient;
          return Recipient?.Any() == true;
        case "topic":
          value = Topic;
          return Topic?.Any() == true;
        case "context":
          value = Context;
          return Context is not null;
        case "sent":
          value = SentElement;
          return SentElement is not null;
        case "received":
          value = ReceivedElement;
          return ReceivedElement is not null;
        case "sender":
          value = Sender;
          return Sender is not null;
        case "reasonCode":
          value = ReasonCode;
          return ReasonCode?.Any() == true;
        case "reasonReference":
          value = ReasonReference;
          return ReasonReference?.Any() == true;
        case "payload":
          value = Payload;
          return Payload?.Any() == true;
        case "note":
          value = Note;
          return Note?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }
    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (Definition?.Any() == true) yield return new KeyValuePair<string,object>("definition",Definition);
      if (BasedOn?.Any() == true) yield return new KeyValuePair<string,object>("basedOn",BasedOn);
      if (PartOf?.Any() == true) yield return new KeyValuePair<string,object>("partOf",PartOf);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (NotDoneElement is not null) yield return new KeyValuePair<string,object>("notDone",NotDoneElement);
      if (NotDoneReason is not null) yield return new KeyValuePair<string,object>("notDoneReason",NotDoneReason);
      if (Category?.Any() == true) yield return new KeyValuePair<string,object>("category",Category);
      if (Medium?.Any() == true) yield return new KeyValuePair<string,object>("medium",Medium);
      if (Subject is not null) yield return new KeyValuePair<string,object>("subject",Subject);
      if (Recipient?.Any() == true) yield return new KeyValuePair<string,object>("recipient",Recipient);
      if (Topic?.Any() == true) yield return new KeyValuePair<string,object>("topic",Topic);
      if (Context is not null) yield return new KeyValuePair<string,object>("context",Context);
      if (SentElement is not null) yield return new KeyValuePair<string,object>("sent",SentElement);
      if (ReceivedElement is not null) yield return new KeyValuePair<string,object>("received",ReceivedElement);
      if (Sender is not null) yield return new KeyValuePair<string,object>("sender",Sender);
      if (ReasonCode?.Any() == true) yield return new KeyValuePair<string,object>("reasonCode",ReasonCode);
      if (ReasonReference?.Any() == true) yield return new KeyValuePair<string,object>("reasonReference",ReasonReference);
      if (Payload?.Any() == true) yield return new KeyValuePair<string,object>("payload",Payload);
      if (Note?.Any() == true) yield return new KeyValuePair<string,object>("note",Note);
    }

  }

}

// end of file

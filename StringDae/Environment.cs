//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StringDae
{
    using System;
    using System.Collections.Generic;
    
    public partial class Environment
    {
        public Environment()
        {
            this.ENTITY_INVESTIGATION_ENVIRONMENT = new HashSet<ENTITY_INVESTIGATION_ENVIRONMENT>();
            this.ENTITY_NOTES = new HashSet<ENTITY_NOTES>();
            this.ENTITY_QUESTIONS = new HashSet<ENTITY_QUESTIONS>();
            this.ENTITY_REFERENCE_SOURCE = new HashSet<ENTITY_REFERENCE_SOURCE>();
            this.EVENTS = new HashSet<EVENT>();
            this.GROUP_EVENT = new HashSet<GROUP_EVENT>();
            this.GROUPS = new HashSet<GROUP>();
            this.Investigations = new HashSet<Investigation>();
            this.LOCATION_EVENT = new HashSet<LOCATION_EVENT>();
            this.LOCATION_PERSON = new HashSet<LOCATION_PERSON>();
            this.LOCATION_OBJECT = new HashSet<LOCATION_OBJECT>();
            this.LOCATION_GROUP = new HashSet<LOCATION_GROUP>();
            this.LOCATIONS = new HashSet<LOCATION>();
            this.NOTES = new HashSet<NOTE>();
            this.OBJECT_EVENT = new HashSet<OBJECT_EVENT>();
            this.OBJECT_GROUP = new HashSet<OBJECT_GROUP>();
            this.OBJECTS = new HashSet<OBJECT>();
            this.PERSON_ATTRIBUTION = new HashSet<PERSON_ATTRIBUTION>();
            this.PERSON_EVENT = new HashSet<PERSON_EVENT>();
            this.PERSON_GROUP = new HashSet<PERSON_GROUP>();
            this.PERSON_OBJECT = new HashSet<PERSON_OBJECT>();
            this.PERSON_PERSON = new HashSet<PERSON_PERSON>();
            this.PERSONS = new HashSet<PERSON>();
            this.QUESTIONS = new HashSet<QUESTION>();
            this.REFERENCE_SOURCE = new HashSet<REFERENCE_SOURCE>();
            this.RELATIONSHIPs = new HashSet<RELATIONSHIP>();
            this.TIMELINE_EVENT = new HashSet<TIMELINE_EVENT>();
            this.TIMELINES = new HashSet<TIMELINE>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime Created_date { get; set; }
        public int Created_by { get; set; }
        public Nullable<int> Modified_by { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
    
        public virtual ICollection<ENTITY_INVESTIGATION_ENVIRONMENT> ENTITY_INVESTIGATION_ENVIRONMENT { get; set; }
        public virtual ICollection<ENTITY_NOTES> ENTITY_NOTES { get; set; }
        public virtual ICollection<ENTITY_QUESTIONS> ENTITY_QUESTIONS { get; set; }
        public virtual ICollection<ENTITY_REFERENCE_SOURCE> ENTITY_REFERENCE_SOURCE { get; set; }
        public virtual ICollection<EVENT> EVENTS { get; set; }
        public virtual ICollection<GROUP_EVENT> GROUP_EVENT { get; set; }
        public virtual ICollection<GROUP> GROUPS { get; set; }
        public virtual ICollection<Investigation> Investigations { get; set; }
        public virtual ICollection<LOCATION_EVENT> LOCATION_EVENT { get; set; }
        public virtual ICollection<LOCATION_PERSON> LOCATION_PERSON { get; set; }
        public virtual ICollection<LOCATION_OBJECT> LOCATION_OBJECT { get; set; }
        public virtual ICollection<LOCATION_GROUP> LOCATION_GROUP { get; set; }
        public virtual ICollection<LOCATION> LOCATIONS { get; set; }
        public virtual ICollection<NOTE> NOTES { get; set; }
        public virtual ICollection<OBJECT_EVENT> OBJECT_EVENT { get; set; }
        public virtual ICollection<OBJECT_GROUP> OBJECT_GROUP { get; set; }
        public virtual ICollection<OBJECT> OBJECTS { get; set; }
        public virtual ICollection<PERSON_ATTRIBUTION> PERSON_ATTRIBUTION { get; set; }
        public virtual ICollection<PERSON_EVENT> PERSON_EVENT { get; set; }
        public virtual ICollection<PERSON_GROUP> PERSON_GROUP { get; set; }
        public virtual ICollection<PERSON_OBJECT> PERSON_OBJECT { get; set; }
        public virtual ICollection<PERSON_PERSON> PERSON_PERSON { get; set; }
        public virtual ICollection<PERSON> PERSONS { get; set; }
        public virtual ICollection<QUESTION> QUESTIONS { get; set; }
        public virtual ICollection<REFERENCE_SOURCE> REFERENCE_SOURCE { get; set; }
        public virtual ICollection<RELATIONSHIP> RELATIONSHIPs { get; set; }
        public virtual ICollection<TIMELINE_EVENT> TIMELINE_EVENT { get; set; }
        public virtual ICollection<TIMELINE> TIMELINES { get; set; }
    }
}

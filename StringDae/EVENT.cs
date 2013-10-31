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
    
    public partial class EVENT
    {
        public EVENT()
        {
            this.ENTITY_INVESTIGATION_ENVIRONMENT = new HashSet<ENTITY_INVESTIGATION_ENVIRONMENT>();
            this.ENTITY_NOTES = new HashSet<ENTITY_NOTES>();
            this.ENTITY_QUESTIONS = new HashSet<ENTITY_QUESTIONS>();
            this.ENTITY_REFERENCE_SOURCE = new HashSet<ENTITY_REFERENCE_SOURCE>();
            this.GROUP_EVENT = new HashSet<GROUP_EVENT>();
            this.LOCATION_EVENT = new HashSet<LOCATION_EVENT>();
            this.OBJECT_EVENT = new HashSet<OBJECT_EVENT>();
            this.PERSON_EVENT = new HashSet<PERSON_EVENT>();
            this.TIMELINE_EVENT = new HashSet<TIMELINE_EVENT>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string EVENT_TYPE { get; set; }
        public Nullable<System.DateTime> EVENT_AT { get; set; }
        public Nullable<System.DateTime> EVENT_TO { get; set; }
        public Nullable<int> ID_IRS { get; set; }
        public Nullable<int> ID_IS { get; set; }
        public System.DateTime Created_date { get; set; }
        public int Created_by { get; set; }
        public Nullable<int> Modified_by { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
        public int ID_ENVIRONMENT { get; set; }
    
        public virtual ICollection<ENTITY_INVESTIGATION_ENVIRONMENT> ENTITY_INVESTIGATION_ENVIRONMENT { get; set; }
        public virtual ICollection<ENTITY_NOTES> ENTITY_NOTES { get; set; }
        public virtual ICollection<ENTITY_QUESTIONS> ENTITY_QUESTIONS { get; set; }
        public virtual ICollection<ENTITY_REFERENCE_SOURCE> ENTITY_REFERENCE_SOURCE { get; set; }
        public virtual Environment Environment { get; set; }
        public virtual InvestigationRelationship_status InvestigationRelationship_status { get; set; }
        public virtual Investigation_status Investigation_status { get; set; }
        public virtual ICollection<GROUP_EVENT> GROUP_EVENT { get; set; }
        public virtual ICollection<LOCATION_EVENT> LOCATION_EVENT { get; set; }
        public virtual ICollection<OBJECT_EVENT> OBJECT_EVENT { get; set; }
        public virtual ICollection<PERSON_EVENT> PERSON_EVENT { get; set; }
        public virtual ICollection<TIMELINE_EVENT> TIMELINE_EVENT { get; set; }
    }
}

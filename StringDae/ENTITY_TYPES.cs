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
    
    public partial class ENTITY_TYPES
    {
        public ENTITY_TYPES()
        {
            this.ENTITY_INVESTIGATION_ENVIRONMENT = new HashSet<ENTITY_INVESTIGATION_ENVIRONMENT>();
            this.ENTITY_NOTES = new HashSet<ENTITY_NOTES>();
            this.ENTITY_QUESTIONS = new HashSet<ENTITY_QUESTIONS>();
            this.ENTITY_REFERENCE_SOURCE = new HashSet<ENTITY_REFERENCE_SOURCE>();
        }
    
        public string ENTITY_TYPE { get; set; }
        public System.DateTime Created_date { get; set; }
        public int Created_by { get; set; }
        public Nullable<int> Modified_by { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
    
        public virtual ICollection<ENTITY_INVESTIGATION_ENVIRONMENT> ENTITY_INVESTIGATION_ENVIRONMENT { get; set; }
        public virtual ICollection<ENTITY_NOTES> ENTITY_NOTES { get; set; }
        public virtual ICollection<ENTITY_QUESTIONS> ENTITY_QUESTIONS { get; set; }
        public virtual ICollection<ENTITY_REFERENCE_SOURCE> ENTITY_REFERENCE_SOURCE { get; set; }
    }
}

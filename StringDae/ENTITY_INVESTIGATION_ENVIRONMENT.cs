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
    
    public partial class ENTITY_INVESTIGATION_ENVIRONMENT
    {
        public int ID { get; set; }
        public string REASON_FOR_INCLUSION { get; set; }
        public string ENTITY_TYPE { get; set; }
        public Nullable<int> ID_NOTE { get; set; }
        public Nullable<int> ID_EVENT { get; set; }
        public Nullable<int> ID_LOCATION { get; set; }
        public Nullable<int> ID_PERSON { get; set; }
        public Nullable<int> ID_OBJECT { get; set; }
        public Nullable<int> ID_GROUP { get; set; }
        public Nullable<int> ID_QUESTIONS { get; set; }
        public System.DateTime Created_date { get; set; }
        public int Created_by { get; set; }
        public Nullable<int> Modified_by { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
        public Nullable<int> ID_ENVIRONMENT { get; set; }
        public Nullable<int> ID_INVESTIGATION { get; set; }
    
        public virtual ENTITY_TYPES ENTITY_TYPES { get; set; }
        public virtual Environment Environment { get; set; }
        public virtual EVENT EVENT { get; set; }
        public virtual GROUP GROUP { get; set; }
        public virtual Investigation Investigation { get; set; }
        public virtual LOCATION LOCATION { get; set; }
        public virtual NOTE NOTE { get; set; }
        public virtual OBJECT OBJECT { get; set; }
        public virtual PERSON PERSON { get; set; }
        public virtual QUESTION QUESTION { get; set; }
    }
}

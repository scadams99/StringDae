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
    
    public partial class OBJECT_EVENT
    {
        public int ID { get; set; }
        public string OE_RELATIONSHIP { get; set; }
        public int ID_EVENT { get; set; }
        public int ID_OBJECT { get; set; }
        public System.DateTime Created_date { get; set; }
        public int Created_by { get; set; }
        public Nullable<int> Modified_by { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
        public Nullable<int> ID_INVESTIGATION { get; set; }
        public int ID_ENVIRONMENT { get; set; }
    
        public virtual Environment Environment { get; set; }
        public virtual EVENT EVENT { get; set; }
        public virtual Investigation Investigation { get; set; }
        public virtual OBJECT OBJECT { get; set; }
    }
}

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
    
    public partial class LOCATION_PERSON_TYPE
    {
        public LOCATION_PERSON_TYPE()
        {
            this.LOCATION_PERSON = new HashSet<LOCATION_PERSON>();
        }
    
        public string LP_TYPE { get; set; }
        public string DESCRIPTION { get; set; }
        public System.DateTime Created_date { get; set; }
        public int Created_by { get; set; }
        public Nullable<int> Modified_by { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
    
        public virtual ICollection<LOCATION_PERSON> LOCATION_PERSON { get; set; }
    }
}

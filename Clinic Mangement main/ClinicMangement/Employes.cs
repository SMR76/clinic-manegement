//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicMangement
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employes
    {
        public Employes()
        {
            this.CallTheRoll = new HashSet<CallTheRoll>();
            this.Visit = new HashSet<Visit>();
        }
    
        public int id { get; set; }
        public int EmployesType { get; set; }
        public string name { get; set; }
        public string lname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<CallTheRoll> CallTheRoll { get; set; }
        public virtual EmployesType EmployesType1 { get; set; }
        public virtual ICollection<Visit> Visit { get; set; }
    }
}

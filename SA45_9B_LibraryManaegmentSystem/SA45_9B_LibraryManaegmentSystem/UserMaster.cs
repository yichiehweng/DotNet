//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA45_9B_LibraryManaegmentSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserMaster
    {
        public string EmployeeID { get; set; }
        public string LoginName { get; set; }
        public string UserPassWord { get; set; }
        public string UserPhoneNumber { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
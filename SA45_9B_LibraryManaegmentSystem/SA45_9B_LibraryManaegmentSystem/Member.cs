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
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.IssueTrans = new HashSet<IssueTran>();
        }
    
        public string MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberCategory { get; set; }
        public string PhoneNumber { get; set; }
        public string PostAddress { get; set; }
        public string PostalCode { get; set; }
        public string EmailAddress { get; set; }
        public string Notes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssueTran> IssueTrans { get; set; }
    }
}

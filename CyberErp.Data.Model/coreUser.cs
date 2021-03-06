//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CyberErp.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class coreUser
    {
        public coreUser()
        {
            this.coreUserSubsystem = new HashSet<coreUserSubsystem>();
            this.iffsUserOperationTypeMapping = new HashSet<iffsUserOperationTypeMapping>();
            this.coreUserRole = new HashSet<coreUserRole>();
        }
    
        public int Id { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public bool IsRevoked { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] LastUpdated { get; set; }
    
        public virtual ICollection<coreUserSubsystem> coreUserSubsystem { get; set; }
        public virtual ICollection<iffsUserOperationTypeMapping> iffsUserOperationTypeMapping { get; set; }
        public virtual ICollection<coreUserRole> coreUserRole { get; set; }
    }
}

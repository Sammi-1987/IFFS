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
    
    public partial class iffsUserOperationTypeMapping
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] LastUpdated { get; set; }
    
        public virtual coreUser coreUser { get; set; }
        public virtual iffsLupOperationType iffsLupOperationType { get; set; }
    }
}

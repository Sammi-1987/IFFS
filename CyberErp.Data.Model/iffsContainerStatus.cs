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
    
    public partial class iffsContainerStatus
    {
        public int Id { get; set; }
        public int ContainerId { get; set; }
        public int StatusId { get; set; }
        public string Value { get; set; }
        public string Remark { get; set; }
        public byte[] LastUpdated { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual iffsContainer iffsContainer { get; set; }
        public virtual iffsContainerStatusTemplate iffsContainerStatusTemplate { get; set; }
    }
}

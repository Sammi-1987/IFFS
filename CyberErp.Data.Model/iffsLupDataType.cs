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
    
    public partial class iffsLupDataType
    {
        public iffsLupDataType()
        {
            this.iffsOperationStatusTemplate = new HashSet<iffsOperationStatusTemplate>();
            this.iffsContainerStatusTemplate = new HashSet<iffsContainerStatusTemplate>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] LastUpdated { get; set; }
    
        public virtual ICollection<iffsOperationStatusTemplate> iffsOperationStatusTemplate { get; set; }
        public virtual ICollection<iffsContainerStatusTemplate> iffsContainerStatusTemplate { get; set; }
    }
}

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
    
    public partial class iffsCrateAndBoxRequestDetail
    {
        public iffsCrateAndBoxRequestDetail()
        {
            this.iffsPackingCrateAndBoxConsumption = new HashSet<iffsPackingCrateAndBoxConsumption>();
        }
    
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public int BoxType { get; set; }
        public int Qty { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public int MeasurmentId { get; set; }
        public string Remark { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] LastUpdated { get; set; }
    
        public virtual iffsCrateAndBoxRequestHeader iffsCrateAndBoxRequestHeader { get; set; }
        public virtual iffsLupBoxType iffsLupBoxType { get; set; }
        public virtual ICollection<iffsPackingCrateAndBoxConsumption> iffsPackingCrateAndBoxConsumption { get; set; }
    }
}

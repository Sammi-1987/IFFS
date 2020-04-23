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
    
    public partial class iffsPackingMaterialList
    {
        public iffsPackingMaterialList()
        {
            this.iffsPackingMaterial = new HashSet<iffsPackingMaterial>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MeasurmentUnit { get; set; }
        public Nullable<decimal> Length { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> SizeCMB { get; set; }
        public MaterialType MaterialType { get; set; }
        public string Remark { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] LastUpdated { get; set; }
    
        public virtual lupMeasurementUnit lupMeasurementUnit { get; set; }
        public virtual ICollection<iffsPackingMaterial> iffsPackingMaterial { get; set; }
    }
}
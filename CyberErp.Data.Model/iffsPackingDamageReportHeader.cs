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
    
    public partial class iffsPackingDamageReportHeader
    {
        public iffsPackingDamageReportHeader()
        {
            this.iffsPackingDamageReportDetail = new HashSet<iffsPackingDamageReportDetail>();
        }
    
        public int Id { get; set; }
        public int OperationId { get; set; }
        public int ClientId { get; set; }
        public int SuprvisorId { get; set; }
        public string ShippersName { get; set; }
        public string DeliveryAddress { get; set; }
        public string OriginCountry { get; set; }
        public string Remarks { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] LastUpdated { get; set; }
    
        public virtual hrmsEmployee hrmsEmployee { get; set; }
        public virtual iffsCustomer iffsCustomer { get; set; }
        public virtual iffsOperation iffsOperation { get; set; }
        public virtual ICollection<iffsPackingDamageReportDetail> iffsPackingDamageReportDetail { get; set; }
    }
}

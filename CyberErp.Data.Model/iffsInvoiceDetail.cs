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
    
    public partial class iffsInvoiceDetail
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceDescription { get; set; }
        public int ServiceUnitTypeId { get; set; }
        public decimal Quantity { get; set; }
        public int CurrencyId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Remark { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] LastUpdated { get; set; }
    
        public virtual iffsLupCurrency iffsLupCurrency { get; set; }
        public virtual iffsLupServiceUnitType iffsLupServiceUnitType { get; set; }
        public virtual iffsService iffsService { get; set; }
        public virtual iffsInvoiceHeader iffsInvoiceHeader { get; set; }
    }
}
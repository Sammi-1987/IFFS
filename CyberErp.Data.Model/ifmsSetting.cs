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
    
    public partial class ifmsSetting
    {
        public int Id { get; set; }
        public Nullable<int> CurrentFiscalYearId { get; set; }
        public Nullable<int> CurrentPeriodId { get; set; }
        public Nullable<int> IncomeSummaryAccountId { get; set; }
        public Nullable<int> ClosingCapitalAccountId { get; set; }
        public Nullable<int> DefaultCostCenterId { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] LastUpdated { get; set; }
    }
}
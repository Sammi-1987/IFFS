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
    
    public partial class iffsCrateAndBoxRequestHeader
    {
        public iffsCrateAndBoxRequestHeader()
        {
            this.iffsCrateAndBoxRequestDetail = new HashSet<iffsCrateAndBoxRequestDetail>();
        }
    
        public int Id { get; set; }
        public int OperationId { get; set; }
        public int SurveyId { get; set; }
        public string OrderNumber { get; set; }
        public string PrevOrderNumber { get; set; }
        public System.DateTime RequestedDate { get; set; }
        public System.DateTime ExpectedDelivery { get; set; }
        public int PreparedBy { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public System.DateTime PreparedDate { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public bool IsIronSheetCover { get; set; }
        public bool IsApproved { get; set; }
        public bool IsChecked { get; set; }
        public bool HasPrevOrderNumber { get; set; }
        public string Remark { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] LastUpdated { get; set; }
    
        public virtual hrmsEmployee hrmsEmployeeApprovedBy { get; set; }
        public virtual hrmsEmployee hrmsEmployeePreparedBy { get; set; }
        public virtual ICollection<iffsCrateAndBoxRequestDetail> iffsCrateAndBoxRequestDetail { get; set; }
        public virtual iffsOperation iffsOperation { get; set; }
        public virtual iffsSurveyRequest iffsSurveyRequest { get; set; }
    }
}

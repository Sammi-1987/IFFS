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
    
    public partial class iffsPackingSurveyHeader
    {
        public iffsPackingSurveyHeader()
        {
            this.iffsPackingSurveyDetail = new HashSet<iffsPackingSurveyDetail>();
            this.iffsSurveyServiceRequest = new HashSet<iffsSurveyServiceRequest>();
            this.iffsPackingMaterial = new HashSet<iffsPackingMaterial>();
        }
    
        public int Id { get; set; }
        public int SurveyRequestId { get; set; }
        public int SurveyedById { get; set; }
        public int ClientStatusId { get; set; }
        public string DestinationCountry { get; set; }
        public string DestinationAddress { get; set; }
        public string DestinationPort { get; set; }
        public System.DateTime SurveyDate { get; set; }
        public System.DateTime DepartureDate { get; set; }
        public System.DateTime PackingDate { get; set; }
        public int EstimatedStuffQty { get; set; }
        public bool IsPacking { get; set; }
        public bool IsMoving { get; set; }
        public bool IsCustomClearance { get; set; }
        public bool IsAir { get; set; }
        public bool IsOcean { get; set; }
        public bool IsDoorToDoor { get; set; }
        public bool IsDoorToPort { get; set; }
        public bool IsViewed { get; set; }
        public Nullable<decimal> CBMAir { get; set; }
        public Nullable<decimal> CBMOcean { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] LastUpdated { get; set; }
    
        public virtual hrmsEmployee hrmsEmployee { get; set; }
        public virtual iffsLupClientStatus iffsLupClientStatus { get; set; }
        public virtual ICollection<iffsPackingSurveyDetail> iffsPackingSurveyDetail { get; set; }
        public virtual iffsSurveyRequest iffsSurveyRequest { get; set; }
        public virtual ICollection<iffsSurveyServiceRequest> iffsSurveyServiceRequest { get; set; }
        public virtual ICollection<iffsPackingMaterial> iffsPackingMaterial { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seratio.Blockchain.Sandbox.Models
{
    using System;

    public partial class Investment
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public Nullable<int> UserSessionID { get; set; }
        public Nullable<int> LastUpdatedByID { get; set; }
        public string Mode { get; set; }
        public decimal Amount { get; set; }
        public string Token { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Comments { get; set; }
        public string TxReferenceNumber { get; set; }
        public System.DateTime InitializedOn { get; set; }
        public Nullable<System.DateTime> TxRefNoUpdatedOn { get; set; }
        public Nullable<decimal> ReceivedAmount { get; set; }
        public string ExchangeRate { get; set; }
        public Nullable<System.Guid> InvestmentID { get; set; }
        public string TokenAmount { get; set; }
        public string OriginalExchangeRate { get; set; }
        public string InvestmentType { get; set; }
        public string CampaignCode { get; set; }
        public bool HasAcceptedTAndCs { get; set; }
        public Nullable<bool> HasTransferred { get; set; }
        public Nullable<System.DateTime> ConfirmedOn { get; set; }
        public Nullable<System.DateTime> RejectedOn { get; set; }
        public Nullable<System.DateTime> IssuedOn { get; set; }
        public System.DateTime LastUpdatedOn { get; set; }
    
        public virtual Administrator Administrator { get; set; }
        public virtual User User { get; set; }
        public virtual UserSession UserSession { get; set; }
    }
}

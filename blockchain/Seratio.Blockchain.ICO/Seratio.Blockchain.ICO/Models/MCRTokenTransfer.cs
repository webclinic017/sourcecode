//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seratio.Platform.ICO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MCRTokenTransfer
    {
        public int ID { get; set; }
        public string WalletAddress { get; set; }
        public decimal Amount { get; set; }
        public string TxHash { get; set; }
        public string Status { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> QueuedOn { get; set; }
        public Nullable<System.DateTime> TransferStartedOn { get; set; }
        public Nullable<System.DateTime> TransferredOn { get; set; }
    }
}

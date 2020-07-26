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
    using System.Collections.Generic;
    
    public partial class MCRTransfer
    {
        public int ID { get; set; }
        public int CoinID { get; set; }
        public int SenderID { get; set; }
        public int RecipientID { get; set; }
        public int WalletTransactionID { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime Time { get; set; }
        public bool HasProcessed { get; set; }
    
        public virtual Coin Coin { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual WalletTransaction WalletTransaction { get; set; }
    }
}
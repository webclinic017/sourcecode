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
    
    public partial class ExchangeRate
    {
        public int ID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string ExchangePrice { get; set; }
        public System.DateTime Time { get; set; }
    }
}

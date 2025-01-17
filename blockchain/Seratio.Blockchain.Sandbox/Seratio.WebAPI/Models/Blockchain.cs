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
    
    public partial class Blockchain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Blockchain()
        {
            this.Coins = new HashSet<Coin>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Host { get; set; }
        public string VaultContractAddress { get; set; }
        public string VaultContractABI { get; set; }
        public bool IsActive { get; set; }
        public bool IsPrimaryNode { get; set; }
        public string Comments { get; set; }
        public bool IsDataActive { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime LastUpdatedOn { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Coin> Coins { get; set; }
    }
}

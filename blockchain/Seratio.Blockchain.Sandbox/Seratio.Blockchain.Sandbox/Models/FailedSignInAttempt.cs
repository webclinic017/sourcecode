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
    public partial class FailedSignInAttempt
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public System.DateTime Time { get; set; }
    
        public virtual User User { get; set; }
    }
}

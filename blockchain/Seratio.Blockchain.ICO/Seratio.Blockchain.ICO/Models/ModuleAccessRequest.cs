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
    
    public partial class ModuleAccessRequest
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public Nullable<int> ProcessedBy { get; set; }
        public string Module { get; set; }
        public string Message { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
        public Nullable<System.DateTime> RejectedOn { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}

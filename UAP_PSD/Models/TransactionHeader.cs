//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UAP_PSD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionHeader
    {
        public int TransactionID { get; set; }
        public int UserID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string Status { get; set; }
    
        public virtual MsUser MsUser { get; set; }
        public virtual TransactionDetail TransactionDetail { get; set; }
    }
}

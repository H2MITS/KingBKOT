//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KingBKOT.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class billAndSettlement
    {
        public string kot { get; set; }
        public string orderDecrip { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public System.DateTime ordDate { get; set; }
        public string ordTime { get; set; }
        public decimal totalDue { get; set; }
        public decimal tax1_Amt { get; set; }
        public decimal tax2_Amt { get; set; }
        public decimal subTotal { get; set; }
        public string mode { get; set; }
        public string empID { get; set; }
        public string couponCode { get; set; }
        public Nullable<decimal> discount { get; set; }
    }
}

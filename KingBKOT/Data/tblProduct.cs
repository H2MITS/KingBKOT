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
    
    public partial class tblProduct
    {
        public int prodID { get; set; }
        public string proName { get; set; }
        public string prodTypeName { get; set; }
        public string proType { get; set; }
        public string proDescrip { get; set; }
        public string tax_1 { get; set; }
        public string tax_2 { get; set; }
        public string tax_3 { get; set; }
        public string proPrice { get; set; }
        public string tax_1Amt { get; set; }
        public string tax_2Amt { get; set; }
        public string tax_3Amt { get; set; }
        public string proNetPrice { get; set; }
        public string qty { get; set; }
        public Nullable<bool> Statues { get; set; }
        public string Reason { get; set; }
        public Nullable<long> prodTypeId { get; set; }
    
        public virtual tblProType tblProType { get; set; }
    }
}

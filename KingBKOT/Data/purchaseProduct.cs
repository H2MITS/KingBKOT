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
    
    public partial class purchaseProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public purchaseProduct()
        {
            this.tbl_PurchaseDetails = new HashSet<tbl_PurchaseDetails>();
            this.tblPurchaseOrders = new HashSet<tblPurchaseOrder>();
        }
    
        public long id { get; set; }
        public string pName { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<decimal> weight { get; set; }
        public string unit { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<decimal> rate { get; set; }
        public Nullable<decimal> totalAmt { get; set; }
        public Nullable<System.DateTime> cdate { get; set; }
        public Nullable<System.DateTime> udate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PurchaseDetails> tbl_PurchaseDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPurchaseOrder> tblPurchaseOrders { get; set; }
    }
}

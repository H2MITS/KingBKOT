using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingBKOT.ViewModel
{
   public class PurchaseDetailsVM
    { 
        public int rowNo{ get; set; }
        public long pdetailsId { get; set; }
        public Nullable<long> purchaseID { get; set; }
        public Nullable<long> productID { get; set; }
        public string productName { get; set; }
        public Nullable<decimal> qty { get; set; }
        public string weight { get; set; }
        public string unit { get; set; }
        public Nullable<decimal> rate { get; set; }
        public string createdDate { get; set; }
        public string updatedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingBKOT.ViewModel
{
   public class PurchaseMasterVM
    {
        public int rowNo { get; set; }
        public long pId { get; set; }
        public string refNo { get; set; }
        public string partyName { get; set; }
        public string date { get; set; }
        public Nullable<decimal> totalWeight { get; set; }
        public string unit { get; set; }
        public Nullable<decimal> totalAmt { get; set; }
        public string remarks { get; set; }
        public string createdDate { get; set; }
        public string updateDate { get; set; }
        public string monthYear { get; set; }
        public string KOT { get; set; }
        public decimal totalAmount { get; set; }

    }
}

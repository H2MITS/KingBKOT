using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingBKOT.ViewModel
{
   public class billAndSettlementVM
    {
        public string kot { get; set; }
        public string guestName{ get; set; }
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

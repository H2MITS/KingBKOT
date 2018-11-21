using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingBKOT.ViewModel
{
   public class DetailSettlementVM
    {
        public int rowNo { get; set; }
        public string KOT { get; set; }
        public string monthYear { get; set; } 
        public decimal totalAmount { get; set; }
        public System.DateTime paidDate { get; set; }
        public string paidTime { get; set; }
        public string currencyInUsed { get; set; }
        public decimal bill { get; set; }
        public string custCurrencyChosen { get; set; }
        public decimal AmountPaid { get; set; }
        public Nullable<decimal> changeDue { get; set; }
        public string paymentType { get; set; }
        public string acctName { get; set; }
        public string acctNum { get; set; }
        public string electronicType { get; set; }
        public string empID { get; set; }

        public decimal? advancePaid{ get; set; }
    }
}

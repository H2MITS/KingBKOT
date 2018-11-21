using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingBKOT.ViewModel
{
   public class ExpensesVM
    {
        public long rowNo { get; set; }
        public long id { get; set; }
        public string expName { get; set; }
        public string expDate { get; set; }
        public decimal? amount { get; set; }
        public string expBy { get; set; }
        public Nullable<System.DateTime> cdate { get; set; }
        public Nullable<System.DateTime> udate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingBKOT.ViewModel
{
    public class advBookingVM
    {
        public long id { get; set; }
        public int rowNo{ get; set; }
        public string custName { get; set; }

        public string mob { get; set; }
        public string eventDate { get; set; }
        public Nullable<int> adults { get; set; }
        public Nullable<int> child { get; set; }
        public Nullable<decimal> advancePayment { get; set; }
        public Nullable<decimal> totalPayment { get; set; }
        public string status { get; set; }
        public string cdate { get; set; }
        public Nullable<System.DateTime> udate { get; set; }
        public string recptNo { get; set; }
    }
}

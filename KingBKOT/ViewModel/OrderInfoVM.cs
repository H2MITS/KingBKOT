using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingBKOT.ViewModel
{
   public class OrderInfoVM
    {
        public string orderType { get; set; }
        public string tableNo { get; set; }
        public string KOT { get; set; }
        public System.DateTime ordDate { get; set; }
        public string ordTime { get; set; }
        public string mobile { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string adultNo { get; set; }
        public string childrenNo { get; set; }
        public string empID { get; set; }
        public string empName { get; set; }
        public string guests { get; set; }
        public string mode { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingBKOT.ViewModel
{
    public class PurchaseProductVM
    {
        public int rowNo { get; set; }
        public int id { get; set; }
        public string pName { get; set; }
        public string date { get; set; }
        public string weight { get; set; }
        public string unit { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<decimal> rate { get; set; }
        public Nullable<decimal> totalAmt { get; set; }
        public string cdate { get; set; }
        public string udate { get; set; }
    }
}

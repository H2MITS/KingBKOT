using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingBKOT.ViewModel
{
    public class SalesPrintVM
    {
        public int rowId { get; set; }
        public string monthYear { get; set; }
        public string ReceiptNoKOT{ get; set; }
        public decimal totalAmount { get; set; }
        public decimal AmountPaid { get; set; }
    }
}

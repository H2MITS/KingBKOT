using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingBKOT.ViewModel
{
   public class ProductsVM
    {
        public long rowNo { get; set; }
        public int prodID { get; set; }
        public string proName { get; set; }
        public string prodTypeName { get; set; }
        public string proType { get; set; }
        public string proDescrip { get; set; }
        public string tax_1 { get; set; }
        public string tax_2 { get; set; }
        public string tax_3 { get; set; }
        public string proPrice { get; set; }
        public string tax_1Amt { get; set; }
        public string tax_2Amt { get; set; }
        public string tax_3Amt { get; set; }
        public string proNetPrice { get; set; }
        public string qty { get; set; }
        public Nullable<bool> Statues { get; set; }
        public string Reason { get; set; }
        public Nullable<long> prodTypeId { get; set; }

        public virtual ProductTypeVM tblProType { get; set; }
    }
}

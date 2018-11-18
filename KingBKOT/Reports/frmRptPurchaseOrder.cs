using KingBKOT.Data;
using KingBKOT.ViewModel;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingBKOT.Reports
{
    public partial class frmRptPurchaseOrder : Form
    {
        KBBQEntities _entities;
        DateTime datePassed;
        public frmRptPurchaseOrder(DateTime Passeddate)
        {
            InitializeComponent();

            datePassed = Passeddate;
        }

        private void frmRptPurchaseOrder_Load(object sender, EventArgs e)
        {
            addPurchaseOrder();
            this.reportViewer1.RefreshReport();
        }

        private void addPurchaseOrder()
        {
            try
            {
                int rowNo = 1;
                _entities = new KBBQEntities();

                List<PurchaseOrderVM> modelList = new List<PurchaseOrderVM>();

                var categoryData = _entities.tblPurchaseOrders.Where(x => x.date == datePassed).ToList();

                foreach (var item in categoryData)
                {
                    PurchaseOrderVM model = new PurchaseOrderVM();
                    model.rowNo = rowNo;
                    model.id = item.id;

                    var productName = _entities.purchaseProducts.Where(x => x.id == item.productId).FirstOrDefault().pName;

                    model.pName = productName;
                    model.qty = item.qty;
                    model.weight = item.weight + " " + item.unit;

                    model.cdate = Convert.ToDateTime(item.cdate).ToString("dd-MM-yyyy  hh:mm tt");

                    if (item.udate == null)
                        model.udate = "--";
                    else
                        model.udate = Convert.ToDateTime(item.udate).ToString("dd-MM-yyyy  hh:mm tt");

                    modelList.Add(model);

                    rowNo++;
                }
                ReportDataSource datasource = new ReportDataSource("DataSet1", modelList);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}

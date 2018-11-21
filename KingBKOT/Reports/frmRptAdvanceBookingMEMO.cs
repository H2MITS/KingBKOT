using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingBKOT.Data;
using KingBKOT.ViewModel;
using Microsoft.Reporting.WinForms;

namespace KingBKOT.Reports
{
    public partial class frmRptAdvanceBookingMEMO : Form
    {
        KBBQEntities _entities;

        long passedId;

        public frmRptAdvanceBookingMEMO(long Id)
        {
            InitializeComponent();
            passedId = Id;
        }

        private void frmRptAdvanceBookingMEMO_Load(object sender, EventArgs e)
        {
            showData();

            this.reportViewer1.RefreshReport();
        }


        private void showData()
        {
            try
            {
                  int rowNo = 1;
                _entities = new KBBQEntities();

                List<advBookingVM> modelList = new List<advBookingVM>();

                var advanceBookingData = _entities.tblAdvBookings.Where(x=>x.id==passedId).ToList();

                foreach (var item in advanceBookingData)
                {
                    advBookingVM model = new advBookingVM();

                    model.id = item.id;
                    model.rowNo = rowNo;
                    model.adults = item.adults;
                    model.child = item.child;
                    model.custName = item.custName;
                    model.mob = item.mob;
                    model.advancePayment = item.advancePayment;
                    model.eventDate = Convert.ToDateTime(item.eventDate).ToString("dd-MMM-yyyy");
                    model.totalPayment = item.totalPayment;
                    model.status = item.status;
                    model.udate = item.udate;
                    model.cdate = Convert.ToDateTime(item.cdate).ToString("dd-MMM-yyyy");
                    model.recptNo = item.recptNo;
                    model.id = item.id;

                    modelList.Add(model);

                }

                ReportDataSource datasource = new ReportDataSource("DataSet1", modelList);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
            }

            catch (Exception x)
            {

            }
        }
    }
}

using KingBKOT.Classes;
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
    public partial class frmRptSales : Form
    {
        string type;
        KBBQEntities _entities;
        AmtFomatting amtFormat = new AmtFomatting();
        decimal? ttlAmt = 0;
        public frmRptSales(string typesss)
        {
            InitializeComponent();
            type = typesss;
        }

        private void frmRptSales_Load(object sender, EventArgs e)
        {
            showReport();
            this.reportViewer1.RefreshReport();

            
        }

        void showReport()
        {
            try
            {
              
                ttlAmt = 0;
                int rowNo = 1;
                _entities = new KBBQEntities();

                 
                List<DetailSettlementVM> modelListSales = new List<DetailSettlementVM>();
                List<detailsSettlement> dataSales = new List<detailsSettlement>();

                if (type == "--All--")
                {
                   
                    #region Salesregion
                    ttlAmt = 0;
                    rowNo = 1;
                    dataSales = new List<detailsSettlement>();
                    dataSales = _entities.detailsSettlements.ToList();

                    foreach (var item in dataSales)
                    {
                        DetailSettlementVM model = new DetailSettlementVM();

                        model.rowNo = rowNo;
                        DateTime dt = Convert.ToDateTime(item.paidDate).Date;

                        model.monthYear = dt.Date.ToString("dd-MM-yyyy");
                        model.AmountPaid = Convert.ToDecimal(amtFormat.comma(item.AmountPaid));
                        model.KOT = item.receiptno;
                        rowNo++;
                        ttlAmt += Convert.ToDecimal(item.AmountPaid);

                        
                        modelListSales.Add(model);
                         
                       // lblSalesTotalAmt.Text = amtFormat.comma(ttlAmt).ToString();
                    }
                    DetailSettlementVM models = new DetailSettlementVM(); 
                    models.totalAmount = Convert.ToDecimal(ttlAmt);
                    modelListSales.Add(models);

                    ReportDataSource datasource = new ReportDataSource("DataSet1", modelListSales);

                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(datasource);

                    #endregion
                }
                else if (type == "Month")
                {
                    string dates = "";
                    decimal? amt = 0;
                    int rowId = -1;

                    #region Sales Data 

                    ttlAmt = 0;
                    rowNo = 1;

                    _entities = new KBBQEntities();

                    dataSales = new List<detailsSettlement>();
                    dataSales = _entities.detailsSettlements.ToList();

                    int dataSaleCount = dataSales.Count();
                    int count = 0;

                    dates = "";
                    amt = 0;
                    rowId = -1;

                    DetailSettlementVM model = new DetailSettlementVM();

                    foreach (var item in dataSales)
                    {
                         
                        var date = Convert.ToDateTime(item.paidDate).Date;
                        string dd = date.ToString("MMM");

                        if (dd != dates)
                        {
                            model = new DetailSettlementVM();
                            model.rowNo = rowNo;
                            model.monthYear = dd;
                            model.KOT = "--";
                            //modelListSales.Add(model);
                            //dgSalesReport.Rows.Add("0", rowNo, dd);
                            dates = dd;
                            amt = 0;
                            rowId++;
                        }
                        amt += item.AmountPaid;


                        model.AmountPaid =Convert.ToDecimal(amtFormat.comma(amt));

                        if (dd != dates)
                        {
                            modelListSales.Add(model);
                        }

                        rowNo++;
                        count++;

                        ttlAmt += item.AmountPaid;


                        if (dataSaleCount == count)
                        {
                            modelListSales.Add(model);
                        }
                    }
                    DetailSettlementVM models = new DetailSettlementVM();
                    models.totalAmount = Convert.ToDecimal(ttlAmt);
                    modelListSales.Add(models);

                    ReportDataSource datasource = new ReportDataSource("DataSet1", modelListSales);

                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(datasource);
                    #endregion
                }
                else
                {

                    string dates = "";
                    decimal? amt = 0;
                    int rowId = -1;

                    #region Sales Data
                    ttlAmt = 0;
                    rowNo = 1;
                 

                    _entities = new KBBQEntities();

                    dataSales = new List<detailsSettlement>();
                    dataSales = _entities.detailsSettlements.ToList();

                    int dataSaleCount = dataSales.Count();
                    int count = 0;

                    dates = "";
                    amt = 0;
                    rowId = -1;
                    DetailSettlementVM model = new DetailSettlementVM();

                    foreach (var item in dataSales)
                    {

                        var date = Convert.ToDateTime(item.paidDate).Date;
                        string dd = date.ToString("yyyy");

                        if (dd != dates)
                        {
                            model = new DetailSettlementVM();
                            model.rowNo = rowNo;
                            model.monthYear = dd;
                            model.KOT = "--";
                            //modelListSales.Add(model);
                            //dgSalesReport.Rows.Add("0", rowNo, dd);
                            dates = dd;
                            amt = 0;
                            rowId++;
                        }
                        amt += item.AmountPaid;


                        model.AmountPaid = Convert.ToDecimal(amtFormat.comma(amt));

                        if (dd != dates)
                        {
                            modelListSales.Add(model);
                        }

                        rowNo++;
                        count++;

                        ttlAmt += item.AmountPaid;


                        if (dataSaleCount == count)
                        {
                            modelListSales.Add(model);
                        }
                    }
                    DetailSettlementVM models = new DetailSettlementVM();
                    models.totalAmount = Convert.ToDecimal(ttlAmt);
                    modelListSales.Add(models);

                    ReportDataSource datasource = new ReportDataSource("DataSet1", modelListSales);

                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(datasource);
                    #endregion
                }
            }
            catch (Exception x)
            {

            }
        }
    }
}

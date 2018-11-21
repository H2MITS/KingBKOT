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
using KingBKOT.Classes;
using KingBKOT.ViewModel;
using KingBKOT.Reports;
using System.IO;
using System.Diagnostics;

namespace KingBKOT.Form_View
{
    public partial class frmPurchaseSaleReport : Form
    {
        public frmPurchaseSaleReport()
        {
            InitializeComponent();
        }
        KBBQEntities _entities;
        AmtFomatting amtFormat = new AmtFomatting();
        decimal? ttlAmt = 0;
        private object keyboardProc;
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridBind(cmbType.Text);
        }

        private void frmPurchaseSaleReport_Load(object sender, EventArgs e)
        {
           
            cmbType.SelectedIndex = 0;
            datagridBind(cmbType.Text);

            radioButton1.Checked=true;

            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.CustomFormat = "dd-MM-yyyy";

            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.CustomFormat = "dd-MM-yyyy";
        }

        private void datagridBind(string type)
        {
            try
            {
                dgPurchaseReport.AutoGenerateColumns = false;
                dgSalesReport.AutoGenerateColumns = false;

                ttlAmt = 0;
                int rowNo = 1;
                _entities = new KBBQEntities();

                List<PurchaseMasterVM> modelList = new List<PurchaseMasterVM>();
                List<tbl_PurchaseMaster> data = new List<tbl_PurchaseMaster>();

                List<DetailSettlementVM> modelListSales = new List<DetailSettlementVM>();
                List<detailsSettlement> dataSales = new List<detailsSettlement>();

                if (type == "--All--")
                {
                    #region PurchaseData
                    data = _entities.tbl_PurchaseMaster.ToList();

                    foreach (var item in data)
                    {
                        PurchaseMasterVM model = new PurchaseMasterVM();

                        model.rowNo = rowNo;
                        DateTime dt = Convert.ToDateTime(item.date).Date;

                        model.monthYear = dt.Date.ToString("dd-MM-yyyy");
                        model.totalAmt = Convert.ToDecimal(amtFormat.comma(item.totalAmt));
                        model.KOT = item.refNo;
                        rowNo++;
                        modelList.Add(model);

                        ttlAmt += Convert.ToDecimal(item.totalAmt);
                        lblTotalAmt.Text = amtFormat.comma(ttlAmt).ToString();
                    }

                    dgPurchaseReport.DataSource = modelList;

                    lblTotalRows.Text = modelList.Count.ToString();
                    #endregion

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
                        model.AmountPaid = Convert.ToDecimal(amtFormat.comma(item.bill));
                        model.KOT = item.receiptno;
                        rowNo++;
                        modelListSales.Add(model);

                        ttlAmt += Convert.ToDecimal(item.bill);

                        _entities = new KBBQEntities();
                        var checkForAdvancePay = _entities.tblAdvBookings.Where(x => x.recptNo == item.receiptno).FirstOrDefault();

                        if (checkForAdvancePay != null)
                        {
                            ttlAmt += checkForAdvancePay.advancePayment;

                            model.advancePaid = checkForAdvancePay.advancePayment;
                        }
                        else
                        {
                            model.advancePaid = 0;
                        }

                        lblSalesTotalAmt.Text = amtFormat.comma(ttlAmt).ToString();
                    }

                    dgSalesReport.DataSource = modelListSales;

                    lblSalesRow.Text = modelList.Count.ToString();
                    #endregion
                }
                else if (type == "Month")
                {
                    #region Purchase Data
                    ttlAmt = 0;
                    rowNo = 1;

                    dgPurchaseReport.DataSource = null;
                    dgPurchaseReport.Rows.Clear();

                    _entities = new KBBQEntities();

                    data = new List<tbl_PurchaseMaster>();
                    data = _entities.tbl_PurchaseMaster.ToList();

                    string dates = "";
                    decimal? amt = 0;
                    int rowId = -1;
                    foreach (var item in data)
                    {
                        var date = Convert.ToDateTime(item.date).Date;
                        string dd = date.ToString("MMM");

                        if (dd != dates)
                        {
                            dgPurchaseReport.Rows.Add("0", rowNo,"--", dd);
                            dates = dd;
                            amt = 0;
                            rowId++;
                        }
                        amt += item.totalAmt;
                        dgPurchaseReport.Rows[rowId].Cells[4].Value = amtFormat.comma(amt);
                        rowNo++;

                        ttlAmt += item.totalAmt;
                        lblTotalAmt.Text = amtFormat.comma(ttlAmt).ToString();
                    }
                    lblTotalRows.Text = modelList.Count.ToString();
                    #endregion

                    #region Sales Data 

                    ttlAmt = 0;
                    rowNo = 1;

                    dgSalesReport.DataSource = null;
                    dgSalesReport.Rows.Clear();

                    _entities = new KBBQEntities();

                    dataSales = new List<detailsSettlement>();
                    dataSales = _entities.detailsSettlements.ToList();

                    dates = "";
                    amt = 0;
                    rowId = -1;
                    decimal? advPay = 0;
                    foreach (var item in dataSales)
                    {
                        var date = Convert.ToDateTime(item.paidDate).Date;
                        string dd = date.ToString("MMM");

                        if (dd != dates)
                        {
                            dgSalesReport.Rows.Add("0", rowNo, "--", dd);
                            dates = dd;
                            amt = 0;
                            rowId++;
                        }
                        amt += item.bill;
                        dgSalesReport.Rows[rowId].Cells[5].Value = amtFormat.comma(amt);

                        ttlAmt += item.bill;
                        _entities = new KBBQEntities();
                        var checkForAdvancePay = _entities.tblAdvBookings.Where(x => x.recptNo == item.receiptno).FirstOrDefault();

                        if (checkForAdvancePay != null)
                        {
                            ttlAmt += checkForAdvancePay.advancePayment;
                            advPay += checkForAdvancePay.advancePayment;

                            dgSalesReport.Rows[rowId].Cells[4].Value = advPay;
                        }
                        

                        rowNo++;

                       
                        lblSalesTotalAmt.Text = amtFormat.comma(ttlAmt).ToString();
                    }
                    lblSalesRow.Text = modelList.Count.ToString();
                    #endregion
                }
                else
                {
                    #region Purchase Data
                    ttlAmt = 0;
                    rowNo = 1;
                    dgPurchaseReport.DataSource = null;
                    dgPurchaseReport.Rows.Clear();

                    _entities = new KBBQEntities();

                    data = new List<tbl_PurchaseMaster>();
                    data = _entities.tbl_PurchaseMaster.ToList();

                    string dates = "";
                    decimal? amt = 0;
                    int rowId = -1;
                    foreach (var item in data)
                    {
                        var date = Convert.ToDateTime(item.date).Date;
                        string dd = date.ToString("yyyy");

                        if (dd != dates)
                        {
                            dgPurchaseReport.Rows.Add("0", rowNo, "--", dd);
                            dates = dd;
                            amt = 0;
                            rowId++;
                        }
                        amt += item.totalAmt;
                        dgPurchaseReport.Rows[rowId].Cells[4].Value = amtFormat.comma(amt);
                        rowNo++;

                        ttlAmt += item.totalAmt;
                        lblTotalAmt.Text = amtFormat.comma(ttlAmt).ToString();
                    }
                    lblTotalRows.Text = modelList.Count.ToString();
                    #endregion

                    #region Sales Data
                    ttlAmt = 0;
                    rowNo = 1;
                    dgSalesReport.DataSource = null;
                    dgSalesReport.Rows.Clear();

                    _entities = new KBBQEntities();

                    dataSales = new List<detailsSettlement>();
                    dataSales = _entities.detailsSettlements.ToList();

                    dates = "";
                    amt = 0;
                    rowId = -1;
                    decimal? advPay = 0;
                    foreach (var item in dataSales)
                    {
                        var date = Convert.ToDateTime(item.paidDate).Date;
                        string dd = date.ToString("yyyy");

                        if (dd != dates)
                        {
                            dgSalesReport.Rows.Add("0", rowNo, "--", dd);

                            dates = dd;
                            amt = 0;
                            rowId++;
                        }
                        amt += item.bill;
                        dgSalesReport.Rows[rowId].Cells[5].Value = amtFormat.comma(amt);
                        rowNo++;

                        ttlAmt += item.bill;
                        _entities = new KBBQEntities();
                        var checkForAdvancePay = _entities.tblAdvBookings.Where(x => x.recptNo == item.receiptno).FirstOrDefault();

                        if (checkForAdvancePay != null)
                        {
                            ttlAmt += checkForAdvancePay.advancePayment;
                            advPay += checkForAdvancePay.advancePayment;

                            dgSalesReport.Rows[rowId].Cells[4].Value = advPay;
                        }




                        lblSalesTotalAmt.Text = amtFormat.comma(ttlAmt).ToString();
                    }
                    lblSalesRow.Text = modelList.Count.ToString();
                    #endregion
                }
            }
            catch (Exception x)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //frmRptSales rpt = new frmRptSales(cmbType.Text);
            //rpt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //frmRptPurchase rpt = new frmRptPurchase(cmbType.Text);
            //rpt.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbType.Text.Trim()))
            {
                errorProvider1.SetError(cmbType, "Select Term for Report is required.");
            }
            else
            {
                errorProvider1.SetError(cmbType, string.Empty);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            datePannel.Visible = false;
            monthYearPanel.Visible = true;

            monthYearPanel.Top = 44;
            monthYearPanel.Left = 320;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            datePannel.Visible = true;
            monthYearPanel.Visible = false;

            datePannel.Top = 44;
            datePannel.Left = 320;
        }

        private void btnDatSearcsh_Click(object sender, EventArgs e)
        {

            DateTime fromdate = DateTime.ParseExact(dtpFromDate.Text, "dd-MM-yyyy", null);
            DateTime todate = DateTime.ParseExact(dtpToDate.Text, "dd-MM-yyyy", null);

            if (todate.Date  < fromdate.Date)
            {
                MessageBox.Show("Invalid Date Entered", "Error - King Bar beque Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpToDate.Focus();

                return;
            }

            List<PurchaseMasterVM> modelList = new List<PurchaseMasterVM>();
            List<tbl_PurchaseMaster> data = new List<tbl_PurchaseMaster>();

            List<DetailSettlementVM> modelListSales = new List<DetailSettlementVM>();
            List<detailsSettlement> dataSales = new List<detailsSettlement>();

            #region PurchaseData
            _entities = new KBBQEntities();
            data = _entities.tbl_PurchaseMaster.Where(x => x.date >= fromdate && x.date <= todate).ToList();


            int rowNo = 1;

            foreach (var item in data)
            {
                PurchaseMasterVM model = new PurchaseMasterVM();

                model.rowNo = rowNo;
                DateTime dt = Convert.ToDateTime(item.date).Date;

                model.monthYear = dt.Date.ToString("dd-MM-yyyy");
                model.totalAmt = Convert.ToDecimal(amtFormat.comma(item.totalAmt));
                model.KOT = item.refNo;
                rowNo++;
                modelList.Add(model);

                ttlAmt += Convert.ToDecimal(item.totalAmt);
                lblTotalAmt.Text = amtFormat.comma(ttlAmt).ToString();
            }

            dgPurchaseReport.DataSource = modelList;

            lblTotalRows.Text = modelList.Count.ToString();
            #endregion

            #region Salesregion
            ttlAmt = 0;
            rowNo = 1;
            dataSales = new List<detailsSettlement>();
            dataSales = _entities.detailsSettlements.Where(x => x.paidDate >= fromdate && x.paidDate <= todate).ToList();

            foreach (var item in dataSales)
            {
                DetailSettlementVM model = new DetailSettlementVM();

                model.rowNo = rowNo;
                DateTime dt = Convert.ToDateTime(item.paidDate).Date;

                model.monthYear = dt.Date.ToString("dd-MM-yyyy");
                model.AmountPaid = Convert.ToDecimal(amtFormat.comma(item.bill));
                model.KOT = item.receiptno;
                rowNo++;
                modelListSales.Add(model);

                ttlAmt += Convert.ToDecimal(item.bill);
                lblSalesTotalAmt.Text = amtFormat.comma(ttlAmt).ToString();
            }

            dgSalesReport.DataSource = modelListSales;
            
            lblSalesRow.Text = modelList.Count.ToString();
            #endregion
        }

        private void dgPurchaseReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrintSales_Click(object sender, EventArgs e)
        {

            frmRptSales rpt = new frmRptSales(cmbType.Text, dtpFromDate, dtpToDate);
            rpt.ShowDialog();
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            try
            {
                string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
                string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

                this.keyboardProc = Process.Start(keyboardPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: '{0}'", ex);
            }
        }

        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
            frmRptPurchase rpt = new frmRptPurchase(cmbType.Text, dtpFromDate, dtpToDate);
            rpt.ShowDialog();
        }
    }
}

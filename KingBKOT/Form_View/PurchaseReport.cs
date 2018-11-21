using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingBKOT.Data;
using KingBKOT.ViewModel;
using KingBKOT.Classes;

namespace KingBKOT.Forms
{
    public partial class PurchaseReport : Form
    {
        private object keyboardProc;
        decimal? totalAmts = 0;
        AmtFomatting amtFormat = new AmtFomatting();

        public PurchaseReport()
        {
            InitializeComponent();
        }

        KBBQEntities _entities;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnKeyboard_Click(object sender, EventArgs e)
        //{
           
        //}

        private void btnClear_Click(object sender, EventArgs e)
        {
            dateFrom.Text = string.Empty;
            dateTo.Text = string.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            dateFrom.Format = DateTimePickerFormat.Custom;
            dateFrom.CustomFormat = "dd-MM-yyyy";


            dateTo.Format = DateTimePickerFormat.Custom;
            dateTo.CustomFormat = "dd-MM-yyyy";

            billNumberAutoComplete();
            dataGridBind();
        }

        private void billNumberAutoComplete()
        {
            _entities = new KBBQEntities();

            var billNoAutoComplete = _entities.tbl_PurchaseMaster.OrderBy(x => x.pId);
            txtSearch.AutoCompleteCustomSource.Clear();
            foreach (var item in billNoAutoComplete)
            {
                txtSearch.AutoCompleteCustomSource.Add(item.refNo.ToString());
            }
        }

        private void dataGridBind()
        {
            try
            {
                int rowNo = 1;
                totalAmts = 0;
                dgPurchaseDetails.AutoGenerateColumns = false;

                _entities = new KBBQEntities();

                List<PurchaseMasterVM> modelList = new List<PurchaseMasterVM>();

                var data = _entities.tbl_PurchaseMaster.OrderByDescending(x => x.pId);

                foreach (var item in data)
                {
                    PurchaseMasterVM model = new PurchaseMasterVM();
                    model.rowNo = rowNo;
                    model.pId = item.pId;
                    model.refNo = item.refNo;
                    model.partyName = item.partyName;
                    model.remarks = item.remarks;
                    model.date = Convert.ToDateTime(item.date).ToString("dd-MM-yyyy");
                    model.totalWeight = item.totalWeight;
                    model.totalAmt = Convert.ToDecimal(amtFormat.comma(item.totalAmt));

                    model.createdDate = Convert.ToDateTime(item.createdDate).ToString("dd-MM-yyyy  hh:mm tt");

                    if (item.updateDate == null)
                        model.updateDate = "--";
                    else
                        model.updateDate = Convert.ToDateTime(item.updateDate).ToString("dd-MM-yyyy  hh:mm tt");

                    modelList.Add(model);
                    totalAmts += item.totalAmt;
                    rowNo++;
                }
                lblTotalAmt.Text = amtFormat.comma(totalAmts);
                dgPurchaseDetails.DataSource = modelList;
                lblTotalRows.Text = modelList.Count.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int rowNo = 1;
                totalAmts = 0;
                dgPurchaseDetails.AutoGenerateColumns = false;
                _entities = new KBBQEntities();

                List<PurchaseMasterVM> purchaseMasterList = new List<PurchaseMasterVM>();
                List<tbl_PurchaseMaster> data = new List<tbl_PurchaseMaster>();

                DateTime fromdate = DateTime.ParseExact(dateFrom.Text, "dd-MM-yyyy", null);
                DateTime todate = DateTime.ParseExact(dateTo.Text, "dd-MM-yyyy", null);

                if (fromdate > todate)
                {
                    MessageBox.Show("Invalid date entered. Select valid dates");
                    return;
                }
                else
                {

                    if (txtSearch.Text == string.Empty)
                    {
                        if (dateFrom.Text == DateTime.Now.Date.ToString("dd-MM-yyyy") && dateTo.Text == DateTime.Now.Date.ToString("dd-MM-yyyy"))
                        {
                            data = _entities.tbl_PurchaseMaster.OrderByDescending(x => x.pId).ToList();
                        }
                        else
                        {
                            data = _entities.tbl_PurchaseMaster.Where(x => x.date >= fromdate && x.date <= todate).OrderByDescending(x => x.pId).ToList();
                        }
                    }
                    else
                    {
                        if (dateFrom.Text == DateTime.Now.Date.ToString("dd-MM-yyyy") && dateTo.Text == DateTime.Now.Date.ToString("dd-MM-yyyy"))
                        {
                            data = _entities.tbl_PurchaseMaster.Where(x => x.refNo.Contains(txtSearch.Text.Trim().ToString())).OrderByDescending(x => x.pId).ToList();

                        }
                        else
                        {
                            data = _entities.tbl_PurchaseMaster.Where(x => x.date >= fromdate && x.date <= todate && x.refNo.Contains(txtSearch.Text.Trim().ToString())).OrderByDescending(x => x.pId).ToList();
                        }

                    }

                    foreach (var item in data)
                    {
                        PurchaseMasterVM model = new PurchaseMasterVM();
                        model.rowNo = rowNo;
                        model.pId = item.pId;
                        model.refNo = item.refNo;
                        model.date = Convert.ToDateTime(item.date).ToString("dd-MM-yyyy");
                        model.totalWeight = item.totalWeight;
                        model.totalAmt = item.totalAmt;
                        model.createdDate = Convert.ToDateTime(item.createdDate).ToString("dd-MM-yyyy  hh:mm tt");

                        if (item.updateDate == null)
                        {
                            model.updateDate = "--";

                        }
                        else
                        {
                            model.updateDate = Convert.ToDateTime(item.updateDate).ToString("dd-MM-yyyy  hh:mm tt");

                        }
                        purchaseMasterList.Add(model);
                        totalAmts += item.totalAmt;
                        rowNo++;
                    }
                    lblTotalAmt.Text = amtFormat.comma(totalAmts);
                    dgPurchaseDetails.DataSource = purchaseMasterList;
                    lblTotalRows.Text = purchaseMasterList.Count.ToString();
                }
            }
            catch (Exception x)
            {

            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            dateFrom.Text = DateTime.Now.Date.ToString();
            dateTo.Text = DateTime.Now.Date.ToString();
            txtSearch.Text = "";
            dataGridBind();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int rowNo = 1;
                dgPurchaseDetails.AutoGenerateColumns = false;
                totalAmts = 0;

                if (txtSearch.Text == string.Empty)
                {
                    dataGridBind();
                    return;
                }

                _entities = new KBBQEntities();
                List<PurchaseMasterVM> modelList = new List<PurchaseMasterVM>();

                var data = _entities.tbl_PurchaseMaster.Where(x => x.refNo.Contains(txtSearch.Text.Trim()) || x.partyName.Contains(txtSearch.Text.Trim())).OrderByDescending(x => x.pId);

                foreach (var item in data)
                {
                    PurchaseMasterVM model = new PurchaseMasterVM();
                    model.rowNo = rowNo;
                    model.pId = item.pId;
                    model.refNo = item.refNo;
                    model.partyName = item.partyName;
                    model.remarks = item.remarks;
                    model.date = Convert.ToDateTime(item.date).ToString("dd-MM-yyyy");
                    model.totalWeight = item.totalWeight;
                    model.totalAmt = Convert.ToDecimal(amtFormat.comma(item.totalAmt));
                    model.createdDate = Convert.ToDateTime(item.createdDate).ToString("dd-MM-yyyy  hh:mm tt");
                    if (item.updateDate == null)
                    {
                        model.updateDate = "--";
                    }
                    else
                    {
                        model.updateDate = Convert.ToDateTime(item.updateDate).ToString("dd-MM-yyyy  hh:mm tt");

                    }

                    totalAmts += item.totalAmt;
                    modelList.Add(model);

                    rowNo++;
                }

                dgPurchaseDetails.DataSource = modelList;
                lblTotalRows.Text = modelList.Count.ToString();
                lblTotalAmt.Text = amtFormat.comma(totalAmts);
            }
            catch (Exception x)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int rowNo = 1;
                dgPurchaseDetails.AutoGenerateColumns = false;
                totalAmts = 0;

                _entities = new KBBQEntities();
                List<PurchaseMasterVM> modelList = new List<PurchaseMasterVM>();

                var data = _entities.tbl_PurchaseMaster.Where(x => x.date == DateTime.Now.Date).OrderByDescending(x => x.pId);

                foreach (var item in data)
                {
                    PurchaseMasterVM model = new PurchaseMasterVM();
                    model.rowNo = rowNo;
                    model.pId = item.pId;
                    model.refNo = item.refNo;
                    model.partyName = item.partyName;
                    model.remarks = item.remarks;
                    model.date = Convert.ToDateTime(item.date).ToString("dd-MM-yyyy");
                    model.totalWeight = item.totalWeight;
                    model.totalAmt = Convert.ToDecimal(amtFormat.comma(item.totalAmt));
                    model.createdDate = Convert.ToDateTime(item.createdDate).ToString("dd-MM-yyyy  hh:mm tt");
                    if (item.updateDate == null)
                    {
                        model.updateDate = "--";
                    }
                    else
                    {
                        model.updateDate = Convert.ToDateTime(item.updateDate).ToString("dd-MM-yyyy  hh:mm tt");

                    }

                    totalAmts += item.totalAmt;
                    modelList.Add(model);

                    rowNo++;
                }

                dgPurchaseDetails.DataSource = modelList;
                lblTotalRows.Text = modelList.Count.ToString();
                lblTotalAmt.Text = amtFormat.comma(totalAmts);
            }
            catch (Exception x)
            {

            }
        }

        private void dgPurchaseDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgPurchaseDetails.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        _entities = new KBBQEntities();

                        var cellId = Convert.ToInt32(dgPurchaseDetails.CurrentRow.Cells[0].Value);
                         

                        var selectedData1 = _entities.tbl_PurchaseDetails.Where(x => x.purchaseID == cellId).FirstOrDefault();
                        var selectedData2 = _entities.tbl_PurchaseMaster.Where(x => x.pId == cellId).FirstOrDefault();

                        if (selectedData1 != null)
                        {
                            _entities.tbl_PurchaseDetails.Remove(selectedData1);
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong. Record cannot be deleted.");
                        }
                        if (selectedData2 != null)
                        {
                            _entities.tbl_PurchaseMaster.Remove(selectedData2);
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong. Record cannot be deleted.");
                        }

                        _entities.SaveChanges();
                        MessageBox.Show("Record deleted ");
                        dataGridBind();
                    }
                    else
                    {
                        //No delete
                    }

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Record Cannot be deleted. Reference of this record is present in other entries");
            }
        }

        private void dgPurchaseDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgPurchaseDetails.CurrentRow.Index != -1 && dgPurchaseDetails.CurrentRow.Cells[1].Value != null)
                {
                    var lID = Convert.ToInt32(dgPurchaseDetails.CurrentRow.Cells[0].Value);

                    frmPurchaseMasterMain acc = new frmPurchaseMasterMain(lID);
                    acc.ShowDialog();
                    dataGridBind();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void btnPurchaseEntry_Click(object sender, EventArgs e)
        {
            frmPurchaseMasterMain purch = new frmPurchaseMasterMain(0);
            purch.ShowDialog();
            dataGridBind();
        }

        private void btnKeyboard_Click_1(object sender, EventArgs e)
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

        private void btnClear_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

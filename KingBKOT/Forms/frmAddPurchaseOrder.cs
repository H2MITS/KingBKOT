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
using KingBKOT.Forms;
using KingBKOT.ViewModel;
using KingBKOT.Reports;

namespace KingBKOT.Forms
{
    public partial class frmAddPurchaseOrder : Form
    {
        KBBQEntities _entities;
        int passedId = 0;
        public frmAddPurchaseOrder(int passedProId)
        {
            InitializeComponent();
            passedId = passedProId;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            dataGridBind();
        }

        private void clear()
        {
            txtitemName.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtWeight.Text = string.Empty;
            btnCreate.Text = "Create";
        }

        private void frmAddPurchaseOrder_Load(object sender, EventArgs e)
        {
            dateToday.Format = DateTimePickerFormat.Custom;
            dateToday.CustomFormat = "dd-MM-yyyy";

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";

            comboUnit.SelectedIndex = 0;
            itemAutocomplete();
            dataGridBind();

            errorProvider1.SetError(dateTimePicker1, "Select Date to print.");

        }
        private void itemAutocomplete()
        {
            _entities = new KBBQEntities();

            var ledgerNameAutoComplete = _entities.purchaseProducts.OrderBy(x => x.pName);
            txtitemName.AutoCompleteCustomSource.Clear();
            foreach (var item in ledgerNameAutoComplete)
            {
                txtitemName.AutoCompleteCustomSource.Add(item.pName.ToString());
            }
        }

        private void dataGridBind()
        {
            try
            {
                dgPurchaseOrderDetails.AutoGenerateColumns = false;
                int rowNo = 1;
                _entities = new KBBQEntities();

                List<PurchaseOrderVM> modelList = new List<PurchaseOrderVM>();

                var categoryData = _entities.tblPurchaseOrders.Where(x => x.date == dateTimePicker1.Value.Date).ToList();

                foreach (var item in categoryData)
                {
                    PurchaseOrderVM model = new PurchaseOrderVM();
                    model.rowNo = rowNo;
                    model.id = item.id;

                    var productName = _entities.purchaseProducts.Where(x => x.id == item.productId).FirstOrDefault().pName;

                    model.pName = productName;
                    model.qty = item.qty;
                    model.weight = item.weight + " " + item.unit;
                    model.date = item.date.ToString();
                    model.cdate = Convert.ToDateTime(item.cdate).ToString("dd-MM-yyyy  hh:mm tt");

                    if (item.udate == null)
                        model.udate = "--";
                    else
                        model.udate = Convert.ToDateTime(item.udate).ToString("dd-MM-yyyy  hh:mm tt");


                    modelList.Add(model);

                    rowNo++;
                }

                dgPurchaseOrderDetails.DataSource = modelList;

                lblTotalRows.Text = modelList.Count.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtitemName.Text == string.Empty && txtQty.Text == string.Empty && txtWeight.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtitemName, "Enter all details.");
                    txtitemName.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter all details.";
                }
                else if (txtitemName.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtitemName, "Enter Product-name");
                    txtitemName.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Party-name.";
                }
                else if (txtQty.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtQty, "Enter Qty.");
                    txtQty.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Qty.";
                }
                else if (txtWeight.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtWeight, "Enter Weight.");
                    txtWeight.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Weight.";
                }
                else
                {

                    DateTime date = DateTime.ParseExact(dateToday.Text, "dd-MM-yyyy", null);
                    if (btnCreate.Text == "Create")
                    {
                        //save code
                        _entities = new KBBQEntities();

                        var pId = _entities.purchaseProducts.Where(x => x.pName == txtitemName.Text.Trim()).FirstOrDefault().id;

                        //var checkForExisitingData = _entities.tblPurchaseOrders.Where(x => x.productId == pId).FirstOrDefault();

                        //if (checkForExisitingData != null)
                        //{
                        //    MessageBox.Show("Entry Already Exists. Update the Exisiting Entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    clear();
                        //    txtitemName.Focus();
                        //    return;
                        //}
                        //else
                        //{
                            //save Code
                            tblPurchaseOrder proDate = new tblPurchaseOrder();
                            proDate.productId = pId;
                            proDate.qty = Convert.ToDecimal(txtQty.Text);
                            proDate.weight = Convert.ToDecimal(txtWeight.Text);
                            proDate.unit = comboUnit.Text.ToString();
                            proDate.date = date;
                            proDate.cdate = DateTime.Now;

                            _entities.tblPurchaseOrders.Add(proDate);
                            _entities.SaveChanges();

                            clear();
                            MessageBox.Show("Record Added Successfully");

                        //}

                    }
                    else
                    {
                        //Update Code

                        _entities = new KBBQEntities();
                        var pId = _entities.purchaseProducts.Where(x => x.pName == txtitemName.Text.Trim()).FirstOrDefault().id;


                        var proDataUpdate = _entities.tblPurchaseOrders.Where(x => x.id == passedId).FirstOrDefault();

                        proDataUpdate.productId = pId;
                        proDataUpdate.qty = Convert.ToDecimal(txtQty.Text);
                        proDataUpdate.weight = Convert.ToDecimal(txtWeight.Text);
                        proDataUpdate.unit = comboUnit.Text.ToString();
                        proDataUpdate.date = date;
                        proDataUpdate.udate = DateTime.Now;

                        _entities.SaveChanges();

                        clear();
                        MessageBox.Show("Record Updated Successfully");
                    }
                    dataGridBind();
                }

            }
            catch (Exception x)
            {

            }
        }

        private void txtitemName_Leave(object sender, EventArgs e)
        {
            try
            {
                _entities = new KBBQEntities();
                if (txtitemName.Text != string.Empty)
                {
                    var checkLedgername = _entities.purchaseProducts.Where(x => x.pName == txtitemName.Text.Trim().ToString()).FirstOrDefault();

                    if (checkLedgername == null)
                    {
                        DialogResult myResult;
                        myResult = MessageBox.Show("No such product exists. Want to create new product?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (myResult == DialogResult.OK)
                        {
                            //frmAddPurchaseProduct ledger = new frmAddPurchaseProduct(0,txtitemName.Text.Trim());
                            //ledger.ShowDialog();

                            purchaseProduct pp = new purchaseProduct();
                            pp.pName = txtitemName.Text.Trim().ToString();

                            _entities.purchaseProducts.Add(pp);
                            _entities.SaveChanges();

                            itemAutocomplete();
                            txtitemName.Focus();
                        }
                        else
                        {
                            txtitemName.Focus();
                        }
                    }

                }
            }
            catch (Exception x)
            {

            }
        }

        private void dgPurchaseOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgPurchaseOrderDetails.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        _entities = new KBBQEntities();

                        var cellId = Convert.ToInt32(dgPurchaseOrderDetails.CurrentRow.Cells[0].Value);

                        var selectedData1 = _entities.tblPurchaseOrders.Where(x => x.id == cellId).FirstOrDefault();


                        if (selectedData1 != null)
                        {
                            _entities.tblPurchaseOrders.Remove(selectedData1);
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong. Record cannot be deleted.");
                        }

                        _entities.SaveChanges();
                        MessageBox.Show("Record deleted ");
                        dataGridBind();

                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void dgPurchaseOrderDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgPurchaseOrderDetails.CurrentRow.Index != -1 && dgPurchaseOrderDetails.CurrentRow.Cells[1].Value != null)
                {
                    var lID = Convert.ToInt32(dgPurchaseOrderDetails.CurrentRow.Cells[0].Value);

                    _entities = new KBBQEntities();
                    var seeData = _entities.tblPurchaseOrders.Where(x => x.id == lID).FirstOrDefault();

                    if (seeData != null)
                    {
                        var pName = _entities.purchaseProducts.Where(x => x.id == seeData.productId).FirstOrDefault().pName;

                        txtitemName.Text = pName.Trim().ToString();
                        txtQty.Text = seeData.qty.ToString();
                        txtWeight.Text = seeData.weight.ToString();

                        comboUnit.Text = seeData.unit;

                        passedId = seeData.id;
                        btnCreate.Text = "Update";
                    }
                    else
                    {

                    }

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void txtitemName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtitemName.Text != string.Empty)
                {

                    dgPurchaseOrderDetails.AutoGenerateColumns = false;
                    int rowNo = 1;
                    _entities = new KBBQEntities();

                    List<PurchaseOrderVM> modelList = new List<PurchaseOrderVM>();

                    var pId = _entities.purchaseProducts.Where(x => x.pName.Contains(txtitemName.Text.ToString())).FirstOrDefault();
                    if (pId != null)
                    {
                        var categoryData = _entities.tblPurchaseOrders.Where(x => x.productId == pId.id).ToList();

                        foreach (var item in categoryData)
                        {
                            PurchaseOrderVM model = new PurchaseOrderVM();
                            model.rowNo = rowNo;
                            model.id = item.id;

                            var productName = _entities.purchaseProducts.Where(x => x.id == item.productId).FirstOrDefault().pName;

                            model.pName = productName;
                            model.qty = item.qty;
                            model.weight = item.weight + " " + item.unit;
                            model.date = item.date.ToString();
                            model.cdate = Convert.ToDateTime(item.cdate).ToString("dd-MM-yyyy  hh:mm tt");

                            if (item.udate == null)
                                model.udate = "--";
                            else
                                model.udate = Convert.ToDateTime(item.udate).ToString("dd-MM-yyyy  hh:mm tt");


                            modelList.Add(model);

                            rowNo++;
                        }
                    }
                    dgPurchaseOrderDetails.DataSource = modelList;

                    lblTotalRows.Text = modelList.Count.ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRptPurchaseOrder rpt = new frmRptPurchaseOrder(dateTimePicker1.Value.Date);
            rpt.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgPurchaseOrderDetails.AutoGenerateColumns = false;
                int rowNo = 1;
                _entities = new KBBQEntities();

                List<PurchaseOrderVM> modelList = new List<PurchaseOrderVM>();

                var categoryData = _entities.tblPurchaseOrders.Where(x => x.date == dateTimePicker1.Value.Date).ToList();

                foreach (var item in categoryData)
                {
                    PurchaseOrderVM model = new PurchaseOrderVM();
                    model.rowNo = rowNo;
                    model.id = item.id;

                    var productName = _entities.purchaseProducts.Where(x => x.id == item.productId).FirstOrDefault().pName;

                    model.pName = productName;
                    model.qty = item.qty;
                    model.date = item.date.ToString();
                    model.weight = item.weight + " " + item.unit;

                    model.cdate = Convert.ToDateTime(item.cdate).ToString("dd-MM-yyyy  hh:mm tt");

                    if (item.udate == null)
                        model.udate = "--";
                    else
                        model.udate = Convert.ToDateTime(item.udate).ToString("dd-MM-yyyy  hh:mm tt");


                    modelList.Add(model);

                    rowNo++;
                }

                dgPurchaseOrderDetails.DataSource = modelList;

                lblTotalRows.Text = modelList.Count.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

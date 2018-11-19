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
using KingBKOT.Classes;
using System.Diagnostics;
using System.IO;

namespace KingBKOT.Forms
{
    public partial class frmPurchaseMasterMain : Form
    {
        object keyboardProc;
        KBBQEntities _entities;
        int count = 0;
        AmtFomatting amtFormat = new AmtFomatting();
        int id = 1;
        int datagridId = 1;
        bool datagridEdit = false;   //Used When Double click on datagrid to edit 
        decimal ttlWeight = 0, ttlRate = 0;

        int passedPid = 0;

        public frmPurchaseMasterMain(int passedPurchasemasterId)
        {
            InitializeComponent();
            passedPid = passedPurchasemasterId;
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            try
            {

                btnCreate.Enabled = true;
                lblBtnError.Visible = false;

                if (txtitemName.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtitemName, "Enter item Code.");
                    txtitemName.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter item code.";
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
                    errorProvider1.SetError(txtWeight, "Enter item weight.");
                    txtWeight.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter item weight.";
                }


                else if (txtRate.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtRate, "Enter rate.");
                    txtRate.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter rate.";
                }

                else
                {
                    errorProvider1.Clear();

                    if (txtitemName.Text != string.Empty && txtQty.Text != string.Empty && txtWeight.Text != string.Empty && txtRate.Text != string.Empty)
                    {
                        if (datagridEdit)
                        {
                            //  MessageBox.Show( dgPurchaseItem.Rows[datagridId].Cells);
                            dgPurchaseItem.Rows[datagridId].Cells[1].Value = txtitemName.Text;
                            dgPurchaseItem.Rows[datagridId].Cells[2].Value = txtQty.Text;
                            dgPurchaseItem.Rows[datagridId].Cells[3].Value = txtWeight.Text;
                            dgPurchaseItem.Rows[datagridId].Cells[4].Value = comboUnit.Text;
                            dgPurchaseItem.Rows[datagridId].Cells[5].Value = txtRate.Text;

                            this.datagridEdit = false;

                            var dgQty = Convert.ToDecimal(dgPurchaseItem.Rows[datagridId].Cells[2].Value);
                            var dgWeight = Convert.ToDecimal(dgPurchaseItem.Rows[datagridId].Cells[3].Value);
                            var dgrate = Convert.ToDecimal(dgPurchaseItem.Rows[datagridId].Cells[5].Value);


                        }
                        else
                        {

                            dgPurchaseItem.Rows.Add(id.ToString(), txtitemName.Text, txtQty.Text, txtWeight.Text, comboUnit.Text, txtRate.Text);
                            //dgPurchaseOrderDetails.Rows.Add(id.ToString(), txtitemName.Text, "harsh", "200", "G", "500");
                            //dgPurchaseItem.Rows.Add(id.ToString(), txtitemName.Text, "harsh", "200", "G", "500");
                            id = id + 1;
                        }


                        if (comboUnit.Text == "Kg")
                        {
                            decimal grams = Convert.ToDecimal(txtWeight.Text) * 1000;
                            ttlWeight = ttlWeight + grams;
                        }
                        else
                        {
                            ttlWeight = ttlWeight + Convert.ToDecimal(txtWeight.Text);
                        }

                        ttlRate = ttlRate + Convert.ToDecimal(txtRate.Text);
                    }


                    double kg = Convert.ToDouble(ttlWeight) / 1000;
                    if (kg > 0)
                    {
                        txtTotalWeight.Text = kg.ToString();
                        lblUnit.Text = "Kg";
                    }
                    else
                    {
                        txtTotalWeight.Text = ttlWeight.ToString();
                        lblUnit.Text = "Gram";
                    }
                    txtTotalAmt.Text = amtFormat.comma(ttlRate).ToString();

                    clearDetails();
                    txtitemName.Focus();
                    errorProvider1.Clear();

                    txtAmtInWords.Text = "";
                    ConvertNoToWord convertToWord = new ConvertNoToWord();
                    var rats = Convert.ToDecimal(txtTotalAmt.Text.Trim().ToString());
                    txtAmtInWords.Text = convertToWord.ConvertNumbertoWords(Convert.ToInt32(rats)).ToLower();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void dgPurchaseOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnCreate.Enabled = false;
                lblBtnError.Visible = true;

                if (dgPurchaseItem.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        // int id = Convert.ToInt32(dgPurchaseItem.CurrentRow.Index);

                        foreach (DataGridViewCell oneCell in dgPurchaseItem.SelectedCells)
                        {

                            //var dgQty = Convert.ToDecimal(dgPurchaseItem.Rows[oneCell.RowIndex].Cells[2].Value);
                            var dgWeight = Convert.ToDecimal(dgPurchaseItem.Rows[oneCell.RowIndex].Cells[3].Value);
                            var dgRate = Convert.ToDecimal(dgPurchaseItem.Rows[oneCell.RowIndex].Cells[5].Value);


                            ttlWeight = ttlWeight - dgWeight; 
                            ttlRate = ttlRate - dgRate; 
                            txtTotalAmt.Text = ttlRate.ToString();

                            double kg = Convert.ToDouble(ttlWeight) / 1000;
                            if (kg > 0)
                            {
                                txtTotalWeight.Text = kg.ToString();
                                lblUnit.Text = "Kg";
                            }
                            else
                            {
                                txtTotalWeight.Text = ttlWeight.ToString();
                                lblUnit.Text = "Gram";
                            }

                            if (oneCell.Selected)
                                dgPurchaseItem.Rows.RemoveAt(oneCell.RowIndex);

                            txtAmtInWords.Text = "";
                            ConvertNoToWord convertToWord = new ConvertNoToWord();
                            txtAmtInWords.Text = convertToWord.ConvertNumbertoWords(Convert.ToInt32(ttlRate)).ToLower();

                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void frmPurchaseMasterMain_Load(object sender, EventArgs e)
        {
            try
            {
                dateToday.Format = DateTimePickerFormat.Custom;
                dateToday.CustomFormat = "dd-MM-yyyy";

                clear();
                clearDetails();



                itemAutocomplete();

                //Edit load

                if (passedPid != 0)
                {
                    showAvailableData();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }
        private void showAvailableData()
        {
            clear();
            clearDetails();

            btnCreate.Text = "Update";
            _entities = new KBBQEntities();

            var data = _entities.tbl_PurchaseMaster.Where(x => x.pId == passedPid).FirstOrDefault();

            txtRefNo.Text = data.refNo;
            dateToday.Text = data.date.ToString();


            txtTotalAmt.Text = amtFormat.comma(data.totalAmt).ToString();
            txtTotalWeight.Text = data.totalWeight.ToString();

            ttlWeight = Convert.ToDecimal(txtTotalWeight.Text) * 1000;
            ttlRate = Convert.ToDecimal(txtTotalAmt.Text);


            txtAmtInWords.Text = "";
            ConvertNoToWord convertToWord = new ConvertNoToWord();
            //int totalRate = Convert.ToInt32(txtTotalRate.Text);
            txtAmtInWords.Text = convertToWord.ConvertNumbertoWords(Convert.ToInt32(data.totalAmt)).ToLower();

            _entities = new KBBQEntities();

            var purchaseDetailsData = _entities.tbl_PurchaseDetails.Where(x => x.purchaseID == passedPid).ToList();

            id = 1;
            foreach (var item in purchaseDetailsData)
            {
                var pName = _entities.purchaseProducts.Where(x => x.id == item.productID).FirstOrDefault().pName;

                dgPurchaseItem.Rows.Add(
                    id.ToString(),
                    pName,
                    item.qty,
                    item.weight,
                    item.unit,
                    item.rate);

                id = id + 1;
            }
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

        private void clear()
        {
            dgPurchaseItem.Rows.Clear();
            txtRefNo.Text = "";
            txtitemName.Text = "";
            dateToday.Text = DateTime.Now.Date.ToString();

            txtTotalAmt.Text = "0.00";
            txtTotalWeight.Text = "0.00";

            txtAmtInWords.Text = "";
            txtRemark.Text = "";
            id = 1;
            datagridId = 1;
            datagridEdit = false;
            ttlWeight = ttlRate = 0;
            panel3.Visible = false;
        }

        private void dgPurchaseItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgPurchaseItem.CurrentRow.Index != -1 && dgPurchaseItem.CurrentRow.Cells[1].Value != null)
                {


                    //var Rowid = Convert.ToInt32(dgPurchaseItem.CurrentRow.Cells[0].Value);
                    txtitemName.Text = dgPurchaseItem.CurrentRow.Cells[1].Value.ToString();
                    txtQty.Text = dgPurchaseItem.CurrentRow.Cells[2].Value.ToString();
                    txtWeight.Text = dgPurchaseItem.CurrentRow.Cells[3].Value.ToString();
                    comboUnit.Text = dgPurchaseItem.CurrentRow.Cells[4].Value.ToString();
                     
                    txtRate.Text = dgPurchaseItem.CurrentRow.Cells[5].Value.ToString();
                    //id = 1;
                    //ttlRate = Convert.ToDecimal(txtTotalRate.Text);
                    //ttlWeight = Convert.ToDecimal(txtTotalWeight.Text);
                    //ttlMelting = Convert.ToDecimal(txtTotalMelting.Text);

                    ttlWeight = ttlWeight - Convert.ToDecimal(txtWeight.Text);
                    
                    ttlRate = ttlRate - Convert.ToDecimal(txtRate.Text);

                    //MessageBox.Show(ttlWeight + "-" + ttlMelting + "-" + ttlRate);

                    int id = Convert.ToInt32(dgPurchaseItem.CurrentRow.Index);

                    datagridId = id;
                    datagridEdit = true;
                    txtitemName.Focus();
                    //foreach (DataGridViewCell oneCell in dgPurchaseItem.SelectedCells)
                    //{
                    //    if (oneCell.Selected)
                    //        dgPurchaseItem.Rows.RemoveAt(oneCell.RowIndex);
                    //}

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidation val = new TextBoxValidation();
            val.onlyNumber(sender, e);
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidation val = new TextBoxValidation();
            val.onlyNumber(sender, e);
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidation val = new TextBoxValidation();
            val.onlyNumber(sender, e);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRefNo.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtRefNo, "Enter reference number.");
                    txtRefNo.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter reference number.";
                }
               
                else if (txtTotalWeight.Text == string.Empty)
                {

                    errorProvider1.Clear();
                    errorProvider1.SetError(txtTotalWeight, "Enter total weight.");
                    txtTotalWeight.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter total weight.";
                }
                 
                else if (txtTotalAmt.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtTotalAmt, "Enter total rate.");
                    txtTotalAmt.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter total rate.";
                }
                else
                {
                    if (btnCreate.Text == "Create")
                    {
                        //Save Code

                        _entities = new KBBQEntities();

                        tbl_PurchaseMaster purchaseData = new tbl_PurchaseMaster();
                        purchaseData.refNo = txtRefNo.Text.Trim().ToString();
                     
                        DateTime date = DateTime.ParseExact(dateToday.Text, "dd-MM-yyyy", null);

                        purchaseData.date = Convert.ToDateTime(date);
                        purchaseData.totalWeight = Convert.ToDecimal(txtTotalWeight.Text);
                        purchaseData.unit = lblUnit.Text; 
                        purchaseData.totalAmt = Convert.ToDecimal(txtTotalAmt.Text);
                        purchaseData.remarks = txtRemark.Text.ToString();
                        purchaseData.createdDate = DateTime.Now;
                        purchaseData.updateDate = DateTime.Now;

                        _entities.tbl_PurchaseMaster.Add(purchaseData);
                        _entities.SaveChanges();

                        //add data to purchase detials
                        addPurchaseDetailsData(); 
                         
                        MessageBox.Show("Record Successfull Saved");

                    }
                    else
                    {
                        //Update Code

                        _entities = new KBBQEntities();

                        var purchaseDataUpdate = _entities.tbl_PurchaseMaster.Where(x => x.pId == passedPid).FirstOrDefault();

                        purchaseDataUpdate.refNo = txtRefNo.Text.Trim().ToString();

                        DateTime date = DateTime.ParseExact(dateToday.Text, "dd-MM-yyyy", null);

                        purchaseDataUpdate.date = Convert.ToDateTime(date);

                        purchaseDataUpdate.totalWeight = Convert.ToDecimal(txtTotalWeight.Text);
                        purchaseDataUpdate.unit = lblUnit.Text;
                        purchaseDataUpdate.totalAmt = Convert.ToDecimal(txtTotalAmt.Text);
                        purchaseDataUpdate.remarks = txtRemark.Text.ToString();
                        purchaseDataUpdate.updateDate = DateTime.Now;

                        _entities.SaveChanges();

                        var purchaseDetailsUpdate = _entities.tbl_PurchaseDetails.Where(x => x.purchaseID == passedPid).ToList();

                        foreach (var item in purchaseDetailsUpdate)
                        {
                            _entities.tbl_PurchaseDetails.Remove(item);
                            _entities.SaveChanges();
                        }

                        addPurchaseDetailsData();  //grid data entry in purchse details

                        //Update transaction
 
                        MessageBox.Show("Record Successfull Updated");
                    }
                    clear();
                    clearDetails();
                    count = 0;
                    passedPid = 0;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        void addPurchaseDetailsData()
        {
            foreach (DataGridViewRow dr in dgPurchaseItem.Rows)
            {
                if (Convert.ToString(dr.Cells[0].Value) != string.Empty)
                {
                    _entities = new KBBQEntities();

                    tbl_PurchaseDetails purchaseDetails = new tbl_PurchaseDetails();

                    purchaseDetails.purchaseID = _entities.tbl_PurchaseMaster.Where(x => x.refNo == txtRefNo.Text).FirstOrDefault().pId;
                    var gridItemCode = dr.Cells[1].Value.ToString();
                    purchaseDetails.productID = _entities.purchaseProducts.Where(x => x.pName == gridItemCode).FirstOrDefault().id;
                    purchaseDetails.qty = Convert.ToDecimal(dr.Cells[2].Value.ToString());
                    purchaseDetails.weight = Convert.ToDecimal(dr.Cells[3].Value.ToString());
                    purchaseDetails.unit = dr.Cells[4].Value.ToString();
                    purchaseDetails.rate = Convert.ToDecimal(dr.Cells[5].Value.ToString());
                    purchaseDetails.createdDate = DateTime.Now;

                    _entities.tbl_PurchaseDetails.Add(purchaseDetails);
                    _entities.SaveChanges();

                    //Update Qty in stock

                    var itemQty = _entities.purchaseProducts.Where(x => x.id == purchaseDetails.productID).FirstOrDefault();

                    itemQty.qty = itemQty.qty + purchaseDetails.qty;
                    itemQty.udate = DateTime.Now;

                    _entities.SaveChanges();
                }
            }
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

            this.keyboardProc = Process.Start(keyboardPath);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearDetails()
        {
            txtitemName.Text = "";
            txtQty.Text = "0";
            txtWeight.Text = "0.00";
            txtRate.Text = "0.00";
            comboUnit.SelectedIndex = 0;

        }
    }
}

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
using System.Diagnostics;
using System.IO;

namespace KingBKOT.Forms
{
    public partial class frmExpenses : Form
    {
        KBBQEntities _entities;
        object keyboardProc;
        long passedId;
        public frmExpenses()
        {
            InitializeComponent();
        }


        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmExpenses_Load(object sender, EventArgs e)
        {
            try
            {
                dgvExpenses.AutoGenerateColumns = false;

                dateToday.Format = DateTimePickerFormat.Custom;
                dateToday.CustomFormat = "dd-MM-yyyy";

                dtpStartDate.Format = DateTimePickerFormat.Custom;
                dtpStartDate.CustomFormat = "dd-MM-yyyy";

                dtpEndDate.Format = DateTimePickerFormat.Custom;
                dtpEndDate.CustomFormat = "dd-MM-yyyy";

                dtpExpDate.Format = DateTimePickerFormat.Custom;
                dtpExpDate.CustomFormat = "dd-MM-yyyy";


                dataGridViewBind();
            }
            catch (Exception x)
            {

            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            dataGridViewBind();
        }

        private void Clear()
        {
            txtExpName.Text = string.Empty;
            txtExpBy.Text = string.Empty;
            txtAmt.Text = "0";

            btnCreate.Text = "Savee";

            dateToday.Text = DateTime.Now.ToString();

            dateToday.Format = DateTimePickerFormat.Custom;
            dateToday.CustomFormat = "dd-MM-yyyy";

            dtpExpDate.Text = DateTime.Now.ToString();

            dtpExpDate.Format = DateTimePickerFormat.Custom;
            dtpExpDate.CustomFormat = "dd-MM-yyyy";

            dtpStartDate.Text = DateTime.Now.ToString();

            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd-MM-yyyy";

            dtpEndDate.Text = DateTime.Now.ToString();

            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = "dd-MM-yyyy";

            dataGridViewBind();
        }

        private void dataGridViewBind()
        {
            try
            {
                _entities = new KBBQEntities();
                List<ExpensesVM> modelList = new List<ExpensesVM>();
                int rowNo = 1;
                decimal? ttlAmt = 0;
                var data = _entities.tblExpenses.OrderBy(x => x.id).ToList();

                if (data != null)
                {
                    foreach (var item in data)
                    {
                        ExpensesVM model = new ExpensesVM();

                        model.id = item.id;
                        model.expName = item.expName;
                        model.expBy = item.expBy;
                        model.amount = item.amount;
                        model.expDate = Convert.ToDateTime(item.expDate).ToString("dd-MMM-yyyy");
                        model.cdate = item.cdate;
                        model.udate = item.udate;

                        model.rowNo = rowNo;

                        ttlAmt += item.amount;
                        rowNo++;

                        modelList.Add(model);

                    }
                    dgvExpenses.DataSource = modelList;
                    lblTotalRecord.Text = modelList.Count.ToString();

                    lblTotalExp.Text = ttlAmt.ToString();
                }

            }
            catch (Exception x)
            {

            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtExpName.Text == string.Empty && txtExpBy.Text == string.Empty && txtAmt.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtExpName, "Enter all details.");
                    txtExpName.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter all details.";
                }
                else if (txtExpName.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtExpName, "Enter Expense-name");
                    txtExpName.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Customer-name.";
                }
                else if (txtExpBy.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtExpBy, "Enter Expense By.");
                    txtExpBy.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Expense By.";
                }
                else if (txtAmt.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtAmt, "Enter Amount.");
                    txtAmt.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Amount.";
                }
                else
                {

                    //DateTime date = DateTime.ParseExact(dateToday.Text, "yyyy-MM-dd", null);
                    if (btnCreate.Text == "Save")
                    {
                        tblExpens data = new tblExpens();

                        data.expName = txtExpName.Text.Trim().ToString();
                        data.expBy = txtExpBy.Text.Trim().ToString();
                        data.expDate = dtpExpDate.Value.Date;
                        data.amount = Convert.ToDecimal(txtAmt.Text);
                        data.cdate = DateTime.Now;

                        _entities.tblExpenses.Add(data);
                        _entities.SaveChanges();
                        MessageBox.Show("Record Created Successfully");
                    }
                    else
                    {
                        //Update Code

                        _entities = new KBBQEntities();
                        //var pId = _entities.purchaseProducts.Where(x => x.pName == txtitemName.Text.Trim()).FirstOrDefault().id;


                        var expData = _entities.tblExpenses.Where(x => x.id == passedId).FirstOrDefault();

                        expData.expName = txtExpName.Text.Trim().ToString();
                        expData.expBy = txtExpBy.Text.Trim().ToString();
                        expData.expDate = dtpExpDate.Value.Date;
                        expData.amount = Convert.ToDecimal(txtAmt.Text);
                        expData.udate = DateTime.Now;

                        _entities.SaveChanges();

                        Clear();
                        MessageBox.Show("Record Updated Successfully");
                    }

                    dataGridViewBind();
                }
            }
            catch (Exception x)
            {

            }
        }

        private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvExpenses.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        _entities = new KBBQEntities();

                        var cellId = Convert.ToInt32(dgvExpenses.CurrentRow.Cells[0].Value);

                        var selectedData1 = _entities.tblExpenses.Where(x => x.id == cellId).FirstOrDefault();


                        if (selectedData1 != null)
                        {
                            _entities.tblExpenses.Remove(selectedData1);
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong. Record cannot be deleted.");
                        }

                        _entities.SaveChanges();
                        MessageBox.Show("Record deleted ");
                        dataGridViewBind();

                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void dgvExpenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvExpenses.CurrentRow.Index != -1 && dgvExpenses.CurrentRow.Cells[1].Value != null)
                {
                    var lID = Convert.ToInt32(dgvExpenses.CurrentRow.Cells[0].Value);

                    _entities = new KBBQEntities();
                    var seeData = _entities.tblExpenses.Where(x => x.id == lID).FirstOrDefault();

                    if (seeData != null)
                    {

                        txtExpName.Text = seeData.expName.Trim().ToString();
                        txtExpBy.Text = seeData.expBy.Trim().ToString();
                        txtAmt.Text = seeData.amount.ToString();

                        dtpExpDate.Text = seeData.expDate.ToString();

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

        private void btnDatSearcsh_Click(object sender, EventArgs e)
        {
            try
            {
                _entities = new KBBQEntities();
                List<ExpensesVM> modelList = new List<ExpensesVM>();
                int rowNo = 1;
                decimal? ttlAmt = 0;
                var data = _entities.tblExpenses.Where(x=>x.expDate>=dtpStartDate.Value.Date && x.expDate<=dtpExpDate.Value.Date).OrderBy(x => x.id).ToList();

                if (data != null)
                {
                    foreach (var item in data)
                    {
                        ExpensesVM model = new ExpensesVM();

                        model.id = item.id;
                        model.expName = item.expName;
                        model.expBy = item.expBy;
                        model.amount = item.amount;
                        model.expDate = Convert.ToDateTime(item.expDate).ToString("dd-MMM-yyyy");
                        model.cdate = item.cdate;
                        model.udate = item.udate;

                        model.rowNo = rowNo;

                        ttlAmt += item.amount;
                        rowNo++;

                        modelList.Add(model);

                    }
                    dgvExpenses.DataSource = modelList;
                    lblTotalRecord.Text = modelList.Count.ToString();

                    lblTotalExp.Text = ttlAmt.ToString();
                }

            }
            catch (Exception x)
            {

            }
        }

        private void txtExpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtExpBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

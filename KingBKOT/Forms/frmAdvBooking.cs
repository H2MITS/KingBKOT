using KingBKOT.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingBKOT.ViewModel;
using System.IO;
using System.Diagnostics;
using KingBKOT.Reports;

namespace KingBKOT.Forms
{
    public partial class frmAdvBooking : Form
    {
        KBBQEntities _entities;
        long passedId = 0;
        object keyboardProc;
        public frmAdvBooking()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            long idd = passedId;

            frmRptAdvanceBookingMEMO rpt = new frmRptAdvanceBookingMEMO(idd);
            rpt.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAdvBooking_Load(object sender, EventArgs e)
        {
            dateToday.Format = DateTimePickerFormat.Custom;
            dateToday.CustomFormat = "dd-MM-yyyy";

            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd-MM-yyyy";

            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = "dd-MM-yyyy";

            dtpBookingDate.Format = DateTimePickerFormat.Custom;
            dtpBookingDate.CustomFormat = "dd-MM-yyyy";

            gridViewBind();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustName.Text == string.Empty && txtMob.Text == string.Empty && txtChild.Text == string.Empty && txtAdults.Text == string.Empty && txtAdvPayment.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtCustName, "Enter all details.");
                    txtCustName.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter all details.";
                }
                else if (txtCustName.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtCustName, "Enter Customer-name");
                    txtCustName.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Customer-name.";
                }
                else if (txtMob.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtMob, "Enter Mobile Number.");
                    txtMob.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Qty.";
                }
                else if (txtAdults.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtAdults, "Enter Adults.");
                    txtAdults.Focus();
                    panel3.Visible = true;
                    lblError.Text = "There must be atleast 1 adult.";
                }
                else if (txtAdvPayment.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtAdvPayment, "Enter Adv. Payment.");
                    txtAdvPayment.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Adv. Payment.";
                }
                else
                {

                    //DateTime date = DateTime.ParseExact(dateToday.Text, "yyyy-MM-dd", null);
                    if (btnCreate.Text == "Create")
                    {
                        tblAdvBooking data = new tblAdvBooking();

                        data.custName = txtCustName.Text.Trim().ToString();
                        data.mob = txtMob.Text.Trim().ToString();
                        data.child = Convert.ToInt32(txtChild.Text.ToString());
                        data.adults = Convert.ToInt32(txtAdults.Text);
                        data.eventDate = dtpBookingDate.Value.Date;
                        data.todayDate = dateToday.Value.Date;
                        data.advancePayment = Convert.ToDecimal(txtAdvPayment.Text);
                        data.status = "UNPAID";
                        data.cdate = DateTime.Now;

                        _entities.tblAdvBookings.Add(data);
                        _entities.SaveChanges();
                        MessageBox.Show("Record Created Successfully");


                        DialogResult myResult;
                        myResult = MessageBox.Show("Are you want to print receipt?", "Print Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (myResult == DialogResult.OK)
                        {

                            _entities = new KBBQEntities();
                            long lastId = _entities.tblAdvBookings.OrderByDescending(x => x.id).FirstOrDefault().id;


                            frmRptAdvanceBookingMEMO rpt = new frmRptAdvanceBookingMEMO(lastId);
                            rpt.ShowDialog();
                        }

                    }
                    else
                    {
                        //Update Code

                        _entities = new KBBQEntities();
                        //var pId = _entities.purchaseProducts.Where(x => x.pName == txtitemName.Text.Trim()).FirstOrDefault().id;


                        var advBookingData = _entities.tblAdvBookings.Where(x => x.id == passedId).FirstOrDefault();

                        advBookingData.custName = txtCustName.Text.Trim().ToString();
                        advBookingData.mob = txtMob.Text.Trim().ToString();
                        advBookingData.child = Convert.ToInt32(txtChild.Text.ToString());
                        advBookingData.adults = Convert.ToInt32(txtAdults.Text);
                        advBookingData.eventDate = dtpBookingDate.Value.Date;
                        advBookingData.todayDate = dateToday.Value.Date;
                        advBookingData.advancePayment = Convert.ToDecimal(txtAdvPayment.Text);

                        _entities.SaveChanges();


                        MessageBox.Show("Record Updated Successfully");

                        DialogResult myResult;
                        myResult = MessageBox.Show("Are you want to print receipt?", "Print Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (myResult == DialogResult.OK)
                        {

                            _entities = new KBBQEntities();


                            frmRptAdvanceBookingMEMO rpt = new frmRptAdvanceBookingMEMO(passedId);
                            rpt.ShowDialog();
                        }
                    }
                    clear();
                    gridViewBind();

                }
            }
            catch (Exception x)
            {

            }
        }

        void clear()
        {
            txtAdults.Text = "1";
            txtChild.Text = "0";
            txtCustName.Text = string.Empty;
            txtMob.Text = "0";
            txtAdvPayment.Text = "0";
            btnCreate.Text = "Create";

            dateToday.Text = DateTime.Now.ToString();

            dateToday.Format = DateTimePickerFormat.Custom;
            dateToday.CustomFormat = "dd-MM-yyyy";

            dtpBookingDate.Text = DateTime.Now.ToString();

            dtpBookingDate.Format = DateTimePickerFormat.Custom;
            dtpBookingDate.CustomFormat = "dd-MM-yyyy";

            dtpStartDate.Text = DateTime.Now.ToString();

            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd-MM-yyyy";

            dtpEndDate.Text = DateTime.Now.ToString();

            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = "dd-MM-yyyy";
        }

        private void dgAdvBookingDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgAdvBookingDetails.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        _entities = new KBBQEntities();

                        var cellId = Convert.ToInt32(dgAdvBookingDetails.CurrentRow.Cells[0].Value);

                        var selectedData1 = _entities.tblAdvBookings.Where(x => x.id == cellId).FirstOrDefault();


                        if (selectedData1 != null)
                        {
                            _entities.tblAdvBookings.Remove(selectedData1);
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong. Record cannot be deleted.");
                        }

                        _entities.SaveChanges();
                        MessageBox.Show("Record deleted ");
                        gridViewBind();

                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void gridViewBind()
        {
            try
            {
                dgAdvBookingDetails.AutoGenerateColumns = false;
                int rowNo = 1;
                _entities = new KBBQEntities();

                List<advBookingVM> modelList = new List<advBookingVM>();

                var advanceBookingData = _entities.tblAdvBookings.Where(x => x.todayDate == dtpStartDate.Value.Date).ToList();

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
                    model.cdate = Convert.ToDateTime(item.cdate).ToString("dd-MM-yyyy");
                    model.recptNo = item.recptNo;
                    model.id = item.id;

                    modelList.Add(model);

                }
                dgAdvBookingDetails.DataSource = modelList;
                lblTotalRows.Text = modelList.Count.ToString();
            }

            catch (Exception x)
            {

            }
        }

        private void dgAdvBookingDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgAdvBookingDetails.CurrentRow.Index != -1 && dgAdvBookingDetails.CurrentRow.Cells[1].Value != null)
                {
                    var lID = Convert.ToInt32(dgAdvBookingDetails.CurrentRow.Cells[0].Value);

                    _entities = new KBBQEntities();
                    var seeData = _entities.tblAdvBookings.Where(x => x.id == lID).FirstOrDefault();

                    if (seeData != null)
                    {
                        if (seeData.status == "UNPAID")
                        {
                            txtCustName.Text = seeData.custName.Trim().ToString();
                            txtMob.Text = seeData.mob.ToString();
                            txtAdults.Text = seeData.adults.ToString();
                            txtChild.Text = seeData.child.ToString();
                            txtAdvPayment.Text = seeData.advancePayment.ToString();
                            dtpBookingDate.Text = seeData.eventDate.ToString();



                            passedId = seeData.id;
                            btnCreate.Text = "Update";
                        }
                        else
                        {
                            MessageBox.Show("Cannot able to update as payment is settled", "Error - King Bar beque Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDatSearcsh_Click(object sender, EventArgs e)
        {
            try
            {
                dgAdvBookingDetails.AutoGenerateColumns = false;
                int rowNo = 1;
                _entities = new KBBQEntities();

                List<advBookingVM> modelList = new List<advBookingVM>();

                var advanceBookingData = _entities.tblAdvBookings.Where(x => x.eventDate >= dtpStartDate.Value.Date && x.eventDate <= dtpEndDate.Value.Date).ToList();

                foreach (var item in advanceBookingData)
                {
                    advBookingVM model = new advBookingVM();

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
                    model.cdate = Convert.ToDateTime(item.cdate).ToString("dd-MM-yyyy");
                    model.recptNo = item.recptNo;
                    model.id = item.id;

                    modelList.Add(model);

                }
                dgAdvBookingDetails.DataSource = modelList;
                lblTotalRows.Text = modelList.Count.ToString();
            }

            catch (Exception x)
            {

            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            clear();


            gridViewBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmAdvBooking_Load(sender, e);
        }

        private void txtMob_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMob.Text, "  ^ [0-9]"))
            {
                txtMob.Text = "";
            }
        }

        private void txtMob_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAdults_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAdults.Text, "  ^ [0-9]"))
            {
                txtAdults.Text = "";
            }
        }

        private void txtAdults_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtChild_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtChild_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtChild.Text, "  ^ [0-9]"))
            {
                txtChild.Text = "";
            }
        }

        private void txtAdvPayment_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAdvPayment.Text, "  ^ [0-9]"))
            {
                txtAdvPayment.Text = "";
            }
        }

        private void txtCustName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCustName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }

        }
    }
}

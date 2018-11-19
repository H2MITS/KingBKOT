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
using System.Diagnostics;
using System.IO;

namespace Cindy_Restaurant.Forms
{
    public partial class orderInfo : Form
    {
        object keyboardProc;
        public orderInfo()
        {
            InitializeComponent();
        }

        KBBQEntities _entities;

        ErrorProvider err = new ErrorProvider();
        public string orderType;
        frmOrder orderTable = new frmOrder();
        frmTheTables table_Forms = new frmTheTables();
        public int hiddFashCash = 0;

        public string Dates, Times;
        private void orderInfo_Load(object sender, EventArgs e)
        {
            try
            {
                _entities = new KBBQEntities();

                var getempName = _entities.tblEmployees.OrderBy(x => x.fname).ToList();
                cmbWaiter.ValueMember = "id";
                cmbWaiter.DisplayMember = "fname";
                cmbWaiter.DataSource = getempName;


            }
            catch (Exception x)
            {

            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            valChildNo(txtChild);
            valAdultNo(txtAdultNo);
            if (err.GetError(txtChild).Length != 0)
            {

                err.SetIconAlignment(txtChild, ErrorIconAlignment.MiddleLeft);
                err.SetError(txtChild, "Input not a number");
                return;
            }
            else if (err.GetError(txtAdultNo).Length != 0)
            {
                err.SetIconAlignment(txtAdultNo, ErrorIconAlignment.MiddleLeft);
                err.SetError(txtAdultNo, "Input not a number");
                return;

            }
            else
            {

                //make a default of 1


                if (txtAdultNo.Text.Trim().Length == 0)
                {
                    txtAdultNo.Text = 1.ToString();
                }
                //make a default of 0


                if (txtChild.Text.Trim().Length == 0)
                {
                    txtChild.Text = 0.ToString();

                }


                orderTable.fname = txtFirst.Text;
                orderTable.lname = txtLast.Text;
                Dates = dateTimePicker1.Value.ToShortDateString();
                Times = dateTimePicker1.Value.ToShortTimeString();
                orderTable.lblgetDateTime.Text = Dates + " " + Times;
                orderTable.lblAdultNo.Text = txtAdultNo.Text;
                orderTable.lblChild.Text = txtChild.Text;
                orderTable.lblgetGuestName.Text = txtFirst.Text + " " + txtLast.Text;
                orderTable.lblTableNo.Text = txtTableNo.Text;

                if (txtTableNo.Text.Equals("0"))
                {

                    orderTable.lblOrderDescription.Text = orderType;
                }
                else
                {
                    orderTable.lblOrderDescription.Text = txtReceiptType.Text.Trim();
                }

                // orderTable.lblwaiterName.Text = this.txtWaiterName.Text.Trim();
                orderTable.lblwaiterName.Text = this.cmbWaiter.Text.Trim();
                table_Forms.Hide(); //make frmTable invisible
                this.Hide();

                if (hiddFashCash == 1)
                {
                    orderTable.hiddFashCash = 1;
                }

                orderTable.ShowDialog();

            }
        }

        private void txtAdultNo_TextChanged(object sender, EventArgs e)
        {
            valAdultNo((Control)sender);
        }

        private void txtChild_TextChanged(object sender, EventArgs e)
        {
            valChildNo((Control)sender);
        }

        void valAdultNo(Control ctrl)
        {
            int num;

            if (txtAdultNo.Text.Trim().Length == 0)
            {
                txtAdultNo.Text = "1";
                err.SetIconAlignment(txtAdultNo, ErrorIconAlignment.MiddleLeft);
                err.SetError(txtAdultNo, "");
            }

            else if (txtAdultNo.Text.Trim().Length != 0)
            {
                if (int.TryParse(txtAdultNo.Text, out num) == true)
                {
                    err.SetIconAlignment(txtAdultNo, ErrorIconAlignment.MiddleLeft);
                    err.SetError(txtAdultNo, "");

                }
                else
                {
                    err.SetIconAlignment(txtAdultNo, ErrorIconAlignment.MiddleLeft);
                    err.SetError(txtAdultNo, "Input not a number");
                    return;
                }
            }





        }

        void valChildNo(Control ctrl)
        {
            int num;

            if (txtChild.Text.Trim().Length == 0)
            {
                txtChild.Text = "0";
                err.SetIconAlignment(txtChild, ErrorIconAlignment.MiddleLeft);
                err.SetError(txtChild, "");

            }

            //child textbox contain an input
            else if (txtChild.Text.Trim().Length != 0)
            {

                if (int.TryParse(txtChild.Text, out num) == true)
                {
                    err.SetIconAlignment(txtChild, ErrorIconAlignment.MiddleLeft);
                    err.SetError(txtChild, "");

                }
                else
                {
                    err.SetIconAlignment(txtChild, ErrorIconAlignment.MiddleLeft);
                    err.SetError(txtChild, "Input not a number");
                    return;
                }
            }



        }

        private void txtChild_Leave(object sender, EventArgs e)
        {
            valChildNo((Control)sender);
        }

        private void txtAdultNo_Leave(object sender, EventArgs e)
        {
            valAdultNo((Control)sender);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdultNo.Text = string.Empty;
            txtChild.Text = string.Empty;
            txtFirst.Text = string.Empty;
            txtLast.Text = string.Empty;
            txtReceiptType.Text = string.Empty;
            txtTableNo.Text = string.Empty;
            txtWaiterName.Text = string.Empty;
            cmbWaiter.SelectedIndex = 0;
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cindy_Restaurant.Form_View;
using Cindy_Restaurant.Classes;
using System.Data.SqlClient;
using KingBKOT.Data;
using KingBKOT.ViewModel;
using System.Diagnostics;
using System.IO;

namespace Cindy_Restaurant.Forms
{
    public partial class frmSettlement : Form
    {
        object keyboardProc;
        public frmSettlement()
        {
            InitializeComponent();
        }

        KBBQEntities _entities;

        clsSelect selectClass;
        clsInsert insertClass;
        clsUpdate updateClass;
        clsdelete deleteClass;
        double AmtPay, RateConvert = 1, changeDue;
        double parseAmt;
        clsView viewClass = new clsView();
        frmViewOrderSettlement fvos = new frmViewOrderSettlement();
        //   frmReceiptPreview rcs;
        public string getCashierName;
        public string KOTnum;

        public List<billAndSettlementVM> recNoList = new List<billAndSettlementVM>();
        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmSettlement_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            errorProvider1.SetError(txtAmtPAid, "Enter Amount to be paid");
            cboPaymentType.SelectedIndex = 0;
            selectClass = new clsSelect();

            //get the methods from the select class
            //   selectClass.addCurrencyToComboBox(cboSelectCurrency);
            //   selectClass.addCurrencyToComboBox(cboPOSCurrency);
            //  selectClass.selectCurrencyUsedToComboBox(cboPaymentType);
            //selectClass.selectCurrencyUsedFromLabel(lblCurcsonvertFrom, "Inused");
            //  selectClass.addElectronicCurrencyToComboBox(posEelectronicType);
            // selectClass.selectCurrencyUsedToLabel(lblConverTo, cboSelectCurrency);


            //   selectClass.selectInitialCurrencyUsedToComboBox(cboSelectCurrency);

            //selectClass.selectCurrencyUsedFromLabel(lblUsedCurrency, "Inused");

            //  lblGetSymbol.Text = lblcustCurrency.Text;
            //  lblUsedCurr.Text = lblUsedCurrency.Text;
            btnCashout.Enabled = false;
        }

        private void cboSelectCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectClass = new clsSelect();
            //  selectClass.selectCurrencyUsedToLabel(lblConverTo, cboSelectCurrency);

            //selectClass.selectCurrencyUsedToLabel(lblcustCurrency, cboSelectCurrency);
            lblcustCurrency.Text = cboSelectCurrency.Text;
            //  lblCurcsonvertFrom.Text = lblcustCurrency.Text;
            //lblGetSymbol.Text = lblcustCurrency.Text;
            label15.Text = lblcustCurrency.Text;
            // lblUsedCurr.Text = lblUsedCurrency.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            //insertClass = new clsInsert();
            //string cashier = selectClass.getEmployeeByID(getCashierName);
            //MessageBox.Show(KOTnum);
            //insertClass.insertTodetailsSettlement(txtReceiptNum.Text, dateTimePicker1, dateTimePicker1, lblUsedCurrency.Text, double.Parse(txtCustOwes.Text),  0.0, "POS", txtAcctName.Text, txtAcctNum.Text, posEelectronicType.SelectedItem.ToString(), cashier);
            //POSupdateBillAndSettlement("PAID");
            //this.Close();

        }

        private void txtCustOwes_TextChanged(object sender, EventArgs e)
        {
            txtBill.Text = txtCustOwes.Text;
        }

        private void txtAmtPAid_TextChanged(object sender, EventArgs e)
        {

            //Lets first test to make sure the input and rate is of a number character
            AmtPay = double.TryParse(txtAmtPAid.Text, out parseAmt) ? parseAmt : double.Parse("0");
            // RateConvert = double.TryParse(lblConverTo.Text, out parseRateConvert) ? parseRateConvert : double.Parse("0");

            txtAmtToPay.Text = txtAmtPAid.Text;
            txtRateTimesAmtPaid.Text = (AmtPay * RateConvert).ToString();

            valAmtPaid((Control)sender);
        }

        private void txtReceiptNum_TextChanged(object sender, EventArgs e)
        {
            txtReceiptNo.Text = txtReceiptNum.Text;
        }

        double ComputePayment()
        {

            //Lets first test to make sure the input and rate is of a number character
            AmtPay = double.TryParse(txtAmtPAid.Text, out parseAmt) ? parseAmt : double.Parse("0");
            // RateConvert = double.TryParse(lblConverTo.Text, out parseRateConvert) ? parseRateConvert : double.Parse("0");

            //customer payement - customer owes

            changeDue = (AmtPay * RateConvert) - double.Parse(txtCustOwes.Text);

            return changeDue;

        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            deleteClass = new clsdelete();
            if (voidID == "")
            {
                MessageBox.Show("Please click to select a row to void", "Help - King Bar Beque...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Font myFont = new Font("Sans Serif", 8, FontStyle.Strikeout, GraphicsUnit.Point);
            dataGridView1.Rows[0].Cells[0].Style.Font = myFont;
            dataGridView1.Rows[0].Cells[1].Style.Font = myFont;
            dataGridView1.Rows[0].Cells[2].Style.Font = myFont;
            dataGridView1.Rows[0].Cells[3].Style.Font = myFont;
            deleteClass.deleteDetailsSettlementByID(voidID);//this is the id used to void the specific kot
            POSupdateBillAndSettlement("UNPAID");

        }

        private void btnCashout_Click(object sender, EventArgs e)
        {
            
            _entities = new KBBQEntities();
            if (recNoList == null || recNoList.Count==0)
            {
                updateClass = new clsUpdate();
                insertClass = new clsInsert();

                frmPopupChange popChange = new frmPopupChange();

                popChange.label3.Text = string.Format("{0:n2}", double.Parse(ComputePayment().ToString()));
                popChange.ShowDialog();
                string cashier = selectClass.getWaiterByID(getCashierName);


                insertClass.insertTodetailsSettlement(txtReceiptNum.Text, dateTimePicker1, dateTimePicker1, "Inr", double.Parse(txtCustOwes.Text), "Inr", double.Parse(txtRateTimesAmtPaid.Text), changeDue, "Cash", "-", "-", "-", cashier, txtReceiptNo.Text.Trim());

                if (txtDisc.Text == string.Empty)
                {
                    txtDisc.Text = "0";
                }

                updateClass.updateBillAndSettlement(this.txtReceiptNum.Text, "PAID", txtCode.Text, Convert.ToDecimal(txtDisc.Text));

            }
            else
            {
                updateClass = new clsUpdate();
                insertClass = new clsInsert();

                frmPopupChange popChange = new frmPopupChange();

                popChange.label3.Text = string.Format("{0:n2}", double.Parse(ComputePayment().ToString()));
                popChange.ShowDialog();
                string cashier = selectClass.getWaiterByID(getCashierName);

                if (txtDisc.Text == string.Empty)
                {
                    txtDisc.Text = "0";
                }

                decimal amtTemp = 0,lastPaid=0;
                string lastKot = "";
                foreach (var item in recNoList)
                {
                    decimal amtFromKOT = _entities.billAndSettlements.Where(x => x.kot == item.kot).FirstOrDefault().totalDue;

                    amtTemp += amtFromKOT;

                    insertClass.insertTodetailsSettlement(item.kot, dateTimePicker1, dateTimePicker1, "Inr", double.Parse(amtFromKOT.ToString()), "Inr", double.Parse(amtFromKOT.ToString()), 0, "Cash", "-", "-", "-", cashier, txtReceiptNo.Text.Trim());

                    updateClass.updateBillAndSettlement(item.kot, "PAID", txtCode.Text, Convert.ToDecimal(txtDisc.Text));
                    lastKot = item.kot;
                    lastPaid = amtFromKOT;
                }


                if (Convert.ToDecimal(txtRateTimesAmtPaid.Text) > amtTemp)
                {
                    amtTemp = Convert.ToDecimal(txtRateTimesAmtPaid.Text) - amtTemp;

                    lastPaid = lastPaid + amtTemp;

                    updateClass.updateDetailsBillAndSettlement(lastKot, double.Parse(lastPaid.ToString()),changeDue);
                }
                if (Convert.ToDecimal(txtRateTimesAmtPaid.Text) < amtTemp)
                {
                    amtTemp = amtTemp - Convert.ToDecimal(txtRateTimesAmtPaid.Text);

                    lastPaid = lastPaid - amtTemp;

                    amtTemp = Convert.ToDecimal(txtRateTimesAmtPaid.Text) - amtTemp;
                    updateClass.updateDetailsBillAndSettlement(lastKot, double.Parse(lastPaid.ToString()),changeDue);
                }

            }
            MessageBox.Show("Payment successfully taken", "SAVED - King Bar Beque Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Close();

        }

        void valAmtPaid(Control ctrl)
        {
            ErrorProvider err = new ErrorProvider();
            double amt;
            if ((txtAmtPAid.Text.Length > 0) && (double.TryParse(txtAmtPAid.Text, out amt) == true))
            {
                btnCashout.Enabled = true;
                txtCode.Enabled = true;
                txtDisc.Enabled = true;
            }
            else
            {
                txtCode.Enabled = false;
                txtDisc.Enabled = false;
                btnCashout.Enabled = false;
            }
        }



        void valAmtPOSPaid(Control ctrl)
        {

            //double amt;
            //if ((txtPosPaid.Text.Trim().Length > 0) && (double.TryParse(txtPosPaid.Text, out amt) == true))
            //{
            //    btnPosPaid.Enabled = true;

            //}
            //else
            //{
            //    btnPosPaid.Enabled = false;
            //}
        }

        private void txtAmtPAid_Leave(object sender, EventArgs e)
        {
            valAmtPaid((Control)sender);
        }

        private void txtPosPaid_TextChanged(object sender, EventArgs e)
        {
            valAmtPOSPaid((Control)sender);
        }

        private void txtPosPaid_Leave(object sender, EventArgs e)
        {
            valAmtPOSPaid((Control)sender);
        }

        private void cboPOSCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  posCurChoice.Text = cboPOSCurrency.SelectedItem.ToString();
        }

        //ACCT NAME
        void valAccName(Control ctrl)
        {
            //if (txtAcctName.Text.Trim().Length > 0)
            //{
            //    clsInsert.err.SetError(txtAcctName, string.Empty);

            //}
            //else
            //{
            //    clsInsert.err.SetIconAlignment(txtAcctName, ErrorIconAlignment.MiddleLeft);
            //    clsInsert.err.SetError(txtAcctName, "Field can\'t be empty");
            //    return;
            //}

        }
        void valAccNum(Control ctrl)
        {
            //double num;
            //if ((txtAcctNum.Text.Trim().Length == 13) && double.TryParse(txtAcctNum.Text,out num)==true && !txtAcctNum.Text.Contains("."))
            //{

            //    clsInsert.err.SetError(txtAcctNum, string.Empty);

            //}
            //else
            //{
            //    clsInsert.err.SetIconAlignment(txtAcctNum, ErrorIconAlignment.MiddleLeft);
            //    clsInsert.err.SetError(txtAcctNum, "Field is either empty or text length is less than 13");
            //    return;
            //}

        }

        private void txtAcctNum_TextChanged(object sender, EventArgs e)
        {
            valAccNum((Control)sender);
        }

        private void txtAcctNum_Leave(object sender, EventArgs e)
        {
            valAccNum((Control)sender);
        }

        private void txtAcctName_TextChanged(object sender, EventArgs e)
        {
            valAccName((Control)sender);
        }

        private void txtAcctName_Leave(object sender, EventArgs e)
        {
            valAccName((Control)sender);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            _entities = new KBBQEntities();
            if (recNoList == null)
            {
                //viewClass.viewBillTransaction(dataGridView1, txtReceiptNum.Text.Trim());
                List<billAndSettlementVM> modellist = new List<billAndSettlementVM>();

                billAndSettlementVM model = new billAndSettlementVM();
                var data = _entities.billAndSettlements.Where(x => x.kot == txtReceiptNo.Text.Trim()).FirstOrDefault();

                model.kot = data.kot;
                model.ordDate = data.ordDate;
                model.ordTime = data.ordTime;
                model.totalDue = data.totalDue;

                modellist.Add(model);

                dataGridView1.DataSource = modellist;
            }
            else
            {
                List<billAndSettlementVM> modelList = new List<billAndSettlementVM>();
                foreach (var item in recNoList)
                {
                    billAndSettlementVM model = new billAndSettlementVM();
                    var data = _entities.billAndSettlements.Where(x => x.kot == item.kot).FirstOrDefault();

                    model.kot = data.kot;
                    model.ordDate = data.ordDate;
                    model.ordTime = data.ordTime;
                    model.totalDue = data.totalDue;

                    modelList.Add(model);
                }

                dataGridView1.DataSource = modelList;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtRateTimesAmtPaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //  txtAcctName.Text = string.Empty;
            //  txtAcctNum.Text = string.Empty;
            txtAmtPAid.Text = string.Empty;
            txtAmtToPay.Text = string.Empty;
            //  txtPosPaid.Text = string.Empty;
            txtCustOwes.Text = string.Empty;
            txtBill.Text = string.Empty;
            txtRateTimesAmtPaid.Text = string.Empty;
            txtReceiptNo.Text = string.Empty;
            txtReceiptNum.Text = string.Empty;
            cboPaymentType.SelectedItem = string.Empty;
            // cboPOSCurrency.SelectedItem = string.Empty;
            // posCurChoice.Text = string.Empty;
            // posEelectronicType.SelectedItem = string.Empty;
            cboSelectCurrency.SelectedItem = string.Empty;
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime;

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCode != null)
                {
                    _entities = new KBBQEntities();
                    var coupCode = _entities.billAndSettlements.ToList();

                    foreach (var item in coupCode)
                    {

                        if (item.couponCode != null)
                        {
                            var avail = item.couponCode.Trim().ToString();
                            if (avail == txtCode.Text.Trim().ToString())
                            {
                                MessageBox.Show("Coupon Code already existed.", "Error - King Bar beque Restaurant Coupon Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtCode.Focus();
                                return;
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
            catch (Exception x)
            {

            }
        }


        //UPDATE THE BILL AND SETTLEMENT TABLE

        void POSupdateBillAndSettlement(string mode)
        {

            try
            {
                //getting field members from select class
                selectClass.con = new SqlConnection(selectClass.dbPath);
                selectClass.con.Open();
                string updateString = "update billAndSettlement set mode=@mode where kot='" + txtReceiptNo.Text.TrimEnd() + "'";
                selectClass.cmd = new SqlCommand(updateString, selectClass.con);
                selectClass.cmd.Parameters.AddWithValue("@mode", mode.Trim());

                selectClass.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error - King Bar Beque Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void txtDisc_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtDisc.Text != null)
                {

                    var rateAfterDisc = (Convert.ToInt32(txtAmtPAid.Text) * Convert.ToInt32(txtDisc.Text)) / 100;

                    rateAfterDisc = Convert.ToInt32(txtAmtPAid.Text) - rateAfterDisc;

                    txtRateTimesAmtPaid.Text = rateAfterDisc.ToString();
                }
                else
                {

                }
            }
            catch (Exception x)
            {
               // MessageBox.Show("Error: " + x.ToString(), "Error - King Bar Beque Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
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

        string voidID = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                voidID = row.Cells[0].Value.ToString();
            }
        }

    }
}

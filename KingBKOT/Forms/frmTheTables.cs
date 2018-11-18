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

namespace Cindy_Restaurant.Forms
{
    public partial class frmTheTables : Form
    {
        KBBQEntities _entities;
        public frmTheTables()
        {
            InitializeComponent();
        }
         
        public string empID, receiptType;
        private void frmTheTables_Load(object sender, EventArgs e)
        {
           // checkTableOccupied();


        }

       private void checkTableOccupied()
        {
            _entities = new KBBQEntities();

            var checkPaid = _entities.tblOrderInfoes.ToList();

            if (checkPaid != null)
            {
                foreach (var item in checkPaid)
                {
                    var status = _entities.billAndSettlements.Where(x => x.kot == item.KOT).FirstOrDefault();

                    if (status.mode == "UNPAID")
                    {
                        if (item.tableNo == "1")
                        {
                            btn1.Enabled = false;
                            btn1.BackColor = Color.Red;
                        }
                        if (item.tableNo == "2")
                        {
                            btn2.Enabled = false;
                            btn2.BackColor = Color.Red;
                        }
                        if (item.tableNo == "3")
                        {
                            btn3.Enabled = false;
                            btn3.BackColor = Color.Red;
                        }
                        if (item.tableNo == "4")
                        {
                            btn4.Enabled = false;
                            btn4.BackColor = Color.Red;
                        }
                        if (item.tableNo == "5")
                        {
                            btn5.Enabled = false;
                            btn5.BackColor = Color.Red;
                        }
                        if (item.tableNo == "6")
                        {
                            btn6.Enabled = false;
                            btn6.BackColor = Color.Red;
                        }
                        if (item.tableNo == "7")
                        {
                            btn7.Enabled = false;
                            btn7.BackColor = Color.Red;
                        }
                        if (item.tableNo == "8")
                        {
                            btn8.Enabled = false;
                            btn8.BackColor = Color.Red;
                        }
                        if (item.tableNo == "9")
                        {
                            btn9.Enabled = false;
                            btn9.BackColor = Color.Red;
                        }
                        if (item.tableNo == "10")
                        {
                            btn10.Enabled = false;
                            btn10.BackColor = Color.Red;
                        }
                        if (item.tableNo == "11")
                        {
                            btn11.Enabled = false;
                            btn11.BackColor = Color.Red;
                        }
                        if (item.tableNo == "12")
                        {
                            btn12.Enabled = false;
                            btn12.BackColor = Color.Red;
                        }
                        if (item.tableNo == "13")
                        {
                            btn13.Enabled = false;
                            btn13.BackColor = Color.Red;
                        }
                        if (item.tableNo == "14")
                        {
                            btn14.Enabled = false;
                            btn14.BackColor = Color.Red;
                        }
                        if (item.tableNo == "15")
                        {
                            btn15.Enabled = false;
                            btn15.BackColor = Color.Red;
                        }
                        if (item.tableNo == "16")
                        {
                            btn16.Enabled = false;
                            btn16.BackColor = Color.Red;
                        }
                        if (item.tableNo == "17")
                        {
                            btn17.Enabled = false;
                            btn17.BackColor = Color.Red;
                        }
                        if (item.tableNo == "18")
                        {
                            btn18.Enabled = false;
                            btn18.BackColor = Color.Red;
                        }
                        if (item.tableNo == "19")
                        {
                            btn19.Enabled = false;
                            btn19.BackColor = Color.Red;
                        }
                        if (item.tableNo == "20")
                        {
                            btn20.Enabled = false;
                            btn20.BackColor = Color.Red;
                        }
                    }
                    else
                    {

                        if (item.tableNo == "1")
                        {
                            btn1.Enabled = true;
                            btn1.BackColor = Color.Green;
                        }
                        if (item.tableNo == "2")
                        {
                            btn2.Enabled = true;
                            btn2.BackColor = Color.Green;
                        }
                        if (item.tableNo == "3")
                        {
                            btn3.Enabled = true;
                            btn3.BackColor = Color.Green;
                        }
                        if (item.tableNo == "4")
                        {
                            btn4.Enabled = true;
                            btn4.BackColor = Color.Green;
                        }
                        if (item.tableNo == "5")
                        {
                            btn5.Enabled = true;
                            btn5.BackColor = Color.Green;
                        }
                        if (item.tableNo == "6")
                        {
                            btn6.Enabled = true;
                            btn6.BackColor = Color.Green;
                        }
                        if (item.tableNo == "7")
                        {
                            btn7.Enabled = true;
                            btn7.BackColor = Color.Green;
                        }
                        if (item.tableNo == "8")
                        {
                            btn8.Enabled = true;
                            btn8.BackColor = Color.Green;
                        }
                        if (item.tableNo == "9")
                        {
                            btn9.Enabled = true;
                            btn9.BackColor = Color.Green;
                        }
                        if (item.tableNo == "10")
                        {
                            btn10.Enabled = true;
                            btn10.BackColor = Color.Green;
                        }
                        if (item.tableNo == "11")
                        {
                            btn11.Enabled = true;
                            btn11.BackColor = Color.Green;
                        }
                        if (item.tableNo == "12")
                        {
                            btn12.Enabled = true;
                            btn12.BackColor = Color.Green;
                        }
                        if (item.tableNo == "13")
                        {
                            btn13.Enabled = true;
                            btn13.BackColor = Color.Green;
                        }
                        if (item.tableNo == "14")
                        {
                            btn14.Enabled = true;
                            btn14.BackColor = Color.Green;
                        }
                        if (item.tableNo == "15")
                        {
                            btn15.Enabled = true;
                            btn15.BackColor = Color.Green;
                        }
                        if (item.tableNo == "16")
                        {
                            btn16.Enabled = true;
                            btn16.BackColor = Color.Green;
                        }
                        if (item.tableNo == "17")
                        {
                            btn17.Enabled = true;
                            btn17.BackColor = Color.Green;
                        }
                        if (item.tableNo == "18")
                        {
                            btn18.Enabled = true;
                            btn18.BackColor = Color.Green;
                        }
                        if (item.tableNo == "19")
                        {
                            btn19.Enabled = true;
                            btn19.BackColor = Color.Green;
                        }
                        if (item.tableNo == "20")
                        {
                            btn20.Enabled = true;
                            btn20.BackColor = Color.Green;
                        }
                    }
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn1.Text.ToString();
            frm1.ShowDialog();
           // checkTableOccupied();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn2.Text.ToString();
            frm1.ShowDialog();
            //checkTableOccupied();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn3.Text.ToString();
            frm1.ShowDialog();
            //checkTableOccupied();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn4.Text.ToString();
            frm1.ShowDialog();
           // checkTableOccupied();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn5.Text.ToString();
            frm1.ShowDialog();
           // checkTableOccupied();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn6.Text.ToString();
            frm1.ShowDialog();
           // checkTableOccupied();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn7.Text.ToString();
            frm1.ShowDialog();
           // checkTableOccupied();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn8.Text.ToString();
            frm1.ShowDialog();
          //  checkTableOccupied();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn9.Text.ToString();
            frm1.ShowDialog();
          //  checkTableOccupied();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn10.Text.ToString();
            frm1.ShowDialog();
            //checkTableOccupied();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();

            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn11.Text.ToString();
            frm1.ShowDialog();
            //checkTableOccupied();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn12.Text.ToString();
            frm1.ShowDialog();
           // checkTableOccupied();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn13.Text.ToString();
            frm1.ShowDialog();
            //checkTableOccupied();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn14.Text.ToString();
            frm1.ShowDialog();
            //checkTableOccupied();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn15.Text.ToString();
            frm1.ShowDialog();
           // checkTableOccupied();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn16.Text.ToString();
            frm1.ShowDialog();
          //  checkTableOccupied();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn17.Text.ToString();
            frm1.ShowDialog();
          //  checkTableOccupied();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn19.Text.ToString();
            frm1.ShowDialog();
          //  checkTableOccupied();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn19.Text.ToString();
            frm1.ShowDialog();
          //  checkTableOccupied();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            orderInfo frm1 = new orderInfo();
            frm1.txtReceiptType.Text = receiptType;
            frm1.txtWaiterName.Text = empID.Trim();
            frm1.txtTableNo.Text = this.btn20.Text.ToString();
            frm1.ShowDialog();
            //checkTableOccupied();
        }
    }
}

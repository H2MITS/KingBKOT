using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cindy_Restaurant.Classes;
using Cindy_Restaurant.Forms;
using Cindy_Restaurant.Form_View;
using Cindy_Restaurant.Folder_Updates;
using KingBKOT.Form_View;
using KingBKOT.Data;


namespace Cindy_Restaurant
{
    public partial class frmParent : Form
    {
        KBBQEntities _entities;

        public frmParent()
        {
            InitializeComponent();
        }

        public int getLogNum;
        DateTime dayTime = new DateTime();
        clsSelect selectClass = new clsSelect();
        clsUpdate updateClass = new clsUpdate();
        public string emPloID;
        public string getIDNumber;

        ComboBox lblCur = new ComboBox();// pull the default currency;
        private void frmParent_Load(object sender, EventArgs e)
        {
            selectClass.getEmployeeByID(statGetUser.Text.ToString());
            emPloID = selectClass.getEmployeeID;
            timer1.Start();
        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {
            frmDeveloper vDeveloper = new frmDeveloper();
            vDeveloper.ShowDialog();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           dayTime = DateTime.Now;
            statGetDate.Text = dayTime.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult reason = MessageBox.Show("Are sure you wanna close shift", "Close Shift- King Bar Beque Restaurant", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (reason.Equals(DialogResult.OK)) {
                getCashierReportText();
                DateTimePicker endDay = new DateTimePicker();
                updateClass.updateLogHistory(getLogNum, statGetUser.Text, endDay, endDay);
                this.Close();
        }
    }

        private void button5_Click(object sender, EventArgs e)
        {
            frmRegEmp regEmeployee = new frmRegEmp();
            regEmeployee.ShowDialog();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            frmAddUsers addUsers = new frmAddUsers();
            addUsers.ShowDialog();
        }

        private void btnRecall_Click(object sender, EventArgs e)
        {
            receiptList recallForm = new receiptList();
            selectClass.getEmployeeByID(this.statGetUser.Text);
            recallForm.lblGetId.Text = selectClass.getEmployeeID;
            recallForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTheTables tableorder = new frmTheTables();
            tableorder.empID = this.statGetUser.Text;
            tableorder.receiptType = btnDineIn.Text;
           
            tableorder.ShowDialog();
        }

        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            orderInfo infoOrder = new orderInfo();
            
            infoOrder.txtWaiterName.Text = this.statGetUser.Text;
            infoOrder.txtTableNo.Text = "0";
            //infoOrder.txtAdultNo.Text = "1";
            //infoOrder.txtChild.Text = "0";
            infoOrder.txtReceiptType.Text = btnTakeAway.Text;
            infoOrder.orderType = btnTakeAway.Text;
            infoOrder.ShowDialog();
        }

        private void btnNocharge_Click(object sender, EventArgs e)
        {
            frmTheTables tableorder = new frmTheTables();
            tableorder.receiptType = btnNocharge.Text;
            
            tableorder.empID = this.statGetUser.Text;
            tableorder.ShowDialog();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
           frmChangePass  passChange = new frmChangePass();
            passChange.getEmpName = this.statGetUser.Text;
            passChange.ShowDialog();
        }

        private void btnBakup_Click(object sender, EventArgs e)
        {
            updateClass.BackUp();
        }

        private void btnCuurency_Click(object sender, EventArgs e)
        {
            frmCurrency curr = new frmCurrency();
            curr.ShowDialog();
        }

        private void btnAddPOSCurrency_Click(object sender, EventArgs e)
        {
            frmAddElectronicCurrency elecAdd = new frmAddElectronicCurrency();
            elecAdd.ShowDialog();
        }

        private void btnAddMenus_Click(object sender, EventArgs e)
        {
            frmProductReg prodAdd = new frmProductReg();
            prodAdd.ShowDialog();
        }

        private void btnAddMenuGroup_Click(object sender, EventArgs e)
        {
            frmProdType prodType = new frmProdType();
            prodType.ShowDialog();
        }

        private void btnVCurrency_Click(object sender, EventArgs e)
        {
            frmViewCurrency vCurr = new frmViewCurrency();
            vCurr.ShowDialog();
        }

        private void btnVPOS_Click(object sender, EventArgs e)
        {
            frmViewElectronicCurrency vPOS = new frmViewElectronicCurrency();
            vPOS.ShowDialog();
        }

        private void btnVEmployee_Click(object sender, EventArgs e)
        {
            frmViewEmployees vEmployee = new frmViewEmployees();
            vEmployee.ShowDialog();
        }

        private void btnVUsers_Click(object sender, EventArgs e)
        {
            frmViewUsers vUsers = new frmViewUsers();
            vUsers.ShowDialog();
        }

        private void btnVLogins_Click(object sender, EventArgs e)
        {
            frmViewLogHistory vLogs = new frmViewLogHistory();
            vLogs.ShowDialog();
        }

        private void btnVorder_Click(object sender, EventArgs e)
        {
            frmViewOrderInfo vOrder = new frmViewOrderInfo();
            vOrder.ShowDialog();
        }

        private void btnVProducts_Click(object sender, EventArgs e)
        {
            frmViewProducts vProd = new frmViewProducts();
            vProd.ShowDialog();
        }

        private void btnVProdTypes_Click(object sender, EventArgs e)
        {
            frmViewProductTypes vProdType = new frmViewProductTypes();
            vProdType.ShowDialog();
        }

        private void btnVtaxes_Click(object sender, EventArgs e)
        {
            frmViewTax vTax = new frmViewTax();
            vTax.ShowDialog();
        }

        //cashier information
         
        private void getCashierReportText()
        {
            try
            {
                selectClass.selectShiftNumberAndTimeFromLoginHistory(this.statGetUser.Text);
                string cashierID = selectClass.getEmployeeByID(this.statGetUser.Text);

                selectClass.sumAllCash(cashierID, Convert.ToDateTime(selectClass.logDates), dayTime.Date);
                selectClass.sumAllPOS(cashierID, Convert.ToDateTime(selectClass.logDates), dayTime.Date);
                //cashier report goes here
                frmVCashierReport repCashier = new frmVCashierReport();
                repCashier.textBox1.AppendText("\t\tCASHIER REPORT" + Environment.NewLine);
                repCashier.textBox1.AppendText("*******************************************" + Environment.NewLine);
                repCashier.textBox1.AppendText("Shift No. : " + selectClass.shifts + Environment.NewLine);
                repCashier.textBox1.AppendText(Environment.NewLine + "User : " + this.statGetUser.Text + Environment.NewLine);
                repCashier.textBox1.AppendText(Environment.NewLine + "Time In : " + selectClass.logDates + " " + selectClass.tymer + Environment.NewLine);
                repCashier.textBox1.AppendText(Environment.NewLine + "Time out : " + statGetDate.Text + Environment.NewLine);
                repCashier.textBox1.AppendText(Environment.NewLine + "*******************************************" + Environment.NewLine);
                repCashier.textBox1.AppendText("\tTOTAL PAYMENT RECIEVED" + Environment.NewLine);
                repCashier.textBox1.AppendText("*******************************************" + Environment.NewLine);
                repCashier.textBox1.AppendText(Environment.NewLine + "CASH : " + selectClass.cashValue + Environment.NewLine);
                repCashier.textBox1.AppendText(Environment.NewLine + "*******************************************" + Environment.NewLine);
                repCashier.textBox1.AppendText("\tADDING UP CASH " + Environment.NewLine);
                repCashier.textBox1.AppendText("*******************************************" + Environment.NewLine);

                repCashier.textBox1.AppendText(Environment.NewLine + "TOTAL : " + selectClass.selectCurrencyUsedToComboBox(repCashier.textBox1.Text.ToString()) + (selectClass.POSvalue + selectClass.cashValue) + Environment.NewLine);
                repCashier.textBox1.AppendText(Environment.NewLine + "CLOSING DAY SALES AT :  " + selectClass.selectCurrencyUsedToComboBox(repCashier.textBox1.Text.ToString()) + (selectClass.POSvalue + selectClass.cashValue) + Environment.NewLine);
                repCashier.textBox1.AppendText(Environment.NewLine + "*******************************************" + Environment.NewLine);
                repCashier.textBox1.AppendText(Environment.NewLine + "Thank you for a stupendous work");
                repCashier.textBox1.AppendText("*******************************************" + Environment.NewLine);

                repCashier.ShowDialog();

            }
            catch(Exception x)
            {
                MessageBox.Show("Something went wrong.");
            }
        
        }

        private void btnVsalesRports_Click(object sender, EventArgs e)
        {
            getCashierReportText();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmVDetailsSettlement vDetails = new frmVDetailsSettlement();
            vDetails.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmVFreezeItems vFreeze = new frmVFreezeItems();
            vFreeze.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmVNetSales netSales = new frmVNetSales();
            netSales.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmVTaxSales vTaxSales = new frmVTaxSales();
            vTaxSales.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmPurchaseType frm = new frmPurchaseType();
            frm.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _entities = new KBBQEntities();

            orderInfo infoOrder = new orderInfo();

            infoOrder.txtWaiterName.Text = this.statGetUser.Text;
            infoOrder.txtTableNo.Text = "0";
            infoOrder.hiddFashCash = 1;
            //infoOrder.txtAdultNo.Text = "1";
            //infoOrder.txtChild.Text = "0";
            infoOrder.txtReceiptType.Text = button2.Text;
            infoOrder.orderType = button2.Text;

           var empIDD= selectClass.getEmployeeByID(statGetUser.Text.ToString());

            infoOrder.cmbWaiter.SelectedText = this.statGetUser.Text;
            infoOrder.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPurchaseSaleReport frm = new frmPurchaseSaleReport();
            frm.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

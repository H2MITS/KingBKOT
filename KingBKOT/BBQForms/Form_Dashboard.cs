using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using KingBKOT.Forms;
using KingBarbeque;
using Cindy_Restaurant.Classes;

namespace TestProject.Forms
{
    public partial class Form_Dashboard : Form
    {
     //   private int _ticks;
        public Form_Dashboard()
        {
            InitializeComponent();
            timer1.Start();
        }

        public int getLogNum;
   //     DateTime dayTime = new DateTime();
        clsSelect selectClass = new clsSelect();
        clsUpdate updateClass = new clsUpdate();
        public string emPloID;
        public string getIDNumber;

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult reason = MessageBox.Show("Are you sure you want to logout", "Close Shift- King Bar Beque", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (reason.Equals(DialogResult.OK))
            {
                //  getCashierReportText();
                DateTimePicker endDay = new DateTimePicker();
                updateClass.updateLogHistory(getLogNum, statGetUser.Text, endDay, endDay);
                this.Close();
            }
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            workingDate.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductMaster pm = new ProductMaster();
            pm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            sr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddCoupon ac = new AddCoupon();
            ac.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PurchaseReport pr = new PurchaseReport();
            pr.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ExpensesReport er = new ExpensesReport();
            er.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmSalesMaster fsm = new frmSalesMaster();
            fsm.ShowDialog();
            //this.Close();
        }

        private void btnEmployeeSalary_Click(object sender, EventArgs e)
        {
            EmployeeMaster em = new EmployeeMaster();
            em.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingMaster sm = new SettingMaster();
            sm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

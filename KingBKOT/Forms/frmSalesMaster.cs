using KingBarbeque;
using KingBarbeque.Forms;
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
using TestProject.Forms;
using System.Drawing.Imaging;

namespace KingBKOT.Forms
{
    public partial class frmSalesMaster : Form
    {
        private object keyboardProc;
        public frmSalesMaster()
        {
            InitializeComponent();
          
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSalesMaster_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

            this.keyboardProc = Process.Start(keyboardPath);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SalesReturn sr = new SalesReturn();
            sr.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            KOT kt = new KOT();
            kt.ShowDialog();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {

            
            Hold hld = new Hold();
            hld.ShowDialog();   
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Unhold unhld = new Unhold();
            unhld.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Orange;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            btnKeyboard.BackColor = Color.Orange;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.MidnightBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnKeyboard.BackColor = Color.MidnightBlue;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            btnDineInn.BackColor = Color.Orange;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btnDineInn.BackColor = Color.MidnightBlue;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            btnTakeAway.BackColor = Color.Orange;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnTakeAway.BackColor = Color.MidnightBlue;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            btnSalesReturn.BackColor = Color.Orange;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            btnSalesReturn.BackColor = Color.MidnightBlue;
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            btnNew.BackColor = Color.Orange;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            btnNew.BackColor = Color.MidnightBlue;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            btnKOT.BackColor = Color.Orange;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            btnKOT.BackColor = Color.MidnightBlue;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            btnHold.BackColor = Color.Orange;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            btnHold.BackColor = Color.MidnightBlue;
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            btnUnhold.BackColor = Color.Orange;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            btnUnhold.BackColor = Color.MidnightBlue;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Orange;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.MidnightBlue;
        }

        //private void button1_MouseEnter(object sender, EventArgs e)
        //{
        //    button1.BackColor = Color.Orange;
        //}

        //private void button7_MouseClick(object sender, MouseEventArgs e)
        //{
        //    button7.BackColor = Color.Orange;
        //}
    }
}


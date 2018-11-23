using Cindy_Restaurant.Forms;
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
using KingBKOT.Data;
using KingBKOT.ViewModel;

namespace KingBKOT.Forms
{
    public partial class frmAdvBookingReceiptNo : Form
    {
        KBBQEntities _entities;
        object keyboardProc;
        public int hiddFashCash;
        public string waiterName;
        public frmAdvBookingReceiptNo()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRecptNo.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            
            _entities = new KBBQEntities();

            long id = Convert.ToInt32(txtRecptNo.Text.Trim());

            var data = _entities.tblAdvBookings.Where(x => x.id == id).FirstOrDefault();

            if (data == null)
            {
                MessageBox.Show("Invalid Advance Booking Receipt No", "Error - King Bar beque Restaurant Logins", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                frmOrder infoOrder = new frmOrder();
                infoOrder.lblwaiterName.Text = waiterName;
                infoOrder.hiddFashCash = 2;
                infoOrder.advBookingId = data.id;
                infoOrder.ShowDialog();

                this.Close();
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

        private void frmAdvBookingReceiptNo_Load(object sender, EventArgs e)
        {
            txtRecptNo.Focus();
        }

        private void txtRecptNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRecptNo_Validating(object sender, CancelEventArgs e)
        {
            if (txtRecptNo.Text.Length == 0)
            {
                errorProvider1.SetError(txtRecptNo, "Please enter Advance receipt number");
                e.Cancel = true;
            }
            else
            {
                //errorProvider1.SetError(txtRecptNo, "");
            }
        }
    }
}

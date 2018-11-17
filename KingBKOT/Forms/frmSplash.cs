using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cindy_Restaurant.Forms;
using KingBarbeque.Forms;

namespace Cindy_Restaurant.Forms
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        SignIn sig = new SignIn();
        private void frmSplash_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label2.Text = "KING BAR BEQUE RESTAURANT";
            label1.Text = "v 1.0.0.1";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           frmLogin  formLogin = new frmLogin();
            progressBar1.Increment(1);

            if (this.progressBar1.Value == 10)
            {
                label3.Visible = true;
                label3.Text = "Starting..";
            }

            else if (this.progressBar1.Value == 20)
            {
                label3.Visible = true;
                label3.Text = "Loading modules..";
            }
            else if (this.progressBar1.Value == 30)
            {
                label3.Visible = true;
                label3.Text = "Processing..";
            }
            else if (this.progressBar1.Value == 40)
            {
                label3.Visible = true;
                label3.Text = "Finishing..";
            }
            else if (this.progressBar1.Value == 50)
            {

                timer1.Stop();
                this.Hide();
                sig.Show();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

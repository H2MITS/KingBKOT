using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using KingBarbeque;

namespace KingBKOT.Forms
{
    public partial class MenuProducts : UserControl
    {

        private object keyboardProc;
        public MenuProducts()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files|*.png|All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured,Please browse image location", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

            this.keyboardProc = Process.Start(keyboardPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductCategory pc = new ProductCategory();
            pc.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrice.Text = string.Empty;
            txtProductName.Text = string.Empty;
            comboCategory.Text = string.Empty;
            pictureBox1.Controls.Clear();
            
        }

        ////private void btnClose_Click(object sender, EventArgs e)
        ////{
        ////    this.Dispose();
        ////}
    }
}

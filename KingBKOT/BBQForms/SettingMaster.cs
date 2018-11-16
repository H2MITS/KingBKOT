using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingBKOT.Forms
{
    public partial class SettingMaster : Form
    {
        
        public SettingMaster()
        {
            InitializeComponent();
            lblSubTItle.Text = "( General Settings )";
        }

        private void btnGeneralSettings_Click(object sender, EventArgs e)
        {
            lblSubTItle.Text = "( General Settings )";

            panel1.Controls.Clear();
            GeneralSettings db = new GeneralSettings();
            panel1.Controls.Add(db);
            panel2.Height = btnGeneralSettings.Height;
            panel2.Top = btnGeneralSettings.Top;
            //db.Dock = DockStyle.Fill;
            db.Show();
        }
    }
}

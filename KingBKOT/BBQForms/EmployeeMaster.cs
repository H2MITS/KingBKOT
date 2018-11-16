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
    public partial class EmployeeMaster : Form
    {
        public EmployeeMaster()
        {
            InitializeComponent();
            panel2.Height = button2.Height;
            panel2.Top = button2.Top;
            lblSubTItle.Text = "( Add Employee Details )";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblSubTItle.Text = "( Add Employee Details )";

            //panel2.Height = button2.Height;
            //panel2.Top = button2.Top;
            //addEmployee1.BringToFront();


            //label1.Text = "Stock Inventory";
            //SidePanel.Height = button2.Height;
            //SidePanel.Top = button2.Top;
            //  mySecondCustomControl1.BringToFront();
            panel1.Controls.Clear();
            AddEmployee db = new AddEmployee();
            panel1.Controls.Add(db);
            panel2.Height = button2.Height;
            panel2.Top = button2.Top;
            //db.Dock = DockStyle.Fill;
            db.Show();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblSubTItle.Text = "( Employee Salary )";

            //panel2.Height = button5.Height;
            //panel2.Top = button5.Top;
            //employeeSalary1.BringToFront();

            panel1.Controls.Clear();
            EmployeeSalary db = new EmployeeSalary();
            panel1.Controls.Add(db); panel2.Height = button2.Height;
            panel2.Top = button2.Top;
            db.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSubTItle.Text = "( List Of Employees )";

            // panel2.Height = button1.Height;
            // panel2.Top = button1.Top;
            //listofEmployee1.BringToFront();

            panel1.Controls.Clear();
ListofEmployee db = new ListofEmployee();
            panel1.Controls.Add(db); panel2.Height = button2.Height;
            panel2.Top = button2.Top;
            db.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblSubTItle.Text = "( Salary Report )";

            //panel2.Height = button4.Height;
            //panel2.Top = button4.Top;
            //salaryReport1.BringToFront();


            panel1.Controls.Clear();
            SalaryReport db = new SalaryReport();
            panel1.Controls.Add(db); panel2.Height = button2.Height;
            panel2.Top = button2.Top;
            //db.Dock = DockStyle.Fill;
            db.Show();
        }

        private void addEmployee2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using Cindy_Restaurant.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Data.SqlClient;
using Cindy_Restaurant;
using System.IO;
using System.Diagnostics;
using KingBKOT.Data;


namespace KingBarbeque.Forms
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        KBBQEntities _entities;

        object keyboardProc;
        clsSelect selectClass = new clsSelect();
        clsInsert varinsert = new clsInsert();
        DateTimePicker day = new DateTimePicker();
        clsInsert insertClass = new clsInsert();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        //public void btnLogin_Click(object sender, EventArgs e)
        // {
        //     SignInn(cboUsername.SelectedItem.ToString(), txtPassword.Text);
        //     notifyIcon1.Visible = true;
        //     notifyIcon1.ShowBalloonTip(5000, "Happy Birthday", "King Bar Beque App wishes you a happy birthday", ToolTipIcon.Info);
        // }

        //LOGIN
        void SignInn(string Usernames, string Password)
        {

            try
            {
                DateTime currDate = DateTime.Now;
                DateTime addDat;

                _entities = new KBBQEntities();
                var data = _entities.Users.Where(x => x.Uname == Usernames && x.Pass == Password).FirstOrDefault();

                if (data != null)
                {
                    addDat = data.cdate.Value.AddDays(10);

                    if (currDate.Date == addDat.Date)
                    {
                        MessageBox.Show("Your system need to be upgraded as all the test is successfully done. Contact your technical administrator for more information.", "Upgradation Info - King Bar beque Restaurant Logins", MessageBoxButtons.OK, MessageBoxIcon.Information    );

                        return;
                    }
                }

                SqlConnection con = new SqlConnection(varinsert.dbPath);

                string sql = "select Uname,Pass,privileges from Users where Uname=@Uname and Pass=@Pass";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@Uname", Usernames.Trim());
                cmd.Parameters.AddWithValue("@Pass", Password.Trim());
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;

                //If count is equal to 1, meaning if found=true, then show frmMain form
                if (count == 1)
                {
                    string privel = getPrivilege();
                    frmParent frmdashboard = new frmParent();
                    //username,login date,login time, logout date, logout time

                    insertClass.insertToLogHistory(cboUsername.SelectedItem.ToString(), day, day, day, day);

                    int getLogID = 0;
                    int lab;
                    lab = selectClass.callMaxLogHistoryAndEmployee(cboUsername.SelectedItem.ToString(), getLogID);

                    /*
                     *Disable some button based on certain privileges the user has
                     *if user is assigned Administrator he/she  has all button enable at his/her disposal
                     *but in the case where he/she has a privilege called users certain buttons will be greyed out 
                     *meaning he/she can't perform certain operation
                     */
                    if (privel.Equals("Users"))
                    {
                        //frmdashboard.btnRegEmployee.Enabled = false;
                        //frmdashboard.btnAddUsers.Enabled = false;
                        //frmdashboard.btnCuurency.Enabled = false;
                        //frmdashboard.btnAddPOSCurrency.Enabled = false;
                        //frmdashboard.btnAddMenuGroup.Enabled = false;
                        //frmdashboard.btnAddMenus.Enabled = false;
                        //frmdashboard.btnVEmployee.Enabled = false;
                        //frmdashboard.btnVUsers.Enabled = false;
                        //frmdashboard.button9.Enabled = false;
                        //frmdashboard.button11.Enabled = false;
                        //frmdashboard.btnBakup.Enabled = false;
                    }

                    frmdashboard.statGetUser.Text = cboUsername.SelectedItem.ToString();
                    frmdashboard.getLogNum = lab;

                    this.Hide();
                    frmdashboard.ShowDialog();
                    txtPassword.Clear();
                    txtPassword.Text = "•••••••";
                    txtPassword.Select();
                    selectClass.selectUsers(cboUsername);
                    this.Show();
                }

                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error - King Bar beque Restaurant Logins", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - Throwing Exceptions");
            }




        }


        //getPrivilege reads the privilege the login user has

        SqlConnection con;
        SqlDataReader reader;
        string privilege;
        string getPrivilege()
        {
            try
            {

                string sql = "select privileges from Users where Uname='" + cboUsername.SelectedItem.ToString() + "'and  Pass='" + txtPassword.Text + "'";

                con = new SqlConnection(insertClass.dbPath);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    privilege = reader["privileges"].ToString();
                }
            }
            catch (Exception)
            {

            }
            return privilege;


        }

        private void Logins(string text1, string text2)
        {
            throw new NotImplementedException();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cboUsername.Text.Trim()))
            {
                errorProvider1.SetError(cboUsername, "Username is required.");
            }
            else
            {
                errorProvider1.SetError(cboUsername, string.Empty);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtPassword, "Password is required.");
            }
            else
            {
                errorProvider1.SetError(txtPassword, string.Empty);
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            selectClass.selectUsers(cboUsername);
            txtPassword.Select();
            txtPassword.Clear();

           // this.BackColor = Color.FromArgb(29, 161, 242);

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //}

        //private void btnKeyboard_Click(object sender, EventArgs e)
        //{

        //}

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKeyboard_Click_1(object sender, EventArgs e)
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

        private void btnLogin_Click_1(object sender, EventArgs e)
        {


            SignInn(cboUsername.SelectedItem.ToString(), txtPassword.Text);
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(5000, "Happy Birthday", "King Bar Beque App wishes you a happy birthday", ToolTipIcon.Info);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //private void txtUsername_Click(object sender, EventArgs e)
        //{

        //}
    }
}

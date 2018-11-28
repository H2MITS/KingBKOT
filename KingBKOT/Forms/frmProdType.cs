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
using Cindy_Restaurant.Classes;
using System.Diagnostics;
using System.IO;
using KingBKOT.Data;
using KingBKOT.ViewModel;

namespace Cindy_Restaurant.Forms
{
    public partial class frmProdType : Form
    {
        object keyboardProc;
        KBBQEntities _entities;

        long passedId;
        public frmProdType()
        {
            InitializeComponent();
        }
        clsInsert insertClass = new clsInsert();

        //RESET CONTROL TO ITS FORMER STATE
        void _setInitialState()
        {
            cboProductTypeName.SelectedIndex = 0;
            txtCategory.ResetText();
        }


        //THIS FORM HELPS TO CREATE PRODUCT
        //e.g  WIN, SOFT DRINK,MAIN DISH
        void valProduct(Control ctrl)
        {
            if (txtCategory.Text.Trim().Length > 0)
            {
                clsInsert.err.SetError(txtCategory, string.Empty);
            }
            else
            {
                clsInsert.err.SetIconAlignment(txtCategory, ErrorIconAlignment.MiddleLeft);
                clsInsert.err.SetError(txtCategory, "Please enter product type");
                return;

            }

        }

        //let user select food beverage
        void ValCategory(Control ctrl)
        {
            if (cboProductTypeName.SelectedIndex == 0)
            {
                clsSelect.err.SetIconAlignment(cboProductTypeName, ErrorIconAlignment.MiddleLeft);
                clsSelect.err.SetError(cboProductTypeName, "Please select category");
                return;
            }
            else
            {

                clsSelect.err.SetError(cboProductTypeName, string.Empty);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            valProduct(txtCategory);
            ValCategory(cboProductTypeName);
            if (clsInsert.err.GetError(txtCategory).Length != 0)
            {
                clsInsert.err.SetIconAlignment(txtCategory, ErrorIconAlignment.MiddleLeft);
                clsInsert.err.SetError(txtCategory, "Please enter product type");
                return;
            }
            else if (clsSelect.err.GetError(cboProductTypeName).Length != 0)
            {
                clsSelect.err.SetIconAlignment(cboProductTypeName, ErrorIconAlignment.MiddleLeft);
                clsSelect.err.SetError(cboProductTypeName, "Please select category");
                return;

            }
            else
            {

                _CheckProductExist();
            }
            clear();
            dataGridbind();
        }

        private void frmProdType_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            _setInitialState();
            dataGridbind();
        }

        private void dataGridbind()
        {
            try
            {
                _entities = new KBBQEntities();

                List<ProductTypeVM> modelList = new List<ProductTypeVM>();

                var data = _entities.tblProTypes.OrderBy(x => x.proSubCate).ToList();


                int rowNo = 1;
                foreach (var item in data)
                {
                    ProductTypeVM model = new ProductTypeVM();
                    model.prodTypeName = item.prodTypeName;
                    model.proSubCate = item.proSubCate;
                    model.proTypeID = item.proTypeID;

                    model.rowNo = rowNo;

                    modelList.Add(model);
                    rowNo++;
                }
                lblTotalRecord.Text = modelList.Count.ToString();
                dataGridView1.DataSource = modelList;
            }
            catch(Exception x)
            {

            }
        }


        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            valProduct((Control)sender);
        }

        private void txtCategory_Leave(object sender, EventArgs e)
        {
            valProduct((Control)sender);
        }

        private void cboProductTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValCategory((Control)sender);
        }

        private void cboProductTypeName_Leave(object sender, EventArgs e)
        {
            ValCategory((Control)sender);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //REMOVE DULPICATE
        public void _CheckProductExist()
        {
            try
            {
                if (btnSave.Text == "Save")
                {
                    SqlConnection con = new SqlConnection(insertClass.dbPath);

                    string sql = "select proSubCate from tblProType  where proSubCate = @proSubCate";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("@proSubCate", txtCategory.Text.Trim());

                    adapt.Fill(ds);
                    con.Close();
                    int count = ds.Tables[0].Rows.Count;

                    //If count is equal to 1
                    //meaning user already exist
                    if (count == 1)
                    {
                        MessageBox.Show("Menu Subgroup Already Exist", "Help - King Bar Beque", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        //PERFORM INSERT
                        insertClass.insertToProType(cboProductTypeName, txtCategory.Text);
                        _setInitialState();
                    }
                }
                else 
                {
                    _entities = new KBBQEntities();
                    var data = _entities.tblProTypes.Where(x => x.proTypeID == passedId).FirstOrDefault();

                    if (data != null)
                    {
                        data.prodTypeName = cboProductTypeName.Text.ToString();
                        data.proSubCate = txtCategory.Text.Trim();

                        _entities.SaveChanges();
                    }
                }

             

            }

            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Throwing Exception - Fronty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            clear();
        }

        void clear()
        {
           
            txtCategory.Text = string.Empty;
            btnSave.Text = "Save";

            cboProductTypeName.Focus();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1 && dataGridView1.CurrentRow.Cells[1].Value != null)
                {
                    var lID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    _entities = new KBBQEntities();
                    var seeData = _entities.tblProTypes.Where(x => x.proTypeID == lID).FirstOrDefault();

                    if (seeData != null)
                    {

                        txtCategory.Text = seeData.proSubCate.Trim().ToString();
                        cboProductTypeName.Text = seeData.prodTypeName.Trim().ToString();

                        passedId = seeData.proTypeID;
                        btnSave.Text = "Update";
                    }
                    else
                    {

                    }

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        _entities = new KBBQEntities();

                        var cellId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                        var selectedData1 = _entities.tblProTypes.Where(x => x.proTypeID == cellId).FirstOrDefault();


                        if (selectedData1 != null)
                        {
                            _entities.tblProTypes.Remove(selectedData1);
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong. Record cannot be deleted.");
                        }

                        _entities.SaveChanges();
                        MessageBox.Show("Record deleted ");
                        dataGridbind();

                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void txtCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtCategory_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtCategory.Text != string.Empty)
                {

                    _entities = new KBBQEntities();

                    List<ProductTypeVM> modelList = new List<ProductTypeVM>();

                    var data = _entities.tblProTypes.Where(x=>x.proSubCate.Contains(txtCategory.Text.Trim().ToString())).OrderBy(x => x.proSubCate).ToList();


                    int rowNo = 1;
                    foreach (var item in data)
                    {
                        ProductTypeVM model = new ProductTypeVM();
                        model.prodTypeName = item.prodTypeName;
                        model.proSubCate = item.proSubCate;
                        model.proTypeID = item.proTypeID;

                        model.rowNo = rowNo;

                        modelList.Add(model);
                        rowNo++;
                    }
                    lblTotalRecord.Text = modelList.Count.ToString();
                    dataGridView1.DataSource = modelList;
                }
                else
                {
                    dataGridbind();
                }
            }
            catch(Exception x)
            {

            }
        }
    }
}

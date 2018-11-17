using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingBKOT.Data;

namespace KingBKOT.Forms
{
    public partial class frmAddPurchaseProduct : Form
    {
        KBBQEntities _entities;
        int passedId = 0;
        string passedPName = "";

        public frmAddPurchaseProduct(int passedProId, string passedProName)
        {
            InitializeComponent();
            passedId = passedProId;
            passedPName = passedProName;
        }

        private void frmAddPurchaseProduct_Load(object sender, EventArgs e)
        {
            dateToday.Format = DateTimePickerFormat.Custom;
            dateToday.CustomFormat = "dd-MM-yyyy";
            comboUnit.SelectedIndex = 0;

            //Edit load
            if (passedPName != "")
                txtProductName.Text = passedPName;

            if (passedId != 0)
            {
                showAvailableData();
            }
        }


        private void showAvailableData()
        {
            clear();


            btnSubmit.Text = "Update";
            _entities = new KBBQEntities();

            var data = _entities.purchaseProducts.Where(x => x.id == passedId).FirstOrDefault();

            txtProductName.Text = data.pName.Trim().ToString();
            txtQuantity.Text = data.qty.ToString();
            txtWeight.Text = data.weight.ToString();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }


        void clear()
        {
            txtProductName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            comboUnit.SelectedIndex = 0;
            btnSubmit.Text = "Submit";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == string.Empty && txtQuantity.Text == string.Empty && txtWeight.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtProductName, "Enter all details.");
                    txtProductName.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter all details.";
                }
                else if (txtProductName.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtProductName, "Enter Product-name");
                    txtProductName.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Party-name.";
                }
                else if (txtQuantity.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtQuantity, "Enter Qty.");
                    txtQuantity.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Qty.";
                }
                else if (txtWeight.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtWeight, "Enter Weight.");
                    txtWeight.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Weight.";
                }
                else
                {
                    DateTime date = DateTime.ParseExact(dateToday.Text, "dd-MM-yyyy", null);

                    if (btnSubmit.Text == "Submit")
                    {
                        //save code
                        _entities = new KBBQEntities();


                        purchaseProduct proDate = new purchaseProduct();
                        proDate.pName = txtProductName.Text.Trim().ToString();
                        proDate.qty = Convert.ToDecimal(txtQuantity.Text);
                        proDate.weight = Convert.ToDecimal(txtWeight.Text);
                        proDate.unit = comboUnit.Text.ToString();
                        proDate.date = date;
                        proDate.cdate = DateTime.Now;

                        _entities.purchaseProducts.Add(proDate);
                        _entities.SaveChanges();

                        clear();
                        MessageBox.Show("Record Added Successfully");

                    }
                    else
                    {
                        //update code

                        _entities = new KBBQEntities();

                        var proDataUpdate = _entities.purchaseProducts.Where(x => x.id == passedId).FirstOrDefault();

                        proDataUpdate.pName = txtProductName.Text.Trim().ToString();
                        proDataUpdate.qty = Convert.ToDecimal(txtQuantity.Text);
                        proDataUpdate.weight = Convert.ToDecimal(txtWeight.Text);
                        proDataUpdate.unit = comboUnit.Text.ToString();
                        proDataUpdate.date = date;
                        proDataUpdate.udate = DateTime.Now;

                        _entities.SaveChanges();

                        clear();
                        MessageBox.Show("Record Updated Successfully");
                    }

                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {

        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {

        }
    }
}

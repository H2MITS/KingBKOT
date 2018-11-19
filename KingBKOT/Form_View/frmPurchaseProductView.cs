using KingBKOT.Forms;
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
using KingBKOT.ViewModel;
using System.Diagnostics;
using System.IO;

namespace KingBKOT.Form_View
{
    
    public partial class frmPurchaseProductView : Form
    {
        object keyboardProc;
        KBBQEntities _entities;

        public frmPurchaseProductView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddPurchaseProduct frm = new frmAddPurchaseProduct(0,"");
            frm.ShowDialog();
            dataGridBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtItemname.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtItemname, "Enter Item Name.");
                txtItemname.Focus();

            }
        }

        private void frmPurchaseProductView_Load(object sender, EventArgs e)
        {
            dataGridBind();
        }

        private void dataGridBind()
        {
            try
            {
                _entities = new KBBQEntities();

                int rowNo = 1;

                dgItemDetails.AutoGenerateColumns = false;

                List<PurchaseProductVM> modelList = new List<PurchaseProductVM>();

                var data = _entities.purchaseProducts.OrderBy(x => x.pName);

                foreach (var item in data)
                {
                    PurchaseProductVM model = new PurchaseProductVM();
                    model.rowNo = rowNo;
                    model.id = Convert.ToInt32( item.id);
                    model.pName = item.pName;
                    model.date = Convert.ToDateTime(item.date).ToString("dd-MM-yyyy");
                    model.weight = item.weight + " " + item.unit;
                    model.qty = item.qty;
                    model.cdate = Convert.ToDateTime(item.cdate).ToString("dd-MM-yyyy  hh:mm tt");

                    if (item.udate == null)
                        model.udate = "--";
                    else
                        model.udate = Convert.ToDateTime(item.udate).ToString("dd-MM-yyyy  hh:mm tt");

                    modelList.Add(model);

                    rowNo++;
                }

                dgItemDetails.DataSource = modelList;
                lblTotalRows.Text = modelList.Count.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemname.Text = string.Empty;
        }

        private void txtItemname_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                _entities = new KBBQEntities();

                int rowNo = 1;

                dgItemDetails.AutoGenerateColumns = false;

                List<PurchaseProductVM> modelList = new List<PurchaseProductVM>();

                var data = _entities.purchaseProducts.Where(x => x.pName.Contains(txtItemname.Text)).OrderBy(x => x.pName);

                foreach (var item in data)
                {
                    PurchaseProductVM model = new PurchaseProductVM();
                    model.rowNo = rowNo;
                    model.id = Convert.ToInt32(item.id);
                    model.pName = item.pName;
                    model.date = Convert.ToDateTime(item.date).ToString("dd-MM-yyyy");
                    model.weight = item.weight.ToString();
                    model.qty = item.qty;
                    model.cdate = Convert.ToDateTime(item.cdate).ToString("dd-MM-yyyy  hh:mm tt");

                    if (item.udate == null)
                        model.udate = "--";
                    else
                        model.udate = Convert.ToDateTime(item.udate).ToString("dd-MM-yyyy  hh:mm tt");

                    modelList.Add(model);

                    rowNo++;
                }

                dgItemDetails.DataSource = modelList;
                lblTotalRows.Text = modelList.Count.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void dgItemDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgItemDetails.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        _entities = new KBBQEntities();

                        var cellId = Convert.ToInt32(dgItemDetails.CurrentRow.Cells[0].Value);

                        var selectedData1 = _entities.purchaseProducts.Where(x => x.id == cellId).FirstOrDefault();


                        if (selectedData1 != null)
                        {
                            _entities.purchaseProducts.Remove(selectedData1);
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong. Record cannot be deleted.");
                        }

                        _entities.SaveChanges();
                        MessageBox.Show("Record deleted ");
                        dataGridBind();

                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void dgItemDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgItemDetails.CurrentRow.Index != -1 && dgItemDetails.CurrentRow.Cells[1].Value != null)
                {
                    var lID = Convert.ToInt32(dgItemDetails.CurrentRow.Cells[0].Value);

                    frmAddPurchaseProduct frm = new frmAddPurchaseProduct(lID,"");
                    frm.ShowDialog();
                    dataGridBind();

                     
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong. Contact your system administrator");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

            this.keyboardProc = Process.Start(keyboardPath);
        }
    }
}

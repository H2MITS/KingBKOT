using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cindy_Restaurant.Classes;
using KingBKOT.Data;
using KingBKOT.ViewModel;
using System.IO;
using System.Diagnostics;
using Cindy_Restaurant.Forms;

namespace Cindy_Restaurant.Form_View
{
    public partial class receiptList : Form
    {
        object keyboardProc;
        KBBQEntities _entities;

        public Label lblGetId = new Label();
        clsInsert insertClass = new clsInsert();

        List<billAndSettlementVM> recNoToPass = new List<billAndSettlementVM>();

        public receiptList()
        {
            InitializeComponent();
        }

        Label getRep = new Label();
        TextBox txtGetBill = new TextBox();
        public string recallDate, recallTime;

        clsSelect selectClass = new clsSelect();

        // frmSettlement settlement = new frmSettlement();
        // settlement.txtReceiptNum.Text = getRep.Text;
        //clsSelect selectClass = new clsSelect();
        frmViewOrderSettlement fvos = new frmViewOrderSettlement();
        frmOrder fOrder = new frmOrder();
        private void frmRecall_Load(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(cmbTableNo, "Select Table No");
                _entities = new KBBQEntities();
                dataGridView2.AutoGenerateColumns = false;

                getTableNo();

                if (cmbTableNo.Items.Count > 0)
                {
                    cmbTableNo.SelectedIndex = 0;
                    btnMergePayFinal.Visible = true;
                }
                else
                {
                    btnMergePayFinal.Visible = false;
                }

                dataGridView2.RowTemplate.Height = 35;
                cboSearcshMode.SelectedIndex = 0;

               

                //---------------------------------------------


                List<billAndSettlementVM> modelList = new List<billAndSettlementVM>();
                List<billAndSettlement> data = new List<billAndSettlement>();

                if (cmbTableNo.Items.Count == 0)
                {

                    data = _entities.billAndSettlements.Where(x => x.mode == "UNPAID").ToList();
                    foreach (var item in data)
                    {

                        billAndSettlementVM model = new billAndSettlementVM();

                        model.kot = item.kot;
                        model.orderDecrip = item.orderDecrip;
                        model.guestName = item.fname + " " + item.lname;
                        model.mobile= item.mobile;
                        model.ordDate = item.ordDate.ToString("dd-MMM-yyyy");
                        model.ordTime = item.ordTime;
                        model.totalDue = item.totalDue;

                        modelList.Add(model);
                    }
                }
                else
                {


                    string selectedTable = cmbTableNo.Text.ToString();

                    var datas = _entities.tblOrderInfoes.Where(x => x.tableNo == selectedTable).ToList();
                    //data = _entities.billAndSettlements.Where(x => x. == selectedTable).ToList();

                    foreach (var item in datas)
                    {
                        var datss = _entities.billAndSettlements.Where(x => x.kot == item.KOT && x.mode == "UNPAID").FirstOrDefault();

                        if (datss != null)
                        {
                            billAndSettlementVM model = new billAndSettlementVM();

                            model.kot = datss.kot;
                            model.orderDecrip = datss.orderDecrip;
                            model.guestName = datss.fname + " " + datss.lname;
                            model.ordDate = item.ordDate.ToString("dd-MMM-yyyy");
                            model.ordTime = datss.ordTime;
                            model.totalDue = datss.totalDue;
                            model.mobile= item.mobile;

                            modelList.Add(model);
                        }
                    }
                }



                dataGridView2.DataSource = modelList;

                dataGridView2.ClearSelection();
            }
            catch (Exception x)
            {

            }
        }
        string tabl = "0";
        int count = 0;
        private void getTableNo()
        {
            _entities = new KBBQEntities();

            var data = _entities.billAndSettlements.Where(x => x.mode == "UNPAID").OrderBy(x => x.kot).ToList();
            List<OrderInfoVM> modelList = new List<OrderInfoVM>();

            if (data != null)
            {

                foreach (var item in data)
                {
                    var dataTableNo = _entities.tblOrderInfoes.Where(x => x.KOT == item.kot).FirstOrDefault();

                    if (dataTableNo != null)
                    {

                        var datas = _entities.tblOrderInfoes.ToList();

                        foreach (var itemss in modelList)
                        {
                            if (itemss.tableNo == dataTableNo.tableNo)
                            {
                                count = 1;
                            }
                        }

                        if (count == 1)
                        {
                            count = 0;
                        }
                        else
                        {
                            OrderInfoVM model = new OrderInfoVM();
                            model.KOT = dataTableNo.KOT;
                            model.tableNo = dataTableNo.tableNo;

                            modelList.Add(model);

                            tabl = model.tableNo;
                            count = 0;

                            //cmbTableNo.Items.Add(tabl);
                        }

                    }
                }

                cmbTableNo.ValueMember = "KOT";
                cmbTableNo.DisplayMember = "tableNo";
                cmbTableNo.DataSource = modelList.OrderBy(x => x.tableNo).ToList();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMyOrder_Click(object sender, EventArgs e)
        {
            try
            {
                

                _entities = new KBBQEntities();
                DateTimePicker dates = new DateTimePicker();
                if (btnMyOrder.Text.Equals("My Order"))
                {
                    btnMyOrder.Text = "All Orders";
                    btnMergePayFinal.Visible = false;
                    //-----------------------------------------------------------------------

                    //string selectedTable = cmbTableNo.SelectedValue.ToString();

                    List<billAndSettlementVM> modelList = new List<billAndSettlementVM>();
                    //string dts = Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd");

                    //DateTime dt=Convert.ToDateTime(dts);
                    var data = _entities.billAndSettlements.ToList();
                    foreach (var item in data)
                    {

                        billAndSettlementVM model = new billAndSettlementVM();

                        model.kot = item.kot;
                        model.orderDecrip = item.orderDecrip;
                        model.guestName = item.fname + " " + item.lname;
                        model.ordDate = item.ordDate.ToString("dd-MMM-yyyy");
                        model.ordTime = item.ordTime;
                        model.totalDue = item.totalDue;
                        model.mobile= item.mobile;
                        modelList.Add(model);
                    }

                    dataGridView2.DataSource = modelList;

                    dataGridView2.ClearSelection();
                }
                else if (btnMyOrder.Text.Equals("All Orders"))
                {
                    btnMergePayFinal.Visible = true;
                    btnMyOrder.Text = "My Order";
                    //   btnMyOrder.Image = Properties.Resources.Office_Customer_Male_Light_icon;

                    //-----------------------------------------------------------------------

                    string selectedTable = cmbTableNo.SelectedValue.ToString();

                    List<billAndSettlementVM> modelList = new List<billAndSettlementVM>();

                    var data = _entities.billAndSettlements.Where(x => x.ordDate == dateTimePicker1.Value.Date).ToList();
                    foreach (var item in data)
                    {

                        billAndSettlementVM model = new billAndSettlementVM();

                        model.kot = item.kot;
                        model.orderDecrip = item.orderDecrip;
                        model.guestName = item.fname + " " + item.lname;
                        model.ordDate = item.ordDate.ToString("dd-MMM-yyyy");
                        model.ordTime = item.ordTime;
                        model.totalDue = item.totalDue;
                        model.mobile = item.mobile;
                        modelList.Add(model);
                    }

                    dataGridView2.DataSource = modelList;

                    dataGridView2.ClearSelection();
                }
            }
            catch (Exception x)
            {

            }
        }

        private void btnDatSearcsh_Click(object sender, EventArgs e)
        {
            try
            {
                btnMergePayFinal.Visible = false;
                //-----------------------------------------------------------------------

                string selectedTable = cmbTableNo.SelectedValue.ToString();

                List<billAndSettlementVM> modelList = new List<billAndSettlementVM>();

                var data = _entities.billAndSettlements.Where(x => x.ordDate == dateTimePicker1.Value.Date).ToList();
                foreach (var item in data)
                {

                    billAndSettlementVM model = new billAndSettlementVM();

                    model.kot = item.kot;
                    model.orderDecrip = item.orderDecrip;
                    model.guestName = item.fname + " " + item.lname;
                    model.ordDate = item.ordDate.ToString("dd-MMM-yyyy");
                    model.ordTime = item.ordTime;
                    model.totalDue = item.totalDue;
                    model.mobile = item.mobile;
                    modelList.Add(model);
                }

                dataGridView2.DataSource = modelList;
                dataGridView2.ClearSelection();
            }
            catch (Exception x)
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                btnMergePayFinal.Visible = false;
                //-------------------------------------------------------------------------------------
                string selectedTable = cmbTableNo.SelectedValue.ToString();
                List<billAndSettlement> data = new List<billAndSettlement>();
                List<billAndSettlementVM> modelList = new List<billAndSettlementVM>();

                if (cboSearcshMode.SelectedIndex.Equals(0)) //Fname
                {
                    data = _entities.billAndSettlements.Where(x => x.fname.Contains(txtSearcsh.Text)).ToList();

                }
                else if (cboSearcshMode.SelectedIndex.Equals(1)) //Lname
                {
                    data = _entities.billAndSettlements.Where(x => x.lname.Contains(txtSearcsh.Text)).ToList();

                }

                else if (cboSearcshMode.SelectedIndex.Equals(3)) //Receipt
                {
                    if (txtSearcsh.Text != string.Empty)
                        data = _entities.billAndSettlements.Where(x => x.kot == (txtSearcsh.Text)).ToList();
                }
                else if (cboSearcshMode.SelectedIndex.Equals(2)) //mobile
                {
                    if (txtSearcsh.Text != string.Empty)
                        data = _entities.billAndSettlements.Where(x => x.mobile.Contains(txtSearcsh.Text)).ToList();
                }

                foreach (var item in data)
                {

                    billAndSettlementVM model = new billAndSettlementVM();

                    model.kot = item.kot;
                    model.orderDecrip = item.orderDecrip;
                    model.guestName = item.fname + " " + item.lname;
                    model.ordDate = item.ordDate.ToString("dd-MMM-yyyy");
                    model.ordTime = item.ordTime;
                    model.totalDue = item.totalDue;
                    model.mobile = item.mobile;
                    modelList.Add(model);
                }

                dataGridView2.DataSource = modelList;
                dataGridView2.ClearSelection();
            }
            catch (Exception x)
            {

            }
        }

        private void chkTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                btnMergePayFinal.Visible = false;
                if (chkTakeAway.Checked)
                {

                    //-----------------------------------------------------------------------

                    string selectedTable = cmbTableNo.SelectedValue.ToString();

                    List<billAndSettlementVM> modelList = new List<billAndSettlementVM>();

                    var data = _entities.billAndSettlements.Where(x => x.orderDecrip == "Take Away" && x.mode == "UNPAID").ToList();
                    foreach (var item in data)
                    {

                        billAndSettlementVM model = new billAndSettlementVM();

                        model.kot = item.kot;
                        model.orderDecrip = item.orderDecrip;
                        model.guestName = item.fname + " " + item.lname;
                        model.ordDate = item.ordDate.ToString("dd-MMM-yyyy");
                        model.ordTime = item.ordTime;
                        model.totalDue = item.totalDue;
                        model.mobile = item.mobile;
                        modelList.Add(model);
                    }

                    dataGridView2.DataSource = modelList;
                    dataGridView2.ClearSelection();
                }
            }
            catch (Exception x)
            {

            }
        }

        private void chkDineIn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                btnMergePayFinal.Visible = false;

                if (chkDineIn.Checked)
                {
                    //-----------------------------------------------------------------------

                    string selectedTable = cmbTableNo.SelectedValue.ToString();

                    List<billAndSettlementVM> modelList = new List<billAndSettlementVM>();

                    var data = _entities.billAndSettlements.Where(x => x.orderDecrip == "Dine In" && x.mode == "UNPAID").ToList();
                    foreach (var item in data)
                    {

                        billAndSettlementVM model = new billAndSettlementVM();

                        model.kot = item.kot;
                        model.orderDecrip = item.orderDecrip;
                        model.guestName = item.fname + " " + item.lname;
                        model.ordDate = item.ordDate.ToString("dd-MMM-yyyy");
                        model.ordTime = item.ordTime;
                        model.totalDue = item.totalDue;
                        model.mobile = item.mobile;
                        modelList.Add(model);
                    }

                    dataGridView2.DataSource = modelList;
                    dataGridView2.ClearSelection();
                }
            }
            catch (Exception x)
            {

            }
        }

        private void chkNoCharge_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //  if (chkNoCharge.Checked)
                {
                    //-----------------------------------------------------------------------

                    string selectedTable = cmbTableNo.SelectedValue.ToString();

                    List<billAndSettlementVM> modelList = new List<billAndSettlementVM>();

                    var data = _entities.billAndSettlements.Where(x => x.orderDecrip == "No Charge").ToList();
                    foreach (var item in data)
                    {

                        billAndSettlementVM model = new billAndSettlementVM();

                        model.kot = item.kot;
                        model.orderDecrip = item.orderDecrip;
                        model.guestName = item.fname + " " + item.lname;
                        model.ordDate = item.ordDate.ToString("dd-MMM-yyyy");
                        model.ordTime = item.ordTime;
                        model.totalDue = item.totalDue;
                         model.mobile= item.mobile;
                        modelList.Add(model);
                    }

                    dataGridView2.DataSource = modelList;
                    dataGridView2.ClearSelection();
                }
            }
            catch (Exception x)
            {

            }
        }
        string selectedTable = "";
        private void btnRecall_Click(object sender, EventArgs e)
        {

            _entities = new KBBQEntities();

            if (getRep.Text == "")
            {
                MessageBox.Show("Please click to select Receipt", "Help - KINGBBQ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            selectClass.selectOrderDetailsUsingKOT(getRep.Text, fvos.listView1, 0);

            selectClass.selectOrderFieldsUsingKOT(getRep.Text);
            fvos.lblGetReceipt.Text = getRep.Text;
            fvos.lblKOT.Text = getRep.Text;
            fvos.lblTableNo.Text = selectClass.TableNum;
            fvos.lblOrderDescription.Text = selectClass.orderDescript;
            fvos.lblgetDateTime.Text = selectClass.OrderDate + " ";
            fvos.thisDate = selectClass.OrderDate;
            fvos.daty = selectClass.OrderDate;
            


            fvos.recNoToPassList = null;

            fvos.lblgetDateTime.Text += selectClass.OrderTime;
            fvos.timy = selectClass.OrderTime;
            //get number of person
            selectClass.selectAdultAndChildren(getRep.Text);
            fvos.lblAdultNo.Text = selectClass.AdultNum;
            fvos.lblChild.Text = selectClass.ChildrenNum;

            //pull employee-id where the receipt id is known
            string salesPersonID = selectClass.getSalePersonID(getRep.Text);

            //After getting the sale person id 
            //search for the fullname using the the id gotten
            //when the id is match get the Uname and assigned it to the lable
            fvos.lblwaiterName.Text = selectClass.salpersonByID(salesPersonID);


            fvos.fvosBillofOder = txtGetBill.Text;


            var ifSettled = _entities.billAndSettlements.Where(x => x.kot == getRep.Text).FirstOrDefault();

            if (ifSettled != null)
            {
                if (ifSettled.mode == "PAID")
                {
                    fvos.btnSettlement.Visible = false;
                }
            }

            //fvos.btnSettlement.Visible = false;
            fvos.ShowDialog();
            //settlement.txtCustOwes.Text = txtGetBill.Text;
            //settlement.ShowDialog();
            getRep.Text = "";

            this.Close();
            // serve as refresh

            // bindGridViewForPageLoad();
        }

        private void brnClear_Click(object sender, EventArgs e)
        {
            txtGetBill.Text = string.Empty;
            txtSearcsh.Text = string.Empty;
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
            chkDineIn.Checked = false;
            //chkNoCharge.Checked = false;
            chkTakeAway.Checked = false;
            cboSearcshMode.SelectedItem = string.Empty;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbTableNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnMergePay.Visible = true;

                _entities = new KBBQEntities();

                //var data = _entities.tblOrderInfoes.Where(x => x.tableNo == cmbTableNo.SelectedText.ToString()).ToList();
                //foreach (var item in data)
                //{
                //   selectClass.selectBillAndSettlementTableNo(dataGridView1, cmbTableNo.SelectedValue.ToString());
                //}
                dataGridView2.Refresh();

                recNoToPass = new List<billAndSettlementVM>();
                string tablCMBSelected = cmbTableNo.Text.ToString();

                List<billAndSettlementVM> modelList = new List<billAndSettlementVM>();

                var data = _entities.tblOrderInfoes.Where(x => x.tableNo == tablCMBSelected).ToList();

                foreach (var item in data)
                {
                    var dataSettlement = _entities.billAndSettlements.Where(x => x.kot == item.KOT && x.mode == "UNPAID").FirstOrDefault();
                    if (dataSettlement != null)
                    {
                        billAndSettlementVM model = new billAndSettlementVM();

                        model.kot = dataSettlement.kot;
                        model.orderDecrip = dataSettlement.orderDecrip;
                        model.guestName = dataSettlement.fname + " " + dataSettlement.lname;
                        model.ordDate = item.ordDate.ToString("dd-MMM-yyyy");
                        model.ordTime = dataSettlement.ordTime;
                        model.totalDue = dataSettlement.totalDue;
                        model.mobile = dataSettlement.mobile;
                        modelList.Add(model);

                        recNoToPass.Add(model);
                    }

                }

                dataGridView2.DataSource = modelList;
                dataGridView2.ClearSelection();
            }
            catch (Exception x)
            {

            }
        }

        private void cboSearcshMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMergePay_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amt = 0;
                int dgTotalRows = dataGridView2.Rows.Count;
                if (dataGridView2.Rows.Count >= 0)
                {
                    DataGridViewRow row = this.dataGridView2.Rows[dgTotalRows - 1];

                    //  getRep.Text = row.Cells[0].Value.ToString();

                    //get customer name
                    fvos.lblgetGuestName.Text = row.Cells[2].Value.ToString();

                    fvos.thisTime = row.Cells[5].Value.ToString();

                    foreach (DataGridViewRow item in dataGridView2.Rows)
                    {
                        amt += Convert.ToDecimal(item.Cells[6].Value);

                    }
                    fvos.lblMobile.Text = row.Cells[3].Value.ToString();
                    txtGetBill.Text = amt.ToString();
                }

                _entities = new KBBQEntities();

                string tablCMBSelected = cmbTableNo.Text.ToString();

                var getLastRecptNo = (selectClass.getKOTNum()).ToString();

                //just to tell kot generator that the id is used
                insertClass.insertToKOTGenerator(Convert.ToInt32(getLastRecptNo), "done");

                var recptNo = _entities.tblOrderInfoes.Where(x => x.tableNo == tablCMBSelected).ToList();

                fvos.lblKOT.Text = "";
                foreach (var item in recNoToPass)
                {
                    selectClass.selectOrderDetailsUsingKOT(item.kot, fvos.listView1, 1);

                    fvos.lblKOT.Text += item.kot + ", ";
                }

                selectClass.selectOrderFieldsUsingKOT(recptNo.OrderByDescending(x => x.KOT).FirstOrDefault().KOT);

                fvos.recNoToPassList = recNoToPass; // passing all rec for current selected table
                fvos.lblGetReceipt.Text = getLastRecptNo.ToString();
                fvos.lblTableNo.Text = selectClass.TableNum;
                fvos.lblOrderDescription.Text = selectClass.orderDescript;
                fvos.lblgetDateTime.Text = selectClass.OrderDate + " ";
                fvos.thisDate = selectClass.OrderDate;
                fvos.daty = selectClass.OrderDate;

                fvos.lblgetDateTime.Text += selectClass.OrderTime;
                fvos.timy = selectClass.OrderTime;

                //get number of person
                selectClass.selectAdultAndChildren(recptNo.OrderByDescending(x => x.KOT).FirstOrDefault().KOT);

                fvos.lblAdultNo.Text = selectClass.AdultNum;
                fvos.lblChild.Text = selectClass.ChildrenNum;

                //pull employee-id where the receipt id is known
                string salesPersonID = selectClass.getSalePersonID(recptNo.OrderByDescending(x => x.KOT).FirstOrDefault().KOT);

                //After getting the sale person id 
                //search for the fullname using the the id gotten
                //when the id is match get the Uname and assigned it to the lable
                fvos.lblwaiterName.Text = selectClass.salpersonByID(salesPersonID);


                fvos.fvosBillofOder = txtGetBill.Text;


                var ifSettled = _entities.billAndSettlements.Where(x => x.kot == getRep.Text).FirstOrDefault();

                if (ifSettled != null)
                {
                    if (ifSettled.mode == "PAID")
                    {
                        fvos.btnSettlement.Visible = false;
                    }
                }

                //fvos.btnSettlement.Visible = false;
                fvos.ShowDialog();
                //settlement.txtCustOwes.Text = txtGetBill.Text;
                //settlement.ShowDialog();
                getRep.Text = "";

                this.Close();
                //   bindGridViewForPageLoad();
            }
            catch (Exception x)
            {

            }

        }
        clsUpdate updateClass;
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult myResult;
                myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.OK)
                {
                    _entities = new KBBQEntities();

                    var cellId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                    updateClass = new clsUpdate();
                    updateClass.updateBillAndSettlement(cellId.ToString(), "CANCELLED", "", 0);

                    _entities = new KBBQEntities();

                    var data = _entities.DailySales.Where(x => x.KOT == cellId.ToString()).ToList();

                    foreach (var item in data)
                    {
                        _entities.DailySales.Remove(item);
                        _entities.SaveChanges();

                    }

                    bindGridViewForPageLoad();


                }
            }


        }

        private void bindGridViewForPageLoad()
        {
            try
            {
                getTableNo();

                // dataGridView2.Rows.Clear();
                dataGridView2.Refresh();


                List<billAndSettlementVM> modelList = new List<billAndSettlementVM>();
                List<billAndSettlement> data = new List<billAndSettlement>();

                data = _entities.billAndSettlements.Where(x => x.mode == "UNPAID").ToList();

                foreach (var item in data)

                {

                    billAndSettlementVM model = new billAndSettlementVM();

                    model.kot = item.kot;
                    model.orderDecrip = item.orderDecrip;
                    model.guestName = item.fname + " " + item.lname;
                    model.ordDate = item.ordDate.ToString("dd-MMM-yyyy");
                    model.ordTime = item.ordTime;
                    model.totalDue = item.totalDue;
                    model.mobile = item.mobile;
                    modelList.Add(model);
                }



                dataGridView2.DataSource = modelList;

                dataGridView2.ClearSelection();
            }
            catch (Exception x)
            {

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int dgTotalRows = dataGridView2.Rows.Count;
                if (dataGridView2.Rows.Count >= 0)
                {
                    DataGridViewRow row = this.dataGridView2.Rows[dgTotalRows - 1];

                    //  getRep.Text = row.Cells[0].Value.ToString();

                    //get customer name
                    fOrder.lblgetGuestName.Text = row.Cells[2].Value.ToString();

                    fOrder.thisTime = row.Cells[5].Value.ToString();

                    string s = row.Cells[2].Value.ToString();
                    // Split string on spaces.
                    // ... This will separate all the words.
                    string[] words = s.Split(' ');


                    fOrder.fname = words[0].ToString();
                    fOrder.lname = words[1].ToString();
                }

                _entities = new KBBQEntities();

                if (getRep.Text == "")
                {
                    MessageBox.Show("Please click to select Receipt", "Help - KINGBBQ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                selectClass.selectOrderDetailsUsingKOT(getRep.Text, fOrder.listView1, 0);

                selectClass.selectOrderFieldsUsingKOT(getRep.Text);

                fOrder.lblKOT.Text = getRep.Text;
                fOrder.lblTableNo.Text = selectClass.TableNum;
                fOrder.lblOrderDescription.Text = selectClass.orderDescript;
                fOrder.lblgetDateTime.Text = selectClass.OrderDate + " ";
                fOrder.thisDate = selectClass.OrderDate;

                // fOrder.recNoToPassList = null;

                fOrder.lblgetDateTime.Text += selectClass.OrderTime;
                // fvos.timy = selectClass.OrderTime;
                //get number of person
                selectClass.selectAdultAndChildren(getRep.Text);
                fOrder.lblAdultNo.Text = selectClass.AdultNum;
                fOrder.lblChild.Text = selectClass.ChildrenNum;

                //pull employee-id where the receipt id is known
                string salesPersonID = selectClass.getSalePersonID(getRep.Text);

                //After getting the sale person id 
                //search for the fullname using the the id gotten
                //when the id is match get the Uname and assigned it to the lable
                fOrder.lblwaiterName.Text = selectClass.salpersonByID(salesPersonID);


                fOrder.fvosBillofOder = txtGetBill.Text;
                fOrder.btnOrder.Text = "Update Order";

                //var ifSettled = _entities.billAndSettlements.Where(x => x.kot == getRep.Text).FirstOrDefault();

                //if (ifSettled != null)
                //{
                //    if (ifSettled.mode == "PAID")
                //    {
                //        fvos.btnSettlement.Visible = false;
                //    }
                //}

                //fvos.btnSettlement.Visible = false;
                fOrder.ShowDialog();
                //settlement.txtCustOwes.Text = txtGetBill.Text;
                //settlement.ShowDialog();
                getRep.Text = "";

                this.Close();

                // serve as refresh

                //  bindGridViewForPageLoad();
            }
            catch (Exception x)
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal amt = 0;

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];

                    getRep.Text = row.Cells[0].Value.ToString();

                    //get customer name
                    fvos.lblgetGuestName.Text = row.Cells[2].Value.ToString();
                    fvos.lblMobile.Text = row.Cells[3].Value.ToString();

                    fvos.thisTime = row.Cells[5].Value.ToString();


                    amt = Convert.ToDecimal(row.Cells[6].Value);


                    txtGetBill.Text = amt.ToString();
                }
            }
            catch (Exception x)
            {

            }
        }


    }
}

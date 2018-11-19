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
using System.Drawing.Printing;
using System.Data.SqlClient;

using KingBKOT.Data;
using System.Diagnostics;
using System.IO;

namespace Cindy_Restaurant.Forms
{
    public partial class frmOrder : Form
    {
        object keyboardProc;
        KBBQEntities _entities;
        public string thisDate, thisTime;
        public frmOrder()
        {
            InitializeComponent();
        }

        clsSelect selectClass = new clsSelect();
        clsView viewClass = new clsView();
        clsdelete deleteClass = new clsdelete();
        clsInsert insertClass = new clsInsert();
        clsUpdate updateClass = new clsUpdate();
        string getEmpID;
        string taxPercsent, vatPercsent;
        public string kot = null;//is the id for each ordering
        public int hiddFashCash = 0;
        public string fname, lname;
        public string fvosBillofOder;
        //1

        private void button45_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        //private void button21_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += btnL.Text;
        //}

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        //private void button22_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += btnM.Text;
        //}

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        //private void button23_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += btnN.Text;
        //}

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        //private void button24_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += btnO.Text;
        //}

        //private void button25_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += btnP.Text;
        //}

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                //CONTINUE TO CLEAR TEXT UNTIL NOTHING IS REMAIN
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnA_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "A";
        //}

        //private void btnB_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "B";
        //}

        //private void btnC_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "C";
        //}

        //private void btnD_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "D";
        //}

        //private void btnE_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "E";
        //}

        //private void btnF_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "F";
        //}

        //private void btnG_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "G";
        //}

        //private void btnH_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "H";
        //}

        //private void btnI_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "I";
        //}

        //private void btnJ_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "J";
        //}

        //private void btnK_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "K";
        //}

        //private void btnQ_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "Q";
        //}

        //private void btnR_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "R";
        //}

        //private void btnS_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "S";
        //}

        //private void btnT_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "T";
        //}

        //private void btnU_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "U";
        //}

        //private void btnZ_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "Z";
        //}

        //private void btn0_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "0";
        //}

        //private void btn2_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "2";
        //}

        //private void btn3_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "3";
        //}

        //private void btn4_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "4";
        //}

        //private void btn9_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += "9";
        //}

        //private void btnCent_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += btnCent.Text;
        //}

        //private void btndot_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += btndot.Text;
        //}

        //private void btnPounds_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += btnPounds.Text;
        //}

        //private void btnDollar_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text += btnDollar.Text;
        //}

        private void btnFood_Click(object sender, EventArgs e)
        {
            //_entities = new KBBQEntities();

            //var data = _entities.tblProducts.Where(x => x.prodTypeName == "Food").OrderBy(x=>x.prodTypeName).ToList();

            //foreach (var item in data)
            //{
            //    ListViewItem listVItem = new ListViewItem();
            //    listVItem.SubItems.Add(item.proType);

            //    subCategoryListView.Items.Add(listVItem);
            //}

            viewClass.SelectSubMenuByTextDisplay(btnFood, dataGridView3);


            //Change1.Text = "Soup";
            //Change2.Text = "Salad";
            //Change3.Text = "Appetizer";
            //Change4.Text = "Main";
            //Change5.Text = "Pasta";
            //Change6.Text = "Dessert";

            //Change7.Text = "Sandwich";
            //Change8.Text = "Hot hors doeuvres";
            //Change9.Text = "Traditional Kitchen";
            //Change0.Visible = false;
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            viewClass.SelectSubMenuByTextDisplay(btnDrink, dataGridView3);

            //Change1.Text = "Winery";
            //Change2.Text = "Soft Drink";
            //Change3.Text = "Beer";
            //Change4.Text = "Water";
            //Change5.Text = "Juice";
            //Change6.Text = "Whisky";
            //Change7.Text = "Brandy";
            //Change8.Text = "Cocktail";

            //Change9.Text = "Liquer";
            //Change0.Visible = true;
            //Change0.Text = "Cognac";
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            // var dgv = new DataGridView();
            dataGridView1.RowTemplate.Height = 40;
            dataGridView3.RowTemplate.Height = 40;

            if (hiddFashCash == 1)
            {
                // For FashCash
                btnSettlement.Visible = false;
                btnOrder.Visible = false;
                btnCashout.Visible = true;
                btnCashout.Enabled = true;

                lblKOT.Visible = false;
                label2.Visible = false;
            }
            else
            {
                btnSettlement.Visible = true;
                btnOrder.Visible = true;
                btnCashout.Visible = false;
                lblKOT.Visible = true;
                label2.Visible = true;
            }

            //if (lblOrderDescription.Text.Equals("Dine In"))
            //{
            //    btnCashout.Enabled = false;
            //}
            //else
            //{
            //    btnCashout.Enabled = false;
            //}

            selectClass.selectProduct(dataGridView1);
            selectClass.getTaxables();

            taxPercsent = string.Format("{0:n2}", selectClass.tax1.ToString());
            vatPercsent = string.Format("{0:n2}", selectClass.tax2.ToString());

            btnFood_Click(sender, e); //activate the food button when form load
            selectClass.calcTaxAmt(decimal.Parse(taxPercsent), decimal.Parse(vatPercsent), decimal.Parse("0.00"), decimal.Parse(lblTotalAmt.Text));
            lblTaxAmt.Text = selectClass.tax1_Amt.ToString();
            lblVat.Text = selectClass.tax2_Amt.ToString();
            lblSubTotal.Text = selectClass.netPrice.ToString();
            lblTotalAmt.Text = subtotal().ToString();


            _entities = new KBBQEntities();

            var cgstPer = _entities.tblTaxes.FirstOrDefault().tax_1;
            var sgstPer = _entities.tblTaxes.FirstOrDefault().tax_2;

            lblCGSTTaxPer.Text = "( " + cgstPer.ToString().Substring(0, 4) + " %)";
            lblSGSTTaxPer.Text = "( " + sgstPer.ToString().Substring(0, 4) + " %)";

        }

        private void Change1_Click(object sender, EventArgs e)
        {
            // viewClass.SelectMenuByTextDisplay(Change1, dataGridView1);
        }

        private void Change2_Click(object sender, EventArgs e)
        {
            //viewClass.SelectMenuByTextDisplay(Change2, dataGridView1);
        }

        private void Change3_Click(object sender, EventArgs e)
        {
            // viewClass.SelectMenuByTextDisplay(Change3, dataGridView1);
        }

        private void Change4_Click(object sender, EventArgs e)
        {
            //viewClass.SelectMenuByTextDisplay(Change4, dataGridView1);
        }

        private void Change5_Click(object sender, EventArgs e)
        {
            // viewClass.SelectMenuByTextDisplay(Change5, dataGridView1);
        }

        private void Change6_Click(object sender, EventArgs e)
        {
            // viewClass.SelectMenuByTextDisplay(Change6, dataGridView1);
        }

        private void Change7_Click(object sender, EventArgs e)
        {
            // viewClass.SelectMenuByTextDisplay(Change7, dataGridView1);
        }

        private void Change8_Click(object sender, EventArgs e)
        {
            //viewClass.SelectMenuByTextDisplay(Change8, dataGridView1);
        }

        private void Change9_Click(object sender, EventArgs e)
        {
            //  viewClass.SelectMenuByTextDisplay(Change9, dataGridView1);
        }

        private void Change0_Click(object sender, EventArgs e)
        {
            //viewClass.SelectMenuByTextDisplay(Change0, dataGridView1);
        }
        string itemName;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int col = 0; col <= listView1.Items.Count - 1; col++)
            {

                //listView1.Items[col].SubItems[1].Text = (Convert.ToInt32(listView1.Items[col].SubItems[1].Text).ToString()) ;
                //listView1.Items[col].SubItems[3].Text = (Convert.ToInt32(listView1.Items[col].SubItems[3].Text).ToString());



                selectClass.calcTaxAmt(decimal.Parse(taxPercsent), decimal.Parse(vatPercsent), decimal.Parse("0.00"), decimal.Parse(lblTotalAmt.Text));
                lblTaxAmt.Text = selectClass.tax1_Amt.ToString();
                lblVat.Text = selectClass.tax2_Amt.ToString();
                lblSubTotal.Text = selectClass.netPrice.ToString();
                lblTotalAmt.Text = subtotal().ToString();

            }

            if (listView1.Items.Count >= 0)
            {
                btnModify.Enabled = true;
                btnComplimentary.Enabled = true;
            }
            else
            {
                btnModify.Enabled = false;
                btnComplimentary.Enabled = false;
            }
        }

        //Calculate SubTotal
        private double subtotal()
        {
            int i = 0;
            int j = 0;
            double k = 0;
            i = 0;
            j = 0;
            k = 0;


            try
            {

                j = listView1.Items.Count;
                for (i = 0; i <= j - 1; i++)
                {
                    k = k + Convert.ToDouble(listView1.Items[i].SubItems[3].Text);
                }
                return k;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return k;

        }

        private void printReceipt()
        {

            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDialog.Document = printDoc;
            printDoc.PrintPage += printDoc_PrintPage;
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                printDoc.Print();
            }
        }

        private void printFashCashReceipt()
        {

            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDialog.Document = printDoc;
            printDoc.PrintPage += printFastCashDoc_PrintPage;
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                printDoc.Print();
            }
        }

        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int i, j;
            //let make j the total count of items on listview
            j = listView1.Items.Count;


            Graphics grafic = e.Graphics;
            Font font = new Font("Courer New", 12);
            float fontHeight = font.GetHeight();
            int StartX = 5;
            int StartY = 5;
            int offSet = 40;

            grafic.DrawString("   King Bar Beque Restaurant", new Font("Courer New", 14), new SolidBrush(Color.Black), StartX, StartY);
            grafic.DrawString(" ", new Font("Courer New", 8), new SolidBrush(Color.Black), StartX, StartY + 5);

            grafic.DrawString("========================================", new Font("Courer New", 8), new SolidBrush(Color.Black), StartX, StartY + 20);

            grafic.DrawString("KOT #:", new Font("Courer New", 10), new SolidBrush(Color.Black), StartX, StartY + 40);
            grafic.DrawString("\t" + kot.PadRight(30), new Font("Courer New", 10), new SolidBrush(Color.Black), StartX, StartY + 40);

            grafic.DrawString("\t\tDay: " + lblgetDateTime.Text, new Font("Courer New", 10), new SolidBrush(Color.Black), StartX, StartY + 40);


            grafic.DrawString("Table #: ", new Font("Courer New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 20));
            grafic.DrawString("\t" + lblTableNo.Text.PadRight(30), new Font("Courer New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 20));
            //    grafic.DrawString("\t\t\t\t"+ ordInfo.Times.ToString().PadRight(30), new Font("Courer New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 20));

            grafic.DrawString("Server #: ", new Font("Courer New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 40));
            grafic.DrawString("\t" + lblwaiterName.Text, new Font("Courer New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 40));

            grafic.DrawString("Guest :", new Font("Courer New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 60));
            grafic.DrawString("\t" + lblgetGuestName.Text, new Font("Courer New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 60));


            string Liners = "========================================";
            grafic.DrawString(Liners, new Font("Courer New", 8), new SolidBrush(Color.Black), StartX, StartY + (offSet + 80));

            grafic.DrawString("Qty", new Font("Courer New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 100));
            grafic.DrawString("\t Item Name ", new Font("Courer New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 100));
            //grafic.DrawString("\t\t\t\tUnit", new Font("Courer New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 100));
            // grafic.DrawString("\t\t\t\t\tAmount ", new Font("Courer New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 100));


            grafic.DrawString("========================================", new Font("Courer New", 8), new SolidBrush(Color.Black), StartX, StartY + (offSet + 120));


            for (i = 0; i <= j - 1; i++)
            {

                string strTotalQty, proPrice, proName;
                proName = listView1.Items[i].SubItems[2].Text;
                strTotalQty = Convert.ToInt32(listView1.Items[i].SubItems[1].Text).ToString();
                //  proPrice = Convert.ToInt32(listView1.Items[i].SubItems[3].Text).ToString();

                string productLine = strTotalQty + "\t" + proName + "\t"; //+ proPrice;
                grafic.DrawString(productLine, font, new SolidBrush(Color.Black), StartX, StartY + (offSet + 140));
                offSet += (int)fontHeight + 5;

            }
            grafic.DrawString("========================================", new Font("Courer New", 8), new SolidBrush(Color.Black), StartX, StartY + (offSet + 150));

            //string LineDraw = "======================================================";
            //grafic.DrawString(LineDraw, new Font("Courer New", 8), new SolidBrush(Color.Black), StartX, StartY + offSet);

            // grafic.DrawString("Bill Amount :".PadRight(30), font, new SolidBrush(Color.Black), StartX, StartY);
            //grafic.DrawString("\t\t" + lblSubTotal.Text.PadRight(30), font, new SolidBrush(Color.Black), StartX, StartY + offSet);

            //grafic.DrawString("Payable :".PadRight(30) + lblTotalAmt.Text, font, new SolidBrush(Color.Black), StartX, StartY + offSet);

        }


        void printFastCashDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int i, j;

            if (lblgetGuestName.Text == "lblgetGuestName")
            {
                lblgetGuestName.Text = "";
            }

            //let make j the total count of items on listview
            j = listView1.Items.Count;
            Graphics grafic = e.Graphics;
            Font font = new Font("Courier New", 11);
            float fontHeight = font.GetHeight();
            int StartX = 5;
            int StartY = 5;
            int offSet = 40;

            grafic.DrawString("King BarBeque Restaurant", new Font("Courier New", 13, FontStyle.Regular), new SolidBrush(Color.Black), StartX, StartY);
            grafic.DrawString(" ", new Font("Courier New", 8), new SolidBrush(Color.Black), StartX, StartY + 5);

            grafic.DrawString("========================================", new Font("Courier New", 8), new SolidBrush(Color.Black), StartX, StartY + 20);

            grafic.DrawString("Receipt#:", new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + 40);
            grafic.DrawString("\t\t" + kot.PadRight(30), new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + 40);

            grafic.DrawString("\t\t\tDate:" + thisDate, new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + 40);


            grafic.DrawString("Table #:", new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 20));
            grafic.DrawString("\t\t" + lblTableNo.Text.PadRight(30), new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 20));
            grafic.DrawString("\t\t\tTime:" + thisTime, new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 20));

            grafic.DrawString("Server #:", new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 40));
            grafic.DrawString("\t\t" + lblwaiterName.Text, new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 40));

            grafic.DrawString("Guest:", new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 60));
            grafic.DrawString("\t\t" + lblgetGuestName.Text, new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 60));

            grafic.DrawString("Rec Type:", new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 80));
            grafic.DrawString("\t\t Fash Cash", new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 80));


            string Liners = "=======================================================";
            grafic.DrawString(Liners, new Font("Courier New", 8), new SolidBrush(Color.Black), StartX, StartY + (offSet + 100));


            grafic.DrawString("Item Name", new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 120));
            grafic.DrawString("\t\t\tQty", new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 120));

            grafic.DrawString("\t\t\t\tAmount ", new Font("Courier New", 10), new SolidBrush(Color.Black), StartX, StartY + (offSet + 120));


            grafic.DrawString("=======================================================", new Font("Courier New", 8), new SolidBrush(Color.Black), StartX, StartY + (offSet + 140));


            for (i = 0; i <= j - 1; i++)
            {

                string strTotalQty, proPrice, proName;
                proName = listView1.Items[i].SubItems[2].Text;
                strTotalQty = Convert.ToInt32(listView1.Items[i].SubItems[1].Text).ToString();
                proPrice = Convert.ToInt32(listView1.Items[i].SubItems[3].Text).ToString();

                string productLine = "";


                if (proName.Length >= 13)
                {
                    productLine = proName.Substring(0, 13) + "\t" + strTotalQty + "     " + proPrice;
                }

                //character is less than or equal 7
                else if ((proName.Length >= 7) && (proName.Length < 13))
                {
                    if (proName.Length == 7)
                    {
                        // 6 charc

                        productLine = proName + "       \t" + strTotalQty + "     " + proPrice;
                    }
                    if (proName.Length == 8)
                    {
                        // 5 charc
                        productLine = proName + "      \t" + strTotalQty + "     " + proPrice;
                    }
                    if (proName.Length == 9)
                    {
                        // 4 charc
                        productLine = proName + "    \t" + strTotalQty + "     " + proPrice;

                    }
                    if (proName.Length == 10)
                    {
                        // 3 charc
                        productLine = proName + "   \t" + strTotalQty + "     " + proPrice;

                    }
                    if (proName.Length == 11)
                    {
                        // 2 charc
                        productLine = proName + "  \t" + strTotalQty + "     " + proPrice;

                    }
                    if (proName.Length == 12)
                    {
                        // 1 charc
                        productLine = proName + " \t" + strTotalQty + "     " + proPrice;

                    }
                    if (proName.Length == 13)
                    {
                        productLine = proName + "\t" + strTotalQty + "     " + proPrice;
                    }

                }

                // is greater than 7
                else if (proName.Length < 7)
                {
                    if (proName.Length == 1)
                    {
                        productLine = proName + "            \t" + strTotalQty + "     " + proPrice;
                    }
                    if (proName.Length == 2)
                    {
                        productLine = proName + "           \t" + strTotalQty + "     " + proPrice;
                    }
                    if (proName.Length == 3)
                    {
                        productLine = proName + "          \t" + strTotalQty + "     " + proPrice;
                    }
                    if (proName.Length == 4)
                    {
                        productLine = proName + "         \t" + strTotalQty + "     " + proPrice;
                    }
                    if (proName.Length == 5)
                    {
                        productLine = proName + "        \t" + strTotalQty + "     " + proPrice;
                    }
                    if (proName.Length == 6)
                    {
                        productLine = proName + "       \t" + strTotalQty + "     " + proPrice;
                    }


                }

                grafic.DrawString(productLine, font, new SolidBrush(Color.Black), StartX, StartY + (offSet + 160));

                offSet += (int)fontHeight + 5;

            }

            string LineDraw = "========================================";
            grafic.DrawString(LineDraw, new Font("Courier New", 8), new SolidBrush(Color.Black), StartX, StartY + (offSet + 170));

            string LineDrawss = "----------------------------------------";
            grafic.DrawString(LineDraw, new Font("Courier New", 8), new SolidBrush(Color.Black), StartX, StartY + (offSet + 170));



            grafic.DrawString("  Sub Total..." + lblSubTotal.Text + Environment.NewLine, font, new SolidBrush(Color.Black), StartX, StartY + (offSet + 180));
            grafic.DrawString("  Tax........." + (double.Parse(lblTaxAmt.Text) + double.Parse(lblVat.Text)), font, new SolidBrush(Color.Black), StartX, StartY + (offSet + 190));
            grafic.DrawString("  Payable....." + lblTotalAmt.Text + Environment.NewLine, font, new SolidBrush(Color.Black), StartX, StartY + (offSet + 210));
            grafic.DrawString(LineDraw, font, new SolidBrush(Color.Black), StartX, StartY + (offSet + 230));
            grafic.DrawString("Description" + "\tTaxable" + "    Tax", font, new SolidBrush(Color.Black), StartX, StartY + (offSet + 250));

            _entities = new KBBQEntities();

            var cgstPer = _entities.tblTaxes.FirstOrDefault().tax_1;
            var sgstPer = _entities.tblTaxes.FirstOrDefault().tax_2;







            grafic.DrawString("CGST" + "( " + cgstPer.ToString().Substring(0, 4) + " %)" + "\t" + lblSubTotal.Text + "    " + lblTaxAmt.Text, font, new SolidBrush(Color.Black), StartX, StartY + (offSet + 270));
            grafic.DrawString("SGST" + "( " + sgstPer.ToString().Substring(0, 4) + " %)" + "\t" + lblSubTotal.Text + "    " + lblVat.Text, font, new SolidBrush(Color.Black), StartX, StartY + (offSet + 300));
            grafic.DrawString(LineDrawss, font, new SolidBrush(Color.Black), StartX, StartY + (offSet + 310));
            grafic.DrawString("Transaction: " + "PAID", font, new SolidBrush(Color.Black), StartX, StartY + (offSet + 330));
            grafic.DrawString(LineDrawss, font, new SolidBrush(Color.Black), StartX, StartY + (offSet + 350));
            grafic.DrawString("Thank you for your visit.Please do visit us again ", new Font("Courier New", 8), new SolidBrush(Color.Black), StartX, StartY + (offSet + 370));
            grafic.DrawString(LineDrawss, font, new SolidBrush(Color.Black), StartX, StartY + (offSet + 390));

        }
        private void button68_Click(object sender, EventArgs e)
        {
            //get sales id
            kot = selectClass.getKOTNum().ToString();


            //check if customer has ordered
            //then continue with the transaction

            if (listView1.Items.Count > 0)
            {
                orderInfo infoOrder = new orderInfo();

                int i, j;
                //let make j the total count of items on listview
                j = listView1.Items.Count;

                for (i = 0; i <= j - 1; i++)
                {

                    string strTotalQty, proPrice, proName;
                    proName = listView1.Items[i].SubItems[2].Text;
                    strTotalQty = Convert.ToInt32(listView1.Items[i].SubItems[1].Text).ToString();
                    proPrice = Convert.ToInt32(listView1.Items[i].SubItems[3].Text).ToString();
                    getEmpID = selectClass.getEmployeeByID(lblwaiterName.Text);

                    //perform the insertion
                    insertClass.insertToDailySales(int.Parse(lblTableNo.Text), lblOrderDescription.Text, Convert.ToInt32(strTotalQty), proName, decimal.Parse(proPrice), getEmpID, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, "Ordered", kot);

                }


                //populate the bill and settlement table
                insertClass.insertTobillAndSettlement(kot, lblOrderDescription.Text, fname, lname, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, double.Parse(lblTotalAmt.Text), double.Parse(lblTaxAmt.Text), double.Parse(lblVat.Text), double.Parse(lblSubTotal.Text), "unpaid".ToUpper(), getEmpID);


                insertClass.insertTotblOrderInfo(lblOrderDescription.Text, lblTableNo.Text, kot, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, fname, lname, lblAdultNo.Text, lblChild.Text, getEmpID);



                //just to tell kot generator that the id is used
                //insertClass.insertToKOTGenerator("done");
                insertClass.insertToKOTGenerator(Convert.ToInt32(kot), "done");

                //call the below method
                //  PreviewReceipt();
                printReceipt();
                //empty listview
                for (i = 0; i <= j - 1; i++)
                {

                    listView1.Items.Clear();
                }

                kot = null;



            }
            //Show this message

            else
            {
                MessageBox.Show("Error: " + "Please double click to select your " + Environment.NewLine + "choice of menu item(s) to order", "Throwing Exception - Fronty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //]]]]]]]]]]]]]]]]]]]]]]]
            selectClass.getTaxables();

            taxPercsent = string.Format("{0:n2}", selectClass.tax1.ToString());
            vatPercsent = string.Format("{0:n2}", selectClass.tax2.ToString());

            try
            {
                if (listView1.Items.Count > 0)
                {
                    //remove the item selected
                    ListViewItem item = listView1.FocusedItem;
                    //fill the text boxes


                    decimal amt, tempAmt;
                    int qty;
                    if (Convert.ToInt32(item.SubItems[1].Text) > 1)
                    {
                        qty = Convert.ToInt32(item.SubItems[1].Text);
                        item.SubItems[1].Text = (Convert.ToInt32(item.SubItems[1].Text) - 1).ToString();


                        amt = Convert.ToDecimal(item.SubItems[3].Text);

                        tempAmt = amt / qty;
                        amt = amt - tempAmt;
                        item.SubItems[3].Text = amt.ToString();
                    }
                    else
                    {
                        listView1.FocusedItem.Remove();
                    }

                    //  Convert.ToInt32(listView1.SelectedItems);
                    //listView1.FocusedItem.Remove();

                    //Reinitialize prices breakdown
                    for (int col = 0; col <= listView1.Items.Count - 1; col++)
                    {

                        selectClass.calcTaxAmt(decimal.Parse(taxPercsent), decimal.Parse(vatPercsent), decimal.Parse("0.00"), decimal.Parse(lblTotalAmt.Text));
                        lblTaxAmt.Text = selectClass.tax1_Amt.ToString();
                        lblVat.Text = selectClass.tax2_Amt.ToString();
                        lblSubTotal.Text = selectClass.netPrice.ToString();
                        lblTotalAmt.Text = subtotal().ToString();

                    }

                }
                else if (listView1.Items.Count <= 0)
                {
                    listView1.Items.Clear();
                    lblTaxAmt.Text = "0.00";
                    lblVat.Text = "0.00";
                    lblSubTotal.Text = "0.00";
                    lblTotalAmt.Text = "0.00";
                    lblTotalAmt.Text = "0.00";

                }


                listView1.FocusedItem.Focused = false;
            }

            //do nothing
            catch (Exception ex)
            {
                // MessageBox.Show("Please click to select Item", "Help - KINGBBQ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // return;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            selectClass.searcshProduct(textBox1.Text.Trim(), dataGridView1);
        }





        string name = "";
        int count = 0;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            string proNam = row.Cells[0].Value.ToString();
            string reason = "";

            //CEHECKING STATUES
            try
            {

                string sql = "select Reason from tblProducts where proName='" + proNam + "'";
                SqlConnection con = new SqlConnection(selectClass.dbPath);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    reason = reader["Reason"].ToString();

                }

                if (reason.Trim().Length > 0)
                {
                    MessageBox.Show("The selected Item has been freeze" + Environment.NewLine + "Reason: " + reason, "Bring To Notice - King Bar Beque Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;

                }
                else
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.SubItems[2].Text == row.Cells[0].Value.ToString())
                        {
                            count = 1;
                        }
                    }



                    if (count == 0)
                    {
                        ListViewItem listVItem = new ListViewItem();
                        listVItem.SubItems.Add("1");
                        listVItem.SubItems.Add(row.Cells[0].Value.ToString());
                        listVItem.SubItems.Add(row.Cells[1].Value.ToString());

                        listView1.Items.Add(listVItem);

                        name = row.Cells[0].Value.ToString();
                    }
                    else
                    {
                        //ListViewItem listVItem = new ListViewItem();
                        //listVItem.SubItems.Add("1");
                        //listVItem.SubItems.Add(row.Cells[0].Value.ToString());
                        //listVItem.SubItems.Add(row.Cells[1].Value.ToString());

                        //listView1.Items.Add(listVItem);

                        foreach (ListViewItem item in listView1.Items)
                        {
                            if (item.SubItems[2].Text == row.Cells[0].Value.ToString())
                            {
                                item.SubItems[1].Text = (Convert.ToInt32(item.SubItems[1].Text.ToString()) + 1).ToString();
                                item.SubItems[3].Text = (Convert.ToInt32(item.SubItems[3].Text) + Convert.ToInt32(row.Cells[1].Value)).ToString();
                            }
                        }

                        count = 0;
                    }



                    for (int col = 0; col <= listView1.Items.Count - 1; col++)
                    {

                        selectClass.calcTaxAmt(decimal.Parse(taxPercsent), decimal.Parse(vatPercsent), decimal.Parse("0.00"), decimal.Parse(lblTotalAmt.Text));
                        lblTaxAmt.Text = selectClass.tax1_Amt.ToString();
                        lblVat.Text = selectClass.tax2_Amt.ToString();
                        lblSubTotal.Text = selectClass.netPrice.ToString();
                        fvosBillofOder = lblTotalAmt.Text = subtotal().ToString();

                    }

                }
            }

            catch (Exception ex)
            {
                //  MessageBox.Show("Error: " + ex.Message, "Throwing Exception - Fronty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (lblOrderDescription.Text == "Dine In".Trim() || lblOrderDescription.Text == "Take Away".Trim())
            {

                placeOrder();

            }
            else if (lblOrderDescription.Text == "No Charge".Trim())
            {
                PlaceNoChargeOrder();
            }

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

            try
            {
                //get the name of the selected item
                itemName = listView1.FocusedItem.SubItems[2].Text;
                if (itemName.Trim() != "")
                {
                    frmModification modifyForm = new frmModification();
                    viewClass.viewProductForModification(itemName, modifyForm.dataGridView1);
                    modifyForm.txtApplyName.Text = listView1.FocusedItem.SubItems[2].Text;
                    modifyForm.txtApplyRate.Text = listView1.FocusedItem.SubItems[3].Text;
                    modifyForm.ShowDialog();
                    listView1.FocusedItem.SubItems[3].Text = modifyForm.getModApplyRate;
                    listView1.FocusedItem.SubItems[2].Text = modifyForm.getModApplyName;


                    //Clear Item
                    itemName = "";

                    //Reinitialize price breakdown
                    for (int col = 0; col <= listView1.Items.Count - 1; col++)
                    {

                        selectClass.calcTaxAmt(decimal.Parse(taxPercsent), decimal.Parse(vatPercsent), decimal.Parse("0.00"), decimal.Parse(lblTotalAmt.Text));
                        lblTaxAmt.Text = selectClass.tax1_Amt.ToString();
                        lblVat.Text = selectClass.tax2_Amt.ToString();
                        lblSubTotal.Text = selectClass.netPrice.ToString();
                        lblTotalAmt.Text = subtotal().ToString();

                    }

                }
                else
                {
                    MessageBox.Show("Please click to select item", "Help - King Bar Beque Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please click to select item", "Help - King Bar Beque Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void lblTotalAmt_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalAmt_TextChanged(object sender, EventArgs e)
        {
            for (int col = 0; col <= listView1.Items.Count - 1; col++)
            {

                selectClass.calcTaxAmt(decimal.Parse(taxPercsent), decimal.Parse(vatPercsent), decimal.Parse("0.00"), decimal.Parse(lblTotalAmt.Text));
                lblTaxAmt.Text = selectClass.tax1_Amt.ToString();
                lblVat.Text = selectClass.tax2_Amt.ToString();
                lblSubTotal.Text = selectClass.netPrice.ToString();
                lblTotalAmt.Text = subtotal().ToString();

            }
            txtTotal.Text = lblTotalAmt.Text;
        }

        private void btnSettlement_Click(object sender, EventArgs e)
        {

        }


        //Perform ordering
        void placeOrder()
        {

            //get sales id
            kot = selectClass.getKOTNum().ToString();


            //check if customer has ordered
            //then continue with the transaction

            if (listView1.Items.Count > 0)
            {

                int i, j;
                if (btnOrder.Text == "Order")
                {

                    orderInfo infoOrder = new orderInfo();


                    //let make j the total count of items on listview
                    j = listView1.Items.Count;

                    for (i = 0; i <= j - 1; i++)
                    {

                        string strTotalQty, proPrice, proName;
                        proName = listView1.Items[i].SubItems[2].Text;
                        strTotalQty = Convert.ToInt32(listView1.Items[i].SubItems[1].Text).ToString();
                        proPrice = Convert.ToInt32(listView1.Items[i].SubItems[3].Text).ToString();
                        getEmpID = selectClass.getWaiterByID(lblwaiterName.Text);

                        //perform the insertion
                        insertClass.insertToDailySales(int.Parse(lblTableNo.Text), lblOrderDescription.Text, Convert.ToInt32(strTotalQty), proName, decimal.Parse(proPrice), getEmpID, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, "Ordered", kot);

                    }


                    //populate the bill and settlement table
                    insertClass.insertTobillAndSettlement(kot, lblOrderDescription.Text, fname, lname, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, double.Parse(lblTotalAmt.Text), double.Parse(lblTaxAmt.Text), double.Parse(lblVat.Text), double.Parse(lblSubTotal.Text), "unpaid".ToUpper(), getEmpID);


                    insertClass.insertTotblOrderInfo(lblOrderDescription.Text, lblTableNo.Text, kot, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, fname, lname, lblAdultNo.Text, lblChild.Text, getEmpID);



                    //just to tell kot generator that the id is used
                    insertClass.insertToKOTGenerator(Convert.ToInt32(kot), "done");

                }
                else
                {
                    kot = lblKOT.Text;
                    orderInfo infoOrder = new orderInfo();


                    //let make j the total count of items on listview
                    j = listView1.Items.Count;

                    //perform Deletion first to update

                    _entities = new KBBQEntities();
                    var dataDS = _entities.DailySales.Where(x => x.KOT == kot).ToList();

                    if (dataDS != null)
                    {
                        foreach (var item in dataDS)
                        {
                            _entities.DailySales.Remove(item);
                            _entities.SaveChanges();
                        }
                      
                    }


                    for (i = 0; i <= j - 1; i++)
                    {

                        string strTotalQty, proPrice, proName;
                        proName = listView1.Items[i].SubItems[2].Text;
                        strTotalQty = Convert.ToInt32(listView1.Items[i].SubItems[1].Text).ToString();
                        proPrice = Convert.ToInt32(listView1.Items[i].SubItems[3].Text).ToString();
                        getEmpID = selectClass.getWaiterByID(lblwaiterName.Text);

                       
                        //perform the insertion
                        insertClass.insertToDailySales(int.Parse(lblTableNo.Text), lblOrderDescription.Text, Convert.ToInt32(strTotalQty), proName, decimal.Parse(proPrice), getEmpID, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, "Ordered", kot);

                    }

                    _entities = new KBBQEntities();
                    var data = _entities.billAndSettlements.Where(x => x.kot == kot).FirstOrDefault();
                    if (data != null)
                    {
                        _entities.billAndSettlements.Remove(data);
                        _entities.SaveChanges();
                    }


                    //populate the bill and settlement table
                    insertClass.insertTobillAndSettlement(kot, lblOrderDescription.Text, fname, lname, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, double.Parse(lblTotalAmt.Text), double.Parse(lblTaxAmt.Text), double.Parse(lblVat.Text), double.Parse(lblSubTotal.Text), "unpaid".ToUpper(), getEmpID);

                    //delete
                    _entities = new KBBQEntities();
                    var datas = _entities.tblOrderInfoes.Where(x => x.KOT == kot).FirstOrDefault();
                    if (datas != null)
                    {
                        _entities.tblOrderInfoes.Remove(datas);
                        _entities.SaveChanges();
                    }

                    insertClass.insertTotblOrderInfo(lblOrderDescription.Text, lblTableNo.Text, kot, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, fname, lname, lblAdultNo.Text, lblChild.Text, getEmpID);

                    //delete
                    _entities = new KBBQEntities();
                    int intKOT= Convert.ToInt32(kot);
                    var datasK = _entities.kotGenerators.Where(x => x.genKOT == intKOT).FirstOrDefault();
                    if (datasK != null)
                    {
                        _entities.kotGenerators.Remove(datasK);
                        _entities.SaveChanges();
                    }

                    //just to tell kot generator that the id is used
                    insertClass.insertToKOTGenerator(Convert.ToInt32(kot), "done");



                }
                //call the below method
                //  PreviewReceipt();
                printReceipt();
                //empty listview
                for (i = 0; i <= j - 1; i++)
                {

                    listView1.Items.Clear();
                }
                lblTotalAmt.Text = "0.000";
                kot = null;



            }
            //Show this message

            else
            {
                MessageBox.Show("Error: " + "Please double click to select your " + Environment.NewLine + "choice of menu item(s) to order", "Throwing Exception - Fronty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }



        }

        void PlaceNoChargeOrder()
        {


            string Nocharge = "NC" + selectClass.genNochargeIDs();

            //check if customer has ordered
            //then continue with the transaction

            if (listView1.Items.Count > 0)
            {
                orderInfo infoOrder = new orderInfo();

                int i, j;
                //let make j the total count of items on listview
                j = listView1.Items.Count;

                for (i = 0; i <= j - 1; i++)
                {

                    string strTotalQty, proPrice, proName;
                    proName = listView1.Items[i].SubItems[2].Text;
                    strTotalQty = Convert.ToInt32(listView1.Items[i].SubItems[1].Text).ToString();
                    proPrice = Convert.ToInt32(listView1.Items[i].SubItems[3].Text).ToString();
                    getEmpID = selectClass.getWaiterByID(lblwaiterName.Text);

                    //perform the insertion
                    insertClass.insertToDailySales(int.Parse(lblTableNo.Text), lblOrderDescription.Text, Convert.ToInt32(strTotalQty), proName, decimal.Parse(proPrice), getEmpID, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, "Ordered", Nocharge);

                }


                //populate the bill and settlement table
                insertClass.insertTobillAndSettlement(Nocharge, lblOrderDescription.Text, fname, lname, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, double.Parse(lblTotalAmt.Text), double.Parse(lblTaxAmt.Text), double.Parse(lblVat.Text), double.Parse(lblSubTotal.Text), "No charge".ToUpper(), getEmpID);


                insertClass.insertTotblOrderInfo(lblOrderDescription.Text, lblTableNo.Text, Nocharge, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, fname, lname, lblAdultNo.Text, lblChild.Text, getEmpID);



                //just to tell NochargeID generator that the id is used
                insertClass.insertTogenNochargeIDs("done");

                //call the below method
                //  PreviewReceipt();
                printReceipt();
                //empty listview
                for (i = 0; i <= j - 1; i++)
                {

                    listView1.Items.Clear();
                }
                lblTotalAmt.Text = "0.000";
                Nocharge = "";



            }
            //Show this message

            else
            {
                MessageBox.Show("Error: " + "Please double click to select your " + Environment.NewLine + "choice of menu item(s) to order", "Throwing Exception - Fronty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }




        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblSubTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblVat_Click(object sender, EventArgs e)
        {

        }

        private void lblTaxAmt_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btnO_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnM_Click(object sender, EventArgs e)
        //{

        //}

        private void btnComplimentary_Click(object sender, EventArgs e)
        {
            //]]]]]]]]]]]]]]]]]]]]]]]

            try
            {
                selectClass.getTaxables();

                taxPercsent = string.Format("{0:n2}", selectClass.tax1.ToString());
                vatPercsent = string.Format("{0:n2}", selectClass.tax2.ToString());

                Font myFont = new Font("Sans Serif", 8, FontStyle.Italic, GraphicsUnit.Point);

                if (listView1.Items.Count > 0)
                {

                    listView1.FocusedItem.SubItems[3].Text = "0";
                    listView1.FocusedItem.Font = myFont;
                }
                //Reinitialize prices breakdown
                for (int col = 0; col <= listView1.Items.Count - 1; col++)
                {

                    selectClass.calcTaxAmt(decimal.Parse(taxPercsent), decimal.Parse(vatPercsent), decimal.Parse("0.00"), decimal.Parse(lblTotalAmt.Text));
                    lblTaxAmt.Text = selectClass.tax1_Amt.ToString();
                    lblVat.Text = selectClass.tax2_Amt.ToString();
                    lblSubTotal.Text = selectClass.netPrice.ToString();
                    lblTotalAmt.Text = subtotal().ToString();

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error: " + "Please click to compliment your order", "Throwing Exception - King Bar Beque Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

        }
        string getReceiptNumber = "0";

        private void btnExtra_Click(object sender, EventArgs e)
        {
            viewClass.SelectSubMenuByTextDisplay(btnExtra, dataGridView3);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            selectClass.searcshSubMenu(textBox3.Text.Trim(), dataGridView3);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];

            string proNam = row.Cells[0].Value.ToString();

            viewClass.SelectMenuByTextDisplay(proNam, dataGridView1);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            txtTotal.Text = string.Empty;
            listView1.Items.Clear();
        }

        private void lblCGSTTaxPer_Click(object sender, EventArgs e)
        {

        }

        private void btnCashout_Click(object sender, EventArgs e)
        {
            kot = selectClass.getKOTNum().ToString();
            getReceiptNumber = kot;
            if (listView1.Items.Count > 0)
            {
                orderInfo infoOrder = new orderInfo();

                int i, j;
                //let make j the total count of items on listview
                j = listView1.Items.Count;

                for (i = 0; i <= j - 1; i++)
                {

                    string strTotalQty, proPrice, proName;
                    proName = listView1.Items[i].SubItems[2].Text;
                    strTotalQty = Convert.ToInt32(listView1.Items[i].SubItems[1].Text).ToString();
                    proPrice = Convert.ToInt32(listView1.Items[i].SubItems[3].Text).ToString();
                    getEmpID = selectClass.getWaiterByID(lblwaiterName.Text);

                    //perform the insertion
                    insertClass.insertToDailySales(int.Parse(lblTableNo.Text), lblOrderDescription.Text, Convert.ToInt32(strTotalQty), proName, decimal.Parse(proPrice), getEmpID, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, "Ordered", kot);

                }


                //populate the bill and settlement table
                insertClass.insertTobillAndSettlement(kot, lblOrderDescription.Text, fname, lname, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, double.Parse(lblTotalAmt.Text), double.Parse(lblTaxAmt.Text), double.Parse(lblVat.Text), double.Parse(lblSubTotal.Text), "PAID".ToUpper(), getEmpID);


                // insertClass.insertTotblOrderInfo(lblOrderDescription.Text, lblTableNo.Text, kot, infoOrder.dateTimePicker1, infoOrder.dateTimePicker1, fname, lname, lblAdultNo.Text, lblChild.Text, getEmpID);



                //just to tell kot generator that the id is used
                insertClass.insertToKOTGenerator(Convert.ToInt32(kot), "done");

                //call the below method
                //  PreviewReceipt();
                //printReceipt();
                //empty listview
                //for (i = 0; i <= j - 1; i++)
                //{

                //    listView1.Items.Clear();
                //}
                //lblTotalAmt.Text = "0.000";
                //kot = null;



            }
            //Show this message

            else
            {
                MessageBox.Show("Error: " + "Please double click to select your " + Environment.NewLine + "choice of menu item(s) to order", "Throwing Exception - Fronty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }




            frmSettlement setl = new frmSettlement();
            setl.getCashierName = this.lblwaiterName.Text;
            setl.txtReceiptNum.Text = this.getReceiptNumber; // genrate receipt number
            setl.KOTnum = "0";
            setl.txtCustOwes.Text = fvosBillofOder;
            // this.Hide();
            setl.ShowDialog();

            // //wait a bit
            string askme = "Do you wanna print receipt ?";
            DialogResult result = MessageBox.Show(askme, "Print Receipt - King Bar Beque Restaurant", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                PreviewReceipt();
                printFashCashReceipt();
            }
            this.Close();
        }

        public void PreviewReceipt()
        {
            frmReceiptPreview rcs = new frmReceiptPreview();
            frmSettlement setl = new frmSettlement();

            //get sales id

            rcs.textBox1.AppendText("King Bar Beque Restaurant" + Environment.NewLine);
            rcs.textBox1.AppendText("========================================" + Environment.NewLine);

            rcs.textBox1.AppendText("Receipt No #: " + getReceiptNumber + "\t\t\tDate: " + DateTime.Now.ToString("dd/MM/yy") + Environment.NewLine);
            rcs.textBox1.AppendText("Table No #:" + lblTableNo.Text + "\t\t\tTime : " + DateTime.Now.ToString("h:mm tt") + Environment.NewLine);
            rcs.textBox1.AppendText("Server #: " + "\t" + lblwaiterName.Text + Environment.NewLine);
            rcs.textBox1.AppendText("Guest #: " + "\t" + lblgetGuestName.Text + Environment.NewLine);

            rcs.textBox1.AppendText("========================================" + Environment.NewLine);
            rcs.textBox1.AppendText(Environment.NewLine + "Item Name" + "\t\tQty" + "\t\tPrice" + Environment.NewLine);
            rcs.textBox1.AppendText("========================================" + Environment.NewLine);


            //the below section will loop the items from the order sheet

            if (listView1.Items.Count > 0)
            {


                int i, j;
                //let make j the total count of items on listview
                j = listView1.Items.Count;

                for (i = 0; i <= j - 1; i++)
                {

                    string strTotalQty, proPrice, proName;
                    proName = listView1.Items[i].SubItems[2].Text;
                    strTotalQty = Convert.ToInt32(listView1.Items[i].SubItems[1].Text).ToString();
                    proPrice = Convert.ToInt32(listView1.Items[i].SubItems[3].Text).ToString();
                    getEmpID = selectClass.getEmployeeByID(lblwaiterName.Text);

                    //to align perfect when previewed
                    //check and cut short the character length
                    //character is  > 13 cut it short to 13
                    if (proName.Length >= 13)
                    {
                        rcs.textBox1.AppendText(proName.Substring(0, 13) + "\t\t" + strTotalQty + "\t\t" + proPrice + Environment.NewLine);

                    }

                    //character is less than or equal 7
                    else if ((proName.Length >= 7) && (proName.Length < 13))
                    {
                        if (proName.Length == 7)
                        {
                            // 6 charc
                            rcs.textBox1.AppendText(proName + "      \t\t" + strTotalQty + "\t\t" + proPrice + Environment.NewLine);
                        }
                        if (proName.Length == 8)
                        {
                            // 5 charc
                            rcs.textBox1.AppendText(proName + "     \t\t" + strTotalQty + "\t\t" + proPrice + Environment.NewLine);

                        }
                        if (proName.Length == 9)
                        {
                            // 4 charc
                            rcs.textBox1.AppendText(proName + "    \t\t" + strTotalQty + "\t\t" + proPrice + Environment.NewLine);

                        }
                        if (proName.Length == 10)
                        {
                            // 3 charc
                            rcs.textBox1.AppendText(proName + "   \t\t" + strTotalQty + "\t\t" + proPrice + Environment.NewLine);

                        }
                        if (proName.Length == 11)
                        {
                            // 2 charc
                            rcs.textBox1.AppendText(proName + "  \t\t" + strTotalQty + "\t\t" + proPrice + Environment.NewLine);

                        }
                        if (proName.Length == 12)
                        {
                            // 1 charc
                            rcs.textBox1.AppendText(proName + " \t\t" + strTotalQty + "\t\t" + proPrice + Environment.NewLine);

                        }
                        if (proName.Length == 13)
                        {
                            rcs.textBox1.AppendText(proName + "\t\t" + strTotalQty + "\t\t" + proPrice + Environment.NewLine);
                        }

                    }

                    // is greater than 7
                    else if (proName.Length < 7)
                    {
                        if (proName.Length == 1)
                        {
                            rcs.textBox1.AppendText(proName + "            \t\t" + strTotalQty + "\t\t" + proPrice + Environment.NewLine);
                        }
                        if (proName.Length == 2)
                        {
                            rcs.textBox1.AppendText(proName + "           \t\t" + strTotalQty + "\t\t" + proPrice + Environment.NewLine);

                        }
                        if (proName.Length == 3)
                        {
                            rcs.textBox1.AppendText(proName + "          \t\t" + strTotalQty + "\t\t" + proPrice + Environment.NewLine);

                        }
                        if (proName.Length == 4)
                        {
                            rcs.textBox1.AppendText(proName + "         \t\t\t" + strTotalQty + "\t\t" + proPrice + Environment.NewLine);

                        }
                        if (proName.Length == 5)
                        {
                            rcs.textBox1.AppendText(proName + "        \t\t" + strTotalQty + "\t\t" + proPrice + Environment.NewLine);

                        }
                        if (proName.Length == 6)
                        {
                            rcs.textBox1.AppendText(proName + "       \t\t" + strTotalQty + "\t\t" + proPrice + Environment.NewLine);

                        }


                    }


                }

                _entities = new KBBQEntities();

                var cgstPer = _entities.tblTaxes.FirstOrDefault().tax_1;
                var sgstPer = _entities.tblTaxes.FirstOrDefault().tax_2;


                rcs.textBox1.AppendText("========================================" + Environment.NewLine);

                rcs.textBox1.AppendText(Environment.NewLine);
                rcs.textBox1.AppendText("\t\t\tSub Total..." + lblSubTotal.Text + Environment.NewLine);
                rcs.textBox1.AppendText("\t\t\tTax............." + (double.Parse(lblTaxAmt.Text) + double.Parse(lblVat.Text)) + Environment.NewLine);
                rcs.textBox1.AppendText("\t\t\tPayable....." + lblTotalAmt.Text + Environment.NewLine);
                rcs.textBox1.AppendText("========================================" + Environment.NewLine);

                rcs.textBox1.AppendText("Description" + "\t\tTaxable" + "\t\tTax" + Environment.NewLine);

                //set subtotal and VAT
                rcs.textBox1.AppendText("CGST" + "( " + cgstPer.ToString().Substring(0, 4) + " %)" + "\t\t" + lblSubTotal.Text + "\t\t" + lblTaxAmt.Text + Environment.NewLine);

                //set subtotal and TAX
                rcs.textBox1.AppendText("SGST" + "( " + sgstPer.ToString().Substring(0, 4) + " %)" + "\t\t" + lblSubTotal.Text + "\t\t" + lblVat.Text + Environment.NewLine);

                rcs.textBox1.AppendText(Environment.NewLine + "---------------------------------------------------------------------------------------------------" + Environment.NewLine);



                rcs.textBox1.AppendText(Environment.NewLine + "Transaction: " + "PAID" + Environment.NewLine);
                rcs.textBox1.AppendText(Environment.NewLine + "---------------------------------------------------------------------------------------------------" + Environment.NewLine);

                rcs.textBox1.AppendText("Thank you for your visit, Please do visit us again");
                rcs.textBox1.AppendText(Environment.NewLine + "========================================" + Environment.NewLine);
                rcs.ShowDialog();
            }


        }

    }
}


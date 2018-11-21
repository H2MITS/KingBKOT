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

namespace Cindy_Restaurant.Form_View
{
    public partial class frmVTaxSales : Form
    {
        KBBQEntities _entities;
        public frmVTaxSales()
        {
            InitializeComponent();
        }

        private void frmVTaxSales_Load(object sender, EventArgs e)
        {
            dataGridView2.AutoGenerateColumns = false;
            clsView viewClass = new clsView();
            //viewClass.viewTaxSales(dataGridView1);

            _entities = new KBBQEntities();

            var cgstPer = _entities.tblTaxes.FirstOrDefault().tax_1;
            var sgstPer = _entities.tblTaxes.FirstOrDefault().tax_2;

         //   dataGridView2.Columns[4].HeaderText = "CGST( " + cgstPer.ToString().Substring(0, 4) + " %)";
           // dataGridView2.Columns[5].HeaderText = "( " + sgstPer.ToString().Substring(0, 4) + " %)";

            dataGridBind();
        }

        void dataGridBind()
        {
            try
            {
                _entities = new KBBQEntities();

                var data = _entities.billAndSettlements.Where(x => x.mode == "PAID").ToList();

                List<billAndSettlementVM> modelList = new List<billAndSettlementVM>();
                int row = 1;
                foreach (var item in data)
                {
                    billAndSettlementVM model = new billAndSettlementVM();
                    model.rowNo = row;
                    model.kot = _entities.detailsSettlements.Where(x => x.KOT == item.kot).FirstOrDefault().receiptno;

                    model.orderDecrip = item.orderDecrip;
                    model.ordDate = item.ordDate.ToString("dd-MMM-yyyy");
                    model.tax1_Amt = item.tax1_Amt;
                    model.tax2_Amt = item.tax2_Amt;
                    row++;
                    modelList.Add(model);                    
                }
                dataGridView2.DataSource = modelList;
            }
            catch (Exception x)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace Cindy_Restaurant.Form_View
{
    public partial class frmViewOrderInfo : Form
    {
        KBBQEntities _entities;
        object keyboardProc;

        public frmViewOrderInfo()
        {
            InitializeComponent();
        }
        clsView viewClass = new clsView();

        private void frmViewOrderInfo_Load(object sender, EventArgs e)
        {
            try
            {
                // viewClass.viewOrderInfo(dataGridView1);

                //dateFrom.Format = DateTimePickerFormat.Custom;
                //dateFrom.CustomFormat = "dd-MM-yyyy";


                //dateTo.Format = DateTimePickerFormat.Custom;
                //dateTo.CustomFormat = "dd-MM-yyyy";
                dataGridView1.AutoGenerateColumns = false;

                _entities = new KBBQEntities();

                List<OrderInfoVM> modelList = new List<OrderInfoVM>();

                var data = _entities.tblOrderInfoes.OrderBy(x => x.KOT).ToList();

                if (data != null)
                {
                    foreach (var item in data)
                    {
                        OrderInfoVM model = new OrderInfoVM();

                        model.KOT = item.KOT;
                        model.orderType = item.orderType;
                        model.tableNo = item.tableNo;
                        model.ordDate = item.ordDate;
                        model.ordTime = item.ordTime;
                        model.guests = item.fname + " " + item.lname;
                        model.adultNo = item.adultNo;
                        model.childrenNo = item.childrenNo;

                        var empName = _entities.tblEmployees.Where(x => x.empID == item.empID).FirstOrDefault();

                        if (empName != null)
                        {
                            model.empName = empName.fname;
                        }

                        modelList.Add(model);

                    }

                    dataGridView1.DataSource = modelList;
                }
            }
            catch(Exception x)
            {

            }
        }


      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                 //DateTime fromdate = DateTime.ParseExact(dateFrom.Text, "dd-MM-yyyy", null);
                 //DateTime todate = DateTime.ParseExact(dateTo.Text, "dd-MM-yyyy", null);

                viewClass.viewOrderInfoByDates(dataGridView1, Convert.ToDateTime(dateFrom.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dateTo.Text).ToString("yyyy-MM-dd"));

                dataGridView1.AutoGenerateColumns = false;

                _entities = new KBBQEntities();

                List<OrderInfoVM> modelList = new List<OrderInfoVM>();

                DateTime fromDate = Convert.ToDateTime(dateFrom.Text);
                DateTime toDate = Convert.ToDateTime(dateTo.Text);

                var data = _entities.tblOrderInfoes.Where(x=>x.ordDate>=fromDate && x.ordDate<=toDate).OrderBy(x => x.KOT).ToList();

                if (data != null)
                {
                    foreach (var item in data)
                    {
                        OrderInfoVM model = new OrderInfoVM();

                        model.KOT = item.KOT;
                        model.orderType = item.orderType;
                        model.tableNo = item.tableNo;
                        model.ordDate = item.ordDate;
                        model.ordTime = item.ordTime;
                        model.guests = item.fname + " " + item.lname;
                        model.adultNo = item.adultNo;
                        model.childrenNo = item.childrenNo;

                        var empName = _entities.tblEmployees.Where(x => x.empID == item.empID).FirstOrDefault();

                        if (empName != null)
                        {
                            model.empName = empName.fname;
                        }

                        modelList.Add(model);

                    }

                    dataGridView1.DataSource = modelList;
                }
            }

            catch (Exception x)
            {
                MessageBox.Show(x.ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            _entities = new KBBQEntities();

            List<OrderInfoVM> modelList = new List<OrderInfoVM>();

            var data = _entities.tblOrderInfoes.OrderBy(x => x.KOT).ToList();

            if (data != null)
            {
                foreach (var item in data)
                {
                    OrderInfoVM model = new OrderInfoVM();

                    model.KOT = item.KOT;
                    model.orderType = item.orderType;
                    model.tableNo = item.tableNo;
                    model.ordDate = item.ordDate;
                    model.ordTime = item.ordTime;
                    model.guests = item.fname + " " + item.lname;
                    model.adultNo = item.adultNo;
                    model.childrenNo = item.childrenNo;

                    var empName = _entities.tblEmployees.Where(x => x.empID == item.empID).FirstOrDefault();

                    if (empName != null)
                    {
                        model.empName = empName.fname;
                    }

                    modelList.Add(model);

                }

                dataGridView1.DataSource = modelList;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dateFrom.Value = DateTimePicker.MinimumDateTime;
            dateTo.Value = DateTimePicker.MinimumDateTime;
            dataGridView1.DataSource = null;
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

            this.keyboardProc = Process.Start(keyboardPath);
        }
    }
}

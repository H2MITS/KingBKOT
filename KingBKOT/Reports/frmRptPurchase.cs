﻿using KingBKOT.Classes;
using KingBKOT.Data;
using KingBKOT.ViewModel;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingBKOT.Reports
{
    public partial class frmRptPurchase : Form
    {
        string type;
        KBBQEntities _entities;
        AmtFomatting amtFormat = new AmtFomatting();
        decimal? ttlAmt = 0;

        public frmRptPurchase(string typesss)
        {
            InitializeComponent();
            type = typesss;
        }
        
        private void frmRptPurchase_Load(object sender, EventArgs e)
        {
            showReport();
            this.reportViewer1.RefreshReport();
        }

        void showReport()
        {
            try
            {

                ttlAmt = 0;
                int rowNo = 1;
                _entities = new KBBQEntities();

                List<DetailSettlementVM> modelList = new List<DetailSettlementVM>();
                List<tbl_PurchaseMaster> data = new List<tbl_PurchaseMaster>();

                if (type == "--All--")
                {
                    #region PurchaseData
                    data = _entities.tbl_PurchaseMaster.ToList();

                    foreach (var item in data)
                    {
                        DetailSettlementVM model = new DetailSettlementVM();

                        model.rowNo = rowNo;
                        DateTime dt = Convert.ToDateTime(item.date).Date;

                        model.monthYear = dt.Date.ToString("dd-MM-yyyy");
                        model.AmountPaid = Convert.ToDecimal(amtFormat.comma(item.totalAmt));

                        rowNo++;
                        
                        ttlAmt += Convert.ToDecimal(item.totalAmt);
                        modelList.Add(model);
                    }
                    DetailSettlementVM models = new DetailSettlementVM();
                    models.totalAmount = Convert.ToDecimal(ttlAmt);
                    modelList.Add(models);

                    ReportDataSource datasource = new ReportDataSource("DataSet1", modelList);

                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(datasource);

                    #endregion

                }
                else if (type == "Month")
                {
                    string dates = "";
                    decimal? amt = 0;
                    int rowId = -1;

                    #region Purchase Data
                    ttlAmt = 0;
                    rowNo = 1;
 

                    _entities = new KBBQEntities();

                    data = new List<tbl_PurchaseMaster>();
                    data = _entities.tbl_PurchaseMaster.ToList();

                    int dataSaleCount = data.Count();
                    int count = 0;
                    DetailSettlementVM model = new DetailSettlementVM();
                
                    foreach (var item in data)
                    {
                        var date = Convert.ToDateTime(item.date).Date;
                        string dd = date.ToString("MMM");

                        if (dd != dates)
                        {
                            model = new DetailSettlementVM();
                            model.rowNo = rowNo;
                            model.monthYear = dd;

                            //modelListSales.Add(model);
                            //dgSalesReport.Rows.Add("0", rowNo, dd);
                            dates = dd;
                            amt = 0;
                            rowId++;
                        }
                        amt += item.totalAmt;


                        model.AmountPaid = Convert.ToDecimal(amtFormat.comma(amt));

                        if (dd != dates)
                        {
                            modelList.Add(model);
                        }

                        rowNo++;
                        count++;

                        ttlAmt += item.totalAmt;


                        if (dataSaleCount == count)
                        {
                            modelList.Add(model);
                        }
                    }
                    DetailSettlementVM models = new DetailSettlementVM();
                    models.totalAmount = Convert.ToDecimal(ttlAmt);
                    modelList.Add(models);

                    ReportDataSource datasource = new ReportDataSource("DataSet1", modelList);

                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(datasource);
                    #endregion

                  
                }
                else
                {

                    string dates = "";
                    decimal? amt = 0;
                    int rowId = -1;

                    #region Purchase Data
                    ttlAmt = 0;
                    rowNo = 1;


                    _entities = new KBBQEntities();

                    data = new List<tbl_PurchaseMaster>();
                    data = _entities.tbl_PurchaseMaster.ToList();

                    int dataSaleCount = data.Count();
                    int count = 0;
                    DetailSettlementVM model = new DetailSettlementVM();

                    foreach (var item in data)
                    {
                        var date = Convert.ToDateTime(item.date).Date;
                        string dd = date.ToString("yyyy");

                        if (dd != dates)
                        {
                            model = new DetailSettlementVM();
                            model.rowNo = rowNo;
                            model.monthYear = dd;

                            //modelListSales.Add(model);
                            //dgSalesReport.Rows.Add("0", rowNo, dd);
                            dates = dd;
                            amt = 0;
                            rowId++;
                        }
                        amt += item.totalAmt;


                        model.AmountPaid = Convert.ToDecimal(amtFormat.comma(amt));

                        if (dd != dates)
                        {
                            modelList.Add(model);
                        }

                        rowNo++;
                        count++;

                        ttlAmt += item.totalAmt;


                        if (dataSaleCount == count)
                        {
                            modelList.Add(model);
                        }
                    }
                    DetailSettlementVM models = new DetailSettlementVM();
                    models.totalAmount = Convert.ToDecimal(ttlAmt);
                    modelList.Add(models);

                    ReportDataSource datasource = new ReportDataSource("DataSet1", modelList);

                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(datasource);
                    #endregion
                }
            }
            catch (Exception x)
            {

            }
        }
    }
}

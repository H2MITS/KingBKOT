﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace KingBKOT.Forms
{
    public partial class EmployeeSalary : UserControl
    {
        private object keyboardProc;
        public EmployeeSalary()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeName.Text = string.Empty;
            //dateMonth.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");
            this.keyboardProc = Process.Start(keyboardPath);
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtEmployeeName.Text = string.Empty;
            txtEmployeeId.Text = string.Empty;
            txtSalary.Text = string.Empty;
            comboEmployeeType.Text = string.Empty;
            //dateMonth.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
        }
    }
}
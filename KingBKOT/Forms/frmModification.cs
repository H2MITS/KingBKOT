﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cindy_Restaurant.Classes;
using System.Diagnostics;
using System.IO;

namespace Cindy_Restaurant.Forms
{
    public partial class frmModification : Form
    {

        object keyboardProc;
        public string getEmpName;
        public frmModification()
        {
            InitializeComponent();
        }
       

        clsSelect selectClass = new clsSelect();
        public string getModApplyRate, getModApplyName;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[0];

            getModApplyRate = row.Cells[5].Value.ToString();
            getModApplyName = row.Cells[0].Value.ToString();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtApplyName.Text = row.Cells[0].Value.ToString();
                txtSubTotal.Text = row.Cells[1].Value.ToString();
                txtVat.Text = row.Cells[2].Value.ToString();
                txtTourLevy.Text = row.Cells[3].Value.ToString();
                txtTax3.Text = row.Cells[4].Value.ToString();
                txtApplyRate.Text = row.Cells[5].Value.ToString();
                txtTotal.Text = row.Cells[5].Value.ToString();

            }
        }


        private void btnApplyRate_Click(object sender, EventArgs e)
        {
            valApplyRate(txtApplyRate);

            if (clsSelect.err.GetError(txtApplyRate).Length != 0)
            {
                clsSelect.err.SetIconAlignment(txtApplyRate, ErrorIconAlignment.MiddleLeft);
                clsSelect.err.SetError(txtApplyRate, "Please numeric value");
                return;
            }
            else
            {
                DataGridViewRow row = this.dataGridView1.Rows[0];
                row.Cells[5].Value = txtApplyRate.Text;
            }
        }

        private void btnApplyName_Click(object sender, EventArgs e)
        {
            valApplyName(txtApplyName);

            if (clsSelect.err.GetError(txtApplyName).Length != 0)
            {
                clsSelect.err.SetIconAlignment(txtApplyName, ErrorIconAlignment.MiddleLeft);
                clsSelect.err.SetError(txtApplyName, "Please field can\'t be empty");
                return;
            }

           else
            {
                DataGridViewRow row = this.dataGridView1.Rows[0];
                row.Cells[0].Value = txtApplyName.Text;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            valApplyName(txtApplyName);
            valApplyRate(txtApplyRate);
            if (clsSelect.err.GetError(txtApplyName).Length != 0) {
                clsSelect.err.SetIconAlignment(txtApplyName, ErrorIconAlignment.MiddleLeft);
                clsSelect.err.SetError(txtApplyName, "Please field can\'t be empty");
                return;
            }
            else if (clsSelect.err.GetError(txtApplyRate).Length != 0)
            {
                clsSelect.err.SetIconAlignment(txtApplyRate, ErrorIconAlignment.MiddleLeft);
                clsSelect.err.SetError(txtApplyRate, "Please numeric value");
                return;
            }

            else { 
            
             DataGridViewRow row = this.dataGridView1.Rows[0];

            getModApplyRate = row.Cells[5].Value.ToString();
            getModApplyName = row.Cells[0].Value.ToString();
            this.Hide();
            }

           

        }


        void valApplyName(Control ctrl)
        {

            if (txtApplyName.Text.Trim().Length > 0)
            {
                clsSelect.err.SetIconAlignment(txtApplyName, ErrorIconAlignment.MiddleLeft);
                clsSelect.err.SetError(txtApplyName, string.Empty);

            }
            else
            {

                clsSelect.err.SetIconAlignment(txtApplyName, ErrorIconAlignment.MiddleLeft);
                clsSelect.err.SetError(txtApplyName, "Please field can\'t be empty");
                return;

            }



        }

        void valApplyRate(Control ctrl)
        {
            double num;
            if (txtApplyRate.Text.Trim().Length > 0 && double.TryParse(txtApplyRate.Text, out num))
            {
                clsSelect.err.SetIconAlignment(txtApplyRate, ErrorIconAlignment.MiddleLeft);
                clsSelect.err.SetError(txtApplyRate, string.Empty);

            }
            else
            {

                clsSelect.err.SetIconAlignment(txtApplyRate, ErrorIconAlignment.MiddleLeft);
                clsSelect.err.SetError(txtApplyRate, "Please numeric value");
                return;

            }

        }

        private void txtApplyName_TextChanged(object sender, EventArgs e)
        {
            valApplyName((Control)sender);
        }

        private void txtApplyRate_TextChanged(object sender, EventArgs e)
        {
            valApplyRate((Control)sender);
        }

        private void txtApplyRate_Leave(object sender, EventArgs e)
        {
            valApplyRate((Control)sender);
        }

        private void txtApplyName_Leave(object sender, EventArgs e)
        {
            valApplyName((Control)sender);
        }

        private void frmModification_FormClosing(object sender, FormClosingEventArgs e)
        {
            
               
        }

        private void frmModification_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtApplyName.Text = string.Empty;
            txtApplyRate.Text = string.Empty;
            txtSubTotal.Text = string.Empty;
            txtTax3.Text = string.Empty;
            txtTourLevy.Text = string.Empty;
            txtVat.Text = string.Empty;
            txtTotal.Text = string.Empty;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtApplyRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtApplyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtSubTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTourLevy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTax3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

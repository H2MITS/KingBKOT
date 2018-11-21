namespace KingBKOT.Form_View
{
    partial class frmPurchaseSaleReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseSaleReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSalesRow = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblSalesTotalAmt = new System.Windows.Forms.Label();
            this.lblTotalAmt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPurchasePrint = new System.Windows.Forms.Button();
            this.btnPrintSales = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.datePannel = new System.Windows.Forms.Panel();
            this.btnDatSearcsh = new System.Windows.Forms.Button();
            this.monthYearPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgSalesReport = new System.Windows.Forms.DataGridView();
            this.dgPurchaseReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.datePannel.SuspendLayout();
            this.monthYearPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalesRow
            // 
            this.lblSalesRow.AutoSize = true;
            this.lblSalesRow.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesRow.ForeColor = System.Drawing.Color.White;
            this.lblSalesRow.Location = new System.Drawing.Point(623, 540);
            this.lblSalesRow.Name = "lblSalesRow";
            this.lblSalesRow.Size = new System.Drawing.Size(15, 16);
            this.lblSalesRow.TabIndex = 159;
            this.lblSalesRow.Text = "0";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "--All--",
            "Month",
            "Year"});
            this.cmbType.Location = new System.Drawing.Point(115, 6);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(374, 28);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            this.cmbType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbType_Validating);
            // 
            // lblSalesTotalAmt
            // 
            this.lblSalesTotalAmt.AutoSize = true;
            this.lblSalesTotalAmt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTotalAmt.ForeColor = System.Drawing.Color.White;
            this.lblSalesTotalAmt.Location = new System.Drawing.Point(923, 539);
            this.lblSalesTotalAmt.Name = "lblSalesTotalAmt";
            this.lblSalesTotalAmt.Size = new System.Drawing.Size(15, 16);
            this.lblSalesTotalAmt.TabIndex = 163;
            this.lblSalesTotalAmt.Text = "0";
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.AutoSize = true;
            this.lblTotalAmt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmt.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmt.Location = new System.Drawing.Point(407, 538);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(15, 16);
            this.lblTotalAmt.TabIndex = 164;
            this.lblTotalAmt.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(839, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 165;
            this.label1.Text = "Total Sales : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(303, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 166;
            this.label3.Text = "Total Purchase : ";
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRows.ForeColor = System.Drawing.Color.White;
            this.lblTotalRows.Location = new System.Drawing.Point(95, 541);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(15, 16);
            this.lblTotalRows.TabIndex = 160;
            this.lblTotalRows.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(541, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 161;
            this.label4.Text = "Total Rows : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 162;
            this.label2.Text = "Total Rows : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 3);
            this.panel1.TabIndex = 169;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 20.75F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 34);
            this.label12.TabIndex = 168;
            this.label12.Text = "Purchase Report";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(863, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 34);
            this.label5.TabIndex = 168;
            this.label5.Text = "Sales Report";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(852, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 3);
            this.panel2.TabIndex = 169;
            // 
            // btnPurchasePrint
            // 
            this.btnPurchasePrint.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPurchasePrint.FlatAppearance.BorderSize = 0;
            this.btnPurchasePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchasePrint.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasePrint.ForeColor = System.Drawing.Color.White;
            this.btnPurchasePrint.Location = new System.Drawing.Point(16, 581);
            this.btnPurchasePrint.Name = "btnPurchasePrint";
            this.btnPurchasePrint.Size = new System.Drawing.Size(135, 48);
            this.btnPurchasePrint.TabIndex = 2;
            this.btnPurchasePrint.Text = "Print Purchase";
            this.btnPurchasePrint.UseVisualStyleBackColor = false;
            this.btnPurchasePrint.Click += new System.EventHandler(this.btnPurchasePrint_Click);
            // 
            // btnPrintSales
            // 
            this.btnPrintSales.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrintSales.FlatAppearance.BorderSize = 0;
            this.btnPrintSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSales.ForeColor = System.Drawing.Color.White;
            this.btnPrintSales.Location = new System.Drawing.Point(536, 581);
            this.btnPrintSales.Name = "btnPrintSales";
            this.btnPrintSales.Size = new System.Drawing.Size(135, 48);
            this.btnPrintSales.TabIndex = 4;
            this.btnPrintSales.Text = "Print Sales";
            this.btnPrintSales.UseVisualStyleBackColor = false;
            this.btnPrintSales.Click += new System.EventHandler(this.btnPrintSales_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(16, 572);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 3);
            this.panel3.TabIndex = 173;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(-1, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(509, 3);
            this.panel4.TabIndex = 30;
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKeyboard.FlatAppearance.BorderSize = 0;
            this.btnKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyboard.ForeColor = System.Drawing.Color.White;
            this.btnKeyboard.Location = new System.Drawing.Point(381, 581);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(135, 48);
            this.btnKeyboard.TabIndex = 3;
            this.btnKeyboard.Text = "Keyboard";
            this.btnKeyboard.UseVisualStyleBackColor = false;
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 175;
            this.label6.Text = "Select Term:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(909, 581);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 48);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 177;
            this.label7.Text = "Start Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Location = new System.Drawing.Point(96, 8);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(120, 26);
            this.dtpFromDate.TabIndex = 176;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(238, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 179;
            this.label8.Text = "End Date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Location = new System.Drawing.Point(320, 8);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(120, 26);
            this.dtpToDate.TabIndex = 178;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(408, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 26);
            this.radioButton1.TabIndex = 180;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "By Date";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(579, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(175, 26);
            this.radioButton2.TabIndex = 180;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "By Month / Year";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // datePannel
            // 
            this.datePannel.Controls.Add(this.btnDatSearcsh);
            this.datePannel.Controls.Add(this.dtpFromDate);
            this.datePannel.Controls.Add(this.label7);
            this.datePannel.Controls.Add(this.dtpToDate);
            this.datePannel.Controls.Add(this.label8);
            this.datePannel.Location = new System.Drawing.Point(355, 44);
            this.datePannel.Name = "datePannel";
            this.datePannel.Size = new System.Drawing.Size(497, 52);
            this.datePannel.TabIndex = 181;
            // 
            // btnDatSearcsh
            // 
            this.btnDatSearcsh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDatSearcsh.FlatAppearance.BorderSize = 0;
            this.btnDatSearcsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatSearcsh.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnDatSearcsh.ForeColor = System.Drawing.Color.White;
            this.btnDatSearcsh.Image = ((System.Drawing.Image)(resources.GetObject("btnDatSearcsh.Image")));
            this.btnDatSearcsh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatSearcsh.Location = new System.Drawing.Point(446, 4);
            this.btnDatSearcsh.Name = "btnDatSearcsh";
            this.btnDatSearcsh.Size = new System.Drawing.Size(43, 38);
            this.btnDatSearcsh.TabIndex = 180;
            this.btnDatSearcsh.UseVisualStyleBackColor = false;
            this.btnDatSearcsh.Click += new System.EventHandler(this.btnDatSearcsh_Click);
            // 
            // monthYearPanel
            // 
            this.monthYearPanel.Controls.Add(this.cmbType);
            this.monthYearPanel.Controls.Add(this.label6);
            this.monthYearPanel.Location = new System.Drawing.Point(28, 48);
            this.monthYearPanel.Name = "monthYearPanel";
            this.monthYearPanel.Size = new System.Drawing.Size(497, 42);
            this.monthYearPanel.TabIndex = 181;
            this.monthYearPanel.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(12, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1030, 3);
            this.panel5.TabIndex = 174;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(-1, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(509, 3);
            this.panel6.TabIndex = 30;
            // 
            // dgSalesReport
            // 
            this.dgSalesReport.AllowUserToAddRows = false;
            this.dgSalesReport.AllowUserToDeleteRows = false;
            this.dgSalesReport.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSalesReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column7,
            this.Column9,
            this.Column10,
            this.Column1,
            this.Column11});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSalesReport.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgSalesReport.Location = new System.Drawing.Point(536, 161);
            this.dgSalesReport.Name = "dgSalesReport";
            this.dgSalesReport.ReadOnly = true;
            this.dgSalesReport.Size = new System.Drawing.Size(505, 373);
            this.dgSalesReport.TabIndex = 182;
            // 
            // dgPurchaseReport
            // 
            this.dgPurchaseReport.AllowUserToAddRows = false;
            this.dgPurchaseReport.AllowUserToDeleteRows = false;
            this.dgPurchaseReport.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPurchaseReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPurchaseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPurchaseReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPurchaseReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPurchaseReport.Location = new System.Drawing.Point(4, 161);
            this.dgPurchaseReport.Name = "dgPurchaseReport";
            this.dgPurchaseReport.ReadOnly = true;
            this.dgPurchaseReport.Size = new System.Drawing.Size(505, 373);
            this.dgPurchaseReport.TabIndex = 182;
            this.dgPurchaseReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPurchaseReport_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "rowNo";
            this.dataGridViewTextBoxColumn7.HeaderText = "#";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "KOT";
            this.dataGridViewTextBoxColumn8.HeaderText = "Receipt No";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 192;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "monthYear";
            this.dataGridViewTextBoxColumn9.HeaderText = "Month / Year";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "totalAmt";
            this.dataGridViewTextBoxColumn10.HeaderText = "Purchase Amt";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id";
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "rowNo";
            this.Column7.HeaderText = "#";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "KOT";
            this.Column9.HeaderText = "Receipt No";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 70;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "monthYear";
            this.Column10.HeaderText = "Month / Year";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "advancePaid";
            this.Column1.HeaderText = "Adv. Payments";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "amountPaid";
            this.Column11.HeaderText = "Sales Amt";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // frmPurchaseSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1066, 641);
            this.Controls.Add(this.dgPurchaseReport);
            this.Controls.Add(this.dgSalesReport);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.monthYearPanel);
            this.Controls.Add(this.datePannel);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnKeyboard);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnPrintSales);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPurchasePrint);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblSalesRow);
            this.Controls.Add(this.lblSalesTotalAmt);
            this.Controls.Add(this.lblTotalAmt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalRows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPurchaseSaleReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Sale Report";
            this.Load += new System.EventHandler(this.frmPurchaseSaleReport_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.datePannel.ResumeLayout(false);
            this.datePannel.PerformLayout();
            this.monthYearPanel.ResumeLayout(false);
            this.monthYearPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalesRow;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblSalesTotalAmt;
        private System.Windows.Forms.Label lblTotalAmt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPurchasePrint;
        private System.Windows.Forms.Button btnPrintSales;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel monthYearPanel;
        private System.Windows.Forms.Panel datePannel;
        private System.Windows.Forms.Button btnDatSearcsh;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgSalesReport;
        private System.Windows.Forms.DataGridView dgPurchaseReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}
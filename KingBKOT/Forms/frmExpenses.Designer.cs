namespace KingBKOT.Forms
{
    partial class frmExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpenses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtExpBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpName = new System.Windows.Forms.TextBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.dateToday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDatSearcsh = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblTotalRecord = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalExp = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(178, 211);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 3);
            this.panel3.TabIndex = 43;
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKeyboard.FlatAppearance.BorderSize = 0;
            this.btnKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyboard.ForeColor = System.Drawing.Color.Black;
            this.btnKeyboard.Location = new System.Drawing.Point(327, 230);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(103, 52);
            this.btnKeyboard.TabIndex = 5;
            this.btnKeyboard.Text = "Keyboard";
            this.btnKeyboard.UseVisualStyleBackColor = false;
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(470, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 52);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(50, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 3);
            this.panel2.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 3);
            this.panel1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(47, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 34);
            this.label3.TabIndex = 41;
            this.label3.Text = "Daily Expenses";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(622, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 52);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(178, 230);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(103, 52);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Save";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtExpBy
            // 
            this.txtExpBy.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtExpBy.Location = new System.Drawing.Point(178, 145);
            this.txtExpBy.MaxLength = 30;
            this.txtExpBy.Name = "txtExpBy";
            this.txtExpBy.Size = new System.Drawing.Size(336, 25);
            this.txtExpBy.TabIndex = 2;
            this.txtExpBy.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Exp By (Name)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Expenses Name";
            // 
            // txtExpName
            // 
            this.txtExpName.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtExpName.Location = new System.Drawing.Point(178, 77);
            this.txtExpName.MaxLength = 30;
            this.txtExpName.Name = "txtExpName";
            this.txtExpName.Size = new System.Drawing.Size(336, 25);
            this.txtExpName.TabIndex = 0;
            this.txtExpName.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // txtAmt
            // 
            this.txtAmt.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtAmt.Location = new System.Drawing.Point(178, 180);
            this.txtAmt.MaxLength = 5;
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(120, 25);
            this.txtAmt.TabIndex = 3;
            this.txtAmt.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(53, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 176;
            this.label7.Text = "Exp Date:";
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpDate.Location = new System.Drawing.Point(178, 111);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(120, 26);
            this.dtpExpDate.TabIndex = 1;
            // 
            // dateToday
            // 
            this.dateToday.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToday.Location = new System.Drawing.Point(742, 24);
            this.dateToday.Name = "dateToday";
            this.dateToday.Size = new System.Drawing.Size(120, 26);
            this.dateToday.TabIndex = 175;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(687, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 176;
            this.label6.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 25);
            this.label5.TabIndex = 178;
            this.label5.Text = "Daily Expense List";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Goldenrod;
            this.panel5.Location = new System.Drawing.Point(17, 333);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 3);
            this.panel5.TabIndex = 177;
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
            this.btnDatSearcsh.Location = new System.Drawing.Point(819, 300);
            this.btnDatSearcsh.Name = "btnDatSearcsh";
            this.btnDatSearcsh.Size = new System.Drawing.Size(43, 38);
            this.btnDatSearcsh.TabIndex = 186;
            this.btnDatSearcsh.UseVisualStyleBackColor = false;
            this.btnDatSearcsh.Click += new System.EventHandler(this.btnDatSearcsh_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(602, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 184;
            this.label11.Text = "End Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(377, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 185;
            this.label8.Text = "Start Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(693, 310);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(120, 26);
            this.dtpEndDate.TabIndex = 182;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(468, 311);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(120, 26);
            this.dtpStartDate.TabIndex = 183;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToDeleteRows = false;
            this.dgvExpenses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenses.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpenses.Location = new System.Drawing.Point(12, 355);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.Size = new System.Drawing.Size(850, 263);
            this.dgvExpenses.TabIndex = 187;
            this.dgvExpenses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenses_CellContentClick);
            this.dgvExpenses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenses_CellDoubleClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 645);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(850, 3);
            this.panel4.TabIndex = 189;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(545, 621);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(317, 19);
            this.label15.TabIndex = 190;
            this.label15.Text = "* Note : Double-Click on any one row to EDIT.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 650);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 188;
            this.label9.Text = "Total Record:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "rowNo";
            this.Column2.HeaderText = "#";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "expName";
            this.Column3.HeaderText = "Exp. Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "expDate";
            this.Column4.HeaderText = "Exp Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "amount";
            this.Column5.HeaderText = "Amount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "expBy";
            this.Column6.HeaderText = "Exp By";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "cdate";
            this.Column7.HeaderText = "Created On";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "udate";
            this.Column8.HeaderText = "Update On";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Actions";
            this.Delete.Image = global::KingBKOT.Properties.Resources.delete1;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // lblTotalRecord
            // 
            this.lblTotalRecord.AutoSize = true;
            this.lblTotalRecord.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.lblTotalRecord.ForeColor = System.Drawing.Color.White;
            this.lblTotalRecord.Location = new System.Drawing.Point(118, 650);
            this.lblTotalRecord.Name = "lblTotalRecord";
            this.lblTotalRecord.Size = new System.Drawing.Size(17, 20);
            this.lblTotalRecord.TabIndex = 191;
            this.lblTotalRecord.Text = "0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(520, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(268, 19);
            this.label10.TabIndex = 192;
            this.label10.Text = "* Note : Name of person who did exp.";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Pink;
            this.panel6.Controls.Add(this.lblError);
            this.panel6.Location = new System.Drawing.Point(231, 650);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(274, 32);
            this.panel6.TabIndex = 193;
            this.panel6.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblError.Location = new System.Drawing.Point(3, 6);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(152, 20);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Confirm Password : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(602, 651);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 188;
            this.label12.Text = "Total Expenses:";
            // 
            // lblTotalExp
            // 
            this.lblTotalExp.AutoSize = true;
            this.lblTotalExp.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.lblTotalExp.ForeColor = System.Drawing.Color.White;
            this.lblTotalExp.Location = new System.Drawing.Point(719, 653);
            this.lblTotalExp.Name = "lblTotalExp";
            this.lblTotalExp.Size = new System.Drawing.Size(17, 20);
            this.lblTotalExp.TabIndex = 191;
            this.lblTotalExp.Text = "0";
            // 
            // frmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(874, 691);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalExp);
            this.Controls.Add(this.lblTotalRecord);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.btnDatSearcsh);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateToday);
            this.Controls.Add(this.dtpExpDate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnKeyboard);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.txtExpName);
            this.Controls.Add(this.txtExpBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Expenses";
            this.Load += new System.EventHandler(this.frmExpenses_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtExpBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpName;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.DateTimePicker dateToday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDatSearcsh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label lblTotalRecord;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTotalExp;
        private System.Windows.Forms.Label label12;
    }
}
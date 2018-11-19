namespace Cindy_Restaurant.Form_View
{
    partial class receiptList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receiptList));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearcsh = new System.Windows.Forms.TextBox();
            this.cboSearcshMode = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDineIn = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkTakeAway = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkNoCharge = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnMyOrder = new System.Windows.Forms.Button();
            this.btnRecall = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.brnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTableNo = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMergePay = new System.Windows.Forms.Button();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.btnMergePayFinal = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDatSearcsh = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(603, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "[All Receipt, All Order]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearcsh);
            this.groupBox1.Controls.Add(this.cboSearcshMode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(616, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearcsh
            // 
            this.txtSearcsh.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtSearcsh.Location = new System.Drawing.Point(311, 23);
            this.txtSearcsh.Name = "txtSearcsh";
            this.txtSearcsh.Size = new System.Drawing.Size(299, 25);
            this.txtSearcsh.TabIndex = 1;
            // 
            // cboSearcshMode
            // 
            this.cboSearcshMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearcshMode.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.cboSearcshMode.FormattingEnabled = true;
            this.cboSearcshMode.Items.AddRange(new object[] {
            "Firstname",
            "Lastname",
            "Receipt number"});
            this.cboSearcshMode.Location = new System.Drawing.Point(149, 22);
            this.cboSearcshMode.Name = "cboSearcshMode";
            this.cboSearcshMode.Size = new System.Drawing.Size(156, 27);
            this.cboSearcshMode.TabIndex = 0;
            this.cboSearcshMode.SelectedIndexChanged += new System.EventHandler(this.cboSearcshMode_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDineIn);
            this.groupBox2.Location = new System.Drawing.Point(52, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 38);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // chkDineIn
            // 
            this.chkDineIn.AutoSize = true;
            this.chkDineIn.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.chkDineIn.ForeColor = System.Drawing.Color.White;
            this.chkDineIn.Location = new System.Drawing.Point(41, 11);
            this.chkDineIn.Name = "chkDineIn";
            this.chkDineIn.Size = new System.Drawing.Size(79, 24);
            this.chkDineIn.TabIndex = 0;
            this.chkDineIn.Text = "Dine In";
            this.chkDineIn.UseVisualStyleBackColor = true;
            this.chkDineIn.CheckedChanged += new System.EventHandler(this.chkDineIn_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkTakeAway);
            this.groupBox3.Location = new System.Drawing.Point(265, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 38);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // chkTakeAway
            // 
            this.chkTakeAway.AutoSize = true;
            this.chkTakeAway.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.chkTakeAway.ForeColor = System.Drawing.Color.White;
            this.chkTakeAway.Location = new System.Drawing.Point(34, 12);
            this.chkTakeAway.Name = "chkTakeAway";
            this.chkTakeAway.Size = new System.Drawing.Size(108, 24);
            this.chkTakeAway.TabIndex = 4;
            this.chkTakeAway.Text = "Take Away";
            this.chkTakeAway.UseVisualStyleBackColor = true;
            this.chkTakeAway.CheckedChanged += new System.EventHandler(this.chkTakeAway_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkNoCharge);
            this.groupBox4.Location = new System.Drawing.Point(476, 188);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 38);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // chkNoCharge
            // 
            this.chkNoCharge.AutoSize = true;
            this.chkNoCharge.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.chkNoCharge.ForeColor = System.Drawing.Color.White;
            this.chkNoCharge.Location = new System.Drawing.Point(35, 11);
            this.chkNoCharge.Name = "chkNoCharge";
            this.chkNoCharge.Size = new System.Drawing.Size(109, 24);
            this.chkNoCharge.TabIndex = 5;
            this.chkNoCharge.Text = "No Charge";
            this.chkNoCharge.UseVisualStyleBackColor = true;
            this.chkNoCharge.CheckedChanged += new System.EventHandler(this.chkNoCharge_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(12, 550);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(111, 59);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 25);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btnMyOrder
            // 
            this.btnMyOrder.BackColor = System.Drawing.Color.Gold;
            this.btnMyOrder.FlatAppearance.BorderSize = 0;
            this.btnMyOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyOrder.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnMyOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyOrder.Location = new System.Drawing.Point(620, 12);
            this.btnMyOrder.Name = "btnMyOrder";
            this.btnMyOrder.Size = new System.Drawing.Size(180, 40);
            this.btnMyOrder.TabIndex = 8;
            this.btnMyOrder.Text = "My Order";
            this.btnMyOrder.UseVisualStyleBackColor = false;
            this.btnMyOrder.Click += new System.EventHandler(this.btnMyOrder_Click);
            // 
            // btnRecall
            // 
            this.btnRecall.BackColor = System.Drawing.Color.Chartreuse;
            this.btnRecall.FlatAppearance.BorderSize = 0;
            this.btnRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecall.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnRecall.Location = new System.Drawing.Point(478, 566);
            this.btnRecall.Name = "btnRecall";
            this.btnRecall.Size = new System.Drawing.Size(89, 41);
            this.btnRecall.TabIndex = 10;
            this.btnRecall.Text = "Recall";
            this.toolTip1.SetToolTip(this.btnRecall, "Click on the item in the grid to select \r\nand click recall to select payment");
            this.btnRecall.UseVisualStyleBackColor = false;
            this.btnRecall.Click += new System.EventHandler(this.btnRecall_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(686, 565);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 42);
            this.button5.TabIndex = 12;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(341, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Receipt List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(347, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 3);
            this.panel2.TabIndex = 34;
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
            // brnClear
            // 
            this.brnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.brnClear.FlatAppearance.BorderSize = 0;
            this.brnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnClear.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.brnClear.ForeColor = System.Drawing.Color.Black;
            this.brnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnClear.Location = new System.Drawing.Point(577, 565);
            this.brnClear.Name = "brnClear";
            this.brnClear.Size = new System.Drawing.Size(99, 42);
            this.brnClear.TabIndex = 11;
            this.brnClear.Text = "Clear";
            this.brnClear.UseVisualStyleBackColor = false;
            this.brnClear.Click += new System.EventHandler(this.brnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Table No";
            // 
            // cmbTableNo
            // 
            this.cmbTableNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableNo.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.cmbTableNo.FormattingEnabled = true;
            this.cmbTableNo.Location = new System.Drawing.Point(172, 87);
            this.cmbTableNo.Name = "cmbTableNo";
            this.cmbTableNo.Size = new System.Drawing.Size(156, 27);
            this.cmbTableNo.TabIndex = 0;
            this.cmbTableNo.SelectedIndexChanged += new System.EventHandler(this.cmbTableNo_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Delete});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Location = new System.Drawing.Point(12, 232);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(824, 292);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "kot";
            this.Column1.HeaderText = "Reciept No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "orderDecrip";
            this.Column2.HeaderText = "Order Desc";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "guestName";
            this.Column3.HeaderText = "Guest Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ordDate";
            this.Column4.HeaderText = "Order Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ordTime";
            this.Column5.HeaderText = "Order Time";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "totalDue";
            this.Column6.HeaderText = "Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnMergePay
            // 
            this.btnMergePay.Location = new System.Drawing.Point(0, 0);
            this.btnMergePay.Name = "btnMergePay";
            this.btnMergePay.Size = new System.Drawing.Size(75, 23);
            this.btnMergePay.TabIndex = 0;
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKeyboard.FlatAppearance.BorderSize = 0;
            this.btnKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyboard.ForeColor = System.Drawing.Color.White;
            this.btnKeyboard.Location = new System.Drawing.Point(12, 615);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(345, 42);
            this.btnKeyboard.TabIndex = 72;
            this.btnKeyboard.Text = "Keyboard";
            this.btnKeyboard.UseVisualStyleBackColor = false;
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnMergePayFinal
            // 
            this.btnMergePayFinal.BackColor = System.Drawing.Color.Green;
            this.btnMergePayFinal.FlatAppearance.BorderSize = 0;
            this.btnMergePayFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMergePayFinal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMergePayFinal.ForeColor = System.Drawing.Color.White;
            this.btnMergePayFinal.Location = new System.Drawing.Point(476, 615);
            this.btnMergePayFinal.Name = "btnMergePayFinal";
            this.btnMergePayFinal.Size = new System.Drawing.Size(311, 42);
            this.btnMergePayFinal.TabIndex = 72;
            this.btnMergePayFinal.Text = "Merge Pay";
            this.btnMergePayFinal.UseVisualStyleBackColor = false;
            this.btnMergePayFinal.Click += new System.EventHandler(this.btnMergePay_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Action";
            this.dataGridViewImageColumn1.Image = global::KingBKOT.Properties.Resources.delete11;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 117;
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
            this.btnDatSearcsh.Location = new System.Drawing.Point(129, 567);
            this.btnDatSearcsh.Name = "btnDatSearcsh";
            this.btnDatSearcsh.Size = new System.Drawing.Size(43, 38);
            this.btnDatSearcsh.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnDatSearcsh, "Select date from the date option on the left\r\nside of this button and click\r\nsear" +
        "ch");
            this.btnDatSearcsh.UseVisualStyleBackColor = false;
            this.btnDatSearcsh.Click += new System.EventHandler(this.btnDatSearcsh_Click);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Action";
            this.Delete.Image = global::KingBKOT.Properties.Resources.delete11;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnUpdate.Location = new System.Drawing.Point(187, 566);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 41);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UnHold / (Update)";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // receiptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(812, 682);
            this.Controls.Add(this.btnMergePayFinal);
            this.Controls.Add(this.btnKeyboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTableNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brnClear);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRecall);
            this.Controls.Add(this.btnMyOrder);
            this.Controls.Add(this.btnDatSearcsh);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "receiptList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt List- King Bar Beque Restaurant";
            this.Load += new System.EventHandler(this.frmRecall_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearcsh;
        private System.Windows.Forms.ComboBox cboSearcshMode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkDineIn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkTakeAway;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkNoCharge;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDatSearcsh;
        private System.Windows.Forms.Button btnMyOrder;
        private System.Windows.Forms.Button btnRecall;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button brnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTableNo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnMergePay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
      //  private System.Windows.Forms.Button btnMergePay;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Button btnMergePayFinal;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnUpdate;
    }
}
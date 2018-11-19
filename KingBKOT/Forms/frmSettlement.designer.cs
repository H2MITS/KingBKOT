namespace Cindy_Restaurant.Forms
{
    partial class frmSettlement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettlement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCash = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCashout = new System.Windows.Forms.Button();
            this.cboPaymentType = new System.Windows.Forms.ComboBox();
            this.txtRateTimesAmtPaid = new System.Windows.Forms.TextBox();
            this.lblcustCurrency = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReceiptNum = new System.Windows.Forms.TextBox();
            this.txtAmtPAid = new System.Windows.Forms.TextBox();
            this.txtCustOwes = new System.Windows.Forms.TextBox();
            this.cboSelectCurrency = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAmtToPay = new System.Windows.Forms.TextBox();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.txtReceiptNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnView = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCash.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.txtAmtPAid);
            this.groupBox1.Controls.Add(this.txtCustOwes);
            this.groupBox1.Location = new System.Drawing.Point(466, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(235, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 3);
            this.panel3.TabIndex = 31;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(267, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "₹";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "₹";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(23, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(196, 62);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Payment Date And Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 25);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCash);
            this.tabControl1.Location = new System.Drawing.Point(23, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 357);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCash
            // 
            this.tabCash.BackColor = System.Drawing.Color.MidnightBlue;
            this.tabCash.Controls.Add(this.groupBox6);
            this.tabCash.Controls.Add(this.btnCashout);
            this.tabCash.Controls.Add(this.cboPaymentType);
            this.tabCash.Controls.Add(this.txtRateTimesAmtPaid);
            this.tabCash.Controls.Add(this.lblcustCurrency);
            this.tabCash.Controls.Add(this.label11);
            this.tabCash.Controls.Add(this.label5);
            this.tabCash.Controls.Add(this.label4);
            this.tabCash.Controls.Add(this.txtReceiptNum);
            this.tabCash.Location = new System.Drawing.Point(4, 22);
            this.tabCash.Name = "tabCash";
            this.tabCash.Padding = new System.Windows.Forms.Padding(3);
            this.tabCash.Size = new System.Drawing.Size(413, 331);
            this.tabCash.TabIndex = 0;
            this.tabCash.Text = "Cash";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Orange;
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txtDisc);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.txtCode);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(9, 122);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(396, 100);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Coupon Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(271, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "%";
            // 
            // txtDisc
            // 
            this.txtDisc.Enabled = false;
            this.txtDisc.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtDisc.Location = new System.Drawing.Point(173, 59);
            this.txtDisc.MaxLength = 10;
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(96, 25);
            this.txtDisc.TabIndex = 12;
            this.txtDisc.Leave += new System.EventHandler(this.txtDisc_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(46, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Discount %";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtCode.Location = new System.Drawing.Point(173, 19);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(208, 25);
            this.txtCode.TabIndex = 11;
            this.txtCode.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Code";
            // 
            // btnCashout
            // 
            this.btnCashout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCashout.FlatAppearance.BorderSize = 0;
            this.btnCashout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashout.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnCashout.ForeColor = System.Drawing.Color.White;
            this.btnCashout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashout.Location = new System.Drawing.Point(274, 280);
            this.btnCashout.Name = "btnCashout";
            this.btnCashout.Size = new System.Drawing.Size(120, 45);
            this.btnCashout.TabIndex = 14;
            this.btnCashout.Text = "Paid";
            this.btnCashout.UseVisualStyleBackColor = false;
            this.btnCashout.Click += new System.EventHandler(this.btnCashout_Click);
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentType.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cboPaymentType.Location = new System.Drawing.Point(185, 32);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.Size = new System.Drawing.Size(209, 27);
            this.cboPaymentType.TabIndex = 9;
            // 
            // txtRateTimesAmtPaid
            // 
            this.txtRateTimesAmtPaid.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtRateTimesAmtPaid.Location = new System.Drawing.Point(186, 236);
            this.txtRateTimesAmtPaid.Name = "txtRateTimesAmtPaid";
            this.txtRateTimesAmtPaid.ReadOnly = true;
            this.txtRateTimesAmtPaid.Size = new System.Drawing.Size(208, 25);
            this.txtRateTimesAmtPaid.TabIndex = 13;
            this.txtRateTimesAmtPaid.TextChanged += new System.EventHandler(this.txtRateTimesAmtPaid_TextChanged);
            // 
            // lblcustCurrency
            // 
            this.lblcustCurrency.AutoSize = true;
            this.lblcustCurrency.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblcustCurrency.ForeColor = System.Drawing.Color.White;
            this.lblcustCurrency.Location = new System.Drawing.Point(161, 236);
            this.lblcustCurrency.Name = "lblcustCurrency";
            this.lblcustCurrency.Size = new System.Drawing.Size(20, 24);
            this.lblcustCurrency.TabIndex = 2;
            this.lblcustCurrency.Text = "₹";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Amount Paid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Receipt Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Payment Type";
            // 
            // txtReceiptNum
            // 
            this.txtReceiptNum.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtReceiptNum.Location = new System.Drawing.Point(185, 84);
            this.txtReceiptNum.Name = "txtReceiptNum";
            this.txtReceiptNum.ReadOnly = true;
            this.txtReceiptNum.Size = new System.Drawing.Size(209, 25);
            this.txtReceiptNum.TabIndex = 10;
            this.txtReceiptNum.TextChanged += new System.EventHandler(this.txtReceiptNum_TextChanged);
            // 
            // txtAmtPAid
            // 
            this.txtAmtPAid.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtAmtPAid.Location = new System.Drawing.Point(297, 57);
            this.txtAmtPAid.MaxLength = 10;
            this.txtAmtPAid.Name = "txtAmtPAid";
            this.txtAmtPAid.Size = new System.Drawing.Size(124, 25);
            this.txtAmtPAid.TabIndex = 0;
            this.txtAmtPAid.TextChanged += new System.EventHandler(this.txtAmtPAid_TextChanged);
            this.txtAmtPAid.Leave += new System.EventHandler(this.txtAmtPAid_Leave);
            // 
            // txtCustOwes
            // 
            this.txtCustOwes.Enabled = false;
            this.txtCustOwes.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtCustOwes.Location = new System.Drawing.Point(297, 16);
            this.txtCustOwes.Name = "txtCustOwes";
            this.txtCustOwes.ReadOnly = true;
            this.txtCustOwes.Size = new System.Drawing.Size(124, 25);
            this.txtCustOwes.TabIndex = 7;
            this.txtCustOwes.TextChanged += new System.EventHandler(this.txtCustOwes_TextChanged);
            // 
            // cboSelectCurrency
            // 
            this.cboSelectCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectCurrency.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.cboSelectCurrency.FormattingEnabled = true;
            this.cboSelectCurrency.Location = new System.Drawing.Point(190, 56);
            this.cboSelectCurrency.Name = "cboSelectCurrency";
            this.cboSelectCurrency.Size = new System.Drawing.Size(209, 27);
            this.cboSelectCurrency.TabIndex = 11;
            this.cboSelectCurrency.Visible = false;
            this.cboSelectCurrency.SelectedIndexChanged += new System.EventHandler(this.cboSelectCurrency_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Select the Currency";
            this.label6.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Enabled = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(613, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 47);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(739, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 47);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 20.75F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(342, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(285, 34);
            this.label12.TabIndex = 2;
            this.label12.Text = "Receipt Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAmtToPay);
            this.groupBox3.Controls.Add(this.txtBill);
            this.groupBox3.Controls.Add(this.txtReceiptNo);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(51, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 155);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // txtAmtToPay
            // 
            this.txtAmtToPay.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtAmtToPay.Location = new System.Drawing.Point(188, 105);
            this.txtAmtToPay.Name = "txtAmtToPay";
            this.txtAmtToPay.ReadOnly = true;
            this.txtAmtToPay.Size = new System.Drawing.Size(186, 25);
            this.txtAmtToPay.TabIndex = 3;
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtBill.Location = new System.Drawing.Point(188, 65);
            this.txtBill.Name = "txtBill";
            this.txtBill.ReadOnly = true;
            this.txtBill.Size = new System.Drawing.Size(186, 25);
            this.txtBill.TabIndex = 2;
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtReceiptNo.Location = new System.Drawing.Point(188, 25);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.ReadOnly = true;
            this.txtReceiptNo.Size = new System.Drawing.Size(186, 25);
            this.txtReceiptNo.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Amount Paying";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(121, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "curPay";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(16, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Receipt #:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(16, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Bill Amount";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(47, 476);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(120, 47);
            this.btnView.TabIndex = 32;
            this.btnView.Text = "View";
            this.toolTip1.SetToolTip(this.btnView, "Helps to view the transaction");
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(348, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 3);
            this.panel2.TabIndex = 30;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(47, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(378, 181);
            this.dataGridView1.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "kot";
            this.Column1.HeaderText = "Kot";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ordDate";
            this.Column2.HeaderText = "Order Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ordTime";
            this.Column3.HeaderText = "Order Time";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "totalDue";
            this.Column4.HeaderText = "Amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKeyboard);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(51, 532);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 63);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKeyboard.FlatAppearance.BorderSize = 0;
            this.btnKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyboard.ForeColor = System.Drawing.Color.White;
            this.btnKeyboard.Location = new System.Drawing.Point(487, 10);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(120, 47);
            this.btnKeyboard.TabIndex = 72;
            this.btnKeyboard.Text = "Keyboard";
            this.btnKeyboard.UseVisualStyleBackColor = false;
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(613, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 47);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(739, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 47);
            this.button3.TabIndex = 14;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSettlement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(986, 741);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cboSelectCurrency);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettlement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Settlement - King Bar Beque Restaurant";
            this.Load += new System.EventHandler(this.frmSettlement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCash.ResumeLayout(false);
            this.tabCash.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmtPAid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCash;
        private System.Windows.Forms.ComboBox cboSelectCurrency;
        private System.Windows.Forms.ComboBox cboPaymentType;
        private System.Windows.Forms.TextBox txtRateTimesAmtPaid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAmtToPay;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.TextBox txtReceiptNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblcustCurrency;
        public System.Windows.Forms.TextBox txtReceiptNum;
        private System.Windows.Forms.Button btnCashout;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.TextBox txtCustOwes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
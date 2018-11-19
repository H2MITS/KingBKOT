namespace KingBKOT.Forms
{
    partial class frmPurchaseMasterMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboUnit = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtitemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgPurchaseItem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.dateToday = new System.Windows.Forms.DateTimePicker();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHiddenId = new System.Windows.Forms.Label();
            this.lblhiddenCategoryName = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtAmtInWords = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.txtTotalAmt = new System.Windows.Forms.TextBox();
            this.txtTotalWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblBtnError = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseItem)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboUnit
            // 
            this.comboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUnit.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.comboUnit.FormattingEnabled = true;
            this.comboUnit.Items.AddRange(new object[] {
            "Gram",
            "Kg"});
            this.comboUnit.Location = new System.Drawing.Point(597, 80);
            this.comboUnit.Name = "comboUnit";
            this.comboUnit.Size = new System.Drawing.Size(118, 27);
            this.comboUnit.TabIndex = 4;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtWeight.Location = new System.Drawing.Point(477, 81);
            this.txtWeight.MaxLength = 50;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(103, 26);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtRate.Location = new System.Drawing.Point(732, 81);
            this.txtRate.MaxLength = 50;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(188, 26);
            this.txtRate.TabIndex = 5;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            this.txtRate.Leave += new System.EventHandler(this.txtRate_Leave);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtQty.Location = new System.Drawing.Point(325, 81);
            this.txtQty.MaxLength = 50;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(135, 26);
            this.txtQty.TabIndex = 2;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtitemName
            // 
            this.txtitemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtitemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtitemName.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtitemName.Location = new System.Drawing.Point(16, 81);
            this.txtitemName.MaxLength = 50;
            this.txtitemName.Name = "txtitemName";
            this.txtitemName.Size = new System.Drawing.Size(290, 26);
            this.txtitemName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 169;
            this.label1.Text = "Item Name : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(593, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 167;
            this.label6.Text = "Unit : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(473, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 168;
            this.label3.Text = "Weight : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(728, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 165;
            this.label8.Text = "Rate : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(321, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 166;
            this.label2.Text = "Qty : ";
            // 
            // dgPurchaseItem
            // 
            this.dgPurchaseItem.AllowUserToAddRows = false;
            this.dgPurchaseItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgPurchaseItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgPurchaseItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPurchaseItem.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgPurchaseItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPurchaseItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgPurchaseItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPurchaseItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column7,
            this.Column4,
            this.Column9,
            this.Column10,
            this.Delete});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPurchaseItem.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgPurchaseItem.Location = new System.Drawing.Point(16, 125);
            this.dgPurchaseItem.Name = "dgPurchaseItem";
            this.dgPurchaseItem.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPurchaseItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgPurchaseItem.Size = new System.Drawing.Size(1003, 204);
            this.dgPurchaseItem.TabIndex = 170;
            this.dgPurchaseItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPurchaseOrderDetails_CellContentClick);
            this.dgPurchaseItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPurchaseItem_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "SrNo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Item Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Qty";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Weight";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Unit";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Rate";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 150;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.HeaderText = "Actions";
            this.Delete.Image = global::KingBKOT.Properties.Resources.delete1;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(737, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 174;
            this.label7.Text = "Date:";
            // 
            // dateToday
            // 
            this.dateToday.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToday.Location = new System.Drawing.Point(791, 12);
            this.dateToday.Name = "dateToday";
            this.dateToday.Size = new System.Drawing.Size(120, 26);
            this.dateToday.TabIndex = 172;
            // 
            // txtRefNo
            // 
            this.txtRefNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRefNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRefNo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtRefNo.Location = new System.Drawing.Point(81, 12);
            this.txtRefNo.MaxLength = 50;
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(290, 26);
            this.txtRefNo.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 173;
            this.label9.Text = "Bill No : ";
            // 
            // lblHiddenId
            // 
            this.lblHiddenId.AutoSize = true;
            this.lblHiddenId.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblHiddenId.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblHiddenId.Location = new System.Drawing.Point(434, 332);
            this.lblHiddenId.Name = "lblHiddenId";
            this.lblHiddenId.Size = new System.Drawing.Size(88, 20);
            this.lblHiddenId.TabIndex = 175;
            this.lblHiddenId.Text = "Hidden Id: ";
            this.lblHiddenId.Visible = false;
            // 
            // lblhiddenCategoryName
            // 
            this.lblhiddenCategoryName.AutoSize = true;
            this.lblhiddenCategoryName.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblhiddenCategoryName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblhiddenCategoryName.Location = new System.Drawing.Point(289, 332);
            this.lblhiddenCategoryName.Name = "lblhiddenCategoryName";
            this.lblhiddenCategoryName.Size = new System.Drawing.Size(148, 20);
            this.lblhiddenCategoryName.TabIndex = 176;
            this.lblhiddenCategoryName.Text = "Hidden Cat Name: ";
            this.lblhiddenCategoryName.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(13, 332);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(270, 17);
            this.label15.TabIndex = 177;
            this.label15.Text = "* Note : Double-Click on any one row to EDIT.";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtRemark.Location = new System.Drawing.Point(25, 478);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(473, 51);
            this.txtRemark.TabIndex = 178;
            // 
            // txtAmtInWords
            // 
            this.txtAmtInWords.Enabled = false;
            this.txtAmtInWords.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtAmtInWords.Location = new System.Drawing.Point(25, 376);
            this.txtAmtInWords.Multiline = true;
            this.txtAmtInWords.Name = "txtAmtInWords";
            this.txtAmtInWords.Size = new System.Drawing.Size(473, 70);
            this.txtAmtInWords.TabIndex = 180;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(21, 454);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 21);
            this.label14.TabIndex = 181;
            this.label14.Text = "Remarks : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 21);
            this.label10.TabIndex = 182;
            this.label10.Text = "Amt In Words : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Pink;
            this.panel3.Controls.Add(this.lblError);
            this.panel3.Location = new System.Drawing.Point(25, 535);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 32);
            this.panel3.TabIndex = 179;
            this.panel3.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblError.ForeColor = System.Drawing.Color.Black;
            this.lblError.Location = new System.Drawing.Point(3, 6);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(152, 20);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Confirm Password : ";
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.Enabled = false;
            this.txtTotalAmt.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtTotalAmt.Location = new System.Drawing.Point(732, 420);
            this.txtTotalAmt.MaxLength = 15;
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.Size = new System.Drawing.Size(144, 26);
            this.txtTotalAmt.TabIndex = 184;
            // 
            // txtTotalWeight
            // 
            this.txtTotalWeight.Enabled = false;
            this.txtTotalWeight.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtTotalWeight.Location = new System.Drawing.Point(732, 376);
            this.txtTotalWeight.MaxLength = 15;
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.Size = new System.Drawing.Size(144, 26);
            this.txtTotalWeight.TabIndex = 183;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(593, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 189;
            this.label4.Text = "Total Weight : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(593, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 189;
            this.label5.Text = "Total Amt : ";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.lblUnit.ForeColor = System.Drawing.Color.White;
            this.lblUnit.Location = new System.Drawing.Point(880, 381);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(31, 21);
            this.lblUnit.TabIndex = 189;
            this.lblUnit.Text = "Kg";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(880, 422);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 21);
            this.label17.TabIndex = 189;
            this.label17.Text = "/- rs";
            // 
            // lblBtnError
            // 
            this.lblBtnError.AutoSize = true;
            this.lblBtnError.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblBtnError.ForeColor = System.Drawing.Color.Red;
            this.lblBtnError.Location = new System.Drawing.Point(516, 485);
            this.lblBtnError.Name = "lblBtnError";
            this.lblBtnError.Size = new System.Drawing.Size(199, 16);
            this.lblBtnError.TabIndex = 192;
            this.lblBtnError.Text = "*Go to Rate textbox and enter tab";
            this.lblBtnError.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(632, 510);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 57);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(514, 510);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 57);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.BackColor = System.Drawing.Color.Orange;
            this.btnKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyboard.ForeColor = System.Drawing.Color.Black;
            this.btnKeyboard.Location = new System.Drawing.Point(751, 510);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(112, 57);
            this.btnKeyboard.TabIndex = 6;
            this.btnKeyboard.Text = "Keyboard";
            this.btnKeyboard.UseVisualStyleBackColor = false;
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(869, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 57);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPurchaseMasterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1031, 604);
            this.Controls.Add(this.lblBtnError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnKeyboard);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalAmt);
            this.Controls.Add(this.txtTotalWeight);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtAmtInWords);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblHiddenId);
            this.Controls.Add(this.lblhiddenCategoryName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateToday);
            this.Controls.Add(this.txtRefNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgPurchaseItem);
            this.Controls.Add(this.comboUnit);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtitemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPurchaseMasterMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPurchaseMasterMain";
            this.Load += new System.EventHandler(this.frmPurchaseMasterMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseItem)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboUnit;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtitemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgPurchaseItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateToday;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHiddenId;
        private System.Windows.Forms.Label lblhiddenCategoryName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtAmtInWords;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtTotalAmt;
        private System.Windows.Forms.TextBox txtTotalWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblBtnError;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnKeyboard;
    }
}
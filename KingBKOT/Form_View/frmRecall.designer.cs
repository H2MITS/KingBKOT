namespace Cindy_Restaurant.Form_View
{
    partial class btnCancel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearcsh = new System.Windows.Forms.TextBox();
            this.cboSearcshMode = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDineIn = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkTakeAway = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkNoCharge = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDatSearcsh = new System.Windows.Forms.Button();
            this.btnMyOrder = new System.Windows.Forms.Button();
            this.btnRecall = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.brnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
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
            this.btnSearch.TabIndex = 3;
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
            this.txtSearcsh.TabIndex = 2;
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
            this.cboSearcshMode.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dataGridView1.Location = new System.Drawing.Point(52, 232);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 292);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.groupBox3.TabIndex = 3;
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
            this.chkTakeAway.TabIndex = 0;
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
            this.groupBox4.TabIndex = 3;
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
            this.chkNoCharge.TabIndex = 0;
            this.chkNoCharge.Text = "No Charge";
            this.chkNoCharge.UseVisualStyleBackColor = true;
            this.chkNoCharge.CheckedChanged += new System.EventHandler(this.chkNoCharge_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(46, 550);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(111, 59);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 25);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnDatSearcsh
            // 
            this.btnDatSearcsh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDatSearcsh.FlatAppearance.BorderSize = 0;
            this.btnDatSearcsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatSearcsh.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnDatSearcsh.ForeColor = System.Drawing.Color.White;
            this.btnDatSearcsh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatSearcsh.Location = new System.Drawing.Point(169, 568);
            this.btnDatSearcsh.Name = "btnDatSearcsh";
            this.btnDatSearcsh.Size = new System.Drawing.Size(82, 40);
            this.btnDatSearcsh.TabIndex = 5;
            this.btnDatSearcsh.Text = "Search";
            this.toolTip1.SetToolTip(this.btnDatSearcsh, "Select date from the date option on the left\r\nside of this button and click\r\nsear" +
        "ch");
            this.btnDatSearcsh.UseVisualStyleBackColor = false;
            this.btnDatSearcsh.Click += new System.EventHandler(this.btnDatSearcsh_Click);
            // 
            // btnMyOrder
            // 
            this.btnMyOrder.BackColor = System.Drawing.Color.Gold;
            this.btnMyOrder.FlatAppearance.BorderSize = 0;
            this.btnMyOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyOrder.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnMyOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyOrder.Location = new System.Drawing.Point(262, 568);
            this.btnMyOrder.Name = "btnMyOrder";
            this.btnMyOrder.Size = new System.Drawing.Size(106, 41);
            this.btnMyOrder.TabIndex = 5;
            this.btnMyOrder.Text = "My Order";
            this.btnMyOrder.UseVisualStyleBackColor = false;
            this.btnMyOrder.Click += new System.EventHandler(this.btnMyOrder_Click);
            // 
            // btnRecall
            // 
            this.btnRecall.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRecall.FlatAppearance.BorderSize = 0;
            this.btnRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecall.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnRecall.Location = new System.Drawing.Point(478, 568);
            this.btnRecall.Name = "btnRecall";
            this.btnRecall.Size = new System.Drawing.Size(89, 41);
            this.btnRecall.TabIndex = 5;
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
            this.button5.Location = new System.Drawing.Point(686, 567);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 42);
            this.button5.TabIndex = 5;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(379, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Split";
            this.button1.UseVisualStyleBackColor = false;
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
            this.brnClear.ForeColor = System.Drawing.Color.White;
            this.brnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnClear.Location = new System.Drawing.Point(577, 567);
            this.brnClear.Name = "brnClear";
            this.brnClear.Size = new System.Drawing.Size(99, 42);
            this.brnClear.TabIndex = 5;
            this.brnClear.Text = "Clear";
            this.brnClear.UseVisualStyleBackColor = false;
            this.brnClear.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(839, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brnClear);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnRecall);
            this.Controls.Add(this.btnMyOrder);
            this.Controls.Add(this.btnDatSearcsh);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "btnCancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt List- King Bar Beque Restaurant";
            this.Load += new System.EventHandler(this.frmRecall_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button brnClear;
    }
}
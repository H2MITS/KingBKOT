namespace Cindy_Restaurant.Forms
{
    partial class frmModification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModification));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax3 = new System.Windows.Forms.TextBox();
            this.txtTourLevy = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApplyRate = new System.Windows.Forms.TextBox();
            this.txtApplyName = new System.Windows.Forms.TextBox();
            this.btnApplyRate = new System.Windows.Forms.Button();
            this.btnApplyName = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 110);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(808, 93);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtTax3);
            this.groupBox1.Controls.Add(this.txtTourLevy);
            this.groupBox1.Controls.Add(this.txtVat);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(432, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Amount Breakdown";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtTotal.Location = new System.Drawing.Point(127, 190);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(287, 25);
            this.txtTotal.TabIndex = 8;
            // 
            // txtTax3
            // 
            this.txtTax3.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtTax3.Location = new System.Drawing.Point(127, 151);
            this.txtTax3.Name = "txtTax3";
            this.txtTax3.ReadOnly = true;
            this.txtTax3.Size = new System.Drawing.Size(287, 25);
            this.txtTax3.TabIndex = 7;
            // 
            // txtTourLevy
            // 
            this.txtTourLevy.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtTourLevy.Location = new System.Drawing.Point(127, 111);
            this.txtTourLevy.Name = "txtTourLevy";
            this.txtTourLevy.ReadOnly = true;
            this.txtTourLevy.Size = new System.Drawing.Size(287, 25);
            this.txtTourLevy.TabIndex = 6;
            // 
            // txtVat
            // 
            this.txtVat.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtVat.Location = new System.Drawing.Point(127, 70);
            this.txtVat.Name = "txtVat";
            this.txtVat.ReadOnly = true;
            this.txtVat.Size = new System.Drawing.Size(287, 25);
            this.txtVat.TabIndex = 5;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtSubTotal.Location = new System.Drawing.Point(127, 29);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(287, 25);
            this.txtSubTotal.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cess ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "SGST (2.5%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "CGST (2.5%)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sub Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Rate";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtApplyRate
            // 
            this.txtApplyRate.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtApplyRate.Location = new System.Drawing.Point(158, 253);
            this.txtApplyRate.Name = "txtApplyRate";
            this.txtApplyRate.Size = new System.Drawing.Size(247, 25);
            this.txtApplyRate.TabIndex = 0;
            this.txtApplyRate.TextChanged += new System.EventHandler(this.txtApplyRate_TextChanged);
            this.txtApplyRate.Leave += new System.EventHandler(this.txtApplyRate_Leave);
            // 
            // txtApplyName
            // 
            this.txtApplyName.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtApplyName.Location = new System.Drawing.Point(158, 377);
            this.txtApplyName.Name = "txtApplyName";
            this.txtApplyName.Size = new System.Drawing.Size(247, 25);
            this.txtApplyName.TabIndex = 2;
            this.txtApplyName.TextChanged += new System.EventHandler(this.txtApplyName_TextChanged);
            this.txtApplyName.Leave += new System.EventHandler(this.txtApplyName_Leave);
            // 
            // btnApplyRate
            // 
            this.btnApplyRate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnApplyRate.FlatAppearance.BorderSize = 0;
            this.btnApplyRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyRate.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnApplyRate.Location = new System.Drawing.Point(259, 287);
            this.btnApplyRate.Name = "btnApplyRate";
            this.btnApplyRate.Size = new System.Drawing.Size(146, 32);
            this.btnApplyRate.TabIndex = 1;
            this.btnApplyRate.Text = "Apply Rate";
            this.btnApplyRate.UseVisualStyleBackColor = false;
            this.btnApplyRate.Click += new System.EventHandler(this.btnApplyRate_Click);
            // 
            // btnApplyName
            // 
            this.btnApplyName.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnApplyName.FlatAppearance.BorderSize = 0;
            this.btnApplyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyName.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnApplyName.Location = new System.Drawing.Point(259, 411);
            this.btnApplyName.Name = "btnApplyName";
            this.btnApplyName.Size = new System.Drawing.Size(146, 32);
            this.btnApplyName.TabIndex = 3;
            this.btnApplyName.Text = "Apply Name";
            this.btnApplyName.UseVisualStyleBackColor = false;
            this.btnApplyName.Click += new System.EventHandler(this.btnApplyName_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(672, 25);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 49);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOK);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Location = new System.Drawing.Point(44, 460);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(810, 90);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Yellow;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(13, 25);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(126, 49);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "Submit";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LawnGreen;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(327, 25);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 49);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(44, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 3);
            this.panel2.TabIndex = 31;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(38, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(408, 34);
            this.label8.TabIndex = 30;
            this.label8.Text = "Modify Product Order Details";
            // 
            // frmModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(891, 584);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnApplyName);
            this.Controls.Add(this.btnApplyRate);
            this.Controls.Add(this.txtApplyName);
            this.Controls.Add(this.txtApplyRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmModification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MODIFY PRODUCT ORDER DETAILS - King Bar Beque Restaurant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmModification_FormClosing);
            this.Load += new System.EventHandler(this.frmModification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax3;
        private System.Windows.Forms.TextBox txtTourLevy;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApplyRate;
        private System.Windows.Forms.Button btnApplyName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txtApplyRate;
        public System.Windows.Forms.TextBox txtApplyName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
    }
}
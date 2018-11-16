namespace TestProject.Forms
{
    partial class Form_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFaq = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPurchaseOrder = new System.Windows.Forms.Button();
            this.btnUserRegister = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnSalesReports = new System.Windows.Forms.Button();
            this.btnPurchaseReport = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAddCoupons = new System.Windows.Forms.Button();
            this.btnFoodQuote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statGetUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.workingDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnFaq);
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1127, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 720);
            this.panel1.TabIndex = 0;
            // 
            // btnFaq
            // 
            this.btnFaq.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFaq.FlatAppearance.BorderSize = 0;
            this.btnFaq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaq.ForeColor = System.Drawing.Color.White;
            this.btnFaq.Image = ((System.Drawing.Image)(resources.GetObject("btnFaq.Image")));
            this.btnFaq.Location = new System.Drawing.Point(0, 661);
            this.btnFaq.Name = "btnFaq";
            this.btnFaq.Size = new System.Drawing.Size(73, 59);
            this.btnFaq.TabIndex = 6;
            this.btnFaq.UseVisualStyleBackColor = true;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.Location = new System.Drawing.Point(0, 0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(73, 64);
            this.btnSignOut.TabIndex = 2;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(77, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "King Bar beque";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(480, 688);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Copyrights 2018. All rights reserved By King Barbeque";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(47, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 3);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(68, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 720);
            this.panel3.TabIndex = 28;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPurchaseOrder.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPurchaseOrder.FlatAppearance.BorderSize = 0;
            this.btnPurchaseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseOrder.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseOrder.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseOrder.Image = global::KingBKOT.Properties.Resources.order;
            this.btnPurchaseOrder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPurchaseOrder.Location = new System.Drawing.Point(325, 312);
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.btnPurchaseOrder.Size = new System.Drawing.Size(149, 176);
            this.btnPurchaseOrder.TabIndex = 30;
            this.btnPurchaseOrder.Text = "\r\nPurchases\r\n Order\r\n";
            this.btnPurchaseOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPurchaseOrder.UseVisualStyleBackColor = false;
            this.btnPurchaseOrder.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnUserRegister
            // 
            this.btnUserRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserRegister.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUserRegister.FlatAppearance.BorderSize = 0;
            this.btnUserRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserRegister.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRegister.ForeColor = System.Drawing.Color.White;
            this.btnUserRegister.Image = global::KingBKOT.Properties.Resources.domain__1_;
            this.btnUserRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserRegister.Location = new System.Drawing.Point(170, 494);
            this.btnUserRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 5);
            this.btnUserRegister.Name = "btnUserRegister";
            this.btnUserRegister.Size = new System.Drawing.Size(304, 97);
            this.btnUserRegister.TabIndex = 29;
            this.btnUserRegister.Text = "    User Registration";
            this.btnUserRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserRegister.UseVisualStyleBackColor = false;
            this.btnUserRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSales
            // 
            this.btnSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSales.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = global::KingBKOT.Properties.Resources.sale;
            this.btnSales.Location = new System.Drawing.Point(170, 209);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(149, 279);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "\r\nSales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProducts.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Image = global::KingBKOT.Properties.Resources.menu__2_;
            this.btnProducts.Location = new System.Drawing.Point(624, 209);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(241, 97);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "      Products";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExpenses.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExpenses.ForeColor = System.Drawing.Color.White;
            this.btnExpenses.Image = global::KingBKOT.Properties.Resources.calculator;
            this.btnExpenses.Location = new System.Drawing.Point(871, 208);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(177, 279);
            this.btnExpenses.TabIndex = 1;
            this.btnExpenses.Text = "\r\nExpenses\r\n";
            this.btnExpenses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExpenses.UseVisualStyleBackColor = false;
            this.btnExpenses.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmployee.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.Location = new System.Drawing.Point(606, 415);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(129, 176);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "\r\nEmployees\r\n";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployeeSalary_Click);
            // 
            // btnSalesReports
            // 
            this.btnSalesReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalesReports.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalesReports.FlatAppearance.BorderSize = 0;
            this.btnSalesReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReports.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReports.ForeColor = System.Drawing.Color.White;
            this.btnSalesReports.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesReports.Image")));
            this.btnSalesReports.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalesReports.Location = new System.Drawing.Point(480, 415);
            this.btnSalesReports.Name = "btnSalesReports";
            this.btnSalesReports.Size = new System.Drawing.Size(120, 176);
            this.btnSalesReports.TabIndex = 1;
            this.btnSalesReports.Text = "\r\nSales\r\nReports";
            this.btnSalesReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalesReports.UseVisualStyleBackColor = false;
            this.btnSalesReports.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnPurchaseReport
            // 
            this.btnPurchaseReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPurchaseReport.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPurchaseReport.FlatAppearance.BorderSize = 0;
            this.btnPurchaseReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseReport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseReport.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseReport.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchaseReport.Image")));
            this.btnPurchaseReport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPurchaseReport.Location = new System.Drawing.Point(741, 312);
            this.btnPurchaseReport.Name = "btnPurchaseReport";
            this.btnPurchaseReport.Size = new System.Drawing.Size(124, 176);
            this.btnPurchaseReport.TabIndex = 1;
            this.btnPurchaseReport.Text = "\r\nPurchases\r\nReport\r\n\r\n";
            this.btnPurchaseReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPurchaseReport.UseVisualStyleBackColor = false;
            this.btnPurchaseReport.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSettings.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(741, 494);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(308, 97);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "       Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAddCoupons
            // 
            this.btnAddCoupons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCoupons.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddCoupons.FlatAppearance.BorderSize = 0;
            this.btnAddCoupons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCoupons.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCoupons.ForeColor = System.Drawing.Color.White;
            this.btnAddCoupons.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCoupons.Image")));
            this.btnAddCoupons.Location = new System.Drawing.Point(480, 312);
            this.btnAddCoupons.Name = "btnAddCoupons";
            this.btnAddCoupons.Size = new System.Drawing.Size(255, 97);
            this.btnAddCoupons.TabIndex = 1;
            this.btnAddCoupons.Text = "      Add Coupons";
            this.btnAddCoupons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCoupons.UseVisualStyleBackColor = false;
            this.btnAddCoupons.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnFoodQuote
            // 
            this.btnFoodQuote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFoodQuote.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFoodQuote.FlatAppearance.BorderSize = 0;
            this.btnFoodQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodQuote.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodQuote.ForeColor = System.Drawing.Color.White;
            this.btnFoodQuote.Image = ((System.Drawing.Image)(resources.GetObject("btnFoodQuote.Image")));
            this.btnFoodQuote.Location = new System.Drawing.Point(325, 209);
            this.btnFoodQuote.Name = "btnFoodQuote";
            this.btnFoodQuote.Size = new System.Drawing.Size(294, 97);
            this.btnFoodQuote.TabIndex = 1;
            this.btnFoodQuote.Text = "       Food Quotation";
            this.btnFoodQuote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFoodQuote.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.Location = new System.Drawing.Point(984, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Welcome,";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // statGetUser
            // 
            this.statGetUser.AutoSize = true;
            this.statGetUser.BackColor = System.Drawing.Color.Transparent;
            this.statGetUser.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.statGetUser.Location = new System.Drawing.Point(1076, 24);
            this.statGetUser.Name = "statGetUser";
            this.statGetUser.Size = new System.Drawing.Size(70, 17);
            this.statGetUser.TabIndex = 31;
            this.statGetUser.Text = "Welcome,";
            this.statGetUser.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label5.Location = new System.Drawing.Point(984, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Working Date:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // workingDate
            // 
            this.workingDate.AutoSize = true;
            this.workingDate.BackColor = System.Drawing.Color.Transparent;
            this.workingDate.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.workingDate.Location = new System.Drawing.Point(1077, 49);
            this.workingDate.Name = "workingDate";
            this.workingDate.Size = new System.Drawing.Size(70, 17);
            this.workingDate.TabIndex = 31;
            this.workingDate.Text = "Welcome,";
            this.workingDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.workingDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statGetUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPurchaseOrder);
            this.Controls.Add(this.btnUserRegister);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnSalesReports);
            this.Controls.Add(this.btnPurchaseReport);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnAddCoupons);
            this.Controls.Add(this.btnFoodQuote);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dashboard";
            this.Text = "Form_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFoodQuote;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnAddCoupons;
        private System.Windows.Forms.Button btnPurchaseReport;
        private System.Windows.Forms.Button btnSalesReports;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFaq;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnUserRegister;
        private System.Windows.Forms.Button btnPurchaseOrder;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label statGetUser;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label workingDate;
    }
}
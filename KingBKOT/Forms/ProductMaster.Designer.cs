namespace KingBKOT.Forms
{
    partial class ProductMaster
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.purchaseProducts1 = new KingBKOT.Forms.PurchaseProducts();
            this.addCategory1 = new KingBKOT.Forms.AddCategory();
            this.menuProducts1 = new KingBKOT.Forms.MenuProducts();
            this.listOfMenuProducts1 = new KingBKOT.Forms.ListOfMenuProducts();
            this.listofPurchaseProducts1 = new KingBKOT.Forms.ListofPurchaseProducts();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "List of Purchase Products";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(247, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "List of Menu Products";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Purchase Products";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Menu Products";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 536);
            this.panel2.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(247, 43);
            this.button5.TabIndex = 2;
            this.button5.Text = "Add Category";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.purchaseProducts1);
            this.panel1.Controls.Add(this.addCategory1);
            this.panel1.Controls.Add(this.menuProducts1);
            this.panel1.Controls.Add(this.listOfMenuProducts1);
            this.panel1.Controls.Add(this.listofPurchaseProducts1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(247, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 536);
            this.panel1.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::KingBKOT.Properties.Resources.error;
            this.btnClose.Location = new System.Drawing.Point(850, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 42;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // purchaseProducts1
            // 
            this.purchaseProducts1.BackColor = System.Drawing.Color.MidnightBlue;
            this.purchaseProducts1.Location = new System.Drawing.Point(29, 80);
            this.purchaseProducts1.Name = "purchaseProducts1";
            this.purchaseProducts1.Size = new System.Drawing.Size(741, 434);
            this.purchaseProducts1.TabIndex = 47;
            // 
            // addCategory1
            // 
            this.addCategory1.BackColor = System.Drawing.Color.MidnightBlue;
            this.addCategory1.Location = new System.Drawing.Point(44, 80);
            this.addCategory1.Name = "addCategory1";
            this.addCategory1.Size = new System.Drawing.Size(726, 418);
            this.addCategory1.TabIndex = 46;
            // 
            // menuProducts1
            // 
            this.menuProducts1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuProducts1.Location = new System.Drawing.Point(20, 93);
            this.menuProducts1.Name = "menuProducts1";
            this.menuProducts1.Size = new System.Drawing.Size(769, 412);
            this.menuProducts1.TabIndex = 45;
            // 
            // listOfMenuProducts1
            // 
            this.listOfMenuProducts1.BackColor = System.Drawing.Color.MidnightBlue;
            this.listOfMenuProducts1.Location = new System.Drawing.Point(17, 93);
            this.listOfMenuProducts1.Name = "listOfMenuProducts1";
            this.listOfMenuProducts1.Size = new System.Drawing.Size(726, 414);
            this.listOfMenuProducts1.TabIndex = 44;
            // 
            // listofPurchaseProducts1
            // 
            this.listofPurchaseProducts1.BackColor = System.Drawing.Color.MidnightBlue;
            this.listofPurchaseProducts1.Location = new System.Drawing.Point(20, 80);
            this.listofPurchaseProducts1.Name = "listofPurchaseProducts1";
            this.listofPurchaseProducts1.Size = new System.Drawing.Size(723, 418);
            this.listofPurchaseProducts1.TabIndex = 43;
            // 
            // ProductMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1144, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductMaster";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox btnClose;
        private PurchaseProducts purchaseProducts1;
        private AddCategory addCategory1;
        private MenuProducts menuProducts1;
        private ListOfMenuProducts listOfMenuProducts1;
        private ListofPurchaseProducts listofPurchaseProducts1;
    }
}
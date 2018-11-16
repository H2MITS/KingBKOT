namespace KingBarbeque
{
    partial class KOT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.ComboWaiter = new System.Windows.Forms.ComboBox();
            this.comboTable = new System.Windows.Forms.ComboBox();
            this.lblGenerateKot = new System.Windows.Forms.Label();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.ComboWaiter);
            this.panel1.Controls.Add(this.comboTable);
            this.panel1.Controls.Add(this.lblGenerateKot);
            this.panel1.Controls.Add(this.lblWaiter);
            this.panel1.Controls.Add(this.lblTable);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 153);
            this.panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(599, 97);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(27, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 3);
            this.panel2.TabIndex = 27;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::KingBKOT.Properties.Resources.error;
            this.btnClose.Location = new System.Drawing.Point(655, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 11;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(492, 97);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(90, 32);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // ComboWaiter
            // 
            this.ComboWaiter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboWaiter.FormattingEnabled = true;
            this.ComboWaiter.Items.AddRange(new object[] {
            "Ram",
            "Shyam",
            "Haresh",
            "Karan",
            "Ramesh",
            "Suresh",
            "Mahesh",
            "Meet"});
            this.ComboWaiter.Location = new System.Drawing.Point(319, 100);
            this.ComboWaiter.Name = "ComboWaiter";
            this.ComboWaiter.Size = new System.Drawing.Size(157, 25);
            this.ComboWaiter.TabIndex = 2;
            this.ComboWaiter.Text = "-------------Select------------";
            // 
            // comboTable
            // 
            this.comboTable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTable.FormattingEnabled = true;
            this.comboTable.Items.AddRange(new object[] {
            "Table-01",
            "Table-02",
            "Table-03",
            "Table-04",
            "Table-05",
            "Table-06",
            "Table-07",
            "Table-08",
            "Table-09",
            "Table-10"});
            this.comboTable.Location = new System.Drawing.Point(82, 100);
            this.comboTable.Name = "comboTable";
            this.comboTable.Size = new System.Drawing.Size(157, 25);
            this.comboTable.TabIndex = 1;
            this.comboTable.Text = "-------------Select------------";
            // 
            // lblGenerateKot
            // 
            this.lblGenerateKot.AutoSize = true;
            this.lblGenerateKot.Font = new System.Drawing.Font("Century Gothic", 20.75F);
            this.lblGenerateKot.ForeColor = System.Drawing.Color.White;
            this.lblGenerateKot.Location = new System.Drawing.Point(18, 22);
            this.lblGenerateKot.Name = "lblGenerateKot";
            this.lblGenerateKot.Size = new System.Drawing.Size(221, 34);
            this.lblGenerateKot.TabIndex = 7;
            this.lblGenerateKot.Text = "Generate K.O.T";
            // 
            // lblWaiter
            // 
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblWaiter.ForeColor = System.Drawing.Color.White;
            this.lblWaiter.Location = new System.Drawing.Point(252, 103);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(61, 20);
            this.lblWaiter.TabIndex = 6;
            this.lblWaiter.Text = "Waiter:";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblTable.ForeColor = System.Drawing.Color.White;
            this.lblTable.Location = new System.Drawing.Point(19, 100);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(51, 20);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "Table:";
            // 
            // KOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(711, 154);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KOT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KOT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox ComboWaiter;
        private System.Windows.Forms.ComboBox comboTable;
        private System.Windows.Forms.Label lblGenerateKot;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
    }
}
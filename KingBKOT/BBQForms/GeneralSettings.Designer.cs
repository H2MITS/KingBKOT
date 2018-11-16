namespace KingBKOT.Forms
{
    partial class GeneralSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetKOT = new System.Windows.Forms.Button();
            this.checkboxInvoicePrint = new System.Windows.Forms.CheckBox();
            this.checkboxKOTPrint = new System.Windows.Forms.CheckBox();
            this.checkboxCheckout = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkboxCheckout);
            this.panel1.Controls.Add(this.checkboxKOTPrint);
            this.panel1.Controls.Add(this.checkboxInvoicePrint);
            this.panel1.Controls.Add(this.btnResetKOT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 429);
            this.panel1.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(612, 257);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 32);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(523, 257);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 32);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(9, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 3);
            this.panel3.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(403, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "No. of Prints:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(401, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Order Ready Time:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(554, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "-------------Select------------";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "15 Minutes",
            "30 Minutes",
            "40 Minutes",
            "1 Hour",
            ""});
            this.comboBox2.Location = new System.Drawing.Point(554, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 24);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Text = "-------------Select------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(403, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Reset K.O.T:";
            // 
            // btnResetKOT
            // 
            this.btnResetKOT.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnResetKOT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResetKOT.FlatAppearance.BorderSize = 0;
            this.btnResetKOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetKOT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetKOT.ForeColor = System.Drawing.Color.White;
            this.btnResetKOT.Location = new System.Drawing.Point(554, 115);
            this.btnResetKOT.Name = "btnResetKOT";
            this.btnResetKOT.Size = new System.Drawing.Size(141, 32);
            this.btnResetKOT.TabIndex = 10;
            this.btnResetKOT.Text = "Reset KOT";
            this.btnResetKOT.UseVisualStyleBackColor = false;
            // 
            // checkboxInvoicePrint
            // 
            this.checkboxInvoicePrint.AutoSize = true;
            this.checkboxInvoicePrint.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkboxInvoicePrint.Location = new System.Drawing.Point(20, 18);
            this.checkboxInvoicePrint.Name = "checkboxInvoicePrint";
            this.checkboxInvoicePrint.Size = new System.Drawing.Size(168, 24);
            this.checkboxInvoicePrint.TabIndex = 5;
            this.checkboxInvoicePrint.Text = "Invoice Printing On";
            this.checkboxInvoicePrint.UseVisualStyleBackColor = true;
            // 
            // checkboxKOTPrint
            // 
            this.checkboxKOTPrint.AutoSize = true;
            this.checkboxKOTPrint.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkboxKOTPrint.Location = new System.Drawing.Point(20, 69);
            this.checkboxKOTPrint.Name = "checkboxKOTPrint";
            this.checkboxKOTPrint.Size = new System.Drawing.Size(138, 24);
            this.checkboxKOTPrint.TabIndex = 6;
            this.checkboxKOTPrint.Text = "KOT Printing On";
            this.checkboxKOTPrint.UseVisualStyleBackColor = true;
            // 
            // checkboxCheckout
            // 
            this.checkboxCheckout.AutoSize = true;
            this.checkboxCheckout.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkboxCheckout.Location = new System.Drawing.Point(20, 118);
            this.checkboxCheckout.Name = "checkboxCheckout";
            this.checkboxCheckout.Size = new System.Drawing.Size(193, 24);
            this.checkboxCheckout.TabIndex = 7;
            this.checkboxCheckout.Text = " Checkout KOT Printing";
            this.checkboxCheckout.UseVisualStyleBackColor = true;
            // 
            // GeneralSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.panel1);
            this.Name = "GeneralSettings";
            this.Size = new System.Drawing.Size(726, 438);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnResetKOT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkboxCheckout;
        private System.Windows.Forms.CheckBox checkboxKOTPrint;
        private System.Windows.Forms.CheckBox checkboxInvoicePrint;
    }
}

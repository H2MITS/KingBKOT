namespace Cindy_Restaurant.Folder_Updates
{
    partial class ufrmCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ufrmCurrency));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCurrName = new System.Windows.Forms.TextBox();
            this.txtCurSymbol = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.radInuse = new System.Windows.Forms.RadioButton();
            this.radNotuse = new System.Windows.Forms.RadioButton();
            this.chkSetDefault = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Currency Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Currency Symbol";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtID.Location = new System.Drawing.Point(209, 20);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(272, 25);
            this.txtID.TabIndex = 1;
            // 
            // txtCurrName
            // 
            this.txtCurrName.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtCurrName.Location = new System.Drawing.Point(209, 61);
            this.txtCurrName.MaxLength = 25;
            this.txtCurrName.Name = "txtCurrName";
            this.txtCurrName.Size = new System.Drawing.Size(272, 25);
            this.txtCurrName.TabIndex = 1;
            this.txtCurrName.TextChanged += new System.EventHandler(this.txtCurrName_TextChanged);
            this.txtCurrName.Leave += new System.EventHandler(this.txtCurrName_Leave);
            // 
            // txtCurSymbol
            // 
            this.txtCurSymbol.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtCurSymbol.Location = new System.Drawing.Point(209, 104);
            this.txtCurSymbol.MaxLength = 1;
            this.txtCurSymbol.Name = "txtCurSymbol";
            this.txtCurSymbol.Size = new System.Drawing.Size(272, 25);
            this.txtCurSymbol.TabIndex = 1;
            this.txtCurSymbol.TextChanged += new System.EventHandler(this.txtCurSymbol_TextChanged);
            this.txtCurSymbol.Leave += new System.EventHandler(this.txtCurSymbol_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(209, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(18, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 45);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Statues";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Exchange Rates";
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtExchangeRate.Location = new System.Drawing.Point(209, 190);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(121, 25);
            this.txtExchangeRate.TabIndex = 5;
            this.txtExchangeRate.TextChanged += new System.EventHandler(this.txtExchangeRate_TextChanged);
            this.txtExchangeRate.Leave += new System.EventHandler(this.txtExchangeRate_Leave);
            // 
            // radInuse
            // 
            this.radInuse.AutoSize = true;
            this.radInuse.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.radInuse.ForeColor = System.Drawing.Color.White;
            this.radInuse.Location = new System.Drawing.Point(207, 148);
            this.radInuse.Name = "radInuse";
            this.radInuse.Size = new System.Drawing.Size(72, 24);
            this.radInuse.TabIndex = 6;
            this.radInuse.TabStop = true;
            this.radInuse.Text = "In Use";
            this.radInuse.UseVisualStyleBackColor = true;
            // 
            // radNotuse
            // 
            this.radNotuse.AutoSize = true;
            this.radNotuse.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.radNotuse.ForeColor = System.Drawing.Color.White;
            this.radNotuse.Location = new System.Drawing.Point(280, 149);
            this.radNotuse.Name = "radNotuse";
            this.radNotuse.Size = new System.Drawing.Size(84, 24);
            this.radNotuse.TabIndex = 6;
            this.radNotuse.TabStop = true;
            this.radNotuse.Text = "Not Use";
            this.radNotuse.UseVisualStyleBackColor = true;
            // 
            // chkSetDefault
            // 
            this.chkSetDefault.AutoSize = true;
            this.chkSetDefault.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.chkSetDefault.ForeColor = System.Drawing.Color.White;
            this.chkSetDefault.Location = new System.Drawing.Point(207, 235);
            this.chkSetDefault.Name = "chkSetDefault";
            this.chkSetDefault.Size = new System.Drawing.Size(51, 24);
            this.chkSetDefault.TabIndex = 7;
            this.chkSetDefault.Text = "Yes";
            this.chkSetDefault.UseVisualStyleBackColor = true;
            this.chkSetDefault.CheckedChanged += new System.EventHandler(this.chkSetDefault_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Set Default Currency";
            // 
            // ufrmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(589, 495);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkSetDefault);
            this.Controls.Add(this.radNotuse);
            this.Controls.Add(this.radInuse);
            this.Controls.Add(this.txtExchangeRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCurSymbol);
            this.Controls.Add(this.txtCurrName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ufrmCurrency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Currency";
            this.Load += new System.EventHandler(this.ufrmCurrency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtCurrName;
        public System.Windows.Forms.TextBox txtCurSymbol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtExchangeRate;
        public System.Windows.Forms.RadioButton radInuse;
        public System.Windows.Forms.RadioButton radNotuse;
        private System.Windows.Forms.CheckBox chkSetDefault;
        private System.Windows.Forms.Label label6;
    }
}
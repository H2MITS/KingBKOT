namespace KingBKOT.Forms
{
    partial class Unhold
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
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnDelivery = new System.Windows.Forms.RadioButton();
            this.rbtnTakeAway = new System.Windows.Forms.RadioButton();
            this.rbtnDineIn = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.lblFilterOrder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 411);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::KingBKOT.Properties.Resources.error;
            this.btnClose.Location = new System.Drawing.Point(870, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 43;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(891, 248);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtnDelivery);
            this.panel3.Controls.Add(this.rbtnTakeAway);
            this.panel3.Controls.Add(this.rbtnDineIn);
            this.panel3.Controls.Add(this.rbtnAll);
            this.panel3.Controls.Add(this.lblFilterOrder);
            this.panel3.Location = new System.Drawing.Point(13, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 69);
            this.panel3.TabIndex = 41;
            // 
            // rbtnDelivery
            // 
            this.rbtnDelivery.AutoSize = true;
            this.rbtnDelivery.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbtnDelivery.ForeColor = System.Drawing.Color.White;
            this.rbtnDelivery.Location = new System.Drawing.Point(402, 24);
            this.rbtnDelivery.Name = "rbtnDelivery";
            this.rbtnDelivery.Size = new System.Drawing.Size(89, 25);
            this.rbtnDelivery.TabIndex = 4;
            this.rbtnDelivery.TabStop = true;
            this.rbtnDelivery.Text = "Delivery";
            this.rbtnDelivery.UseVisualStyleBackColor = true;
            // 
            // rbtnTakeAway
            // 
            this.rbtnTakeAway.AutoSize = true;
            this.rbtnTakeAway.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbtnTakeAway.ForeColor = System.Drawing.Color.White;
            this.rbtnTakeAway.Location = new System.Drawing.Point(281, 22);
            this.rbtnTakeAway.Name = "rbtnTakeAway";
            this.rbtnTakeAway.Size = new System.Drawing.Size(115, 25);
            this.rbtnTakeAway.TabIndex = 3;
            this.rbtnTakeAway.TabStop = true;
            this.rbtnTakeAway.Text = "Take Away";
            this.rbtnTakeAway.UseVisualStyleBackColor = true;
            // 
            // rbtnDineIn
            // 
            this.rbtnDineIn.AutoSize = true;
            this.rbtnDineIn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbtnDineIn.ForeColor = System.Drawing.Color.White;
            this.rbtnDineIn.Location = new System.Drawing.Point(193, 24);
            this.rbtnDineIn.Name = "rbtnDineIn";
            this.rbtnDineIn.Size = new System.Drawing.Size(82, 25);
            this.rbtnDineIn.TabIndex = 2;
            this.rbtnDineIn.TabStop = true;
            this.rbtnDineIn.Text = "Dine In";
            this.rbtnDineIn.UseVisualStyleBackColor = true;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbtnAll.ForeColor = System.Drawing.Color.White;
            this.rbtnAll.Location = new System.Drawing.Point(120, 24);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(51, 25);
            this.rbtnAll.TabIndex = 1;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All ";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // lblFilterOrder
            // 
            this.lblFilterOrder.AutoSize = true;
            this.lblFilterOrder.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterOrder.ForeColor = System.Drawing.Color.White;
            this.lblFilterOrder.Location = new System.Drawing.Point(3, 22);
            this.lblFilterOrder.Name = "lblFilterOrder";
            this.lblFilterOrder.Size = new System.Drawing.Size(116, 23);
            this.lblFilterOrder.TabIndex = 46;
            this.lblFilterOrder.Text = "Filter Order:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(19, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 3);
            this.panel2.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 34);
            this.label3.TabIndex = 39;
            this.label3.Text = "Un-Hold Bill";
            // 
            // Unhold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(922, 414);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Unhold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unhold";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtnDelivery;
        private System.Windows.Forms.RadioButton rbtnTakeAway;
        private System.Windows.Forms.RadioButton rbtnDineIn;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.Label lblFilterOrder;
        private System.Windows.Forms.PictureBox btnClose;
    }
}
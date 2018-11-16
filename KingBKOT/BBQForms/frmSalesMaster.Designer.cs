namespace KingBKOT.Forms
{
    partial class frmSalesMaster
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnSalesReturn = new System.Windows.Forms.Button();
            this.btnUnhold = new System.Windows.Forms.Button();
            this.btnKOT = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.btnDineInn = new System.Windows.Forms.Button();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFastCash = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnHold);
            this.panel1.Controls.Add(this.btnSalesReturn);
            this.panel1.Controls.Add(this.btnUnhold);
            this.panel1.Controls.Add(this.btnKOT);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnTakeAway);
            this.panel1.Controls.Add(this.btnDineInn);
            this.panel1.Controls.Add(this.btnKeyboard);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 69);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::KingBKOT.Properties.Resources.error;
            this.btnClose.Location = new System.Drawing.Point(1298, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 63);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "\r\nClose";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button5_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.button5_MouseHover);
            // 
            // btnHold
            // 
            this.btnHold.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHold.FlatAppearance.BorderSize = 0;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnHold.ForeColor = System.Drawing.Color.White;
            this.btnHold.Image = global::KingBKOT.Properties.Resources.hold__2_;
            this.btnHold.Location = new System.Drawing.Point(1163, 3);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(63, 63);
            this.btnHold.TabIndex = 8;
            this.btnHold.Text = "\r\nHold";
            this.btnHold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHold.UseVisualStyleBackColor = false;
            this.btnHold.Click += new System.EventHandler(this.button6_Click);
            this.btnHold.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
            this.btnHold.MouseHover += new System.EventHandler(this.button6_MouseHover);
            // 
            // btnSalesReturn
            // 
            this.btnSalesReturn.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalesReturn.FlatAppearance.BorderSize = 0;
            this.btnSalesReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSalesReturn.ForeColor = System.Drawing.Color.White;
            this.btnSalesReturn.Image = global::KingBKOT.Properties.Resources.cart;
            this.btnSalesReturn.Location = new System.Drawing.Point(938, 3);
            this.btnSalesReturn.Name = "btnSalesReturn";
            this.btnSalesReturn.Size = new System.Drawing.Size(94, 63);
            this.btnSalesReturn.TabIndex = 5;
            this.btnSalesReturn.Text = "\r\nSales Return";
            this.btnSalesReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalesReturn.UseVisualStyleBackColor = false;
            this.btnSalesReturn.Click += new System.EventHandler(this.button7_Click);
            this.btnSalesReturn.MouseLeave += new System.EventHandler(this.button7_MouseLeave);
            this.btnSalesReturn.MouseHover += new System.EventHandler(this.button7_MouseHover);
            // 
            // btnUnhold
            // 
            this.btnUnhold.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUnhold.FlatAppearance.BorderSize = 0;
            this.btnUnhold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnhold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUnhold.ForeColor = System.Drawing.Color.White;
            this.btnUnhold.Image = global::KingBKOT.Properties.Resources.to_do_list__1_;
            this.btnUnhold.Location = new System.Drawing.Point(1234, 3);
            this.btnUnhold.Name = "btnUnhold";
            this.btnUnhold.Size = new System.Drawing.Size(63, 63);
            this.btnUnhold.TabIndex = 9;
            this.btnUnhold.Text = "\r\nUn-Hold";
            this.btnUnhold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUnhold.UseVisualStyleBackColor = false;
            this.btnUnhold.Click += new System.EventHandler(this.button8_Click);
            this.btnUnhold.MouseLeave += new System.EventHandler(this.button8_MouseLeave);
            this.btnUnhold.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // btnKOT
            // 
            this.btnKOT.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnKOT.FlatAppearance.BorderSize = 0;
            this.btnKOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnKOT.ForeColor = System.Drawing.Color.White;
            this.btnKOT.Image = global::KingBKOT.Properties.Resources.dinner;
            this.btnKOT.Location = new System.Drawing.Point(1093, 3);
            this.btnKOT.Name = "btnKOT";
            this.btnKOT.Size = new System.Drawing.Size(63, 63);
            this.btnKOT.TabIndex = 7;
            this.btnKOT.Text = "\r\nKOT";
            this.btnKOT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKOT.UseVisualStyleBackColor = false;
            this.btnKOT.Click += new System.EventHandler(this.button9_Click);
            this.btnKOT.MouseLeave += new System.EventHandler(this.button9_MouseLeave);
            this.btnKOT.MouseHover += new System.EventHandler(this.button9_MouseHover);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = global::KingBKOT.Properties.Resources.store_new_badges;
            this.btnNew.Location = new System.Drawing.Point(1025, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(63, 63);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "\r\nNew";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            this.btnNew.MouseHover += new System.EventHandler(this.button10_MouseHover);
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTakeAway.FlatAppearance.BorderSize = 0;
            this.btnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTakeAway.ForeColor = System.Drawing.Color.White;
            this.btnTakeAway.Image = global::KingBKOT.Properties.Resources.smartphone;
            this.btnTakeAway.Location = new System.Drawing.Point(219, 3);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(76, 63);
            this.btnTakeAway.TabIndex = 4;
            this.btnTakeAway.Text = "\r\nTake Away";
            this.btnTakeAway.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTakeAway.UseVisualStyleBackColor = false;
            this.btnTakeAway.Click += new System.EventHandler(this.button3_Click);
            this.btnTakeAway.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.btnTakeAway.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // btnDineInn
            // 
            this.btnDineInn.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDineInn.FlatAppearance.BorderSize = 0;
            this.btnDineInn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDineInn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDineInn.ForeColor = System.Drawing.Color.White;
            this.btnDineInn.Image = global::KingBKOT.Properties.Resources.dining_room_cutlery_set_of_three_pieces_in_silhouettes__1_;
            this.btnDineInn.Location = new System.Drawing.Point(150, 4);
            this.btnDineInn.Name = "btnDineInn";
            this.btnDineInn.Size = new System.Drawing.Size(63, 63);
            this.btnDineInn.TabIndex = 3;
            this.btnDineInn.Text = "\r\nDine Inn";
            this.btnDineInn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDineInn.UseVisualStyleBackColor = false;
            this.btnDineInn.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.btnDineInn.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnKeyboard.FlatAppearance.BorderSize = 0;
            this.btnKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnKeyboard.ForeColor = System.Drawing.Color.White;
            this.btnKeyboard.Image = global::KingBKOT.Properties.Resources.keyboard__1_;
            this.btnKeyboard.Location = new System.Drawing.Point(72, 3);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(72, 63);
            this.btnKeyboard.TabIndex = 2;
            this.btnKeyboard.Text = "\r\nKeyboard";
            this.btnKeyboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKeyboard.UseVisualStyleBackColor = false;
            this.btnKeyboard.Click += new System.EventHandler(this.button2_Click);
            this.btnKeyboard.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.btnKeyboard.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(241, 623);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.textBox1.Location = new System.Drawing.Point(8, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 42);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(260, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(738, 671);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1011, 86);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(344, 572);
            this.dataGridView3.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.ForeColor = System.Drawing.Color.Orange;
            this.lblTotal.Location = new System.Drawing.Point(1005, 661);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 33);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // btnFastCash
            // 
            this.btnFastCash.BackColor = System.Drawing.Color.Orange;
            this.btnFastCash.FlatAppearance.BorderSize = 0;
            this.btnFastCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastCash.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnFastCash.ForeColor = System.Drawing.Color.White;
            this.btnFastCash.Image = global::KingBKOT.Properties.Resources.money__1_;
            this.btnFastCash.Location = new System.Drawing.Point(1011, 707);
            this.btnFastCash.Name = "btnFastCash";
            this.btnFastCash.Size = new System.Drawing.Size(153, 50);
            this.btnFastCash.TabIndex = 12;
            this.btnFastCash.Text = " Fast Cash";
            this.btnFastCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFastCash.UseVisualStyleBackColor = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCheckout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = global::KingBKOT.Properties.Resources.cart1;
            this.btnCheckout.Location = new System.Drawing.Point(1202, 707);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(153, 50);
            this.btnCheckout.TabIndex = 13;
            this.btnCheckout.Text = " Checkout";
            this.btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::KingBKOT.Properties.Resources.minimize_tab;
            this.btnMinimize.Location = new System.Drawing.Point(0, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(74, 63);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "\r\nMinimize";
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.button1_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // frmSalesMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 757);
            this.Controls.Add(this.btnFastCash);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalesMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalesMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSalesMaster_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnSalesReturn;
        private System.Windows.Forms.Button btnUnhold;
        private System.Windows.Forms.Button btnKOT;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnTakeAway;
        private System.Windows.Forms.Button btnDineInn;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFastCash;
        private System.Windows.Forms.Button btnCheckout;
    }
}
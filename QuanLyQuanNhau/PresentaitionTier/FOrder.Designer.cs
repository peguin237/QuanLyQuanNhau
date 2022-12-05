namespace QuanLyQuanNhau
{
    partial class FOrder
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDanhMuc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nupSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.nupGiamGia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDoiBan = new System.Windows.Forms.Button();
            this.cbxDoiBan = new System.Windows.Forms.ComboBox();
            this.pnlBan = new System.Windows.Forms.Panel();
            this.cbxMon = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 565);
            this.panel1.TabIndex = 0;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvOrder.Location = new System.Drawing.Point(773, 101);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(550, 304);
            this.dgvOrder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(783, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh Mục :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(802, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Món :";
            // 
            // cbxDanhMuc
            // 
            this.cbxDanhMuc.FormattingEnabled = true;
            this.cbxDanhMuc.Location = new System.Drawing.Point(875, 22);
            this.cbxDanhMuc.Name = "cbxDanhMuc";
            this.cbxDanhMuc.Size = new System.Drawing.Size(121, 24);
            this.cbxDanhMuc.TabIndex = 3;
            this.cbxDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbxDanhMuc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1012, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Lượng :";
            // 
            // nupSoLuong
            // 
            this.nupSoLuong.Location = new System.Drawing.Point(1100, 22);
            this.nupSoLuong.Name = "nupSoLuong";
            this.nupSoLuong.Size = new System.Drawing.Size(120, 22);
            this.nupSoLuong.TabIndex = 5;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(1226, 22);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(97, 73);
            this.btnThemMon.TabIndex = 6;
            this.btnThemMon.Text = "Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(1072, 411);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(164, 22);
            this.txtThanhTien.TabIndex = 7;
            // 
            // nupGiamGia
            // 
            this.nupGiamGia.Location = new System.Drawing.Point(1072, 454);
            this.nupGiamGia.Name = "nupGiamGia";
            this.nupGiamGia.Size = new System.Drawing.Size(120, 22);
            this.nupGiamGia.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(991, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thành tiền :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(991, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giảm Giá :";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(1161, 509);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 68);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDoiBan
            // 
            this.btnDoiBan.Location = new System.Drawing.Point(773, 487);
            this.btnDoiBan.Name = "btnDoiBan";
            this.btnDoiBan.Size = new System.Drawing.Size(75, 68);
            this.btnDoiBan.TabIndex = 6;
            this.btnDoiBan.Text = "Đổi Bàn";
            this.btnDoiBan.UseVisualStyleBackColor = true;
            this.btnDoiBan.Click += new System.EventHandler(this.btnDoiBan_Click);
            // 
            // cbxDoiBan
            // 
            this.cbxDoiBan.FormattingEnabled = true;
            this.cbxDoiBan.Location = new System.Drawing.Point(854, 474);
            this.cbxDoiBan.Name = "cbxDoiBan";
            this.cbxDoiBan.Size = new System.Drawing.Size(121, 24);
            this.cbxDoiBan.TabIndex = 4;
            // 
            // pnlBan
            // 
            this.pnlBan.Location = new System.Drawing.Point(12, 12);
            this.pnlBan.Name = "pnlBan";
            this.pnlBan.Size = new System.Drawing.Size(755, 565);
            this.pnlBan.TabIndex = 0;
            // 
            // cbxMon
            // 
            this.cbxMon.FormattingEnabled = true;
            this.cbxMon.Location = new System.Drawing.Point(875, 70);
            this.cbxMon.Name = "cbxMon";
            this.cbxMon.Size = new System.Drawing.Size(121, 24);
            this.cbxMon.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Món";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số Lượng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thành Tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 589);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.btnDoiBan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.nupGiamGia);
            this.Controls.Add(this.nupSoLuong);
            this.Controls.Add(this.cbxDoiBan);
            this.Controls.Add(this.cbxMon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxDanhMuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.pnlBan);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDanhMuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupSoLuong;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.NumericUpDown nupGiamGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDoiBan;
        private System.Windows.Forms.ComboBox cbxDoiBan;
        private System.Windows.Forms.Panel pnlBan;
        private System.Windows.Forms.ComboBox cbxMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}


namespace QuanLyQuanNhau.PresentaitionTier
{
    partial class FTong
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(588, 24);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(179, 191);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Location = new System.Drawing.Point(42, 234);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(176, 204);
            this.btnQLNV.TabIndex = 0;
            this.btnQLNV.Text = "Quản Lý Nhân Viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(69, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 182);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(172, 20);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 22);
            this.txtTen.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(172, 69);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            this.txtMaNV.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuátToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // đăngXuátToolStripMenuItem
            // 
            this.đăngXuátToolStripMenuItem.Name = "đăngXuátToolStripMenuItem";
            this.đăngXuátToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuátToolStripMenuItem.Text = "Đăng Xuát";
            this.đăngXuátToolStripMenuItem.Click += new System.EventHandler(this.đăngXuátToolStripMenuItem_Click);
            // 
            // FTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FTong";
            this.Text = "FTong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FTong_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FTong_FormClosed);
            this.Load += new System.EventHandler(this.FTong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuátToolStripMenuItem;
    }
}
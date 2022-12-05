using QuanLyQuanNhau.BusinessTier;
using QuanLyQuanNhau.DataTier.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNhau.PresentaitionTier
{
    public partial class FLogin : Form
    {
        private NhanVienBUS nhanVienBUS;
        public FLogin()
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();
        }
        private void Reset()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NhanVienViewModel nv;
            if (nhanVienBUS.KiemTraNhanVien(txtTaiKhoan.Text, txtMatKhau.Text, out nv))
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                FTong f = new FTong(nv);
                f.Show();
                this.Hide();
                this.Reset();
                f.DangXuat += F_DangXuat;
            }
        }
        private void F_DangXuat(object sender, EventArgs e)
        {
            (sender as FTong).isThoat = false;
            (sender as FTong).Close();
            this.Show();
        }
    }
}

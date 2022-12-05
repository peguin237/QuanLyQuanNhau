using QuanLyQuanNhau.BusinessTier;
using QuanLyQuanNhau.DataTier.Model;
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
    public partial class FQLNhanVien : Form
    {
        private readonly NhanVienBUS nhanVienBUS;
        private int maNhanVien = -1;
        public FQLNhanVien()
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();
        }
        private void LoadNhanVien()
        {
            dgvNhanVien.DataSource = nhanVienBUS.GetNhanViens();
        }

        private void FQLNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string thongBao = "";
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                thongBao += "\nPhải nhập họ tên";
            }
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                thongBao += "\nPhải nhập tài khoản";
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                thongBao += "\nPhải nhập mật khẩu";
            }
            if (string.IsNullOrWhiteSpace(cbxGioiTinh.Text))
            {
                thongBao += "\nPhải chọn giới tính";
            }
            if (string.IsNullOrWhiteSpace(cbxQuyen.Text))
            {
                thongBao += "\nPhải chọn quyền hạn";
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                thongBao += "\nPhải nhập SĐT";
            }
            if (thongBao != "")
            {
                MessageBox.Show(thongBao);
                return;
            }
            NhanVien nv = new NhanVien();
            nv.Ten = txtTen.Text;
            nv.TenDangNhap = txtTaiKhoan.Text;
            nv.GioiTinh = cbxGioiTinh.Text;
            nv.Quyen = cbxQuyen.Text;
            nv.SDT = Convert.ToInt32(txtSDT.Text);
            nv.MatKhau = txtMatKhau.Text;
            try
            {
                nhanVienBUS.ThemNhanVien(nv);
                LoadNhanVien();
                txtTen.Text = txtTaiKhoan.Text = txtMatKhau.Text = cbxGioiTinh.Text = cbxQuyen.Text = txtSDT.Text = txtMatKhau.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Ten = txtTen.Text;
            nv.TenDangNhap = txtTaiKhoan.Text;
            nv.GioiTinh = cbxGioiTinh.Text;
            nv.Quyen = cbxQuyen.Text;
            nv.SDT = Convert.ToInt32(txtSDT.Text);
            nv.MatKhau = txtMatKhau.Text;
            nv.MaNV = maNhanVien;
            try
            {
                nhanVienBUS.CapNhatNhanVien(nv);
                LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = maNhanVien;
            try
            {
                nhanVienBUS.XoaNhanVien(maNhanVien);
                LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongChon = e.RowIndex;
            maNhanVien = Convert.ToInt32(dgvNhanVien.Rows[dongChon].Cells[0].Value.ToString());
            txtTen.Text = dgvNhanVien.Rows[dongChon].Cells[1].Value.ToString();
            txtTaiKhoan.Text = dgvNhanVien.Rows[dongChon].Cells[5].Value.ToString();
            txtMatKhau.Text = dgvNhanVien.Rows[dongChon].Cells[4].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[dongChon].Cells[3].Value.ToString();
            cbxGioiTinh.Text = dgvNhanVien.Rows[dongChon].Cells[2].Value.ToString();
            cbxQuyen.Text = dgvNhanVien.Rows[dongChon].Cells[6].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            maNhanVien = -1;
            txtTaiKhoan.Text = txtTen.Text = txtMatKhau.Text = txtSDT.Text = cbxQuyen.Text = cbxGioiTinh.Text = "";
            LoadNhanVien();
        }
    }
}

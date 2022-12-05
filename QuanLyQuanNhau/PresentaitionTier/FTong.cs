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
    public partial class FTong : Form
    {
        private NhanVienViewModel nhanVienBanHang;
        public bool isThoat = true;
        public FTong(NhanVienViewModel nv)
        {
            InitializeComponent();
            nhanVienBanHang = nv;
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            FQLNhanVien f = new FQLNhanVien();
            f.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FOrder f = new FOrder();
            f.ShowDialog();
        }

        private void FTong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void FTong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void đăngXuátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }
        public event EventHandler DangXuat;

        private void FTong_Load(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            txtTen.ReadOnly = true;
            //txtMaNV.Text = Convert.ToInt32(nhanVienBanHang.Ma);
            txtTen.Text = nhanVienBanHang.Ten;
        }
    }
}

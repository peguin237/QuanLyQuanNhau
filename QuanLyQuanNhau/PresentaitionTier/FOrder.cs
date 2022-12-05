using QuanLyQuanNhau.BusinessTier;
using QuanLyQuanNhau.DataTier.Model;
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

namespace QuanLyQuanNhau
{
    public partial class FOrder : Form
    {
        private const int W = 80;
        private const int H = 80;
        private const int DISTANCE = 120;
        private const int COL = 5;
        private double tongTien = 0;
        private Button banChon = null;
        private List<ThongTinDatBan> Danhsach = new List<ThongTinDatBan>();

        private BanBUS banBUS;
        private DanhMucBUS danhMucBUS;
        private MonBUS monBUS;
        private HoaDonBUS hoaDonBUS;

        System.Globalization.CultureInfo fVND = new System.Globalization.CultureInfo("vi-VN");
        public FOrder()
        {
            InitializeComponent();
            nupGiamGia.TextChanged += NupGiamGia_TextChanged;
            banBUS = new BanBUS();
            danhMucBUS = new DanhMucBUS();
            monBUS = new MonBUS();
            hoaDonBUS = new HoaDonBUS();
            CaiDatDieuKhien();
        }
        private void NupGiamGia_TextChanged(object sender, EventArgs e)
        {
            double soTienGiam = (double)(nupGiamGia.Value / 100) * tongTien;
            txtThanhTien.Text = String.Format(fVND, "{0:C0}", (tongTien - soTienGiam));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoSoLuongBan();
            LoadDanhMuc();
            LoadDanhSachBan();
            WindowState = FormWindowState.Maximized;
        }
        private void LoadDanhSachBan()
        {
            cbxDoiBan.DataSource = banBUS.GetBans();
        }
        private void LoadDanhMuc()
        {
            cbxDanhMuc.DataSource = danhMucBUS.GetDanhMucs();
        }

        private void cbxDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            int maDanhMuc = int.Parse(cbx.SelectedValue.ToString());
            cbxMon.DataSource = monBUS.GetMonTheoDanhMuc(maDanhMuc);
        }
        private void CaiDatDieuKhien()
        {
            cbxDanhMuc.DisplayMember = "Ten";
            cbxDanhMuc.ValueMember = "MaDanhMuc";

            cbxMon.DisplayMember = "Ten";
            cbxMon.ValueMember = "MaMon";

            cbxDoiBan.DisplayMember = "TenBan";
            cbxDoiBan.ValueMember = "MaBan";
        }
        private void KhoiTaoSoLuongBan()
        {
            int x = 27, y = 29, i = 0;
            foreach (Ban ban in banBUS.GetBans())
            {
                TaoBan(x, y, ban);
                i++;
                if (i % COL == 0)
                {
                    y += DISTANCE;
                    x = 27;
                    continue;
                }
                x += DISTANCE;
            }
        }
        private void TaoBan(int x, int y, Ban ban)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Text = ban.TenBan;
            btn.Tag = ban.MaBan;
            btn.Size = new Size(W, H);
            btn.BackColor = Color.White;
            btn.Click += Btn_Click;
            pnlBan.Controls.Add(btn);
        }
        public void HienThiDanhSachMon(List<MonDat> danhSach)
        {
            dgvOrder.Rows.Clear();
            foreach (MonDat mon in danhSach)
            {
                int rows = dgvOrder.Rows.Add(mon);
                dgvOrder.Rows[rows].Cells[0].Value = mon.TenMon;
                dgvOrder.Rows[rows].Cells[1].Value = mon.SoLuong;
                dgvOrder.Rows[rows].Cells[2].Value = mon.DonGia;
                dgvOrder.Rows[rows].Cells[3].Value = mon.ThanhTien;
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (banChon == null)
            {
                banChon = btn;
                banChon.BackColor = Color.Blue;
            }
            else if (banChon == btn)
            {

                banChon.BackColor = Color.White;
                banChon = null;
                dgvOrder.Rows.Clear();
                tongTien = 0;
                txtThanhTien.Clear();
                return;
            }
            else
            {
                banChon.BackColor = Color.White;
                banChon = btn;
                banChon.BackColor = Color.Blue;
            }
            int maSoBanChon = int.Parse(banChon.Tag.ToString());
            //Kiem tra xem BAN CO TRONG DS HAY CHUA 
            ThongTinDatBan thongTin = Danhsach.Where(x => x.MaBan == maSoBanChon).FirstOrDefault();
            if (thongTin != null)
            {
                HienThiDanhSachMon(thongTin.DanhSachMon);
                tongTien = thongTin.DanhSachMon.Sum(x => x.ThanhTien);
                txtThanhTien.Text = String.Format(fVND, "{0:C0}", (tongTien));
            }
            else
            {
                dgvOrder.Rows.Clear();
                tongTien = 0;
                txtThanhTien.Clear();
            }
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (banChon == null)
            {
                MessageBox.Show("Vui long chon ban");
                return;
            }
            if (nupSoLuong.Value <= 0)
            {
                MessageBox.Show("Vui long chon so luong");
                return;
            }
            int MaSoBan = int.Parse(banChon.Tag.ToString());
            ThongTinDatBan thongTin = Danhsach.Where(x => x.MaBan == MaSoBan).FirstOrDefault();
            if (thongTin == null)
            {
                thongTin = new ThongTinDatBan();
                thongTin.MaBan = MaSoBan;
                //banChon.BackColor = Color.Green;
                Danhsach.Add(thongTin);
            }
            MonDat mon = new MonDat();
            Mon m = (Mon)cbxMon.SelectedItem;
            mon.SoLuong = int.Parse(nupSoLuong.Value.ToString());
            mon.TenMon = cbxMon.Text;
            mon.DonGia = (double)m.GiaTien;
            mon.MaMon = m.MaMon;
            thongTin.CapNhatMon(mon);
            HienThiDanhSachMon(thongTin.DanhSachMon);
            tongTien = thongTin.DanhSachMon.Sum(x => x.ThanhTien);
            txtThanhTien.Text = String.Format(fVND, "{0:C0}", (tongTien));
        }

        private void btnDoiBan_Click(object sender, EventArgs e)
        {
            int maSoBanChuyen, maSoBanDich;
            Button bandich = null;
            if (banChon == null)
            {
                MessageBox.Show("Chon ban can chuyen!!");
                return;
            }
            maSoBanChuyen = int.Parse(banChon.Tag.ToString());
            ThongTinDatBan thongTinDatBanChuyen = Danhsach.Where(x => x.MaBan == maSoBanChuyen).FirstOrDefault();
            if (thongTinDatBanChuyen == null)
            {
                MessageBox.Show("Khong the chuyen ban trong!!");
                return;
            }
            maSoBanDich = int.Parse(cbxDoiBan.SelectedValue.ToString());
            if (maSoBanChuyen == maSoBanDich)
            {
                MessageBox.Show("Ban chuyen va  dich phai khac nhau!!");
                return;
            }
            bandich = pnlBan.Controls.OfType<Button>().Where(x => x.Tag.ToString() == maSoBanDich.ToString()).FirstOrDefault();
            // bandich.Image = Image.FromFile("../../Resources/ly-cafe.png");
            ThongTinDatBan thongTinDatBanDich = Danhsach.Where(x => x.MaBan == maSoBanDich).FirstOrDefault();
            if (thongTinDatBanDich == null)
            {
                thongTinDatBanChuyen.MaBan = maSoBanDich;
                // pnlBan.Controls.OfType<Button>().Where(x => x.Tag.ToString() == maSoBanDich.ToString()).FirstOrDefault().Image = Image.FromFile("../../Resources/ly-cafe.png");
            }
            else
            {
                foreach (MonDat item in thongTinDatBanChuyen.DanhSachMon)
                {
                    thongTinDatBanDich.CapNhatMon(item);
                }
                HienThiDanhSachMon(thongTinDatBanDich.DanhSachMon);
                tongTien = thongTinDatBanDich.DanhSachMon.Sum(x => x.ThanhTien);
                txtThanhTien.Text = String.Format(fVND, "(0:C0)", tongTien);
                Danhsach.Remove(thongTinDatBanChuyen);
            }
            banChon.Image = null;
            banChon.BackColor = Color.White;
            banChon = bandich;
            banChon.BackColor = Color.Blue;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (banChon == null)
            {
                MessageBox.Show("vui long chon ban");
                return;
            }
            int maSoBanChon = Convert.ToInt32(banChon.Tag);
            ThongTinDatBan thongTinDatBan = Danhsach.Where(x => x.MaBan == maSoBanChon).FirstOrDefault();
            if (thongTinDatBan == null)
            {
                MessageBox.Show("BÀN  CHƯA ĐƯỢC ĐẶT MÓN NÀO");
                return;
            }
            HoaDon hoaDon = new HoaDon();
            hoaDon.TongTien = tongTien;
            hoaDon.MaBan = int.Parse(banChon.Tag.ToString());
            hoaDon.GiamGia = (double)nupGiamGia.Value;
            hoaDon.Ngay = DateTime.Now;
            //continue
            ChiTietHD chiTiet;
            foreach (var item in thongTinDatBan.DanhSachMon)
            {
                chiTiet = new ChiTietHD();
                chiTiet.SoLuong = item.SoLuong;
                txtThanhTien.Clear();
                chiTiet.MaMon = item.MaMon;
                hoaDon.ChiTietHDs.Add(chiTiet);
            }
            //try
            //{
                hoaDonBUS.LuuHoaDon(hoaDon);
                banChon.Image = null;
                dgvOrder.Rows.Clear();
                txtThanhTien.Text = "";
                nupGiamGia.ResetText();
                Danhsach.Remove(thongTinDatBan);
                MessageBox.Show("LƯU HÓA ĐƠN THÀNH CÔNG");
            //}
            //catch (Exception ex)
            //{
                //MessageBox.Show(ex.Message);
            //}
        }
    }
}

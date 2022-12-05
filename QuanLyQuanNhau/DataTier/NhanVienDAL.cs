using QuanLyQuanNhau.DataTier.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanNhau.DataTier.ViewModel;
using System.Windows.Forms;

namespace QuanLyQuanNhau.DataTier
{
    internal class NhanVienDAL
    {
        private QuanLyQuanNhauModel quanlyquannhau;

        public NhanVienDAL()
        {
            quanlyquannhau = new QuanLyQuanNhauModel();
        }
        //lay tat ca nhan vien
        public IEnumerable<NhanVienViewModel> GetNhanViens()
        {
            var danhSachNhanVien = quanlyquannhau.NhanViens
                                   .Select(x => new NhanVienViewModel
                                   {
                                       Ma = x.MaNV,
                                       Ten = x.Ten,
                                       GioiTinh = x.GioiTinh,
                                       SDT = x.SDT,
                                       MatKhau = x.MatKhau,
                                       TenDangNhap = x.TenDangNhap,
                                       Quyen = x.Quyen
                                   }).ToList();

            return danhSachNhanVien;
        }
        public bool ThemNhanVien(NhanVien nv)
        {
            try
            {
                NhanVien nhanVien = quanlyquannhau.NhanViens.Where(x => x.TenDangNhap == nv.TenDangNhap).FirstOrDefault();
                if (nhanVien == null)
                {
                    quanlyquannhau.NhanViens.Add(nv);
                    quanlyquannhau.SaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception("Tên đăng nhập đã tồn tại");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CapNhatNhanVien(NhanVien nv)
        {
            try
            {
                NhanVien nhanVien = quanlyquannhau.NhanViens.Where(x => x.MaNV == nv.MaNV).FirstOrDefault();
                if (nhanVien == null)
                {
                    throw new Exception("Nhân viên không tồn tại");
                }
                else
                {
                    nhanVien.MaNV = nv.MaNV;
                    nhanVien.Ten = nv.Ten;
                    nhanVien.GioiTinh = nv.GioiTinh;
                    nhanVien.SDT = nv.SDT;
                    nhanVien.TenDangNhap = nv.TenDangNhap;
                    nhanVien.Quyen = nv.Quyen;
                    quanlyquannhau.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaNhanVien(int maNhanVien)
        {
            try
            {
                var nv = quanlyquannhau.NhanViens.Where(x => x.MaNV == maNhanVien).FirstOrDefault();
                if (nv != null)
                {
                    quanlyquannhau.NhanViens.Remove(nv);
                    quanlyquannhau.SaveChanges();
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool KiemTraDangNhap(string tenDangNhap, string matKhau, out NhanVienViewModel nv)
        {
            var nhanVien = quanlyquannhau.NhanViens
                .Where(x => x.TenDangNhap == tenDangNhap)
                .FirstOrDefault();

            nv = new NhanVienViewModel();

            if (nhanVien == null)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                nv.Ma = nhanVien.MaNV;
                nv.Ten = nhanVien.Ten;
                nv.GioiTinh = nhanVien.GioiTinh;
                nv.SDT = nhanVien.SDT;
                nv.TenDangNhap = nhanVien.TenDangNhap;
                nv.Quyen = nhanVien.Quyen;
                return true;
            }
        }
    }
}

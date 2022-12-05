using QuanLyQuanNhau.DataTier.Model;
using QuanLyQuanNhau.DataTier.ViewModel;
using QuanLyQuanNhau.DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNhau.BusinessTier
{
    internal class NhanVienBUS
    {
        private NhanVienDAL nhanVienDAL;

        public NhanVienBUS()
        {
            nhanVienDAL = new NhanVienDAL();
        }
        public IEnumerable<NhanVienViewModel> GetNhanViens()
        {
            return nhanVienDAL.GetNhanViens();
        }
        public bool ThemNhanVien(NhanVien nv)
        {
            try
            {
                return nhanVienDAL.ThemNhanVien(nv);
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
                return nhanVienDAL.CapNhatNhanVien(nv);
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
                return nhanVienDAL.XoaNhanVien(maNhanVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool KiemTraNhanVien(string tenDangNhap, string matKhau, out NhanVienViewModel nv)
        {
            return nhanVienDAL.KiemTraDangNhap(tenDangNhap, matKhau, out nv);
        }
    }
}

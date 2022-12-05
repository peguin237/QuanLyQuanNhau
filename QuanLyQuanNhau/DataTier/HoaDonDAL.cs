using QuanLyQuanNhau.DataTier.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNhau.DataTier
{
    internal class HoaDonDAL
    {
        private QuanLyQuanNhauModel quanlyquannhau;
        public HoaDonDAL()
        {
            quanlyquannhau = new QuanLyQuanNhauModel();
        }
        public bool LuuHoaDon(HoaDon hoaDon)
        {
            try
            {
                quanlyquannhau.HoaDons.Add(hoaDon);
                quanlyquannhau.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

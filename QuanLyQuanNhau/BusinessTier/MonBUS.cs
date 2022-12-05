using QuanLyQuanNhau.DataTier.Model;
using QuanLyQuanNhau.DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNhau.BusinessTier
{
    internal class MonBUS
    {
        private MonDAL monDAL;
        public MonBUS()
        {
            monDAL = new MonDAL();
        }
        public IEnumerable<Mon> GetMonTheoDanhMuc(int maDanhMuc)
        {
            return monDAL.GetMonTheoMaDanhMuc(maDanhMuc);
        }
    }
}

using QuanLyQuanNhau.DataTier.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNhau.DataTier
{
    internal class MonDAL
    {
        private QuanLyQuanNhauModel quanlyquannhau;
        public MonDAL()
        {
            quanlyquannhau = new QuanLyQuanNhauModel();
        }
        public IEnumerable<Mon> GetMonTheoMaDanhMuc(int maDanhMuc)
        {
            return quanlyquannhau.Mons.Where(x => x.MaDanhMuc == maDanhMuc).ToList();
        }
    }
}

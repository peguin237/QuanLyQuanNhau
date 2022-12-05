using QuanLyQuanNhau.DataTier.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNhau.DataTier
{
    internal class DanhMucDAL
    {
        private QuanLyQuanNhauModel quanlyquannhau;
        public DanhMucDAL()
        {
            quanlyquannhau = new QuanLyQuanNhauModel();
        }
        public IEnumerable<DanhMuc> GetDanhMucs()
        {
            return quanlyquannhau.DanhMucs.ToList();
        }
    }
}

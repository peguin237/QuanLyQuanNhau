using QuanLyQuanNhau.DataTier.Model;
using QuanLyQuanNhau.DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNhau.BusinessTier
{
    internal class DanhMucBUS
    {
        private DanhMucDAL danhMucDAL;
        public DanhMucBUS()
        {
            danhMucDAL = new DanhMucDAL();
        }
        public IEnumerable<DanhMuc> GetDanhMucs()
        {
            return danhMucDAL.GetDanhMucs();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanNhau.DataTier.Model;

namespace QuanLyQuanNhau.DataTier
{
    internal class BanDAL
    {
        private QuanLyQuanNhauModel quanlyquannhau;
        public BanDAL()
        {
            quanlyquannhau = new QuanLyQuanNhauModel();
        }
        public IEnumerable<Ban> GetBans()
        {
            return quanlyquannhau.Bans.ToList();
        }
    }
}

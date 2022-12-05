using QuanLyQuanNhau.DataTier.Model;
using QuanLyQuanNhau.DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNhau.BusinessTier
{
    internal class BanBUS
    {
        private BanDAL banDAL;
        public BanBUS()
        {
            banDAL = new BanDAL();
        }
        public IEnumerable<Ban> GetBans()
        {
            return banDAL.GetBans();
        }
    }
}

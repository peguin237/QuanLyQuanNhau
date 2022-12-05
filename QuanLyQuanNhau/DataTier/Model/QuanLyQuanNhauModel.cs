using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyQuanNhau.DataTier.Model
{
    public partial class QuanLyQuanNhauModel : DbContext
    {
        public QuanLyQuanNhauModel()
            : base("name=QuanLyQuanNhau")
        {
        }

        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<ChiTietHD> ChiTietHDs { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<Mon> Mons { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

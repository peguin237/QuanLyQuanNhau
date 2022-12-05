namespace QuanLyQuanNhau.DataTier.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHD")]
    public partial class ChiTietHD
    {
        [Key]
        
        public int MaChiTietHD { get; set; }

        public int? MaMon { get; set; }

        public int? SoLuong { get; set; }

        public int? MaHD { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual Mon Mon { get; set; }
    }
}

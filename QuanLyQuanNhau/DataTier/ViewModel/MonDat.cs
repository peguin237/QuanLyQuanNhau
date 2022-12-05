﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNhau.DataTier.ViewModel
{
    public class MonDat
    {
        public int MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get { return DonGia * SoLuong; } }
    }
}

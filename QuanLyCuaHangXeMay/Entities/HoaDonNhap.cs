using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangXeMay.Entities
{
    class HoaDonNhap
    {
        private string mahoadon, hoten, diachi, sdt, ngaynhap, manv;
        public HoaDonNhap(string mahoadon,string hoten,string  diachi,string sdt,string ngaynhap,string manv)
        {
            this.mahoadon = mahoadon;
            this.hoten = hoten;
            this.diachi = diachi;

            this.sdt = sdt;
            this.ngaynhap = ngaynhap;
            this.manv = manv;
        }
        override
            public string ToString()
        {
            return mahoadon + "#" + hoten + "#" + diachi + "#" + sdt + "#" + ngaynhap + "#" + manv;
        }
        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public string Manv { get => manv; set => manv = value; }
    }
}

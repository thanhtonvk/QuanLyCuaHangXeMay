using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangXeMay.Entities
{
    class HoaDonXuat
    {
        private string mahoadonxuat, tenxe, loaixe;
        private int soluong;
        private double giaban, tongtien;
        public HoaDonXuat(string mahoadonxuat,string tenxe,string loaixe,int soluong,double giaban,double tongtien)
        {
            this.mahoadonxuat = mahoadonxuat;
            this.tenxe = tenxe;
            this.loaixe = loaixe;
            this.soluong = soluong;
            this.giaban = giaban;
            this.tongtien = tongtien;
        }
        override
            public string ToString()
        {
            return mahoadonxuat + "#" + tenxe + "#" + loaixe + "#" + soluong + "#" + giaban + "#" + tongtien;
        }
        public string Mahoadonxuat { get => mahoadonxuat; set => mahoadonxuat = value; }
        public string Tenxe { get => tenxe; set => tenxe = value; }
        public string Loaixe { get => loaixe; set => loaixe = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Giaban { get => giaban; set => giaban = value; }
        public double Tongtien { get => tongtien; set => tongtien = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangXeMay.Entities
{
    class Xe
    {
        private string tenxe, loaixe, xuatxu;
        private int soluong;
        private double giaban;
        public Xe(string tenxe,string loaixe,string xuatxu,int soluong,double giaban)
        {
            this.tenxe = tenxe;
            this.loaixe = loaixe;
            this.xuatxu = xuatxu;
            this.soluong = soluong;
            this.giaban = giaban;
        }
        override
        public  string ToString()
        {
            return tenxe + "#" + loaixe + "#" + xuatxu + "#" + soluong + "#" + giaban;
        }
        public string Tenxe { get => tenxe; set => tenxe = value; }
        public string Loaixe { get => loaixe; set => loaixe = value; }
        public string Xuatxu { get => xuatxu; set => xuatxu = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Giaban { get => giaban; set => giaban = value; }
    }
}

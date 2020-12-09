using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangXeMay.Entities
{
    class KhachHang
    {
        private string makh, hoten, diachi, thoigianmua, sdt, cmnd;
        private int solanghetham,capdo;
        public KhachHang(string makh,string hoten,string diachi,string thoigianmua,string sdt,string cmnd,int solanghetham,int capdo)
        {
            this.makh = makh;
            this.hoten = hoten;
            this.diachi = diachi;
            this.thoigianmua = thoigianmua;
            this.sdt = sdt;
            this.cmnd = cmnd;
            this.solanghetham = solanghetham;
            this.capdo = capdo;
        }
        override
            public string ToString()
        {
            return makh + "#" + hoten + "#" + diachi + "#" + thoigianmua + "#" + sdt + "#" + cmnd + "#" + solanghetham + "#" + capdo;
        }
        public string Makh { get => makh; set => makh = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Thoigianmua { get => thoigianmua; set => thoigianmua = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public int Solanghetham { get => solanghetham; set => solanghetham = value; }
        public int Capdo { get => capdo; set => capdo = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangXeMay.Entities
{
    class NhanVien
    {
        private string manhanvien, hoten, cmnd, namsinh, gioitinh, sdt, chucvu;
        public NhanVien(string manv,string hoten,string cmnd,string namsinh,string gioitinh,string sdt,string chucvu)
        {
            this.manhanvien = manv;
            this.hoten = hoten;
            this.cmnd = cmnd;
            this.namsinh = namsinh;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.chucvu = chucvu;
        }
        override
            public string ToString()
        {
            return manhanvien + "#" + hoten + "#" + cmnd + "#" + namsinh + "#" + gioitinh + "#" + sdt + "#" + chucvu;
        }
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Namsinh { get => namsinh; set => namsinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
    }
}

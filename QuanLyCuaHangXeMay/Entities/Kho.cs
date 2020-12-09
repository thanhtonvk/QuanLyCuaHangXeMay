using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangXeMay.Entities
{
    class Kho
    {
        private string makho, vitri, tinhtrang, manv;
        public Kho(string makho,string vitri,string tinhtrang,string manv)
        {
            this.makho = makho;
            this.vitri = vitri;
            this.tinhtrang = tinhtrang;
            this.manv = manv;
        }
        override
            public string ToString()
        {
            return makho + "#" + vitri + "#" + tinhtrang + "#" + manv;
        }
        public string Makho { get => makho; set => makho = value; }
        public string Vitri { get => vitri; set => vitri = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public string Manv { get => manv; set => manv = value; }
    }
}

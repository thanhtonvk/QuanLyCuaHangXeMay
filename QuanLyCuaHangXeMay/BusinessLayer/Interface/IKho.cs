using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangXeMay.BusinessLayer.Interface
{
    interface IKho
    {
        void Them(ArrayList arrayList);
        void Hien(ArrayList arrayList);
        void Sua(ArrayList arrayList);
        void Xoa(ArrayList arrayList);
        void Timkiem(ArrayList arrayList);
    }
}

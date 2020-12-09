using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangXeMay.Entities;
using QuanLyCuaHangXeMay.BusinessLayer.Interface;
namespace QuanLyCuaHangXeMay.BusinessLayer
{
    class HoaDonNhap_BLL : IHoaDonNhap
    {
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã hóa đơn","Họ tên NCC","Địa chỉ","SĐT","Ngày nhập","Mã nhân viên");
            foreach(HoaDonNhap hoaDon in arrayList)
            {
                Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", hoaDon.Mahoadon, hoaDon.Hoten, hoaDon.Diachi, hoaDon.Sdt, hoaDon.Manv);
            }
        }

        public void Them(ArrayList arrayList)
        {
            //(string mahoadon, string hoten, string diachi, string sdt, string ngaynhap, string manv)
           
            string mahoadon = (arrayList.Count + 1000).ToString();
            Console.Write("                                Nhập họ tên nhà cung cấp: ");
            string hoten = Console.ReadLine();
            Console.Write("                                NHập địa chỉ: ");
            string diachi = Console.ReadLine();
            Console.Write("                                Nhập sdt: ");
            string sdt = Console.ReadLine();
            Console.Write("                                Nhập ngày nhập: ");
            string ngaynhap = Console.ReadLine();
            Console.Write("                                Nhập mã nhân viên nhập: ");
            string manv = Console.ReadLine();
            arrayList.Add(new HoaDonNhap(mahoadon,hoten,diachi,sdt,ngaynhap,manv));
        }
    }
}

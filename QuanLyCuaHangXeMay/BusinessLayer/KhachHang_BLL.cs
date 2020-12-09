using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangXeMay.Entities;
using QuanLyCuaHangXeMay.BusinessLayer.Interface;

namespace QuanLyCuaHangXeMay.DataAccess
{
    class KhachHang_BLL : IKhachHang
    {
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", "Mã khách hàng", "Họ tên", "Địa chỉ", "Thời gian mua", "Số điện thoại", "CMND", "Số lần ghé thăm", "Cấp độ");
            foreach (KhachHang KhachHang in arrayList)
            {
                display(KhachHang);
            }
        }
        public KhachHang findKhachHang(ArrayList arrayList, string keyword)
        {
            KhachHang kq = null;
            foreach (KhachHang KhachHang in arrayList)
            {
                if (KhachHang.Makh.Equals(keyword) || KhachHang.Hoten.Equals(keyword))
                {
                    kq = KhachHang;
                }
            }
            return kq;
        }
        public void Sua(ArrayList arrayList)
        {
            Console.Write("                                Nhập mã hoặc tên cần sửa: ");
            string keyword = Console.ReadLine();
            KhachHang KhachHang = findKhachHang(arrayList, keyword);
            Console.Write("                                Nhập họ tên: ");
            KhachHang.Hoten = Console.ReadLine();
            Console.Write("                                Nhập địa chỉ: ");
            KhachHang.Diachi = Console.ReadLine();
            Console.Write("                                Nhập thời gian mua: ");
            KhachHang.Thoigianmua = Console.ReadLine();
            Console.Write("                                Nhập sđt: ");
            KhachHang.Sdt = Console.ReadLine();
            Console.Write("                                Nhập CMND: ");
            KhachHang.Cmnd = Console.ReadLine();
            Console.Write("                                Nhập số lần ghé thăm: ");
            KhachHang.Solanghetham = int.Parse(Console.ReadLine());
            Console.Write("                                Nhập cấp độ: ");
            KhachHang.Capdo = int.Parse(Console.ReadLine());
        }
        public void display(KhachHang KhachHang)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", KhachHang.Makh, KhachHang.Hoten, KhachHang.Diachi, KhachHang.Thoigianmua, KhachHang.Sdt, KhachHang.Cmnd, KhachHang.Solanghetham, KhachHang.Capdo);
        }
        public void Them(ArrayList arrayList)
        {
            //string tenKhachHang,string loaiKhachHang,string xuatxu,int soluong,double giaban

            string maKhachHang = (arrayList.Count + 1000).ToString();
            Console.Write("                                Nhập họ tên: ");
            string hoten = Console.ReadLine();
            Console.Write("                                Nhập địa chỉ: ");
            string diachi = Console.ReadLine();
            Console.Write("                                Nhập thời gian mua: ");
            string thoigianmua = Console.ReadLine();
            Console.Write("                                Nhập sđt: ");
            string sdt = Console.ReadLine();
            Console.Write("                                Nhập CMND: ");
            string cmnd = Console.ReadLine();
            Console.Write("                                Nhập số lần ghé thăm: ");
            int ghetham = int.Parse(Console.ReadLine());
            Console.Write("                                Nhập cấp độ: ");
            int capdo = int.Parse(Console.ReadLine());
            arrayList.Add(new KhachHang(maKhachHang, hoten, diachi, thoigianmua, sdt, cmnd, ghetham, capdo));
        }

        public void Timkiem(ArrayList arrayList)
        {
            Console.Write("                                Nhập mã hoặc tên khách hàng: ");
            string keyword = Console.ReadLine();
            display(findKhachHang(arrayList, keyword));

        }

        public void Xoa(ArrayList arrayList)
        {
            Console.Write("                                Nhập mã hoặc tên khách hàng: ");
            string keyword = Console.ReadLine();
            arrayList.Remove(findKhachHang(arrayList, keyword));
        }


    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangXeMay.Entities;
using QuanLyCuaHangXeMay.BusinessLayer.Interface;

namespace QuanLyCuaHangXeMay.DataAccess
{
    class NhanVien_BLL : INhanVien
    {
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", "Mã nhân viên", "Họ tên", "CMND", "Năm sinh", "Giới tính", "Số điện thoại", "Chức vụ");
            foreach (NhanVien NhanVien in arrayList)
            {
                display(NhanVien);
            }
        }
        public NhanVien findNhanVien(ArrayList arrayList, string keyword)
        {
            NhanVien kq = null;
            foreach (NhanVien NhanVien in arrayList)
            {
                if (NhanVien.Manhanvien.Equals(keyword) || NhanVien.Hoten.Equals(keyword))
                {
                    kq = NhanVien;
                }
            }
            return kq;
        }
        public void Sua(ArrayList arrayList)
        {
            Console.Write("                                Nhập mã hoặc tên nhân viên: ");
            string keyword = Console.ReadLine();
            NhanVien nhanVien = findNhanVien(arrayList, keyword);
            Console.Write("                                Nhập tên nhân viên: ");
           nhanVien.Hoten = Console.ReadLine();
            Console.Write("                                Nhập cmnd: ");
            nhanVien.Cmnd = Console.ReadLine();
            Console.Write("                                Nhập năm sinh: ");
            nhanVien.Namsinh = Console.ReadLine();
            Console.Write("                                Nhập giới tính: ");
            nhanVien.Gioitinh = Console.ReadLine();
            Console.Write("                                Nhập số điện thoại: ");
            nhanVien.Sdt = Console.ReadLine();
            Console.Write("                                Nhập chức vụ: ");
            nhanVien.Chucvu= Console.ReadLine();
        }
        public void display(NhanVien NhanVien)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", NhanVien.Manhanvien, NhanVien.Hoten, NhanVien.Cmnd, NhanVien.Namsinh, NhanVien.Gioitinh, NhanVien.Sdt, NhanVien.Chucvu);
        }
        public void Them(ArrayList arrayList)
        {
            //manhanvien, hoten, cmnd, namsinh, gioitinh, sdt, chucvu

            string maNhanVien = (arrayList.Count + 1000).ToString();
            Console.Write("                                Nhập tên nhân viên: ");
            string hoten = Console.ReadLine();
            Console.Write("                                Nhập cmnd: ");
            string cmnd = Console.ReadLine();
            Console.Write("                                Nhập năm sinh: ");
            string namsinh = Console.ReadLine();
            Console.Write("                                Nhập giới tính: ");
            string gioitinh = Console.ReadLine();
            Console.Write("                                Nhập số điện thoại: ");
            string sdt = Console.ReadLine();
            Console.Write("                                Nhập chức vụ: ");
            string chucvu = Console.ReadLine();
           
            arrayList.Add(new NhanVien(maNhanVien,hoten,cmnd,namsinh,gioitinh,sdt,chucvu));
        }

        public void Timkiem(ArrayList arrayList)
        {
            Console.Write("                                Nhập mã hoặc tên nhân viên: ");
            string keyword = Console.ReadLine();
            display(findNhanVien(arrayList, keyword));

        }

        public void Xoa(ArrayList arrayList)
        {
            Console.Write("                                Nhập mã hoặc tên nhân viên: ");
            string keyword = Console.ReadLine();
            arrayList.Remove(findNhanVien(arrayList, keyword));
        }


    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangXeMay.BusinessLayer;
using QuanLyCuaHangXeMay.DataAccess;
using QuanLyCuaHangXeMay.Entities;
namespace QuanLyCuaHangXeMay.Presenation
{
    class View
    {
        private static void Menu()
        {
            Console.WriteLine("                                 ___________________________________________________");
            Console.WriteLine("                                 |           QUẢN LÝ CỬA HÀNG XE MÁY                |");
            Console.WriteLine("                                 |__________________________________________________|");
            Console.WriteLine("                                 |1. QUẢN LÝ KHO                                    |");
            Console.WriteLine("                                 |2. QUẢN LÝ XE                                     |");
            Console.WriteLine("                                 |3. QUẢN LÝ NHÂN VIÊN                              |");
            Console.WriteLine("                                 |4. QUẢN LÝ HÓA ĐƠN NHẬP                           |");
            Console.WriteLine("                                 |5. QUẢN LÝ HÓA ĐƠN XUẤT                           |");
            Console.WriteLine("                                 |6. QUẢN LÝ KHÁCH HÀNG                             |");
            Console.WriteLine("                                 |0. THOÁT                                          |");
            Console.WriteLine("                                 |__________________________________________________|");
        }
        static HoaDonNhap_BLL HoaDonNhap_BLL = new HoaDonNhap_BLL();
        static HoaDonXuat_BLL hoaDonXuat_BLL = new HoaDonXuat_BLL();
        static HoaDonNhap_DAL HoaDonNhap_DAL = new HoaDonNhap_DAL();
        static HoaDonXuat_DAL hoaDonXuat_DAL = new HoaDonXuat_DAL();
        static KhachHang_BLL khachHang_BLL = new KhachHang_BLL();
        static KhachHang_DAL khachHang_DAL = new KhachHang_DAL();
        static Kho_BLL kho_BLL = new Kho_BLL();
        static Kho_DAL kho_DAL = new Kho_DAL();
        static NhanVien_BLL nhanVien_BLL = new NhanVien_BLL();
        static NhanVien_DAL nhanVien_DAL = new NhanVien_DAL();
        static Xe_BLL xe_BLL= new Xe_BLL();
        static Xe_DAL xe_DAL = new Xe_DAL();
        static ArrayList hoadonnhap = new ArrayList();
        static ArrayList hoadonxuat = new ArrayList();
        static ArrayList khachhang = new ArrayList();
        static ArrayList kho = new ArrayList();
        static ArrayList nhanvien = new ArrayList();
        static ArrayList xe = new ArrayList();
        public static void Run()
        {
            hoaDonXuat_DAL.docFile(hoadonxuat);
            HoaDonNhap_DAL.docFile(hoadonnhap);
            khachHang_DAL.docFile(khachhang);
            kho_DAL.docFile(kho);
            nhanVien_DAL.docFile(nhanvien);
            xe_DAL.docFile(xe);
            int chon;
            while (true)
            {
                Menu();
                //chọn chức  năng
                chon = int.Parse(Console.ReadLine());
                //nếu nhập = 0 thì dừng chương trình
                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        Console.Clear();
                        Kho_GUI.Run(kho_BLL, kho_DAL, kho);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Xe_GUI.Run(xe_BLL, xe_DAL, xe);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        NhanVien_GUI.Run(nhanVien_BLL, nhanVien_DAL, nhanvien);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        HoaDonNhap_GUI.Run(HoaDonNhap_BLL, HoaDonNhap_DAL, hoadonnhap);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        HoaDonXuat_GUI.Run(hoaDonXuat_BLL, hoaDonXuat_DAL, hoadonxuat);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        KhachHang_GUI.Run(khachHang_BLL, khachHang_DAL, khachhang);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: break;
                }
            }
        }
    }
}

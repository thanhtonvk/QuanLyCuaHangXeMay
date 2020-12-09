using System;
using System.Collections;
using System.Text;
using QuanLyCuaHangXeMay.BusinessLayer;
using QuanLyCuaHangXeMay.DataAccess;

namespace QuanLyCuaHangXeMay.Presenation
{
    class HoaDonNhap_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("                                 ___________________________________________________");
            Console.WriteLine("                                 |              QUẢN LÝ HÓA ĐƠN NHẬP                |");
            Console.WriteLine("                                 |__________________________________________________|");
            Console.WriteLine("                                 |1. Nhập hóa đơn                                   |");
            Console.WriteLine("                                 |2. Hiện thị danh sách                             |");
            Console.WriteLine("                                 |0.Thoát                                           |");
            Console.WriteLine("                                 |__________________________________________________|");
        }
        public static void Run(HoaDonNhap_BLL hoaDonNhap_BLL, HoaDonNhap_DAL hoaDonNhap_DAL, ArrayList arrayList)
        {
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
                        hoaDonNhap_BLL.Them(arrayList);
                        hoaDonNhap_DAL.ghiFile(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        hoaDonNhap_BLL.Hien(arrayList);
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

using System;
using System.Collections;
using System.Text;
using QuanLyCuaHangXeMay.BusinessLayer;
using QuanLyCuaHangXeMay.DataAccess;

namespace QuanLyCuaHangXeMay.Presenation
{
    class HoaDonXuat_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("                                 ___________________________________________________");
            Console.WriteLine("                                 |              QUẢN LÝ HÓA ĐƠN XUẤT                |");
            Console.WriteLine("                                 |__________________________________________________|");
            Console.WriteLine("                                 |1. Nhập hóa đơn                                   |");
            Console.WriteLine("                                 |2. Hiện thị danh sách                             |");
            Console.WriteLine("                                 |3.Thống kê                                        |");
            Console.WriteLine("                                 |0.Thoát                                           |");
            Console.WriteLine("                                 |__________________________________________________|");
        }
        public static void Run(HoaDonXuat_BLL hoaDonXuat_BLL, HoaDonXuat_DAL hoaDonXuat_DAL, ArrayList arrayList)
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
                        hoaDonXuat_BLL.Them(arrayList);
                        hoaDonXuat_DAL.ghiFile(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        hoaDonXuat_BLL.Hien(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        hoaDonXuat_BLL.ThongKe(arrayList);
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

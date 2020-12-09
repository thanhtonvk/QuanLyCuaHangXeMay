using QuanLyCuaHangXeMay.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangXeMay.Presenation
{
    class Kho_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("                                 ___________________________________________________");
            Console.WriteLine("                                 |                      QUẢN LÝ Kho                 |");
            Console.WriteLine("                                 |__________________________________________________|");
            Console.WriteLine("                                 |1. Nhập thêm Kho                                  |");
            Console.WriteLine("                                 |2. Hiện thị danh sách                             |");
            Console.WriteLine("                                 |3. Sửa thông tin                                  |");
            Console.WriteLine("                                 |4. Xóa Kho                                        |");
            Console.WriteLine("                                 |5. Tìm kiếm                                       |");
            Console.WriteLine("                                 |0.Thoát                                           |");
            Console.WriteLine("                                 |__________________________________________________|");
        }
        public static void Run(Kho_BLL Kho_BLL, Kho_DAL Kho_DAL, ArrayList arrayList)
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
                        Kho_BLL.Them(arrayList);
                        Kho_DAL.ghiFile(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Kho_BLL.Hien(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Kho_BLL.Sua(arrayList);
                        Kho_DAL.ghiFile(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Kho_BLL.Xoa(arrayList);
                        Kho_DAL.ghiFile(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Kho_BLL.Timkiem(arrayList);
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

using QuanLyCuaHangXeMay.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangXeMay.Presenation
{
    class NhanVien_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("                                 ___________________________________________________");
            Console.WriteLine("                                 |               QUẢN LÝ NHÂN VIÊN                  |");
            Console.WriteLine("                                 |__________________________________________________|");
            Console.WriteLine("                                 |1. Nhập thêm nhân viên                            |");
            Console.WriteLine("                                 |2. Hiện thị danh sách                             |");
            Console.WriteLine("                                 |3. Sửa thông tin                                  |");
            Console.WriteLine("                                 |4. Xóa nhân viên                                  |");
            Console.WriteLine("                                 |5. Tìm kiếm                                       |");
            Console.WriteLine("                                 |0.Thoát                                           |");
            Console.WriteLine("                                 |__________________________________________________|");
        }
        public static void Run(NhanVien_BLL NhanVien_BLL, NhanVien_DAL NhanVien_DAL, ArrayList arrayList)
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
                        NhanVien_BLL.Them(arrayList);
                        NhanVien_DAL.ghiFile(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        NhanVien_BLL.Hien(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        NhanVien_BLL.Sua(arrayList);
                        NhanVien_DAL.ghiFile(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        NhanVien_BLL.Xoa(arrayList);
                        NhanVien_DAL.ghiFile(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        NhanVien_BLL.Timkiem(arrayList);
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

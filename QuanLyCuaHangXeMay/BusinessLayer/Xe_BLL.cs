using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangXeMay.Entities;
using QuanLyCuaHangXeMay.BusinessLayer.Interface;

namespace QuanLyCuaHangXeMay.DataAccess
{
    class Xe_BLL : IXe
    {
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-30}|{4,-40}|", "Tên xe","Loại xe","Xuất xứ","Số lượng","Giá bán");
            foreach(Xe xe in arrayList)
            {
                display(xe);
            }
        }
        public Xe findXe(ArrayList arrayList,string keyword)
        {
            Xe kq = null;
            foreach(Xe xe in arrayList)
            {
                if (xe.Tenxe.Equals(keyword))
                {
                    kq = xe;
                }
            }
            return kq;
        }
        public void Sua(ArrayList arrayList)
        {
            Console.Write("                                Nhập tên xe cần sửa: ");
            string keyword = Console.ReadLine();
            Xe xe = findXe(arrayList, keyword); 
            Console.Write("                                Nhập tên xe : ");
            xe.Tenxe = Console.ReadLine();
            Console.Write("                                Nhập loại xe: ");
            xe.Loaixe = Console.ReadLine();
            Console.WriteLine("                                NHập xuất xứ: ");
            xe.Xuatxu = Console.ReadLine();
            Console.WriteLine("                                Nhập số lượng: ");
            xe.Soluong = int.Parse(Console.ReadLine());
            Console.WriteLine("                                Nhập giá bán: ");
            xe.Giaban = double.Parse(Console.ReadLine());
        }
        public void display(Xe xe)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-30}|{4,-40}|", xe.Tenxe,xe.Loaixe,xe.Xuatxu,xe.Soluong,xe.Giaban);
        }
        public void Them(ArrayList arrayList)
        {
            //string tenxe,string loaixe,string xuatxu,int soluong,double giaban
            Console.Write("                                Nhập tên xe: ");
            string tenxe = Console.ReadLine();
            Console.Write("                                Nhập loại xe: ");
            string loaixe = Console.ReadLine();
            Console.Write("                                NHập xuất xứ: ");
            string xuatxu = Console.ReadLine();
            Console.Write("                                Nhập số lượng: ");
            int soluong = int.Parse(Console.ReadLine());
            Console.Write("                                Nhập giá bán: ");
            double gia = double.Parse(Console.ReadLine());
            arrayList.Add(new Xe(tenxe, loaixe, xuatxu, soluong, gia));
        }

        public void Timkiem(ArrayList arrayList)
        {
            Console.Write("                                Nhập tên xe: ");
            string keyword = Console.ReadLine();
            display(findXe(arrayList, keyword));

        }

        public void Xoa(ArrayList arrayList)
        {
            Console.Write("                                Nhập tên xe: ");
            string keyword = Console.ReadLine();
            arrayList.Remove(findXe(arrayList, keyword));
        }
    }
}

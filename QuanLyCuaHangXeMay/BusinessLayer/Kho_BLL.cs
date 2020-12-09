using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangXeMay.Entities;
using QuanLyCuaHangXeMay.BusinessLayer.Interface;

namespace QuanLyCuaHangXeMay.DataAccess
{
    class Kho_BLL : IKho
    {
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-30}|", "Mã kho", "Vị trí", "Tình trạng", "Mã nhân viên");
            foreach (Kho Kho in arrayList)
            {
                display(Kho);
            }
        }
        public Kho findKho(ArrayList arrayList, string keyword)
        {
            Kho kq = null;
            foreach (Kho Kho in arrayList)
            {
                if (Kho.Makho.Equals(keyword))
                {
                    kq = Kho;
                }
            }
            return kq;
        }
        public void Sua(ArrayList arrayList)
        {
            Console.Write("                                Nhập mã Kho cần sửa: ");
            string keyword = Console.ReadLine();
            Kho Kho = findKho(arrayList, keyword);
            Console.Write("                                Nhập mã Kho: ");
            Kho.Manv = Console.ReadLine();
            Console.Write("                                Nhập vị trí Kho: ");
            Kho.Vitri = Console.ReadLine();
            Console.Write("                                NHập tình trạng: ");
            Kho.Tinhtrang = Console.ReadLine();
            Console.Write("                                Nhập mã nhân viên: ");
            Kho.Manv = Console.ReadLine();
        }
        public void display(Kho Kho)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-30}|", Kho.Makho, Kho.Vitri, Kho.Tinhtrang, Kho.Manv);
        }
        public void Them(ArrayList arrayList)
        {
            //string tenKho,string loaiKho,string xuatxu,int soluong,double giaban

            string makho = (arrayList.Count + 1000).ToString();
            Console.Write("                                Nhập vị trí Kho: ");
            string vitri = Console.ReadLine();
            Console.Write("                                NHập tình trạng: ");
            string tinhtrang = Console.ReadLine();
            Console.Write("                                Nhập mã nhân viên: ");
            string manv = Console.ReadLine();

            arrayList.Add(new Kho(makho, vitri, tinhtrang, manv));
        }

        public void Timkiem(ArrayList arrayList)
        {
            Console.Write("                                Nhập mã Kho: ");
            string keyword = Console.ReadLine();
            display(findKho(arrayList, keyword));

        }

        public void Xoa(ArrayList arrayList)
        {
            Console.Write("                                Nhập mã Kho: ");
            string keyword = Console.ReadLine();
            arrayList.Remove(findKho(arrayList, keyword));
        }
    }
}

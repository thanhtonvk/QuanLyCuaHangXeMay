using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangXeMay.Entities;
using QuanLyCuaHangXeMay.BusinessLayer.Interface;
namespace QuanLyCuaHangXeMay.BusinessLayer
{
    class HoaDonXuat_BLL : IHoaDonXuat
    {
        private int getSLBanChay(ArrayList arrayList)
        {
            int kq = int.MinValue;
            foreach(HoaDonXuat hoaDonXuat in arrayList)
            {
                if (kq < hoaDonXuat.Soluong) kq = hoaDonXuat.Soluong;
            }
            return kq;
        }
        private int getSLBanE(ArrayList arrayList)
        {
            int kq = int.MaxValue;
            foreach (HoaDonXuat hoaDonXuat in arrayList)
            {
                if (kq > hoaDonXuat.Soluong) kq = hoaDonXuat.Soluong;
            }
            return kq;
        }
        public void ThongKe(ArrayList arrayList)
        {
            Console.WriteLine("Thống kê loại xe bán chạy");
            foreach(HoaDonXuat hoaDonXuat in arrayList)
            {
                if (hoaDonXuat.Soluong == getSLBanChay(arrayList))
                {
                    Console.Write(hoaDonXuat.Loaixe);
                }
            }
            foreach (HoaDonXuat hoaDonXuat in arrayList)
            {
                if (hoaDonXuat.Soluong == getSLBanE(arrayList))
                {
                    Console.Write(hoaDonXuat.Loaixe);
                }
            }
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã hóa đơn", "Tên xe", "Loại xe", "Số lượng", "Giá bán", "Tổng tiền");
            foreach (HoaDonXuat hoaDon in arrayList)
            {
                Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", hoaDon.Mahoadonxuat, hoaDon.Tenxe, hoaDon.Loaixe, hoaDon.Soluong, hoaDon.Tongtien);
            }
        }

        public void Them(ArrayList arrayList)
        {
            //string mahoadonxuat,string tenxe,string loaixe,int soluong,double giaban,double tongtien

            string mahoadon = (arrayList.Count + 1000).ToString();
            Console.Write("                                Nhập tên xe: ");
            string tenxe = Console.ReadLine();
            Console.Write("                                Nhập loại xe: ");
            string loaixe = Console.ReadLine();
            Console.Write("                                Nhập số lượng: ");
            int sl = int.Parse(Console.ReadLine());
            Console.Write("                                Nhập giá bán: ");
            double giaban = double.Parse(Console.ReadLine());
            double tong = sl * giaban;
         
          
            arrayList.Add(new HoaDonXuat(mahoadon, tenxe, loaixe, sl, giaban, tong));
        }
    }
}

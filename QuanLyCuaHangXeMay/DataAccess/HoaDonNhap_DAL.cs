﻿using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangXeMay.Entities;

namespace QuanLyCuaHangXeMay.DataAccess
{
    class HoaDonNhap_DAL
    {
        static string path = "HoaDonNhap.txt";
        public void docFile(ArrayList arrayList)
        {
            if (File.Exists(path))
            {
                string line;
                StreamReader streamReader = new StreamReader(path);
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split("#");
                    arrayList.Add(new HoaDonNhap(arr[0], arr[1], arr[2], arr[3], arr[4],arr[5]));
                }
                streamReader.Close();
            }
        }
        public void ghiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (HoaDonNhap HoaDonNhap in arrayList)
            {
                streamWriter.WriteLine(HoaDonNhap.ToString());
            }
            streamWriter.Close();
        }
    }
}

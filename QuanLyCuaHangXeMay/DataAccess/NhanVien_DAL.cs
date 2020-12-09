using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangXeMay.Entities;

namespace QuanLyCuaHangXeMay.DataAccess
{
    class NhanVien_DAL
    {
        static string path = "NhanVien.txt";
        public void docFile(ArrayList arrayList)
        {
            if (File.Exists(path))
            {
                string line;
                StreamReader streamReader = new StreamReader(path);
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split("#");
                    arrayList.Add(new NhanVien(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]));
                }
                streamReader.Close();
            }
        }
        public void ghiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (NhanVien NhanVien in arrayList)
            {
                streamWriter.WriteLine(NhanVien.ToString());
            }
            streamWriter.Close();
        }
    }
}

using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangXeMay.Entities;

namespace QuanLyCuaHangXeMay.DataAccess
{
    class KhachHang_DAL
    {
        static string path = "KhachHang.txt";
        public void docFile(ArrayList arrayList)
        {
            if (File.Exists(path))
            {
                string line;
                StreamReader streamReader = new StreamReader(path);
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split("#");
                    arrayList.Add(new KhachHang(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], int.Parse(arr[6]), int.Parse(arr[7])));
                }
                streamReader.Close();
            }
        }
        public void ghiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (KhachHang KhachHang in arrayList)
            {
                streamWriter.WriteLine(KhachHang.ToString());
            }
            streamWriter.Close();
        }
    }
}

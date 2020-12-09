using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangXeMay.Entities;

namespace QuanLyCuaHangXeMay.DataAccess
{
    class HoaDonXuat_DAL
    {
        static string path = "HoaDonXuat.txt";
        public void docFile(ArrayList arrayList)
        {
            //string mahoadonxuat,string tenxe,string loaixe,int soluong,double giaban,double tongtien
            if (File.Exists(path))
            {
                string line;
                StreamReader streamReader = new StreamReader(path);
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split("#");
                    arrayList.Add(new HoaDonXuat(arr[0], arr[1], arr[2],int.Parse( arr[3]), double.Parse(arr[4]),double.Parse( arr[5])));
                }
                streamReader.Close();
            }
        }
        public void ghiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (HoaDonXuat HoaDonXuat in arrayList)
            {
                streamWriter.WriteLine(HoaDonXuat.ToString());
            }
            streamWriter.Close();
        }
    }
}

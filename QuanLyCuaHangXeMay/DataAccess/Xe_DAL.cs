using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangXeMay.Entities;

namespace QuanLyCuaHangXeMay.DataAccess
{
    class Xe_DAL
    {
        static string path = "xe.txt";
        public void docFile(ArrayList arrayList)
        {
            if (File.Exists(path))
            {
                string line;
                StreamReader streamReader = new StreamReader(path);
                while((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split("#");
                    arrayList.Add(new Xe(arr[0], arr[1], arr[2], int.Parse(arr[3]), double.Parse(arr[4])));
                }
                streamReader.Close();
            }
        }
        public void ghiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach(Xe xe in arrayList)
            {
                streamWriter.WriteLine(xe.ToString());
            }
            streamWriter.Close();
        }
    }
}

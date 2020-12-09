using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangXeMay.Entities;

namespace QuanLyCuaHangXeMay.DataAccess
{
    class Kho_DAL
    {
        static string path = "Kho.txt";
        public void docFile(ArrayList arrayList)
        {
            if (File.Exists(path))
            {
                string line;
                StreamReader streamReader = new StreamReader(path);
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split("#");
                    arrayList.Add(new Kho(arr[0], arr[1], arr[2], arr[3]));
                }
                streamReader.Close();
            }
        }
        public void ghiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (Kho Kho in arrayList)
            {
                streamWriter.WriteLine(Kho.ToString());
            }
            streamWriter.Close();
        }
    }
}

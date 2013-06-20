using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Collections;
using HotelManager.Data;
using HotelManager.Data.Entity;


namespace HotelManager.Business
{
    class BusNhanVien
    {
        public static ArrayList GetList()
        {
            return DataNhanVien.GetList();
        }

        public static DataTable GetTable()
        {
            return DataNhanVien.GetTable();
        }

        public static void UpdateTable(DataTable dataTable)
        {
            DataNhanVien.UpdateTable(dataTable);
        }

        public static void UpdateNhanVien(NhanVien nhanvien)
        {
            DataNhanVien.UpdateNhanVien(nhanvien);
        }

        public static bool Add(NhanVien nhanvien)
        {
            return DataNhanVien.Add(nhanvien);
        }

        public static void Delete(int maNhanVien)
        {
            DataNhanVien.Delete(maNhanVien);
        }

        public static DataTable Find(int maNhanVien)
        {
            return DataNhanVien.Find(maNhanVien);
        }

        public static DataTable Find(string tenNhanVien)
        {
            return DataNhanVien.Find(tenNhanVien);
        }

        public static NhanVien FindUserPass(string user, string pass)
        {
            return DataNhanVien.FindUserPass(user, pass);
        }
    }
}

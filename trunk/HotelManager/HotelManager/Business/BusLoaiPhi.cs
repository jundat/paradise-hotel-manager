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
    class BusLoaiPhi
    {
        public static ArrayList GetList()
        {
            return DataLoaiPhi.GetList();
        }

        public static DataTable GetTable()
        {
            return DataLoaiPhi.GetTable();
        }

        public static void UpdateTable(DataTable dataTable)
        {
            DataLoaiPhi.UpdateTable(dataTable);
        }

        public static void Update(LoaiPhi loaiphi)
        {
            DataLoaiPhi.Update(loaiphi);
        }

        public static bool Add(LoaiPhi loaiphi)
        {
            return DataLoaiPhi.Add(loaiphi);
        }

        public static void Delete(int maLoaiPhi)
        {
            DataLoaiPhi.Delete(maLoaiPhi);
        }

        public static DataTable Find(int maLoaiPhi)
        {
            return DataLoaiPhi.Find(maLoaiPhi);
        }

        public static DataTable Find(string tenLoaiPhi)
        {
            return DataLoaiPhi.Find(tenLoaiPhi);
        }

        public static String FindTenBang(int MaLoaiPhi)
        {
            return DataLoaiPhi.FindTenBang(MaLoaiPhi);
        }
    }
}

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
    class BusChiTietPhieuDen
    {
        public static ArrayList GetList(int maPhieuDen)
        {
            return DataChiTietPhieuDen.GetList(maPhieuDen);
        }

        public static ArrayList GetList()
        {
            return DataChiTietPhieuDen.GetList();
        }

        public static DataTable GetTable()
        {
            return DataChiTietPhieuDen.GetTable();
        }

        public static void UpdateTable(DataTable dataTable)
        {
            DataChiTietPhieuDen.UpdateTable(dataTable);
        }

        public static void UpdateChiTietPhieuDen(ChiTietPhieuDen ct_PhieuDen)
        {
            DataChiTietPhieuDen.UpdateChiTietPhieuDen(ct_PhieuDen);
        }

        public static bool Add(ChiTietPhieuDen ct_PhieuDen)
        {
            return DataChiTietPhieuDen.Add(ct_PhieuDen);
        }

        public static void Delete(int maCTPhieuDen)
        {
            DataChiTietPhieuDen.Delete(maCTPhieuDen);
        }

        public static DataTable Find(int maCTPhieuDen)
        {
            return DataChiTietPhieuDen.Find(maCTPhieuDen);
        }

        public static ArrayList FindMaPhong(int maphong)
        {
            return DataChiTietPhieuDen.FindMaPhong(maphong);
        }

        public static DataTable FindMaPhieuDen(int maPhieuDen)
        {
            return DataChiTietPhieuDen.FindMaPhieuDen(maPhieuDen);
        }


    }
}

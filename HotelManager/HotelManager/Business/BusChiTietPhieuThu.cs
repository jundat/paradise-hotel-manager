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
    class BusChiTietPhieuThu
    {
        public static ArrayList GetList()
        {
            return DataChiTietPhieuThu.GetList();
        }

        public static DataTable GetTable()
        {
            return DataChiTietPhieuThu.GetTable();
        }

        public static void UpdateTable(DataTable dataTable)
        {
            DataChiTietPhieuThu.UpdateTable(dataTable);
        }

        public static void UpdateChiTietPhieuThu(ChiTietPhieuThu ct_phieuthu)
        {
            DataChiTietPhieuThu.UpdateChiTietPhieuThu(ct_phieuthu);
        }

        public static bool Add(ChiTietPhieuThu ct_phieuthu)
        {
            return DataChiTietPhieuThu.Add(ct_phieuthu);
        }

        public static void Delete(int maCTPhieuThu)
        {
            DataChiTietPhieuThu.Delete(maCTPhieuThu);
        }

        public static DataTable Find(int maCTPhieuThu)
        {
            return DataChiTietPhieuThu.Find(maCTPhieuThu);
        }

        public static DataTable FindMaPhieuThu(int maPhieuThu)
        {
            return DataChiTietPhieuThu.FindMaPhieuThu(maPhieuThu);
        }
    }
}

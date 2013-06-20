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
    class BusPhieuDen
    {
        public static PhieuDen Get(int maphieuden)
        {
            return DataPhieuDen.Get(maphieuden);
        }

        public static ArrayList GetList()
        {
            return DataPhieuDen.GetList();
        }

        public static DataTable GetTable()
        {
            return DataPhieuDen.GetTable();
        }

        public static void UpdateTable(DataTable dataTable)
        {
            DataPhieuDen.UpdateTable(dataTable);
        }

        public static void UpdatePhieuDen(PhieuDen phieuDen)
        {
            DataPhieuDen.UpdatePhieuDen(phieuDen);
        }

        public static void UpdateTrangThai(int maphieu, bool tinhtrang)
        {
            DataPhieuDen.UpdateTrangThai(maphieu, tinhtrang);
        }

        public static bool Add(PhieuDen phieuDen)
        {
            return DataPhieuDen.Add(phieuDen);
        }

        public static void Delete(int maPhieuDen)
        {
            DataPhieuDen.Delete(maPhieuDen);
        }

        public static DataTable Find(int maPhieuDen)
        {
            return DataPhieuDen.Find(maPhieuDen);
        }

        public static DataTable FindCMND(string cmnd, bool tinhtrang)
        {
            return DataPhieuDen.FindCMND(cmnd, tinhtrang);
        }

        public static DataTable Find(string tenKhachDaiDien)
        {
            return DataPhieuDen.Find(tenKhachDaiDien);
        }
    }
}

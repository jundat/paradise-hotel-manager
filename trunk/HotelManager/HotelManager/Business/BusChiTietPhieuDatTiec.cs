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
    class BusChiTietPhieuDatTiec
    {
        public static ArrayList GetList()
        {
            return DataChiTietPhieuDatTiec.GetList();
        }

        public static DataTable GetTable()
        {
            return DataChiTietPhieuDatTiec.GetTable();
        }

        public static void UpdateTable(DataTable dataTable)
        {
            DataChiTietPhieuDatTiec.UpdateTable(dataTable);
        }

        public static void UpdateChiTietPhieuDatTiec(ChiTietPhieuDatTiec ct_phieudattiec)
        {
            DataChiTietPhieuDatTiec.UpdateChiTietPhieuDatTiec(ct_phieudattiec);
        }

        public static bool Add(ChiTietPhieuDatTiec ct_phieudattiec)
        {
            return DataChiTietPhieuDatTiec.Add(ct_phieudattiec);
        }

        public static void Delete(int maphieu)
        {
            DataChiTietPhieuDatTiec.Delete(maphieu);
        }

        public static DataTable Find(int maphieu)
        {
            return DataChiTietPhieuDatTiec.Find(maphieu);
        }

        public static DataTable Find(string tenmon)
        {
            return DataChiTietPhieuDatTiec.Find(tenmon);
        }

    }
}

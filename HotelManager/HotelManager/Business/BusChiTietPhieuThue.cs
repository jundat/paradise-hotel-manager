using HotelManager.Data;
using HotelManager.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HotelManager.Business
{
    class BusChiTietPhieuThue : BusAbstract
    {
        public static void Add(ChiTietPhieuThue phieu)
        {
            DataChiTietPhieuThue.Add(phieu);
        }

        public static DataTable FindMaPhieuThue(int maphieuthue)
        {
            return DataChiTietPhieuThue.FindMaPhieuThue(maphieuthue);
        }
    }
}

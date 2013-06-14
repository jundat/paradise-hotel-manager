using HotelManager.Data;
using HotelManager.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HotelManager.Business
{
    class BusPhuThu : BusAbstract
    {
        public static DataTable GetTable()
        {
            return DataPhuThu.GetTable();
        }

        public static void UpdateTable(DataTable data)
        {
            DataPhuThu.UpdateTable(data);
        }

        public static PhuThu Find(int soluongkhach)
        {
            return DataPhuThu.Find(soluongkhach);
        }
    }
}

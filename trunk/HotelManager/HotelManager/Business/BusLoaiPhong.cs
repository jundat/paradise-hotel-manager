using HotelManager.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HotelManager.Business
{
    class BusLoaiPhong : BusAbstract
    {
        public static ArrayList GetList()
        {
            return DataLoaiPhong.GetList();
        }

        public static DataTable GetTable()
        {
            return DataLoaiPhong.GetTable();
        }

        public static void UpdateTable(DataTable data)
        {
            DataLoaiPhong.UpdateTable(data);
        }
    }
}

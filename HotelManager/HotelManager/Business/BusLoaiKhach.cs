using HotelManager.Data;
using HotelManager.Data.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HotelManager.Business
{
    class BusLoaiKhach : BusAbstract
    {
        public static ArrayList GetList()
        {
            return DataLoaiKhach.GetList();
        }

        public static DataTable GetTable()
        {
            return DataLoaiKhach.GetTable();
        }

        public static void UpdateTable(DataTable data)
        {
            DataLoaiKhach.UpdateTable(data);
        }

        public static LoaiKhach Find(int maloaikhach)
        {
            return DataLoaiKhach.Find(maloaikhach);
        }
    }
}

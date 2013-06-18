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
    class BusPhieuThu
    {
        public static ArrayList GetList()
        {
            return DataPhieuThu.GetList();
        }

        public static DataTable GetTable()
        {
            return DataPhieuThu.GetTable();
        }

        public static void UpdateTable(DataTable dataTable)
        {
            DataPhieuThu.UpdateTable(dataTable);
        }

        public static void UpdatePhieuThu(PhieuThu phieuthu)
        {
            DataPhieuThu.UpdatePhieuThu(phieuthu);
        }

        public static bool Add(PhieuThu phieuthu)
        {
            return DataPhieuThu.Add(phieuthu);
        }

        public static void Delete(int maPhieuThu)
        {
            DataPhieuThu.Delete(maPhieuThu);
        }

        public static DataTable Find(int maPhieuThu)
        {
            return DataPhieuThu.Find(maPhieuThu);
        }

        public static DataTable Find(string tenKhach)
        {
            return DataPhieuThu.Find(tenKhach);
        }
        
    }
}

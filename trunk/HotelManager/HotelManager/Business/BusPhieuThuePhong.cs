using HotelManager.Data;
using HotelManager.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HotelManager.Business
{
    class BusPhieuThuePhong : BusAbstract
    {
        public static int Add(PhieuThuePhong phieu)
        {
            return DataPhieuThuePhong.Add(phieu);
        }

        public static DataTable GetTable()
        {
            return DataPhieuThuePhong.GetTable();
        }

        /// <summary>
        /// Lấy phiếu thuê phòng có ngày thuê gần nhất ứng với maphong
        /// </summary>
        public static PhieuThuePhong GetPrevious(int maphong)
        {
            return DataPhieuThuePhong.GetPrevious(maphong);
        }

        public static void UpdatePhieuThue(PhieuThuePhong phieu)
        {
            DataPhieuThuePhong.UpdatePhieuThue(phieu);
        }
    }
}

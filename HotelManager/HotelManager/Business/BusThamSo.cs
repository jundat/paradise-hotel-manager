using HotelManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Business
{
    class BusThamSo : BusAbstract
    {
        public static int GetSoKhachToiDaTrongPhong()
        {
            return DataThamSo.GetSoKhachToiDaTrongPhong();
        }

        public static void UpdateSoKhachToiDa(int sk)
        {
            DataThamSo.UpdateSoKhachToiDa(sk);
        }
    }
}

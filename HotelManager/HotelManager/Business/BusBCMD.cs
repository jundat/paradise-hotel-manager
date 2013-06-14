using HotelManager.Data;
using HotelManager.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HotelManager.Business
{
    class BusBCMD : BusAbstract
    {
        public static int Add(int thang)
        {
            return DataBCMD.Add(thang);
        }

        public static BCMD FindThangBaoCao(int thang)
        {
            return DataBCMD.FindThangBaoCao(thang);
        }

        public static DataTable BaoCaoMatDo(int thang, int nam)
        {
            return DataPhong.BaoCaoMatDo(thang, nam);
        }
    }
}

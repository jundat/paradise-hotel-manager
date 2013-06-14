using HotelManager.Data;
using HotelManager.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Business
{
    class BusChiTietBCMD : BusAbstract
    {
        public static void Add(ChiTietBCMD phieu)
        {
            DataChiTietBCMD.Add(phieu);
        }
    }
}

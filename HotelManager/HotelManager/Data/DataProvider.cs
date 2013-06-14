using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;


namespace HotelManager.Data
{
    class DataProvider : DataAbstract
    {
        private static OleDbConnection ObjCn;
        private static string file = "hotel.mdb";
        private static string user = "admin";
        private static string pass = "tanlong";

        /// <summary>
        /// Trả về 1 connection đã được mở
        /// </summary>
        /// <returns></returns>
        public static OleDbConnection ConnectionData()
        {
            if (ObjCn == null)
            {
                string ChuoiConnect =
                    "Provider = Microsoft.Jet.OLEDB.4.0 " +
                    ";Data Source =" + System.Windows.Forms.Application.StartupPath + @"\" + file +
                    ";Jet OLEDB:Database Password = " + pass +
                    ";User ID = " + user;

                ObjCn = new OleDbConnection(ChuoiConnect);
            }

            if (ObjCn.State != System.Data.ConnectionState.Open)
            {
                ObjCn.Open();
            }

            return ObjCn;
        }
        
    }
}

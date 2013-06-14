using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace HotelManager.Data
{
    /// <summary>
    /// Quản lý bảng THAMSO
    /// </summary>
    class DataThamSo : DataAbstract
    {
        public static int GetSoKhachToiDaTrongPhong()
        {
            //tao ket noi, mo ket noi
            OleDbConnection ObjCn = DataProvider.ConnectionData();

            //tao chuoi strSQL thao tac CSDL
            string StrSQL = "SELECT SoKhachToiDaTrongMotPhong FROM THAMSO";

            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            OleDbDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            if(ObjReader.Read())
            {
                return (int)ObjReader["SoKhachToiDaTrongMotPhong"];
            }

            return -1;
        }

        public static void UpdateSoKhachToiDa(int _soKhachToiDa)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "UPDATE THAMSO SET SoKhachToiDaTrongMotPhong = ?";
            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            ObjCmd.Parameters.Add("@SoKhachToiDaTrongMotPhong", OleDbType.Integer).Value = _soKhachToiDa;

            ObjCmd.ExecuteNonQuery();
            ObjCn.Close();
        }
    }
}

using HotelManager.Data.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace HotelManager.Data
{
    /// <summary>
    /// Quản lý bảng PHUTHU
    /// </summary>
    class DataPhuThu : DataAbstract
    {
        public static ArrayList GetList()
        {
            ArrayList listPhuThu = new ArrayList();
            //
            OleDbConnection ObjCn = DataProvider.ConnectionData();

            //tao chuoi strSQL thao tac CSDL
            string StrSQL = "SELECT * FROM PHUTHU";

            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            OleDbDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                PhuThu phuthu = new PhuThu();

                phuthu.SoLuongKhach = (int)ObjReader["SoLuongKhach"];
                phuthu.TyLePhuThu = (double)ObjReader["TyLePhuThu"];

                listPhuThu.Add(phuthu);
            }

            //dong ket noi, giai phongDuocChon tai nguyen
            ObjCn.Close();

            return listPhuThu;            
        }

        public static DataTable GetTable()
        {
            DataTable _DataTable = new DataTable();

            //tao ket noi
            OleDbConnection ObjCn = DataProvider.ConnectionData();

            //tao chuoi strSQL
            string StrSQL = "SELECT * FROM PHUTHU";

            OleDbDataAdapter ObjAdapter = new OleDbDataAdapter(StrSQL, ObjCn);
            ObjAdapter.Fill(_DataTable);

            //dong ket noi
            ObjCn.Close();
            return _DataTable;
        }

        public static void UpdateTable(DataTable _dataTable)
        {
            //tao chuoi ket noi.
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM PHUTHU";

            OleDbDataAdapter ObjAdapter = new OleDbDataAdapter(StrSQL, ObjCn);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(ObjAdapter);

            ObjAdapter.Update(_dataTable);

            //dong ket noi
            ObjCn.Close();
        }

        public static PhuThu Find(int soluongkhach)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM PHUTHU WHERE SoLuongKhach = ?";

            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);
            ObjCmd.Parameters.Add("@SoLuongKhach", OleDbType.Integer).Value = soluongkhach;

            OleDbDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            PhuThu _phuthu = new PhuThu();

            if (ObjReader.Read())
            {
                _phuthu.SoLuongKhach = (int)ObjReader["SoLuongKhach"];
                _phuthu.TyLePhuThu = (double)ObjReader["TyLePhuThu"];
            }

            //dong ket noi
            ObjReader.Close();
            ObjCn.Close();

            return _phuthu;
        }

        public static bool AddPhuThu(PhuThu _phuthu)
        {
            try
            {
                OleDbConnection ObjCn = DataProvider.ConnectionData();

                string StrSQL = "INSERT INTO PHUTHU(SoLuongKhach, TyLePhuThu) VALUES(?, ?)";
                OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

                ObjCmd.Parameters.Add("@SoLuongKhach", OleDbType.Integer).Value = _phuthu.SoLuongKhach;
                ObjCmd.Parameters.Add("@TyLePhuThu", OleDbType.Double).Value = _phuthu.TyLePhuThu;

                ObjCmd.ExecuteNonQuery();

                ////Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                //StrSQL = "Select @@IDENTITY";

                //ObjCmd = new OleDbCommand(StrSQL, ObjCn);
                //_phuthu.MaPhong = (int)ObjCmd.ExecuteScalar();

                //dong ket noi giair phongDuocChon tai nguyen
                ObjCn.Close();

                return true;
            }
            catch (Exception eee)
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManager.Data.Entity;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace HotelManager.Data
{
    /// <summary>
    /// Quản lý các thao tác với ChiTietBCMD
    /// </summary>
    class DataChiTietBCMD : DataAbstract
    {
        public static DataTable GetTable()
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM CHITIETBCMD";
            OleDbDataAdapter da = new OleDbDataAdapter(StrSQL, ObjCn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ObjCn.Close();
            return dt;
        }

        public static void UpdateTable(DataTable dt)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM CHITIETBCMD";
            OleDbDataAdapter da = new OleDbDataAdapter(StrSQL, ObjCn);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);

            da.Update(dt);
            ObjCn.Close();
        }

        public static ArrayList GetList()
        {
            ArrayList _arrList = new ArrayList();
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM CHITIETBCMD";
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ChiTietBCMD _chiTietBCMD = new ChiTietBCMD();

                _chiTietBCMD.MaChiTietBCMD = (int)dr["MaChiTietBCMD"];
                _chiTietBCMD.MaPhong = (int)dr["MaPhong"];
                _chiTietBCMD.SoNgayThue = (int)dr["SoNgayThue"];
                _chiTietBCMD.TyLe = (double)dr["TyLe"];
                _chiTietBCMD.MaBCMD = (int)dr["MaPhong"];

                _arrList.Add(_chiTietBCMD);
            }

            dr.Close();
            ObjCn.Close();
            return _arrList;
        }

        public static void Add(ChiTietBCMD _phieuCT)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "INSERT INTO CHITIETBCMD(MaPhong, SoNgayThue, TyLe, MaBCMD) values(?, ?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);

            cmd.Parameters.Add("@MaPhong", OleDbType.Integer).Value = _phieuCT.MaPhong;
            cmd.Parameters.Add("@SoNgayThue", OleDbType.Integer).Value = _phieuCT.SoNgayThue;
            cmd.Parameters.Add("@TyLe", OleDbType.Double).Value = _phieuCT.TyLe;
            cmd.Parameters.Add("@MaBCMD", OleDbType.Integer).Value = _phieuCT.MaBCMD;

            cmd.ExecuteNonQuery();

            StrSQL = "SELECT @@IDENTITY";
            cmd = new OleDbCommand(StrSQL, ObjCn);
            _phieuCT.MaChiTietBCMD = (int)cmd.ExecuteScalar();

            ObjCn.Close();
        }

        public static void Delete(int _maCTBCMD)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "DELETE FROM CHITIETBCMD WHERE MaChiTietBCMD = ?";

            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);
            cmd.Parameters.Add("@MaChiTietBCMD", OleDbType.Integer).Value = _maCTBCMD;

            cmd.ExecuteNonQuery();

            ObjCn.Close();
        }

        public static void UpdateChiTietBCMD(ChiTietBCMD _CTPhieuThue)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "UPDATE CHITIETBCMD SET MaPhong = ?, SoNgayThue = ?, TyLe = ?, MaBCMD = ? WHERE MaChiTietBCMD = ?";
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);

            cmd.Parameters.Add("@MaPhong", OleDbType.Integer).Value = _CTPhieuThue.MaPhong;
            cmd.Parameters.Add("@SoNgayThue", OleDbType.Integer).Value = _CTPhieuThue.SoNgayThue;
            cmd.Parameters.Add("@TyLe", OleDbType.Double).Value = _CTPhieuThue.TyLe;
            cmd.Parameters.Add("@MaBCMD", OleDbType.Integer).Value = _CTPhieuThue.MaBCMD;
            cmd.Parameters.Add("@MaChiTietBCMD", OleDbType.Integer).Value = _CTPhieuThue.MaChiTietBCMD;

            cmd.ExecuteNonQuery();

            ObjCn.Close();
        }

    }
}

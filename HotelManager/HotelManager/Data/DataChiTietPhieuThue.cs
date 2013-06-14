using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using HotelManager.Data.Entity;

namespace HotelManager.Data
{
    /// <summary>
    /// Thao tác với bảng CHITIETPHIEUTHUE
    /// </summary>
    public class DataChiTietPhieuThue : DataAbstract
    {
        /// <summary>
        /// Lấy bảng CHITIETPHIEUTHUE
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM CHITIETPHIEUTHUE";
            OleDbDataAdapter da = new OleDbDataAdapter(StrSQL,ObjCn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ObjCn.Close();
            return dt;
        }

        /// <summary>
        /// update dữ liệu mới
        /// </summary>
        /// <param name="dt"></param>
        public static void UpdateTable(DataTable dt)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM CHITIETPHIEUTHUE";
            OleDbDataAdapter da = new OleDbDataAdapter(StrSQL, ObjCn);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            
            da.Update(dt);
            ObjCn.Close();
        }

        /// <summary>
        /// Lấy list các CHITIETPHIEUTHUE
        /// </summary>
        /// <returns></returns>
        public static IList GetList()
        {
            ArrayList _arrList = new ArrayList();
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM CHITIETPHIEUTHUE";
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ChiTietPhieuThue _chiTietPT = new ChiTietPhieuThue();

                _chiTietPT.MaChiTietPhieuThue = (int)dr["MaChiTietPhieuThue"];
                _chiTietPT.MaPhieuThue = (int)dr["MaPhieuThue"];
                _chiTietPT.TenKhachHang = (string)dr["TenKhachHang"];
                _chiTietPT.DiaChi = (string)dr["DiaChi"];
                _chiTietPT.CMND = (string)dr["CMND"];
                _chiTietPT.MaLoaiKhach = (int)dr["MaLoaiKhach"];

                _arrList.Add(_chiTietPT);
            }

            dr.Close();
            ObjCn.Close();
            return _arrList;
        }

        /// <summary>
        /// Tìm kiếm 1 ChiTietPhieuThue theo DiaChi
        /// </summary>
        /// <param name="_diaChi"></param>
        /// <returns></returns>
        public static DataTable FindDC(string _diaChi)
        {
            DataTable dt = new DataTable();
            
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM CHITIETPHIEUTHUE WHERE DiaChi = ?";
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);
            
            cmd.Parameters.Add("@DiaChi", OleDbType.WChar).Value = _diaChi;
            
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dt);
            
            return dt;
        }

        /// <summary>
        /// Lấy danh sách các phiếu thuê có chung mã phiếu thuê
        /// </summary>
        public static DataTable FindMaPhieuThue(int maphieuthue)
        {
            DataTable dt = new DataTable();

            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM CHITIETPHIEUTHUE WHERE MaPhieuThue = ?";
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);

            cmd.Parameters.Add("@MaPhieuThue", OleDbType.WChar).Value = maphieuthue;

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Tifmm kiếm chi tiết phiếu thuê theo cmnd
        /// </summary>
        /// <param name="_cmnd"></param>
        /// <returns></returns>
        public static ChiTietPhieuThue FindCMND(string _cmnd)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM CHITIETPHIEUTHUE WHERE CMND = ?";
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);
            cmd.Parameters.Add("@CMND", OleDbType.WChar).Value = _cmnd;
            
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();
            ChiTietPhieuThue _phieuCT = new ChiTietPhieuThue();

            while (reader.Read())
            {
                _phieuCT.MaChiTietPhieuThue = (int)reader["MaChiTietPhieuThue"];
                _phieuCT.MaPhieuThue = (int)reader["MaPhieuThue"];
                _phieuCT.TenKhachHang = (string)reader["TenKhachHang"];
                _phieuCT.DiaChi = (string)reader["DiaChi"];
                _phieuCT.CMND = (string)reader["CMND"];
                _phieuCT.MaLoaiKhach = (int)reader["MaLoaiKhach"];
            }

            reader.Close();
            ObjCn.Close();
            return _phieuCT;
        }

        //public  static DataTable FindTenPhong(KhachHang _KH)
        //{
        //    DataTable adapter = new DataTable();
        //    ObjCn = DataProvider.ConnectionData();
        //    OleDbCommand cmd = BuildQuery(_KH, ObjCn);
        //    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
        //    adapter.Fill(adapter);
        //    return adapter;
        //}
        //private  static OleDbCommand BuildQuery(KhachHang _KH, OleDbConnection _cn)
        //{
        //    OleDbCommand cmd = new OleDbCommand();
        //    string strDKPhong = "1=1";
        //    string strDKDiaChi = "1=1";
        //    string strDKCMND = "1=1";
        //    string strDKTenLoaiKhach = "1=1";

        //    //if (_KH.CheckTenPhong)
        //    //{
        //    //    strDKPhong = "TenPhong like ?";
        //    //    cmd.Parameters.Add("@TenPhong", OleDbType.WChar).Value = ("%" + (_KH.TenPhong + "%"));

        //    //}
        //    if (_KH.CheckDC && _KH.DiaChi != "")
        //    {
        //        strDKDiaChi = "DiaChi like ?";
        //        cmd.Parameters.Add("@DiaChi", OleDbType.WChar).Value = ("%" + (_KH.DiaChi + "%"));
        //    }
        //    if (_KH.CheckCMND )
        //    {
        //        strDKCMND = "CMND like ?";
        //        cmd.Parameters.Add("@CMND", OleDbType.WChar).Value = ("%" + (_KH.CMND + "%"));
        //    }
        //    string strDKWhere = "Where"+ " ";            
        //    strDKWhere = (strDKWhere + strDKDiaChi);
        //    strDKWhere = (strDKWhere + ("and" + strDKCMND));

        //    string strSQL = "Select * From ChiTietPhieuThuePhong" ;
        //    strSQL = (strSQL + strDKWhere);
            
        //    cmd.Connection = ObjCn;
        //    cmd.CommandText = StrSQL;
        //    return cmd;
        //}

        /// <summary>
        /// Thêm chi tiết phiếu thuê vào bảng CHITIETPHIEUTHUE
        /// </summary>
        /// <param name="_phieuCT"></param>
        public static void Add(ChiTietPhieuThue _phieuCT)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "INSERT INTO CHITIETPHIEUTHUE(MaPhieuThue, TenKhachHang, DiaChi, CMND, MaLoaiKhach) values(?, ?, ?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);

            cmd.Parameters.Add("@MaPhieuThue", OleDbType.Integer).Value = _phieuCT.MaPhieuThue;
            cmd.Parameters.Add("@TenKhachHang", OleDbType.WChar).Value = _phieuCT.TenKhachHang;
            cmd.Parameters.Add("@DiaChi", OleDbType.WChar).Value = _phieuCT.DiaChi;
            cmd.Parameters.Add("@CMND", OleDbType.WChar).Value = _phieuCT.CMND;
            cmd.Parameters.Add("@MaLoaiKhach", OleDbType.Integer).Value = _phieuCT.MaLoaiKhach;

            cmd.ExecuteNonQuery();

            StrSQL = "Select @@IDENTITY";
            cmd = new OleDbCommand(StrSQL, ObjCn);
            _phieuCT.MaChiTietPhieuThue = (int)cmd.ExecuteScalar();

            ObjCn.Close();
        }

        /// <summary>
        /// Xoá chi tiết phiếu thuê phòng
        /// </summary>
        /// <param name="_maCTBCMD"></param>
        public static void Delete(int _maCTPhieuThue)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "DELETE FROM CHITIETPHIEUTHUE WHERE MaChiTietPhieuThue = ?";
            
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);
            cmd.Parameters.Add("@MaChiTietPhieuThue", OleDbType.Integer).Value = _maCTPhieuThue;
            
            cmd.ExecuteNonQuery();
            
            ObjCn.Close();
        }

        /// <summary>
        /// Sửa 1 chi tiết phiếu thuê
        /// </summary>
        /// <param name="_CTPhieuThue"></param>
        public static void UpdateCTPT(ChiTietPhieuThue _CTPhieuThue)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "UPDATE CHITIETPHIEUTHUE SET MaPhieuThue = ?, TenKhachHangThuePhong = ?, DiaChi = ?, CMND = ?, MaLoaiKhach = ? WHERE MaChiTietPhieuThue = ?";
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);

            cmd.Parameters.Add("@MaPhieuThue", OleDbType.Integer).Value = _CTPhieuThue.MaPhieuThue;
            cmd.Parameters.Add("@TenKhachHang", OleDbType.WChar).Value = _CTPhieuThue.TenKhachHang;
            cmd.Parameters.Add("@DiaChi", OleDbType.WChar).Value = _CTPhieuThue.DiaChi;
            cmd.Parameters.Add("@CMND", OleDbType.WChar).Value = _CTPhieuThue.CMND;
            cmd.Parameters.Add("@MaLoaiKhach", OleDbType.Integer).Value = _CTPhieuThue.MaLoaiKhach;
            cmd.Parameters.Add("@MaChiTietPhieuThue", OleDbType.Integer).Value = _CTPhieuThue.MaChiTietPhieuThue;
            
            cmd.ExecuteNonQuery();
            
            ObjCn.Close();
        }
    }
}

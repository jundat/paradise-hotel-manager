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
    /// Các thao tác đối với Loại Phòng
    /// </summary>
    public class DataLoaiPhong : DataAbstract
    {
        /// <summary>
        /// Lấy List các LoaiPhong từ bảng LOAIPHONG
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetList()
        {
            ArrayList arrayList = new ArrayList();
            
            //mo ket noi
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM LOAIPHONG";
            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);
            OleDbDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                LoaiPhong _loaiPhong = new LoaiPhong();

                _loaiPhong.MaLoaiPhong = (int)ObjReader["MaLoaiPhong"];
                _loaiPhong.TenLoaiPhong = (string)ObjReader["TenLoaiPhong"];
                _loaiPhong.DonGia = (decimal)ObjReader["DonGia"];

                arrayList.Add(_loaiPhong);
            }

            //dong ket noi
            ObjCn.Close();
            return arrayList;
        }

        /// <summary>
        /// Lấy table LOAIPHONG
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            DataTable _dataTable = new DataTable();
            //
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM LOAIPHONG";
            OleDbDataAdapter ObjAdapter = new OleDbDataAdapter(StrSQL, ObjCn);
            ObjAdapter.Fill(_dataTable);
            
            //dong ket noi
            ObjCn.Close();
            return _dataTable;
        }

        /// <summary>
        /// Update dữ liệu cho bảng LOAIPHONG
        /// </summary>
        /// <param name="_dataTable"></param>
        public static void UpdateTable(DataTable _dataTable)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM LOAIPHONG";
            OleDbDataAdapter ObjAdapter = new OleDbDataAdapter(StrSQL, ObjCn);
            OleDbCommandBuilder ObjCmd = new OleDbCommandBuilder(ObjAdapter);

            ObjAdapter.Update(_dataTable);

            //dong ket noi
            ObjCn.Close();
        }

        /// <summary>
        /// Tìm kiếm 1 LoaiPhong theo TenLoaiPhong
        /// </summary>
        /// <param name="_maLoaiPhong"></param>
        /// <returns></returns>
        public static LoaiPhong Find(string _tenLoaiPhong)
        {
            LoaiPhong _loaiPhong = new LoaiPhong();
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM LOAIPHONG WHERE TenLoaiPhong = ?";

            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);
            ObjCmd.Parameters.Add("@TenLoaiPhong", OleDbType.WChar).Value = _tenLoaiPhong;
            
            OleDbDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();
            
            while (ObjReader.Read())
            {
                _loaiPhong.MaLoaiPhong = (int)ObjReader["MaLoaiPhong"];
                _loaiPhong.TenLoaiPhong = (string)ObjReader["TenLoaiPhong"];
                _loaiPhong.DonGia = (decimal)ObjReader["DonGia"];
            }

            //dong ket noi
            ObjReader.Close();
            ObjCn.Close();
            return _loaiPhong;
        }

        public static LoaiPhong Find(int _maLoaiPhong)
        {
            LoaiPhong _loaiPhong = new LoaiPhong();
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM LOAIPHONG WHERE MaLoaiPhong = ?";

            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);
            ObjCmd.Parameters.Add("@MaLoaiPhong", OleDbType.Integer).Value = _maLoaiPhong;

            OleDbDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                _loaiPhong.MaLoaiPhong = (int)ObjReader["MaLoaiPhong"];
                _loaiPhong.TenLoaiPhong = (string)ObjReader["TenLoaiPhong"];
                _loaiPhong.DonGia = (decimal)ObjReader["DonGia"];
            }

            //dong ket noi
            ObjReader.Close();
            ObjCn.Close();
            return _loaiPhong;
        }

        /// <summary>
        /// Tìm kiếm LoaiPhong theo đơn giá
        /// </summary>
        /// <param name="_donGia"></param>
        /// <returns></returns>
        public static LoaiPhong Find(double _donGia)
        {
            LoaiPhong _loaiPhong = new LoaiPhong();

            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM LOAIPHONG WHERE DonGia = ?";
            
            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);
            ObjCmd.Parameters.Add("@DonGia", OleDbType.Currency).Value = _donGia;
            
            OleDbDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();
            
            while (ObjReader.Read())
            {
                _loaiPhong.MaLoaiPhong = (int)ObjReader["MaLoaiPhong"];
                _loaiPhong.TenLoaiPhong = (string)ObjReader["TenLoaiPhong"];
                _loaiPhong.DonGia = (decimal)ObjReader["DonGia"];
            }

            //dong ket noi
            ObjReader.Close();
            ObjCn.Close();
            return _loaiPhong;
        }

        /// <summary>
        /// Thêm LoaiPhong mới
        /// </summary>
        /// <param name="phieuThue"></param>
        public static void Add(LoaiPhong _loaiPhong)
        {
            //
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "INSERT INTO LOAIPHONG(TenLoaiPhong, DonGia) VALUES(?, ?)";

            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);
            ObjCmd.Parameters.Add("@TenLoaiPhong", OleDbType.WChar).Value = _loaiPhong.TenLoaiPhong;
            ObjCmd.Parameters.Add("@DonGia", OleDbType.Currency).Value = (decimal)_loaiPhong.DonGia;

            ObjCmd.ExecuteNonQuery();
            StrSQL = "Select @@IDENTITY";
            ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            _loaiPhong.MaLoaiPhong = (int)ObjCmd.ExecuteScalar();
            
            //dong ket noi
            ObjCn.Close();
        }

        /// <summary>
        /// Xoá 1 LoaiPhong trong bảng LOAIPHONG
        /// </summary>
        /// <param name="_tinhtrang"></param>
        public static void Delete(int _maLoaiPhong)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "DELETE FROM LOAIPHONG WHERE MaLoaiPhong = ?";
            
            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);
            ObjCmd.Parameters.Add("@MaLoaiPhong", OleDbType.Integer).Value = _maLoaiPhong;
            
            ObjCmd.ExecuteNonQuery();
            
            ObjCn.Close();
        }

        /// <summary>
        /// Sửa thông tin 1 LoaiPhong
        /// </summary>
        /// <param name="phieuThue"></param>
        public static void Update(LoaiPhong _loaiPhong)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "UPDATE LOAIPHONG SET TenLoaiPhong = ?, DonGia = ? Where MaLoaiPhong = ?";
            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            ObjCmd.Parameters.Add("@MaLoaiPhong", OleDbType.Integer).Value = _loaiPhong.MaLoaiPhong;
            ObjCmd.Parameters.Add("@TenLoaiPhong", OleDbType.WChar).Value = _loaiPhong.TenLoaiPhong;
            ObjCmd.Parameters.Add("@DonGia", OleDbType.Currency).Value = _loaiPhong.DonGia;

            ObjCmd.ExecuteNonQuery();

            ObjCn.Close();
        }
    }
}

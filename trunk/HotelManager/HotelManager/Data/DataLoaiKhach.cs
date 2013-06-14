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
    /// Các thao tác với bảng LOAIKHACH
    /// </summary>
    public class DataLoaiKhach : DataAbstract
    {
        /// <summary>
        /// Lấy danh sách LoaiKhach
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetList()
        {
            ArrayList arrayList = new ArrayList();
            //mo ket noi
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM LOAIKHACH";

            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);
            OleDbDataReader ObjReader;
            
            ObjReader = ObjCmd.ExecuteReader();
            
            while (ObjReader.Read())
            {
                LoaiKhach _LoaiKhach = new LoaiKhach();

                _LoaiKhach.MaLoaiKhach = (int)ObjReader["MaLoaiKhach"];
                _LoaiKhach.TenLoaiKhach = (string)ObjReader["TenLoaiKhach"];
                _LoaiKhach.HeSo = (double)ObjReader["HeSo"];

                arrayList.Add(_LoaiKhach);
            }

            //dong ket noi
            ObjCn.Close();
            return arrayList;
        }

        /// <summary>
        /// Lấy về table LOAIKHACH
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            DataTable _dataTable = new DataTable();
            //
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM LOAIKHACH";
            
            OleDbDataAdapter ObjAdapter = new OleDbDataAdapter(StrSQL, ObjCn);
            ObjAdapter.Fill(_dataTable);
            
            //dong ket noi
            ObjCn.Close();
            return _dataTable;
        }

        /// <summary>
        /// Update dữ liệu cho bảng LOAIKHACH
        /// </summary>
        /// <param name="_dataTable"></param>
        public static void UpdateTable(DataTable _dataTable)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM LOAIKHACH";

            OleDbDataAdapter ObjAdapter = new OleDbDataAdapter(StrSQL, ObjCn);
            OleDbCommandBuilder ObjCmd = new OleDbCommandBuilder(ObjAdapter);

            ObjAdapter.Update(_dataTable);
            
            //dong ket noi
            ObjCn.Close();
        }

        /// <summary>
        /// Tìm kiếm LoaiKhach theo TenLoaiKhach
        /// </summary>
        /// <param name="_tenLoaiKhach"></param>
        /// <returns></returns>
        public static LoaiKhach Find(string _tenLoaiKhach)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM LOAIKHACH WHERE TenLoaiKhach = ?";
            
            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);
            ObjCmd.Parameters.Add("@TenLoaiKhach", OleDbType.WChar).Value = _tenLoaiKhach;
            
            OleDbDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();
            
            LoaiKhach _LoaiKhach = new LoaiKhach();
            
            while (ObjReader.Read())
            {
                _LoaiKhach.MaLoaiKhach = (int)ObjReader["MaLoaiKhach"];
                _LoaiKhach.TenLoaiKhach = (string)ObjReader["TenLoaiKhach"];
                _LoaiKhach.HeSo = (double)ObjReader["HeSo"];
            }

            //dong ket noi
            ObjReader.Close();
            ObjCn.Close();
            return _LoaiKhach;
        }

        public static LoaiKhach Find(int maloaikhach)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM LOAIKHACH WHERE MaLoaiKhach = ?";

            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);
            ObjCmd.Parameters.Add("@MaLoaiKhach", OleDbType.Integer).Value = maloaikhach;

            OleDbDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            LoaiKhach _loaiKhach = new LoaiKhach();

            if (ObjReader.Read())
            {
                _loaiKhach.MaLoaiKhach = (int)ObjReader["MaLoaiKhach"];
                _loaiKhach.TenLoaiKhach = (string)ObjReader["TenLoaiKhach"];
                _loaiKhach.HeSo = (double)ObjReader["HeSo"];
            }

            //dong ket noi
            ObjReader.Close();
            ObjCn.Close();
            return _loaiKhach;
        }
       
        /// <summary>
        /// Thêm LoaiKhach
        /// </summary>
        /// <param name="_phuthu"></param>
        public static void Add(LoaiKhach _LoaiKhach)
        {
            //
            OleDbConnection ObjCn = DataProvider.ConnectionData();

            string StrSQL = "INSERT INTO LOAIKHACH(TenLoaiKhach, HeSo) values(?, ?)";
            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            ObjCmd.Parameters.Add("@TenLoaiKhach", OleDbType.WChar).Value = _LoaiKhach.TenLoaiKhach;
            ObjCmd.Parameters.Add("@HeSo", OleDbType.Decimal).Value = (double)_LoaiKhach.HeSo;
            
            ObjCmd.ExecuteNonQuery();
            
            StrSQL = "Select @@IDENTITY";
            ObjCmd = new OleDbCommand(StrSQL, ObjCn);
            _LoaiKhach.MaLoaiKhach = (int)ObjCmd.ExecuteScalar();
            
            //dong ket noi
            ObjCn.Close();
        }

        /// <summary>
        /// Xoá LoaiKhach
        /// </summary>
        /// <param name="_maLoaiKhach"></param>
        public static void Delete(int _maLoaiKhach)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "DELETE FROM LOAIKHACH WHERE MaLoaiKhach = ?";
            
            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);
            ObjCmd.Parameters.Add("@MaLoaiKhach", OleDbType.Integer).Value = _maLoaiKhach;
            ObjCmd.ExecuteNonQuery();

            ObjCn.Close();
        }

        /// <summary>
        /// Sửa thông tin LoaiKhach
        /// </summary>
        /// <param name="_phuthu"></param>
        public static void Update(LoaiKhach _LoaiKhach)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "UPDATE LOAIKHACH SET TenLoaiKhach = ?, HeSo = ? WHERE MaLoaiKhach = ?";
            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            ObjCmd.Parameters.Add("@MaLoaiKhach", OleDbType.Integer).Value = _LoaiKhach.MaLoaiKhach;
            ObjCmd.Parameters.Add("@TenLoaiKhach", OleDbType.WChar).Value = _LoaiKhach.TenLoaiKhach;
            ObjCmd.Parameters.Add("@HeSo", OleDbType.Double).Value = _LoaiKhach.HeSo;

            ObjCmd.ExecuteNonQuery();

            ObjCn.Close();
        }
    }
}

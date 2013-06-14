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
    /// Thực hiện các thao tác trên PhieuThuePhong
    /// </summary>
    public class DataPhieuThuePhong : DataAbstract
    {
        /// <summary>
        /// Lấy danh sách phuthu từ PHONG, dưới dạng List
        /// </summary>
        /// <returns></returns>
        public static IList GetList()
        {
            ArrayList _arrayList = new ArrayList();
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM PHIEUTHUEPHONG";
            OleDbCommand command = new OleDbCommand(StrSQL, ObjCn);
            OleDbDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                PhieuThuePhong _phieuThue = new PhieuThuePhong();

                _phieuThue.MaPhieuThue = (int)reader["MaPhieuThue"];
                _phieuThue.MaPhong = (int)reader["MaPhong"];
                _phieuThue.NgayBatDauThue = (DateTime)reader["NgayBatDauThue"];
                
                //_phieuThue.NgayTraPhong = (DateTime)reader["NgayTraPhong"];

                try
                {
                    _phieuThue.NgayTraPhong = (DateTime)reader["NgayTraPhong"];
                }
                catch
                {
                    _phieuThue.NgayTraPhong = DateTime.MaxValue;
                }

                _phieuThue.DonGiaThue = (decimal)reader["DonGiaThue"];

                _arrayList.Add(_phieuThue);
            }

            reader.Close();
            ObjCn.Close();
            return _arrayList;
        }

        /// <summary>
        /// Lấy hết bảng PHIEUTHUEPHONG
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            DataTable dataTable = new DataTable();
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM PHIEUTHUEPHONG";
            
            OleDbDataAdapter adapter = new OleDbDataAdapter(StrSQL,ObjCn);
            adapter.Fill(dataTable);
            ObjCn.Close();
            return dataTable;
        }

        /// <summary>
        /// UpdatePhieuThue giá trị mới cho bảng PHIEUTHUEPHONG
        /// </summary>
        /// <param name="dataTable"></param>
        public static void UpdateTable(DataTable dataTable)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM PHIEUTHUEPHONG";
            OleDbDataAdapter adapter = new OleDbDataAdapter(StrSQL, ObjCn);
            
            OleDbCommandBuilder commandBuider = new OleDbCommandBuilder(adapter);

            adapter.Update(dataTable);
            ObjCn.Close();
        }

        /// <summary>
        /// Thêm phiếu thuê phòng
        /// </summary>
        /// <param name="_phieu"></param>
        /// <returns>Trả về MaPhieuThue nếu thành công, ngược lại -1</returns>
        public static int Add(PhieuThuePhong _phieu)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "INSERT INTO PHIEUTHUEPHONG(MaPhong, NgayBatDauThue, NgayTraPhong, DonGiaThue) VALUES(?, ?, ?, ?)";
            
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);

            cmd.Parameters.Add("@MaPhong", OleDbType.Integer).Value = _phieu.MaPhong;
            cmd.Parameters.Add("@NgayBatDauThue", OleDbType.Date).Value = (DateTime)_phieu.NgayBatDauThue;
            cmd.Parameters.Add("@NgayTraPhong", OleDbType.Date).Value = (DateTime)_phieu.NgayTraPhong;
            cmd.Parameters.Add("@DonGiaThue", OleDbType.Currency).Value = (decimal)_phieu.DonGiaThue;

            cmd.ExecuteNonQuery();
            
            StrSQL = "SELECT @@IDENTITY";
            cmd = new OleDbCommand(StrSQL, ObjCn);
            _phieu.MaPhieuThue = (int)cmd.ExecuteScalar();

            ObjCn.Close();
            return _phieu.MaPhieuThue;
        }

        /// <summary>
        /// Xoá phiếu thuê phòng với MaPhieuThue
        /// </summary>
        /// <param name="_maPhieuThue"></param>
        public static void Delete(int _maPhieuThue)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "DELETE FROM PHIEUTHUEPHONG WHERE MaPhieuThue = ?";
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);
            cmd.Parameters.Add("@MaPhieuThue", OleDbType.Integer).Value = _maPhieuThue;
            cmd.ExecuteNonQuery();
            ObjCn.Close();
        }

        /// <summary>
        /// Sửa 1 phiếu thuê phòng
        /// </summary>
        /// <param name="_phieu"></param>
        public static void UpdatePhieuThue(PhieuThuePhong _phieu)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "UPDATE PHIEUTHUEPHONG SET MaPhong = ?, NgayBatDauThue = ?, DonGiaThue = ?, NgayTraPhong = ? Where MaPhieuThue = ?";
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);

            cmd.Parameters.Add("@MaPhong", OleDbType.Integer).Value = _phieu.MaPhong;
            cmd.Parameters.Add("@NgayBatDauThue", OleDbType.Date).Value = (DateTime)_phieu.NgayBatDauThue;
            cmd.Parameters.Add("@NgayTraPhong", OleDbType.Date).Value = (DateTime)_phieu.NgayTraPhong;
            cmd.Parameters.Add("@DonGiaThue", OleDbType.Currency).Value = (decimal)_phieu.DonGiaThue;
            cmd.Parameters.Add("@MaPhieuThue", OleDbType.Integer).Value = (int)_phieu.MaPhieuThue;
            cmd.ExecuteNonQuery();
            ObjCn.Close();
        }

        public static PhieuThuePhong Find(int MaPhieuThue)
        {
            PhieuThuePhong phieu = new PhieuThuePhong();
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM PHIEUTHUEPHONG WHERE MaPhieuThue = ?";

            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);
            ObjCmd.Parameters.Add("@MaPhieuThue", OleDbType.Integer).Value = MaPhieuThue;

            OleDbDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            if (ObjReader.Read())
            {
                phieu.MaPhieuThue = (int)ObjReader["MaPhieuThue"];
                phieu.MaPhong = (int)ObjReader["MaPhong"];
                phieu.NgayBatDauThue = (DateTime)ObjReader["NgayBatDauThue"];

                try
                {
                    phieu.NgayTraPhong = (DateTime)ObjReader["NgayTraPhong"];

                    if (phieu.NgayTraPhong.Year == 1900)
                        phieu.NgayTraPhong = DateTime.MaxValue;
                }
                catch
                {
                    phieu.NgayTraPhong = DateTime.MaxValue;
                }

                phieu.DonGiaThue = (decimal)ObjReader["DonGiaThue"];
            }

            //dong ket noi
            ObjReader.Close();
            ObjCn.Close();
            return phieu;
        }

        /// <summary>
        /// Lấy phiếu gần nhất có mã phòng = maphong
        /// </summary>
        public static PhieuThuePhong GetPrevious(int maphong)
        {
            //ArrayList _arrayList = new ArrayList();
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT MAX(MaPhieuThue) FROM PHIEUTHUEPHONG WHERE MaPhong=?";
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);
            cmd.Parameters.Add("@MaPhong", OleDbType.Integer).Value = maphong;
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            try
            {
                if (reader.Read())
                {
                    int maphieu = (int)reader[0];

                    PhieuThuePhong phieu = Find(maphieu);
                    return phieu;
                }
            }
            catch
            {
                return null;
            }

            return null;
        }
    }
}

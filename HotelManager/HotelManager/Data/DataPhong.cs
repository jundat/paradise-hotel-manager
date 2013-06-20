using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using MySql.Data.MySqlClient;
using HotelManager.Data.Entity;
using System.Data;
using System.Windows.Forms;

namespace HotelManager.Data
{
    /// <summary>
    /// Thực hiện các thao tác trên bảng PHONG
    /// </summary>
    class DataPhong
    {
        /// <summary>
        /// Lấy danh sách Phòng, dưới dạng List
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetList()
        {
            ArrayList listPhong = new ArrayList();
            
            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM phong";
            MySqlDataReader dataReader = null;
            try
            {
                // Thực thi truy vấn
                dataReader = cmd.ExecuteReader();

                // Lấy dữ liệu trả ra từ truy vấn rồi gán cho baoCaoDoanhThu
                while (dataReader.Read())
                {
                    Phong phong = new Phong();

                    phong.MaPhong = (int)dataReader["MaPhong"];
                    phong.MaLoaiPhong = (int)dataReader["MaLoaiPhong"];
                    phong.TenPhong = (string)dataReader["TenPhong"];
                    phong.TinhTrangHienTai = Convert.ToBoolean(dataReader["TinhTrangHienTai"]);
                    phong.MoTa = (String)dataReader["MoTa"];

                    listPhong.Add(phong);
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetList PHONG table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }

            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
            return listPhong;
        }

        /// <summary>
        /// Lấy hết bảng PHONG từ database
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM phong";
            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataTable);

            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
            return dataTable;
        }

        /// <summary>
        /// Update giá trị mới cho bảng PHONG
        /// </summary>
        /// <param name="dataTable"></param>
        public static void UpdateTable(DataTable dataTable)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM phong";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            MySqlCommandBuilder commandBuider = new MySqlCommandBuilder(adapter);

            adapter.Update(dataTable);
            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
        }


        /// <summary>
        /// Thêm một phòng
        /// </summary>
        /// <param name="phong"></param>
        /// <returns></returns>
        public static bool AddPhong(Phong phong)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "INSERT INTO phong(MaLoaiPhong, TenPhong, TinhTrangHienTai, MoTa) VALUES(?, ?, ?, ?);";
            
            try
            {
                cmd.Parameters.Add("@MaLoaiPhong", MySqlDbType.Int32).Value = phong.MaLoaiPhong;
                cmd.Parameters.Add("@TenPhong", MySqlDbType.String).Value = phong.TenPhong;
                cmd.Parameters.Add("@TinhTrangHienTai", MySqlDbType.Byte).Value = phong.TinhTrangHienTai;
                cmd.Parameters.Add("@MoTa", MySqlDbType.String).Value = phong.MoTa;

                cmd.ExecuteNonQuery();

                cmd.CommandText = "Select @@IDENTITY";
                phong.MaPhong = (int)cmd.ExecuteScalar();

                // Đóng kết nối
                DataProvider.getInstance().CloseConnection();
                return true;
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Dữ liệu trùng lặp: Phong " + phong.MaPhong);
                }
                // Đóng kết nối
                DataProvider.getInstance().CloseConnection();
                return false;
            }
        }
        
        /// <summary>
        /// Cập nhật thông tin 1 phòng
        /// </summary>
        /// <param name="phong"></param>
        public static void UpdatePhong(Phong phong)
        {
            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE phong SET MaLoaiPhong = ?, TinhTrangHienTai = ?, MoTa = ?  WHERE MaPhong = ?";

            // Truyền tham số cho câu truy vấn
            cmd.Parameters.Add("@MaLoaiPhong", MySqlDbType.Int32).Value = phong.MaLoaiPhong;
            cmd.Parameters.Add("@TinhTrangHienTai", MySqlDbType.Byte).Value = phong.TinhTrangHienTai;
            cmd.Parameters.Add("@MoTa", MySqlDbType.String).Value = phong.MoTa;
            cmd.Parameters.Add("@MaPhong", MySqlDbType.Int32).Value = phong.MaPhong;

            // Thực thi truy vấn
            cmd.ExecuteNonQuery();
            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
        }
        
        /// <summary>
        /// Xóa một phòng
        /// </summary>
        /// <param name="maPhong"></param>
        public static void DeletePhong(int maPhong)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "DELETE FROM phong WHERE MaPhong = " + maPhong;
            cmd.ExecuteNonQuery();
            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
        }

        /// <summary>
        /// Tìm kiếm 1 phòng thông qua MaPhong
        /// </summary>
        /// <param name="_maPhong"></param>
        /// <returns>Phong</returns>
        public static Phong FindMaPhong(int _maPhong)
        {
            Phong phong = new Phong();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM phong WHERE MaPhong = ?";

            cmd.Parameters.Add("@MaPhong", MySqlDbType.Int32).Value = _maPhong;

            MySqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                phong.MaPhong = (int)dataReader["MaPhong"];
                phong.MaLoaiPhong = (int)dataReader["MaLoaiPhong"];
                phong.TinhTrangHienTai = (Boolean)dataReader["TinhTrangHienTai"];
                phong.MoTa = (String)dataReader["MoTa"];
            }

            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
            return phong;
        }

        /// <summary>
        /// Tìm kiếm 1 phòng thông qua TenPhong
        /// </summary>
        /// <param name="_tenPhong"></param>
        /// <returns>Phong</returns>
        public static Phong FindTheoTenPhong(String _tenPhong)
        {
            
            Phong phong = new Phong();

            DataProvider.getInstance().OpenConnection();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM phong WHERE TenPhong = '" + _tenPhong + "'";
            
            MySqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                phong.MaPhong = (int)dataReader["MaPhong"];
                phong.MaLoaiPhong = (int)dataReader["MaLoaiPhong"];
                phong.TenPhong = (String)dataReader["TenPhong"];
                phong.TinhTrangHienTai = Convert.ToBoolean(dataReader["TinhTrangHienTai"]);
                phong.MoTa = (String)dataReader["MoTa"];
            }


            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
            return phong;
        }

        /// <summary>
        /// Tim kiem theo Mã Loại Phòng
        /// </summary>
        public static DataTable FindMaLoaiPhong(int _maLoaiPhong)
        {
            DataTable dataTable = new DataTable();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM phong WHERE MaLoaiPhong = ?";
            cmd.Parameters.Add("@MaLoaiPhong", MySqlDbType.Int32).Value = _maLoaiPhong;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataTable);

            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
            return dataTable;
        }

        /// <summary>
        /// Tim kiem theo tinh trang
        /// </summary>
        public static DataTable FindTinhTrang(Boolean _tinhTrang)
        {
            DataTable dataTable = new DataTable();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM phong WHERE TinhTrangHienTai = ?";
            cmd.Parameters.Add("@TinhTrangHienTai", MySqlDbType.Byte).Value = _tinhTrang;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataTable);

            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
            return dataTable;
        }

        /// <summary>
        /// Tim kiem bang Mô tả
        /// </summary>
        public static DataTable FindGhiChu(string _moTa)
        {
            DataTable dataTable = new DataTable();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM phong WHERE GhiChu LIKE '%" + _moTa + "%' ;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataTable);

            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
            return dataTable;
        }


    }
}

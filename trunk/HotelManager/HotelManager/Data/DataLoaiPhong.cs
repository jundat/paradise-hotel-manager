using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using System.Windows.Forms;
using HotelManager.Data.Entity;
using System.Data;
using MySql.Data.MySqlClient; 

namespace HotelManager.Data
{
    /// <summary>
    /// Thực hiện các thao tác trên bảng LOAI_PHONG
    /// </summary>
    class DataLoaiPhong
    {
        /// <summary>
        /// Lấy danh sách loại phòng, dưới dạng List
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetList()
        {
            // Lấy command
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            MySqlDataReader dataReader = null;
            ArrayList _arrayList = new ArrayList();

            try
            {
                // set query
                cmd.CommandText = "SELECT * FROM loai_phong";
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    LoaiPhong _loaiPhong = new LoaiPhong();

                    _loaiPhong.MaLoaiPhong = (int)dataReader["MaLoaiPhong"];
                    _loaiPhong.TenLoaiPhong = (String)dataReader["TenLoaiPhong"];
                    _loaiPhong.DonGia = (float)dataReader["DonGia"];

                    _arrayList.Add(_loaiPhong);
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetList !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }

            return _arrayList;
        }

        /// <summary>
        /// Lấy hết bảng LOAI_PHONG
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM PHIEUTHUEPHONG";
            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataTable);

            return dataTable;
        }

        /// <summary>
        /// Update giá trị mới cho bảng LOAI_PHONG
        /// </summary>
        /// <param name="dataTable"></param>
        public static void UpdateTable(DataTable dataTable)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM PHIEUTHUEPHONG";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            MySqlCommandBuilder commandBuider = new MySqlCommandBuilder(adapter);

            adapter.Update(dataTable);
        }

        /// <summary>
        /// Thêm Loại Phòng
        /// </summary>
        /// <param name="_phieu"></param>
        /// <returns>Trả về MaLoaiPhong nếu thành công, ngược lại -1</returns>
        public static int Add(LoaiPhong _loaiPhong)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "INSERT INTO loai_phong(MaLoaiPhong, TenLoaiPhong, DonGia) VALUES(?, ?, ?)";
            
            cmd.Parameters.Add("@MaLoaiPhong", MySqlDbType.Int32).Value = _loaiPhong.MaLoaiPhong;
            cmd.Parameters.Add("@TenLoaiPhong", MySqlDbType.String).Value = _loaiPhong.TenLoaiPhong;
            cmd.Parameters.Add("@DonGia", MySqlDbType.Float).Value = _loaiPhong.DonGia;

            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT @@IDENTITY";
            _loaiPhong.MaLoaiPhong = (int)cmd.ExecuteScalar();

            return _loaiPhong.MaLoaiPhong;
        }

        /// <summary>
        /// Xoá Loại phòng với MaLoaiPhong
        /// </summary>
        /// <param name="_maPhieuThue"></param>
        public static void Delete(int _maLoaiPhong)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "DELETE FROM loai_phong WHERE MaLoaiPhong = ?";

            cmd.Parameters.Add("@MaLoaiPhong", MySqlDbType.Int32).Value = _maLoaiPhong;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Sửa 1 Loại Phòng
        /// </summary>
        /// <param name="_loaiPhong"></param>
        public static void UpdateLoaiPhong(LoaiPhong _loaiPhong)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE loai_phong SET TenLoaiPhong = ?, DonGia = ? WHERE MaLoaiPhong = ?";

            cmd.Parameters.Add("@MaLoaiPhong", MySqlDbType.Int32).Value = _loaiPhong.MaLoaiPhong;
            cmd.Parameters.Add("@TenLoaiPhong", MySqlDbType.String).Value = _loaiPhong.TenLoaiPhong;
            cmd.Parameters.Add("@DonGia", MySqlDbType.Float).Value = _loaiPhong.DonGia;

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Tìm kiếm Loai Phòng theo mã của nó
        /// </summary>
        /// <param name="_maLoaiPhong"></param>
        /// <returns></returns>
        public static LoaiPhong Find(int _maLoaiPhong)
        {
            LoaiPhong loaiPhong = new LoaiPhong();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM loai_phong WHERE MaLoaiPhong = ?";

            cmd.Parameters.Add("@MaLoaiPhong", MySqlDbType.Int32).Value = _maLoaiPhong;

            MySqlDataReader dataReader = null;
            try
            {
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    loaiPhong.MaLoaiPhong = (int)dataReader["MaLoaiPhong"];
                    loaiPhong.TenLoaiPhong = (String)dataReader["TenLoaiPhong"];
                    loaiPhong.DonGia = (float)dataReader["DonGia"];
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetList LOAI_PHONG table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }

            return loaiPhong;
        }
    }
}

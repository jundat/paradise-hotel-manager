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
    /// Thao tác vơi bảng BANG_KE
    /// </summary>
    class DataBangKe
    {
        /// <summary>
        /// Lấy danh sách các bảng kê dưới dạng List
        /// </summary>
        /// <returns></returns>
        public static IList GetList()
        {
            // Lấy command
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            MySqlDataReader dataReader = null;
            ArrayList _arrayList = new ArrayList();

            try
            {
                // set query
                cmd.CommandText = "SELECT * FROM bang_ke";
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    BangKe _bangKe = new BangKe();

                    _bangKe.MaBangKe = (int)dataReader["MaBangKe"];
                    _bangKe.MaPhong = (int)dataReader["MaPhong  "];
                    _bangKe.TongChiPhi = (float)dataReader["TongChiPhi"];
                    _bangKe.TinhTrangThanhToan = (Boolean)dataReader["TinhTrangHienTai"];

                    _arrayList.Add(_bangKe);
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetList BANG_KE table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Lấy hết bảng BANG_KE
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM bang_ke";
            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataTable);

            return dataTable;
        }

        /// <summary>
        /// Update giá trị mới cho bảng BANG_KE
        /// </summary>
        /// <param name="dataTable"></param>
        public static void UpdateTable(DataTable dataTable)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM bang_ke";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder commandBuider = new MySqlCommandBuilder(adapter);
            adapter.Update(dataTable);
        }

        /// <summary>
        /// Thêm Bảng Kê mới
        /// </summary>
        /// <param name="_phieu"></param>
        /// <returns>Trả về MaBangKE nếu thành công, ngược lại -1</returns>
        public static int Add(BangKe _bangKe)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "INSERT INTO bang_ke(MaPhong, TongChiPhi, TinhTrangThanhToan) VALUES(?, ?, ?)";

            cmd.Parameters.Add("@MaPhong", MySqlDbType.Int32).Value = _bangKe.MaPhong;
            cmd.Parameters.Add("@TongChiPhi", MySqlDbType.Float).Value = _bangKe.TongChiPhi;
            cmd.Parameters.Add("@TinhTrangThanhToan", MySqlDbType.Byte).Value = _bangKe.TinhTrangThanhToan;

            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT @@IDENTITY";
            _bangKe.MaBangKe = (int)cmd.ExecuteScalar();

            return _bangKe.MaBangKe;
        }

        /// <summary>
        /// Xoá một Bảng kê
        /// </summary>
        /// <param name="_maBangKe"></param>
        public static void Delete(int _maBangKe)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "DELETE FROM bang_ke WHERE MaBangKe = ?";

            cmd.Parameters.Add("@MaBangKe", MySqlDbType.Int32).Value = _maBangKe;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Sửa 1 Loại Phòng
        /// </summary>
        /// <param name="_phieu"></param>
        public static void UpdateLoaiPhong(BangKe _bangKe)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE bang_ke SET MaPhong = ?, TongChiPhi = ?, TinhTrangThanhToan = ? WHERE MaBangKe = ?";

            cmd.Parameters.Add("@MaBangKe", MySqlDbType.Int32).Value = _bangKe.MaBangKe;
            cmd.Parameters.Add("@MaPhong", MySqlDbType.Int32).Value = _bangKe.MaPhong;
            cmd.Parameters.Add("@TongChiPhi", MySqlDbType.Float).Value = _bangKe.TongChiPhi;
            cmd.Parameters.Add("@TinhTrangThanhToan", MySqlDbType.Byte).Value = _bangKe.TinhTrangThanhToan;

            cmd.ExecuteNonQuery();
        }


        /// <summary>
        /// Tìm kiêm một Bảng kê thông qua Mã bảng kê
        /// </summary>
        /// <param name="_maLoaiPhong"></param>
        /// <returns></returns>
        public static BangKe Find(int _maBangKe)
        {
            BangKe bangKe = new BangKe();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM bang_ke WHERE MaBangKe = ?";

            cmd.Parameters.Add("@MaBangKe", MySqlDbType.Int32).Value = _maBangKe;

            MySqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                bangKe.MaBangKe = (int)dataReader["MaBangKe"];
                bangKe.MaPhong = (int)dataReader["MaPhong"];
                bangKe.TongChiPhi = (float)dataReader["TongChiPhi"];
                bangKe.TinhTrangThanhToan = (Boolean)dataReader["TinhTrangThanhToan"];
            }

            return bangKe;
        }

    }
}

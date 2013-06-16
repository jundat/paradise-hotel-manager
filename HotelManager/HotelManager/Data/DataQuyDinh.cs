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
    /// Quản lý bảng QUY_DINH
    /// </summary>
    class DataQuyDinh
    {
        /// <summary>
        /// Đặt Số khách tối đa trong một phòng
        /// </summary>
        /// <returns></returns>
        public static int GetSoKhachToiDaTrongMotPhong()
        {
            // Tao chuoi strSQL thao tac CSDL
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT SoKhachToiDaTrongMotPhong FROM quy_dinh WHERE ID = 1";

            MySqlDataReader dataReader = null;

            try
            {
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    return (int)dataReader["SoKhachToiDaTrongMotPhong"];
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetSoKhachToiDaTrongMotPhong QUY_DINH table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return -1;
        }

        /// <summary>
        /// Cập nhật Số khách tối đa trong một phòng
        /// </summary>
        /// <param name="_soKhachToiDaTrongMotPhong"></param>
        public static void UpdateSoKhachToiDaTrongMotPhong(int _soKhachToiDaTrongMotPhong)
        {
            // Tao chuoi strSQL thao tac CSDL
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE quy_dinh SET SoKhachToiDaTrongMotPhong = ? WHERE ID = 1";
            cmd.Parameters.Add("@SoKhachToiDaTrongMotPhong", MySqlDbType.Int32).Value = _soKhachToiDaTrongMotPhong;

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Đặt Tỷ lệ cọc
        /// </summary>
        /// <returns></returns>
        public static float GetTyLeCoc()
        {
            // Tao chuoi strSQL thao tac CSDL
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT TyLeCoc FROM quy_dinh WHERE ID = 1";

            MySqlDataReader dataReader = null;
            
            try
            {
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    return (float)dataReader["TyLeCoc"];
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetTyLeCoc QUY_DINH table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return 0;
        }

        /// <summary>
        /// Cập nhật Tỷ lệ cọc
        /// </summary>
        /// <param name="_tyLeCoc"></param>
        public static void UpdateTyLeCoc(float _tyLeCoc)
        {
            // Tao chuoi strSQL thao tac CSDL
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE quy_dinh SET TyLeCoc = ? WHERE ID = 1";
            cmd.Parameters.Add("@TyLeCoc", MySqlDbType.Float).Value = _tyLeCoc;

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Đặt Số giờ thuê với giá gốc
        /// </summary>
        /// <returns></returns>
        public static int GetSoGioThueVoiGiaGoc()
        {
            // Tao chuoi strSQL thao tac CSDL
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT SoGioThueVoiGiaGoc FROM quy_dinh WHERE ID = 1";

            MySqlDataReader dataReader = null;

            try
            {
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    return (int)dataReader["SoGioThueVoiGiaGoc"];
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetSoGioThueVoiGiaGoc QUY_DINH table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }

            return 0;
        }

        /// <summary>
        /// Cập nhật Số giờ thuê với giá gốc
        /// </summary>
        /// <param name="_soGioThueVoiGiaGoc"></param>
        public static void UpdateSoGioThueVoiGiaGoc(int _soGioThueVoiGiaGoc)
        {
            // Tao chuoi strSQL thao tac CSDL
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE quy_dinh SET SoGioThueVoiGiaGoc = ? WHERE ID = 1";
            cmd.Parameters.Add("@SoGioThueVoiGiaGoc", MySqlDbType.Int32).Value = _soGioThueVoiGiaGoc;

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Đặt Tỷ lệ giá phòng nếu thuê theo ngày
        /// </summary>
        /// <returns></returns>
        public static float GetTyLeGiaPhongNeuThueTheoNgay()
        {
            // Tao chuoi strSQL thao tac CSDL
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT TyLeGiaPhongNeuThueTheoNgay FROM quy_dinh WHERE ID = 1";

            MySqlDataReader dataReader = null;

            try
            {
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    return (float)dataReader["TyLeGiaPhongNeuThueTheoNgay"];
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetTyLeGiaPhongNeuThueTheoNgay QUY_DINH table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }

            return 0;
        }

        /// <summary>
        /// Cập nhật Tỷ lệ giá phòng nếu thuê theo ngày
        /// </summary>
        /// <param name="_tyLeGiaPhongNeuThueTheoNgay"></param>
        public static void UpdateTyLeGiaPhongNeuThueTheoNgay(float _tyLeGiaPhongNeuThueTheoNgay)
        {
            // Tao chuoi strSQL thao tac CSDL
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE quy_dinh SET TyLeGiaPhongNeuThueTheoNgay = ? WHERE ID = 1";
            cmd.Parameters.Add("@TyLeGiaPhongNeuThueTheoNgay", MySqlDbType.Float).Value = _tyLeGiaPhongNeuThueTheoNgay;

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Lấy thông số của quy định thông qua đối tượng quy định
        /// </summary>
        /// <returns></returns>
        public static QuyDinh GetQuyDinh()
        {
            QuyDinh quyDinh = new QuyDinh();

            // Tao chuoi strSQL thao tac CSDL
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM quy_dinh WHERE ID = 1";

            MySqlDataReader dataReader = null;

            try
            {
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    quyDinh.SoKhachToiDaTrongMotPhong = (int)dataReader["SoKhachToiDaTrongMotPhong"];
                    quyDinh.TyLeCoc = (float)dataReader["TyLeCoc"];
                    quyDinh.SoGioThueVoiGiaGoc = (int)dataReader["SoGioThueVoiGiaGoc"];
                    quyDinh.TyLeGiaPhongNeuThueTheoNgay = (float)dataReader["TyLeGiaPhongNeuThueTheoNgay"];
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetQuyDinh QUY_DINH table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }

            return quyDinh;
        }

        /// <summary>
        /// Cập nhật thông số của quy định thông qua đối tượng quy định
        /// </summary>
        /// <param name="_quyDinh"></param>
        public static void UpdateQuyDinh(QuyDinh _quyDinh)
        {
            // Tao chuoi strSQL thao tac CSDL
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE quy_dinh SET SoKhachToiDaTrongMotPhong = ?, TyLeCoc = ?, SoGioThueVoiGiaGoc = ?, TyLeGiaPhongNeuThueTheoNgay = ? WHERE ID = 1";

            cmd.Parameters.Add("@SoKhachToiDaTrongMotPhong", MySqlDbType.Int32).Value = _quyDinh.SoKhachToiDaTrongMotPhong;
            cmd.Parameters.Add("@TyLeCoc", MySqlDbType.Float).Value = _quyDinh.TyLeCoc;
            cmd.Parameters.Add("@SoGioThueVoiGiaGoc", MySqlDbType.Int32).Value = _quyDinh.SoGioThueVoiGiaGoc;
            cmd.Parameters.Add("@TyLeGiaPhongNeuThueTheoNgay", MySqlDbType.Float).Value = _quyDinh.TyLeGiaPhongNeuThueTheoNgay;

            cmd.ExecuteNonQuery();
        }

    }
}

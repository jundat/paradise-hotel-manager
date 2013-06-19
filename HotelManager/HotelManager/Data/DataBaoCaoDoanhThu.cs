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
    /// Thực hiện các thao tác trên bảng BAO_CAO_DOANH_THU
    /// </summary>
    class DataBaoCaoDoanhThu
    {
        /// <summary>
        /// Tìm kiếm các dòng báo cáo của một tháng
        /// </summary>
        /// <returns></returns>
        public static ArrayList FindTheoThangBaoCao(DateTime thang)
        {
            ArrayList listBaoCaoDoanhThu = new ArrayList();
            
            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM BaoCaoDoanhThu WHERE YEAR(ThoiDiemLapBaoCao) = " + thang.Year + " and MONTH(ThoiDiemLapBaoCao) = " + thang.Month;
            MySqlDataReader dataReader = null;

            try
            {
                // Thực thi truy vấn
                dataReader = cmd.ExecuteReader();

                // Lấy dữ liệu trả ra từ truy vấn rồi gán cho baoCaoDoanhThu
                while (dataReader.Read())
                {
                    BaoCaoDoanhThu baoCaoDoanhThu = new BaoCaoDoanhThu();
                    baoCaoDoanhThu.MaBaoCaoDoanhThu = (int)dataReader["MaBaoCaoDoanhThu"];
                    baoCaoDoanhThu.MaPhong = (int)dataReader["MaPhong"];
                    baoCaoDoanhThu.DoanhThu = (float)dataReader["DoanhThu"];
                    baoCaoDoanhThu.TyLeDoanhThu = (int)dataReader["TyLeDoanhThu"];
                    baoCaoDoanhThu.ThoiDiemLapBaoCao = (DateTime)dataReader["ThoiDiemLapBaoCao"];

                    listBaoCaoDoanhThu.Add(baoCaoDoanhThu);
                }

            } catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetList BAO_CAO_DOANH_THU table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            return listBaoCaoDoanhThu;
        }

        /// <summary>
        /// Tìm kiếm tất cả các dòng báo cáo của một phòng theo mã phòng của nó
        /// </summary>
        /// <returns></returns>
        public static ArrayList FindTheoPhong(int maPhong)
        {
            ArrayList listBaoCaoDoanhThu = new ArrayList();

            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM BaoCaoDoanhThu WHERE MaPhong = " + maPhong;
            MySqlDataReader dataReader = null;

            try
            {
                // Thực thi truy vấn
                dataReader = cmd.ExecuteReader();

                // Lấy dữ liệu trả ra từ truy vấn rồi gán cho baoCaoDoanhThu            
                while (dataReader.Read())
                {
                    BaoCaoDoanhThu baoCaoDoanhThu = new BaoCaoDoanhThu();
                    baoCaoDoanhThu.MaBaoCaoDoanhThu = (int)dataReader["MaBaoCaoDoanhThu"];
                    baoCaoDoanhThu.MaPhong = (int)dataReader["MaPhong"];
                    baoCaoDoanhThu.DoanhThu = (float)dataReader["DoanhThu"];
                    baoCaoDoanhThu.TyLeDoanhThu = (int)dataReader["TyLeDoanhThu"];
                    baoCaoDoanhThu.ThoiDiemLapBaoCao = (DateTime)dataReader["ThoiDiemLapBaoCao"];

                    listBaoCaoDoanhThu.Add(baoCaoDoanhThu);
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: FindTheoPhong BAO_CAO_DOANH_THU table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return listBaoCaoDoanhThu;
        }

        /// <summary>
        /// Tìm một dòng báo cáo doanh thu theo maBaoCaoDoanhThu của nó
        /// </summary>
        /// <param name="maBaoCaoDoanhThu"></param>
        /// <returns></returns>
        public static BaoCaoDoanhThu FindMaBaoCaoDoanhThu(int maBaoCaoDoanhThu)
        {
            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM BaoCaoDoanhThu WHERE MaBaoCaoDoanhThu = ?";
            cmd.Parameters.Add("@MaBaoCaoDoanhThu", MySqlDbType.Int32).Value = maBaoCaoDoanhThu;
            MySqlDataReader dataReader = null;
            BaoCaoDoanhThu baoCaoDoanhThu = new BaoCaoDoanhThu();

            try
            {
                // Thực thi truy vấn                
                dataReader = cmd.ExecuteReader();

                // Lấy dữ liệu trả ra từ truy vấn rồi gán cho baoCaoDoanhThu
                if (dataReader.Read())
                {
                    baoCaoDoanhThu.MaBaoCaoDoanhThu = (int)dataReader["MaBaoCaoDoanhThu"];
                    baoCaoDoanhThu.MaPhong = (int)dataReader["MaPhong"];
                    baoCaoDoanhThu.DoanhThu = (float)dataReader["DoanhThu"];
                    baoCaoDoanhThu.TyLeDoanhThu = (int)dataReader["TyLeDoanhThu"];
                    baoCaoDoanhThu.ThoiDiemLapBaoCao = (DateTime)dataReader["ThoiDiemLapBaoCao"];
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: FindMaBaoCaoDoanhThu BAO_CAO_DOANH_THU table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return baoCaoDoanhThu;
        }

        /// <summary>
        /// Thêm một dòng báo cáo doanh thu cho một phòng
        /// </summary>
        /// <param name="thangDuocChon"></param>
        /// <returns>Return MaBaoCaoDoanhThu</returns>
        public static int Add(BaoCaoDoanhThu baoCaoDoanhThu)
        {
            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "INSERT INTO bao_cao_doanh_thu(MaPhong, DoanhThu, TyLeDoanhThu, ThoiDiemLapBaoCao) values(?, ?, ?, ?)";

            cmd.Parameters.Add("@MaPhong", MySqlDbType.Int32).Value = baoCaoDoanhThu.MaPhong;
            cmd.Parameters.Add("@DoanhThu", MySqlDbType.Float).Value = baoCaoDoanhThu.DoanhThu;
            cmd.Parameters.Add("@TyLeDoanhThu", MySqlDbType.Float).Value = baoCaoDoanhThu.TyLeDoanhThu;
            cmd.Parameters.Add("@ThoiDiemLapBaoCao", MySqlDbType.Date).Value = baoCaoDoanhThu.ThoiDiemLapBaoCao;

            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT @@IDENTITY";
            int maBaoCaoDoanhThu = (int)cmd.ExecuteScalar();

            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
            return maBaoCaoDoanhThu;
        }

        /// <summary>
        /// Xóa Một báo cáo dựa vào mã của nó
        /// </summary>
        /// <param name="maBaoCaoDoanhThu"> mã của Báo cáo doanh thu cần xóa</param>
        /// <returns>Return MaBaoCaoDoanhThu</returns>
        public static void DeleteBaoCaoDoanhThu(int maBaoCaoDoanhThu)
        {
            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "DELETE FROM bao_cao_doanh_thu WHERE MaBaoCaoDoanhThu = " + maBaoCaoDoanhThu;
            cmd.ExecuteNonQuery();
            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
        }

        /// <summary>
        /// Xóa tất cả các báo cáo của tháng
        /// </summary>
        /// <param name="thang"> tháng cần xóa </param>
        public static void DeleteBaoCaoDoanhThu(DateTime thang)
        {
            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "DELETE FROM bao_cao_doanh_thu WHERE YEAR(ThoiDiemLapBaoCao) = " + thang.Year + " and MONTH(ThoiDiemLapBaoCao) = " + thang.Month;
            cmd.ExecuteNonQuery();
            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
        }

        /// <summary>
        /// Cập nhật một dong báo cáo doanh thu
        /// </summary>
        /// <param name="baoCaoDoanhThu">thông tin của 1 dòng báo cáo cần cập nhật</param>
        public static void UpdateBaoCaoDoanhThu(BaoCaoDoanhThu baoCaoDoanhThu)
        {
            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE bao_cao_doanh_thu SET MaPhong = ?, DoanhTHu = ?, TyLeDoanhThu = ?, ThoiDiemLapBaoCao = ? WHERE MaBaoCaoDoanhThu = ?";

            // Truyền tham số cho câu truy vấn
            cmd.Parameters.Add("@MaPhong", MySqlDbType.Int32).Value = baoCaoDoanhThu.MaPhong;
            cmd.Parameters.Add("@DoanhThu", MySqlDbType.Float).Value = baoCaoDoanhThu.DoanhThu;
            cmd.Parameters.Add("@TyLeDoanhThu", MySqlDbType.Float).Value = baoCaoDoanhThu.TyLeDoanhThu;
            cmd.Parameters.Add("@ThoiDiemLapBaoCao", MySqlDbType.Date).Value = baoCaoDoanhThu.ThoiDiemLapBaoCao;
            cmd.Parameters.Add("@MaBaoCaoDoanhThu", MySqlDbType.Int32).Value = baoCaoDoanhThu.MaBaoCaoDoanhThu;

            // Thực thi truy vấn
            cmd.ExecuteNonQuery();
            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
        }

    }
}

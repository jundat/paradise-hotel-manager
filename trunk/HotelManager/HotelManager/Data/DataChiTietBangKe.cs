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
    class DataChiTietChiTietBangKe
    {
        /// <summary>
        /// Lấy danh sách các Chi Tiết Bảng Kê dưới dạng List
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
                cmd.CommandText = "SELECT * FROM chi_tiet_bang_ke";
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    ChiTietBangKe _chiTietBangKe = new ChiTietBangKe();

                    _chiTietBangKe.MaChiTietBangKe = (int)dataReader["MaChiTietBangKe"];
                    _chiTietBangKe.MaBangKe = (int)dataReader["MaBangKe"];
                    _chiTietBangKe.TenDichVu = (String)dataReader["TenDichVu"];
                    _chiTietBangKe.ThoiDiemGoi = (DateTime)dataReader["ThoiDiemGoi"];
                    _chiTietBangKe.DonGia = (float)dataReader["DonGia"];
                    _chiTietBangKe.SoLuong = (int)dataReader["SoLuong"];
                    _chiTietBangKe.GhiChu = (String)dataReader["GhiChu"];

                    _arrayList.Add(_chiTietBangKe);
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetList CHI_TIET_BANG_KE table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Lấy hết bảng chi_tiet_bang_ke
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM chi_tiet_bang_ke";
            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataTable);

            return dataTable;
        }

        /// <summary>
        /// Update giá trị mới cho bảng chi_tiet_bang_ke
        /// </summary>
        /// <param name="dataTable"></param>
        public static void UpdateTable(DataTable dataTable)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM chi_tiet_bang_ke";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder commandBuider = new MySqlCommandBuilder(adapter);
            adapter.Update(dataTable);
        }

        /// <summary>
        /// Thêm Bảng Kê mới
        /// </summary>
        /// <param name="_phieu"></param>
        /// <returns>Trả về MaChiTietBangKe nếu thành công, ngược lại -1</returns>
        public static int Add(ChiTietBangKe _chiTietBangKe)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "INSERT INTO chi_tiet_bang_ke(MaPhong, TongChiPhi, TinhTrangThanhToan) VALUES(?, ?, ?)";

            cmd.Parameters.Add("@MaBangKe", MySqlDbType.Int32).Value = _chiTietBangKe.MaBangKe;
            cmd.Parameters.Add("@TenDichVu", MySqlDbType.String).Value = _chiTietBangKe.TenDichVu;
            cmd.Parameters.Add("@ThoiDiemGoi", MySqlDbType.Date).Value = _chiTietBangKe.ThoiDiemGoi;
            cmd.Parameters.Add("@DonGia", MySqlDbType.Float).Value = _chiTietBangKe.DonGia;
            cmd.Parameters.Add("@SoLuong", MySqlDbType.Int32).Value = _chiTietBangKe.SoLuong;
            cmd.Parameters.Add("@GhiChu", MySqlDbType.String).Value = _chiTietBangKe.GhiChu;

            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT @@IDENTITY";
            _chiTietBangKe.MaChiTietBangKe = (int)cmd.ExecuteScalar();

            return _chiTietBangKe.MaChiTietBangKe;
        }

        /// <summary>
        /// Xoá một Bảng kê
        /// </summary>
        /// <param name="_maChiTietBangKe"></param>
        public static void Delete(int _maChiTietBangKe)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "DELETE FROM chi_tiet_bang_ke WHERE MaChiTietBangKe = ?";

            cmd.Parameters.Add("@MaChiTietBangKe", MySqlDbType.Int32).Value = _maChiTietBangKe;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Sửa 1 Loại Phòng
        /// </summary>
        /// <param name="_phieu"></param>
        public static void UpdateChiTietBangKe(ChiTietBangKe _chiTietBangKe)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE chi_tiet_bang_ke SET MaBangKe = ?, TenDichVu = ?, ThoiDiemGoi = ?, DonGia = ?, SoLuong = ?, GhiChu = ? WHERE MaChiTietBangKe = ?";

            cmd.Parameters.Add("@MaChiTietBangKe", MySqlDbType.Int32).Value = _chiTietBangKe.MaChiTietBangKe;
            cmd.Parameters.Add("@MaBangKe", MySqlDbType.Int32).Value = _chiTietBangKe.MaBangKe;
            cmd.Parameters.Add("@TenDichVu", MySqlDbType.String).Value = _chiTietBangKe.TenDichVu;
            cmd.Parameters.Add("@ThoiDiemGoi", MySqlDbType.Date).Value = _chiTietBangKe.ThoiDiemGoi;
            cmd.Parameters.Add("@DonGia", MySqlDbType.Float).Value = _chiTietBangKe.DonGia;
            cmd.Parameters.Add("@SoLuong", MySqlDbType.Int32).Value = _chiTietBangKe.SoLuong;
            cmd.Parameters.Add("@GhiChu", MySqlDbType.String).Value = _chiTietBangKe.GhiChu;

            cmd.ExecuteNonQuery();
        }


        /// <summary>
        /// Tìm kiêm một Bảng kê thông qua Mã Chi Tiết bảng kê
        /// </summary>
        /// <param name="_maLoaiPhong"></param>
        /// <returns></returns>
        public static ChiTietBangKe Find(int _maChiTietBangKe)
        {
            ChiTietBangKe ChiTietBangKe = new ChiTietBangKe();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM chi_tiet_bang_ke WHERE MaChiTietBangKe = ?";

            cmd.Parameters.Add("@MaChiTietBangKe", MySqlDbType.Int32).Value = _maChiTietBangKe;

            MySqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                ChiTietBangKe.MaChiTietBangKe = (int)dataReader["MaChiTietBangKe"];
                ChiTietBangKe.MaBangKe = (int)dataReader["MaBangKe"];
                ChiTietBangKe.TenDichVu = (String)dataReader["TenDichVu"];
                ChiTietBangKe.ThoiDiemGoi = (DateTime)dataReader["ThoiDiemGoi"];
                ChiTietBangKe.DonGia = (float)dataReader["DonGia"];
                ChiTietBangKe.SoLuong = (int)dataReader["SoLuong"];
                ChiTietBangKe.GhiChu = (String)dataReader["GhiChu"];
            }

            return ChiTietBangKe;
        }

    }
}

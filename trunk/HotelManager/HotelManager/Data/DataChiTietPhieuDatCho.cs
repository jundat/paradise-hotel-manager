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
    /// Thao tác với bảng CHI_TIẾT_PHIẾU_ĐẶT_CHỖ
    /// </summary>
    class DataChiTietPhieuDatCho
    {
        /// <summary>
        /// Lấy bảng CHI_TIET_PHIEU_DAT_CHO
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM chi_tiet_phieu_dat_cho";
            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataTable);

            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
            return dataTable;
        }

        /// <summary>
        /// update dữ liệu mới
        /// </summary>
        /// <param name="dt"></param>
        public static void UpdateTable(DataTable dataTable)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM chi_tiet_phieu_dat_cho";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            MySqlCommandBuilder commandBuider = new MySqlCommandBuilder(adapter);

            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
            adapter.Update(dataTable);
        }

        /// <summary>
        /// Lấy list các CHI_TIET_PHIEU_DAT_CHO
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetList()
        {
            ArrayList _arrayList = new ArrayList();

            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM chi_tiet_phieu_dat_cho";

            MySqlDataReader dataReader = null;

            try
            {
                // Thực thi truy vấn
                dataReader = cmd.ExecuteReader();

                // Lấy dữ liệu trả ra từ truy vấn rồi gán cho baoCaoDoanhThu
                while (dataReader.Read())
                {
                    ChiTietPhieuDatCho _chiTietPhieuDatCho = new ChiTietPhieuDatCho();

                    _chiTietPhieuDatCho.MaChiTietPhieuDatCho = (int)dataReader["MaChiTietPhieuDatCho"];
                    _chiTietPhieuDatCho.MaPhieuDatCho = (int)dataReader["MaPhieuDatCho"];
                    _chiTietPhieuDatCho.MaPhong = (int)dataReader["MaPhong"];
                    _chiTietPhieuDatCho.DonGia = (float)dataReader["DonGia"];
                    _chiTietPhieuDatCho.Coc = (float)dataReader["Coc"];

                    _arrayList.Add(_chiTietPhieuDatCho);
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetList CHI_TIET_PHIEU_DAT_CHO table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return _arrayList;
        }

        /// <summary>
        /// Tìm danh sách phiếu đặt chỗ của phiếu đặt chỗ có mã đưa vô
        /// </summary>
        /// <param name="maPhieuDatCho"> Mã phiếu đặt chỗ cần tìm chi tiết </param>
        /// <returns></returns>
        public static ArrayList FindĐanhSachChiTiet(int maPhieuDatCho)
        {
            ArrayList _arrayList = new ArrayList();

            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            
            cmd.CommandText = "SELECT * FROM chi_tiet_phieu_dat_cho WHERE MaPhieuDatCho = ?MaPhieuDatCho";
            cmd.Parameters.Add("?MaPhieuDatCho", maPhieuDatCho);


            MySqlDataReader dataReader = null;

            try
            {
                // Thực thi truy vấn
                dataReader = cmd.ExecuteReader();

                // Lấy dữ liệu trả ra từ truy vấn rồi gán cho baoCaoDoanhThu
                while (dataReader.Read())
                {
                    ChiTietPhieuDatCho _chiTietPhieuDatCho = new ChiTietPhieuDatCho();

                    _chiTietPhieuDatCho.MaChiTietPhieuDatCho = (int)dataReader["MaChiTietPhieuDatCho"];
                    _chiTietPhieuDatCho.MaPhieuDatCho = (int)dataReader["MaPhieuDatCho"];
                    _chiTietPhieuDatCho.MaPhong = (int)dataReader["MaPhong"];
                    _chiTietPhieuDatCho.DonGia = (float)dataReader["DonGia"];
                    _chiTietPhieuDatCho.Coc = (float)dataReader["Coc"];

                    _arrayList.Add(_chiTietPhieuDatCho);
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetList CHI_TIET_PHIEU_DAT_CHO table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return _arrayList;
        }

        /// <summary>
        /// Thêm chi tiết phiếu đặt tiệc vào bảng CHI_TIET_PHIEU_DAT_CHO
        /// </summary>
        /// <param name="_chiTietPhieuDatCho"></param>
        public static void Add(ChiTietPhieuDatCho _chiTietPhieuDatCho)
        {
            // Chuẩn bị kết nối
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "INSERT INTO chi_tiet_pheu_dat_cho(MaPhieuDatCho, MaPhong, DonGia, Coc) VALUES(?MaPhieuDatCho, ?MaPhong, ?DonGia, ?Coc)";
            cmd.Prepare();

            // Tryền tham số cho truy vấn
            cmd.Parameters.Add("?MaPhieuDatCho", MySqlDbType.Int32).Value = _chiTietPhieuDatCho.MaPhieuDatCho;
            cmd.Parameters.Add("?MaPhong", MySqlDbType.Int32).Value = _chiTietPhieuDatCho.MaPhong;
            cmd.Parameters.Add("?DonGia", MySqlDbType.Float).Value = _chiTietPhieuDatCho.DonGia;
            cmd.Parameters.Add("?Coc", MySqlDbType.Float).Value = _chiTietPhieuDatCho.Coc;

            // Thực hiện truy vấn
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Select @@IDENTITY";
            _chiTietPhieuDatCho.MaChiTietPhieuDatCho = Convert.ToInt32(cmd.ExecuteScalar());

            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
        }

        /// <summary>
        /// Xoá chi tiết phiếu thuê đặt chỗ
        /// </summary>
        /// <param name="_maChiTietPhieuDatCho"></param>
        public static void Delete(int _maChiTietPhieuDatCho)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "DELETE FROM chi_tiet_phieu_dat_cho WHERE MaChiTietPhieuDatCho = " + _maChiTietPhieuDatCho;
            cmd.ExecuteNonQuery();
            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
        }

        public static void DeleteCTPDC(int maphieudatcho)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "DELETE FROM chi_tiet_pheu_dat_cho WHERE MaPhieuDatCho = " + maphieudatcho;
            cmd.ExecuteNonQuery();
            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
        }
        /// <summary>
        /// Sửa 1 chi tiết phiếu thuê
        /// </summary>
        /// <param name="_chiTietPhieuDatCho"></param>
        public static void UpdateChiTietPhieuDatCho(ChiTietPhieuDatCho _chiTietPhieuDatCho)
        {
            // Chuẩn bị kết nối
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE chi_tiet_phieu_dat_cho SET MaPhieuDatCho = ?, MaPhong = ?, DonGia = ?, Coc = ? WHERE MaChiTietPhieuDatCho = ?";
            
            // Truyền tham số cho truy vấn
            cmd.Parameters.Add("@MaChiTietPhieuDatCho", MySqlDbType.Int32).Value = _chiTietPhieuDatCho.MaChiTietPhieuDatCho;
            cmd.Parameters.Add("@MaPhieuDatCho", MySqlDbType.Int32).Value = _chiTietPhieuDatCho.MaPhieuDatCho;
            cmd.Parameters.Add("@MaPhong", MySqlDbType.Int32).Value = _chiTietPhieuDatCho.MaPhong;
            cmd.Parameters.Add("@DonGia", MySqlDbType.Float).Value = _chiTietPhieuDatCho.DonGia;
            cmd.Parameters.Add("@Coc", MySqlDbType.Float).Value = _chiTietPhieuDatCho.Coc;

            // Thực thi truy vấn
            cmd.ExecuteNonQuery();
            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
        }

    }
}

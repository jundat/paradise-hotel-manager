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
    /// Thao tác với bảng phiếu đặt chỗ
    /// </summary>
    class DataPhieuDatCho
    {
        /// <summary>
        /// Lấy danh sách PHIEU_DAT_CHO
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetList()
        {
            ArrayList _arrayList = new ArrayList();

            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM phieu_dat_cho";

            MySqlDataReader dataReader = null;

            try
            {
                // Thực thi truy vấn
                dataReader = cmd.ExecuteReader();

                // Lấy dữ liệu trả ra từ truy vấn rồi gán cho baoCaoDoanhThu
                while (dataReader.Read())
                {
                    PhieuDatCho _phieuDatCho = new PhieuDatCho();

                    _phieuDatCho.MaPhieuDatCho = (int)dataReader["MaPhieuDatCho"];
                    _phieuDatCho.TenNguoiDatCho = (String)dataReader["TenNguoiDatCho"];
                    _phieuDatCho.CMND = (String)dataReader["CMND"];
                    _phieuDatCho.SDT = (String)dataReader["SDT"];
                    _phieuDatCho.DiaChi = (String)dataReader["DiaChi"];
                    _phieuDatCho.TongCoc = (float)dataReader["TongCoc"];
                    _phieuDatCho.ThoiDiemDat = (DateTime)dataReader["ThoiDiemDat"];
                    _phieuDatCho.ThoiDiemDen = (DateTime)dataReader["ThoiDiemDen"];
                    _phieuDatCho.ThoiDiemDi = (DateTime)dataReader["ThoiDiemDi"];

                    _arrayList.Add(_phieuDatCho);
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
            return _arrayList;
        }

        /// <summary>
        /// Lấy danh sách PHIEU_DAT_CHO
        /// </summary>
        /// <returns></returns>
        public static ArrayList Find(String tenNguoiDatCho, String CMND, String SDT, String diaChi)
        {
            ArrayList _arrayList = new ArrayList();

            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            
            cmd.CommandText = "SELECT * FROM phieu_dat_cho WHERE TenNguoiDatCho = ?TenNguoiDatCho OR CMND = ?CMND OR SDT = ?SDT OR DiaChi = ?DiaChi";

            cmd.Parameters.Add("?TenNguoiDatCho", tenNguoiDatCho);
            cmd.Parameters.Add("?CMND", CMND);
            cmd.Parameters.Add("?SDT", SDT);
            cmd.Parameters.Add("?DiaChi", diaChi);

            MySqlDataReader dataReader = null;

            try
            {
                // Thực thi truy vấn
                dataReader = cmd.ExecuteReader();

                // Lấy dữ liệu trả ra từ truy vấn rồi gán cho baoCaoDoanhThu
                while (dataReader.Read())
                {
                    PhieuDatCho _phieuDatCho = new PhieuDatCho();

                    _phieuDatCho.MaPhieuDatCho = (int)dataReader["MaPhieuDatCho"];
                    _phieuDatCho.TenNguoiDatCho = (String)dataReader["TenNguoiDatCho"];
                    _phieuDatCho.CMND = (String)dataReader["CMND"];
                    _phieuDatCho.SDT = (String)dataReader["SDT"];
                    _phieuDatCho.DiaChi = (String)dataReader["DiaChi"];
                    _phieuDatCho.TongCoc = (float)dataReader["TongCoc"];
                    _phieuDatCho.ThoiDiemDat = (DateTime)dataReader["ThoiDiemDat"];
                    _phieuDatCho.ThoiDiemDen = (DateTime)dataReader["ThoiDiemDen"];
                    _phieuDatCho.ThoiDiemDi = (DateTime)dataReader["ThoiDiemDi"];

                    _arrayList.Add(_phieuDatCho);
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
            return _arrayList;
        }
        /// <summary>
        /// Lấy hết bảng PHIEU_DAT_CHO
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM phieu_dat_cho";
            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataTable);

            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
            return dataTable;
        }

        /// <summary>
        /// UpdatePhieuDatCho giá trị mới cho bảng PHIEU_DAT_CHO
        /// </summary>
        /// <param name="dataTable"></param>
        public static void UpdateTable(DataTable dataTable)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM phieu_dat_cho";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            MySqlCommandBuilder commandBuider = new MySqlCommandBuilder(adapter);

            adapter.Update(dataTable);
            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
        }

        /// <summary>
        /// Thêm phiếu đặt chỗ đặt chỗ
        /// </summary>
        /// <param name="_phieu"></param>
        /// <returns>Trả về MaPhieuDatCho nếu thành công, ngược lại -1</returns>
        public static int Add(PhieuDatCho _phieuDatCho)
        {
            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "INSERT INTO phieu_dat_cho(TenNguoiDatCho, SDT, DiaChi, TongCoc, ThoiDiemDat, ThoiDiemDen, ThoiDiemDi) VALUES(?TenNguoiDatCho, ?SDT, ?DiaChi, ?TongCoc, ?ThoiDiemDat, ?ThoiDiemDen, ?ThoiDiemDi)";

            cmd.Parameters.Add("?TenNguoiDatCho", MySqlDbType.String).Value = _phieuDatCho.TenNguoiDatCho;
            cmd.Parameters.Add("?SDT", MySqlDbType.String).Value = _phieuDatCho.SDT;
            cmd.Parameters.Add("?DiaChi", MySqlDbType.String).Value = _phieuDatCho.DiaChi;
            cmd.Parameters.Add("?TongCoc", MySqlDbType.Float).Value = _phieuDatCho.TongCoc;
            cmd.Parameters.Add("?ThoiDiemDat", MySqlDbType.Date).Value = _phieuDatCho.ThoiDiemDat;
            cmd.Parameters.Add("?ThoiDiemDen", MySqlDbType.Date).Value = _phieuDatCho.ThoiDiemDen;
            cmd.Parameters.Add("?ThoiDiemDi", MySqlDbType.Date).Value = _phieuDatCho.ThoiDiemDi;

            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT @@IDENTITY";
            _phieuDatCho.MaPhieuDatCho = Convert.ToInt32(cmd.ExecuteScalar());

            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
            return _phieuDatCho.MaPhieuDatCho;
        }

        /// <summary>
        /// Xoá phiếu đặt chỗ phòng với MaPhieuDatCho
        /// </summary>
        /// <param name="_maPhieuDatCho"></param>
        public static void Delete(int _maPhieuDatCho)
        {
            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "DELETE FROM phieu_dat_cho WHERE MaPhieuDatCho = ?maphieudatcho";
            cmd.Parameters.Add("?maphieudatcho", _maPhieuDatCho);
            cmd.ExecuteNonQuery();
            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
        }

        public static void DeleteSDT(String sdt)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "DELETE FROM phieu_dat_cho WHERE SDT = ?sdt";
            cmd.Parameters.Add("?sdt", MySqlDbType.Int32).Value = sdt;
            cmd.ExecuteNonQuery();
            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
        }
        /// <summary>
        /// Sửa 1 phiếu đặt chỗ
        /// </summary>
        /// <param name="_phieu"></param>
        public static void UpdatePhieuDatCho(PhieuDatCho _phieuDatCho)
        {
            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE phieu_dat_cho SET TenNguoiDatCho = ?TenNguoiDatCho, SDT = ?SDT, DiaChi = ?DiaChi, TongCoc = ?TongCoc, ThoiDiemDat = ?ThoiDiemDat, ThoiDiemDen = ?ThoiDiemDen, ThoiDiemDi = ?ThoiDiemDi WHERE MaPhieuDatCho = ?MaPhieuDatCho";

            // truyền tham số cho truy vấn
            cmd.Parameters.Add("?MaPhieuDatCho", MySqlDbType.Int32).Value = _phieuDatCho.MaPhieuDatCho;
            cmd.Parameters.Add("?TenNguoiDatCho", MySqlDbType.String).Value = _phieuDatCho.TenNguoiDatCho;
            cmd.Parameters.Add("?SDT", MySqlDbType.String).Value = _phieuDatCho.SDT;
            cmd.Parameters.Add("?DiaChi", MySqlDbType.String).Value = _phieuDatCho.DiaChi;
            cmd.Parameters.Add("?TongCoc", MySqlDbType.Float).Value = _phieuDatCho.TongCoc;
            cmd.Parameters.Add("?ThoiDiemDat", MySqlDbType.Date).Value = _phieuDatCho.ThoiDiemDat;
            cmd.Parameters.Add("?ThoiDiemDen", MySqlDbType.Date).Value = _phieuDatCho.ThoiDiemDen;
            cmd.Parameters.Add("?ThoiDiemDi", MySqlDbType.Date).Value = _phieuDatCho.ThoiDiemDi;

            cmd.ExecuteNonQuery();
            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
        }

        /// <summary>
        /// Tìm kiếm phiếu đặt chỗ theo Mã phiếu đặt chỗ
        /// </summary>
        /// <param name="_maPhieuDatCho"></param>
        /// <returns></returns>
        public static PhieuDatCho Find(int _maPhieuDatCho)
        {
            PhieuDatCho phieuDatCho = new PhieuDatCho();

            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM PhieuDatChoPHONG WHERE MaPhieuDatCho = ?";

            cmd.Parameters.Add("@MaPhieuDatCho", MySqlDbType.Int32).Value = _maPhieuDatCho;

            MySqlDataReader dataReader = null;

            try
            {
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    phieuDatCho.MaPhieuDatCho = (int)dataReader["MaPhieuDatCho"];
                    phieuDatCho.TenNguoiDatCho = (String)dataReader["TenNguoiDatCho"];
                    phieuDatCho.SDT = (String)dataReader["SDT"];
                    phieuDatCho.DiaChi = (String)dataReader["DiaChi"];
                    phieuDatCho.TongCoc = (float)dataReader["TongCoc"];
                    phieuDatCho.ThoiDiemDat = (DateTime)dataReader["ThoiDiemDat"];
                    phieuDatCho.ThoiDiemDen = (DateTime)dataReader["ThoiDiemDen"];
                    phieuDatCho.ThoiDiemDi = (DateTime)dataReader["ThoiDiemDi"];
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: Find PHIEU_DAT_CHO table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return phieuDatCho;
        }

        public static PhieuDatCho FindTheoSDT(String _SDT)
        {
            PhieuDatCho phieuDatCho = new PhieuDatCho();

            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM phieu_dat_cho WHERE SDT = ?SDT";

            cmd.Parameters.Add("?SDT", _SDT);

            MySqlDataReader dataReader = null;

            try
            {
                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    phieuDatCho.MaPhieuDatCho = (int)dataReader["MaPhieuDatCho"];
                    phieuDatCho.TenNguoiDatCho = (String)dataReader["TenNguoiDatCho"];
                    phieuDatCho.SDT = (String)dataReader["SDT"];
                    phieuDatCho.DiaChi = (String)dataReader["DiaChi"];
                    phieuDatCho.TongCoc = (float)dataReader["TongCoc"];
                    phieuDatCho.ThoiDiemDat = (DateTime)dataReader["ThoiDiemDat"];
                    phieuDatCho.ThoiDiemDen = (DateTime)dataReader["ThoiDiemDen"];
                    phieuDatCho.ThoiDiemDi = (DateTime)dataReader["ThoiDiemDi"];
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: Find PHIEU_DAT_CHO table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return phieuDatCho;
        }

        //Phan them vao
        public static PhieuDatCho GetPhieudatcho(String _tenphong)
        {
            PhieuDatCho phieudatcho = new PhieuDatCho();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "select * from PHIEU_DAT_CHO where PHIEU_DAT_CHO.MaPhieuDatCho = " +
                              "(select PHIEU_DAT_CHO.MaPhieuDatCho from PHIEU_DAT_CHO,CHI_TIET_PHEU_DAT_CHO,PHONG where PHIEU_DAT_CHO.MaPhieuDatCho = CHI_TIET_PHEU_DAT_CHO.MaPhieuDatCho " +
                              "and CHI_TIET_PHEU_DAT_CHO.MaPhong = PHONG.MaPhong and PHONG.TenPhong = ?_tenphong)";

            cmd.Parameters.Add("?_tenphong", _tenphong);

            MySqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                phieudatcho.MaPhieuDatCho = (int)dataReader["MaPhieuDatCho"];
                phieudatcho.TenNguoiDatCho = (String)dataReader["TenNguoiDatCho"];
                phieudatcho.SDT = (String)dataReader["SDT"];
                phieudatcho.ThoiDiemDat = (DateTime)(dataReader["ThoiDiemDat"]);
                phieudatcho.ThoiDiemDen = (DateTime)(dataReader["ThoiDiemDen"]);
                phieudatcho.ThoiDiemDi = (DateTime)(dataReader["ThoiDiemDi"]);
                phieudatcho.TongCoc = (float)(dataReader["TongCoc"]);
            }
            DataProvider.getInstance().CloseConnection();
            return phieudatcho;
        }

    }
}

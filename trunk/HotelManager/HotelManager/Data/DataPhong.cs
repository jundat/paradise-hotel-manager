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
        public static bool AddPhong(Phong phong)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "INSERT INTO phong(MaLoaiPhong, TenPhong, TinhTrangHienTai, MoTa)"
                + "VALUES(" + phong.MaLoaiPhong
                + ", \'" + phong.TenPhong + "\'"
                + ", " + Convert.ToByte(phong.TinhTrangHienTai)
                + ", \'" + phong.MoTa + "\'"
                + ");";
            
            try
            {
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
        public static void UpdatePhong(Phong phong)
        {
            // Lấy và chuẩn bị command cho truy vấn
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE phong SET MaLoaiPhong = ?maloaiphong, TinhTrangHienTai = ?tinhtranghientai, MoTa = ?mota  WHERE MaPhong = ?_maphong";

            // Truyền tham số cho câu truy vấn
            cmd.Parameters.Add("?maloaiphong", MySqlDbType.Int32).Value = phong.MaLoaiPhong;
            cmd.Parameters.Add("?tinhtranghientai", MySqlDbType.Byte).Value = phong.TinhTrangHienTai;
            cmd.Parameters.Add("?mota", MySqlDbType.String).Value = phong.MoTa;
            cmd.Parameters.Add("?_maphong", MySqlDbType.Int32).Value = phong.MaPhong;

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
            cmd.CommandText = "SELECT * FROM phong WHERE MaPhong = ?MaPhong";

            cmd.Parameters.Add("@MaPhong", _maPhong);

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
        /// Tìm kiếm 1 phòng thông qua TenPhong
        /// </summary>
        /// <param name="_tenPhong"></param>
        /// <returns>Phong</returns>
        public static Phong FindTheoTenPhong(String _tenPhong)
        {
            
            Phong phong = new Phong();

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
            cmd.CommandText = "SELECT * FROM phong WHERE TinhTrangHienTai = ?TinhTrangHienTai";
            cmd.Parameters.Add("?TinhTrangHienTai", MySqlDbType.Byte).Value = _tinhTrang;
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

        //Phan them vao

        public static DataTable LayPhongTrongTheoTenloaiPhong(String tenloaiphong, Boolean _tinhtrang, DateTime _thoidiemden, DateTime _thoidiemdi)
        {
            DataTable datatable = new DataTable();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "select TenPhong,LOAI_PHONG.DonGia from PHONG,LOAI_PHONG" +
                     " where TinhTrangHienTai = ?_tinhtrang and PHONG.MaLoaiPhong = LOAI_PHONG.MaLoaiPhong and LOAI_PHONG.TenLoaiPhong = ?tenloaiphong and TenPhong != ALL(select TenPhong from PHONG,CHI_TIET_PHIEU_DAT_CHO,PHIEU_DAT_CHO" +
                     " where PHONG.MaPhong = CHI_TIET_PHIEU_DAT_CHO.MaPhong" +
                    " and CHI_TIET_PHIEU_DAT_CHO.MaPhieuDatCho = PHIEU_DAT_CHO.MaPhieuDatCho " +
                   " and PHIEU_DAT_CHO.ThoiDiemDen between ?thoidiemden and ?thoidiemdi" +
                    " and PHIEU_DAT_CHO.ThoiDiemDi between ?thoidiemden and ?thoidiemdi )";

            cmd.Parameters.Add("?_tinhtrang", _tinhtrang);
            cmd.Parameters.Add("?thoidiemden", _thoidiemden);
            cmd.Parameters.Add("?thoidiemdi", _thoidiemdi);
            cmd.Parameters.Add("?tenloaiphong", tenloaiphong);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(datatable);
            DataProvider.getInstance().CloseConnection();
            return datatable;
        }

        public static DataTable Timphongtheothoidiem(DateTime _thoidiemden, DateTime _thoidiemdi, Boolean _tinhtrang)
        {
            DataTable datatable = new DataTable();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "select TenPhong,LOAI_PHONG.DonGia,TenLoaiPhong from PHONG,LOAI_PHONG" +
                     " where TinhTrangHienTai = ?_tinhtrang and PHONG.MaLoaiPhong = LOAI_PHONG.MaLoaiPhong and TenPhong != ALL(select TenPhong from PHONG,CHI_TIET_PHIEU_DAT_CHO,PHIEU_DAT_CHO" +
                     " where PHONG.MaPhong = CHI_TIET_PHIEU_DAT_CHO.MaPhong" +
                    " and CHI_TIET_PHIEU_DAT_CHO.MaPhieuDatCho = PHIEU_DAT_CHO.MaPhieuDatCho " +
                   " and PHIEU_DAT_CHO.ThoiDiemDen between ?thoidiemden and ?thoidiemdi" +
                    " and PHIEU_DAT_CHO.ThoiDiemDi between ?thoidiemden and ?thoidiemdi )";

            cmd.Parameters.Add("?_tinhtrang", _tinhtrang);
            cmd.Parameters.Add("?thoidiemden", _thoidiemden);
            cmd.Parameters.Add("?thoidiemdi", _thoidiemdi);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(datatable);
            DataProvider.getInstance().CloseConnection();
            return datatable;


        }

        public static DataTable GetPhongtrongchothue(bool tinhtrang)
        {
            DataTable dataTable = new DataTable();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT TenPhong,TenLoaiPhong,loai_phong.DonGia FROM phong,loai_phong WHERE phong.MaLoaiPhong = loai_phong.MaLoaiPhong and phong.TinhTrangHienTai = ?tt";
            cmd.Parameters.Add("?tt", tinhtrang);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataTable);

            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
            return dataTable;
        }

        public static DataTable GetPhongDaDat(String _tennguoidat, String _SDT)
        {
            DataTable datatable = new DataTable();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "select TenPhong,TenLoaiPhong,LOAI_PHONG.DonGia,Coc from PHONG,LOAI_PHONG,PHIEU_DAT_CHO,CHI_TIET_PHIEU_DAT_CHO"
                + " where PHIEU_DAT_CHO.TenNguoiDatCho = ?_tennguoidat and PHIEU_DAT_CHO.SDT = ?_SDT " +
                "and PHIEU_DAT_CHO.MaPhieuDatCho = CHI_TIET_PHIEU_DAT_CHO.MaPhieuDatCho and CHI_TIET_PHIEU_DAT_CHO.MaPhong = PHONG.MaPhong "
                + "and PHONG.MaLoaiPhong = LOAI_PHONG.MaLoaiPhong";

            cmd.Parameters.Add("?_tennguoidat", _tennguoidat);
            cmd.Parameters.Add("?_SDT", _SDT);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(datatable);
            DataProvider.getInstance().CloseConnection();
            return datatable;
        }

        public static DataTable layphongtrongtheoloaiphong(String tenloaiphong)
        {
            DataTable datatable = new DataTable();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT TenPhong,TenLoaiPhong,loai_phong.DonGia FROM phong,loai_phong WHERE phong.MaLoaiPhong = loai_phong.MaLoaiPhong and loai_phong.TenLoaiPhong = ?tt and phong.TinhTrangHienTai = ?ttht";
            cmd.Parameters.Add("?tt", tenloaiphong);
            cmd.Parameters.Add("?ttht", false);


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(datatable);
            DataProvider.getInstance().CloseConnection();
            return datatable;
        }

        /// <summary>
        /// Xác nhận thuộc tính Tình trạng phòng là còn trống (do trả phòng)
        /// </summary>
        /// <param name="MaPhong"></param>
        public static void TraPhong(int MaPhong)
        {
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = "UPDATE phong SET TinhTrangHienTai = ?TinhTrangHienTai WHERE MaPhong = ?MaPhong";

            ObjCmd.Parameters.Add("?MaPhong", MaPhong);
            ObjCmd.Parameters.Add("?TinhTrangHienTai", true); // true là đang trống

            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();
        }
    }
}

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
    class DataChiTietPhieuDen
    {
        public static ArrayList GetList(int maPhieuDen)
        {
            ArrayList listCTPhieuDen = new ArrayList();
            string StrSQL = "SELECT * FROM chi_tiet_phieu_den WHERE MaPhieuDen = " + maPhieuDen;
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;
            MySqlDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                ChiTietPhieuDen ct_PhieuDen = new ChiTietPhieuDen();

                ct_PhieuDen.MaChiTietPhieuDen = (int)ObjReader["MaChiTietPhieuDen"];
                ct_PhieuDen.MaPhieuDen = maPhieuDen; // (int)ObjReader["MaPhieuDen"];
                ct_PhieuDen.MaPhong = (int)ObjReader["MaPhong"];
                ct_PhieuDen.TenKhachHang = (string)ObjReader["TenKhachHang"];
                ct_PhieuDen.CMND = (string)ObjReader["CMND"];
                ct_PhieuDen.DonGia = (float)ObjReader["DonGia"];

                listCTPhieuDen.Add(ct_PhieuDen);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listCTPhieuDen;
        }

        public static ArrayList GetList()
        {
            ArrayList listCTPhieuDen = new ArrayList();
            string StrSQL = "SELECT * FROM chi_tiet_phieu_den";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;
            MySqlDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                ChiTietPhieuDen ct_PhieuDen = new ChiTietPhieuDen();

                ct_PhieuDen.MaChiTietPhieuDen = (int)ObjReader["MaChiTietPhieuDen"];
                ct_PhieuDen.MaPhieuDen = (int)ObjReader["MaPhieuDen"];
                ct_PhieuDen.MaPhong = (int)ObjReader["MaPhong"];
                ct_PhieuDen.TenKhachHang = (string)ObjReader["TenKhachHang"];
                ct_PhieuDen.CMND = (string)ObjReader["CMND"];
                ct_PhieuDen.DonGia = (float)ObjReader["DonGia"];

                listCTPhieuDen.Add(ct_PhieuDen);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listCTPhieuDen;
        }

        public static DataTable GetTable()
        {
            DataTable table = new DataTable();
            string StrSQL = "SELECT * FROM chi_tiet_phieu_den";
            MySqlDataAdapter ObjAdapter = new MySqlDataAdapter(StrSQL, DataProvider.getInstance().getConnection());
            ObjAdapter.Fill(table);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return table;
        }

        public static void UpdateTable(DataTable dataTable)
        {
            //tao chuoi ket noi.
            MySqlConnection ObjCn = DataProvider.getInstance().getConnection();
            string StrSQL = "SELECT * FROM chi_tiet_phieu_den";

            MySqlDataAdapter ObjAdapter = new MySqlDataAdapter(StrSQL, ObjCn);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(ObjAdapter);

            ObjAdapter.Update(dataTable);

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static void UpdateChiTietPhieuDen(ChiTietPhieuDen ct_PhieuDen)
        {
            string StrSQL = "UPDATE chi_tiet_phieu_den SET MaPhieuDen = " + ct_PhieuDen.MaPhieuDen
                + ", MaPhong = " + ct_PhieuDen.MaPhong 
                + ", TenKhachHang = "+ct_PhieuDen.TenKhachHang
                + ", CMND = " + ct_PhieuDen.CMND 
                + ", DonGia = "+ct_PhieuDen.DonGia
                + " WHERE MaChiTietPhieuDen = " + ct_PhieuDen.MaChiTietPhieuDen;


            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;




            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static bool Add(ChiTietPhieuDen ct_PhieuDen)
        {
            try
            {
                MySqlCommand cmd = DataProvider.getInstance().getCommand();
                cmd.CommandText = "INSERT INTO chi_tiet_phieu_den(MaPhieuDen, MaPhong, TenKhachHang, CMND, DonGia)"
                    + " VALUES(?maphieuden, ?maphong, ?tenkhach, ?CMND, ?DonGia)";

                cmd.Parameters.Add("?maphieuden", ct_PhieuDen.MaPhieuDen);
                cmd.Parameters.Add("?CMND", ct_PhieuDen.CMND);
                cmd.Parameters.Add("?maphong", ct_PhieuDen.MaPhong);
                cmd.Parameters.Add("?tenkhach", ct_PhieuDen.TenKhachHang);
                cmd.Parameters.Add("?DonGia", ct_PhieuDen.DonGia);
                

                cmd.ExecuteNonQuery();

                //Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                cmd.CommandText = "Select @@IDENTITY"; ;
                ct_PhieuDen.MaChiTietPhieuDen = (int)cmd.ExecuteScalar();

                //close connection
                DataProvider.getInstance().CloseConnection();

                return true;
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Dữ liệu trùng lặp: PhieuDen " + ct_PhieuDen.TenKhachHang);
                }

                //close connection
                DataProvider.getInstance().CloseConnection();

                return false;
            }
        }

        public static void Delete(int maCTPhieuDen)
        {
            string StrSQL = "DELETE FROM chi_tiet_phieu_den WHERE MaChiTietPhieuDen = " + maCTPhieuDen;

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;


            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static DataTable Find(int maCTPhieuDen)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM chi_tiet_phieu_den WHERE MaChiTietPhieuDen = " + maCTPhieuDen;
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;


            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
        }

        public static ArrayList FindMaPhong(int maphong)
        {
            ArrayList listCTPhieuDen = new ArrayList();
            string StrSQL = "SELECT * FROM chi_tiet_phieu_den WHERE MaPhong = " + maphong;
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;
            MySqlDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                ChiTietPhieuDen ct_PhieuDen = new ChiTietPhieuDen();

                ct_PhieuDen.MaChiTietPhieuDen = (int)ObjReader["MaChiTietPhieuDen"];
                ct_PhieuDen.MaPhieuDen = (int)ObjReader["MaPhieuDen"];
                ct_PhieuDen.MaPhong = maphong;// (int)ObjReader["MaPhong"];
                ct_PhieuDen.TenKhachHang = (string)ObjReader["TenKhachHang"];
                ct_PhieuDen.CMND = (string)ObjReader["CMND"];
                ct_PhieuDen.DonGia = (float)ObjReader["DonGia"];

                listCTPhieuDen.Add(ct_PhieuDen);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listCTPhieuDen;
        }

        public static DataTable FindMaPhieuDen(int maPhieuDen)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM chi_tiet_phieu_den WHERE MaPhieuDen = " + maPhieuDen;

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;


            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
        }

        /// <summary>
        /// Tìm danh sách Chi Tiết Phiếu Đến có mã phòng và tình Trạng thanh toán truyền vô
        /// </summary>
        /// <param name="maPhong"></param>
        /// <param name="tinhTrangThanhToan"></param>
        /// <returns></returns>
        public static ArrayList FindDanhSachChiTiet(int maPhong, bool tinhTrangThanhToan)
        {
            ArrayList listCTPhieuDen = new ArrayList();
            
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = "SELECT * FROM chi_tiet_phieu_den "
                                +"WHERE MaPhong = ?MaPhong AND MaPhieuDen IN "
                                    + "(SELECT MaPhieuDen FROM phieu_den "
                                    + "WHERE TinhTrangThanhToan = ?TinhTrangThanhToan)";

            ObjCmd.Parameters.Add("?MaPhong", maPhong);
            ObjCmd.Parameters.Add("?TinhTrangThanhToan", tinhTrangThanhToan);

            MySqlDataReader ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                ChiTietPhieuDen ct_PhieuDen = new ChiTietPhieuDen();

                ct_PhieuDen.MaChiTietPhieuDen = (int)ObjReader["MaChiTietPhieuDen"];
                ct_PhieuDen.MaPhieuDen = (int)ObjReader["MaPhieuDen"];
                ct_PhieuDen.MaPhong = (int)ObjReader["MaPhong"];
                ct_PhieuDen.TenKhachHang = (string)ObjReader["TenKhachHang"];
                ct_PhieuDen.CMND = (string)ObjReader["CMND"];
                ct_PhieuDen.DonGia = (float)ObjReader["DonGia"];

                listCTPhieuDen.Add(ct_PhieuDen);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listCTPhieuDen;
        }

        /// <summary>
        /// Tìm danh sách chi tiết Phiếu đến theo tên khách và tình trạng lưu trú của khách
        /// </summary>
        /// <param name="tenKhach"></param>
        /// <param name="tinhTrang"></param>
        /// <returns></returns>
        public static ArrayList FindDanhSachChiTietPhieuDenTheoTenKhach(String tenKhach, String tinhTrang)
        {
            ArrayList listCTPhieuDen = new ArrayList();
            
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();

            if (tinhTrang.Equals("Không quan tâm"))
            {
                ObjCmd.CommandText = "SELECT * FROM chi_tiet_phieu_den WHERE TenKhachHang LIKE '%" + tenKhach + "%'";
            }
            else
                if (tinhTrang.Equals("Đã trả phòng"))
                {
                    ObjCmd.CommandText = "SELECT * FROM chi_tiet_phieu_den WHERE TenKhachHang LIKE '%" + tenKhach + "%' AND "
                                        + " MaPhieuDen IN ( SELECT MaPhieuDen FROM phieu_den WHERE TinhTrangThanhToan = ?TinhTrangThanhToan)";
                    ObjCmd.Parameters.Add("?TinhTrangThanhToan", true);
                }
                else // tinh trạng == Đang thuê phòng
                {
                    ObjCmd.CommandText = "SELECT * FROM chi_tiet_phieu_den WHERE TenKhachHang LIKE '%" + tenKhach + "%' AND "
                                        + " MaPhieuDen IN ( SELECT MaPhieuDen FROM phieu_den WHERE TinhTrangThanhToan = ?TinhTrangThanhToan)";
                    ObjCmd.Parameters.Add("?TinhTrangThanhToan", false);
                }

            MySqlDataReader ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                ChiTietPhieuDen ct_PhieuDen = new ChiTietPhieuDen();

                ct_PhieuDen.MaChiTietPhieuDen = (int)ObjReader["MaChiTietPhieuDen"];
                ct_PhieuDen.MaPhieuDen = (int)ObjReader["MaPhieuDen"];
                ct_PhieuDen.MaPhong = (int)ObjReader["MaPhong"];
                ct_PhieuDen.TenKhachHang = (string)ObjReader["TenKhachHang"];
                ct_PhieuDen.CMND = (string)ObjReader["CMND"];
                ct_PhieuDen.DonGia = (float)ObjReader["DonGia"];

                listCTPhieuDen.Add(ct_PhieuDen);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listCTPhieuDen;
        }

        /// <summary>
        /// Tìm danh sách chi tiết Phiếu đến theo CMND và tình trạng lưu trú của khách
        /// </summary>
        /// <param name="tenKhach"></param>
        /// <param name="tinhTrang"></param>
        /// <returns></returns>
        public static ArrayList FindDanhSachChiTietPhieuDenTheoCMND(String CMND, String tinhTrang)
        {
            ArrayList listCTPhieuDen = new ArrayList();

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();

            if (tinhTrang.Equals("Không quan tâm"))
            {
                ObjCmd.CommandText = "SELECT * FROM chi_tiet_phieu_den WHERE CMND LIKE '%" + CMND + "%'";
            }
            else
                if (tinhTrang.Equals("Đã trả phòng"))
                {
                    ObjCmd.CommandText =  "SELECT * FROM chi_tiet_phieu_den WHERE CMND LIKE '%" + CMND + "%' AND "
                                        + " MaPhieuDen IN ( SELECT MaPhieuDen FROM phieu_den WHERE TinhTrangThanhToan = ?TinhTrangThanhToan)";
                    ObjCmd.Parameters.Add("?TinhTrangThanhToan", true);
                }
                else // tinh trạng == Đang thuê phòng
                {
                    ObjCmd.CommandText = "SELECT * FROM chi_tiet_phieu_den WHERE CMND LIKE '%" + CMND + "%' AND "
                                        + " MaPhieuDen IN ( SELECT MaPhieuDen FROM phieu_den WHERE TinhTrangThanhToan = ?TinhTrangThanhToan)";
                    ObjCmd.Parameters.Add("?TinhTrangThanhToan", false);
                }

            MySqlDataReader ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                ChiTietPhieuDen ct_PhieuDen = new ChiTietPhieuDen();

                ct_PhieuDen.MaChiTietPhieuDen = (int)ObjReader["MaChiTietPhieuDen"];
                ct_PhieuDen.MaPhieuDen = (int)ObjReader["MaPhieuDen"];
                ct_PhieuDen.MaPhong = (int)ObjReader["MaPhong"];
                ct_PhieuDen.TenKhachHang = (string)ObjReader["TenKhachHang"];
                ct_PhieuDen.CMND = (string)ObjReader["CMND"];
                ct_PhieuDen.DonGia = (float)ObjReader["DonGia"];

                listCTPhieuDen.Add(ct_PhieuDen);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listCTPhieuDen;
        }

        /// <summary>
        /// Tìm danh sách các Chi tiết phiếu đến của các Phiếu đến có thời gian lưu trú nằm giữa 2 khoảng thời gian Từ Đến
        /// </summary>
        /// <param name="tu"></param>
        /// <param name="den"></param>
        /// <returns></returns>
        public static ArrayList FindDanhSachChiTietPhieuDenTrongKhoangThoiGian(DateTime tu, DateTime den)
        {
            ArrayList listCTPhieuDen = new ArrayList();

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();

            ObjCmd.CommandText = "SELECT * FROM chi_tiet_phieu_den WHERE MaPhieuDen IN "
                                +"(SELECT MaPhieuDen FROM phieu_den WHERE (ThoiDiemDen BETWEEN ?tu AND ?den) OR (ThoiDiemDi BETWEEN ?tu AND ?den))";
            
            ObjCmd.Parameters.Add("?tu", tu);
            ObjCmd.Parameters.Add("?den", den);
            
            MySqlDataReader ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                ChiTietPhieuDen ct_PhieuDen = new ChiTietPhieuDen();

                ct_PhieuDen.MaChiTietPhieuDen = (int)ObjReader["MaChiTietPhieuDen"];
                ct_PhieuDen.MaPhieuDen = (int)ObjReader["MaPhieuDen"];
                ct_PhieuDen.MaPhong = (int)ObjReader["MaPhong"];
                ct_PhieuDen.TenKhachHang = (string)ObjReader["TenKhachHang"];
                ct_PhieuDen.CMND = (string)ObjReader["CMND"];
                ct_PhieuDen.DonGia = (float)ObjReader["DonGia"];

                listCTPhieuDen.Add(ct_PhieuDen);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listCTPhieuDen;
        }
    }


}

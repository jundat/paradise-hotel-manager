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
    class DataPhieuDen
    {
        public static PhieuDen Get(int maphieuden)
        {
            string StrSQL = "SELECT * FROM phieu_den WHERE MaPhieuDen = " + maphieuden;
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;
            MySqlDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            ObjReader.Read();
            PhieuDen phieuDen = new PhieuDen();

            phieuDen.MaPhieuDen = (int)ObjReader["MaPhieuDen"];
            phieuDen.TenKhachDaiDien = (string)ObjReader["TenKhachDaiDien"];
            phieuDen.CMND = (string)ObjReader["CMND"];
            phieuDen.ThoiDiemDen = (DateTime)ObjReader["ThoiDiemDen"];
            phieuDen.ThoiDiemDi = (DateTime)ObjReader["ThoiDiemDi"];
            phieuDen.TongChiPhi = (float)ObjReader["TongChiPhi"];
            phieuDen.TinhTrangThanhToan = Convert.ToBoolean(ObjReader["TinhTrangThanhToan"]);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return phieuDen;
        }

        public static ArrayList GetList()
        {
            ArrayList listPhieuDen = new ArrayList();
            string StrSQL = "SELECT * FROM phieu_den";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;
            MySqlDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                PhieuDen PhieuDen = new PhieuDen();

                PhieuDen.MaPhieuDen = (int)ObjReader["MaPhieuDen"];
                PhieuDen.TenKhachDaiDien = (string)ObjReader["TenKhachDaiDien"];
                PhieuDen.CMND = (string)ObjReader["CMND"];
                PhieuDen.ThoiDiemDen = (DateTime)ObjReader["ThoiDiemDen"];
                PhieuDen.ThoiDiemDi = (DateTime)ObjReader["ThoiDiemDi"];
                PhieuDen.TongChiPhi = (float)ObjReader["TongChiPhi"];
                PhieuDen.TinhTrangThanhToan = (bool)ObjReader["TinhTrangThanhToan"];

                listPhieuDen.Add(PhieuDen);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listPhieuDen;
        }

        /// <summary>
        /// Tìm kiếm danh sách các Phiếu đến
        /// </summary>
        /// <param name="tenKhachDaiDien"></param>
        /// <param name="CMND"></param>
        /// <param name="tinhTrangThanhToan"></param>
        /// <returns></returns>
        public static ArrayList Find(String tenKhachDaiDien, String CMND, String tinhTrangThanhToan)
        {
            ArrayList listPhieuDen = new ArrayList();
            
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();

            if ("Không quan tâm".Equals(tinhTrangThanhToan))
            {
                ObjCmd.CommandText = "SELECT * FROM phieu_den WHERE TenKhachDaiDien = ?TenKhachDaiDien OR CMND = ?CMND";

                ObjCmd.Parameters.Add("?TenKhachDaiDien", tenKhachDaiDien);
                ObjCmd.Parameters.Add("?CMND", CMND);
            }
            else
                if ("Đã thanh toán".Equals(tinhTrangThanhToan))
                {
                    ObjCmd.CommandText = "SELECT * FROM phieu_den WHERE (TenKhachDaiDien = ?TenKhachDaiDien OR CMND = ?CMND) AND TinhTrangThanhToan = ?TinhTrangThanhToan";

                    ObjCmd.Parameters.Add("?TenKhachDaiDien", tenKhachDaiDien);
                    ObjCmd.Parameters.Add("?CMND", CMND);
                    ObjCmd.Parameters.Add("?TinhTrangThanhToan", true);
                }
                else // Chưa thanh toán
                {
                    ObjCmd.CommandText = "SELECT * FROM phieu_den WHERE (TenKhachDaiDien = ?TenKhachDaiDien OR CMND = ?CMND) AND TinhTrangThanhToan = ?TinhTrangThanhToan";

                    ObjCmd.Parameters.Add("?TenKhachDaiDien", tenKhachDaiDien);
                    ObjCmd.Parameters.Add("?CMND", CMND);
                    ObjCmd.Parameters.Add("?TinhTrangThanhToan", false);
                }

            MySqlDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                PhieuDen PhieuDen = new PhieuDen();

                PhieuDen.MaPhieuDen = (int)ObjReader["MaPhieuDen"];
                PhieuDen.TenKhachDaiDien = (string)ObjReader["TenKhachDaiDien"];
                PhieuDen.CMND = (string)ObjReader["CMND"];
                PhieuDen.ThoiDiemDen = (DateTime)ObjReader["ThoiDiemDen"];
                PhieuDen.ThoiDiemDi = (DateTime)ObjReader["ThoiDiemDi"];
                PhieuDen.TongChiPhi = (float)ObjReader["TongChiPhi"];
                PhieuDen.TinhTrangThanhToan = Convert.ToBoolean(ObjReader["TinhTrangThanhToan"]);

                listPhieuDen.Add(PhieuDen);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listPhieuDen;
        }

        public static DataTable GetTable()
        {
            DataTable table = new DataTable();
            string StrSQL = "SELECT * FROM phieu_den";
            MySqlDataAdapter ObjAdapter = new MySqlDataAdapter(StrSQL, DataProvider.getInstance().getConnection());
            ObjAdapter.Fill(table);

            //close connection
            DataProvider.getInstance().CloseConnection();

            //close connection
            DataProvider.getInstance().CloseConnection();

            return table;
        }

        public static void UpdateTable(DataTable dataTable)
        {
            //tao chuoi ket noi.
            MySqlConnection ObjCn = DataProvider.getInstance().getConnection();
            string StrSQL = "SELECT * FROM phieu_den";

            MySqlDataAdapter ObjAdapter = new MySqlDataAdapter(StrSQL, ObjCn);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(ObjAdapter);

            ObjAdapter.Update(dataTable);

            //close connection
            DataProvider.getInstance().CloseConnection();

        }
        
        public static void UpdatePhieuDen(PhieuDen phieuDen)
        {
            string StrSQL = "UPDATE phieu_den SET TenKhachDaiDien = " + phieuDen.TenKhachDaiDien
                + ", CMND = " + phieuDen.CMND
                + ", ThoiDiemDen = " + phieuDen.ThoiDiemDen
                + ", ThoiDiemDi = " + phieuDen.ThoiDiemDi
                + ", TongChiPhi = " + phieuDen.TongChiPhi
                + ", TinhTrangThanhToan = " + phieuDen.TinhTrangThanhToan
                + " WHERE MaPhieuDen = " + phieuDen.MaPhieuDen;


            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;




            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static void UpdateTrangThai(int maphieu, bool tinhtrang)
        {
            string StrSQL = "UPDATE phieu_den SET TinhTrangThanhToan = " + Convert.ToByte(tinhtrang)
                + " WHERE MaPhieuDen = " + maphieu;
            
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;
            
            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();
        }

        public static bool Add(PhieuDen phieuDen)
        {
            try
            {
                MySqlCommand cmd = DataProvider.getInstance().getCommand();
                cmd.CommandText = "INSERT INTO phieu_den(TenKhachDaiDien, CMND, ThoiDiemDen, ThoiDiemDi, TongChiPhi, TinhTrangThanhToan)"
                    + " VALUES(?TenKhachDaiDien, ?CMND, ?ThoiDiemDen, ?ThoiDiemDi, ?TongChiPhi, ?TinhTrangThanhToan)";

                cmd.Parameters.Add("?TenKhachDaiDien", phieuDen.TenKhachDaiDien);
                cmd.Parameters.Add("?CMND", phieuDen.CMND);
                cmd.Parameters.Add("?TinhTrangThanhToan", phieuDen.TinhTrangThanhToan);
                cmd.Parameters.Add("?ThoiDiemDen", phieuDen.ThoiDiemDen);
                cmd.Parameters.Add("?ThoiDiemDi", phieuDen.ThoiDiemDi);
                cmd.Parameters.Add("?TongChiPhi", phieuDen.TongChiPhi);

                cmd.ExecuteNonQuery();

                //Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                cmd.CommandText = "Select @@IDENTITY"; ;
                phieuDen.MaPhieuDen = Convert.ToInt32(cmd.ExecuteScalar());

                //close connection
                DataProvider.getInstance().CloseConnection();

                return true;
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Dữ liệu trùng lặp: PhieuDen " + phieuDen.TenKhachDaiDien);
                }

                //close connection
                DataProvider.getInstance().CloseConnection();

                return false;
            }
        }

        public static void Delete(int maPhieuDen)
        {
            string StrSQL = "DELETE FROM phieu_den WHERE MaPhieuDen = " + maPhieuDen;

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;



            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static PhieuDen Find(int maPhieuDen)
        {
            PhieuDen phieuDen = new PhieuDen();

            
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = "SELECT * FROM phieu_den WHERE MaPhieuDen = ?MaPhieuDen";

            ObjCmd.Parameters.Add("?MaPhieuDen", maPhieuDen);

            MySqlDataReader dataReader = ObjCmd.ExecuteReader();

            while (dataReader.Read())
            {
                phieuDen.MaPhieuDen = (int)dataReader["MaPhieuDen"];
                phieuDen.TenKhachDaiDien = (String)dataReader["TenKhachDaiDien"];
                phieuDen.CMND = (String)dataReader["CMND"];
                phieuDen.ThoiDiemDen = (DateTime)dataReader["ThoiDiemDen"];
                phieuDen.ThoiDiemDi = (DateTime)dataReader["ThoiDiemDi"];
                phieuDen.TongChiPhi = (float)dataReader["TongChiPhi"];
                phieuDen.TinhTrangThanhToan = Convert.ToBoolean(dataReader["TongChiPhi"]);
            }

            //close connection
            dataReader.Close();
            DataProvider.getInstance().CloseConnection();

            return phieuDen;
        }

        public static DataTable FindCMND(string cmnd, bool tinhtrang)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM phieu_den WHERE CMND = " + cmnd + " AND TinhTrangThanhToan = " + Convert.ToByte(tinhtrang);
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;


            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
        }

        public static DataTable Find(string tenKhachDaiDien)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM phieu_den WHERE TenKhachDaiDien = \'" + tenKhachDaiDien + "\'";

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;
            
            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
        }

        //Phan Them vao

        public static DataTable Getphieuden(String phong)
        {
            DataTable dataTable = new DataTable();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT TenPhong,TenLoaiPhong,LOAI_PHONG.DonGia,ThoiDiemDen,ThoiDiemDi FROM phong,loai_phong,phieu_den,chi_tiet_phieu_den "
            + "WHERE phong.TenPhong = ?tenphong and phong.MaLoaiPhong = loai_phong.MaLoaiPhong and phong.MaPhong = chi_tiet_phieu_den.MaPhong and phieu_den.MaPhieuDen = chi_tiet_phieu_den.MaPhieuDen";
            cmd.Parameters.Add("?tenphong", phong);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataTable);

            // Đóng kết nối
            DataProvider.getInstance().CloseConnection();
            return dataTable;

        }

    }
}

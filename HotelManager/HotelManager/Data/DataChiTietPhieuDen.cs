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
                MySqlConnection ObjCn = DataProvider.getInstance().getConnection();

                string StrSQL = "INSERT INTO chi_tiet_phieu_den(MaPhieuDen, MaPhong, TenKhachHang, CMND, DonGia)"
                    + " VALUES( " + ct_PhieuDen.MaPhieuDen
                    + ", " + ct_PhieuDen.MaPhong 
                    + ", " + ct_PhieuDen.TenKhachHang
                    + ", " + ct_PhieuDen.CMND
                    + ", " + ct_PhieuDen.DonGia 
                    + ");";


                MySqlCommand ObjCmd = new MySqlCommand(StrSQL, ObjCn);




                ObjCmd.ExecuteNonQuery();

                //Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                StrSQL = "Select @@IDENTITY";

                ObjCmd = new MySqlCommand(StrSQL, ObjCn);
                ct_PhieuDen.MaChiTietPhieuDen = (int)ObjCmd.ExecuteScalar();

                //close connection
                DataProvider.getInstance().CloseConnection();

                return true;
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Dữ liệu trùng lặp: ChiTietPhieuDen với phiếu thu có mã: " + ct_PhieuDen.MaPhieuDen);
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

    }
}

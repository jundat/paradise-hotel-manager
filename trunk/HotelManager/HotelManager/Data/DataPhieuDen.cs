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
                MySqlConnection ObjCn = DataProvider.getInstance().getConnection();

                string StrSQL = "INSERT INTO phieu_den(TenKhachDaiDien, CMND, ThoiDiemDen, ThoiDiemDi, TongChiPhi, TinhTrangThanhToan)"
                    + " VALUES( " + phieuDen.TenKhachDaiDien
                    + ", " + phieuDen.CMND
                    + ", " + phieuDen.ThoiDiemDen
                    + ", " + phieuDen.ThoiDiemDi
                    + ", " + phieuDen.TongChiPhi
                    + ", " + phieuDen.TinhTrangThanhToan 
                    + ");";


                MySqlCommand ObjCmd = new MySqlCommand(StrSQL, ObjCn);




                ObjCmd.ExecuteNonQuery();

                //Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                StrSQL = "Select @@IDENTITY";

                ObjCmd = new MySqlCommand(StrSQL, ObjCn);
                phieuDen.MaPhieuDen = (int)ObjCmd.ExecuteScalar();

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

        public static DataTable Find(int maPhieuDen)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM phieu_den WHERE MaPhieuDen = " + maPhieuDen;
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;


            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
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

    }
}

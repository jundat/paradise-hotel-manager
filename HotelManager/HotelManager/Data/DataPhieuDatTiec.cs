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
    class DataPhieuDatTiec
    {
        public static ArrayList GetList()
        {
            ArrayList listPhieuDatTiec = new ArrayList();
            string StrSQL = "SELECT * FROM phieu_dat_tiec";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;
            MySqlDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                PhieuDatTiec phieudattiec = new PhieuDatTiec();

                phieudattiec.MaPhieuDatTiec = (int)ObjReader["MaPhieuDatTiec"];
                phieudattiec.TenKhach = (string)ObjReader["TenKhach"];
                phieudattiec.MaPhong = (int)ObjReader["MaPhong"];
                phieudattiec.ThoiDiem = (DateTime)ObjReader["ThoiDiem"];
                phieudattiec.TongTien = (float)ObjReader["TongTien"];
                phieudattiec.TinhTrangThanhToan = (bool)ObjReader["TinhTrangThanhToan"];

                listPhieuDatTiec.Add(phieudattiec);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listPhieuDatTiec;
        }

        public static DataTable GetTable()
        {
            DataTable table = new DataTable();
            string StrSQL = "SELECT * FROM phieu_dat_tiec";
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
            string StrSQL = "SELECT * FROM phieu_dat_tiec";

            MySqlDataAdapter ObjAdapter = new MySqlDataAdapter(StrSQL, ObjCn);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(ObjAdapter);

            ObjAdapter.Update(dataTable);

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static void UpdatePhieuDatTiec(PhieuDatTiec phieudattiec)
        {
            string StrSQL = "UPDATE phieu_dat_tiec SET TenKhach = " + phieudattiec.TenKhach
                + ", MaPhong = " + phieudattiec.MaPhong
                + ", ThoiDiem = " + phieudattiec.ThoiDiem
                + ", TongTien = " + phieudattiec.TongTien
                + ", TinhTrangThanhToan = " + phieudattiec.TinhTrangThanhToan
                + " WHERE MaPhieuDatTiec = " + phieudattiec.MaPhieuDatTiec;

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;



            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static void UpdateTrangThai(int maphieu, bool trangthai)
        {
            string StrSQL = "UPDATE phieu_dat_tiec SET TinhTrangThanhToan = " + trangthai
                + " WHERE MaPhieuDatTiec = " + maphieu;

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;
           
            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();
        }

        public static bool Add(PhieuDatTiec phieudattiec)
        {
            try
            {
                MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
                ObjCmd.CommandText = "INSERT INTO phieu_dat_tiec(TenKhach, MaPhong, ThoiDiem, TongTien, TinhTrangThanhToan) VALUES(?TenKhach, ?MaPhong, ?ThoiDiem, ?TongTien, ?TinhTrangThanhToan)";
                ObjCmd.Prepare();

                // Tạo và truyền đối số cho command
                ObjCmd.Parameters.Add("?TenKhach", phieudattiec.TenKhach);
                ObjCmd.Parameters.Add("?MaPhong", phieudattiec.MaPhong);
                ObjCmd.Parameters.Add("?ThoiDiem", phieudattiec.ThoiDiem);
                ObjCmd.Parameters.Add("?TongTien", phieudattiec.TongTien);
                ObjCmd.Parameters.Add("?TinhTrangThanhToan", phieudattiec.TinhTrangThanhToan);


                ObjCmd.ExecuteNonQuery();

                //Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                ObjCmd.CommandText = "Select @@IDENTITY";
                phieudattiec.MaPhieuDatTiec = Convert.ToInt32(ObjCmd.ExecuteScalar());

                //close connection
                DataProvider.getInstance().CloseConnection();

                return true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();
            return false;
        }

        public static void Delete(int maphieu)
        {
            string StrSQL = "DELETE FROM phieu_dat_tiec WHERE MaPhieuDatTiec = " + maphieu;

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;



            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static DataTable Find(int maphieu)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM phieu_dat_tiec WHERE MaPhieuDatTiec = " + maphieu;
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;


            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
        }

        public static DataTable Find(string tenkhach)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM phieu_dat_tiec WHERE TenKhach = " + tenkhach;

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
        }

        public static ArrayList Find(int _maPhong, bool _tinhTrangThanhToan)
        {
            ArrayList listPhieuDatTiec = new ArrayList();
            string StrSQL = "SELECT * FROM phieu_dat_tiec WHERE MaPhong = '" + _maPhong + "' AND TinhTrangThanhToan = " + Convert.ToByte(_tinhTrangThanhToan);
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;
            MySqlDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                PhieuDatTiec phieudattiec = new PhieuDatTiec();

                phieudattiec.MaPhieuDatTiec = (int)ObjReader["MaPhieuDatTiec"];
                phieudattiec.TenKhach = (string)ObjReader["TenKhach"];
                phieudattiec.MaPhong = (int)ObjReader["MaPhong"];
                phieudattiec.ThoiDiem = (DateTime)ObjReader["ThoiDiem"];
                phieudattiec.TongTien = (float)ObjReader["TongTien"];
                phieudattiec.TinhTrangThanhToan = Convert.ToBoolean(ObjReader["TinhTrangThanhToan"]);

                listPhieuDatTiec.Add(phieudattiec);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listPhieuDatTiec;
        }
    }
}

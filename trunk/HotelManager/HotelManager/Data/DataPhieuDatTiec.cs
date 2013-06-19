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
            string StrSQL = "UPDATE phieu_dat_tiec SET TenKhach = ?, MaPhong = ?, ThoiDiem = ?, TongTien = ?, TinhTrangThanhToan = ? WHERE MaPhieuDatTiec = ?";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@TenKhach", MySqlDbType.String).Value = phieudattiec.TenKhach;
            ObjCmd.Parameters.Add("@MaPhong", MySqlDbType.Int32).Value = phieudattiec.MaPhong;
            ObjCmd.Parameters.Add("@ThoiDiem", MySqlDbType.Datetime).Value = phieudattiec.ThoiDiem;
            ObjCmd.Parameters.Add("@TongTien", MySqlDbType.Float).Value = phieudattiec.TongTien;
            ObjCmd.Parameters.Add("@TinhTrangThanhToan", MySqlDbType.Byte).Value = phieudattiec.TinhTrangThanhToan;

            ObjCmd.Parameters.Add("@MaPhieuDatTiec", MySqlDbType.Int32).Value = phieudattiec.MaPhieuDatTiec;

            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static bool Add(PhieuDatTiec phieudattiec)
        {
            try
            {
                MySqlConnection ObjCn = DataProvider.getInstance().getConnection();

                string StrSQL = "INSERT INTO phieu_dat_tiec(TenKhach, MaPhong, ThoiDiem, TongTien, TinhTrangThanhToan) VALUES( ?, ?, ?, ?, ?);";
                MySqlCommand ObjCmd = new MySqlCommand(StrSQL, ObjCn);

                ObjCmd.Parameters.Add("@TenKhach", MySqlDbType.String).Value = phieudattiec.TenKhach;
                ObjCmd.Parameters.Add("@MaPhong", MySqlDbType.Int32).Value = phieudattiec.MaPhong;
                ObjCmd.Parameters.Add("@ThoiDiem", MySqlDbType.Datetime).Value = phieudattiec.ThoiDiem;
                ObjCmd.Parameters.Add("@TongTien", MySqlDbType.Float).Value = phieudattiec.TongTien;
                ObjCmd.Parameters.Add("@TinhTrangThanhToan", MySqlDbType.Byte).Value = phieudattiec.TinhTrangThanhToan;

                ObjCmd.ExecuteNonQuery();

                //Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                StrSQL = "Select @@IDENTITY";

                ObjCmd = new MySqlCommand(StrSQL, ObjCn);
                phieudattiec.MaPhieuDatTiec = (int)ObjCmd.ExecuteScalar();

                //close connection
                DataProvider.getInstance().CloseConnection();

                return true;
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Dữ liệu trùng lặp: PhieuDatTiec " + phieudattiec.TenKhach);
                }

                //close connection
                DataProvider.getInstance().CloseConnection();

                return false;
            }
        }

        public static void Delete(int maphieu)
        {
            string StrSQL = "DELETE FROM phieu_dat_tiec WHERE MaPhieuDatTiec = ?";

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@MaPhieuDatTiec", MySqlDbType.Int32).Value = maphieu;

            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static DataTable Find(int maphieu)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM phieu_dat_tiec WHERE MaPhieuDatTiec = ?";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@MaPhieuDatTiec", MySqlDbType.Int32).Value = maphieu;

            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
        }

        public static DataTable Find(string tenkhach)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM phieu_dat_tiec WHERE TenKhach = ?";

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@TenKhach", MySqlDbType.String).Value = tenkhach;

            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
        }

    }
}

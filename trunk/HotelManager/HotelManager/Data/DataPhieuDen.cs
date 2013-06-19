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
            string StrSQL = "UPDATE phieu_den SET TenKhachDaiDien = ?, CMND = ?, ThoiDiemDen = ?, ThoiDiemDi = ?, TongChiPhi = ?, TinhTrangThanhToan = ? WHERE MaPhieuDen = ?";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@TenKhachDaiDien", MySqlDbType.String).Value = phieuDen.TenKhachDaiDien;
            ObjCmd.Parameters.Add("@CMND", MySqlDbType.String).Value = phieuDen.CMND;
            ObjCmd.Parameters.Add("@ThoiDiemDen", MySqlDbType.Datetime).Value = phieuDen.ThoiDiemDen;
            ObjCmd.Parameters.Add("@ThoiDiemDi", MySqlDbType.Datetime).Value = phieuDen.ThoiDiemDi;
            ObjCmd.Parameters.Add("@TongChiPhi", MySqlDbType.Float).Value = phieuDen.TongChiPhi;
            ObjCmd.Parameters.Add("@TinhTrangThanhToan", MySqlDbType.Byte).Value = phieuDen.TinhTrangThanhToan;

            ObjCmd.Parameters.Add("@MaPhieuDen", MySqlDbType.Int32).Value = phieuDen.MaPhieuDen;

            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static bool Add(PhieuDen phieuDen)
        {
            try
            {
                MySqlConnection ObjCn = DataProvider.getInstance().getConnection();

                string StrSQL = "INSERT INTO phieu_den(TenKhachDaiDien, CMND, ThoiDiemDen, ThoiDiemDi, TongChiPhi, TinhTrangThanhToan) VALUES( ?, ?, ?, ?, ?, ?);";
                MySqlCommand ObjCmd = new MySqlCommand(StrSQL, ObjCn);

                ObjCmd.Parameters.Add("@TenKhachDaiDien", MySqlDbType.String).Value = phieuDen.TenKhachDaiDien;
                ObjCmd.Parameters.Add("@CMND", MySqlDbType.String).Value = phieuDen.CMND;
                ObjCmd.Parameters.Add("@ThoiDiemDen", MySqlDbType.Datetime).Value = phieuDen.ThoiDiemDen;
                ObjCmd.Parameters.Add("@ThoiDiemDi", MySqlDbType.Datetime).Value = phieuDen.ThoiDiemDi;
                ObjCmd.Parameters.Add("@TongChiPhi", MySqlDbType.Float).Value = phieuDen.TongChiPhi;
                ObjCmd.Parameters.Add("@TinhTrangThanhToan", MySqlDbType.Byte).Value = phieuDen.TinhTrangThanhToan;

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
            string StrSQL = "DELETE FROM phieu_den WHERE MaPhieuDen = ?";

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@MaPhieuDen", MySqlDbType.Int32).Value = maPhieuDen;

            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static DataTable Find(int maPhieuDen)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM phieu_den WHERE MaPhieuDen = ?";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@MaPhieuDen", MySqlDbType.Int32).Value = maPhieuDen;

            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
        }

        public static DataTable Find(string tenKhachDaiDien)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM phieu_den WHERE TenKhachDaiDien = ?";

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@TenKhachDaiDien", MySqlDbType.String).Value = tenKhachDaiDien;

            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
        }

    }
}

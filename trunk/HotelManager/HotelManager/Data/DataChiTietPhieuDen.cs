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

            return listCTPhieuDen;
        }

        public static DataTable GetTable()
        {
            DataTable table = new DataTable();
            string StrSQL = "SELECT * FROM chi_tiet_phieu_den";
            MySqlDataAdapter ObjAdapter = new MySqlDataAdapter(StrSQL, DataProvider.getInstance().getConnection());
            ObjAdapter.Fill(table);
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

            ObjCn.Close();
        }

        public static void UpdateChiTietPhieuDen(ChiTietPhieuDen ct_PhieuDen)
        {
            string StrSQL = "UPDATE chi_tiet_phieu_den SET MaPhieuDen = ?, MaPhong = ?, TenKhachHang = ?, CMND = ?, DonGia = ? WHERE MaChiTietPhieuDen = ?";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@MaPhieuDen", MySqlDbType.Int32).Value = ct_PhieuDen.MaPhieuDen;
            ObjCmd.Parameters.Add("@MaPhong", MySqlDbType.Int32).Value = ct_PhieuDen.MaPhong;
            ObjCmd.Parameters.Add("@TenKhachHang", MySqlDbType.String).Value = ct_PhieuDen.TenKhachHang;
            ObjCmd.Parameters.Add("@CMND", MySqlDbType.String).Value = ct_PhieuDen.CMND;
            ObjCmd.Parameters.Add("@DonGia", MySqlDbType.Float).Value = ct_PhieuDen.DonGia;

            ObjCmd.Parameters.Add("@MaChiTietPhieuDen", MySqlDbType.Int32).Value = ct_PhieuDen.MaChiTietPhieuDen;

            ObjCmd.ExecuteNonQuery();
        }

        public static bool Add(ChiTietPhieuDen ct_PhieuDen)
        {
            try
            {
                MySqlConnection ObjCn = DataProvider.getInstance().getConnection();

                string StrSQL = "INSERT INTO chi_tiet_phieu_den(MaPhieuDen, MaPhong, TenKhachHang, CMND, DonGia) VALUES( ?, ?, ?, ?, ?);";
                MySqlCommand ObjCmd = new MySqlCommand(StrSQL, ObjCn);

                ObjCmd.Parameters.Add("@MaPhieuDen", MySqlDbType.Int32).Value = ct_PhieuDen.MaPhieuDen;
                ObjCmd.Parameters.Add("@MaPhong", MySqlDbType.Int32).Value = ct_PhieuDen.MaPhong;
                ObjCmd.Parameters.Add("@TenKhachHang", MySqlDbType.String).Value = ct_PhieuDen.TenKhachHang;
                ObjCmd.Parameters.Add("@CMND", MySqlDbType.String).Value = ct_PhieuDen.CMND;
                ObjCmd.Parameters.Add("@DonGia", MySqlDbType.Float).Value = ct_PhieuDen.DonGia;

                ObjCmd.ExecuteNonQuery();

                //Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                StrSQL = "Select @@IDENTITY";

                ObjCmd = new MySqlCommand(StrSQL, ObjCn);
                ct_PhieuDen.MaChiTietPhieuDen = (int)ObjCmd.ExecuteScalar();

                return true;
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Dữ liệu trùng lặp: ChiTietPhieuDen với phiếu thu có mã: " + ct_PhieuDen.MaPhieuDen);
                }
                return false;
            }
        }

        public static void Delete(int maCTPhieuDen)
        {
            string StrSQL = "DELETE FROM chi_tiet_phieu_den WHERE MaChiTietPhieuDen = ?";

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@MaChiTietPhieuDen", MySqlDbType.Int32).Value = maCTPhieuDen;

            ObjCmd.ExecuteNonQuery();
        }

        public static DataTable Find(int maCTPhieuDen)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM chi_tiet_phieu_den WHERE MaChiTietPhieuDen = ?";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@MaChiTietPhieuDen", MySqlDbType.Int32).Value = maCTPhieuDen;

            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            return dt;
        }

        public static DataTable FindMaPhieuDen(int maPhieuDen)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM chi_tiet_phieu_den WHERE MaPhieuDen = ?";

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@MaPhieuDen", MySqlDbType.Int32).Value = maPhieuDen;

            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            return dt;
        }

    }
}

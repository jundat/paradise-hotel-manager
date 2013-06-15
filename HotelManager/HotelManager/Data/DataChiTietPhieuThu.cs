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
    class DataChiTietPhieuThu
    {
        public static ArrayList GetList()
        {
            ArrayList listCTPhieuThu = new ArrayList();
            string StrSQL = "SELECT * FROM chi_tiet_phieu_thu";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;
            MySqlDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                ChiTietPhieuThu ct_phieuthu = new ChiTietPhieuThu();

                ct_phieuthu.MaChiTietPhieuThu = (int)ObjReader["MaChiTietPhieuThu"];
                ct_phieuthu.MaPhieuThu = (int)ObjReader["MaPhieuThu"];
                ct_phieuthu.MaLoaiPhi = (int)ObjReader["MaLoaiPhi"];
                ct_phieuthu.SoTienThu = (float)ObjReader["SoTienThu"];

                listCTPhieuThu.Add(ct_phieuthu);
            }

            return listCTPhieuThu;
        }

        public static DataTable GetTable()
        {
            DataTable table = new DataTable();
            string StrSQL = "SELECT * FROM chi_tiet_phieu_thu";
            MySqlDataAdapter ObjAdapter = new MySqlDataAdapter(StrSQL, DataProvider.getInstance().getConnection());
            ObjAdapter.Fill(table);
            return table;
        }

        public static void UpdateTable(DataTable dataTable)
        {
            //tao chuoi ket noi.
            MySqlConnection ObjCn = DataProvider.getInstance().getConnection();
            string StrSQL = "SELECT * FROM chi_tiet_phieu_thu";

            MySqlDataAdapter ObjAdapter = new MySqlDataAdapter(StrSQL, ObjCn);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(ObjAdapter);

            ObjAdapter.Update(dataTable);

            ObjCn.Close();
        }

        public static void UpdateChiTietPhieuThu(ChiTietPhieuThu ct_phieuthu)
        {
            string StrSQL = "UPDATE chi_tiet_phieu_thu SET MaPhieuThu = ?, MaLoaiPhi = ?, SoTienThu = ? WHERE MaChiTietPhieuThu = ?";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@MaPhieuThu", MySqlDbType.Int32).Value = ct_phieuthu.MaPhieuThu;
            ObjCmd.Parameters.Add("@MaLoaiPhi", MySqlDbType.Int32).Value = ct_phieuthu.MaLoaiPhi;
            ObjCmd.Parameters.Add("@SoTienThu", MySqlDbType.Float).Value = ct_phieuthu.SoTienThu;

            ObjCmd.Parameters.Add("@MaChiTietPhieuThu", MySqlDbType.Int32).Value = ct_phieuthu.MaChiTietPhieuThu;

            ObjCmd.ExecuteNonQuery();
        }

        public static bool Add(ChiTietPhieuThu ct_phieuthu)
        {
            try
            {
                MySqlConnection ObjCn = DataProvider.getInstance().getConnection();

                string StrSQL = "INSERT INTO chi_tiet_phieu_thu(MaPhieuThu, MaLoaiPhi, SoTienThu) VALUES( ?, ?, ?);";
                MySqlCommand ObjCmd = new MySqlCommand(StrSQL, ObjCn);

                ObjCmd.Parameters.Add("@MaPhieuThu", MySqlDbType.Int32).Value = ct_phieuthu.MaPhieuThu;
                ObjCmd.Parameters.Add("@MaLoaiPhi", MySqlDbType.Int32).Value = ct_phieuthu.MaLoaiPhi;
                ObjCmd.Parameters.Add("@SoTienThu", MySqlDbType.Float).Value = ct_phieuthu.SoTienThu;

                ObjCmd.ExecuteNonQuery();

                //Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                StrSQL = "Select @@IDENTITY";

                ObjCmd = new MySqlCommand(StrSQL, ObjCn);
                ct_phieuthu.MaChiTietPhieuThu = (int)ObjCmd.ExecuteScalar();

                return true;
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Dữ liệu trùng lặp: ChiTietPhieuThu với phiếu thu có mã: " + ct_phieuthu.MaPhieuThu);
                }
                return false;
            }
        }

        public static void Delete(int maCTPhieuThu)
        {
            string StrSQL = "DELETE FROM chi_tiet_phieu_thu WHERE MaChiTietPhieuThu = ?";

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@MaChiTietPhieuThu", MySqlDbType.Int32).Value = maCTPhieuThu;

            ObjCmd.ExecuteNonQuery();
        }

        public static DataTable Find(int maCTPhieuThu)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM chi_tiet_phieu_thu WHERE MaChiTietPhieuThu = ?";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@MaChiTietPhieuThu", MySqlDbType.Int32).Value = maCTPhieuThu;

            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            return dt;
        }

        public static DataTable FindMaPhieuThu(int maPhieuThu)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM chi_tiet_phieu_thu WHERE MaPhieuThu = ?";

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@MaPhieuThu", MySqlDbType.Int32).Value = maPhieuThu;

            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            return dt;
        }

    }
}

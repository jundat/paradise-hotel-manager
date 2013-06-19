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

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listCTPhieuThu;
        }

        public static DataTable GetTable()
        {
            DataTable table = new DataTable();
            string StrSQL = "SELECT * FROM chi_tiet_phieu_thu";
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
            string StrSQL = "SELECT * FROM chi_tiet_phieu_thu";

            MySqlDataAdapter ObjAdapter = new MySqlDataAdapter(StrSQL, ObjCn);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(ObjAdapter);

            ObjAdapter.Update(dataTable);

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static void UpdateChiTietPhieuThu(ChiTietPhieuThu ct_phieuthu)
        {
            string StrSQL = "UPDATE chi_tiet_phieu_thu SET MaPhieuThu = " + ct_phieuthu.MaPhieuThu
                + ", MaLoaiPhi = " + ct_phieuthu.MaLoaiPhi
                + ", SoTienThu = " + ct_phieuthu.SoTienThu 
                + " WHERE MaChiTietPhieuThu = " + ct_phieuthu.MaChiTietPhieuThu;


            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;






            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static bool Add(ChiTietPhieuThu ct_phieuthu)
        {
            try
            {
                MySqlConnection ObjCn = DataProvider.getInstance().getConnection();

                string StrSQL = "INSERT INTO chi_tiet_phieu_thu(MaPhieuThu, MaLoaiPhi, SoTienThu) " 
                    + " VALUES("
                    + ct_phieuthu.MaPhieuThu + ","
                    + ct_phieuthu.MaLoaiPhi + "," 
                    + ct_phieuthu.SoTienThu + ");";


                MySqlCommand ObjCmd = new MySqlCommand(StrSQL, ObjCn);

                ObjCmd.ExecuteNonQuery();

                //Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                StrSQL = "Select @@IDENTITY";

                ObjCmd = new MySqlCommand(StrSQL, ObjCn);
                ct_phieuthu.MaChiTietPhieuThu = (int)ObjCmd.ExecuteScalar();

                //close connection
                DataProvider.getInstance().CloseConnection();

                return true;
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Dữ liệu trùng lặp: ChiTietPhieuThu với phiếu thu có mã: " + ct_phieuthu.MaPhieuThu);
                }

                //close connection
                DataProvider.getInstance().CloseConnection();

                return false;
            }
        }

        public static void Delete(int maCTPhieuThu)
        {
            string StrSQL = "DELETE FROM chi_tiet_phieu_thu WHERE MaChiTietPhieuThu = " + maCTPhieuThu;

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;



            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static DataTable Find(int maCTPhieuThu)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM chi_tiet_phieu_thu WHERE MaChiTietPhieuThu = " + maCTPhieuThu;
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;



            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
        }

        public static DataTable FindMaPhieuThu(int maPhieuThu)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM chi_tiet_phieu_thu WHERE MaPhieuThu = " + maPhieuThu;

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

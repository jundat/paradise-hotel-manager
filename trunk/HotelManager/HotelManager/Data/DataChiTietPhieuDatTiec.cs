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
    class DataChiTietPhieuDatTiec
    {
        public static ArrayList GetList()
        {
            ArrayList listCTPhieuDatTiec = new ArrayList();
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = "SELECT * FROM chi_tiet_phieu_dat_tiec";
            MySqlDataReader ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                ChiTietPhieuDatTiec ct_phieudattiec = new ChiTietPhieuDatTiec();

                ct_phieudattiec.MaPhieuDatTiec = (int)ObjReader["MaPhieuDatTiec"];
                ct_phieudattiec.TenMon = (string)ObjReader["TenMon"];
                ct_phieudattiec.DonGia = (float)ObjReader["DonGia"];
                ct_phieudattiec.SoLuong = (int)ObjReader["SoLuong"];
                ct_phieudattiec.YeuCau = (string)ObjReader["YeuCau"];

                listCTPhieuDatTiec.Add(ct_phieudattiec);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listCTPhieuDatTiec;
        }

        public static DataTable GetTable()
        {
            DataTable table = new DataTable();
            string StrSQL = "SELECT * FROM chi_tiec_phieu_dat_tiec";
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
            string StrSQL = "SELECT * FROM chi_tiec_phieu_dat_tiec";

            MySqlDataAdapter ObjAdapter = new MySqlDataAdapter(StrSQL, ObjCn);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(ObjAdapter);

            ObjAdapter.Update(dataTable);

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static void UpdateChiTietPhieuDatTiec(ChiTietPhieuDatTiec ct_phieudattiec)
        {
            string StrSQL = "UPDATE chi_tiec_phieu_dat_tiec SET MaPhieuDatTiec = " + ct_phieudattiec.MaPhieuDatTiec
                + ", TenMon = " + ct_phieudattiec.TenMon
                + ", DonGia = " + ct_phieudattiec.DonGia
                + ", SoLuong = " + ct_phieudattiec.SoLuong 
                + ", YeuCau = " + ct_phieudattiec.YeuCau
                + " WHERE MaChiTietPhieuDatTiec = " + ct_phieudattiec.MaChiTietPhieuDatTiec;


            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;



            

            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static bool Add(ChiTietPhieuDatTiec ct_phieudattiec)
        {
            try
            {
                MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
                ObjCmd.CommandText =  "INSERT INTO chi_tiet_phieu_dat_tiec(MaPhieuDatTiec, TenMon, DonGia, SoLuong, YeuCau) VALUES(?MaPhieuDatTiec, ?TenMon, ?DonGia, ?SoLuong, ?YeuCau)";
                ObjCmd.Prepare();

                ObjCmd.Parameters.Add("?MaPhieuDatTiec", ct_phieudattiec.MaPhieuDatTiec);
                ObjCmd.Parameters.Add("?TenMon", ct_phieudattiec.TenMon);
                ObjCmd.Parameters.Add("?DonGia", ct_phieudattiec.DonGia);
                ObjCmd.Parameters.Add("?SoLuong", ct_phieudattiec.SoLuong);
                ObjCmd.Parameters.Add("?YeuCau", ct_phieudattiec.YeuCau);

                ObjCmd.ExecuteNonQuery();

                //Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                ObjCmd.CommandText = "Select @@IDENTITY";
                ct_phieudattiec.MaChiTietPhieuDatTiec = Convert.ToInt32(ObjCmd.ExecuteScalar());

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
            string StrSQL = "DELETE FROM chi_tiet_phieu_dat_tiec WHERE MaChiTietPhieuDatTiec = " + maphieu;

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;


            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static DataTable Find(int maphieu)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM chi_tiet_phieu_dat_tiec WHERE MaChiTietPhieuDatTiec = " + maphieu;
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;


            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
        }

        public static DataTable Find(string tenmon)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM chi_tiet_phieu_dat_tiec WHERE TenMon = " + tenmon;

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

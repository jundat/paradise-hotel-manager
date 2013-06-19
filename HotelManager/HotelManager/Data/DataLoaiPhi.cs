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
    class DataLoaiPhi
    {
        public static ArrayList GetList()
        {
            ArrayList listLoaiPhi = new ArrayList();
            string StrSQL = "SELECT * FROM loai_phi";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;
            MySqlDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                LoaiPhi loaiphi = new LoaiPhi();

                loaiphi.MaLoaiPhi = (int)ObjReader["MaLoaiPhi"];
                loaiphi.TenLoaiPhi = (string)ObjReader["TenLoaiPhi"];
                loaiphi.GhiChu = (string)ObjReader["GhiChu"];

                listLoaiPhi.Add(loaiphi);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listLoaiPhi;
        }

        public static DataTable GetTable()
        {
            DataTable table = new DataTable();
            string StrSQL = "SELECT * FROM loai_phi";
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
            string StrSQL = "SELECT * FROM loai_phi";

            MySqlDataAdapter ObjAdapter = new MySqlDataAdapter(StrSQL, ObjCn);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(ObjAdapter);

            ObjAdapter.Update(dataTable);

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static void Update(LoaiPhi loaiphi)
        {
            string StrSQL = "UPDATE loai_phi SET TenLoaiPhi = " + loaiphi.TenLoaiPhi  
                + ", GhiChu = " + loaiphi.GhiChu
                + "  WHERE MaLoaiPhi = " + loaiphi.MaLoaiPhi;


            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;





            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static bool Add(LoaiPhi loaiphi)
        {
            try
            {
                MySqlConnection ObjCn = DataProvider.getInstance().getConnection();

                string StrSQL = "INSERT INTO loai_phi(TenLoaiPhi, GhiChu) VALUES(" + loaiphi.TenLoaiPhi + "," + loaiphi.GhiChu + ");";
                MySqlCommand ObjCmd = new MySqlCommand(StrSQL, ObjCn);


                ObjCmd.ExecuteNonQuery();

                //Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                StrSQL = "Select @@IDENTITY";

                ObjCmd = new MySqlCommand(StrSQL, ObjCn);
                loaiphi.MaLoaiPhi = (int)ObjCmd.ExecuteScalar();

                //close connection
                DataProvider.getInstance().CloseConnection();

                return true;
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Dữ liệu trùng lặp: LoaiPhi " + loaiphi.TenLoaiPhi);
                }

                //close connection
                DataProvider.getInstance().CloseConnection();

                return false;
            }
        }

        public static void Delete(int maLoaiPhi)
        {
            string StrSQL = "DELETE FROM loai_phi WHERE MaLoaiPhi = " + maLoaiPhi;

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;



            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static DataTable Find(int maLoaiPhi)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM loai_phi WHERE MaLoaiPhi = " + maLoaiPhi;
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;



            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
        }

        public static DataTable Find(string tenLoaiPhi)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM loai_phi WHERE TenLoaiPhi = " + tenLoaiPhi;

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

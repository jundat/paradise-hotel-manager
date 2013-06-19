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
    class DataNhanVien
    {
        public static ArrayList GetList()
        {
            ArrayList listNhanVien = new ArrayList();
            string StrSQL = "SELECT * FROM nhan_vien";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand(); //open connection and get command
            ObjCmd.CommandText = StrSQL;
            MySqlDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                NhanVien nhanvien = new NhanVien();

                nhanvien.MaNhanVien = (int)ObjReader["MaNhanVien"];
                nhanvien.TenNhanVien = (string)ObjReader["TenNhanVien"];
                nhanvien.DiaChi = (string)ObjReader["DiaChi"];
                nhanvien.SDT = (string)ObjReader["SoDienThoai"];
                nhanvien.ChucVu = (string)ObjReader["ChucVu"];

                listNhanVien.Add(nhanvien);
            }

            //close connection
            DataProvider.getInstance().CloseConnection();

            return listNhanVien;
        }

        public static DataTable GetTable()
        {
            DataTable tableNhanvien = new DataTable();
            string StrSQL = "SELECT * FROM nhan_vien";
            MySqlDataAdapter ObjAdapter = new MySqlDataAdapter(StrSQL, DataProvider.getInstance().getConnection());
            ObjAdapter.Fill(tableNhanvien);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return tableNhanvien;
        }

        public static void UpdateTable(DataTable dataTable)
        {
            //tao chuoi ket noi.
            MySqlConnection ObjCn = DataProvider.getInstance().getConnection();
            string StrSQL = "SELECT * FROM nhan_vien";

            MySqlDataAdapter ObjAdapter = new MySqlDataAdapter(StrSQL, ObjCn);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(ObjAdapter);

            ObjAdapter.Update(dataTable);

            //close connection
            DataProvider.getInstance().CloseConnection();
        }

        public static void UpdateNhanVien(NhanVien nhanvien)
        {
            string StrSQL = "UPDATE nhan_vien SET TenNhanVien = " + nhanvien.TenNhanVien
                + ", DiaChi = " + nhanvien.DiaChi
                + ", SDT = " + nhanvien.SDT
                + ", ChucVu = " + nhanvien.ChucVu
                + ", UserName = " + nhanvien.UserName
                + ", Password = " + nhanvien.Password
                + "  WHERE MaNhanVien = " + nhanvien.MaNhanVien;


            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            


            ObjCmd.Parameters.Add("@MaNhanVien", MySqlDbType.Int32).Value = nhanvien.MaNhanVien;

            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static bool Add(NhanVien nhanvien)
        {
            try
            {
                MySqlConnection ObjCn = DataProvider.getInstance().getConnection();

                string StrSQL = "INSERT INTO nhan_vien(TenNhanVien, DiaChi, SDT, ChucVu, UserName, Password)"
                    + "VALUES(" 
                    + nhanvien.TenNhanVien + "," 
                    + nhanvien.DiaChi + ","
                    + nhanvien.SDT + ","
                    + nhanvien.ChucVu + ","
                    + nhanvien.UserName + ","
                    + nhanvien.Password + ");";


                MySqlCommand ObjCmd = new MySqlCommand(StrSQL, ObjCn);

                


                ObjCmd.ExecuteNonQuery();

                //Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                StrSQL = "Select @@IDENTITY";

                ObjCmd = new MySqlCommand(StrSQL, ObjCn);
                nhanvien.MaNhanVien = (int)ObjCmd.ExecuteScalar();

                //close connection
                DataProvider.getInstance().CloseConnection();
                
                return true;
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Dữ liệu trùng lặp: NhanVien " + nhanvien.TenNhanVien);
                }

                //close connection
                DataProvider.getInstance().CloseConnection();

                return false;
            }
        }

        public static void Delete(int maNhanVien)
        {
            string StrSQL = "DELETE FROM nhan_vien WHERE MaNhanVien = " + maNhanVien;

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;


            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static DataTable Find(int maNhanVien)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM nhan_vien WHERE MaNhanVien = " + maNhanVien;
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;



            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            //close connection
            DataProvider.getInstance().CloseConnection();

            return dt;
        }

        public static DataTable Find(string tenNhanVien)
        {
            DataTable dt = new DataTable();

            string StrSQL = "SELECT * FROM nhan_vien WHERE TenNhanVien = " + tenNhanVien;

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

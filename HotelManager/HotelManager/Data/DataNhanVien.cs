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
                nhanvien.SDT = (string)ObjReader["SDT"];
                nhanvien.ChucVu = (string)ObjReader["ChucVu"];
                nhanvien.UserName = (string)ObjReader["UserName"];
                nhanvien.Password = (string)ObjReader["Password"];

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
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = "UPDATE nhan_vien SET TenNhanVien = ?TenNhanVien, DiaChi = ?DiaChi, SDT = ?SDT, ChucVu = ?ChucVu, UserName = ?UserName, Password = ?Password WHERE MaNhanVien = ?MaNhanVien";


            ObjCmd.Parameters.Add("?MaNhanVien", nhanvien.MaNhanVien);
            ObjCmd.Parameters.Add("?TenNhanVien", nhanvien.TenNhanVien);
            ObjCmd.Parameters.Add("?DiaChi", nhanvien.DiaChi);
            ObjCmd.Parameters.Add("?SDT", nhanvien.SDT);
            ObjCmd.Parameters.Add("?ChucVu", nhanvien.ChucVu);
            ObjCmd.Parameters.Add("?UserName", nhanvien.UserName);
            ObjCmd.Parameters.Add("?Password", nhanvien.Password);

            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();

        }

        public static bool Add(NhanVien nv)
        {
            try
            {
                MySqlCommand cmd = DataProvider.getInstance().getCommand();
                cmd.CommandText = "INSERT INTO nhan_vien(TenNhanVien, DiaChi, SDT, ChucVu, UserName, Password) "
                                  + "VALUES (?TenNhanVien, ?DiaChi, ?SDT, ?ChucVu, ?UserName, ?Password)";
                
                // Truyền tham số cho câu truy vấn
                cmd.Parameters.Add("?TenNhanVien", nv.TenNhanVien);
                cmd.Parameters.Add("?DiaChi", nv.DiaChi);
                cmd.Parameters.Add("?SDT", nv.SDT);
                cmd.Parameters.Add("?ChucVu", nv.ChucVu);
                cmd.Parameters.Add("?UserName", nv.UserName);
                cmd.Parameters.Add("?Password", nv.Password);

                cmd.ExecuteNonQuery();

                cmd.CommandText = "Select @@IDENTITY";
                nv.MaNhanVien = Convert.ToInt32(cmd.ExecuteScalar());

                //close connection
                DataProvider.getInstance().CloseConnection();
                
                return true;
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Dữ liệu trùng lặp: NhanVien " + nv.TenNhanVien);
                }

                //close connection
                DataProvider.getInstance().CloseConnection();

                return false;
            }
        }

        public static void Delete(int maNhanVien)
        {
            string StrSQL = "DELETE FROM nhan_vien WHERE MaNhanVien = ?MaNhanVien";

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = "DELETE FROM nhan_vien WHERE MaNhanVien = ?MaNhanVien";

            ObjCmd.Parameters.Add("?MaNhanVien", maNhanVien);

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

        public static NhanVien FindUserPass(string user, string pass)
        {
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = "SELECT * FROM nhan_vien WHERE UserName = ?UserName AND Password = ?Password";

            ObjCmd.Parameters.Add("?UserName", user);
            ObjCmd.Parameters.Add("?Password", pass);

            MySqlDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            if(ObjReader.Read())
            {
                NhanVien nhanvien = new NhanVien();

                nhanvien.MaNhanVien = (int)ObjReader["MaNhanVien"];
                nhanvien.TenNhanVien = (string)ObjReader["TenNhanVien"];
                nhanvien.DiaChi = (string)ObjReader["DiaChi"];
                nhanvien.SDT = (string)ObjReader["SDT"];
                nhanvien.ChucVu = (string)ObjReader["ChucVu"];
                nhanvien.UserName = (string)ObjReader["UserName"];
                nhanvien.Password = (string)ObjReader["Password"];
                
                //close connection
                DataProvider.getInstance().CloseConnection();
                return nhanvien;
            }
            else
            {
                //close connection
                DataProvider.getInstance().CloseConnection();
                return null;
            }
        }

    }
}

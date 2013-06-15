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
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
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

            return listNhanVien;
        }

        public static DataTable GetTable()
        {
            DataTable tableNhanvien = new DataTable();
            string StrSQL = "SELECT * FROM nhan_vien";
            MySqlDataAdapter ObjAdapter = new MySqlDataAdapter(StrSQL, DataProvider.getInstance().getConnection());
            ObjAdapter.Fill(tableNhanvien);
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

            ObjCn.Close();
        }

        public static void UpdateNhanVien(NhanVien nhanvien)
        {
            string StrSQL = "UPDATE nhan_vien SET TenNhanVien = ?, DiaChi = ?, SDT = ?, ChucVu = ?, UserName = ?, Password = ?  WHERE MaNhanVien = ?";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@TenNhanVien", MySqlDbType.String).Value = nhanvien.TenNhanVien;
            ObjCmd.Parameters.Add("@DiaChi", MySqlDbType.String).Value = nhanvien.DiaChi;
            ObjCmd.Parameters.Add("@SDT", MySqlDbType.String).Value = nhanvien.SDT;
            ObjCmd.Parameters.Add("@ChucVu", MySqlDbType.String).Value = nhanvien.ChucVu;
            ObjCmd.Parameters.Add("@UserName", MySqlDbType.String).Value = nhanvien.UserName;
            ObjCmd.Parameters.Add("@Password", MySqlDbType.String).Value = nhanvien.Password;

            ObjCmd.Parameters.Add("@MaNhanVien", MySqlDbType.Int32).Value = nhanvien.MaNhanVien;

            ObjCmd.ExecuteNonQuery();
        }

        public static bool Add(NhanVien nhanvien)
        {
            try
            {
                MySqlConnection ObjCn = DataProvider.getInstance().getConnection();

                string StrSQL = "INSERT INTO nhan_vien(TenNhanVien, DiaChi, SDT, ChucVu, UserName, Password) VALUES(?, ?, ?, ?, ?, ?);";
                MySqlCommand ObjCmd = new MySqlCommand(StrSQL, ObjCn);

                ObjCmd.Parameters.Add("@TenNhanVien", MySqlDbType.String).Value = nhanvien.TenNhanVien;
                ObjCmd.Parameters.Add("@DiaChi", MySqlDbType.String).Value = nhanvien.DiaChi;
                ObjCmd.Parameters.Add("@SDT", MySqlDbType.String).Value = nhanvien.SDT;
                ObjCmd.Parameters.Add("@ChucVu", MySqlDbType.String).Value = nhanvien.ChucVu;
                ObjCmd.Parameters.Add("@UserName", MySqlDbType.String).Value = nhanvien.UserName;
                ObjCmd.Parameters.Add("@Password", MySqlDbType.String).Value = nhanvien.Password;

                ObjCmd.ExecuteNonQuery();

                //Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                StrSQL = "Select @@IDENTITY";

                ObjCmd = new MySqlCommand(StrSQL, ObjCn);
                nhanvien.MaNhanVien = (int)ObjCmd.ExecuteScalar();

                return true;
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Dữ liệu trùng lặp: NhanVien " + nhanvien.TenNhanVien);
                }
                return false;
            }
        }

        public static void Delete(int maNhanVien)
        {
            string StrSQL = "DELETE FROM nhan_vien WHERE MaNhanVien = ?";

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@MaNhanVien", MySqlDbType.Int32).Value = maNhanVien;

            ObjCmd.ExecuteNonQuery();
        }

        public static DataTable Find(int maNhanVien)
        {
            DataTable dt = new DataTable();
            
            string StrSQL = "SELECT * FROM nhan_vien WHERE MaNhanVien = ?";
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@MaNhanVien", MySqlDbType.Int32).Value = maNhanVien;

            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            return dt;
        }

        public static DataTable Find(string tenNhanVien)
        {
            DataTable dt = new DataTable();
            
            string StrSQL = "SELECT * FROM nhan_vien WHERE TenNhanVien = ?";

            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = StrSQL;

            ObjCmd.Parameters.Add("@TenNhanVien", MySqlDbType.String).Value = tenNhanVien;

            MySqlDataAdapter adapter = new MySqlDataAdapter(ObjCmd);
            adapter.Fill(dt);

            return dt;
        }

    }
}

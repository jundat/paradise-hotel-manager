using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    public class NhanVien
    {
        public int MaNhanVien;
        public string TenNhanVien;
        public string DiaChi;
        public string SDT;
        public string ChucVu;
        public string UserName;
        public string Password;

        public NhanVien()
        {
            MaNhanVien = 0;
            TenNhanVien = "";
            DiaChi = "";
            SDT = "";
            ChucVu = "";
            UserName = "";
            Password = "";
        }

        public NhanVien(int manhanvien, string ten, string diachi, string sdt, string chucvu, string user, string pass)
        {
            MaNhanVien = manhanvien;
            TenNhanVien = ten;
            DiaChi = diachi;
            SDT = sdt;
            ChucVu = chucvu;
            UserName = user;
            Password = pass;
        }
    }
}

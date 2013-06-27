using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    public class ChiTietPhieuDen
    {
        public int MaChiTietPhieuDen;
        public int MaPhieuDen;
        public int MaPhong;
        public string TenKhachHang;
        public string CMND;
        public float DonGia;

        public ChiTietPhieuDen()
        {
            MaChiTietPhieuDen = 0;
            MaPhieuDen = 0;
            MaPhong = 0;
            TenKhachHang = "";
            CMND = "";
            DonGia = 0;
        }

        public ChiTietPhieuDen(int machitiet, int maphieuden, int maphong, string tenkhach, string cmnd, float dongia)
        {
            MaChiTietPhieuDen = machitiet;
            MaPhieuDen = maphieuden;
            MaPhong = maphong;
            TenKhachHang = tenkhach;
            CMND = cmnd;
            DonGia = dongia;
        }
    }
}

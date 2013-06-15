using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class ChiTietPhieuDen
    {
        public int MaChiTietPhieuDen;
        public int MaPhieuDen;
        public string TenKhachHang;
        public string CMND;
        public float DonGia;

        public ChiTietPhieuDen(int machitiet, int maphieuden, string tenkhach, string cmnd, float dongia)
        {
            MaChiTietPhieuDen = machitiet;
            MaPhieuDen = maphieuden;
            TenKhachHang = tenkhach;
            CMND = cmnd;
            DonGia = dongia;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class ChiTietPhieuDatTiec
    {
        public int MaChiTietPhieuDatTiec;
        public int MaPhieuDatTiec;
        public string TenMon;
        public float DonGia;
        public int SoLuong;
        public string YeuCau;

        public ChiTietPhieuDatTiec(int machitiet, int maphieu, string tenmon, float dongia, int soluong, string yeucau)
        {
            MaChiTietPhieuDatTiec = machitiet;
            MaPhieuDatTiec = maphieu;
            TenMon = tenmon;
            DonGia = dongia;
            SoLuong = soluong;
            YeuCau = yeucau;
        }
    }
}

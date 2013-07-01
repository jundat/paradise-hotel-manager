using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    public class PhieuDatTiec
    {
        public int MaPhieuDatTiec;
        public string TenKhach;
        public int MaPhong;
        public DateTime ThoiDiem;
        public float TongTien;
        public bool TinhTrangThanhToan;

        public PhieuDatTiec()
        {
            MaPhieuDatTiec = 0;
            TenKhach = "";
            MaPhong = 0;
            ThoiDiem = new DateTime();
            TongTien = 0;
            TinhTrangThanhToan = false; // Mặc định là chưa thanh toán (false)
        }

        public PhieuDatTiec(int maphieudattiec, string tenkhach, int maphong, DateTime thoidiem, float tongtien, bool tinhtrang)
        {
            MaPhieuDatTiec = maphieudattiec;
            TenKhach = tenkhach;
            MaPhong = maphong;
            ThoiDiem = thoidiem;
            TongTien = tongtien;
            TinhTrangThanhToan = tinhtrang;
        }
    }
}

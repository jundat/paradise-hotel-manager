using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class HoaDon : EntityAbstract
    {
        public int MaHoaDon;
        public DateTime NgayLapHoaDon;
        public decimal TriGia;
        public string TenKhachHang;
        public string DiaChi;

        public HoaDon() { }

        public HoaDon(int _mahoadon, DateTime _ngay, decimal _trigia, string _tenkhach, string _diachi)
        {
            MaHoaDon = _mahoadon;
            NgayLapHoaDon = _ngay;
            TriGia = _trigia;
            TenKhachHang = _tenkhach;
            DiaChi = _diachi;
        }
    }
}

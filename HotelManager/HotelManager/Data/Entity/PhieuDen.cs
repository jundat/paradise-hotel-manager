using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class PhieuDen
    {
        public int MaPhieuDen;
        public string TenKhachDaiDien;
        public string CMND;
        public DateTime ThoiDiemDen;
        public DateTime ThoiDiemDi;
        public float TongChiPhi;
        public bool TinhTrangThanhToan;

        public PhieuDen()
        {
            MaPhieuDen = 0;
            TenKhachDaiDien = "";
            ThoiDiemDen = new DateTime();
            ThoiDiemDi = new DateTime();
            TongChiPhi = 0;
            TinhTrangThanhToan = false;
        }

        public PhieuDen(int maphieu, string tenkhach, string cmnd, DateTime thoidiemden, DateTime thoidiemdi, float tongchiphi, bool tinhtrangthanhtoan)
        {
            MaPhieuDen = maphieu;
            TenKhachDaiDien = tenkhach;
            ThoiDiemDen = thoidiemden;
            ThoiDiemDi = thoidiemdi;
            TongChiPhi = tongchiphi;
            TinhTrangThanhToan = tinhtrangthanhtoan;
        }
    }
}

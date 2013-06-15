using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class PhieuThu
    {
        public int MaPhieuThu;
        public string TenKhach;
        public string CMND;
        public int MaNhanVien;
        public DateTime ThoiDiemThu;
        public float TongTienThu;

        public PhieuThu(int maphieu, string tenkhach, string cmnd, int manhanvien, DateTime thoidiemthu, float tongtien)
        {
            MaPhieuThu = maphieu;
            TenKhach = tenkhach;
            CMND = cmnd;
            MaNhanVien = manhanvien;
            ThoiDiemThu = thoidiemthu;
            TongTienThu = tongtien;
        }
    }
}

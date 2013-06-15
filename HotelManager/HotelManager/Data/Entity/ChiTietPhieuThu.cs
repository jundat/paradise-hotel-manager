using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class ChiTietPhieuThu
    {
        public int MaChiTietPhieuThu;
        public int MaPhieuThu;
        public int MaLoaiPhi;
        public float SoTienThu;

        public ChiTietPhieuThu(int machitiet, int maphieu, int maloaiphi, float sotien)
        {
            MaChiTietPhieuThu = machitiet;
            MaPhieuThu = maphieu;
            MaLoaiPhi = maloaiphi;
            SoTienThu = sotien;
        }
    }
}

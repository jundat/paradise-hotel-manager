using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class BangKe
    {
        public int MaBangKe;
        public int MaPhong;
        public float TongChiPhi;
        public Boolean TinhTrangThanhToan;

        public BangKe()
        {
            MaBangKe = 0;
            MaPhong = 0;
            TongChiPhi = 0;
            TinhTrangThanhToan = false;
        }

        public BangKe(int _maBangKe, int _maPhong, float _tongChiPhi, Boolean _tinhTrangThanhToan)
        {
            MaBangKe = _maBangKe;
            MaPhong = _maPhong;
            TongChiPhi = _tongChiPhi;
            TinhTrangThanhToan = _tinhTrangThanhToan;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class BaoCaoDoanhThu
    {
        public int MaBaoCaoDoanhThu;
        public int MaPhong;
        public float DoanhThu;
        public float TyLeDoanhThu;
        public DateTime ThoiDiemLapBaoCao;

        public BaoCaoDoanhThu()
        {
            MaBaoCaoDoanhThu = 0;
            MaPhong = 0;
            DoanhThu = 0;
            TyLeDoanhThu = 0;
            ThoiDiemLapBaoCao = new DateTime();
        }

        public BaoCaoDoanhThu(int _maBaoCaoDoanhThu, int _maPhong, float _doanhThu, float _tyLeDoanhThu, DateTime _thoiDiemLapBaoCao)
        {
            MaBaoCaoDoanhThu = _maBaoCaoDoanhThu;
            MaPhong = _maPhong;
            DoanhThu = _doanhThu;
            TyLeDoanhThu = _tyLeDoanhThu;
            ThoiDiemLapBaoCao = _thoiDiemLapBaoCao;
        }
    }
}

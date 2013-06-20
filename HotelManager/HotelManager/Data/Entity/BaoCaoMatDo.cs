using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class BaoCaoMatDo
    {
        public int MaBaoCaoMatDo;
        public int MaPhong;
        public float SoNgayThue;
        public float TyLe;
        public DateTime ThoiDiemLapBaoCao;

        public BaoCaoMatDo()
        {
            MaBaoCaoMatDo = 0;
            MaPhong = 0;
            SoNgayThue = 0;
            TyLe = 0;
            ThoiDiemLapBaoCao = new DateTime();
        }

        public BaoCaoMatDo(int _maBaoCaoDoanhThu, int _maPhong, float _doanhThu, float _tyLeDoanhThu, DateTime _thoiDiemLapBaoCao)
        {
            MaBaoCaoMatDo = _maBaoCaoDoanhThu;
            MaPhong = _maPhong;
            SoNgayThue = _doanhThu;
            TyLe = _tyLeDoanhThu;
            ThoiDiemLapBaoCao = _thoiDiemLapBaoCao;
        }
    }
}

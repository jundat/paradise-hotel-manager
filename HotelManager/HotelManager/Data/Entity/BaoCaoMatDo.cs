using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    public class BaoCaoMatDo
    {
        public int MaBaoCaoMatDo;
        public DateTime ThoiDiemLapBaoCao;
        public int MaPhong;
        public float SoGioThue;
        public float TyLe;

        public BaoCaoMatDo()
        {
            MaBaoCaoMatDo = 0;
            MaPhong = 0;
            SoGioThue = 0;
            TyLe = 0;
            ThoiDiemLapBaoCao = new DateTime();
        }

        public BaoCaoMatDo(int _maBaoCaoMatDo, DateTime _thoiDiemLapBaoCao, int _maPhong, float _soGioThue, float _tyLe)
        {
            MaBaoCaoMatDo = _maBaoCaoMatDo;
            ThoiDiemLapBaoCao = _thoiDiemLapBaoCao;
            MaPhong = _maPhong;
            SoGioThue = _soGioThue;
            TyLe = _tyLe;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class QuyDinh
    {
        public int SoKhachToiDaTrongMotPhong;
        public float TyLeCoc;
        public int SoGioThueVoiGiaGoc;
        public float TyLeGiaPhongNeuThueTheoNgay;

        public QuyDinh(int _soKhachToiDaTrongMotPhong, float _tyLeCoc, int _soGioThueVoiGiaGoc, float _tyLeGiaPhongNeuThueTheoNgay)
        {
            SoKhachToiDaTrongMotPhong = _soKhachToiDaTrongMotPhong;
            TyLeCoc = -_tyLeCoc;
            SoGioThueVoiGiaGoc = _soGioThueVoiGiaGoc;
            TyLeGiaPhongNeuThueTheoNgay = _tyLeGiaPhongNeuThueTheoNgay;
        }
    }
}

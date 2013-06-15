using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class BaoCaoDoanhThu
    {
        public int MabaoCaoDoanhThu;
        public int MaPhong;
        public float DoanhThu;
        public float TyLeDoanhThu;

        public BaoCaoDoanhThu(int _maBaoCaoDoanhThu, int _maPhong, float _doanhThu, float _tyLeDoanhThu)
        {
            MabaoCaoDoanhThu = _maBaoCaoDoanhThu;
            MaPhong = _maPhong;
            DoanhThu = _doanhThu;
            TyLeDoanhThu = _tyLeDoanhThu;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class Phong
    {
        public int MaPhong;
        public int MaLoaiPhong;
        public Boolean TinhTrangHienTai;
        public String MoTa;

        public Phong()
        {
            MaPhong = 0;
            MaLoaiPhong = 0;
            TinhTrangHienTai = true;
            MoTa = "";
        }

        public Phong(int _maPhong, int _maLoaiPhong, Boolean _tinhTrangPhong, String _moTa)
        {
            MaPhong = _maPhong;
            MaLoaiPhong = _maLoaiPhong;
            TinhTrangHienTai = _tinhTrangPhong;
            MoTa = _moTa;
        }
    }
}

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
        public String TenPhong;
        public Boolean TinhTrangHienTai;
        public String MoTa;

        public Phong()
        {
            MaPhong = 0;
            MaLoaiPhong = 0;
            TenPhong = "";
            TinhTrangHienTai = true;
            MoTa = "";
        }

        public Phong(int _maPhong, int _maLoaiPhong, String _tenPhong, Boolean _tinhTrangPhong, String _moTa)
        {
            MaPhong = _maPhong;
            MaLoaiPhong = _maLoaiPhong;
            TinhTrangHienTai = _tinhTrangPhong;
            MoTa = _moTa;
        }
    }
}

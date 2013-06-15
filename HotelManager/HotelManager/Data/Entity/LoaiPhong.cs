using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class LoaiPhong
    {
        public int MaLoaiPhong;
        public String TenLoaiPhong;
        public float DonGia;

        public LoaiPhong()
        {
            MaLoaiPhong = 0;
            TenLoaiPhong = "";
            DonGia = 0;
        }

        public LoaiPhong(int _maLoaiPhong, String _tenLoaiPhong, float _donGia)
        {
            MaLoaiPhong = _maLoaiPhong;
            TenLoaiPhong = _tenLoaiPhong;
            DonGia = _donGia;
        }
    }
}

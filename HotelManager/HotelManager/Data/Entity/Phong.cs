using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    /// <summary>
    /// Lưu các thông tin về một phòng
    /// </summary>
    public class Phong : EntityAbstract
    {
        public int MaPhong;
        public string TenPhong;
        public int MaLoaiPhong;
        public bool TinhTrang; //true: đã thuê, false: trống
        public string GhiChu;

        public Phong() 
        {
            TinhTrang = false;
        }

        public Phong(int _maPhong, string _tenPhong, int _maLoaiPhong, bool _tinhTrang, string _ghiChu)
        {
            MaPhong = _maPhong;
            TenPhong = _tenPhong;
            MaLoaiPhong = _maLoaiPhong;
            TinhTrang = _tinhTrang;
            GhiChu = _ghiChu;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    /// <summary>
    /// Lưu trữ thông tin 1 loại phòng
    /// </summary>
    public class LoaiPhong : EntityAbstract
    {
        public int MaLoaiPhong;
        public string TenLoaiPhong;
        public decimal DonGia;

        public LoaiPhong() { }

        public LoaiPhong(int _maLoaiPhong, string _tenLoaiPhong, decimal _dongia)
        {
            MaLoaiPhong = _maLoaiPhong;
            TenLoaiPhong = _tenLoaiPhong;
            DonGia = _dongia;
        }
    }

}

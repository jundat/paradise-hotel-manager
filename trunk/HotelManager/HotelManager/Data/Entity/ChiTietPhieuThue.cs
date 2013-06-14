using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    /// <summary>
    /// Lưu thông tin 1 Chi Tiết Phiếu Thuê Phòng
    /// </summary>
    public class ChiTietPhieuThue : EntityAbstract
    {
        public int MaChiTietPhieuThue;
        public int MaPhieuThue;
        public string TenKhachHang;
        public string DiaChi;
        public string CMND;
        public int MaLoaiKhach;

        public ChiTietPhieuThue() { }

        public ChiTietPhieuThue(int _maCTPT, int _maPhieuThue, string _tenKhachHang,
            string _diachi, string _cmnd, int _maLoaiKhach)
        {
            MaChiTietPhieuThue = _maCTPT;
            MaPhieuThue = _maPhieuThue;
            TenKhachHang = _tenKhachHang;
            DiaChi = _diachi;
            CMND = _cmnd;
            MaLoaiKhach = _maLoaiKhach;
        }
    }
}

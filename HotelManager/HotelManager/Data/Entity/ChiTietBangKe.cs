using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class ChiTietBangKe
    {
        public int MaChiTietBangKe;
        public int MaBangKe;
        public String TenDichVu;
        public DateTime ThoiDiemGoi;
        public float DonGia;
        public int SoLuong;
        public String GhiChu;

        public ChiTietBangKe()
        {
            MaChiTietBangKe = 0;
            MaBangKe = 0;
            TenDichVu = "";
            ThoiDiemGoi = new DateTime();
            DonGia = 0;
            SoLuong = 0;
            GhiChu = "";
        }

        public ChiTietBangKe(int _maChiTietBangKe, int _maBangKe, String _tenDichVu, DateTime _thoiDiemGoi, float _donGia, int _soLuong, String _ghiChu)
        {
            MaChiTietBangKe = _maChiTietBangKe;
            MaBangKe = _maBangKe;
            TenDichVu = _tenDichVu;
            ThoiDiemGoi = _thoiDiemGoi;
            DonGia = _donGia;
            SoLuong = _soLuong;
            GhiChu = _ghiChu;
        }
    }
}

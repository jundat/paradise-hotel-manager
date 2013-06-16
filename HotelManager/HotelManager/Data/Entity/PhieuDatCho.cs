using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class PhieuDatCho
    {
        public int MaPhieuDatCho;
        public String TenNguoiDatCho;
        public String SDT;
        public String DiaChi;
        public float TongCoc;
        public DateTime ThoiDiemDat;
        public DateTime ThoiDiemDen;
        public DateTime ThoiDiemDi;

        public PhieuDatCho()
        {
            MaPhieuDatCho = 0;
            TenNguoiDatCho = "";
            SDT = "";
            DiaChi = "";
            TongCoc = 0;
            ThoiDiemDat = new DateTime();
            ThoiDiemDen = new DateTime();
            ThoiDiemDi = new DateTime();
        }

        public PhieuDatCho(int _maPhieDatCho, String _tenNguoiDatCho, String _sdt, String _diaChi, float _tongCoc, DateTime _thoiDiemDat, DateTime _thoiDiemDen, DateTime _thoiDiemDi)
        {
            MaPhieuDatCho = _maPhieDatCho;
            TenNguoiDatCho = _tenNguoiDatCho;
            SDT = _sdt;
            DiaChi = _diaChi;
            TongCoc = _tongCoc;
            ThoiDiemDat = _thoiDiemDat;
            ThoiDiemDen = _thoiDiemDen;
            ThoiDiemDi = _thoiDiemDi;
        }
    }
}

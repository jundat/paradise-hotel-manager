using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    class ChiTietPhieuDatCho
    {
        public int MaChiTietPhieuDatCho;
        public int MaPhieuDatCho;
        public int MaPhong;
        public float DonGia;
        public float Coc;

        public ChiTietPhieuDatCho(int _maChiTietPhieuDatCho, int _maPhieuDatCho, int _maPhong, float _donGia, float _coc)
        {
            MaChiTietPhieuDatCho = _maChiTietPhieuDatCho;
            MaPhieuDatCho = _maPhieuDatCho;
            MaPhong = _maPhong;
            DonGia = _donGia;
            Coc = _coc;
        }
    }
}

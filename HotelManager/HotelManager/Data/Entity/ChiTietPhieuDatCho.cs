using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    public class ChiTietPhieuDatCho
    {
        public int MaChiTietPhieuDatCho;
        public int MaPhieuDatCho;
        public int MaPhong;
        public float DonGia;
        public float Coc;

        public ChiTietPhieuDatCho()
        {
            MaChiTietPhieuDatCho = 0;
            MaPhieuDatCho = 0;
            MaPhong = 0;
            DonGia = 0;
            Coc = 0;
        }

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

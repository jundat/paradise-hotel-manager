using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    /// <summary>
    /// Lưu các thông tin của ChiTietBCMD
    /// </summary>
    class ChiTietBCMD : EntityAbstract
    {
        public int MaChiTietBCMD;
        public int MaPhong;
        public int SoNgayThue;
        public double TyLe;
        public int MaBCMD;

        public ChiTietBCMD() { }

        public ChiTietBCMD(int _maChiTietBCMD, int _maPhong, int _soNgayThue, double _tyle, int _maBCMD)
        {
            MaChiTietBCMD = _maChiTietBCMD;
            MaPhong = _maPhong;
            SoNgayThue = _soNgayThue;
            TyLe = _tyle;
            MaBCMD = _maBCMD;
        }
    }
}

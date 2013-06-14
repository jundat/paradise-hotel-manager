using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    /// <summary>
    /// Lưu trữ thông tin về 1 Phiếu Thuê Phòng
    /// </summary>
    public class PhieuThuePhong : EntityAbstract
    {
        public int MaPhieuThue;
        public int MaPhong;
        public DateTime NgayBatDauThue;
        public decimal DonGiaThue; //http://stackoverflow.com/questions/693372/what-is-the-best-dataPhuThu-type-to-use-for-money-in-c
        public DateTime NgayTraPhong; //

        public PhieuThuePhong() { }

        public PhieuThuePhong(int _maPhieuThue, int _maPhong, DateTime _ngayBatDauThue, decimal _donGiaThue, DateTime _ngayTraPhong)
        {
            MaPhieuThue = _maPhieuThue;
            MaPhong = _maPhong;
            NgayBatDauThue = _ngayBatDauThue;
            DonGiaThue = _donGiaThue;
            NgayTraPhong = _ngayTraPhong;
        }

    }
}

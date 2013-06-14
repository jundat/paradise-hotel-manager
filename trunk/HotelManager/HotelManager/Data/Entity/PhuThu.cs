using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    /// <summary>
    /// Lưu thông tin Phụ Thu
    /// </summary>
    class PhuThu : EntityAbstract
    {
        public int SoLuongKhach;
        public double TyLePhuThu;

        public PhuThu() { }

        public PhuThu(int _soluongkhach, double _tylephuthu)
        {
            SoLuongKhach = _soluongkhach;
            TyLePhuThu = _tylephuthu;
        }
    }
}

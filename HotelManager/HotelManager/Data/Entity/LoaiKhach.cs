using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    /// <summary>
    /// Lưu thông tin 1 LoaiKhach
    /// </summary>
    public class LoaiKhach : EntityAbstract
    {
        public int MaLoaiKhach;
        public string TenLoaiKhach;
        public double HeSo;

        public LoaiKhach() { }

        public LoaiKhach(int _maLoaiKhach, string _tenLoaiKhach, double _HeSo)
        {
            MaLoaiKhach = _maLoaiKhach;
            TenLoaiKhach = _tenLoaiKhach;
            HeSo = _HeSo;
        }
    }
}

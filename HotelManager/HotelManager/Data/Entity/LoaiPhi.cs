using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    public class LoaiPhi
    {
        public int MaLoaiPhi;
        public string TenLoaiPhi;
        public string GhiChu;

        public LoaiPhi()
        {
            MaLoaiPhi = 0;
            TenLoaiPhi = "";
            GhiChu = "";
        }

        public LoaiPhi(int maloaiphi, string tenloaiphi, string ghichu)
        {
            MaLoaiPhi = maloaiphi;
            TenLoaiPhi = tenloaiphi;
            GhiChu = ghichu;
        }
    }
}

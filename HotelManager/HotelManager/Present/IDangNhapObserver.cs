using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HotelManager.Data.Entity;

namespace HotelManager.Present
{
    public interface IDangNhapObserver
    {
        void RecieveUser(NhanVien nv);
    }
}

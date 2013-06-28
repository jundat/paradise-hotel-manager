using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HotelManager.Data.Entity;

namespace HotelManager.Present
{
    public interface IDangNhapSubject
    {
        void RegisterObserver(IDangNhapObserver o);
        void RemoveObserver(IDangNhapObserver o);
        void NotifyDangNhap(NhanVien nv);
    }
}

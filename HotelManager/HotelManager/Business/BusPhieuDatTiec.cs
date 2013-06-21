using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Collections;
using HotelManager.Data;
using HotelManager.Data.Entity;

namespace HotelManager.Business
{
    class BusPhieuDatTiec
    {
        public static ArrayList GetList()
        {
            return DataPhieuDatTiec.GetList();
        }

        /// <summary>
        /// Tìm kiếm danh sách Phiếu đặt tiệc thỏa mãn
        /// </summary>
        /// <param name="tenKhach"></param>
        /// <param name="tenPhong"></param>
        /// <param name="tinhTrangThanhToan"></param>
        /// <returns></returns>
        public static ArrayList Find(String tenKhach, int maPhong, String tinhTrangThanhToan)
        {
            return DataPhieuDatTiec.Find(tenKhach, maPhong, tinhTrangThanhToan);
        }

        public static DataTable GetTable()
        {
            return DataPhieuDatTiec.GetTable();
        }

        public static void UpdateTable(DataTable dataTable)
        {
            DataPhieuDatTiec.UpdateTable(dataTable);
        }

        public static void UpdatePhieuDatTiec(PhieuDatTiec phieudattiec)
        {
            DataPhieuDatTiec.UpdatePhieuDatTiec(phieudattiec);
        }

        public static void UpdateTrangThai(int maphieu, bool trangthai)
        {
            DataPhieuDatTiec.UpdateTrangThai(maphieu, trangthai);
        }

        public static bool Add(PhieuDatTiec phieudattiec)
        {
            return DataPhieuDatTiec.Add(phieudattiec);
        }

        public static void Delete(int maphieu)
        {
            DataPhieuDatTiec.Delete(maphieu);
        }

        public static DataTable Find(int maphieu)
        {
            return DataPhieuDatTiec.Find(maphieu);
        }

        public static DataTable Find(string tenkhach)
        {
            return DataPhieuDatTiec.Find(tenkhach);
        }


        public static ArrayList Find(int _maPhong, bool _tinhTrangThanhToan)
        {
            return DataPhieuDatTiec.Find(_maPhong, _tinhTrangThanhToan);
        }

        /// <summary>
        /// Tìm danh sách các phiếu đặt tiệc chưa đc thanh toán và Mã phòng của khách đặt nó
        /// </summary>
        /// <param name="maPhong"></param>
        /// <param name="tinhTrangThanhToan"></param>
        /// <returns></returns>
        public static ArrayList FindTheoMaPhongVaTinhTrangThanhToan(int maPhong, bool tinhTrangThanhToan)
        {
            return DataPhieuDatTiec.FindTheoMaPhongVaTinhTrangThanhToan(maPhong, tinhTrangThanhToan);
        }
    }
}

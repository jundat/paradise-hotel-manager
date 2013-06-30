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
    class BusChiTietPhieuDen
    {
        public static ArrayList GetList(int maPhieuDen)
        {
            return DataChiTietPhieuDen.GetList(maPhieuDen);
        }

        public static ArrayList GetList()
        {
            return DataChiTietPhieuDen.GetList();
        }

        public static DataTable GetTable()
        {
            return DataChiTietPhieuDen.GetTable();
        }

        public static void UpdateTable(DataTable dataTable)
        {
            DataChiTietPhieuDen.UpdateTable(dataTable);
        }

        public static void UpdateChiTietPhieuDen(ChiTietPhieuDen ct_PhieuDen)
        {
            DataChiTietPhieuDen.UpdateChiTietPhieuDen(ct_PhieuDen);
        }

        public static bool Add(ChiTietPhieuDen ct_PhieuDen)
        {
            return DataChiTietPhieuDen.Add(ct_PhieuDen);
        }

        public static void Delete(int maCTPhieuDen)
        {
            DataChiTietPhieuDen.Delete(maCTPhieuDen);
        }

        public static DataTable Find(int maCTPhieuDen)
        {
            return DataChiTietPhieuDen.Find(maCTPhieuDen);
        }

        public static ArrayList FindMaPhong(int maphong)
        {
            return DataChiTietPhieuDen.FindMaPhong(maphong);
        }

        public static DataTable FindMaPhieuDen(int maPhieuDen)
        {
            return DataChiTietPhieuDen.FindMaPhieuDen(maPhieuDen);
        }


        /// <summary>
        /// Tìm danh sách Chi Tiết Phiếu Đến có mã phòng và tình Trạng thanh toán truyền vô
        /// </summary>
        /// <param name="maPhong"></param>
        /// <param name="tinhTrangThanhToan"></param>
        /// <returns></returns>
        public static ArrayList FindDanhSachChiTiet(int maPhong, bool tinhTrangThanhToan)
        {
            return DataChiTietPhieuDen.FindDanhSachChiTiet(maPhong, tinhTrangThanhToan);
        }

        /// <summary>
        /// Tìm danh sách chi tiết Phiếu đến theo tên khách và tình trạng lưu trú của khách
        /// </summary>
        /// <param name="tenKhach"></param>
        /// <param name="tinhTrang"></param>
        /// <returns></returns>
        public static ArrayList FindDanhSachChiTietPhieuDenTheoTenKhach(String tenKhach, String tinhTrang)
        {
            return DataChiTietPhieuDen.FindDanhSachChiTietPhieuDenTheoTenKhach(tenKhach, tinhTrang);
        }

        /// <summary>
        /// Tìm danh sách chi tiết Phiếu đến theo CMND và tình trạng lưu trú của khách
        /// </summary>
        /// <param name="tenKhach"></param>
        /// <param name="tinhTrang"></param>
        /// <returns></returns>
        public static ArrayList FindDanhSachChiTietPhieuDenTheoCMND(String CMND, String tinhTrang)
        {
            return DataChiTietPhieuDen.FindDanhSachChiTietPhieuDenTheoCMND(CMND, tinhTrang);
        }

        /// <summary>
        /// Tìm danh sách các Chi tiết phiếu đến của các Phiếu đến có thời gian lưu trú nằm giữa 2 khoảng thời gian Từ Đến
        /// </summary>
        /// <param name="tu"></param>
        /// <param name="den"></param>
        /// <returns></returns>
        public static ArrayList FindDanhSachChiTietPhieuDenTrongKhoangThoiGian(DateTime tu, DateTime den)
        {
            return DataChiTietPhieuDen.FindDanhSachChiTietPhieuDenTrongKhoangThoiGian(tu, den);
        }

        /// <summary>
        /// Tìm danh sách Mã phòng theo Mã phiếu đến trong bảng CHI_TIET_PHIEU_DEN
        /// </summary>
        /// <param name="MaPhieuDen"></param>
        /// <returns></returns>
        public static ArrayList FindMaPhongCuaMaPhieuDen(int MaPhieuDen)
        {
            return DataChiTietPhieuDen.FindMaPhongCuaMaPhieuDen(MaPhieuDen);
        }
    }
}

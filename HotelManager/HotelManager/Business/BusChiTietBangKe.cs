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
    class BusChiTietBangKe
    {
        /// <summary>
        /// Lấy danh sách các Chi Tiết Bảng Kê dưới dạng List
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetList()
        {
            return DataChiTietChiTietBangKe.GetList();
        }

        /// <summary>
        /// Lấy tất cả các dòng chi_tiet_bang_ke có Mã Bảng kê nhập vô
        /// </summary>
        /// <param name="_maBangKe">Mã bảng kê cần tìm chi tiết của nó</param>
        /// <returns></returns>
        public static ArrayList GetList(int _maBangKe)
        {
            return DataChiTietChiTietBangKe.GetList(_maBangKe);
        }

        /// <summary>
        /// Lấy hết bảng chi_tiet_bang_ke
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            return DataChiTietChiTietBangKe.GetTable();
        }

        /// <summary>
        /// Update giá trị mới cho bảng chi_tiet_bang_ke
        /// </summary>
        /// <param name="dataTable"></param>
        public static void UpdateTable(DataTable dataTable)
        {
            DataChiTietChiTietBangKe.UpdateTable(dataTable);
        }

        /// <summary>
        /// Thêm Bảng Kê mới
        /// </summary>
        /// <param name="_phieu"></param>
        /// <returns>Trả về MaChiTietBangKe nếu thành công, ngược lại -1</returns>
        public static int Add(ChiTietBangKe _chiTietBangKe)
        {
            return DataChiTietChiTietBangKe.Add(_chiTietBangKe);
        }

        /// <summary>
        /// Xoá một Bảng kê
        /// </summary>
        /// <param name="_maChiTietBangKe"></param>
        public static void Delete(int _maChiTietBangKe)
        {
            DataChiTietChiTietBangKe.Delete(_maChiTietBangKe);
        }

        /// <summary>
        /// Sửa 1 Loại Phòng
        /// </summary>
        /// <param name="_phieu"></param>
        public static void UpdateChiTietBangKe(ChiTietBangKe _chiTietBangKe)
        {
            DataChiTietChiTietBangKe.UpdateChiTietBangKe(_chiTietBangKe);
        }

        /// <summary>
        /// Tìm kiêm một Bảng kê thông qua Mã Chi Tiết bảng kê
        /// </summary>
        /// <param name="_maLoaiPhong"></param>
        /// <returns></returns>
        public static ChiTietBangKe Find(int _maChiTietBangKe)
        {
            return DataChiTietChiTietBangKe.Find(_maChiTietBangKe);
        }
    }
}

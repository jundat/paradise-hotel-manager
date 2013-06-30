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
    class BusBangKe
    {
        /// <summary>
        /// Lấy danh sách các bảng kê dưới dạng List
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetList()
        {
            return DataBangKe.GetList();
        }

        /// <summary>
        /// Tim danh sách Bảng kê
        /// </summary>
        /// <param name="tenPhong"></param>
        /// <param name="tinhTrangThanhToan"></param>
        /// <returns></returns>
        public static ArrayList Find(int maPhong, String tinhTrangThanhToan)
        {
            return DataBangKe.Find(maPhong, tinhTrangThanhToan);
        }

        /// <summary>
        /// Lấy hết bảng BANG_KE
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            return DataBangKe.GetTable();
        }

        /// <summary>
        /// Update giá trị mới cho bảng BANG_KE
        /// </summary>
        /// <param name="dataTable"></param>
        public static void UpdateTable(DataTable dataTable)
        {
            DataBangKe.UpdateTable(dataTable);
        }


        public static void UpdateTrangThai(int maBangKe, bool trangthai)
        {
            DataBangKe.UpdateTrangThai(maBangKe, trangthai);
        }


        /// <summary>
        /// Thêm Bảng Kê mới
        /// </summary>
        /// <param name="_phieu"></param>
        /// <returns>Trả về MaBangKE nếu thành công, ngược lại -1</returns>
        public static int Add(BangKe _bangKe)
        {
            return DataBangKe.Add(_bangKe);
        }

        /// <summary>
        /// Xoá một Bảng kê
        /// </summary>
        /// <param name="_maBangKe"></param>
        public static void Delete(int _maBangKe)
        {
            DataBangKe.Delete(_maBangKe);
        }

        /// <summary>
        /// Sửa 1 Loại Phòng
        /// </summary>
        /// <param name="_phieu"></param>
        public static void UpdateLoaiPhong(BangKe _bangKe)
        {
            DataBangKe.UpdateLoaiPhong(_bangKe);
        }

        /// <summary>
        /// Tìm kiêm một Bảng kê thông qua Mã bảng kê
        /// </summary>
        /// <param name="_maLoaiPhong"></param>
        /// <returns></returns>
        public static BangKe Find(int _maBangKe)
        {
            return DataBangKe.Find(_maBangKe);
        }
        
        /// <summary>
        /// Tìm kiêm một Bảng kê với Mã phòng và Tình trạng thanh toán
        /// </summary>
        /// <param name="_maLoaiPhong"></param>
        /// <returns></returns>
        public static BangKe Find(int _maPhong, bool _tinhTrangThanhToan)
        {
            return DataBangKe.Find(_maPhong, _tinhTrangThanhToan);
        }

        /// <summary>
        /// Xác nhận thuộc tính Tình trạng thanh toán cho Bảng Kê dịch vụ là đã thanh toán
        /// </summary>
        /// <param name="MaBang"></param>
        public static void ThanhToan(int MaBang)
        {
            DataBangKe.ThanhToan(MaBang);
        }
    }
}

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
    class BusLoaiPhong
    {
        /// <summary>
        /// Lấy danh sách loại phòng, dưới dạng List
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetList()
        {
            return DataLoaiPhong.GetList();
        }

        /// <summary>
        /// Lấy hết bảng LOAI_PHONG
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            return DataLoaiPhong.GetTable();
        }

        /// <summary>
        /// Update giá trị mới cho bảng LOAI_PHONG
        /// </summary>
        /// <param name="dataTable"></param>
        public static void UpdateTable(DataTable dataTable)
        {
            DataLoaiPhong.UpdateTable(dataTable);
        }

        /// <summary>
        /// Thêm Loại Phòng
        /// </summary>
        /// <param name="_phieu"></param>
        /// <returns>Trả về MaLoaiPhong nếu thành công, ngược lại -1</returns>
        public static int Add(LoaiPhong _loaiPhong)
        {
            return DataLoaiPhong.Add(_loaiPhong);
        }

        /// <summary>
        /// Xoá Loại phòng với MaLoaiPhong
        /// </summary>
        /// <param name="_maPhieuThue"></param>
        public static void Delete(int _maLoaiPhong)
        {
            DataLoaiPhong.Delete(_maLoaiPhong);
        }

        /// <summary>
        /// Sửa 1 Loại Phòng
        /// </summary>
        /// <param name="_loaiPhong"></param>
        public static void UpdateLoaiPhong(LoaiPhong _loaiPhong)
        {
            DataLoaiPhong.UpdateLoaiPhong(_loaiPhong);
        }

        /// <summary>
        /// Tìm kiếm Loai Phòng theo mã của nó
        /// </summary>
        /// <param name="_maLoaiPhong"></param>
        /// <returns></returns>
        public static LoaiPhong Find(int _maLoaiPhong)
        {
            return DataLoaiPhong.Find(_maLoaiPhong);
        }

    }
}

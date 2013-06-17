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
    class BusPhong
    {
        /// <summary>
        /// Lấy danh sách Phòng, dưới dạng List
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetList()
        {
            return DataPhong.GetList();
        }

        /// <summary>
        /// Lấy hết bảng PHONG từ database
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            return DataPhong.GetTable();
        }

        /// <summary>
        /// Lấy hết bảng PHONG từ database
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            return DataPhong.GetTable();
        }

        /// <summary>
        /// Update giá trị mới cho bảng PHONG
        /// </summary>
        /// <param name="dataTable"></param>
        public static void UpdateTable(DataTable dataTable)
        {
            DataPhong.UpdateTable(dataTable);
        }

         /// <summary>
        /// Thêm một phòng
        /// </summary>
        /// <param name="phong"></param>
        /// <returns></returns>
        public static bool AddPhong(Phong phong)
        {
            return DataPhong.AddPhong(phong);
        }

        /// <summary>
        /// Cập nhật thông tin 1 phòng
        /// </summary>
        /// <param name="phong"></param>
        public static void UpdatePhong(Phong phong)
        {
            DataPhong.UpdatePhong(phong);
        }

        /// <summary>
        /// Xóa một phòng
        /// </summary>
        /// <param name="maPhong"></param>
        public static void DeletePhong(int maPhong)
        {
            DataPhong.DeletePhong(maPhong);
        }

        /// <summary>
        /// Tìm kiếm 1 phòng thông qua MaPhong
        /// </summary>
        /// <param name="_maPhong"></param>
        /// <returns>Phong</returns>
        public static Phong FindMaPhong(int _maPhong)
        {
            return DataPhong.FindMaPhong(_maPhong);
        }

        /// <summary>
        /// Tim kiem theo Mã Loại Phòng
        /// </summary>
        public static DataTable FindMaLoaiPhong(int _maLoaiPhong)
        {
            return DataPhong.FindMaLoaiPhong(_maLoaiPhong);
        }
        
        /// <summary>
        /// Tim kiem theo tinh trang
        /// </summary>
        public static DataTable FindTinhTrang(Boolean _tinhTrang)
        {
            return DataPhong.FindTinhTrang(_tinhTrang);
        }

        /// <summary>
        /// Tim kiem bang Mô tả
        /// </summary>
        public static DataTable FindGhiChu(string _moTa)
        {
            return DataPhong.FindGhiChu(_moTa);
        }


    }
}

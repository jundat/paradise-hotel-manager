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
    class BusBaoCaoDoanhThu
    {
        /// <summary>
        /// Tìm kiếm các dòng báo cáo của một tháng
        /// </summary>
        /// <returns></returns>
        public static ArrayList FindTheoThangBaoCao(DateTime thang)
        {
            return DataBaoCaoDoanhThu.FindTheoThangBaoCao(thang);
        }

        /// <summary>
        /// Tìm kiếm tất cả các dòng báo cáo của một phòng theo mã phòng của nó
        /// </summary>
        /// <returns></returns>
        public static ArrayList FindTheoPhong(int maPhong)
        {
            return DataBaoCaoDoanhThu.FindTheoPhong(maPhong);
        }

        /// <summary>
        /// Tìm một dòng báo cáo doanh thu theo maBaoCaoDoanhThu của nó
        /// </summary>
        /// <param name="maBaoCaoDoanhThu"></param>
        /// <returns></returns>
        public static BaoCaoDoanhThu FindMaBaoCaoDoanhThu(int maBaoCaoDoanhThu)
        {
            return DataBaoCaoDoanhThu.FindMaBaoCaoDoanhThu(maBaoCaoDoanhThu);
        }

        /// <summary>
        /// Thêm một dòng báo cáo doanh thu cho một phòng
        /// </summary>
        /// <param name="thangDuocChon"></param>
        /// <returns>Return MaBaoCaoDoanhThu</returns>
        public static int Add(BaoCaoDoanhThu baoCaoDoanhThu)
        {
            return DataBaoCaoDoanhThu.Add(baoCaoDoanhThu);
        }

        /// <summary>
        /// Xóa Một báo cáo dựa vào mã của nó
        /// </summary>
        /// <param name="maBaoCaoDoanhThu"> mã của Báo cáo doanh thu cần xóa</param>
        /// <returns>Return MaBaoCaoDoanhThu</returns>
        public static void DeleteBaoCaoDoanhThu(int maBaoCaoDoanhThu)
        {
            DataBaoCaoDoanhThu.DeleteBaoCaoDoanhThu(maBaoCaoDoanhThu);
        }

        /// <summary>
        /// Xóa tất cả các báo cáo của tháng
        /// </summary>
        /// <param name="thang"> tháng cần xóa </param>
        public static void DeleteBaoCaoDoanhThu(DateTime thang)
        {
            DataBaoCaoDoanhThu.DeleteBaoCaoDoanhThu(thang);
        }

        /// <summary>
        /// Cập nhật một dong báo cáo doanh thu
        /// </summary>
        /// <param name="baoCaoDoanhThu">thông tin của 1 dòng báo cáo cần cập nhật</param>
        public static void UpdateBaoCaoDoanhThu(BaoCaoDoanhThu baoCaoDoanhThu)
        {
            DataBaoCaoDoanhThu.UpdateBaoCaoDoanhThu(baoCaoDoanhThu);
        }
    }
}

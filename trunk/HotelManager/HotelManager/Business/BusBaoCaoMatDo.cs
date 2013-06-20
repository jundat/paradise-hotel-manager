using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Collections;
using HotelManager.Data;
using HotelManager.Data.Entity;
using System.Windows.Forms;

namespace HotelManager.Business
{
    class BusBaoCaoMatDo
    {
        public static bool getInformation(DataTable data)
        {
            /************************************************************************/
            /* 
             * 1. Lấy danh sách các phòng trong PHONG
             * 2. Duyệt hết danh sách với MaPhong, tìm ra các Chi Tiet Phieu Den
             * 3. Lấy MaPhieuDen từ các chi tiết phiếu đến đó => danh sách các Phiếu Đến
             * 4. Lấy Ngày Đi - Ngày Đến => Cộng vào số ngày...
             * 
             */
            /************************************************************************/

            //Tổng số giờ trong tháng
            DateTime dauThang = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
            double soGioTrongThang = (DateTime.Now - dauThang).TotalHours;

            ArrayList listPhong = BusPhong.GetList();

            foreach (Phong p in listPhong)
            {
                double tongSoGioThue = 0; //Số giờ thuê trong tháng
                int maPhong = p.MaPhong;

                ArrayList listChiTietPhieuDen = BusChiTietPhieuDen.FindMaPhong(maPhong);
                foreach (ChiTietPhieuDen ct in listChiTietPhieuDen)
                {
                    int maPhieuDen = ct.MaPhieuDen;
                    PhieuDen phieuDen = BusPhieuDen.Get(maPhieuDen);
                    tongSoGioThue += (phieuDen.ThoiDiemDi - phieuDen.ThoiDiemDen).TotalHours;
                }

                //add to datatable
                double tyle = (tongSoGioThue / soGioTrongThang);
                data.Rows.Add(p.TenPhong, tongSoGioThue, tyle.ToString("F4"));
            }

            return true;
        }

        /// <summary>
        /// Tìm kiếm các dòng báo cáo của một tháng
        /// </summary>
        /// <returns></returns>
        public static ArrayList FindTheoThangBaoCao(DateTime thang)
        {
            return DataBaoCaoMatDo.FindTheoThangBaoCao(thang);
        }


        /// <summary>
        /// Tìm kiếm tất cả các dòng báo cáo của một phòng theo mã phòng của nó
        /// </summary>
        /// <returns></returns>
        public static ArrayList FindTheoPhong(int maPhong)
        {
            return DataBaoCaoMatDo.FindTheoPhong(maPhong);
        }

        /// <summary>
        /// Tìm một dòng báo cáo doanh thu theo maBaoCaoDoanhThu của nó
        /// </summary>
        /// <param name="maBaoCaoDoanhThu"></param>
        /// <returns></returns>
        public static BaoCaoMatDo FindMaBaoCaoDoanhThu(int maBaoCaoDoanhThu)
        {
            return DataBaoCaoMatDo.FindMaBaoCaoDoanhThu(maBaoCaoDoanhThu);
        }

        /// <summary>
        /// Thêm một dòng báo cáo doanh thu cho một phòng
        /// </summary>
        /// <param name="thangDuocChon"></param>
        /// <returns>Return MaBaoCaoDoanhThu</returns>
        public static int Add(BaoCaoMatDo baoCaoDoanhThu)
        {
            return DataBaoCaoMatDo.Add(baoCaoDoanhThu);
        }

        /// <summary>
        /// Xóa Một báo cáo dựa vào mã của nó
        /// </summary>
        /// <param name="maBaoCaoDoanhThu"> mã của Báo cáo doanh thu cần xóa</param>
        /// <returns>Return MaBaoCaoDoanhThu</returns>
        public static void DeleteBaoCaoDoanhThu(int maBaoCaoDoanhThu)
        {
            DataBaoCaoMatDo.DeleteBaoCaoDoanhThu(maBaoCaoDoanhThu);
        }

        /// <summary>
        /// Xóa tất cả các báo cáo của tháng
        /// </summary>
        /// <param name="thang"> tháng cần xóa </param>
        public static void DeleteBaoCaoDoanhThu(DateTime thang)
        {
            DataBaoCaoMatDo.DeleteBaoCaoDoanhThu(thang);
        }

        /// <summary>
        /// Cập nhật một dong báo cáo doanh thu
        /// </summary>
        /// <param name="baoCaoDoanhThu">thông tin của 1 dòng báo cáo cần cập nhật</param>
        public static void UpdateBaoCaoDoanhThu(BaoCaoMatDo baoCaoDoanhThu)
        {
            DataBaoCaoMatDo.UpdateBaoCaoDoanhThu(baoCaoDoanhThu);
        }
    }
}

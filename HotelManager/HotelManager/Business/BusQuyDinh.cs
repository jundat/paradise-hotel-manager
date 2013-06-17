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
    class BusQuyDinh
    {
        /// <summary>
        /// Đặt Số khách tối đa trong một phòng
        /// </summary>
        /// <returns></returns>
        public static int GetSoKhachToiDaTrongMotPhong()
        {
            return DataQuyDinh.GetSoKhachToiDaTrongMotPhong();
        }

        /// <summary>
        /// Cập nhật Số khách tối đa trong một phòng
        /// </summary>
        /// <param name="_soKhachToiDaTrongMotPhong"></param>
        public static void UpdateSoKhachToiDaTrongMotPhong(int _soKhachToiDaTrongMotPhong)
        {
            DataQuyDinh.UpdateSoKhachToiDaTrongMotPhong(_soKhachToiDaTrongMotPhong);
        }

         /// <summary>
        /// Đặt Tỷ lệ cọc
        /// </summary>
        /// <returns></returns>
        public static float GetTyLeCoc()
        {
            return DataQuyDinh.GetTyLeCoc();
        }

        /// <summary>
        /// Đặt Số giờ thuê với giá gốc
        /// </summary>
        /// <returns></returns>
        public static int GetSoGioThueVoiGiaGoc()
        {
            return DataQuyDinh.GetSoGioThueVoiGiaGoc();
        }
        
        /// <summary>
        /// Cập nhật Số giờ thuê với giá gốc
        /// </summary>
        /// <param name="_soGioThueVoiGiaGoc"></param>
        public static void UpdateSoGioThueVoiGiaGoc(int _soGioThueVoiGiaGoc)
        {
            DataQuyDinh.UpdateSoGioThueVoiGiaGoc(_soGioThueVoiGiaGoc);
        }

        /// <summary>
        /// Đặt Tỷ lệ giá phòng nếu thuê theo ngày
        /// </summary>
        /// <returns></returns>
        public static float GetTyLeGiaPhongNeuThueTheoNgay()
        {
            return DataQuyDinh.GetTyLeGiaPhongNeuThueTheoNgay();
        }

        /// <summary>
        /// Cập nhật Tỷ lệ giá phòng nếu thuê theo ngày
        /// </summary>
        /// <param name="_tyLeGiaPhongNeuThueTheoNgay"></param>
        public static void UpdateTyLeGiaPhongNeuThueTheoNgay(float _tyLeGiaPhongNeuThueTheoNgay)
        {
            DataQuyDinh.UpdateTyLeGiaPhongNeuThueTheoNgay(_tyLeGiaPhongNeuThueTheoNgay);
        }

        /// <summary>
        /// Lấy thông số của quy định thông qua đối tượng quy định
        /// </summary>
        /// <returns></returns>
        public static QuyDinh GetQuyDinh()
        {
            return DataQuyDinh.GetQuyDinh();
        }

        /// <summary>
        /// Cập nhật thông số của quy định thông qua đối tượng quy định
        /// </summary>
        /// <param name="_quyDinh"></param>
        public static void UpdateQuyDinh(QuyDinh _quyDinh)
        {
            DataQuyDinh.UpdateQuyDinh(_quyDinh);
        }


    }
}

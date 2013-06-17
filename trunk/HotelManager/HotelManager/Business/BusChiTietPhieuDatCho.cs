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
    class BusChiTietPhieuDatCho
    {
        /// <summary>
        /// Lấy bảng CHI_TIET_PHIEU_DAT_CHO
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            return DataChiTietPhieuDatCho.GetTable();
        }

        /// <summary>
        /// update dữ liệu mới
        /// </summary>
        /// <param name="dt"></param>
        public static void UpdateTable(DataTable dataTable)
        {
            DataChiTietPhieuDatCho.UpdateTable(dataTable);
        }

        /// <summary>
        /// Lấy list các CHI_TIET_PHIEU_DAT_CHO
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetList()
        {
            return DataChiTietPhieuDatCho.GetList();
        }

        /// <summary>
        /// Thêm chi tiết phiếu đặt tiệc vào bảng CHI_TIET_PHIEU_DAT_CHO
        /// </summary>
        /// <param name="_chiTietPhieuDatCho"></param>
        public static void Add(ChiTietPhieuDatCho _chiTietPhieuDatCho)
        {
            DataChiTietPhieuDatCho.Add(_chiTietPhieuDatCho);
        }

        /// <summary>
        /// Xoá chi tiết phiếu thuê đặt chỗ
        /// </summary>
        /// <param name="_maChiTietPhieuDatCho"></param>
        public static void Delete(int _maChiTietPhieuDatCho)
        {
            DataChiTietPhieuDatCho.Delete(_maChiTietPhieuDatCho);
        }

        /// <summary>
        /// Sửa 1 chi tiết phiếu thuê
        /// </summary>
        /// <param name="_chiTietPhieuDatCho"></param>
        public static void UpdateChiTietPhieuDatCho(ChiTietPhieuDatCho _chiTietPhieuDatCho)
        {
            DataChiTietPhieuDatCho.UpdateChiTietPhieuDatCho(_chiTietPhieuDatCho);
        }


    }
}

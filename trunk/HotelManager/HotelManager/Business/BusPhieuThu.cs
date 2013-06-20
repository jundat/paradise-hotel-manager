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
    class BusPhieuThu
    {
        public static float getInformation(string cmnd, ref string tenKhach, ref DataTable data)
        {
            float tongchiphi = 0;
            //Tìm trong phiếu đến, lấy ra phiếu đến
            DataTable listPhieuDen = null;
            if (cmnd != "" && cmnd.Length > 0)
            {
                listPhieuDen = BusPhieuDen.FindCMND(cmnd, false);
            }

            if (listPhieuDen.Rows.Count == 0)
            {
                return 0;
            }

            //1- phieu den
            int maPhieuDen = (int)(listPhieuDen.Rows[0]["MaPhieuDen"]);
            float tienPhieuDen = (float)(listPhieuDen.Rows[0]["TongChiPhi"]);
            tenKhach = (string)listPhieuDen.Rows[0]["TenKhachDaiDien"];

            //save lại tình trạng thanh toán
            BusPhieuDen.UpdateTrangThai(maPhieuDen, true);

            ///////////////////////////////////////////////////////////////////////////////////////
            //add to data
            data.Rows.Add("Phieu Den", maPhieuDen, tienPhieuDen, "Chi phí thuê phòng");
            tongchiphi += tienPhieuDen;

            //2- bang ke
            //Tìm danh sách các phòng từ chi tiết phiếu đến
            ArrayList listChiTietPhieuDen = BusChiTietPhieuDen.GetList(maPhieuDen);

            //duyệt các record và tìm ra các tên phòng
            foreach (ChiTietPhieuDen ct in listChiTietPhieuDen)
            {
                int maphong = ct.MaPhong;
                BangKe bangke = BusBangKe.Find(maphong, false);

                if (bangke == null) break;

                //add to data
                data.Rows.Add("Bang Ke", bangke.MaBangKe, bangke.TongChiPhi, "Mã Phòng " + bangke.MaPhong);
                tongchiphi += bangke.TongChiPhi;

                //ghi lại trạng thái trong bảng kê
                //...
                BusBangKe.UpdateTrangThai(bangke.MaBangKe, true);

            }

            //3- Hóa đơn đặt tiệc
            foreach (ChiTietPhieuDen ct in listChiTietPhieuDen)
            {
                ArrayList listPhieuDatTiec = BusPhieuDatTiec.Find(ct.MaPhong, false);

                foreach (PhieuDatTiec pdt in listPhieuDatTiec)
                {
                    //add to data
                    data.Rows.Add("Hoa Don", pdt.MaPhieuDatTiec, pdt.TongTien, "Mã Phòng " + pdt.MaPhong);
                    tongchiphi += pdt.TongTien;

                    //ghi lại trạng thái trong hóa đơn
                    //...
                    BusPhieuDatTiec.UpdateTrangThai(pdt.MaPhieuDatTiec, true);
                }            
            }

            return tongchiphi;
        }


        //
        // Override
        //

        public static ArrayList GetList()
        {
            return DataPhieuThu.GetList();
        }

        public static DataTable GetTable()
        {
            return DataPhieuThu.GetTable();
        }

        public static void UpdateTable(DataTable dataTable)
        {
            DataPhieuThu.UpdateTable(dataTable);
        }

        public static void UpdatePhieuThu(PhieuThu phieuthu)
        {
            DataPhieuThu.UpdatePhieuThu(phieuthu);
        }

        public static bool Add(PhieuThu phieuthu)
        {
            return DataPhieuThu.Add(phieuthu);
        }

        public static void Delete(int maPhieuThu)
        {
            DataPhieuThu.Delete(maPhieuThu);
        }

        public static DataTable Find(int maPhieuThu)
        {
            return DataPhieuThu.Find(maPhieuThu);
        }

        public static DataTable Find(string tenKhach)
        {
            return DataPhieuThu.Find(tenKhach);
        }
        
    }
}

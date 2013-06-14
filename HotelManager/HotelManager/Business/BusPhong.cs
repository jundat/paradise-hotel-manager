using HotelManager.Data;
using HotelManager.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelManager.Business
{
    class BusPhong : BusAbstract
    {
        /// <summary>
        /// Xử lý tác vụ liên quan tới PHONG
        /// </summary>
        public static DataTable LoadExcelFile(string path)
        {
            string connstr = null;
            if (path.EndsWith(".xls"))
            {
                connstr = "Provider=Microsoft.Jet.Oledb.4.0;Data Source='" + path + "';Extended Properties=Excel 8.0";
            }

            if (connstr != null)
            {
                OleDbConnection conn = new OleDbConnection(connstr);
                string strSQL = "SELECT * FROM [Sheet1$]";

                OleDbCommand cmd = new OleDbCommand(strSQL, conn);
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
                return ds.Tables[0];
            }

            return null;
        }

        /// <summary>
        /// Thêm phòng từ dữ liệu của 1 DataGridViewRowCollection
        /// </summary>
        /// <returns>Trả về số Phòng được thêm</returns>
        public static int ThemPhong(DataGridViewRowCollection rows)
        {
            int count = rows.Count - 1;
            for (int i = 0; i < count; ++i)
            {
                DataGridViewRow row = rows[i];
                Phong phong = new Phong();

                phong.TenPhong = "" + row.Cells[0].Value;
                phong.MaLoaiPhong = Int16.Parse(row.Cells[1].Value.ToString());
                phong.GhiChu = "" + row.Cells[2].Value;
                phong.TinhTrang = false;

                DataPhong.AddPhong(phong);
            }

            return count;
        }

        /// <summary>
        /// Tìm kiếm theo các thông số
        /// </summary>
        /// <returns>Nhớ kiểm tra giá trị trả về có hợp lệ ko</returns>
        public static DataTable Find(int maphong, string tenphong, int maLoaiPhong, int tinhTrangPhong, string ghiChu)
        {
            DataTable data = new DataTable();

            //TH1: Tìm tên phòng và mã phòng (thì ko tìm các cái còn lại)
            if (maphong != -1 || tenphong != "")
            {
                if (maphong != -1)
                {
                    data.Merge(DataPhong.FindMaPhong(maphong), true);
                }

                if (tenphong != "")
                {
                    data.Merge(DataPhong.FindTenPhong(tenphong), true);
                }
            }
            else
            {
                //TH2: Tìm theo Mã Loại Phòng và Tên Loại Phòng
                if (maLoaiPhong != -1)
                {
                    data.Merge(DataPhong.FindMaLoaiPhong(maLoaiPhong), true);
                }

                //TH3: Tìm kiếm theo tình trạng
                if (tinhTrangPhong != -1)
                {
                    if(tinhTrangPhong == 1)
                        data.Merge(DataPhong.FindTinhTrang(true), true);
                    else
                        data.Merge(DataPhong.FindTinhTrang(false), true);
                }

                //TH4: Tìm kiếm theo ghi chú
                if (ghiChu != "")
                {
                    data.Merge(DataPhong.FindGhiChu(ghiChu), true);
                }
            }

            DataTable distinctValues;
            if (data.Rows.Count > 0)
            {
                //Chống lặp lại
                DataView view = new DataView(data);
                distinctValues = view.ToTable(true, "MaPhong", "TenPhong", "MaLoaiPhong", "TinhTrang", "GhiChu");
                return distinctValues;
            }

            return data;
        }

        /// <summary>
        /// Xoá 1 phòng theo mã phòng
        /// </summary>
        public static void DeletePhong(int maphong)
        {
            DataPhong.DeletePhong(maphong);
        }

        /// <summary>
        /// Update thông tin cho một collection các phòng
        /// </summary>
        /// <returns>Trả về số phòng được update</returns>
        public static int UpdatePhong(DataGridViewRowCollection rows)
        {
            Phong phong = new Phong();
            int count = rows.Count - 1;

            for (int i = 0; i < count; ++i)
            {
                DataGridViewRow row = rows[i];

                phong.MaPhong = Int16.Parse(row.Cells[0].Value.ToString());
                phong.TenPhong = "" + row.Cells[1].Value;
                phong.MaLoaiPhong = Int16.Parse(row.Cells[2].Value.ToString());
                phong.TinhTrang = (bool)(row.Cells[3].Value);
                phong.GhiChu = "" + row.Cells[4].Value;

                DataPhong.UpdatePhong(phong);
            }

            return count;
        }

        public static void UpdatePhong(Phong phong)
        {
            DataPhong.UpdatePhong(phong);
        }

        public static DataTable BaoCaoMatDo(int thangDuocChon, int namDuocChon)
        {
            return DataPhong.BaoCaoMatDo(thangDuocChon, namDuocChon);
        }

        public static DataTable GetTable()
        {
            return DataPhong.GetTable();
        }
    }
}

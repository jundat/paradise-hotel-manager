using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;//ket noi file access
using System.Linq;
using System.Text;
using HotelManager.Data.Entity;
using System.Windows;


namespace HotelManager.Data
{
    /// <summary>
    /// Thực hiện các thao tác đối với 1 Phòng.
    /// </summary>
    public class DataPhong : DataAbstract
    {
        /// <summary>
        /// Trả về danh sách các Phòng, dưới dạng List
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetList()
        {
            ArrayList ListPhong = new ArrayList();

            //tao ket noi, mo ket noi
            OleDbConnection ObjCn = DataProvider.ConnectionData();

            //tao chuoi strSQL thao tac CSDL
            string StrSQL = "SELECT * FROM PHONG";

            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            OleDbDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            while (ObjReader.Read())
            {
                Phong Phong = new Phong();

                Phong.MaPhong = (int)ObjReader["MaPhong"];
                Phong.TenPhong = (string)ObjReader["TenPhong"];
                Phong.MaLoaiPhong = (int)ObjReader["MaLoaiPhong"];
                Phong.TinhTrang = (bool)ObjReader["TinhTrang"];
                Phong.GhiChu = (string)ObjReader["GhiChu"];

                ListPhong.Add(Phong);
            }

            //dong ket noi, giai phongDuocChon tai nguyen
            ObjCn.Close();

            return ListPhong;
        }

        /// <summary>
        /// Lấy table PHONG từ database
        /// </summary>
        /// <returns>DataTable PHONG</returns>
        public static DataTable GetTable()
        {
            DataTable _DataTable = new DataTable();

            //tao ket noi
            OleDbConnection ObjCn = DataProvider.ConnectionData();

            //tao chuoi strSQL
            string StrSQL = "SELECT * FROM PHONG";

            OleDbDataAdapter ObjAdapter = new OleDbDataAdapter(StrSQL, ObjCn);
            ObjAdapter.Fill(_DataTable);

            //dong ket noi
            ObjCn.Close();
            return _DataTable;
        }

        /// <summary>
        /// UpdatePhieuThue toàn bộ dữ liệu mới lại cho PHONG dưới database
        /// </summary>
        public static void UpdateTable(DataTable _dataTable)
        {
            //tao chuoi ket noi.
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "SELECT * FROM PHONG";

            OleDbDataAdapter ObjAdapter = new OleDbDataAdapter(StrSQL, ObjCn);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(ObjAdapter);

            ObjAdapter.Update(_dataTable);

            //dong ket noi
            ObjCn.Close();
        }

        /// <summary>
        /// Thêm 1 phuthu mới vào PHONG
        /// </summary>
        public static bool AddPhong(Phong _Phong)
        {
            try
            {
                OleDbConnection ObjCn = DataProvider.ConnectionData();

                string StrSQL = "INSERT INTO PHONG(TenPhong, MaLoaiPhong, TinhTrang, GhiChu) VALUES(?, ?, ?, ?)";
                OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

                ObjCmd.Parameters.Add("@TenPhong", OleDbType.WChar).Value = _Phong.TenPhong;
                ObjCmd.Parameters.Add("@MaLoaiPhong", OleDbType.Integer).Value = _Phong.MaLoaiPhong;
                ObjCmd.Parameters.Add("@TinhTrang", OleDbType.Boolean).Value = _Phong.TinhTrang;
                ObjCmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = _Phong.GhiChu;

                ObjCmd.ExecuteNonQuery();

                //Theo bạn Hiệp nghĩ là để update MaPhong theo TenPhong, ~ tăng cái primary key
                StrSQL = "Select @@IDENTITY";

                ObjCmd = new OleDbCommand(StrSQL, ObjCn);
                _Phong.MaPhong = (int)ObjCmd.ExecuteScalar();

                //dong ket noi giair phongDuocChon tai nguyen
                ObjCn.Close();

                return true;
            }
            catch (Exception eee)
            {
                //if (eee.Message.Contains("duplicate"))
                //{
                //    MessageBox.Show("Dữ liệu trùng lặp: Phòng " + _Phong.TenPhong);
                //}
                return false;
            }
        }

        /// <summary>
        /// Xoá 1 phuthu trong PHONG
        /// </summary>
        /// <param name="_maPhong"></param>
        public static void DeletePhong(int _maPhong)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "DELETE FROM PHONG WHERE MaPhong = ?";

            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            ObjCmd.Parameters.Add("@MaPhong", OleDbType.Integer).Value = _maPhong;

            ObjCmd.ExecuteNonQuery();

            //dong ket noi
            ObjCn.Close();
        }

        /// <summary>
        /// Sửa thông tin của 1 phuthu trong PHONG
        /// </summary>
        /// <param name="phieuthue"></param>
        public static void UpdatePhong(Phong _Phong)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "UPDATE PHONG SET TenPhong = ?, MaLoaiPhong = ?, TinhTrang = ?, GhiChu = ? WHERE MaPhong = ?";
            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            ObjCmd.Parameters.Add("@TenPhong", OleDbType.WChar).Value = _Phong.TenPhong;
            ObjCmd.Parameters.Add("@MaLoaiPhong", OleDbType.Integer).Value = _Phong.MaLoaiPhong;
            ObjCmd.Parameters.Add("@TinhTrang", OleDbType.Boolean).Value = _Phong.TinhTrang;
            ObjCmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = _Phong.GhiChu;

            ObjCmd.Parameters.Add("@MaPhong", OleDbType.Integer).Value = _Phong.MaPhong;

            ObjCmd.ExecuteNonQuery();
            ObjCn.Close();
        }

        /// <summary>
        /// Bao cao mat do su dung phongDuocChon
        /// </summary>
        public static DataTable BaoCaoMatDo(int thangBaoCao, int namBaoCao)
        {
            DataTable returnTable = new DataTable();
            returnTable.Columns.Add("MaPhong", typeof(int));
            returnTable.Columns.Add("Phong", typeof(int));
            returnTable.Columns.Add("SoNgayThue", typeof(int));
            returnTable.Columns.Add("TyLe", typeof(double));

            //Tính số ngày trong tháng tới ngày hiện tại(nếu chưa hết tháng)
            //Hoặc tới ngày cuối tháng, nếu đã qua tháng đó.
            
            DateTime cuoiThangTheoLich = (new DateTime(thangBaoCao == 12 ? namBaoCao + 1 : namBaoCao, thangBaoCao < 12 ? (thangBaoCao + 1) : 1, 1)).AddDays(-1);
            
            DateTime cuoiThangBaoCao; //ngày để so sánh với ngày trả và ngày thuê phòng
            DateTime dauThangBaoCao = new DateTime(namBaoCao, thangBaoCao, 1);
            int soNgayTrongThang = 0;

            //nếu chưa hết tháng
            if (DateTime.Now < cuoiThangTheoLich)
            {
                soNgayTrongThang = DateTime.Now.Day + 1;
                cuoiThangBaoCao = DateTime.Now;
            }
            else
            {
                cuoiThangBaoCao = cuoiThangTheoLich;
                TimeSpan delta = cuoiThangTheoLich - dauThangBaoCao;
                soNgayTrongThang = delta.Days + 1;
            }

            //MessageBox.Show("Số ngày trong tháng: " + soNgayTrongThang);

            //Lấy list Phòng
            ArrayList listPhong;
            listPhong = (ArrayList)DataPhong.GetList();

            //Duyệt hết listPhong
            //Đọc từ bảng PHIEUTHUEPHONG
            //ĐK: PhieuThuePhong.MaPhong == listPhong[i].MaPhong
            // && ( PhieThuePhong.NgayBatDauThue hoặc NgayTraPhong thuộc vào tháng đó)
            double tyle = 0.0f;

            foreach (Phong phong in listPhong)
            {
                string StrSQL;

                StrSQL = 
                "SELECT * FROM PHIEUTHUEPHONG WHERE " +
                "(" +         
                    " MaPhong = " + phong.MaPhong + 
                    " AND " +
                    "(" + 
                        "(" + 
                            " (MONTH(NgayBatDauThue) = " + thangBaoCao + " AND YEAR(NgayBatDauThue) = " + namBaoCao + ")" +
                            " OR" +
                            " (MONTH(NgayTraPhong) = " + thangBaoCao + " AND YEAR(NgayTraPhong) = " + namBaoCao + ")" +
                        ")" +

                        "OR " +

                        "(" +
                            " NgayBatDauThue < #" + thangBaoCao + "/1/" + namBaoCao + "#" +
                            " AND" +
                            " NgayTraPhong > #" + thangBaoCao + "/" + cuoiThangBaoCao.Day + "/" + namBaoCao + "#" +
                        ")" + 
                    ")" + 
                ") ";

                OleDbConnection ObjCn = DataProvider.ConnectionData();
                OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

                OleDbDataReader ObjReader;
                ObjReader = ObjCmd.ExecuteReader();

                DateTime NgayBatDauThue;
                DateTime NgayTraPhong;
                int soNgay = 0;
                int tongSoNgayThue = 0;

                while (ObjReader.Read())
                {
                    string s;
                    
                    s = ObjReader["NgayBatDauThue"].ToString();
                    
                    NgayBatDauThue = (DateTime)ObjReader["NgayBatDauThue"];

                    s = ObjReader["NgayTraPhong"].ToString();

                    if (s != "")
                    {
                        NgayTraPhong = Convert.ToDateTime(ObjReader["NgayTraPhong"].ToString());
                    }
                    else
                    {
                        NgayTraPhong = cuoiThangBaoCao;
                    }


                    //TH1, cả 2 ngày đều nằm trong tháng
                    if ((NgayBatDauThue >= dauThangBaoCao && NgayBatDauThue <= cuoiThangBaoCao) &&
                        (NgayTraPhong >= dauThangBaoCao && NgayTraPhong <= cuoiThangBaoCao))
                    {
                        soNgay = (NgayTraPhong - NgayBatDauThue).Days + 1;
                    } //TH2, Ngày bắt đầu thuê ko nằm trong tháng
                    else if ((NgayBatDauThue < dauThangBaoCao) &&
                        (NgayTraPhong >= dauThangBaoCao && NgayTraPhong <= cuoiThangBaoCao))
                    {
                        soNgay = (NgayTraPhong - dauThangBaoCao).Days + 1;
                    } //TH3, Ngày trả phòng ko nằm trong tháng.
                    else if ((NgayBatDauThue >= dauThangBaoCao && NgayBatDauThue <= cuoiThangBaoCao) &&
                        (NgayTraPhong > cuoiThangBaoCao))
                    {
                        soNgay = (cuoiThangBaoCao - NgayBatDauThue).Days + 1;
                    } //TH4, cả 2 ngày đều ko nằm trong tháng
                    else if ((NgayBatDauThue < dauThangBaoCao) &&
                        (NgayTraPhong > cuoiThangBaoCao))
                    {
                        soNgay = (cuoiThangBaoCao - dauThangBaoCao).Days + 1;
                    }

                    tongSoNgayThue += soNgay;                    
                }//end while

                tyle = (double)tongSoNgayThue / (double)soNgayTrongThang;
                returnTable.Rows.Add(phong.MaPhong, phong.TenPhong, tongSoNgayThue, tyle);
            }//end foreach
            
            return returnTable;
        }

        /// <summary>
        /// Tìm kiếm 1 phuthu trong PHONG theo MaPhong
        /// </summary>
        /// <param name="_maPhong"></param>
        /// <returns></returns>
        public static DataTable FindMaPhong(int _maPhong)
        {
            DataTable dt = new DataTable();
            //mo ket noi
            OleDbConnection ObjCn = DataProvider.ConnectionData();

            //tao chuoi strSQL thao tac CSDL
            string StrSQL = "SELECT * FROM PHONG WHERE MaPhong = ?";
            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            ObjCmd.Parameters.Add("@MaPhong", OleDbType.Integer).Value = _maPhong;

            OleDbDataAdapter adapter = new OleDbDataAdapter(ObjCmd);
            adapter.Fill(dt);

            ObjCn.Close();

            return dt;
        }

        /// <summary>
        /// Tìm kiếm 1 table các phuthu dựa vào TenPhong
        /// </summary>
        /// <param name="_tenPhong"></param>
        /// <returns></returns>
        public static DataTable FindTenPhong(string _tenPhong)
        {
            DataTable dt = new DataTable();
            //mo ket noi
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            
            //tao chuoi strSQL thao tac CSDL
            string StrSQL = "SELECT * FROM PHONG WHERE TenPhong = ?";

            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            ObjCmd.Parameters.Add("@TenPhong", OleDbType.WChar).Value = _tenPhong;

            OleDbDataAdapter adapter = new OleDbDataAdapter(ObjCmd);
            adapter.Fill(dt);

            ObjCn.Close();

            return dt;
        }

        /// <summary>
        /// Tim kiem theo maloaiphogn
        /// </summary>
        public static DataTable FindMaLoaiPhong(int _maLoaiPhong)
        {
            //mo ket noi
            OleDbConnection ObjCn = DataProvider.ConnectionData();

            //tao chuoi strSQL thao tac CSDL
            string StrSQL = "SELECT * FROM PHONG WHERE MaLoaiPhong = ?";
            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            ObjCmd.Parameters.Add("@MaLoaiPhong", OleDbType.Integer).Value = _maLoaiPhong;

            OleDbDataAdapter adapter = new OleDbDataAdapter(ObjCmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            ObjCn.Close();

            return dt;
        }

        /// <summary>
        /// Tim kiem theo tinh trang
        /// </summary>
        public static DataTable FindTinhTrang(bool _tinhtrang)
        {
            //mo ket noi
            OleDbConnection ObjCn = DataProvider.ConnectionData();

            //tao chuoi strSQL thao tac CSDL
            string StrSQL = "SELECT * FROM PHONG WHERE TinhTrang = ?";
            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            ObjCmd.Parameters.Add("@TinhTrang", OleDbType.Boolean).Value = _tinhtrang;

            OleDbDataAdapter adapter = new OleDbDataAdapter(ObjCmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            ObjCn.Close();

            return dt;
        }

        /// <summary>
        /// Tim kiem bang ghi chu
        /// </summary>
        public static DataTable FindGhiChu(string _ghiChu)
        {
            DataTable dt = new DataTable();
            //mo ket noi
            OleDbConnection ObjCn = DataProvider.ConnectionData();

            //tao chuoi strSQL thao tac CSDL
            string StrSQL = "SELECT * FROM PHONG WHERE GhiChu LIKE '%" + _ghiChu + "%' ;";
            //string sql = "select * from phongDuocChon where ghichu = '%hanoi%'";

            //OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            //ObjCmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = _ghiChu;

            OleDbDataAdapter adapter = new OleDbDataAdapter(StrSQL, ObjCn);
            adapter.Fill(dt);

            ObjCn.Close();

            return dt;
        }
    }
}

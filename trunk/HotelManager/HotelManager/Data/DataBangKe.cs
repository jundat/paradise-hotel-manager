using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using System.Windows.Forms;
using HotelManager.Data.Entity;
using System.Data;
using MySql.Data.MySqlClient;

namespace HotelManager.Data
{
    /// <summary>
    /// Thao tác vơi bảng BANG_KE
    /// </summary>
    class DataBangKe
    {
        /// <summary>
        /// Lấy danh sách các bảng kê dưới dạng List
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetList()
        {
            // Lấy command
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            MySqlDataReader dataReader = null;
            ArrayList _arrayList = new ArrayList();

            try
            {
                // set query
                cmd.CommandText = "SELECT * FROM bang_ke";
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    BangKe _bangKe = new BangKe();

                    _bangKe.MaBangKe = (int)dataReader["MaBangKe"];
                    _bangKe.MaPhong = (int)dataReader["MaPhong  "];
                    _bangKe.TongChiPhi = (float)dataReader["TongChiPhi"];
                    _bangKe.TinhTrangThanhToan = (Boolean)dataReader["TinhTrangHienTai"];

                    _arrayList.Add(_bangKe);
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetList BANG_KE table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            
            DataProvider.getInstance().CloseConnection();

            return _arrayList;
        }


        /// <summary>
        /// Tim danh sách Bảng kê
        /// </summary>
        /// <param name="tenPhong"></param>
        /// <param name="tinhTrangThanhToan"></param>
        /// <returns></returns>
        public static ArrayList Find(int maPhong, String tinhTrangThanhToan)
        {
            // Lấy command
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            MySqlDataReader dataReader = null;
            ArrayList _arrayList = new ArrayList();

            try
            {
                // set query
                if ("Không quan tâm".Equals(tinhTrangThanhToan))
                {
                    if (maPhong == 0)
                    {
                        cmd.CommandText = "SELECT * FROM bang_ke";
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM bang_ke WHERE MaPhong = ?MaPhong";
                        cmd.Parameters.Add("?MaPhong", maPhong);
                    }
                    
                }
                else
                    if ("Đã thanh toán".Equals(tinhTrangThanhToan))
                    {
                        if (maPhong == 0)
                        {
                            cmd.CommandText = "SELECT * FROM bang_ke WHERE TinhTrangThanhToan = ?TinhTrangThanhToan";
                            cmd.Parameters.Add("?TinhTrangThanhToan", true);
                        }
                        else
                        {
                            cmd.CommandText = "SELECT * FROM bang_ke WHERE MaPhong = ?MaPhong AND TinhTrangThanhToan = ?TinhTrangThanhToan";

                            cmd.Parameters.Add("?MaPhong", maPhong);
                            cmd.Parameters.Add("?TinhTrangThanhToan", true);
                        }
                    }
                    else // Chưa thanh toán
                    {
                        if (maPhong == 0)
                        {
                            cmd.CommandText = "SELECT * FROM bang_ke WHERE TinhTrangThanhToan = ?TinhTrangThanhToan";
                            cmd.Parameters.Add("?TinhTrangThanhToan", false);
                        }
                        else
                        {
                            cmd.CommandText = "SELECT * FROM bang_ke WHERE MaPhong = ?MaPhong AND TinhTrangThanhToan = ?TinhTrangThanhToan";

                            cmd.Parameters.Add("?MaPhong", maPhong);
                            cmd.Parameters.Add("?TinhTrangThanhToan", false);
                        }
                    }

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    BangKe _bangKe = new BangKe();

                    _bangKe.MaBangKe = (int)dataReader["MaBangKe"];
                    _bangKe.MaPhong = (int)dataReader["MaPhong"];
                    _bangKe.TongChiPhi = (float)dataReader["TongChiPhi"];
                    _bangKe.TinhTrangThanhToan = Convert.ToBoolean(dataReader["TinhTrangThanhToan"]);

                    _arrayList.Add(_bangKe);
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString(), "Error Execute query: GetList BANG_KE table !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }

            DataProvider.getInstance().CloseConnection();

            return _arrayList;
        }
        /// <summary>
        /// Lấy hết bảng BANG_KE
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTable()
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM bang_ke";
            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataTable);

            DataProvider.getInstance().CloseConnection();
            return dataTable;
        }

        /// <summary>
        /// Update giá trị mới cho bảng BANG_KE
        /// </summary>
        /// <param name="dataTable"></param>
        public static void UpdateTable(DataTable dataTable)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM bang_ke";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder commandBuider = new MySqlCommandBuilder(adapter);
            adapter.Update(dataTable);
            DataProvider.getInstance().CloseConnection();
        }

        /// <summary>
        /// Thêm Bảng Kê mới
        /// </summary>
        /// <param name="_phieu"></param>
        /// <returns>Trả về MaBangKE nếu thành công, ngược lại -1</returns>
        public static int Add(BangKe _bangKe)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "INSERT INTO bang_ke(MaPhong, TongChiPhi, TinhTrangThanhToan) VALUES(?MaPhong, ?TongChiPhi, ?TinhTrangThanhToan)";
            cmd.Prepare();

            cmd.Parameters.Add("?MaPhong", _bangKe.MaPhong);
            cmd.Parameters.Add("?TongChiPhi", _bangKe.TongChiPhi);
            cmd.Parameters.Add("?TinhTrangThanhToan", _bangKe.TinhTrangThanhToan);

            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT @@IDENTITY";
            _bangKe.MaBangKe = Convert.ToInt32(cmd.ExecuteScalar());

            DataProvider.getInstance().CloseConnection();
            return _bangKe.MaBangKe;
        }

        /// <summary>
        /// Xoá một Bảng kê
        /// </summary>
        /// <param name="_maBangKe"></param>
        public static void Delete(int _maBangKe)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "DELETE FROM bang_ke WHERE MaBangKe = ?";

            cmd.Parameters.Add("@MaBangKe", MySqlDbType.Int32).Value = _maBangKe;
            cmd.ExecuteNonQuery();
            DataProvider.getInstance().CloseConnection();
        }

        /// <summary>
        /// Sửa 1 Loại Phòng
        /// </summary>
        /// <param name="_phieu"></param>
        public static void UpdateLoaiPhong(BangKe _bangKe)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE bang_ke SET MaPhong = ?, TongChiPhi = ?, TinhTrangThanhToan = ? WHERE MaBangKe = ?";

            cmd.Parameters.Add("@MaBangKe", MySqlDbType.Int32).Value = _bangKe.MaBangKe;
            cmd.Parameters.Add("@MaPhong", MySqlDbType.Int32).Value = _bangKe.MaPhong;
            cmd.Parameters.Add("@TongChiPhi", MySqlDbType.Float).Value = _bangKe.TongChiPhi;
            cmd.Parameters.Add("@TinhTrangThanhToan", MySqlDbType.Byte).Value = _bangKe.TinhTrangThanhToan;

            cmd.ExecuteNonQuery();
            DataProvider.getInstance().CloseConnection();
        }

        public static void UpdateTrangThai(int maBangKe, bool trangthai)
        {
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "UPDATE bang_ke SET TinhTrangThanhToan = " + Convert.ToByte(trangthai) + " WHERE MaBangKe = " + maBangKe;

            cmd.ExecuteNonQuery();
            DataProvider.getInstance().CloseConnection();
        }
        
        /// <summary>
        /// Tìm kiêm một Bảng kê thông qua Mã bảng kê
        /// </summary>
        /// <param name="_maLoaiPhong"></param>
        /// <returns></returns>
        public static BangKe Find(int _maBangKe)
        {
            BangKe bangKe = new BangKe();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM bang_ke WHERE MaBangKe = ?MaBangKe";

            cmd.Parameters.Add("?MaBangKe", _maBangKe);

            MySqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                bangKe.MaBangKe = (int)dataReader["MaBangKe"];
                bangKe.MaPhong = (int)dataReader["MaPhong"];
                bangKe.TongChiPhi = (float)dataReader["TongChiPhi"];
                bangKe.TinhTrangThanhToan = Convert.ToBoolean(dataReader["TinhTrangThanhToan"]);
            }
            DataProvider.getInstance().CloseConnection();
            return bangKe;
        }

        /// <summary>
        /// Tìm kiêm một Bảng kê với Mã phòng và Tình trạng thanh toán
        /// </summary>
        /// <param name="_maLoaiPhong"></param>
        /// <returns></returns>
        public static BangKe Find(int _maPhong, bool _tinhTrangThanhToan)
        {
            BangKe bangKe = new BangKe();
            MySqlCommand cmd = DataProvider.getInstance().getCommand();
            cmd.CommandText = "SELECT * FROM bang_ke WHERE MaPhong = '" + _maPhong + "' AND TinhTrangThanhToan = " + Convert.ToByte(_tinhTrangThanhToan);

            MySqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();

            if(dataReader.HasRows)
            {
                if (dataReader.Read())
                {
                    bangKe.MaBangKe = (int)dataReader["MaBangKe"];
                    bangKe.MaPhong = (int)dataReader["MaPhong"];
                    bangKe.TongChiPhi = (float)dataReader["TongChiPhi"];
                    bangKe.TinhTrangThanhToan = Convert.ToBoolean(dataReader["TinhTrangThanhToan"]);
                }

                DataProvider.getInstance().CloseConnection();
                return bangKe;
            }
            else
            {
                DataProvider.getInstance().CloseConnection();
                return null;
            }
        }

        /// <summary>
        /// Xác nhận thuộc tính Tình trạng thanh toán cho Bảng Kê dịch vụ là đã thanh toán
        /// </summary>
        /// <param name="MaBang"></param>
        public static void ThanhToan(int MaBang)
        {
            MySqlCommand ObjCmd = DataProvider.getInstance().getCommand();
            ObjCmd.CommandText = "UPDATE bang_ke SET TinhTrangThanhToan = ?TinhTrangThanhToan WHERE MaBangKe = ?MaBangKe";

            ObjCmd.Parameters.Add("?MaBangKe", MaBang);
            ObjCmd.Parameters.Add("?TinhTrangThanhToan", true);

            ObjCmd.ExecuteNonQuery();

            //close connection
            DataProvider.getInstance().CloseConnection();
        }
    }
}

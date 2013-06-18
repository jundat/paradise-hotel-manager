using HotelManager.Business;
using HotelManager.Data;
using HotelManager.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelManager.Present
{
    public partial class frmLapHoaDon : Form
    {
        public frmLapHoaDon()
        {
            InitializeComponent();
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            dtpNgay.Value = DateTime.Now;
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (CheckInputOk() == false)
                return;
            else
            {
                DataTable data = ((DataTable)dgvKetQua.DataSource);
                double trigia = 0;

                //foreach (DataGridViewRow row in dgvKetQua.Rows)
                for(int i = 0; i < dgvKetQua.Rows.Count - 1; ++i)
                {   
                    //=>MaPhong
                    //Đọc từ PHIEUTHUEPHONG phiếu có: 
                    //MaPhong == MaPhong(dgvKetQua)
                    //MaPhieuThue là MAX
                    //=>MaPhieuThue
                    //=>Thêm NgayTraPhong vô phiếu thuê đó
                    //=>Ngày trả phòng
                    //=>DonGia

                    DataGridViewRow row = dgvKetQua.Rows[i];
                    int maphong = Int32.Parse(row.Cells[0].Value.ToString()); ///////////////////////////////////////////////////////////

                    PhieuThuePhong phieuThue = BusPhieuThuePhong.GetPrevious(maphong);
                    if (phieuThue == null)
                    {
                        MessageBox.Show("Phòng không được thuê");
                        return;
                    }

                    //gán giá trị cho Ngày Trả Phòng
                    if (phieuThue.NgayTraPhong == DateTime.MaxValue || phieuThue.NgayTraPhong == DateTime.MinValue || phieuThue.NgayTraPhong == null)
                    {
                        phieuThue.NgayTraPhong = DateTime.Now;

                        BusPhieuThuePhong.UpdatePhieuThue(phieuThue);
                    }

                    int songaythue = (phieuThue.NgayTraPhong - phieuThue.NgayBatDauThue).Days + 1;

                    //Đọc từ CHITIETPHIEUTHUE chi tiết có:
                    //MaPhieuThue == MaPhieuThue ở trên
                    //=>List ChiTietPhieuThuePhong(Danh sách khách hàng thuê phòng đó)
                    //Duyệt hết đọc ra các
                    //=>Thành tiền

                    DataTable listChiTietPT = BusChiTietPhieuThue.FindMaPhieuThue(phieuThue.MaPhieuThue);
                    
                    int soluongkhach = listChiTietPT.Rows.Count;
                    if (soluongkhach == 0)
                    {
                        if(trigia > 0)
                            txtTriGia.Text = trigia + " VND";

                        MessageBox.Show("Không có khách nào ở phòng Mã Phòng[" + phieuThue.MaPhong + "] !!!???");
                        return;
                    }

                    double heso = 1.0f; //phụ thuộc vào loại khách
                    
                    foreach (DataRow rowChiTiet in listChiTietPT.Rows)
                    {
                        //Tinh toan he so nhan <= loaikhach
                        int maloaikhach = (int)rowChiTiet["MaLoaiKhach"];
                        double newheso = BusLoaiKhach.Find(maloaikhach).HeSo;

                        if (heso < newheso)
                        {
                            heso = newheso;
                        }
                    }

                    double dongia = (double)phieuThue.DonGiaThue;
                    double phuthu = BusPhuThu.Find(soluongkhach).TyLePhuThu;
                    double thanhtien = (dongia * (1 + phuthu) * heso * songaythue); //////////////////////////////////////////////////////////////

                    //Update dữ liệu cho các ô

                    row.Cells["NgayTraPhong"].Value = phieuThue.NgayTraPhong;
                    row.Cells["DonGia"].Value = phieuThue.DonGiaThue;
                    row.Cells["ThanhTien"].Value = thanhtien;

                    trigia += thanhtien;
                }

                txtTriGia.Text = trigia + " VND";

                //Lưu xuống bộ nhớ
                //NO! chán quá

                //In ra
                
            }
        }

        /// <summary>
        /// Kiểm tra các ô nhập có đúng chưa
        /// </summary>
        private bool CheckInputOk()
        {
            if (txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Chưa có tên khách hàng!");
                txtTenKhachHang.Focus();
                return false;
            }

            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Chưa có địa chỉ khách hàng!");
                txtDiaChi.Focus();
                return false;
            }

            if (dgvKetQua.Rows.Count < 1)
            {
                MessageBox.Show("Chưa có thông tin Phòng thuê!");
                dgvKetQua.Focus();
                return false;
            }

            return true;
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data =Supporter.GetDataTable(dgvKetQua);

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel 2003(.xls)|*.xls|CSV File(*.csv)|*.csv";
                dialog.FileName = "Bill";

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    string file = dialog.FileName;

                    if (file.EndsWith("xls"))
                        Exporter.ExportToExcel(file, data);
                    else if (file.EndsWith("csv"))
                        Exporter.ExportToExcel(file, data);

                    //MessageBox.Show("Luwu")
                    System.Diagnostics.Process.Start(file);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xuất file.");
            }
        }
    }
}

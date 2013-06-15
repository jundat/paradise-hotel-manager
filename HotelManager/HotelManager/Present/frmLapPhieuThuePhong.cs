using HotelManager.Business;
using HotelManager.Data;
using HotelManager.Data.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelManager.Present
{
    public partial class frmLapPhieuThuePhong : Form
    {
        Phong phongDuocChon;
        DataLoaiPhong loaiphongDuocChon;

        public frmLapPhieuThuePhong()
        {
            InitializeComponent();
        }

        /// <summary>
        /// khởi tạo giao diện
        /// </summary>
        private void frmLPTP_Load(object sender, EventArgs e)
        {
            //Họ tên
            DataGridViewTextBoxColumn tbHoTen = new DataGridViewTextBoxColumn();
            tbHoTen.HeaderText = "Họ Tên";
            tbHoTen.Name = "colHoTen";
            tbHoTen.ValueType = typeof(string);
            dgvKetQua.Columns.Add(tbHoTen);

            //CMND
            DataGridViewTextBoxColumn tbCMND = new DataGridViewTextBoxColumn();
            tbCMND.HeaderText = "CMND";
            tbCMND.Name = "colCMND";
            tbCMND.ValueType = typeof(string);
            dgvKetQua.Columns.Add(tbCMND);

            //Địa Chỉ
            DataGridViewTextBoxColumn tbDiaChi = new DataGridViewTextBoxColumn();
            tbDiaChi.HeaderText = "Địa Chỉ";
            tbDiaChi.Name = "colDiaChi";
            tbDiaChi.ValueType = typeof(string);
            dgvKetQua.Columns.Add(tbDiaChi);

            //Tên Loại Khách + Tên Loại Khách
            //DataGridViewComboBoxColumn cmbTenLoaiKhach = new DataGridViewComboBoxColumn();
            //cmbTenLoaiKhach.HeaderText = "Tên Loại Khách";
            //cmbTenLoaiKhach.Name = "colTenLoaiKhach";
            //cmbTenLoaiKhach.ValueType = typeof(string);
            //cmbTenLoaiKhach.ReadOnly = true;

            DataGridViewComboBoxColumn cmbMaLoaiKhach = new DataGridViewComboBoxColumn();
            cmbMaLoaiKhach.HeaderText = "Mã Loại Khách";
            cmbMaLoaiKhach.Name = "colMaLoaiKhach";
            cmbMaLoaiKhach.ValueType = typeof(int);
            

            ArrayList listLoaiKhach = BusLoaiKhach.GetList();
            foreach (LoaiKhach loaiKhach in listLoaiKhach)
            {
                //cmbTenLoaiKhach.Items.Add(loaiKhach.TenLoaiKhach);
                cmbMaLoaiKhach.Items.Add(loaiKhach.MaLoaiKhach);
            }

            //dgvKetQua.Columns.Add(cmbTenLoaiKhach);
            dgvKetQua.Columns.Add(cmbMaLoaiKhach);
        }

        /// <summary>
        /// Reset các ô lại giá trị trống
        /// </summary>
        private void ResetInput()
        {
            phongDuocChon = null;
            loaiphongDuocChon = null;
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtMaLoaiPhong.Text = "";
            txtTenLoaiPhong.Text = "";
            txtDonGia.Text = "";
            dtpNgayThue.Value = DateTime.Now;
            
            try{dgvKetQua.Rows.Clear();}catch { }
        }

        /// <summary>
        /// Xử lý button Lưu
        /// </summary>
        private void bttLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra các textbox có hợp lệ
            if (CheckInputOk() == false)
            {
                return;
            }            

            //Update vào PHONG
            phongDuocChon.TinhTrang = true;
            BusPhong.UpdatePhong(phongDuocChon);

            //Lưu vào PHIEUTHUEPHONG
            PhieuThuePhong phieu = new PhieuThuePhong();
            phieu.DonGiaThue = loaiphongDuocChon.DonGia;
            phieu.MaPhong = phongDuocChon.MaPhong;
            phieu.NgayBatDauThue = dtpNgayThue.Value;
            phieu.NgayTraPhong = DateTime.MaxValue;
            int maPhieuThue = BusPhieuThuePhong.Add(phieu);

            //Lưu ChiTietPhieuThue vào CHITIETPHIEUTHUE
            ChiTietPhieuThue chitiet = new ChiTietPhieuThue();

            int count = dgvKetQua.Rows.Count - 1;
            for(int i = 0; i < count; ++i)
            {
                DataGridViewRow row = dgvKetQua.Rows[i];

                chitiet.TenKhachHang = (string)row.Cells["colHoTen"].Value;
                chitiet.CMND = (string)row.Cells["colCMND"].Value;
                chitiet.DiaChi = (string)row.Cells["colDiaChi"].Value;
                chitiet.MaLoaiKhach = (int)row.Cells["colMaLoaiKhach"].Value;
                chitiet.MaPhieuThue = maPhieuThue;

                BusChiTietPhieuThue.Add(chitiet);
            }

            if (count > 0)
            {
                MessageBox.Show("Lưu thành công: " + count + " khách.");
                ResetInput();
            }
            else
                MessageBox.Show("Không có nội dung để lưu.");
        }

        /// <summary>
        /// Kiểm tra các ô nhập liệu đã hợp lệ chưa
        /// </summary>
        private bool CheckInputOk()
        {
            //thông tin phòng
            if (txtMaLoaiPhong.Text == "" || 
                txtTenLoaiPhong.Text == "" || 
                txtDonGia.Text == "" || 
                txtMaPhong.Text == "" || 
                txtTenPhong.Text == "")
            {
                MessageBox.Show("Thông tin không hợp lệ.");
                return false;
            }

            //tình trạng phòng
            if (phongDuocChon.TinhTrang == true)
            {
                MessageBox.Show("Phòng đã có người thuê");
                return false;
            }

            //ngày thuê
            DateTime hientai = DateTime.Now;
            if (dtpNgayThue.Value.Year < hientai.Year)
                return false;
            if (dtpNgayThue.Value.Month < hientai.Month)
                return false;
            if (dtpNgayThue.Value.Day < hientai.Day)
                return false;

            //Kiểm tra danh sách khách có hợp lệ
            if (dgvKetQua.Rows.Count < 1)
            {
                MessageBox.Show("Chưa có thông tin khách hàng");
                return false;
            }

            try
            {
                int count = dgvKetQua.Rows.Count - 1;
                for (int i = 0; i < count; ++i)
                {
                    DataGridViewRow row = dgvKetQua.Rows[i];

                    string TenKhachHang = (string)row.Cells["colHoTen"].Value;
                    string CMND = (string)row.Cells["colCMND"].Value;
                    string DiaChi = (string)row.Cells["colDiaChi"].Value;
                    int MaLoaiKhach = (int)row.Cells["colMaLoaiKhach"].Value;

                    if (TenKhachHang == null)
                    {
                        MessageBox.Show("Thông tin khách hàng chưa đủ hoặc sai.");
                        return false;
                    }

                    if (CMND == null)
                    {
                        MessageBox.Show("Thông tin khách hàng chưa đủ hoặc sai.");
                        return false;
                    }

                    if (DiaChi == null)
                    {
                        MessageBox.Show("Thông tin khách hàng chưa đủ hoặc sai.");
                        return false;
                    }
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show("Thông tin khách hàng chưa đủ hoặc sai.");
                return false;
            }

            return true;
        }
        
        /// <summary>
        /// Xử lý việc tìm kiếm thông tin phòng khi nhập vào Mã Phòng hoặc Tên Phòng.
        /// </summary>
        private void txtTenPhong_TextChanged(object sender, EventArgs e)
        {
            string tenphong = txtTenPhong.Text;
            int maphong = -1;
            bool have = false;

            try
            {
                maphong = Int32.Parse(txtMaPhong.Text);
            }
            catch
            {
                maphong = -1;
            }

            if (sender == txtMaPhong)
            {
                if (maphong != -1)
                {
                    ArrayList listPhong = DataPhong.GetList();
                    foreach (Phong phong in listPhong)
                    {
                        if (phong.MaPhong == maphong)
                        {
                            txtTenPhong.Text = phong.TenPhong;
                            txtMaLoaiPhong.Text = phong.MaLoaiPhong + "";
                            txtTinhTrang.Text = phong.TinhTrang ? "Đã thuê" : "Còn trống";

                            DataLoaiPhong lp = DataLoaiPhong.Find(phong.MaLoaiPhong);
                            txtTenLoaiPhong.Text = lp.TenLoaiPhong;
                            txtDonGia.Text = lp.DonGia + "";

                            this.phongDuocChon = phong;
                            this.loaiphongDuocChon = lp;

                            have = true;
                            break;
                        }
                    }
                }
            }
            else if (sender == txtTenPhong)
            {
                if (tenphong != "")
                {
                    ArrayList listPhong = DataPhong.GetList();

                    foreach (Phong phong in listPhong)
                    {
                        if (phong.TenPhong == tenphong)
                        {
                            txtMaPhong.Text = phong.MaPhong + "";
                            txtMaLoaiPhong.Text = phong.MaLoaiPhong + "";
                            txtTinhTrang.Text = phong.TinhTrang ? "Đã thuê" : "Còn trống";

                            DataLoaiPhong lp = DataLoaiPhong.Find(phong.MaLoaiPhong);
                            txtTenLoaiPhong.Text = lp.TenLoaiPhong;
                            txtDonGia.Text = lp.DonGia + "";

                            this.phongDuocChon = phong;
                            this.loaiphongDuocChon = lp;

                            have = true;
                            break;
                        }
                    }
                }
            }

            if (have == false)
            {
                //if(sender == txtMaPhong)
                //    txtTenPhong.Text = "";
                //else if(sender == txtTenPhong)
                //    txtMaPhong.Text = "";

                txtMaLoaiPhong.Text = "";
                txtTenLoaiPhong.Text = "";
                txtDonGia.Text = "";
                txtTinhTrang.Text = "";
            }
        }
    }
}

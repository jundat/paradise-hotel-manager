using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HotelManager.Business;
using HotelManager.Data.Entity;
using HotelManager.Data;
using System.Collections;

namespace HotelManager.Present
{
    public partial class Lap_Phieu_Thu : Form
    {
        public Lap_Phieu_Thu()
        {
            InitializeComponent();

            //
            this.FirstLoad();
        }
        
        private void FirstLoad()
        {
            this.txtNhanVien.Text = frmMain.nv.TenNhanVien;

            //init data gridview
            //Loại phí
            DataColumn tbLoaiPhi = new DataColumn();
            tbLoaiPhi.Caption = "Loai Phi";
            tbLoaiPhi.ColumnName = "Loai Phi";
            tbLoaiPhi.DataType = typeof(string);

            //Mã Phiếu
            DataColumn tbMaPhieu = new DataColumn();
            tbMaPhieu.Caption = "Ma Phieu";
            tbMaPhieu.ColumnName = "Ma Phieu";
            tbMaPhieu.DataType = typeof(string);

            //Chi phí
            DataColumn tbChiPhi = new DataColumn();
            tbChiPhi.Caption = "Chi Phi";
            tbChiPhi.ColumnName = "Chi Phi";
            tbChiPhi.DataType = typeof(string);

            //Ghi chú
            DataColumn tbGhiChu = new DataColumn();
            tbGhiChu.Caption = "Ghi Chu";
            tbGhiChu.ColumnName = "Ghi Chu";
            tbGhiChu.DataType = typeof(string);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(tbLoaiPhi);
            dataTable.Columns.Add(tbMaPhieu);
            dataTable.Columns.Add(tbChiPhi);
            dataTable.Columns.Add(tbGhiChu);

            dataMain.DataSource = dataTable;
        }

        /// <summary>
        /// Lay thong tin khach hang tu Ten Khach Hang va CMND
        /// </summary>
        private bool TinhToanChiPhi()
        {
            string cmnd = this.txtCMND.Text;
            string tenkhach = "";

            DataTable datatable = (DataTable)dataMain.DataSource;

            float result = BusPhieuThu.getInformation(cmnd, ref tenkhach, ref datatable);
            if (result < 0)
            {
                MessageBox.Show("Không tìm thấy!");
                return false;
            }

            int phiThietHai = 0;
            try
            {
                if (this.txtPhiThietHai.Text != "")
                {
                    phiThietHai = Int32.Parse(this.txtPhiThietHai.Text);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Phí thiệt hại điền giá trị sai!");
                return false;
            }

            this.txtKhachHang.Text = tenkhach;
            this.txtTongChiPhi.Text = "" + (result + phiThietHai);

            //save to table PHIEU_THU
            PhieuThu pt = new PhieuThu();
            pt.CMND = txtCMND.Text;
            pt.TenKhach = txtKhachHang.Text;
            pt.ThoiDiemThu = dtThoiDiemThu.Value;
            pt.TongTienThu = (float)Convert.ToDouble(txtTongChiPhi.Text);
            pt.MaNhanVien = frmMain.nv.MaNhanVien;
            BusPhieuThu.Add(pt);
            
            return true;
        }
        
        private void btThanhToan_Click(object sender, EventArgs e)
        {
            ((DataTable)dataMain.DataSource).Clear();

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn rằng khách hàng đã nộp đủ các khoản phí kể trên !", "Vui lòng xác nhận lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Checkout();
            }

            this.btThanhToan.Enabled = false;
        }

        /// <summary>
        /// Cập nhật lại tình trạng phòng và tình trạng thanh toán cho Bảng phòng, Phiếu đến
        /// Bảng kê dịch vụ, Hóa đơn đặt tiệc
        /// </summary>
        private void Checkout()
        {
            for (int i = 0; i < dataMain.Rows.Count - 1; i++)
            {
                // Lấy thông itn Mã loại phí và Mã bảng trên DataGridView
                int MaLoaiPhi = Convert.ToInt32(dataMain.Rows[i].Cells[0].Value.ToString());
                int MaBang = Convert.ToInt32(dataMain.Rows[i].Cells[1].Value.ToString());

                String TenBang = BusLoaiPhi.FindTenBang(MaLoaiPhi);

                if ("PhieuDen".Equals(TenBang))
                {
                    // Xác nhận trả phòng cho tất cả các phòng của phiếu đến
                    foreach (int maPhong in BusChiTietPhieuDen.FindMaPhongCuaMaPhieuDen(MaBang))
                    {
                        BusPhong.TraPhong(maPhong);
                    }

                    // Xác nhận lại là đã thanh toán
                    BusPhieuDen.ThanhToan(MaBang);
                }

                if ("PhieuDatTiec".Equals(TenBang))
                {
                    // Xác nhận lại là đã thanh toán
                    BusPhieuDatTiec.ThanhToan(MaBang);
                }

                if ("BangKe".Equals(TenBang))
                {
                    // Xác nhận lại là đã thanh toán
                    BusBangKe.ThanhToan(MaBang);
                }
            }
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            if (TinhToanChiPhi() == true)
            {
                this.btThanhToan.Enabled = true;
            }
        }

        private void btInPhieuThu_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)dataMain.DataSource;

            if (data != null)
            {
                string title = "\n\tPHIEU THU\n"
                    + "\nKHACH HANG: "
                    + "\t" + txtKhachHang.Text
                    + "\nCMND: "
                    + "\t" + txtCMND.Text
                    + "\nTHIET HAI: "
                    + "\t" + txtPhiThietHai.Text
                    + "\nNGAY THU: "
                    + "\t" + dtThoiDiemThu.Value.ToString()
                    + "\nNHAN VIEN: "
                    + "\t" + txtNhanVien.Text
                    + "\nTONG TIEN: "
                    + "\t" + txtTongChiPhi.Text;

                Exporter.ToCsV(title, dataMain);
            }
        }
    }
}

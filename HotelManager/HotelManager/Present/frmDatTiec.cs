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

namespace HotelManager.Present
{
    public partial class frmDatTiec : Form
    {
        public frmDatTiec()
        {
            InitializeComponent();
        }


        /// Kiểm tra lỗi nhập liệu ở các ô Tên dịch vụ, Đơn giá, Số lượng
        /// </summary>
        /// <returns></returns>
        private bool coLoiNhapLieu()
        {
            // Kiểm tra trạng thái ô nhập liệu trước khi nhập vô DataGridView
            if ("".Equals(tbTenMon.Text) || "".Equals(tbDonGia.Text) || "".Equals(tbSoLuong.Text))
            {
                MessageBox.Show("Tên món, Đơn giá, Số lượng không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            try
            {
                float donGia = float.Parse(tbDonGia.Text);
                float soLuong = float.Parse(tbSoLuong.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Đơn giá, Số lượng phải là số !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra lỗi nhập liệu
            if (coLoiNhapLieu())
                return;

            // Nếu ko có lỗi nhập liệu thì lấy và chuyển đổi các thông số là số.
            float donGia = float.Parse(tbDonGia.Text);
            float soLuong = float.Parse(tbSoLuong.Text);

            // Kiểm tra  lỗi trùng tên món
            foreach (DataGridViewRow row in dgvDanhSachMon.Rows)
            {
                if (tbTenMon.Text.Equals(row.Cells[1].Value))
                {
                    DialogResult result = MessageBox.Show("Món bạn muốn thêm đã tồn tại ! \n - Chọn Yes để cộng dồn. \n - Chọn No để ghi đè lên. \n - Chọn Cancel để hủy bỏ", "Lỗi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

                    // Cộng dồn vô cột số lượng
                    if (result == DialogResult.Yes)
                    {
                        row.Cells[3].Value = float.Parse(row.Cells[3].Value.ToString()) + soLuong;
                    }
                    else if (result == DialogResult.No)
                    {
                        row.Cells[3].Value = soLuong;
                    }

                    return;
                }
            }

            // Hết lỗi thì thêm vô cuối danh sách các dịch vụ mới
            dgvDanhSachMon.Rows.Add(dgvDanhSachMon.Rows.Count, tbTenMon.Text, donGia, soLuong, rtbYeuCau.Text);

            TinhTongSoTienCuaPhieu();

        }

        private void TinhTongSoTienCuaPhieu()
        {
            float sum = 0;
            for (int i = 0; i < dgvDanhSachMon.Rows.Count - 1; i++)
            {
                // Nếu ko có lỗi nhập liệu thì lấy và chuyển đổi các thông số là số.
                float donGia = float.Parse(dgvDanhSachMon.Rows[i].Cells[2].Value.ToString());
                float soLuong = float.Parse(dgvDanhSachMon.Rows[i].Cells[3].Value.ToString());
                sum += donGia * soLuong;
            }

            // cập nhật lê giao diện
            tbTongTien.Text = sum.ToString();

            // Cập nhật trạng thái của nút đặt tiệc
            if (sum > 0)
            {
                btnDat.Enabled = true;
            }
            else
            {
                btnDat.Enabled = false;
            }
        }

        private void dgvDanhSachMon_SelectionChanged(object sender, EventArgs e)
        {
            // Sự kiện người dùng chọn cả 1 dòng để chỉnh sửa
            if (dgvDanhSachMon.SelectedRows.Count == 1)
            {
                // Kiểm tra dòng đang chọn ko rống hay không thi đưa thông tin trên dòng lên các TextBox
                if ("".Equals(dgvDanhSachMon.SelectedRows[0].Cells[0].Value.ToString()) == false)
                {
                    tbTenMon.Text = dgvDanhSachMon.SelectedRows[0].Cells[1].Value.ToString();
                    tbDonGia.Text = dgvDanhSachMon.SelectedRows[0].Cells[2].Value.ToString(); ;
                    tbSoLuong.Text = dgvDanhSachMon.SelectedRows[0].Cells[3].Value.ToString();
                    rtbYeuCau.Text = dgvDanhSachMon.SelectedRows[0].Cells[4].Value.ToString();
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các dòng đang chọn
            foreach (DataGridViewRow row in dgvDanhSachMon.SelectedRows)
            {
                dgvDanhSachMon.Rows.Remove(row);
            }

            // Cập nhật lại cột Số thứ tự trên DataGridView
            if (dgvDanhSachMon.Rows.Count > 1)
            {
                int i = 1;
                foreach (DataGridViewRow row in dgvDanhSachMon.Rows)
                {
                    if (i < dgvDanhSachMon.Rows.Count)
                        row.Cells[0].Value = i++;
                }
            }

            TinhTongSoTienCuaPhieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachMon.SelectedRows.Count != 1)
            {
                MessageBox.Show("Bạn phải chọn một dòng để có thể sửa", "Lỗi  chọn dòng dữ liệu thao tác", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra lỗi nhập liệu
            if (coLoiNhapLieu())
                return;

            float donGia = float.Parse(tbDonGia.Text);
            float soLuong = float.Parse(tbSoLuong.Text);

            // Sửa thông tin dngf đang chọn
            dgvDanhSachMon.Rows[0].Cells[1].Value = tbTenMon.Text;
            dgvDanhSachMon.Rows[0].Cells[2].Value = tbDonGia.Text;
            dgvDanhSachMon.Rows[0].Cells[3].Value = tbSoLuong.Text;
            dgvDanhSachMon.Rows[0].Cells[4].Value = rtbYeuCau.Text;

            TinhTongSoTienCuaPhieu();
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái ô nhập liệu trước khi nhập vô DataGridView
            if ("".Equals(tbTenKhach.Text) || "".Equals(tbCMND.Text) || "".Equals(tbTenPhong.Text))
            {
                MessageBox.Show("Tên khách, CMND, Tên phòng không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hết lỗi rồi thì tạo một Phiếu đặt tiệc
            PhieuDatTiec phieuDatTiec = new PhieuDatTiec();
            phieuDatTiec.TenKhach = tbTenKhach.Text;
            
            Phong phong = BusPhong.FindTheoTenPhong(tbTenPhong.Text);
            phieuDatTiec.MaPhong = phong.MaPhong;
            if (phong.MaPhong == 0)
            {
                MessageBox.Show("Tên phòng không tồn tại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            phieuDatTiec.ThoiDiem = dtpThoiDiemDat.Value.Date;
            //DateTime now = new DateTime();
            //phieuDatTiec.ThoiDiem.AddHours(now.Hour);
            //phieuDatTiec.ThoiDiem.AddMinutes(now.Minute);
            //phieuDatTiec.ThoiDiem.AddSeconds(now.Second);
            
            phieuDatTiec.TongTien = float.Parse(tbTongTien.Text);
            phieuDatTiec.TinhTrangThanhToan = false;
            BusPhieuDatTiec.Add(phieuDatTiec);

            // Tạo và thêm các chi tiết cho phiếu
            int count = 0;
            for (int i = 0; i < dgvDanhSachMon.Rows.Count - 1; i++)
            {
                ChiTietPhieuDatTiec chiTietPhieuDatTiec = new ChiTietPhieuDatTiec();
                chiTietPhieuDatTiec.MaPhieuDatTiec = phieuDatTiec.MaPhieuDatTiec;
                chiTietPhieuDatTiec.TenMon = dgvDanhSachMon.Rows[i].Cells[1].Value.ToString();
                chiTietPhieuDatTiec.DonGia = float.Parse(dgvDanhSachMon.Rows[i].Cells[2].Value.ToString());
                chiTietPhieuDatTiec.SoLuong = int.Parse(dgvDanhSachMon.Rows[i].Cells[3].Value.ToString());
                chiTietPhieuDatTiec.YeuCau = dgvDanhSachMon.Rows[i].Cells[4].Value.ToString();
                BusChiTietPhieuDatTiec.Add(chiTietPhieuDatTiec);
                count++;
            }

            MessageBox.Show("Đã thêm thành công " + count + " món cho bữa tiệc của khách hàng: " + tbTenKhach.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}

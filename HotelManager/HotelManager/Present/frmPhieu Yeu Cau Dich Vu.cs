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
    public partial class Phieu_Yeu_Cau_Dich_Vu : Form
    {
        private bool _tinhTrangPhong; // false nếu trống | true nếu đang được thuê

        public Phieu_Yeu_Cau_Dich_Vu()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Kiểm tra lỗi nhập liệu ở các ô Tên dịch vụ, Đơn giá, Số lượng
        /// </summary>
        /// <returns></returns>
        private bool coLoiNhapLieu()
        {
            // Kiểm tra trạng thái ô nhập liệu trước khi nhập vô DataGridView
            if ("".Equals(tbTenDichVu.Text) || "".Equals(tbDonGia.Text) || "".Equals(tbSoLuong.Text))
            {
                MessageBox.Show("Tên dịch vụ, Đơn giá, Số lượng không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /// <summary>
        /// Thêm một dịch vụ vô dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (coLoiNhapLieu())
                return;

            float donGia = float.Parse(tbDonGia.Text);
            float soLuong = float.Parse(tbSoLuong.Text);

            // Kiểm tra  lỗi trùng tên dịch vụ
            foreach (DataGridViewRow row in dgvDanhSachDichVuMoiYeuCau.Rows)
            {
                if (tbTenDichVu.Text.Equals(row.Cells[1].Value))
                {
                    DialogResult result = MessageBox.Show("Dịch vụ bạn muốn thêm đã tồn tại ! \n - Chọn Yes để cộng dồn. \n - Chọn No để ghi đè lên. \n - Chọn Cancel để hủy bỏ", "Lỗi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                    
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
            dgvDanhSachDichVuMoiYeuCau.Rows.Add(dgvDanhSachDichVuMoiYeuCau.Rows.Count, tbTenDichVu.Text, donGia, soLuong, tbGhiChu.Text);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDanhSachDichVuMoiYeuCau.SelectedRows)
            {
                dgvDanhSachDichVuMoiYeuCau.Rows.Remove(row);
            }

            // Cập nhật lại cột Số thứ tự
            if (dgvDanhSachDichVuMoiYeuCau.Rows.Count > 1)
            {
                int i = 1;
                foreach (DataGridViewRow row in dgvDanhSachDichVuMoiYeuCau.Rows)
                {
                    if (i < dgvDanhSachDichVuMoiYeuCau.Rows.Count)
                        row.Cells[0].Value = i++;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachDichVuMoiYeuCau.SelectedRows.Count != 1)
            {
                MessageBox.Show("Bạn phải chọn một dòng để có thể sửa", "Lỗi  chọn dòng dữ liệu thao tác", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sửa

            if (coLoiNhapLieu())
                return;

            float donGia = float.Parse(tbDonGia.Text);
            float soLuong = float.Parse(tbSoLuong.Text);

            // Sửa thông tin dngf đang chọn
            dgvDanhSachDichVuMoiYeuCau.Rows[0].Cells[1].Value = tbTenDichVu.Text;
            dgvDanhSachDichVuMoiYeuCau.Rows[0].Cells[2].Value = tbDonGia.Text;
            dgvDanhSachDichVuMoiYeuCau.Rows[0].Cells[3].Value = tbSoLuong.Text;
            dgvDanhSachDichVuMoiYeuCau.Rows[0].Cells[4].Value = tbGhiChu.Text;
        }

        private void dgvDanhSachDichVuMoiYeuCau_SelectionChanged(object sender, EventArgs e)
        {
            // Sự kiện người dùng chọn cả 1 dòng để chỉnh sửa
            if (dgvDanhSachDichVuMoiYeuCau.SelectedRows.Count == 1)
            {
                // Kiểm tra dòng đang chọn có rống hay không
                if ("".Equals(dgvDanhSachDichVuMoiYeuCau.SelectedRows[0].Cells[0].Value.ToString()) == false)
                {
                    tbTenDichVu.Text = dgvDanhSachDichVuMoiYeuCau.SelectedRows[0].Cells[1].Value.ToString();
                    tbDonGia.Text = dgvDanhSachDichVuMoiYeuCau.SelectedRows[0].Cells[2].Value.ToString(); ;
                    tbSoLuong.Text = dgvDanhSachDichVuMoiYeuCau.SelectedRows[0].Cells[3].Value.ToString();
                    tbGhiChu.Text = dgvDanhSachDichVuMoiYeuCau.SelectedRows[0].Cells[4].Value.ToString();
                }
            }
        }


        /// <summary>
        /// Tìm tất cả các Chi tiết bảng kê dịch vụ cho phòng có tên là trường Text của TextBox tbTenPhong
        /// và hiển thị lên giao diện.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbTenPhong_TextChanged(object sender, EventArgs e)
        {
            
            // Lấy tình trạng phòng
            String tenPhong = tbTenPhong.Text;
            if ("".Equals(tbTenPhong.Text))
                tenPhong = "_";

            // Timg phòng theo tên nhập vào, nếu không thấy thì thoát luôn
            Phong phong = BusPhong.FindTheoTenPhong(tenPhong);
            if (phong.MaPhong == 0)
            {
                lblTinhTrangPhong.ForeColor = Color.Red;
                lblTinhTrangPhong.Text = "Không tìm thấy phòng bạn cần tìm !";
                groupBox1.Enabled = false;
                return;
            }

            // Nếu phòng không trống (đang đc thuê)
            if (phong.TinhTrangHienTai == true)
            {
                lblTinhTrangPhong.ForeColor = Color.Blue;
                lblTinhTrangPhong.Text = "Tình trạng: Phòng đang được thuê.";
                btnThemDanhSachDichVuMoi.Enabled = true;
                groupBox1.Enabled = true;
            }// Nếu trống
            else
            {
                lblTinhTrangPhong.ForeColor = Color.Red;
                lblTinhTrangPhong.Text = "Tình trạng: Phòng đang trống không được phép yêu cầu dịch vụ !";
                btnThemDanhSachDichVuMoi.Enabled = false;
                groupBox1.Enabled = false;
                return;
            }

            // Tìm bảng kê có mã phòng là mã của phòng vừa tìm đc và tình trạng thanh toán là false: chưa thanh toán
            BangKe bangKe = BusBangKe.Find(phong.MaPhong, false);
            tbTongChiPhiDenHienTai.Text = bangKe.TongChiPhi.ToString();

            // Nếu không thấy thì tạo một Bảng Kê mới cho phòng
            if (bangKe.MaBangKe == 0)
            {
                bangKe.MaPhong = phong.MaPhong;
                bangKe.TongChiPhi = 0;
                bangKe.TinhTrangThanhToan = false;
                BusBangKe.Add(bangKe);
            }

            // Nạp tất cả các dòng Chi tiết của bảng kê lên dgvDanhSachDichVuDaYeuCau
            NapChiTietBangKe(bangKe);
        }

        private void NapChiTietBangKe(BangKe bangKe)
        {
            // Nạp lại thông số bảng kê
            bangKe = BusBangKe.Find(bangKe.MaBangKe);

            // Đã có bảng kê rồi thì tìm tiếp tất cả các chi tiết bảng kê của nó bỏ vô DataGridView
            int i = 1;
            dgvDanhSachDichVuDaYeuCau.Rows.Clear();
            foreach (ChiTietBangKe ct in BusChiTietBangKe.GetList(bangKe.MaBangKe))
            {
                dgvDanhSachDichVuDaYeuCau.Rows.Add(i++, ct.TenDichVu, ct.ThoiDiemGoi, ct.DonGia, ct.SoLuong, ct.GhiChu);
            }

            tbTongChiPhiDenHienTai.Text = bangKe.TongChiPhi.ToString();
        }
        private void btnThemDanhSachDichVuMoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dịch vụ nào để thêm ko
            if (dgvDanhSachDichVuMoiYeuCau.Rows.Count <= 1)
            {
                MessageBox.Show("Hãy thêm dịch vụ khách hàng yêu cầu trước khi nhấn nút này !", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm bảng kê của phòng
            Phong phong = BusPhong.FindTheoTenPhong(tbTenPhong.Text);
            BangKe bangKe = BusBangKe.Find(phong.MaPhong, false);

            // Thêm các Chi tiết cho Bảng kê
            int count = 0;
            for (int i = 0; i < dgvDanhSachDichVuMoiYeuCau.Rows.Count - 1; i++ )
            {
                ChiTietBangKe chiTietBangKe = new ChiTietBangKe();
                chiTietBangKe.MaBangKe = bangKe.MaBangKe;
                chiTietBangKe.TenDichVu = dgvDanhSachDichVuMoiYeuCau.Rows[i].Cells[1].Value.ToString();
                chiTietBangKe.ThoiDiemGoi = new DateTime();
                chiTietBangKe.DonGia = float.Parse(dgvDanhSachDichVuMoiYeuCau.Rows[i].Cells[2].Value.ToString());
                chiTietBangKe.SoLuong = int.Parse(dgvDanhSachDichVuMoiYeuCau.Rows[i].Cells[3].Value.ToString());
                chiTietBangKe.GhiChu = dgvDanhSachDichVuMoiYeuCau.Rows[i].Cells[4].Value.ToString();

                BusChiTietBangKe.Add(chiTietBangKe);
                count++;

            }

            // xóa danh sách các dịch vụ đã đc thêm
            dgvDanhSachDichVuMoiYeuCau.Rows.Clear();

            MessageBox.Show("Đã thêm " + count + " dịch vụ cho phòng " + phong.TenPhong, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Nạp tất cả các dòng Chi tiết của bảng kê lên dgvDanhSachDichVuDaYeuCau
            NapChiTietBangKe(bangKe);
        }
    }
}

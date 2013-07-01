using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using HotelManager.Business;
using HotelManager.Data.Entity;

namespace HotelManager.Present
{
    public partial class frmTheoDoiSuLuuTruCuaKhachHang : Form
    {
        public frmTheoDoiSuLuuTruCuaKhachHang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tbTenKhach.Enabled = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tbCMND.Enabled = radioButton2.Checked;
        }

        private void btnTimTheoThongTinKhach_Click(object sender, EventArgs e)
        {
            lblTieuChiTimKiem.Text = "Thông tin của khách: ";
            if (radioButton1.Checked)
            {
                lblTieuChiTimKiem.Text += "Tên khách";
            }
            else
            {
                lblTieuChiTimKiem.Text += "CMND";
            }

            if (tbTenKhach.Enabled == true && "".Equals(tbTenKhach.Text))
            {
                MessageBox.Show("Nếu tìm theo tên khách hàng thì ô Tên khách không được để trống !", "Lỗi Nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbCMND.Enabled == true && "".Equals(tbCMND.Text))
            {
                MessageBox.Show("Nếu tìm theo CMND thì ô CMND không được để trống !", "Lỗi Nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm kiếm danh sách chi tiết phiếu đến theo tên khách
            ArrayList danhSachChiTietPhieuDen = new ArrayList();

            if (tbTenKhach.Enabled == true)
            {
                danhSachChiTietPhieuDen = BusChiTietPhieuDen.FindDanhSachChiTietPhieuDenTheoTenKhach(tbTenKhach.Text, cbbTinhTrang.Text);
            }

            // Tìm kiếm danh sách chi tiết phiếu đến theo CMND
            if (tbCMND.Enabled == true)
            {
                danhSachChiTietPhieuDen = BusChiTietPhieuDen.FindDanhSachChiTietPhieuDenTheoCMND(tbCMND.Text, cbbTinhTrang.Text);
            }

            // Có danh sách chi tiết rồi sẽ tìm sang Phiếu đến , Bảng kê, Phiếu đặt tiệc tương ứng
            int count = 0;
            dgvKetQuaTimKiemKhachHang.Rows.Clear();
            // Tìm tất cả các Phiếu Đến chưa thanh toán
            // Duyệt tất cả các dòng Chi Tiết Phiếu Đến có Mã Phòng vừa tìm được và có Tình trạnh thanh toán của phiếu đến là false(Chưa thanh toán)
            foreach (ChiTietPhieuDen ct in danhSachChiTietPhieuDen)
            {
                // Tìm tên phòng của khách
                Phong phong = BusPhong.FindMaPhong(ct.MaPhong);

                // Tìm Phiếu Đến của mối chi tiết dựa v ào mã phiếu đến của Chi Tiết
                PhieuDen phieuDen = BusPhieuDen.Find(ct.MaPhieuDen);

                // Tìm Bảng kê của phòng mà khách đang lưu trú dựa vào Mã phòng
                BangKe bangKe = BusBangKe.Find(ct.MaPhong, false);

                // Tìm tất cả các Phiếu đặt tiệc Chưa đc Thanh toán của khách hàng trong phòng và bỏ vô trong một combobox
                DataGridViewComboBoxCell CBCellPhieuDatTiec = new DataGridViewComboBoxCell();
                foreach (PhieuDatTiec phieuDatTiec in BusPhieuDatTiec.FindTheoMaPhongVaTinhTrangThanhToan(ct.MaPhong, false))
                {
                    CBCellPhieuDatTiec.Items.Add(phieuDatTiec.MaPhieuDatTiec);
                }

                // Điền thông tin tìm được của mỗi khách hàng vô DataGridView
                dgvKetQuaTimKiemKhachHang.Rows.Add(++count, ct.TenKhachHang, ct.CMND, phong.TenPhong, phieuDen.ThoiDiemDen, phieuDen.ThoiDiemDi, phieuDen.MaPhieuDen, bangKe.MaBangKe, null);
                DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)(dgvKetQuaTimKiemKhachHang.Rows[dgvKetQuaTimKiemKhachHang.Rows.Count - 2].Cells[8]);
                for (int i = 0; i < CBCellPhieuDatTiec.Items.Count; i++)
                {
                    comboBoxCell.Items.Add(CBCellPhieuDatTiec.Items[i].ToString());
                    comboBoxCell.Value = comboBoxCell.Items[0].ToString();
                }


            }

            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng thỏa  mãn !", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Tìm thấy " + count + " khách hàng thỏa  mãn !", "Tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnTimTheoThoiGianLuuTru_Click(object sender, EventArgs e)
        {
            lblTieuChiTimKiem.Text = "Thời gian lưu trú của khách !";

            // Tìm danh sách các Chi tiết phiếu đến của các Phiếu đến có thời gian lưu trú nằm giữa 2 khoảng thời gian Từ Đến
            ArrayList danhSachChiTietPhieuDen = new ArrayList();
            danhSachChiTietPhieuDen = BusChiTietPhieuDen.FindDanhSachChiTietPhieuDenTrongKhoangThoiGian(dtpTuThoiDiem.Value.Date , dtpDenThoiDiem.Value.Date);

            // Có danh sách chi tiết rồi sẽ tìm sang Phiếu đến , Bảng kê, Phiếu đặt tiệc tương ứng
            int count = 0;
            dgvKetQuaTimKiemKhachHang.Rows.Clear();
            // Tìm tất cả các Phiếu Đến chưa thanh toán
            // Duyệt tất cả các dòng Chi Tiết Phiếu Đến có Mã Phòng vừa tìm được và có Tình trạnh thanh toán của phiếu đến là false(Chưa thanh toán)
            foreach (ChiTietPhieuDen ct in danhSachChiTietPhieuDen)
            {
                // Tìm tên phòng của khách
                Phong phong = BusPhong.FindMaPhong(ct.MaPhong);

                // Tìm Phiếu Đến của mối chi tiết dựa v ào mã phiếu đến của Chi Tiết
                PhieuDen phieuDen = BusPhieuDen.Find(ct.MaPhieuDen);

                // Tìm Bảng kê của phòng mà khách đang lưu trú dựa vào Mã phòng
                BangKe bangKe = BusBangKe.Find(ct.MaPhong, false);

                // Tìm tất cả các Phiếu đặt tiệc Chưa đc Thanh toán của khách hàng trong phòng và bỏ vô trong một combobox
                DataGridViewComboBoxCell CBCellPhieuDatTiec = new DataGridViewComboBoxCell();
                foreach (PhieuDatTiec phieuDatTiec in BusPhieuDatTiec.FindTheoMaPhongVaTinhTrangThanhToan(ct.MaPhong, false))
                {
                    CBCellPhieuDatTiec.Items.Add(phieuDatTiec.MaPhieuDatTiec);
                }

                // Điền thông tin tìm được của mỗi khách hàng vô DataGridView
                dgvKetQuaTimKiemKhachHang.Rows.Add(++count, ct.TenKhachHang, ct.CMND, phong.TenPhong, phieuDen.ThoiDiemDen, phieuDen.ThoiDiemDi, phieuDen.MaPhieuDen, bangKe.MaBangKe, null);
                DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)(dgvKetQuaTimKiemKhachHang.Rows[dgvKetQuaTimKiemKhachHang.Rows.Count - 2].Cells[8]);
                for (int i = 0; i < CBCellPhieuDatTiec.Items.Count; i++)
                {
                    comboBoxCell.Items.Add(CBCellPhieuDatTiec.Items[i].ToString());
                    comboBoxCell.Value = comboBoxCell.Items[0].ToString();
                }


            }

            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng thỏa  mãn !", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Tìm thấy " + count + " khách hàng thỏa  mãn !", "Tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        /// <summary>
        /// Tìm tất cả các khách hàng trong phòng cùng những thông tin liên quan c ủa từng khách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimTheoPhong_Click(object sender, EventArgs e)
        {
            lblTieuChiTimKiem.Text = "Phòng mà khách đang lưu trú !";

            // Tìm được Mã phòng có tên ở textbox và tình trạng là đang được thê
            Phong phong = BusPhong.FindTheoTenPhong(tbPhong.Text);

            if (phong.MaPhong == 0)
            {
                MessageBox.Show("Không tìm thấy phòng " + tbPhong.Text, "Lỗi tìm phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (phong.TinhTrangHienTai == true)
            {
                MessageBox.Show("Chỉ tìm kiếm phòng đang có khách thuê !", "Lỗi tình trạng phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int count = 0;
            dgvKetQuaTimKiemKhachHang.Rows.Clear();
            // Tìm tất cả các Phiếu Đến chưa thanh toán
            // Duyệt tất cả các dòng Chi Tiết Phiếu Đến có Mã Phòng vừa tìm được và có Tình trạnh thanh toán của phiếu đến là false(Chưa thanh toán)
            foreach (ChiTietPhieuDen ct in BusChiTietPhieuDen.FindDanhSachChiTiet(phong.MaPhong, false))
            {
                // Tìm Phiếu Đến của mối chi tiết dựa cào mã phiếu đến của Chi Tiết
                PhieuDen phieuDen = BusPhieuDen.Find(ct.MaPhieuDen);

                // Tìm Bảng kê của phòng mà khách đang lưu trú dựa vào Mã phòng
                BangKe bangKe = BusBangKe.Find(ct.MaPhong, false);

                // Tìm tất cả các Phiếu đặt tiệc Chưa đc Thanh toán của khách hàng trong phòng và bỏ vô trong một combobox
                DataGridViewComboBoxCell CBCellPhieuDatTiec = new DataGridViewComboBoxCell();
                foreach (PhieuDatTiec phieuDatTiec in BusPhieuDatTiec.FindTheoMaPhongVaTinhTrangThanhToan(ct.MaPhong, false))
                {
                    CBCellPhieuDatTiec.Items.Add(phieuDatTiec.MaPhieuDatTiec);
                }

                // Điền thông tin tìm được của mỗi khách hàng vô DataGridView
                dgvKetQuaTimKiemKhachHang.Rows.Add(++count, ct.TenKhachHang, ct.CMND, phong.TenPhong, phieuDen.ThoiDiemDen, phieuDen.ThoiDiemDi, phieuDen.MaPhieuDen, bangKe.MaBangKe, null);
                DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)(dgvKetQuaTimKiemKhachHang.Rows[dgvKetQuaTimKiemKhachHang.Rows.Count - 2].Cells[8]);
                for (int i = 0; i < CBCellPhieuDatTiec.Items.Count; i++)
                {
                    comboBoxCell.Items.Add(CBCellPhieuDatTiec.Items[i].ToString());
                    comboBoxCell.Value = comboBoxCell.Items[0].ToString();
                }
                 
                
            }

            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng thỏa  mãn !", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Tìm thấy "+ count +" khách hàng thỏa  mãn !", "Tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void tbPhong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimTheoPhong_Click(sender, (EventArgs) e);
            }
        }

        private void tbTenKhach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimTheoThongTinKhach_Click(sender, (EventArgs)e);
            }
        }

        private void tbCMND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimTheoThongTinKhach_Click(sender, (EventArgs)e);
            }
        }

    }
}

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
    public partial class frmTraCuuPhieuDen : Form
    {
        public frmTraCuuPhieuDen()
        {
            InitializeComponent();
        }

        private void btnTimPhieuDen_Click(object sender, EventArgs e)
        {
            int count = 0;
            dgvDanhSachPhieuDen.Rows.Clear();
            int MaPhieuDen = 0;
            foreach (PhieuDen ct in BusPhieuDen.Find(tbTenKhachDaiDien.Text, tbCMND.Text, cbbTinhTrangThanhToan.Text))
            {
                count++;
                MaPhieuDen = ct.MaPhieuDen;
                dgvDanhSachPhieuDen.Rows.Add(ct.MaPhieuDen, ct.TenKhachDaiDien, ct.CMND, ct.ThoiDiemDen, ct.ThoiDiemDi, ct.TongChiPhi);
            }

            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy Phiếu đến thỏa  mãn !", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị chi tiết phiếu đến đâu tiên tìm được
            int index = 0;
            dgvDanhSachChiTietPhieuDen.Rows.Clear();
            foreach (ChiTietPhieuDen ct in BusChiTietPhieuDen.GetList(MaPhieuDen))
            {
                lblChiTietCuaPhieuDen.Text = "CHI TIẾT CỦA PHIẾU ĐẾN" + MaPhieuDen;
                Phong phong = BusPhong.FindMaPhong(ct.MaPhong);
                dgvDanhSachChiTietPhieuDen.Rows.Add(++index, phong.TenPhong, ct.TenKhachHang, ct.CMND, ct.DonGia);
            }

            MessageBox.Show("Tìm thấy " + count + " Phiếu đến thỏa  mãn !", "Tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return;
        }

        private void tbTenKhachDaiDien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimPhieuDen_Click(sender, (EventArgs)e);
            }
        }

        private void tbCMND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimPhieuDen_Click(sender, (EventArgs)e);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDanhSachPhieuDen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbTinhTrangThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblChiTietCuaPhieuDen_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachChiTietPhieuDen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbTenKhachDaiDien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDanhSachPhieuDen_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int MaPhieuDen = int.Parse(dgvDanhSachPhieuDen.SelectedRows[0].Cells[0].Value.ToString());

                // Hiển thị chi tiết phiếu đến đâu tiên tìm được
                int index = 0;
                dgvDanhSachChiTietPhieuDen.Rows.Clear();
                foreach (ChiTietPhieuDen ct in BusChiTietPhieuDen.GetList(MaPhieuDen))
                {
                    lblChiTietCuaPhieuDen.Text = "CHI TIẾT CỦA PHIẾU ĐẾN" + MaPhieuDen;
                    Phong phong = BusPhong.FindMaPhong(ct.MaPhong);
                    dgvDanhSachChiTietPhieuDen.Rows.Add(++index, phong.TenPhong, ct.TenKhachHang, ct.CMND, ct.DonGia);
                }

            }
            catch (Exception ex)
            {
            }
        }
    }
}

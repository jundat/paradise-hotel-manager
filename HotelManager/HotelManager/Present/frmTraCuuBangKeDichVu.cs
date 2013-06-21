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
    public partial class frmTraCuuBangKeDichVu : Form
    {
        public frmTraCuuBangKeDichVu()
        {
            InitializeComponent();
        }

        private void tbTenKhachDaiDien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimBangKe_Click(sender, (EventArgs)e);
            }
        }

        private void btnTimBangKe_Click(object sender, EventArgs e)
        {
            int count = 0;
            dgvDanhSachBangKe.Rows.Clear();
            int MaBangKe = 0;
            foreach (BangKe ct in BusBangKe.Find((BusPhong.FindTheoTenPhong(tbTenPhong.Text)).MaPhong, cbbTinhTrangThanhToan.Text))
            {
                count++;
                MaBangKe = ct.MaBangKe;
                Phong phong = BusPhong.FindMaPhong(ct.MaPhong);
                dgvDanhSachBangKe.Rows.Add(ct.MaBangKe, phong.TenPhong, ct.TongChiPhi);
            }

            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy Bảng kê dịch vụ thỏa  mãn !", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị chi tiết phiếu đến đâu tiên tìm được
            int index = 0;
            dgvDanhSachChiTietBangKe.Rows.Clear();
            foreach (ChiTietBangKe ct in BusChiTietBangKe.GetList(MaBangKe))
            {
                dgvDanhSachChiTietBangKe.Rows.Add(++index, ct.TenDichVu, ct.ThoiDiemGoi, ct.DonGia, ct.SoLuong, ct.GhiChu);
            }

            MessageBox.Show("Tìm thấy " + count + " Bảng kê dịch vụ thỏa  mãn !", "Tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return;
        }

        private void dgvDanhSachBangKe_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int MaBangKe = int.Parse(dgvDanhSachBangKe.SelectedRows[0].Cells[0].Value.ToString());

                // Hiển thị chi tiết phiếu đến đâu tiên tìm được
                int index = 0;
                dgvDanhSachChiTietBangKe.Rows.Clear();
                foreach (ChiTietBangKe ct in BusChiTietBangKe.GetList(MaBangKe))
                {
                    dgvDanhSachChiTietBangKe.Rows.Add(++index, ct.TenDichVu, ct.ThoiDiemGoi, ct.DonGia, ct.SoLuong, ct.GhiChu);
                }

            }
            catch (Exception ex)
            {
            }
        }
    }
}

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
    public partial class frmTraCuuPhieuDatTiec : Form
    {
        public frmTraCuuPhieuDatTiec()
        {
            InitializeComponent();
        }

        private void btnTimPhieuDatTiec_Click(object sender, EventArgs e)
        {
            int count = 0;
            dgvDanhSachPhieuDatTiec.Rows.Clear();
            int MaPhieuDatTiec = 0;
            foreach (PhieuDatTiec ct in BusPhieuDatTiec.Find(tbTenKhach.Text, (BusPhong.FindTheoTenPhong(tbTenPhong.Text)).MaPhong ,cbbTinhTrangThanhToan.Text))
            {
                count++;
                Phong phong = BusPhong.FindMaPhong(ct.MaPhong);
                MaPhieuDatTiec = ct.MaPhieuDatTiec;
                dgvDanhSachPhieuDatTiec.Rows.Add(ct.MaPhieuDatTiec, ct.TenKhach, phong.TenPhong, ct.ThoiDiem, ct.TongTien);
            }

            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy Phiếu đặt tiệc thỏa  mãn !", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị chi tiết phiếu đến đâu tiên tìm được
            int index = 0;
            dgvDanhSachChiTietPhieuDatTiec.Rows.Clear();
            foreach (ChiTietPhieuDatTiec ct in BusChiTietPhieuDatTiec.FindDanhSachChiTietPhieuDatTiec(MaPhieuDatTiec))
            {
                lblChiTietCuaPhieuDatTiec.Text = "CHI TIẾT CỦA PHIẾU ĐẶT TIỆC" + MaPhieuDatTiec;
                dgvDanhSachChiTietPhieuDatTiec.Rows.Add(++index, ct.TenMon, ct.DonGia, ct.SoLuong, ct.YeuCau);
            }

            MessageBox.Show("Tìm thấy " + count + " Phiếu đặt tiệc thỏa  mãn !", "Tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return;
        }

        private void tbTenKhach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimPhieuDatTiec_Click(sender, (EventArgs)e);
            }
        }

        private void tbTenPhong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimPhieuDatTiec_Click(sender, (EventArgs)e);
            }
        }

        private void dgvDanhSachPhieuDatTiec_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int MaPhieuDatTiec = int.Parse(dgvDanhSachPhieuDatTiec.SelectedRows[0].Cells[0].Value.ToString());

                // Hiển thị chi tiết phiếu đến đâu tiên tìm được
                int index = 0;
                dgvDanhSachChiTietPhieuDatTiec.Rows.Clear();
                foreach (ChiTietPhieuDatTiec ct in BusChiTietPhieuDatTiec.FindDanhSachChiTietPhieuDatTiec(MaPhieuDatTiec))
                {
                    lblChiTietCuaPhieuDatTiec.Text = "CHI TIẾT CỦA PHIẾU ĐẶT TIỆC" + MaPhieuDatTiec;
                    dgvDanhSachChiTietPhieuDatTiec.Rows.Add(++index, ct.TenMon, ct.DonGia, ct.SoLuong, ct.YeuCau);
                }

            }
            catch (Exception ex)
            {
            }
        }
    }
}

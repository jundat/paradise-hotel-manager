using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class frmTraCuuPhieuDatCho : Form
    {
        public frmTraCuuPhieuDatCho()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimPhieuDatCho_Click(sender, (EventArgs)e);
            }
        }

        private void tbSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimPhieuDatCho_Click(sender, (EventArgs)e);
            }
        }

        private void tbCMND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimPhieuDatCho_Click(sender, (EventArgs)e);
            }
        }

        private void tbTenNguoiDatCho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimPhieuDatCho_Click(sender, (EventArgs)e);
            }
        }

        private void btnTimPhieuDatCho_Click(object sender, EventArgs e)
        {

            int count = 0;
            dgvDanhSachPhieuDatCho.Rows.Clear();
            int MaPhieuDatCho = 0;
            foreach (PhieuDatCho ct in BusPhieuDatCho.Find(tbTenNguoiDatCho.Text, tbCMND.Text, tbSDT.Text, tbDiaChi.Text))
            {
                count++;
                MaPhieuDatCho = ct.MaPhieuDatCho;
                dgvDanhSachPhieuDatCho.Rows.Add(ct.MaPhieuDatCho, ct.TenNguoiDatCho, ct.CMND, ct.SDT, ct.DiaChi, ct.TongCoc, ct.ThoiDiemDat, ct.ThoiDiemDen, ct.ThoiDiemDi);
            }

            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy Phiếu đặt chỗ thỏa  mãn !", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị chi tiết phiếu đặt chỗ đâu tiên tìm được
            int index = 0;
            dgvDanhSachChiTietPhieuDatCho.Rows.Clear();
            foreach (ChiTietPhieuDatCho ct in BusChiTietPhieuDatCho.FindĐanhSachChiTiet(MaPhieuDatCho))
            {
                lblChiTietCuaPhieuDatCho.Text = "CHI TIẾT CỦA PHIẾU ĐẶT CHỖ " + MaPhieuDatCho;
                Phong phong = BusPhong.FindMaPhong(ct.MaPhong);
                dgvDanhSachChiTietPhieuDatCho.Rows.Add(++index, phong.TenPhong, ct.DonGia, ct.Coc);
            }
            MessageBox.Show("Tìm thấy " + count + " Phiếu đặt chỗ thỏa  mãn !", "Tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return;
        }

        // Cập nhật thông tin các Chi tiết phiếu đặt chỗ theo dong phiếu đặt chõ tìm được
        private void dgvDanhSachPhieuDatCho_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int MaPhieuDatCho = int.Parse(dgvDanhSachPhieuDatCho.SelectedRows[0].Cells[0].Value.ToString());
            
                // Hiển thị chi tiết phiếu đặt chỗ đâu tiên tìm được
                int index = 0;
                foreach (ChiTietPhieuDatCho ct in BusChiTietPhieuDatCho.FindĐanhSachChiTiet(MaPhieuDatCho))
                {
                    lblChiTietCuaPhieuDatCho.Text = "CHI TIẾT CỦA PHIẾU ĐẶT CHỖ " + MaPhieuDatCho;
                    Phong phong = BusPhong.FindMaPhong(ct.MaPhong);
                    dgvDanhSachChiTietPhieuDatCho.Rows.Add(++index, phong.TenPhong, ct.DonGia, ct.Coc);
                }

            }
            catch( Exception ex)
            {
            }
        }
    }
}

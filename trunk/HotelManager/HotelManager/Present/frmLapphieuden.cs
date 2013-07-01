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
    public partial class frmLapphieuden : Form
    {
        int x = 0;
        PhieuDen pden = new PhieuDen();
        public frmLapphieuden()
        {
            InitializeComponent();
        }
        
        private void frmLapphieuden_Load(object sender, EventArgs e)
        {
            dtdanhsachphong.DataSource = BusPhong.layphongchothue(true);
            dataGridView1.DataSource = BusPhieuDen.laydanhsachphieuden();
 
        }

        private void bttimphong_Click(object sender, EventArgs e)
        {
            
            /*else if (dtthoidiemdi.Value.Year == dtthoidiemden.Value.Year && dtthoidiemdi.Value.Month < dtthoidiemden.Value.Month)
                MessageBox.Show("Loi nhap thoi gian2", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (dtthoidiemdi.Value.Year == dtthoidiemden.Value.Year && dtthoidiemdi.Value.Month == dtthoidiemden.Value.Month && dtthoidiemdi.Value.Date < dtthoidiemden.Value.Date)
                MessageBox.Show("Loi nhap thoi gian3", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (dtthoidiemdi.Value.Year == dtthoidiemden.Value.Year && dtthoidiemdi.Value.Month == dtthoidiemden.Value.Month && dtthoidiemdi.Value.Date == dtthoidiemden.Value.Date && dtthoidiemdi.Value.TimeOfDay < dtthoidiemden.Value.TimeOfDay)
                MessageBox.Show("Loi nhap thoi gian4", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            

                if (radiodadatphong.Checked == true)
                    dtdanhsachphongdadat.DataSource = BusPhong.LayDanhSachPhongDaDat(txtnguoidat.Text, txtsdtnguoidat.Text);
                else
                {
                    if (dtthoidiemden.Value < DateTime.Now)
                        MessageBox.Show("Loi nhap thoi gian", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (dtthoidiemdi.Value < dtthoidiemden.Value)
                        MessageBox.Show("Loi nhap thoi gian1", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    dtdanhsachphong.DataSource = BusPhong.Timphongtheothoidiem(dtthoidiemden.Value, dtthoidiemdi.Value);
                }
            
        }

        private void dtdanhsachphongdadat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtdanhsachphongdadat_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtphong.Text = dtdanhsachphongdadat.Rows[e.RowIndex].Cells["clPhong"].Value.ToString();
                txttonggia.Text = dtdanhsachphongdadat.Rows[e.RowIndex].Cells["cldongia"].Value.ToString();
                PhieuDatCho phieudatcho = BusPhieuDatCho.FindSDT(txtsdtnguoidat.Text);
                dtthoidiemden.Value = phieudatcho.ThoiDiemDen;
                dtthoidiemdi.Value = phieudatcho.ThoiDiemDi;
               
            }
            catch (Exception)
            {

            }
        }


        /// <summary>
        /// khi nhan lan 1 thi se tao ra mot phieu den lay ten cua nguoi dau tien lam ten nguoi dai dien
        /// khi nhan lan 2 lan 3 thi se tao ra cac chi tiet phieu dien cho phieu den da tao
        /// khi nhan lan 4 xuat hien thong bao khong co qua 3 khach trong mot phong
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Phong phong = BusPhong.FindTheoTenPhong(txtphong.Text);
            
            if (phong.MaPhong != 0)
            {
                // Xác nhận tình trạng phòng là đã đc thuê 
                BusPhong.ChoKhachNhanPhong(phong.MaPhong);
            }

            x += 1;
            if (x <= BusQuyDinh.GetSoKhachToiDaTrongMotPhong())
            {
                if (x == 1)
                {
                    PhieuDen phieuden = new PhieuDen();
                    phieuden.TenKhachDaiDien = txtkhachhang.Text;
                    phieuden.CMND = txtcmnd.Text;
                    phieuden.ThoiDiemDen = dtthoidiemden.Value;
                    phieuden.ThoiDiemDi = dtthoidiemdi.Value;
                    phieuden.TongChiPhi = float.Parse(txttonggia.Text);
                    phieuden.TinhTrangThanhToan = false;
                    BusPhieuDen.Add(phieuden);
                    pden.MaPhieuDen = phieuden.MaPhieuDen;
                }

                // Tính Tổng giá trị phiếu đến tự động
                ChiTietPhieuDen chitietphieuden = new ChiTietPhieuDen();
                chitietphieuden.MaPhieuDen = pden.MaPhieuDen;
                chitietphieuden.MaPhong = phong.MaPhong;
                chitietphieuden.TenKhachHang = txtkhachhang.Text;
                chitietphieuden.CMND = txtcmnd.Text;
                chitietphieuden.DonGia = float.Parse(txttonggia.Text);
                BusChiTietPhieuDen.Add(chitietphieuden);
            }
            else
            {
                x = 0;
                MessageBox.Show("Khong co qua 3 khach trong mot phong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtkhachhang.Clear();
            txtcmnd.Clear();
            txtdienthoai.Clear();
            txtkhachhang.Focus();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Phong phong = BusPhong.FindTheoTenPhong(txtphong.Text);
            phong.TinhTrangHienTai = false;
            BusPhong.UpdatePhong(phong);
            dataGridView1.DataSource = BusPhieuDen.laydanhsachphieuden();
            x = 0;
            PhieuDatCho phieudatcho = BusPhieuDatCho.FindSDT(txtsdtnguoidat.Text);
            BusChiTietPhieuDatCho.XoaCTPDC(phieudatcho.MaPhieuDatCho);
            BusPhieuDatCho.Delete(phieudatcho.MaPhieuDatCho);

        }

        private void dtdanhsachphong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtphong.Text = dtdanhsachphong.Rows[e.RowIndex].Cells["colPhong"].Value.ToString();
                txttonggia.Text = dtdanhsachphong.Rows[e.RowIndex].Cells["colDonGia"].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtdanhsachphong.DataSource = BusPhong.layphongtrongtheoloaiphong(comboBox1.Text);
        }
        
        private void radiodadatphong_CheckedChanged(object sender, EventArgs e)
        {
            this.rdiochuadatphong.CheckedChanged -= new System.EventHandler(this.rdiochuadatphong_CheckedChanged);
            // Thay đổi do radiodadatphong
            if (radiodadatphong.Checked == true)
            {
                rdiochuadatphong.Checked = false;
                panel2.Enabled = false;
                dtdanhsachphong.Enabled = false;
                dtthoidiemden.Enabled = false;
                dtthoidiemdi.Enabled = false;

                dtdanhsachphongdadat.Enabled = true;
                panel1.Enabled = true;
            }
            else
            {
                rdiochuadatphong.Checked = true;
                panel2.Enabled = true;
                dtdanhsachphong.Enabled = true;
                dtthoidiemden.Enabled = true;
                dtthoidiemdi.Enabled = true;

                dtdanhsachphongdadat.Enabled = false;
                panel1.Enabled = false;
            }

            this.rdiochuadatphong.CheckedChanged += new System.EventHandler(this.rdiochuadatphong_CheckedChanged);
        }

        private void rdiochuadatphong_CheckedChanged(object sender, EventArgs e)
        {
            this.radiodadatphong.CheckedChanged -= new System.EventHandler(this.radiodadatphong_CheckedChanged);
            // Thay đổi do rdiochuadatphong
            if (rdiochuadatphong.Checked == true)
            {
                radiodadatphong.Checked = false;
                panel1.Enabled = false;
                dtdanhsachphongdadat.Enabled = false;
                dtthoidiemden.Enabled = true;
                dtthoidiemdi.Enabled = true;

                dtdanhsachphong.Enabled = true;
                panel2.Enabled = true;
            }
            else
            {
                radiodadatphong.Checked = true;
                panel1.Enabled = true;
                dtdanhsachphongdadat.Enabled = true;
                dtthoidiemden.Enabled = false;
                dtthoidiemdi.Enabled = false;

                dtdanhsachphong.Enabled = false;
                panel2.Enabled = false;
            }
            this.radiodadatphong.CheckedChanged += new System.EventHandler(this.radiodadatphong_CheckedChanged);
        }

        private void txtsdtnguoidat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsdtnguoidat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dtthoidiemden_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

using HotelManager.Data;
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
using HotelManager.Present.Mini;

namespace HotelManager.Present
{
    public partial class frmMain : Form
    {
        public static string TenNhanVien = "Admin";
        public static int MaNhanVien = 0;


        public frmMain()
        {
            InitializeComponent();
        }

        #region Hỗ trợ Giao diện

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.BackColor = Color.FromArgb(100, 20, 20, 0);
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.BackColor = Color.Transparent;
        }

        #endregion Hỗ trợ Giao diện

        /// <summary>
        /// Thêm Phòng
        /// </summary>
        private void linkThemPhong_LinkClicked(object sender, EventArgs e)
        {
         
        }

        /// <summary>
        /// Tra Cứu Phòng
        /// </summary>
        private void linkTraCuuPhong_LinkClicked(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Lập Hoá Đơn
        /// </summary>
        private void linkLapHoaDon_LinkClicked(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Thay Đổi Quy Định
        /// </summary>
        private void linkThayDoiQuyDinh_LinkClicked(object sender, EventArgs e)
        {
            (new frmThayDoiQuyDinh()).Show();
        }

        /// <summary>
        /// Lập Phiếu Thuê Phòng
        /// </summary>
        private void linkLapPhieuThuePhong_LinkClicked(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Lập Báo Cáo Mật Độ
        /// </summary>
        private void linkLapBCMD_LinkClicked(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Thoát bằng link Hệ Thống
        /// </summary>
        private void linkThoat_LinkClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Đóng kết nối khi chương trình kết thúc
        /// </summary>
        private void frmMain_FormClosed(object sender, EventArgs e)
        {
            
        }

        private void linkTraCuuPTP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLapBCMD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkTraCuuPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkThemPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLapPhieuThuePhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new Lap_Phieu_Thu()).Show();
        }

        private void linkLapHoaDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void traCứuLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmDatTiec()).ShowDialog();
        }
        
        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmTheoDoiSuLuuTruCuaKhachHang()).ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void linkYeuCauDichVu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new Phieu_Yeu_Cau_Dich_Vu()).ShowDialog();
        }

        private void lkBaoCaoMatDo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmLapBaoCaoMatDo()).Show();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
//             (new frmDangNhap()).ShowDialog(this);
// 
//             if (TenNhanVien == "" || MaNhanVien == -1)
//             {
//                 this.Close();
//             }
        }

        private void linkDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TenNhanVien = "";
            MaNhanVien = -1;

            (new frmDangNhap()).ShowDialog(this);

            if (TenNhanVien == "" || MaNhanVien == -1)
            {
                this.Close();
            }
        }

        private void llTraCuuPhieuDen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmTraCuuPhieuDen()).ShowDialog();
        }

        private void llTraCuuPhieuDatCho_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmTraCuuPhieuDatCho()).ShowDialog();
        }

        private void itemLapPhieuThu_Click(object sender, EventArgs e)
        {
            linkLapPhieuThuePhong_LinkClicked(null, null);
        }

        private void itemBaoCaoMatDo_Click(object sender, EventArgs e)
        {
            lkBaoCaoMatDo_LinkClicked(null, null);
        }

        private void itemThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            linkThayDoiQuyDinh_LinkClicked(null, null);
        }

        private void picLienHe_Click(object sender, EventArgs e)
        {
            (new frmLienHe()).ShowDialog(this);
        }

        private void picBangGia_Click(object sender, EventArgs e)
        {
            (new frmBangGia()).ShowDialog(this);
        }

        private void picTinhTrangPhong_Click(object sender, EventArgs e)
        {
            (new frmTinhTrangPhong()).Show(this);
        }

        private void picThemPhong_Click(object sender, EventArgs e)
        {
            (new frmThemPhong()).ShowDialog(this);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void llTraCuuBangKeDichVu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmTraCuuBangKeDichVu()).ShowDialog();
        }

        private void llTraCuuPhieuDatTiec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmTraCuuPhieuDatTiec()).ShowDialog();
        }

        private void linkCauHinhThietBi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được hỗ trợ cho bản dùng thử ^_^", "Vui lòng thông cảm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void linkThungRac_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được hỗ trợ cho bản dùng thử ^_^", "Vui lòng thông cảm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void linkPhucHoiDuLieu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được hỗ trợ cho bản dùng thử ^_^", "Vui lòng thông cảm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void linkSaoLuuDuLieu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được hỗ trợ cho bản dùng thử ^_^", "Vui lòng thông cảm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void linkCauHinhPhanMem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được hỗ trợ cho bản dùng thử ^_^", "Vui lòng thông cảm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void linkdatcho_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmDatCho()).ShowDialog();
        }

        private void linklapphieuden_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmLapphieuden()).ShowDialog();
        }

    }
}

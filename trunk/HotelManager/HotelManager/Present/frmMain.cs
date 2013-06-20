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

namespace HotelManager.Present
{
    public partial class frmMain : Form
    {
        public static string TenNhanVien = "Nhan vien 1";
        public static int MaNhanVien = 1;


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

        private void picHome_Click(object sender, EventArgs e)
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

    }
}

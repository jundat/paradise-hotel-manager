using HotelManager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelManager.Present
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Hỗ trợ Giao diện

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.BackColor = Color.FromArgb(80, 0, 0, 0);
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
            (new frmThemPhong()).ShowDialog(this);
        }

        /// <summary>
        /// Tra Cứu Phòng
        /// </summary>
        private void linkTraCuuPhong_LinkClicked(object sender, EventArgs e)
        {
            (new frmTraCuuPhong()).ShowDialog(this);
        }

        /// <summary>
        /// Lập Hoá Đơn
        /// </summary>
        private void linkLapHoaDon_LinkClicked(object sender, EventArgs e)
        {
            (new frmLapHoaDon()).ShowDialog(this);
        }

        /// <summary>
        /// Thay Đổi Quy Định
        /// </summary>
        private void linkThayDoiQuyDinh_LinkClicked(object sender, EventArgs e)
        {
            (new frmThayDoiQuyDinh()).ShowDialog(this);
        }

        /// <summary>
        /// Lập Phiếu Thuê Phòng
        /// </summary>
        private void linkLapPhieuThuePhong_LinkClicked(object sender, EventArgs e)
        {
            (new frmLapPhieuThuePhong()).ShowDialog(this);
        }

        /// <summary>
        /// Lập Báo Cáo Mật Độ
        /// </summary>
        private void linkLapBCMD_LinkClicked(object sender, EventArgs e)
        {
            (new frmBaoCaoMDSD()).ShowDialog(this);
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
            DataProvider.ConnectionData().Close();
        }

        private void linkTraCuuPTP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmTraCuuPhieuThuePhong()).ShowDialog(this);
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            //(new Test()).ShowDialog(this);
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

        }

        private void linkLapHoaDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void traCứuLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}

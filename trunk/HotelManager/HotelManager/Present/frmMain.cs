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
    public partial class frmMain : Form, IDangNhapObserver
    {
        public static NhanVien nv = new NhanVien();

        private frmDangNhap _frmDangNhap;
        
        public frmMain()
        {
            InitializeComponent();
            _frmDangNhap = new frmDangNhap();
            _frmDangNhap.RegisterObserver(this);
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
            _frmDangNhap.ShowDialog(this);

            if (frmMain.nv == null)
            {
                this.Close();
            }
        }

        private void linkDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _frmDangNhap = new frmDangNhap();
            _frmDangNhap.RegisterObserver(this);
            frmMain.nv = null;
            llNhanVien.Text = "Quyền: Tên nhân viên";
            _frmDangNhap.ShowDialog(this);
            if (frmMain.nv == null)
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

        private void itemDangXuat_Click(object sender, EventArgs e)
        {
            linkDangXuat_LinkClicked(null, null);
        }

        private void itemDatCho_Click(object sender, EventArgs e)
        {
            linkdatcho_LinkClicked(null, null);
        }

        private void itemLapPhieuDen_Click(object sender, EventArgs e)
        {
            linklapphieuden_LinkClicked(null, null);
        }

        private void itemYeuCauDichVu_Click(object sender, EventArgs e)
        {
            linkYeuCauDichVu_LinkClicked(null, null);
        }

        private void itemDatTiec_Click(object sender, EventArgs e)
        {
            linkLabel1_LinkClicked(null, null);
        }

        private void itemTraCuuKhachHang_Click(object sender, EventArgs e)
        {
            linkLabel8_LinkClicked(null, null);
        }

        private void itemTraCuuPhieuDen_Click(object sender, EventArgs e)
        {
            llTraCuuPhieuDen_LinkClicked(null, null);
        }

        private void itemTraCuuPhieuDatCho_Click(object sender, EventArgs e)
        {
            llTraCuuPhieuDatCho_LinkClicked(null, null);
        }

        private void itemTraCuuBangKe_Click(object sender, EventArgs e)
        {
            llTraCuuBangKeDichVu_LinkClicked(null, null);
        }

        private void itemTraCuuPhieuDatTiec_Click(object sender, EventArgs e)
        {
            llTraCuuPhieuDatTiec_LinkClicked(null, null);
        }

        // Implement function for interface IDangNhapObserver
        public void RecieveUser(NhanVien nv)
        {
            // thực hiện phân quyền tùy theo giá trị NhanVien và lệnh mà form Đăng nhập truyền cho
            frmMain.nv = nv;
            if (nv != null)
            {
                MessageBox.Show("Tên: " + nv.TenNhanVien + "\nQuyền: " + nv.ChucVu, "Đăng Nhập thành công !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llNhanVien.Text = nv.ChucVu + ": " + nv.TenNhanVien;

                // Hiệu lực|Vô hiệu hóa các chức năng cho phù hợp với quyên hạn của người đăng nhập
                PhanQuyen();
            }
        }

        private void llNhanVien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hiển thị form thay đổi thông tin cá nhân cho nhân viên
            (new frmNhanVien()).ShowDialog(this);
        }

        /// <summary>
        /// Hiệu lực|Vô hiệu hóa các chức năng cho phù hợp với quyên hạn của người đăng nhập
        /// </summary>
        private void PhanQuyen()
        {
            if (frmMain.nv != null)
            {
                if ("Admin".Equals(nv.ChucVu))
                {
                    groupBoxQuanLyChoThuePhong.Enabled = false;
                    groupBoxQuanLyTraPhong.Enabled = false;

                    menuQLThuePhong.Enabled = false;
                    menuQLTraPhong.Enabled = false;

                    pictureBox13.Enabled = true;
                    linkCauHinhThietBi.Enabled = true;

                    pictureBox14.Enabled = true;
                    linkCauHinhThietBi.Enabled = true;

                    pictureBox12.Enabled = true;
                    linkCauHinhPhanMem.Enabled = true;

                    pictureBox11.Enabled = true;
                    linkSaoLuuDuLieu.Enabled = true;

                    pictureBox10.Enabled = true;
                    linkPhucHoiDuLieu.Enabled = true;

                    pictureBox9.Enabled = true;
                    linkThungRac.Enabled = true;

                    pictureBox15.Enabled = true;
                    linkPhanQuyen.Enabled = true;

                    pictureBox8.Enabled = true;
                    linkThayDoiQuyDinh.Enabled = true;
                }
                else // Đăng nhập với quyền tiếp tân - Reception
                {
                    groupBoxQuanLyChoThuePhong.Enabled = true;
                    groupBoxQuanLyTraPhong.Enabled = true;
                    menuQLThuePhong.Enabled = true;
                    menuQLTraPhong.Enabled = true;

                    pictureBox13.Enabled = false;
                    linkCauHinhThietBi.Enabled = false;

                    pictureBox14.Enabled = false;
                    linkCauHinhThietBi.Enabled = false;

                    pictureBox12.Enabled = false;
                    linkCauHinhPhanMem.Enabled = false;

                    pictureBox11.Enabled = false;
                    linkSaoLuuDuLieu.Enabled = false;

                    pictureBox10.Enabled = false;
                    linkPhucHoiDuLieu.Enabled = false;

                    pictureBox9.Enabled = false;
                    linkThungRac.Enabled = false;

                    pictureBox15.Enabled = false;
                    linkPhanQuyen.Enabled = false;

                    pictureBox8.Enabled = false;
                    linkThayDoiQuyDinh.Enabled = false;

                }
            }
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picLienHe_Click(sender, e);
        }

        private void nhàPhátTriểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmNhomPhatTrien()).ShowDialog(this);
        }

        private void linkPhanQuyen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmPhanQuyen()).ShowDialog(this);
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do giao diện phẫn mềm rất thân thiện nên chỉ cần Demo một chút là bạn có thể làm được ^_^", "Hướng dẫn sử dụng !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

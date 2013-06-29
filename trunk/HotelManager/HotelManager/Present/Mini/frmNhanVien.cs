using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HotelManager.Data.Entity;
using HotelManager.Business;

namespace HotelManager.Present.Mini
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();            
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (groupBox1.Visible)
            {
                groupBox1.Visible = false;
                llThuNhoMoRong.Text = "Mở rộng";
                this.Size = new Size(759, 216);
                this.Validate();
            }
            else
            {
                groupBox1.Visible = true;
                llThuNhoMoRong.Text = "Thu nhỏ";
                this.Size = new Size(759, 356);
                this.Validate();
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            tbHoTen.Text = frmMain.nv.TenNhanVien;
            tbTenDangNhap.Text = frmMain.nv.UserName;
            tbDiaChi.Text = frmMain.nv.DiaChi;
            tbSDT.Text = frmMain.nv.SDT;
            tbChucVu.Text = frmMain.nv.ChucVu;
            tbTenDangNhapTD.Text = frmMain.nv.UserName;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (tbMatKhau.Text.Equals(frmMain.nv.Password))
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin cá nhân không ?", "Vui lòng xác nhận lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    frmMain.nv.DiaChi = tbDiaChi.Text;
                    frmMain.nv.SDT = tbSDT.Text;
                    BusNhanVien.UpdateNhanVien(frmMain.nv);
                    frmNhanVien_Load(sender, e);
                    MessageBox.Show("Bạn đã cập nhật thành công thông tin cá nhân !", "Cập nhật thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu sai nên bạn không thể cập nhật thông tin cá nhân !", "Sai Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (tbMatKhauCuTD.Text.Equals(frmMain.nv.Password) == true)
            {
                if (tbMatKhauMoiTD.Text != null)
                {
                    if (tbMatKhauMoiTD.Text.Equals(tbXacNhanLai.Text))
                    {
                        DialogResult rs = MessageBox.Show("Bạn có chắc chắn thay đổi Mật khẩu/Tên đăng nhập không ?", "Vui lòng xác nhận lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            frmMain.nv.Password = tbMatKhauMoiTD.Text;
                            frmMain.nv.UserName = tbTenDangNhapTD.Text;
                            BusNhanVien.UpdateNhanVien(frmMain.nv);
                            MessageBox.Show("Bạn đã cập nhật thành công tên đăng nhập mật khẩu !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            tbMatKhauCuTD.Text = "";
                            tbTenDangNhapTD.Text = "";
                            tbMatKhauMoiTD.Text = "";
                            tbXacNhanLai.Text = "";

                            frmNhanVien_Load(sender, e);
                        }
                    }
                    else // Lỗi nhập sai mật khẩu xác nhận
                    {
                        MessageBox.Show("Lỗi nhập sai mật khẩu xác nhận !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Lỗi để mật khẩu rỗng
                {
                    MessageBox.Show("Lỗi để mật khẩu rỗng !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else // Lỗi nhập sai mật khẩu cũ
            {
                MessageBox.Show("Lỗi nhập sai mật khẩu cũ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbTenDangNhapTD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDoiMatKhau_Click(sender, (EventArgs)e);
            }
        }

        private void tbMatKhauCuTD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDoiMatKhau_Click(sender, (EventArgs)e);
            }
        }

        private void tbMatKhauMoiTD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDoiMatKhau_Click(sender, (EventArgs)e);
            }
        }

        private void tbXacNhanLai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDoiMatKhau_Click(sender, (EventArgs)e);
            }
        }

        private void tbDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCapNhat_Click(sender, (EventArgs)e);
            }
        }

        private void tbSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCapNhat_Click(sender, (EventArgs)e);
            }
        }

        private void tbMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCapNhat_Click(sender, (EventArgs)e);
            }
        }
    }
}

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

namespace HotelManager.Present.Mini
{
    public partial class frmPhanQuyen : Form
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void LoadUserToDataGridView()
        {
            if (dgvNhanVien.Rows.Count > 1)
            {
                dgvNhanVien.Rows.Clear();
            }

            foreach (NhanVien nv in BusNhanVien.GetList())
            {
                dgvNhanVien.Rows.Add(nv.MaNhanVien, nv.TenNhanVien, nv.DiaChi, nv.SDT, nv.ChucVu, nv.UserName, nv.Password);
            }

        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            LoadUserToDataGridView();
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            // Chỉ một dòng của được chọn
            if (dgvNhanVien.SelectedRows.Count == 1)
            {
                // Hiệu lực nút Cập nhật và copy giá trị của dòng đó bỏ vô TextBox tương ứng bên trên
                btnCapNhatTaiKhoan.Enabled = true;
                tbHoTen.Text = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
                tbDiaChi.Text = dgvNhanVien.SelectedRows[0].Cells[2].Value.ToString();
                tbSDT.Text = dgvNhanVien.SelectedRows[0].Cells[3].Value.ToString();
                cbbChucVu.Text = dgvNhanVien.SelectedRows[0].Cells[4].Value.ToString();
                tbTenDangNhap.Text = dgvNhanVien.SelectedRows[0].Cells[5].Value.ToString();
                tbMatKhau.Text = dgvNhanVien.SelectedRows[0].Cells[6].Value.ToString();


                btnXoaTaiKhoan.Enabled = true;

                btnThemTaiKhoanMoi.Enabled = false;
            }
            else
            {
                // Hiệu lực nút Cập nhật và copy giá trị của dòng đó bỏ vô TextBox tương ứng bên trên
                btnCapNhatTaiKhoan.Enabled = false;
                tbHoTen.Text = "";
                tbDiaChi.Text = "";
                tbSDT.Text = "";
                cbbChucVu.Text = "";
                tbTenDangNhap.Text = "";
                tbMatKhau.Text = "";

                btnXoaTaiKhoan.Enabled = false;

                btnThemTaiKhoanMoi.Enabled = true;
            }
        }

        private void btnThemTaiKhoanMoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra nội dung TextBox
            if ("".Equals(tbHoTen.Text) || "".Equals(tbTenDangNhap.Text) || "".Equals(tbDiaChi.Text)
                || "".Equals(tbSDT.Text) || "".Equals(tbTenDangNhap.Text) || "".Equals(tbMatKhau.Text) || "".Equals(cbbChucVu.Text))
            {
                MessageBox.Show("Các ô nhập liệu không được phép rỗng !", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hết lỗi rồi thì làm tiếp
            NhanVien nv = new NhanVien();
            nv.TenNhanVien = tbHoTen.Text;
            nv.DiaChi = tbDiaChi.Text;
            nv.SDT = tbSDT.Text;
            nv.ChucVu = cbbChucVu.Text;
            nv.UserName = tbTenDangNhap.Text;
            nv.Password = tbMatKhau.Text;

            BusNhanVien.Add(nv);

            MessageBox.Show("Bạn vừa thêm thành công " + nv.ChucVu + " : " + nv.TenNhanVien, "THÊM tài khoản thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Nạp lại danh sách các nhân viên vô DataGridView
            LoadUserToDataGridView();

        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            BusNhanVien.Delete(Convert.ToInt32(dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString()));

            String TenNhanVien = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
            String ChucVu = dgvNhanVien.SelectedRows[0].Cells[4].Value.ToString();

            MessageBox.Show("Bạn vừa XÓA thành công cho " + ChucVu + " : " + TenNhanVien, "XÓA tài khoản thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCapNhatTaiKhoan_Click(object sender, EventArgs e)
        {
            // Kiểm tra nội dung TextBox
            if ("".Equals(tbHoTen.Text) || "".Equals(tbTenDangNhap.Text) || "".Equals(tbDiaChi.Text)
                || "".Equals(tbSDT.Text) || "".Equals(tbTenDangNhap.Text) || "".Equals(tbMatKhau.Text) || "".Equals(cbbChucVu.Text))
            {
                MessageBox.Show("Các ô nhập liệu không được phép rỗng !", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hết lỗi rồi thì làm tiếp
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = Convert.ToInt32(dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString());
            nv.TenNhanVien = tbHoTen.Text;
            nv.DiaChi = tbDiaChi.Text;
            nv.SDT = tbSDT.Text;
            nv.ChucVu = cbbChucVu.Text;
            nv.UserName = tbTenDangNhap.Text;
            nv.Password = tbMatKhau.Text;

            BusNhanVien.UpdateNhanVien(nv);

            MessageBox.Show("Bạn vừa Cập nhật thành công nhân viên mã: " + nv.MaNhanVien, "Cập nhật tài khoản thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Nạp lại danh sách các nhân viên vô DataGridView
            LoadUserToDataGridView();
        }
    }
}

using HotelManager.Business;
using HotelManager.Data;
using HotelManager.Data.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelManager.Present
{
    public partial class frmTraCuuPhong : Form
    {
        public frmTraCuuPhong()
        {
            InitializeComponent();
        }

        #region Khởi tạo giao diện

        /// <summary>
        /// Khởi tạo datagridview
        /// </summary>
        private void frmTraCuuPhong_Load(object sender, EventArgs e)
        {
            //cbbMaLoaiPhong & cbbTenLoaiPhong
            ArrayList listLoaiPhong = BusLoaiPhong.GetList();
            foreach (DataLoaiPhong loaiPhong in listLoaiPhong)
            {
                cbbMaLoaiPhong.Items.Add(loaiPhong.MaLoaiPhong);
                cbbTenLoaiPhong.Items.Add(loaiPhong.TenLoaiPhong);
                cbbDonGiaThue.Items.Add(loaiPhong.DonGia);
            }

            //cbbTinhTrangPhong
            cbbTinhTrangPhong.Items.Add(true);
            cbbTinhTrangPhong.Items.Add(false);
        }

        /// <summary>
        /// Đồng bộ dữ liệu cho 3 combobox MaLoaiPhong, TenLoaiPhong và DonGia
        /// </summary>
        private void cbbMaLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox host = (ComboBox)sender;

            cbbTenLoaiPhong.SelectedIndex = host.SelectedIndex;
            cbbMaLoaiPhong.SelectedIndex = host.SelectedIndex;
            cbbDonGiaThue.SelectedIndex = host.SelectedIndex;
        }
        
        #endregion End khởi tạo giao diện

        
        /// <summary>
        /// Tìm Kiếm
        /// </summary>
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvHienThi.DataSource = null;

            int maphong = -1;
            try
            {
                if (txtMaPhong.Text != "")
                {
                    maphong = Int32.Parse(txtMaPhong.Text);
                }
                else
                {
                    maphong = -1;
                }
            }
            catch
            {
                maphong = -1;
            }

            string tenphong = txtTenPhong.Text;
            string ghichu = rtbGhiChu.Text;

            int maloaiphong = -1;
            if (cbbMaLoaiPhong.SelectedIndex != -1)
                maloaiphong = (int)cbbMaLoaiPhong.SelectedItem;

            int tinhtrangphong = -1;
            if (cbbTinhTrangPhong.SelectedIndex != -1)
                if ((bool)cbbTinhTrangPhong.SelectedItem == true)
                    tinhtrangphong = 1;
                else
                    tinhtrangphong = 0;

            DataTable data = BusPhong.Find(maphong, tenphong, maloaiphong, tinhtrangphong, ghichu);

            dgvHienThi.DataSource = data;
        }

        /// <summary>
        /// Xoá phòng
        /// </summary>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = dgvHienThi.SelectedRows.Count;

            foreach (DataGridViewRow row in dgvHienThi.SelectedRows)
            {
                BusPhong.DeletePhong(Int32.Parse(row.Cells[0].Value.ToString()));

                dgvHienThi.Rows.RemoveAt(row.Index);
            }

            if (count > 0)
                MessageBox.Show("Xoá thành công: " + count + " phòng.");
            else
                MessageBox.Show("Chọn các Phòng để xoá.");
        }

        /// <summary>
        /// Cập nhật sửa phòng
        /// </summary>
        private void btnCapNhatSua_Click(object sender, EventArgs e)
        {
            int count = BusPhong.UpdatePhong(dgvHienThi.Rows);

            if (count > 0)
                MessageBox.Show("Cập nhật thành công: " + (count) + " phòng.");
            else
                MessageBox.Show("Không có gì cập nhật.");
        }

        private void frmTraCuuPhong_Shown(object sender, EventArgs e)
        {
            DataTable data = BusPhong.GetTable();
            dgvHienThi.DataSource = data;
        }

        /// <summary>
        /// Kích hoạt tìm kiếm khi nhấn Enter trong các ô nhập
        /// </summary>
        private void rtbGhiChu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(btnTimKiem, null);
            }
        }
    }
}

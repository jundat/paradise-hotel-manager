using HotelManager.Business;
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
    public partial class frmThayDoiQuyDinh : Form
    {
        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Khởi tạo các control
        /// </summary>
        private void frmTDQD_Shown(object sender, EventArgs e)
        {
            //Phụ thu
            DataTable dataPhuThu = BusPhuThu.GetTable();
            if (dataPhuThu != null && dataPhuThu.Rows.Count > 0)
            {
                dgvTyLePhuThu.DataSource = dataPhuThu;
            }

            //Loại khách
            DataTable dataLoaiKhach = BusLoaiKhach.GetTable();
            if (dataLoaiKhach != null && dataLoaiKhach.Rows.Count > 0)
            {
                dgvLoaiKhach.DataSource = dataLoaiKhach;
            }

            //Loại phòng
            DataTable dataLoaiPhong = BusLoaiPhong.GetTable();
            if (dataLoaiPhong != null && dataLoaiPhong.Rows.Count > 0)
            {
                dgvLoaiPhong.DataSource = dataLoaiPhong;
            }

            //Số khách tối đa trong phòng
            txtSoKhachToiDa.Text = "" + BusThamSo.GetSoKhachToiDaTrongPhong();
        }

        /// <summary>
        /// Xử lý button cập nhật
        /// </summary>
        private void bttCapNhat_Click(object sender, EventArgs e)
        {
            //Phụ thu
            DataTable dataPhuThu = (DataTable)dgvTyLePhuThu.DataSource;
            BusPhuThu.UpdateTable(dataPhuThu);

            //Loại khách
            DataTable dataLoaiKhach = (DataTable)dgvLoaiKhach.DataSource;
            BusLoaiKhach.UpdateTable(dataLoaiKhach);

            //Loại phòng
            DataTable dataLoaiPhong = (DataTable)dgvLoaiPhong.DataSource;
            BusLoaiPhong.UpdateTable(dataLoaiPhong);

            //Số khách tối đa trong phòng

            int sk = -1;
            try
            {
                sk = Int32.Parse(txtSoKhachToiDa.Text);
            }
            catch
            {
                sk = -1;
            }

            if (sk != -1)
            {
                BusThamSo.UpdateSoKhachToiDa(sk);
            }
        }
    }
}

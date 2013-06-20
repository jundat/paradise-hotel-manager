using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using HotelManager.Data.Entity;
using HotelManager.Business;
using HotelManager.Business;

namespace HotelManager.Present.Mini
{
    public partial class frmThemPhong : Form
    {
        public frmThemPhong()
        {
            InitializeComponent();

            //load
            FirstLoad();
        }

        public void FirstLoad()
        {
            //Tên Phòng
            DataGridViewTextBoxColumn tbTenPhong = new DataGridViewTextBoxColumn();
            tbTenPhong.HeaderText = "Tên Phòng";
            tbTenPhong.Name = "colTenPhong";
            tbTenPhong.ValueType = typeof(string);
            
            //Loại Phòng
            DataGridViewComboBoxColumn cmbMaLoaiPhong = new DataGridViewComboBoxColumn();
            cmbMaLoaiPhong.HeaderText = "Mã Loại Phòng";
            cmbMaLoaiPhong.Name = "colMaLoaiPhong";
            cmbMaLoaiPhong.ValueType = typeof(int);
            ArrayList listLoaiPhong = BusLoaiPhong.GetList();
            foreach (LoaiPhong loaiPhong in listLoaiPhong)
            {
                cmbMaLoaiPhong.Items.Add(loaiPhong.MaLoaiPhong);
            }
            
            //Ghi chú
            DataGridViewTextBoxColumn tbGhiChu = new DataGridViewTextBoxColumn();
            tbGhiChu.HeaderText = "Ghi chú";
            tbGhiChu.Name = "colGhiChu";
            
            dgvHienThi.Columns.Add(tbTenPhong);
            dgvHienThi.Columns.Add(cmbMaLoaiPhong);
            dgvHienThi.Columns.Add(tbGhiChu);
        }
                
        private void btnUpdatePhong_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)dgvHienThi.DataSource;
            int count = BusPhong.ThemPhong(dgvHienThi.Rows);

            if (count > 0)
                MessageBox.Show("Lưu thành công: " + count + " phòng.");
            else
                MessageBox.Show("Không có dữ liệu mới.");
        }


        private void bttNhapExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel 2003(.xls)|*.xls";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dgvHienThi.Columns.Clear();
                    dgvHienThi.DataSource = BusPhong.LoadExcelFile(dialog.FileName);
                }
                catch (Exception xe)
                {
                    MessageBox.Show(xe.ToString());
                }
            }
        }
    }
}

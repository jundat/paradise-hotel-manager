using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelManager.Data;
using HotelManager.Data.Entity;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using HotelManager.Business;

namespace HotelManager.Present
{
    /// <summary>
    /// Thực hiện nghiệp vụ Lập Danh Mục Phòng
    /// </summary>
    public partial class frmThemPhong : Form
    {
        public frmThemPhong()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Khởi tạo các thuộc tính cho datagridview
        /// </summary>
        public void InitDataGridView()
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

        /// <summary>
        /// Khởi tạo giao diện
        /// </summary>
        private void frmThemPhong_Load(object sender, EventArgs e)
        {
            InitDataGridView();
        }

        /// <summary>
        /// Xử lý nút thêm phòng
        /// </summary>
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            int count = BusPhong.ThemPhong(dgvHienThi.Rows);
            if(count > 0)
                MessageBox.Show("Lưu thành công: " + count + " phòng.");
            else
                MessageBox.Show("Không có dữ liệu mới.");

            //reset datagridview
            try{dgvHienThi.Rows.Clear();}catch { }
        }

        /// <summary>
        /// Nhập file excel
        /// </summary>
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

            btnThemPhong_Click(null, null);
        }
    }
}

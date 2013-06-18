using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelManager.Business;

namespace HotelManager.Present
{
    public partial class frmTraCuuPhieuThuePhong : Form
    {
        public frmTraCuuPhieuThuePhong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTraCuuPhieuThuePhong_Shown(object sender, EventArgs e)
        {
            DataTable data = BusPhieuThuePhong.GetTable();
            dgvHienThi.DataSource = data;
        }
    }
}

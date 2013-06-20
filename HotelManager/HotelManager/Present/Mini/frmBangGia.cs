using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelManager.Business;

namespace HotelManager.Present.Mini
{
    public partial class frmBangGia : Form
    {
        public frmBangGia()
        {
            InitializeComponent();

            //load
            FirstLoad();
        }

        private void FirstLoad()
        {
            dataMain.DataSource = BusLoaiPhong.GetTable();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            BusLoaiPhong.UpdateTable((DataTable)dataMain.DataSource);
        }
    }
}

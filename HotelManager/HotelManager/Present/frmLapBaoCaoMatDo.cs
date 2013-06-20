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
using System.Collections;

namespace HotelManager.Present
{
    public partial class frmLapBaoCaoMatDo : Form
    {
        public frmLapBaoCaoMatDo()
        {
            InitializeComponent();

            //init
            FirstLoad();
        }
        
        private void FirstLoad()
        {
            this.txtThang.Text = "" + DateTime.Now.Month;

            //init data gridview
            //Tên phòng
            DataColumn tbPhong = new DataColumn();
            tbPhong.Caption = "Phong";
            tbPhong.ColumnName = "Phong";
            tbPhong.DataType = typeof(string);

            //Số giờ thuê
            DataColumn tbSoNgayThue = new DataColumn();
            tbSoNgayThue.Caption = "So Gio Thue";
            tbSoNgayThue.ColumnName = "So Gio Thue";
            tbSoNgayThue.DataType = typeof(string);

            //Tỷ lệ
            DataColumn tbTyLe = new DataColumn();
            tbTyLe.Caption = "Ty Le";
            tbTyLe.ColumnName = "Ty Le";
            tbTyLe.DataType = typeof(string);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(tbPhong);
            dataTable.Columns.Add(tbSoNgayThue);
            dataTable.Columns.Add(tbTyLe);

            dataMain.DataSource = dataTable;
        }

        private void btLapBaoCao_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)dataMain.DataSource;
            data.Rows.Clear();
            BusBaoCaoMatDo.getInformation(data);
        }

        private void btInBaoCao_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)dataMain.DataSource;

            if (data != null)
            {
                string title = "\n\tBAO CAO MAT DO SU DUNG PHONG\n"
                    + "\nTHANG: "
                    + "\t" + txtThang.Text;

                Exporter.ToCsV(title, dataMain);
            }
        }
    }
}

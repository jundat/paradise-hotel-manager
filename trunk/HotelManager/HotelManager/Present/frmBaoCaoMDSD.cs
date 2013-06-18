using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelManager.Data.Entity;
using HotelManager.Data;
using System.Xml;
using System.Xml.Xsl;
using System.IO;
using HotelManager.Business;
using RKLib.ExportData;


namespace HotelManager.Present
{
    public partial class frmBaoCaoMDSD : Form
    {
        int thangDuocChon;
        int namDuocChon;

        public frmBaoCaoMDSD()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mặc định vào là báo cáo tháng hiện tại
        /// </summary>
        private void frmBaoCaoMDSD_Load(object sender, EventArgs e)
        {
            thangDuocChon = DateTime.Now.Month;
            namDuocChon = DateTime.Now.Year;

            System.Data.DataTable data = BusPhong.BaoCaoMatDo(thangDuocChon, namDuocChon);

            dtpThangNam.Value = new DateTime(namDuocChon, thangDuocChon, 1);
            
            if (data != null)
            {
                dgvResult.DataSource = (object)data;
            }
        }

        /// <summary>
        /// Lựa chọn tháng và tính toán
        /// </summary>
        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            thangDuocChon = dtpThangNam.Value.Month;
            namDuocChon = dtpThangNam.Value.Year;

            if (namDuocChon > DateTime.Now.Year || (namDuocChon == DateTime.Now.Year && thangDuocChon > DateTime.Now.Month))
            {
                MessageBox.Show("Không thể báo cáo tháng chưa tới!\nTrở về tháng hiện tại.");
                thangDuocChon = DateTime.Now.Month;
                namDuocChon = DateTime.Now.Year;
                dtpThangNam.Value = new DateTime(namDuocChon, thangDuocChon, 1);
            }

            System.Data.DataTable data = BusBCMD.BaoCaoMatDo(thangDuocChon, namDuocChon);

            if (data != null)
            {
                dgvResult.DataSource = (object)data;
            }
        }

        /// <summary>
        /// Lưu báo cáo xuống bộ nhớ
        /// </summary>
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm ThangBaoCao trong bảng BCMD xem đã lưu chưa
            //Nếu rồi thì return

            //Nếu chưa thì lưu
            if (BusBCMD.FindThangBaoCao(thangDuocChon) == null)
            {
                //Lưu ThangBaoCao vào BCMD
                int maBCMD = BusBCMD.Add(thangDuocChon);

                //Lưu ChiTietBCMD vào CHITIETBCMD
                ChiTietBCMD chitiet = new ChiTietBCMD();
                System.Data.DataTable data = (System.Data.DataTable)dgvResult.DataSource;

                foreach (DataRow row in data.Rows)
                {
                    chitiet.MaPhong = (int)row[0];
                    chitiet.SoNgayThue = (int)row[2];
                    chitiet.TyLe = (double)row[3];
                    chitiet.MaBCMD = maBCMD;

                    BusChiTietBCMD.Add(chitiet);
                }

                MessageBox.Show("Lưu thành công!");
            }
            else
            {
                MessageBox.Show("Đã tồn tại, không lưu thêm nữa!");
            }
        }

        /// <summary>
        /// Xuất ra file excel
        /// </summary>
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = (DataTable)dgvResult.DataSource;
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel 2003(.xls)|*.xls|CSV File(*.csv)|*.csv";
                dialog.FileName = "Report-" + thangDuocChon + "-" + namDuocChon;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    string file = dialog.FileName;

                    if(file.EndsWith("xls"))
                        Exporter.ExportToExcel(file, data);
                    else if(file.EndsWith("csv"))
                        Exporter.ExportToExcel(file, data);

                    //MessageBox.Show("Luwu")
                    System.Diagnostics.Process.Start(file);
                }
            }
            catch
            {
                MessageBox.Show("Không thể lưu file.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelManager.Business;
using System.Collections;
using HotelManager.Data.Entity;

namespace HotelManager.Present.Mini
{
    public partial class frmTinhTrangPhong : Form
    {
        Color colorPhongTrong = Color.Cyan;
        Color colorPhongDay = Color.OrangeRed;
        Color forecolorPhongTrong = Color.Black;
        Color forecolorPhongDay = Color.Black;

        public frmTinhTrangPhong()
        {
            InitializeComponent();

            //load
            FirstLoad();
        }

        private void FirstLoad()
        {
            ArrayList listPhong = BusPhong.GetList();
            foreach (Phong p in listPhong)
            {
                Button btn = new Button();
                btn.Text = p.TenPhong;
                btn.Name = "btn" + p.MaPhong;
                btn.Size = new System.Drawing.Size(50, 50);
                btn.FlatStyle = FlatStyle.Flat;
                
                if (p.TinhTrangHienTai == false)
                {
                    btn.BackColor = colorPhongDay;
                    btn.ForeColor = forecolorPhongDay;

                    string loaiPhong = (BusLoaiPhong.Find(p.MaLoaiPhong)).TenLoaiPhong;
                    toolTipBtnPhong.SetToolTip(btn,
                        "\nTình Trạng: Đầy"
                        + "\nLoại Phòng: " + loaiPhong
                        + "\nMã Loại Phòng: " + p.MaLoaiPhong
                        + "\nGhi Chú: " + p.MoTa);
                }
                else
                {
                    btn.BackColor = colorPhongTrong;
                    btn.ForeColor = forecolorPhongTrong;

                    string loaiPhong = (BusLoaiPhong.Find(p.MaLoaiPhong)).TenLoaiPhong;
                    toolTipBtnPhong.SetToolTip(btn,
                        "\nTình Trạng: Trống"
                        + "\nLoại Phòng: " + loaiPhong
                        + "\nMã Loại Phòng: " + p.MaLoaiPhong
                        + "\nGhi Chú: " + p.MoTa);
                }

                pnMain.Controls.Add(btn);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLamTuoi_Click(object sender, EventArgs e)
        {
            this.pnMain.Controls.Clear();
            this.FirstLoad();
        }
    }
}

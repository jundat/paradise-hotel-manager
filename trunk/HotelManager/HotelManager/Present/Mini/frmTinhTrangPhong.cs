using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
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
                btn.Click += this.btnPhong_Click;
                if (p.TinhTrangHienTai == true)
                {
                    btn.BackColor = colorPhongDay;
                    btn.ForeColor = forecolorPhongDay;
                }
                else
                {
                    btn.BackColor = colorPhongTrong;
                    btn.ForeColor = forecolorPhongTrong;
                }

                pnMain.Controls.Add(btn);
            }
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == colorPhongTrong)
            {
                btn.BackColor = colorPhongDay;
                btn.ForeColor = forecolorPhongDay;
            }
            else
            {
                btn.BackColor = colorPhongTrong;
                btn.ForeColor = forecolorPhongTrong;
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

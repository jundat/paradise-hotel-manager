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

namespace HotelManager.Present
{
    public partial class frmThayDoiQuyDinh : Form
    {
        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
            
            //
            this.Load();
        }

        private void Load()
        {
            int soKhachToiDaTrongPhong = BusQuyDinh.GetSoKhachToiDaTrongMotPhong();
            float tyLeTienCoc = BusQuyDinh.GetTyLeCoc();
            int soGioThueVoiGiaGoc = BusQuyDinh.GetSoGioThueVoiGiaGoc();
            float tyLeGiaPhongThueTheoNgay = BusQuyDinh.GetTyLeGiaPhongNeuThueTheoNgay();

            this.txtsluongkhachtoida.Text = "" + soKhachToiDaTrongPhong;
            this.txttyledatcoc.Text = "" + tyLeTienCoc;
            this.txtsogiothuevoigiagoc.Text = "" + soGioThueVoiGiaGoc;
            this.txttylegiaphongneuthuetheongay.Text = "" + tyLeGiaPhongThueTheoNgay;
        }

        private void Update()
        {
            //so khach toi da trong phong
            try
            {
                int sokhach = Int32.Parse(this.txtsluongkhachtoida.Text);
                if (sokhach <= 0)
                {
                    MessageBox.Show("Số khách tối đa trong phòng nhập sai!\n Giá trị phải là số nguyên > 0");
                    return;
                }

                //save
                BusQuyDinh.UpdateSoKhachToiDaTrongMotPhong(sokhach);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Số khách tối đa trong phòng nhập sai!\n Giá trị phải là số nguyên > 0\n" + ex.Message);
                return;
            }

            //ty le tien coc
            try
            {
                float tylecoc = float.Parse(this.txttyledatcoc.Text);
                if (tylecoc < 0.0f || tylecoc > 1.0f)
                {
                    MessageBox.Show("Tỷ lệ tiền cọc nhập sai!\n Giá trị phải là số thực: 0.0 -> 1.0");
                    return;
                }

                //save
                BusQuyDinh.UpdateTyLeCoc(tylecoc);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Tỷ lệ tiền cọc nhập sai!\n Giá trị phải là số thực: 0.0 -> 1.0");
                return;
            }

            //so gio thue voi gia goc
            try
            {
                int sogiothue = int.Parse(this.txtsogiothuevoigiagoc.Text);
                if (sogiothue < 0)
                {
                    MessageBox.Show("Số giờ thuê với giá gốc nhập sai!\n Giá trị phải là số nguyên >= 0");
                    return;
                }

                //save
                BusQuyDinh.UpdateSoGioThueVoiGiaGoc(sogiothue);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Số giờ thuê với giá gốc nhập sai!\n Giá trị phải là số nguyên >= 0");
                return;
            }

            //ty le gia phong neu thue theo ngay
            try
            {
                float tylegiathuengay = float.Parse(this.txttylegiaphongneuthuetheongay.Text);
                if (tylegiathuengay < 0.0f || tylegiathuengay > 1.0f)
                {
                    MessageBox.Show("Tỷ lệ giá phòng nếu thuê theo ngày nhập sai!\n Giá trị phải là số thực: 0.0 -> 1.0");
                    return;
                }

                //save
                BusQuyDinh.UpdateTyLeGiaPhongNeuThueTheoNgay(tylegiathuengay);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Tỷ lệ giá phòng nếu thuê theo ngày nhập sai!\n Giá trị phải là số thực: 0.0 -> 1.0");
                return;
            }

            MessageBox.Show("Lưu thông tin thành công!");
            this.Close();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn lưu các thay đổi không ?", "Vui lòng xác nhận lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Update();
            }
            
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        //Comfortable function
        //

        private void TxtPressEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                this.btluu_Click(null, null);
            }
        }
    }
}

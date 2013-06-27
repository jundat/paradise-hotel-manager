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
using System.Threading;

namespace HotelManager.Present
{
    public partial class frmDangNhap : Form, IDangNhapSubject
    {
        private List<IDangNhapObserver> _DangNhapObservers;
        NhanVien nhanvien;

        public frmDangNhap()
        {
            InitializeComponent();
            _DangNhapObservers = new List<IDangNhapObserver>();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            string user = txtTenDangNhap.Text;
            string pass = txtMatKhau.Text;

            //1- Kiem Tra
            if (user == "")
            {
                this.txtTenDangNhap.Focus();
                errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập trống");
                return;
            }

            if (pass == "")
            {
                this.txtMatKhau.Focus();
                errorProvider1.SetError(txtMatKhau, "Mật khẩu trống");
                return;
            }

            //2- Dang Nhap
            nhanvien = BusNhanVien.FindUserPass(user, pass);
            if (nhanvien == null)
            {
                this.txtTenDangNhap.Focus();
                errorProvider1.SetError(txtTenDangNhap, "Sai tên hoặc mật khẩu");
                errorProvider1.SetError(txtMatKhau, "Sai tên hoặc mật khẩu");
                return;
            }
            else
            {
                ProcessClosing();
            }

        }

        private void ProcessClosing()
        {
            int height = 540;
            while (this.Opacity > 0.0f)
            {
                this.Opacity -= 0.1f;

                height -= 40;
                height = height < 0 ? 0 : height;
                this.Size = new System.Drawing.Size(320, height);
                this.Location = new Point(this.Location.X, this.Location.Y + 20);
                    
                this.Validate();
            }
            this.Close();
        }

        private void txtTenDangNhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btDangNhap_Click(null, null);
            }
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            NotifyDangNhap(nhanvien);
        }

        public void RegisterObserver(IDangNhapObserver o)
        {
            _DangNhapObservers.Add(o);
        }

        public void RemoveObserver(IDangNhapObserver o)
        {
            _DangNhapObservers.Remove(o);
        }

        public void NotifyDangNhap(NhanVien nv)
        {
            foreach (IDangNhapObserver o in _DangNhapObservers)
            {
                o.RecieveUser(nv);
            }
        }

    }
}

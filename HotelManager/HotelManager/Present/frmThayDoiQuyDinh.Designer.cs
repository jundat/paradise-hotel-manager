namespace HotelManager.Present
{
    partial class frmThayDoiQuyDinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btcancel = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.txttylegiaphongneuthuetheongay = new System.Windows.Forms.TextBox();
            this.txtsogiothuevoigiagoc = new System.Windows.Forms.TextBox();
            this.txttyledatcoc = new System.Windows.Forms.TextBox();
            this.txtsluongkhachtoida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btcancel);
            this.panel1.Controls.Add(this.btluu);
            this.panel1.Controls.Add(this.txttylegiaphongneuthuetheongay);
            this.panel1.Controls.Add(this.txtsogiothuevoigiagoc);
            this.panel1.Controls.Add(this.txttyledatcoc);
            this.panel1.Controls.Add(this.txtsluongkhachtoida);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 281);
            this.panel1.TabIndex = 0;
            // 
            // btcancel
            // 
            this.btcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancel.Location = new System.Drawing.Point(402, 237);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(75, 23);
            this.btcancel.TabIndex = 9;
            this.btcancel.Text = "Hủy";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btluu
            // 
            this.btluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Location = new System.Drawing.Point(294, 237);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(75, 23);
            this.btluu.TabIndex = 8;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // txttylegiaphongneuthuetheongay
            // 
            this.txttylegiaphongneuthuetheongay.Location = new System.Drawing.Point(303, 181);
            this.txttylegiaphongneuthuetheongay.Name = "txttylegiaphongneuthuetheongay";
            this.txttylegiaphongneuthuetheongay.Size = new System.Drawing.Size(142, 20);
            this.txttylegiaphongneuthuetheongay.TabIndex = 7;
            this.txttylegiaphongneuthuetheongay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPressEnter);
            // 
            // txtsogiothuevoigiagoc
            // 
            this.txtsogiothuevoigiagoc.Location = new System.Drawing.Point(303, 139);
            this.txtsogiothuevoigiagoc.Name = "txtsogiothuevoigiagoc";
            this.txtsogiothuevoigiagoc.Size = new System.Drawing.Size(142, 20);
            this.txtsogiothuevoigiagoc.TabIndex = 6;
            this.txtsogiothuevoigiagoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPressEnter);
            // 
            // txttyledatcoc
            // 
            this.txttyledatcoc.Location = new System.Drawing.Point(303, 95);
            this.txttyledatcoc.Name = "txttyledatcoc";
            this.txttyledatcoc.Size = new System.Drawing.Size(142, 20);
            this.txttyledatcoc.TabIndex = 5;
            this.txttyledatcoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPressEnter);
            // 
            // txtsluongkhachtoida
            // 
            this.txtsluongkhachtoida.Location = new System.Drawing.Point(303, 56);
            this.txtsluongkhachtoida.Name = "txtsluongkhachtoida";
            this.txtsluongkhachtoida.Size = new System.Drawing.Size(142, 20);
            this.txtsluongkhachtoida.TabIndex = 4;
            this.txtsluongkhachtoida.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPressEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tỷ lệ giá phòng nếu thuê theo ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số giờ thuê với giá gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tỷ lệ tiền đặt cọc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng khách tối đa trong một phòng";
            // 
            // frmThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 281);
            this.Controls.Add(this.panel1);
            this.Name = "frmThayDoiQuyDinh";
            this.Text = "Thay Đổi Quy Định";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.TextBox txttylegiaphongneuthuetheongay;
        private System.Windows.Forms.TextBox txtsogiothuevoigiagoc;
        private System.Windows.Forms.TextBox txttyledatcoc;
        private System.Windows.Forms.TextBox txtsluongkhachtoida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
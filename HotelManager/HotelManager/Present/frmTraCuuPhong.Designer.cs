namespace HotelManager.Present
{
    partial class frmTraCuuPhong
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
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.cbbTinhTrangPhong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbGhiChu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.cbbMaLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbbTenLoaiPhong = new System.Windows.Forms.ComboBox();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.btnCapNhatSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbbDonGiaThue = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhong.Location = new System.Drawing.Point(449, 15);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(157, 31);
            this.txtMaPhong.TabIndex = 1;
            this.txtMaPhong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbGhiChu_KeyUp);
            // 
            // cbbTinhTrangPhong
            // 
            this.cbbTinhTrangPhong.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTinhTrangPhong.FormattingEnabled = true;
            this.cbbTinhTrangPhong.Location = new System.Drawing.Point(747, 15);
            this.cbbTinhTrangPhong.Name = "cbbTinhTrangPhong";
            this.cbbTinhTrangPhong.Size = new System.Drawing.Size(157, 31);
            this.cbbTinhTrangPhong.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(308, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(621, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đã thuê ?";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(754, 418);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(150, 37);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã loại phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ghi chú";
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.BackColor = System.Drawing.SystemColors.Window;
            this.rtbGhiChu.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbGhiChu.Location = new System.Drawing.Point(140, 89);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(764, 31);
            this.rtbGhiChu.TabIndex = 4;
            this.rtbGhiChu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbGhiChu_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(308, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "Tên loại phòng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(8, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tên phòng";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPhong.Location = new System.Drawing.Point(140, 15);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(157, 31);
            this.txtTenPhong.TabIndex = 0;
            this.txtTenPhong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbGhiChu_KeyUp);
            // 
            // cbbMaLoaiPhong
            // 
            this.cbbMaLoaiPhong.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMaLoaiPhong.FormattingEnabled = true;
            this.cbbMaLoaiPhong.Location = new System.Drawing.Point(140, 52);
            this.cbbMaLoaiPhong.Name = "cbbMaLoaiPhong";
            this.cbbMaLoaiPhong.Size = new System.Drawing.Size(157, 31);
            this.cbbMaLoaiPhong.TabIndex = 3;
            this.cbbMaLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbbMaLoaiPhong_SelectedIndexChanged);
            // 
            // cbbTenLoaiPhong
            // 
            this.cbbTenLoaiPhong.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTenLoaiPhong.FormattingEnabled = true;
            this.cbbTenLoaiPhong.Location = new System.Drawing.Point(449, 52);
            this.cbbTenLoaiPhong.Name = "cbbTenLoaiPhong";
            this.cbbTenLoaiPhong.Size = new System.Drawing.Size(157, 31);
            this.cbbTenLoaiPhong.TabIndex = 3;
            this.cbbTenLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbbMaLoaiPhong_SelectedIndexChanged);
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Location = new System.Drawing.Point(12, 126);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(892, 286);
            this.dgvHienThi.TabIndex = 7;
            // 
            // btnCapNhatSua
            // 
            this.btnCapNhatSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCapNhatSua.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhatSua.Location = new System.Drawing.Point(12, 418);
            this.btnCapNhatSua.Name = "btnCapNhatSua";
            this.btnCapNhatSua.Size = new System.Drawing.Size(150, 37);
            this.btnCapNhatSua.TabIndex = 8;
            this.btnCapNhatSua.Text = "Cập nhật sửa";
            this.btnCapNhatSua.UseVisualStyleBackColor = true;
            this.btnCapNhatSua.Click += new System.EventHandler(this.btnCapNhatSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(168, 418);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 37);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbbDonGiaThue
            // 
            this.cbbDonGiaThue.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbDonGiaThue.FormattingEnabled = true;
            this.cbbDonGiaThue.Location = new System.Drawing.Point(747, 52);
            this.cbbDonGiaThue.Name = "cbbDonGiaThue";
            this.cbbDonGiaThue.Size = new System.Drawing.Size(157, 31);
            this.cbbDonGiaThue.TabIndex = 3;
            this.cbbDonGiaThue.SelectedIndexChanged += new System.EventHandler(this.cbbMaLoaiPhong_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(621, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Đơn giá thuê";
            // 
            // frmTraCuuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(916, 461);
            this.Controls.Add(this.cbbDonGiaThue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhatSua);
            this.Controls.Add(this.dgvHienThi);
            this.Controls.Add(this.cbbTenLoaiPhong);
            this.Controls.Add(this.cbbMaLoaiPhong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbGhiChu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTinhTrangPhong);
            this.Controls.Add(this.txtMaPhong);
            this.MinimumSize = new System.Drawing.Size(932, 500);
            this.Name = "frmTraCuuPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tra cứu phòng";
            this.Load += new System.EventHandler(this.frmTraCuuPhong_Load);
            this.Shown += new System.EventHandler(this.frmTraCuuPhong_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.ComboBox cbbTinhTrangPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rtbGhiChu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.ComboBox cbbMaLoaiPhong;
        private System.Windows.Forms.ComboBox cbbTenLoaiPhong;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.Button btnCapNhatSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbbDonGiaThue;
        private System.Windows.Forms.Label label3;
    }
}
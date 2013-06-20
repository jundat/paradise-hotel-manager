namespace HotelManager.Present
{
    partial class frmTheoDoiSuLuuTruCuaKhachHang
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvKetQuaTimKiemKhachHang = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiDiemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiDiemDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhieuDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBangKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhieuDatTiec = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTieuChiTimKiem = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhong = new System.Windows.Forms.TextBox();
            this.btnTimTheoPhong = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbTenKhach = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimTheoThongTinKhach = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimTheoThoiGianLuuTru = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTuThoiDiem = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDenThoiDiem = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiemKhachHang)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.73602F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 435);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 429);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(999, 240);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng tìm được cùng thông tin của họ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvKetQuaTimKiemKhachHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 219);
            this.panel2.TabIndex = 0;
            // 
            // dgvKetQuaTimKiemKhachHang
            // 
            this.dgvKetQuaTimKiemKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQuaTimKiemKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaTimKiemKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colTenKhach,
            this.colCMND,
            this.colTenPhong,
            this.colThoiDiemDen,
            this.colThoiDiemDi,
            this.colPhieuDen,
            this.colBangKe,
            this.colPhieuDatTiec});
            this.dgvKetQuaTimKiemKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetQuaTimKiemKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dgvKetQuaTimKiemKhachHang.Name = "dgvKetQuaTimKiemKhachHang";
            this.dgvKetQuaTimKiemKhachHang.Size = new System.Drawing.Size(993, 219);
            this.dgvKetQuaTimKiemKhachHang.TabIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            // 
            // colTenKhach
            // 
            this.colTenKhach.HeaderText = "Tên";
            this.colTenKhach.Name = "colTenKhach";
            // 
            // colCMND
            // 
            this.colCMND.HeaderText = "CMND";
            this.colCMND.Name = "colCMND";
            // 
            // colTenPhong
            // 
            this.colTenPhong.HeaderText = "Phòng";
            this.colTenPhong.Name = "colTenPhong";
            // 
            // colThoiDiemDen
            // 
            this.colThoiDiemDen.HeaderText = "Thời điểm đến";
            this.colThoiDiemDen.Name = "colThoiDiemDen";
            // 
            // colThoiDiemDi
            // 
            this.colThoiDiemDi.HeaderText = "Thời điểm đi";
            this.colThoiDiemDi.Name = "colThoiDiemDi";
            // 
            // colPhieuDen
            // 
            this.colPhieuDen.HeaderText = "Phiếu đến";
            this.colPhieuDen.Name = "colPhieuDen";
            // 
            // colBangKe
            // 
            this.colBangKe.HeaderText = "Bảng kê";
            this.colBangKe.Name = "colBangKe";
            // 
            // colPhieuDatTiec
            // 
            this.colPhieuDatTiec.HeaderText = "Phiếu đặt tiệc";
            this.colPhieuDatTiec.Name = "colPhieuDatTiec";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(999, 189);
            this.panel3.TabIndex = 14;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lblTieuChiTimKiem);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(673, 105);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 69);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kết quả tìm kiếm hiển thị theo tiêu chí";
            // 
            // lblTieuChiTimKiem
            // 
            this.lblTieuChiTimKiem.AutoSize = true;
            this.lblTieuChiTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuChiTimKiem.ForeColor = System.Drawing.Color.Orange;
            this.lblTieuChiTimKiem.Location = new System.Drawing.Point(19, 33);
            this.lblTieuChiTimKiem.Name = "lblTieuChiTimKiem";
            this.lblTieuChiTimKiem.Size = new System.Drawing.Size(200, 16);
            this.lblTieuChiTimKiem.TabIndex = 20;
            this.lblTieuChiTimKiem.Text = "Thời gian lưu trú của khách !";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbPhong);
            this.groupBox4.Controls.Add(this.btnTimTheoPhong);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(673, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 69);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tra cứu khác đang lưu trú tại Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(19, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tên phòng";
            // 
            // tbPhong
            // 
            this.tbPhong.Location = new System.Drawing.Point(107, 28);
            this.tbPhong.Name = "tbPhong";
            this.tbPhong.Size = new System.Drawing.Size(103, 22);
            this.tbPhong.TabIndex = 19;
            this.tbPhong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPhong_KeyDown);
            // 
            // btnTimTheoPhong
            // 
            this.btnTimTheoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoPhong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimTheoPhong.Location = new System.Drawing.Point(225, 28);
            this.btnTimTheoPhong.Name = "btnTimTheoPhong";
            this.btnTimTheoPhong.Size = new System.Drawing.Size(75, 23);
            this.btnTimTheoPhong.TabIndex = 13;
            this.btnTimTheoPhong.Text = "Tìm Kiếm";
            this.btnTimTheoPhong.UseVisualStyleBackColor = true;
            this.btnTimTheoPhong.Click += new System.EventHandler(this.btnTimTheoPhong_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCMND);
            this.groupBox3.Controls.Add(this.tbTenKhach);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.cbbTinhTrang);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnTimTheoThongTinKhach);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 165);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tra cứu theo Thông tin khách hàng";
            // 
            // tbCMND
            // 
            this.tbCMND.Enabled = false;
            this.tbCMND.Location = new System.Drawing.Point(136, 63);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(168, 22);
            this.tbCMND.TabIndex = 20;
            this.tbCMND.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCMND_KeyDown);
            // 
            // tbTenKhach
            // 
            this.tbTenKhach.Location = new System.Drawing.Point(136, 32);
            this.tbTenKhach.Name = "tbTenKhach";
            this.tbTenKhach.Size = new System.Drawing.Size(168, 22);
            this.tbTenKhach.TabIndex = 19;
            this.tbTenKhach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTenKhach_KeyDown);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Blue;
            this.radioButton2.Location = new System.Drawing.Point(32, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 20);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.Text = "CMND";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Blue;
            this.radioButton1.Location = new System.Drawing.Point(32, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 20);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tên khách";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "Không quan tâm",
            "Đã trả phòng",
            "Đang thuê phòng"});
            this.cbbTinhTrang.Location = new System.Drawing.Point(136, 92);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(168, 24);
            this.cbbTinhTrang.TabIndex = 16;
            this.cbbTinhTrang.Text = "Không quan tâm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(29, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tinh Trạng";
            // 
            // btnTimTheoThongTinKhach
            // 
            this.btnTimTheoThongTinKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoThongTinKhach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimTheoThongTinKhach.Location = new System.Drawing.Point(32, 131);
            this.btnTimTheoThongTinKhach.Name = "btnTimTheoThongTinKhach";
            this.btnTimTheoThongTinKhach.Size = new System.Drawing.Size(75, 23);
            this.btnTimTheoThongTinKhach.TabIndex = 13;
            this.btnTimTheoThongTinKhach.Text = "Tìm Kiếm";
            this.btnTimTheoThongTinKhach.UseVisualStyleBackColor = true;
            this.btnTimTheoThongTinKhach.Click += new System.EventHandler(this.btnTimTheoThongTinKhach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimTheoThoiGianLuuTru);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpTuThoiDiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDenThoiDiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(349, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 165);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Tra cứu theo Thời gian lưu trú";
            // 
            // btnTimTheoThoiGianLuuTru
            // 
            this.btnTimTheoThoiGianLuuTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoThoiGianLuuTru.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimTheoThoiGianLuuTru.Location = new System.Drawing.Point(32, 131);
            this.btnTimTheoThoiGianLuuTru.Name = "btnTimTheoThoiGianLuuTru";
            this.btnTimTheoThoiGianLuuTru.Size = new System.Drawing.Size(75, 23);
            this.btnTimTheoThoiGianLuuTru.TabIndex = 13;
            this.btnTimTheoThoiGianLuuTru.Text = "Tìm Kiếm";
            this.btnTimTheoThoiGianLuuTru.UseVisualStyleBackColor = true;
            this.btnTimTheoThoiGianLuuTru.Click += new System.EventHandler(this.btnTimTheoThoiGianLuuTru_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ thời điểm";
            // 
            // dtpTuThoiDiem
            // 
            this.dtpTuThoiDiem.Location = new System.Drawing.Point(32, 47);
            this.dtpTuThoiDiem.Name = "dtpTuThoiDiem";
            this.dtpTuThoiDiem.Size = new System.Drawing.Size(256, 22);
            this.dtpTuThoiDiem.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến thời điểm";
            // 
            // dtpDenThoiDiem
            // 
            this.dtpDenThoiDiem.Location = new System.Drawing.Point(32, 98);
            this.dtpDenThoiDiem.Name = "dtpDenThoiDiem";
            this.dtpDenThoiDiem.Size = new System.Drawing.Size(256, 22);
            this.dtpDenThoiDiem.TabIndex = 5;
            // 
            // frmTheoDoiSuLuuTruCuaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 435);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmTheoDoiSuLuuTruCuaKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Theo dõi sự lưu trú của khách hàng";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiemKhachHang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvKetQuaTimKiemKhachHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimTheoThoiGianLuuTru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTuThoiDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDenThoiDiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbTenKhach;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTimTheoThongTinKhach;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhong;
        private System.Windows.Forms.Button btnTimTheoPhong;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTieuChiTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiDiemDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiDiemDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhieuDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBangKe;
        private System.Windows.Forms.DataGridViewComboBoxColumn colPhieuDatTiec;


    }
}
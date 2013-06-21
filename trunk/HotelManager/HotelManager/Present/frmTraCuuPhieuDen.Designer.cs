namespace HotelManager.Present
{
    partial class frmTraCuuPhieuDen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuPhieuDen));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhSachPhieuDen = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNguoiDatCho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiDiemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiDiemDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbTinhTrangThanhToan = new System.Windows.Forms.ComboBox();
            this.lblChiTietCuaPhieuDen = new System.Windows.Forms.Label();
            this.dgvDanhSachChiTietPhieuDen = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTenKhachDaiDien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimPhieuDen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuDen)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietPhieuDen)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 383);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 377);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 190);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các Phiếu đến tìm được";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDanhSachPhieuDen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 169);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvDanhSachPhieuDen
            // 
            this.dgvDanhSachPhieuDen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieuDen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuDen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colTenNguoiDatCho,
            this.dataGridViewTextBoxColumn2,
            this.colThoiDiemDen,
            this.colThoiDiemDi,
            this.colTongCoc});
            this.dgvDanhSachPhieuDen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachPhieuDen.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachPhieuDen.Name = "dgvDanhSachPhieuDen";
            this.dgvDanhSachPhieuDen.Size = new System.Drawing.Size(841, 169);
            this.dgvDanhSachPhieuDen.TabIndex = 50;
            this.dgvDanhSachPhieuDen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPhieuDen_CellContentClick);
            this.dgvDanhSachPhieuDen.SelectionChanged += new System.EventHandler(this.dgvDanhSachPhieuDen_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // colTenNguoiDatCho
            // 
            this.colTenNguoiDatCho.HeaderText = "Tên khách đại diện";
            this.colTenNguoiDatCho.Name = "colTenNguoiDatCho";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CMND";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            // colTongCoc
            // 
            this.colTongCoc.HeaderText = "Tổng chi phí";
            this.colTongCoc.Name = "colTongCoc";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbTinhTrangThanhToan);
            this.panel3.Controls.Add(this.lblChiTietCuaPhieuDen);
            this.panel3.Controls.Add(this.dgvDanhSachChiTietPhieuDen);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbCMND);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbTenKhachDaiDien);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnTimPhieuDen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 187);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cbbTinhTrangThanhToan
            // 
            this.cbbTinhTrangThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrangThanhToan.FormattingEnabled = true;
            this.cbbTinhTrangThanhToan.Items.AddRange(new object[] {
            "Không quan tâm",
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbbTinhTrangThanhToan.Location = new System.Drawing.Point(176, 92);
            this.cbbTinhTrangThanhToan.Name = "cbbTinhTrangThanhToan";
            this.cbbTinhTrangThanhToan.Size = new System.Drawing.Size(200, 23);
            this.cbbTinhTrangThanhToan.TabIndex = 51;
            this.cbbTinhTrangThanhToan.Text = "Không quan tâm";
            this.cbbTinhTrangThanhToan.SelectedIndexChanged += new System.EventHandler(this.cbbTinhTrangThanhToan_SelectedIndexChanged);
            // 
            // lblChiTietCuaPhieuDen
            // 
            this.lblChiTietCuaPhieuDen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChiTietCuaPhieuDen.AutoSize = true;
            this.lblChiTietCuaPhieuDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietCuaPhieuDen.ForeColor = System.Drawing.Color.Blue;
            this.lblChiTietCuaPhieuDen.Location = new System.Drawing.Point(524, 12);
            this.lblChiTietCuaPhieuDen.Name = "lblChiTietCuaPhieuDen";
            this.lblChiTietCuaPhieuDen.Size = new System.Drawing.Size(191, 16);
            this.lblChiTietCuaPhieuDen.TabIndex = 50;
            this.lblChiTietCuaPhieuDen.Text = "CHI TIẾT CỦA PHIẾU ĐẾN";
            this.lblChiTietCuaPhieuDen.Click += new System.EventHandler(this.lblChiTietCuaPhieuDen_Click);
            // 
            // dgvDanhSachChiTietPhieuDen
            // 
            this.dgvDanhSachChiTietPhieuDen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachChiTietPhieuDen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachChiTietPhieuDen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChiTietPhieuDen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.clPhong,
            this.clDonGia,
            this.colCoc,
            this.colDonGia});
            this.dgvDanhSachChiTietPhieuDen.Location = new System.Drawing.Point(396, 32);
            this.dgvDanhSachChiTietPhieuDen.Name = "dgvDanhSachChiTietPhieuDen";
            this.dgvDanhSachChiTietPhieuDen.Size = new System.Drawing.Size(448, 149);
            this.dgvDanhSachChiTietPhieuDen.TabIndex = 49;
            this.dgvDanhSachChiTietPhieuDen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachChiTietPhieuDen_CellContentClick);
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            // 
            // clPhong
            // 
            this.clPhong.HeaderText = "Phòng";
            this.clPhong.MinimumWidth = 10;
            this.clPhong.Name = "clPhong";
            // 
            // clDonGia
            // 
            this.clDonGia.HeaderText = "Tên khách";
            this.clDonGia.Name = "clDonGia";
            // 
            // colCoc
            // 
            this.colCoc.HeaderText = "CMND";
            this.colCoc.Name = "colCoc";
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tình trạng thanh toán";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(176, 60);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(200, 20);
            this.tbCMND.TabIndex = 42;
            this.tbCMND.TextChanged += new System.EventHandler(this.tbCMND_TextChanged);
            this.tbCMND.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCMND_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(13, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "CMND";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbTenKhachDaiDien
            // 
            this.tbTenKhachDaiDien.Location = new System.Drawing.Point(176, 31);
            this.tbTenKhachDaiDien.Name = "tbTenKhachDaiDien";
            this.tbTenKhachDaiDien.Size = new System.Drawing.Size(200, 20);
            this.tbTenKhachDaiDien.TabIndex = 38;
            this.tbTenKhachDaiDien.TextChanged += new System.EventHandler(this.tbTenKhachDaiDien_TextChanged);
            this.tbTenKhachDaiDien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTenKhachDaiDien_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tên khách đại diện";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnTimPhieuDen
            // 
            this.btnTimPhieuDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhieuDen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimPhieuDen.Location = new System.Drawing.Point(16, 153);
            this.btnTimPhieuDen.Name = "btnTimPhieuDen";
            this.btnTimPhieuDen.Size = new System.Drawing.Size(109, 23);
            this.btnTimPhieuDen.TabIndex = 32;
            this.btnTimPhieuDen.Text = "Tìm Kiếm";
            this.btnTimPhieuDen.UseVisualStyleBackColor = true;
            this.btnTimPhieuDen.Click += new System.EventHandler(this.btnTimPhieuDen_Click);
            // 
            // frmTraCuuPhieuDen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 383);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraCuuPhieuDen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Phiếu Đến";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuDen)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietPhieuDen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuDen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblChiTietCuaPhieuDen;
        private System.Windows.Forms.DataGridView dgvDanhSachChiTietPhieuDen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTenKhachDaiDien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimPhieuDen;
        private System.Windows.Forms.ComboBox cbbTinhTrangThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNguoiDatCho;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiDiemDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiDiemDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
    }
}
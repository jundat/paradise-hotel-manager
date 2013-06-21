namespace HotelManager.Present
{
    partial class frmTraCuuPhieuDatTiec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuPhieuDatTiec));
            this.cbbTinhTrangThanhToan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTenKhach = new System.Windows.Forms.TextBox();
            this.lblChiTietCuaPhieuDatTiec = new System.Windows.Forms.Label();
            this.dgvDanhSachChiTietPhieuDatTiec = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimPhieuDatTiec = new System.Windows.Forms.Button();
            this.dgvDanhSachPhieuDatTiec = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNguoiDatCho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiDiemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiDiemDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietPhieuDatTiec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuDatTiec)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTinhTrangThanhToan
            // 
            this.cbbTinhTrangThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrangThanhToan.FormattingEnabled = true;
            this.cbbTinhTrangThanhToan.Items.AddRange(new object[] {
            "Không quan tâm",
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbbTinhTrangThanhToan.Location = new System.Drawing.Point(176, 91);
            this.cbbTinhTrangThanhToan.Name = "cbbTinhTrangThanhToan";
            this.cbbTinhTrangThanhToan.Size = new System.Drawing.Size(200, 23);
            this.cbbTinhTrangThanhToan.TabIndex = 51;
            this.cbbTinhTrangThanhToan.Text = "Không quan tâm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tình trạng thanh toán";
            // 
            // tbTenPhong
            // 
            this.tbTenPhong.Location = new System.Drawing.Point(176, 60);
            this.tbTenPhong.Name = "tbTenPhong";
            this.tbTenPhong.Size = new System.Drawing.Size(200, 20);
            this.tbTenPhong.TabIndex = 42;
            this.tbTenPhong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTenPhong_KeyDown);
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
            this.label6.Text = "Phòng";
            // 
            // tbTenKhach
            // 
            this.tbTenKhach.Location = new System.Drawing.Point(176, 31);
            this.tbTenKhach.Name = "tbTenKhach";
            this.tbTenKhach.Size = new System.Drawing.Size(200, 20);
            this.tbTenKhach.TabIndex = 38;
            this.tbTenKhach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTenKhach_KeyDown);
            // 
            // lblChiTietCuaPhieuDatTiec
            // 
            this.lblChiTietCuaPhieuDatTiec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChiTietCuaPhieuDatTiec.AutoSize = true;
            this.lblChiTietCuaPhieuDatTiec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietCuaPhieuDatTiec.ForeColor = System.Drawing.Color.Blue;
            this.lblChiTietCuaPhieuDatTiec.Location = new System.Drawing.Point(393, 13);
            this.lblChiTietCuaPhieuDatTiec.Name = "lblChiTietCuaPhieuDatTiec";
            this.lblChiTietCuaPhieuDatTiec.Size = new System.Drawing.Size(228, 16);
            this.lblChiTietCuaPhieuDatTiec.TabIndex = 50;
            this.lblChiTietCuaPhieuDatTiec.Text = "CHI TIẾT CỦA PHIẾU ĐẶT TIỆC";
            // 
            // dgvDanhSachChiTietPhieuDatTiec
            // 
            this.dgvDanhSachChiTietPhieuDatTiec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachChiTietPhieuDatTiec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachChiTietPhieuDatTiec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChiTietPhieuDatTiec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.clPhong,
            this.clDonGia,
            this.colCoc,
            this.colDonGia});
            this.dgvDanhSachChiTietPhieuDatTiec.Location = new System.Drawing.Point(396, 32);
            this.dgvDanhSachChiTietPhieuDatTiec.Name = "dgvDanhSachChiTietPhieuDatTiec";
            this.dgvDanhSachChiTietPhieuDatTiec.Size = new System.Drawing.Size(423, 149);
            this.dgvDanhSachChiTietPhieuDatTiec.TabIndex = 49;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            // 
            // clPhong
            // 
            this.clPhong.HeaderText = "Tên món";
            this.clPhong.MinimumWidth = 10;
            this.clPhong.Name = "clPhong";
            // 
            // clDonGia
            // 
            this.clDonGia.HeaderText = "Đơn giá";
            this.clDonGia.Name = "clDonGia";
            // 
            // colCoc
            // 
            this.colCoc.HeaderText = "Số lượng";
            this.colCoc.Name = "colCoc";
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Yêu cầu";
            this.colDonGia.Name = "colDonGia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tên khách";
            // 
            // btnTimPhieuDatTiec
            // 
            this.btnTimPhieuDatTiec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhieuDatTiec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimPhieuDatTiec.Location = new System.Drawing.Point(16, 153);
            this.btnTimPhieuDatTiec.Name = "btnTimPhieuDatTiec";
            this.btnTimPhieuDatTiec.Size = new System.Drawing.Size(109, 23);
            this.btnTimPhieuDatTiec.TabIndex = 32;
            this.btnTimPhieuDatTiec.Text = "Tìm Kiếm";
            this.btnTimPhieuDatTiec.UseVisualStyleBackColor = true;
            this.btnTimPhieuDatTiec.Click += new System.EventHandler(this.btnTimPhieuDatTiec_Click);
            // 
            // dgvDanhSachPhieuDatTiec
            // 
            this.dgvDanhSachPhieuDatTiec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieuDatTiec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuDatTiec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colTenNguoiDatCho,
            this.dataGridViewTextBoxColumn2,
            this.colThoiDiemDen,
            this.colThoiDiemDi});
            this.dgvDanhSachPhieuDatTiec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachPhieuDatTiec.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachPhieuDatTiec.Name = "dgvDanhSachPhieuDatTiec";
            this.dgvDanhSachPhieuDatTiec.Size = new System.Drawing.Size(816, 176);
            this.dgvDanhSachPhieuDatTiec.TabIndex = 50;
            this.dgvDanhSachPhieuDatTiec.SelectionChanged += new System.EventHandler(this.dgvDanhSachPhieuDatTiec_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // colTenNguoiDatCho
            // 
            this.colTenNguoiDatCho.HeaderText = "Tên khách";
            this.colTenNguoiDatCho.Name = "colTenNguoiDatCho";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Phòng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // colThoiDiemDen
            // 
            this.colThoiDiemDen.HeaderText = "Thời điểm diễn ra";
            this.colThoiDiemDen.Name = "colThoiDiemDen";
            // 
            // colThoiDiemDi
            // 
            this.colThoiDiemDi.HeaderText = "Tổng tiền";
            this.colThoiDiemDi.Name = "colThoiDiemDi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDanhSachPhieuDatTiec);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 176);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 197);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các Phiếu đặt tiệc tìm được";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 384);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbTinhTrangThanhToan);
            this.panel3.Controls.Add(this.lblChiTietCuaPhieuDatTiec);
            this.panel3.Controls.Add(this.dgvDanhSachChiTietPhieuDatTiec);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbTenPhong);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbTenKhach);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnTimPhieuDatTiec);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 187);
            this.panel3.TabIndex = 13;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 390);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // frmTraCuuPhieuDatTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 390);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraCuuPhieuDatTiec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Phiếu Đặt Tiệc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietPhieuDatTiec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuDatTiec)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTinhTrangThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTenPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTenKhach;
        private System.Windows.Forms.Label lblChiTietCuaPhieuDatTiec;
        private System.Windows.Forms.DataGridView dgvDanhSachChiTietPhieuDatTiec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimPhieuDatTiec;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuDatTiec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNguoiDatCho;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiDiemDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiDiemDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
    }
}
namespace HotelManager.Present
{
    partial class frmTraCuuBangKeDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuBangKeDichVu));
            this.cbbTinhTrangThanhToan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenPhong = new System.Windows.Forms.TextBox();
            this.lblChiTietCuaBangKe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimBangKe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhSachChiTietBangKe = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDanhSachBangKe = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNguoiDatCho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietBangKe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBangKe)).BeginInit();
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
            this.cbbTinhTrangThanhToan.Location = new System.Drawing.Point(176, 64);
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
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tình trạng thanh toán";
            // 
            // tbTenPhong
            // 
            this.tbTenPhong.Location = new System.Drawing.Point(176, 31);
            this.tbTenPhong.Name = "tbTenPhong";
            this.tbTenPhong.Size = new System.Drawing.Size(200, 20);
            this.tbTenPhong.TabIndex = 38;
            this.tbTenPhong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTenKhachDaiDien_KeyDown);
            // 
            // lblChiTietCuaBangKe
            // 
            this.lblChiTietCuaBangKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChiTietCuaBangKe.AutoSize = true;
            this.lblChiTietCuaBangKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietCuaBangKe.ForeColor = System.Drawing.Color.Blue;
            this.lblChiTietCuaBangKe.Location = new System.Drawing.Point(524, 12);
            this.lblChiTietCuaBangKe.Name = "lblChiTietCuaBangKe";
            this.lblChiTietCuaBangKe.Size = new System.Drawing.Size(149, 16);
            this.lblChiTietCuaBangKe.TabIndex = 50;
            this.lblChiTietCuaBangKe.Text = "BẢNG KÊ TÌM ĐƯỢC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tên phòng";
            // 
            // btnTimBangKe
            // 
            this.btnTimBangKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimBangKe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimBangKe.Location = new System.Drawing.Point(16, 149);
            this.btnTimBangKe.Name = "btnTimBangKe";
            this.btnTimBangKe.Size = new System.Drawing.Size(109, 23);
            this.btnTimBangKe.TabIndex = 32;
            this.btnTimBangKe.Text = "Tìm Kiếm";
            this.btnTimBangKe.UseVisualStyleBackColor = true;
            this.btnTimBangKe.Click += new System.EventHandler(this.btnTimBangKe_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDanhSachChiTietBangKe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 185);
            this.panel2.TabIndex = 0;
            // 
            // dgvDanhSachChiTietBangKe
            // 
            this.dgvDanhSachChiTietBangKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachChiTietBangKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChiTietBangKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.clPhong,
            this.clDonGia,
            this.colCoc,
            this.colDonGia,
            this.colGhiChu});
            this.dgvDanhSachChiTietBangKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachChiTietBangKe.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachChiTietBangKe.Name = "dgvDanhSachChiTietBangKe";
            this.dgvDanhSachChiTietBangKe.Size = new System.Drawing.Size(813, 185);
            this.dgvDanhSachChiTietBangKe.TabIndex = 50;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            // 
            // clPhong
            // 
            this.clPhong.HeaderText = "Tên dịch vụ";
            this.clPhong.MinimumWidth = 10;
            this.clPhong.Name = "clPhong";
            // 
            // clDonGia
            // 
            this.clDonGia.HeaderText = "Thời điểm gọi";
            this.clDonGia.Name = "clDonGia";
            // 
            // colCoc
            // 
            this.colCoc.HeaderText = "Đơn giá";
            this.colCoc.Name = "colCoc";
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Số lượng";
            this.colDonGia.Name = "colDonGia";
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.Name = "colGhiChu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(819, 206);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các Dịch vụ mà phòng gọi trong Bảng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 393);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDanhSachBangKe);
            this.panel3.Controls.Add(this.cbbTinhTrangThanhToan);
            this.panel3.Controls.Add(this.lblChiTietCuaBangKe);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbTenPhong);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnTimBangKe);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 187);
            this.panel3.TabIndex = 13;
            // 
            // dgvDanhSachBangKe
            // 
            this.dgvDanhSachBangKe.AllowUserToDeleteRows = false;
            this.dgvDanhSachBangKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachBangKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBangKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBangKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colTenNguoiDatCho,
            this.dataGridViewTextBoxColumn2});
            this.dgvDanhSachBangKe.Location = new System.Drawing.Point(394, 30);
            this.dgvDanhSachBangKe.Name = "dgvDanhSachBangKe";
            this.dgvDanhSachBangKe.Size = new System.Drawing.Size(422, 142);
            this.dgvDanhSachBangKe.TabIndex = 52;
            this.dgvDanhSachBangKe.SelectionChanged += new System.EventHandler(this.dgvDanhSachBangKe_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // colTenNguoiDatCho
            // 
            this.colTenNguoiDatCho.HeaderText = "Phòng";
            this.colTenNguoiDatCho.Name = "colTenNguoiDatCho";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tổng chi phí";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(825, 399);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // frmTraCuuBangKeDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraCuuBangKeDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Bảng Kê Dịch Vụ";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietBangKe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBangKe)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTinhTrangThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTenPhong;
        private System.Windows.Forms.Label lblChiTietCuaBangKe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimBangKe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDanhSachChiTietBangKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.DataGridView dgvDanhSachBangKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNguoiDatCho;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

    }
}
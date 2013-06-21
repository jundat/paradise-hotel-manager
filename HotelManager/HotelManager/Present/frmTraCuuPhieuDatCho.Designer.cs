namespace HotelManager.Present
{
    partial class frmTraCuuPhieuDatCho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuPhieuDatCho));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhSachPhieuDatCho = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNguoiDatCho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiDiemDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiDiemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiDiemDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblChiTietCuaPhieuDatCho = new System.Windows.Forms.Label();
            this.dgvDanhSachChiTietPhieuDatCho = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTenNguoiDatCho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimPhieuDatCho = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuDatCho)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietPhieuDatCho)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 427);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 240);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các Phiếu đặt chỗ tìm được";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDanhSachPhieuDatCho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 219);
            this.panel2.TabIndex = 0;
            // 
            // dgvDanhSachPhieuDatCho
            // 
            this.dgvDanhSachPhieuDatCho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieuDatCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuDatCho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colTenNguoiDatCho,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.colTongCoc,
            this.colThoiDiemDat,
            this.colThoiDiemDen,
            this.colThoiDiemDi});
            this.dgvDanhSachPhieuDatCho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachPhieuDatCho.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachPhieuDatCho.Name = "dgvDanhSachPhieuDatCho";
            this.dgvDanhSachPhieuDatCho.Size = new System.Drawing.Size(841, 219);
            this.dgvDanhSachPhieuDatCho.TabIndex = 50;
            this.dgvDanhSachPhieuDatCho.SelectionChanged += new System.EventHandler(this.dgvDanhSachPhieuDatCho_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // colTenNguoiDatCho
            // 
            this.colTenNguoiDatCho.HeaderText = "Tên người đặt";
            this.colTenNguoiDatCho.Name = "colTenNguoiDatCho";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CMND";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "SĐT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // colTongCoc
            // 
            this.colTongCoc.HeaderText = "Tổng cọc";
            this.colTongCoc.Name = "colTongCoc";
            // 
            // colThoiDiemDat
            // 
            this.colThoiDiemDat.HeaderText = "Thời điểm đặt";
            this.colThoiDiemDat.Name = "colThoiDiemDat";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.lblChiTietCuaPhieuDatCho);
            this.panel3.Controls.Add(this.dgvDanhSachChiTietPhieuDatCho);
            this.panel3.Controls.Add(this.tbDiaChi);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbSDT);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tbCMND);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbTenNguoiDatCho);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnTimPhieuDatCho);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 187);
            this.panel3.TabIndex = 13;
            // 
            // lblChiTietCuaPhieuDatCho
            // 
            this.lblChiTietCuaPhieuDatCho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChiTietCuaPhieuDatCho.AutoSize = true;
            this.lblChiTietCuaPhieuDatCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietCuaPhieuDatCho.ForeColor = System.Drawing.Color.Blue;
            this.lblChiTietCuaPhieuDatCho.Location = new System.Drawing.Point(524, 12);
            this.lblChiTietCuaPhieuDatCho.Name = "lblChiTietCuaPhieuDatCho";
            this.lblChiTietCuaPhieuDatCho.Size = new System.Drawing.Size(226, 16);
            this.lblChiTietCuaPhieuDatCho.TabIndex = 50;
            this.lblChiTietCuaPhieuDatCho.Text = "CHI TIẾT CỦA PHIẾU ĐẶT CHỖ";
            // 
            // dgvDanhSachChiTietPhieuDatCho
            // 
            this.dgvDanhSachChiTietPhieuDatCho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachChiTietPhieuDatCho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachChiTietPhieuDatCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChiTietPhieuDatCho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.clPhong,
            this.clDonGia,
            this.colCoc});
            this.dgvDanhSachChiTietPhieuDatCho.Location = new System.Drawing.Point(382, 32);
            this.dgvDanhSachChiTietPhieuDatCho.Name = "dgvDanhSachChiTietPhieuDatCho";
            this.dgvDanhSachChiTietPhieuDatCho.Size = new System.Drawing.Size(462, 149);
            this.dgvDanhSachChiTietPhieuDatCho.TabIndex = 49;
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
            this.clDonGia.HeaderText = "Đơn Giá";
            this.clDonGia.Name = "clDonGia";
            // 
            // colCoc
            // 
            this.colCoc.HeaderText = "Tiền cọc";
            this.colCoc.Name = "colCoc";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(151, 120);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(200, 20);
            this.tbDiaChi.TabIndex = 46;
            this.tbDiaChi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDiaChi_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Địa chỉ";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(151, 90);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(200, 20);
            this.tbSDT.TabIndex = 44;
            this.tbSDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSDT_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(13, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Số điện thoại";
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(151, 60);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(200, 20);
            this.tbCMND.TabIndex = 42;
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
            // 
            // tbTenNguoiDatCho
            // 
            this.tbTenNguoiDatCho.Location = new System.Drawing.Point(151, 31);
            this.tbTenNguoiDatCho.Name = "tbTenNguoiDatCho";
            this.tbTenNguoiDatCho.Size = new System.Drawing.Size(200, 20);
            this.tbTenNguoiDatCho.TabIndex = 38;
            this.tbTenNguoiDatCho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTenNguoiDatCho_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tên người đặt chỗ";
            // 
            // btnTimPhieuDatCho
            // 
            this.btnTimPhieuDatCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhieuDatCho.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimPhieuDatCho.Location = new System.Drawing.Point(16, 153);
            this.btnTimPhieuDatCho.Name = "btnTimPhieuDatCho";
            this.btnTimPhieuDatCho.Size = new System.Drawing.Size(109, 23);
            this.btnTimPhieuDatCho.TabIndex = 32;
            this.btnTimPhieuDatCho.Text = "Tìm Kiếm";
            this.btnTimPhieuDatCho.UseVisualStyleBackColor = true;
            this.btnTimPhieuDatCho.Click += new System.EventHandler(this.btnTimPhieuDatCho_Click);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 433);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // frmTraCuuPhieuDatCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraCuuPhieuDatCho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Phiếu Đặt Chỗ";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuDatCho)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietPhieuDatCho)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTenNguoiDatCho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimPhieuDatCho;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuDatCho;
        private System.Windows.Forms.Label lblChiTietCuaPhieuDatCho;
        private System.Windows.Forms.DataGridView dgvDanhSachChiTietPhieuDatCho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNguoiDatCho;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiDiemDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiDiemDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiDiemDi;
    }
}
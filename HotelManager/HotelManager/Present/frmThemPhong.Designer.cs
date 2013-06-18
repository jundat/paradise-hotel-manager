namespace HotelManager.Present
{
    partial class frmThemPhong
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
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.bttNhapExcel = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemPhong.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemPhong.Location = new System.Drawing.Point(688, 520);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(150, 37);
            this.btnThemPhong.TabIndex = 6;
            this.btnThemPhong.Text = "Thêm phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Location = new System.Drawing.Point(12, 55);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(826, 459);
            this.dgvHienThi.TabIndex = 7;
            // 
            // bttNhapExcel
            // 
            this.bttNhapExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttNhapExcel.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttNhapExcel.Location = new System.Drawing.Point(12, 520);
            this.bttNhapExcel.Name = "bttNhapExcel";
            this.bttNhapExcel.Size = new System.Drawing.Size(165, 37);
            this.bttNhapExcel.TabIndex = 8;
            this.bttNhapExcel.Text = "Nhập từ file Excel";
            this.bttNhapExcel.UseVisualStyleBackColor = true;
            this.bttNhapExcel.Click += new System.EventHandler(this.bttNhapExcel_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(328, 31);
            this.lbTitle.TabIndex = 9;
            this.lbTitle.Text = "LẬP DANH MỤC PHÒNG";
            // 
            // frmThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(850, 569);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.bttNhapExcel);
            this.Controls.Add(this.dgvHienThi);
            this.Controls.Add(this.btnThemPhong);
            this.MinimumSize = new System.Drawing.Size(746, 386);
            this.Name = "frmThemPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm phòng";
            this.Load += new System.EventHandler(this.frmThemPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.Button bttNhapExcel;
        private System.Windows.Forms.Label lbTitle;
    }
}
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
            this.txtSoKhachToiDa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttCapNhat = new System.Windows.Forms.Button();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLoaiKhach = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTyLePhuThu = new System.Windows.Forms.Label();
            this.dgvTyLePhuThu = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyLePhuThu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoKhachToiDa
            // 
            this.txtSoKhachToiDa.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoKhachToiDa.Location = new System.Drawing.Point(307, 184);
            this.txtSoKhachToiDa.Name = "txtSoKhachToiDa";
            this.txtSoKhachToiDa.Size = new System.Drawing.Size(178, 31);
            this.txtSoKhachToiDa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(1, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số lượng khách tối đa trong phòng";
            // 
            // bttCapNhat
            // 
            this.bttCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttCapNhat.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttCapNhat.Location = new System.Drawing.Point(824, 440);
            this.bttCapNhat.Name = "bttCapNhat";
            this.bttCapNhat.Size = new System.Drawing.Size(150, 37);
            this.bttCapNhat.TabIndex = 4;
            this.bttCapNhat.Text = "Cập nhật";
            this.bttCapNhat.UseVisualStyleBackColor = true;
            this.bttCapNhat.Click += new System.EventHandler(this.bttCapNhat_Click);
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Location = new System.Drawing.Point(495, 252);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.Size = new System.Drawing.Size(480, 181);
            this.dgvLoaiPhong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(491, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số lượng và đơn giá các loại phòng";
            // 
            // dgvLoaiKhach
            // 
            this.dgvLoaiKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiKhach.Location = new System.Drawing.Point(494, 34);
            this.dgvLoaiKhach.Name = "dgvLoaiKhach";
            this.dgvLoaiKhach.Size = new System.Drawing.Size(480, 181);
            this.dgvLoaiKhach.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(491, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số lượng và hệ số các loại khách";
            // 
            // txtTyLePhuThu
            // 
            this.txtTyLePhuThu.AutoSize = true;
            this.txtTyLePhuThu.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTyLePhuThu.Location = new System.Drawing.Point(1, 226);
            this.txtTyLePhuThu.Name = "txtTyLePhuThu";
            this.txtTyLePhuThu.Size = new System.Drawing.Size(121, 23);
            this.txtTyLePhuThu.TabIndex = 22;
            this.txtTyLePhuThu.Text = "Tỷ lệ phụ thu";
            // 
            // dgvTyLePhuThu
            // 
            this.dgvTyLePhuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTyLePhuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTyLePhuThu.Location = new System.Drawing.Point(5, 252);
            this.dgvTyLePhuThu.Name = "dgvTyLePhuThu";
            this.dgvTyLePhuThu.Size = new System.Drawing.Size(480, 181);
            this.dgvTyLePhuThu.TabIndex = 21;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitle.Location = new System.Drawing.Point(10, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(291, 33);
            this.lbTitle.TabIndex = 23;
            this.lbTitle.Text = "THAY ĐỔI QUY ĐỊNH";
            // 
            // frmThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(980, 489);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtTyLePhuThu);
            this.Controls.Add(this.dgvTyLePhuThu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLoaiKhach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLoaiPhong);
            this.Controls.Add(this.bttCapNhat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoKhachToiDa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(746, 429);
            this.Name = "frmThayDoiQuyDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thay đổi quy định";
            this.Shown += new System.EventHandler(this.frmTDQD_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyLePhuThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoKhachToiDa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttCapNhat;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLoaiKhach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTyLePhuThu;
        private System.Windows.Forms.DataGridView dgvTyLePhuThu;
        private System.Windows.Forms.Label lbTitle;
    }
}
namespace HotelManager.Present.Mini
{
    partial class frmTinhTrangPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTinhTrangPhong));
            this.pnMain = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLamTuoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BackColor = System.Drawing.Color.Silver;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMain.Location = new System.Drawing.Point(12, 45);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(620, 484);
            this.pnMain.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(200, 23);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "DANH SÁCH PHÒNG";
            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(527, 535);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(105, 23);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btLamTuoi
            // 
            this.btLamTuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLamTuoi.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLamTuoi.Location = new System.Drawing.Point(16, 535);
            this.btLamTuoi.Name = "btLamTuoi";
            this.btLamTuoi.Size = new System.Drawing.Size(105, 23);
            this.btLamTuoi.TabIndex = 4;
            this.btLamTuoi.Text = "Làm tươi";
            this.btLamTuoi.UseVisualStyleBackColor = true;
            this.btLamTuoi.Click += new System.EventHandler(this.btLamTuoi_Click);
            // 
            // frmTinhTrangPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 570);
            this.Controls.Add(this.btLamTuoi);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(270, 384);
            this.Name = "frmTinhTrangPhong";
            this.Text = "Tình Trạng Phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnMain;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btLamTuoi;

    }
}
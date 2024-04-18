namespace DAL_QuanLyBK
{
    partial class DanhSachCT_HDN
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
            System.Windows.Forms.Label ngayXuatHDNLabel;
            System.Windows.Forms.Label tenNVNhapHangLabel;
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label maHDNLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTongTienNhap = new System.Windows.Forms.TextBox();
            this.dtNgayXuatHD = new System.Windows.Forms.DateTimePicker();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            ngayXuatHDNLabel = new System.Windows.Forms.Label();
            tenNVNhapHangLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            maHDNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ngayXuatHDNLabel
            // 
            ngayXuatHDNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            ngayXuatHDNLabel.AutoSize = true;
            ngayXuatHDNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            ngayXuatHDNLabel.Location = new System.Drawing.Point(488, 108);
            ngayXuatHDNLabel.Name = "ngayXuatHDNLabel";
            ngayXuatHDNLabel.Size = new System.Drawing.Size(81, 22);
            ngayXuatHDNLabel.TabIndex = 20;
            ngayXuatHDNLabel.Text = "Ngày lập";
            // 
            // tenNVNhapHangLabel
            // 
            tenNVNhapHangLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tenNVNhapHangLabel.AutoSize = true;
            tenNVNhapHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenNVNhapHangLabel.Location = new System.Drawing.Point(488, 45);
            tenNVNhapHangLabel.Name = "tenNVNhapHangLabel";
            tenNVNhapHangLabel.Size = new System.Drawing.Size(131, 22);
            tenNVNhapHangLabel.TabIndex = 19;
            tenNVNhapHangLabel.Text = "Tổng tiền nhập";
            // 
            // maNVLabel
            // 
            maNVLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            maNVLabel.AutoSize = true;
            maNVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maNVLabel.Location = new System.Drawing.Point(32, 107);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(117, 22);
            maNVLabel.TabIndex = 18;
            maNVLabel.Text = "Mã nhân viên";
            // 
            // maHDNLabel
            // 
            maHDNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            maHDNLabel.AutoSize = true;
            maHDNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maHDNLabel.Location = new System.Drawing.Point(32, 45);
            maHDNLabel.Name = "maHDNLabel";
            maHDNLabel.Size = new System.Drawing.Size(149, 22);
            maHDNLabel.TabIndex = 17;
            maHDNLabel.Text = "Mã hóa đơn nhập";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(875, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtTongTienNhap);
            this.groupBox1.Controls.Add(ngayXuatHDNLabel);
            this.groupBox1.Controls.Add(this.dtNgayXuatHD);
            this.groupBox1.Controls.Add(tenNVNhapHangLabel);
            this.groupBox1.Controls.Add(maNVLabel);
            this.groupBox1.Controls.Add(maHDNLabel);
            this.groupBox1.Controls.Add(this.txtMaHDN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 152);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(205, 106);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(196, 30);
            this.txtMaNV.TabIndex = 34;
            // 
            // txtTongTienNhap
            // 
            this.txtTongTienNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTienNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTienNhap.Location = new System.Drawing.Point(648, 45);
            this.txtTongTienNhap.Name = "txtTongTienNhap";
            this.txtTongTienNhap.ReadOnly = true;
            this.txtTongTienNhap.Size = new System.Drawing.Size(221, 30);
            this.txtTongTienNhap.TabIndex = 31;
            // 
            // dtNgayXuatHD
            // 
            this.dtNgayXuatHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNgayXuatHD.Enabled = false;
            this.dtNgayXuatHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNgayXuatHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayXuatHD.Location = new System.Drawing.Point(648, 106);
            this.dtNgayXuatHD.Name = "dtNgayXuatHD";
            this.dtNgayXuatHD.Size = new System.Drawing.Size(221, 30);
            this.dtNgayXuatHD.TabIndex = 21;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHDN.Location = new System.Drawing.Point(205, 45);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.ReadOnly = true;
            this.txtMaHDN.Size = new System.Drawing.Size(196, 30);
            this.txtMaHDN.TabIndex = 18;
            // 
            // DanhSachCT_HDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(899, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DanhSachCT_HDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DanhSachCT_HDN";
            this.Load += new System.EventHandler(this.DanhSachCT_HDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTongTienNhap;
        private System.Windows.Forms.DateTimePicker dtNgayXuatHD;
        private System.Windows.Forms.TextBox txtMaHDN;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTongTienNhap = new System.Windows.Forms.TextBox();
            this.dtNgayXuatHD = new System.Windows.Forms.DateTimePicker();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvct_hdn = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnXN = new Guna.UI2.WinForms.Guna2GradientButton();
            ngayXuatHDNLabel = new System.Windows.Forms.Label();
            tenNVNhapHangLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            maHDNLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvct_hdn)).BeginInit();
            this.SuspendLayout();
            // 
            // ngayXuatHDNLabel
            // 
            ngayXuatHDNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            ngayXuatHDNLabel.AutoSize = true;
            ngayXuatHDNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            ngayXuatHDNLabel.Location = new System.Drawing.Point(668, 108);
            ngayXuatHDNLabel.Name = "ngayXuatHDNLabel";
            ngayXuatHDNLabel.Size = new System.Drawing.Size(108, 29);
            ngayXuatHDNLabel.TabIndex = 20;
            ngayXuatHDNLabel.Text = "Ngày lập";
            // 
            // tenNVNhapHangLabel
            // 
            tenNVNhapHangLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tenNVNhapHangLabel.AutoSize = true;
            tenNVNhapHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenNVNhapHangLabel.Location = new System.Drawing.Point(668, 45);
            tenNVNhapHangLabel.Name = "tenNVNhapHangLabel";
            tenNVNhapHangLabel.Size = new System.Drawing.Size(174, 29);
            tenNVNhapHangLabel.TabIndex = 19;
            tenNVNhapHangLabel.Text = "Tổng tiền nhập";
            // 
            // maNVLabel
            // 
            maNVLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            maNVLabel.AutoSize = true;
            maNVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maNVLabel.Location = new System.Drawing.Point(32, 107);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(154, 29);
            maNVLabel.TabIndex = 18;
            maNVLabel.Text = "Mã nhân viên";
            // 
            // maHDNLabel
            // 
            maHDNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            maHDNLabel.AutoSize = true;
            maHDNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maHDNLabel.Location = new System.Drawing.Point(32, 45);
            maHDNLabel.Name = "maHDNLabel";
            maHDNLabel.Size = new System.Drawing.Size(198, 29);
            maHDNLabel.TabIndex = 17;
            maHDNLabel.Text = "Mã hóa đơn nhập";
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
            this.groupBox1.Size = new System.Drawing.Size(1081, 152);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(260, 106);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(196, 30);
            this.txtMaNV.TabIndex = 34;
            // 
            // txtTongTienNhap
            // 
            this.txtTongTienNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTienNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTienNhap.Location = new System.Drawing.Point(854, 45);
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
            this.dtNgayXuatHD.Location = new System.Drawing.Point(854, 106);
            this.dtNgayXuatHD.Name = "dtNgayXuatHD";
            this.dtNgayXuatHD.Size = new System.Drawing.Size(221, 30);
            this.dtNgayXuatHD.TabIndex = 21;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHDN.Location = new System.Drawing.Point(260, 45);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.ReadOnly = true;
            this.txtMaHDN.Size = new System.Drawing.Size(196, 30);
            this.txtMaHDN.TabIndex = 18;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.dgvct_hdn);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(10, 170);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1086, 333);
            this.guna2GroupBox1.TabIndex = 68;
            this.guna2GroupBox1.Text = "Danh sách hóa đơn";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvct_hdn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvct_hdn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvct_hdn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvct_hdn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvct_hdn.ColumnHeadersHeight = 25;
            this.dgvct_hdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvct_hdn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvct_hdn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvct_hdn.Location = new System.Drawing.Point(0, 43);
            this.dgvct_hdn.Name = "dgvct_hdn";
            this.dgvct_hdn.RowHeadersVisible = false;
            this.dgvct_hdn.RowHeadersWidth = 51;
            this.dgvct_hdn.RowTemplate.Height = 24;
            this.dgvct_hdn.Size = new System.Drawing.Size(1083, 271);
            this.dgvct_hdn.TabIndex = 0;
            this.dgvct_hdn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvct_hdn.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvct_hdn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvct_hdn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvct_hdn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvct_hdn.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvct_hdn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvct_hdn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvct_hdn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvct_hdn.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvct_hdn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvct_hdn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvct_hdn.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvct_hdn.ThemeStyle.ReadOnly = false;
            this.dgvct_hdn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvct_hdn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvct_hdn.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvct_hdn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvct_hdn.ThemeStyle.RowsStyle.Height = 24;
            this.dgvct_hdn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvct_hdn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvct_hdn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvct_hdn_CellClick);
            this.dgvct_hdn.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvct_hdn_RowsRemoved);
            this.dgvct_hdn.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvct_hdn_UserDeletedRow);
            // 
            // btnXN
            // 
            this.btnXN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXN.BackColor = System.Drawing.Color.Transparent;
            this.btnXN.BorderRadius = 20;
            this.btnXN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXN.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnXN.FillColor2 = System.Drawing.Color.Gray;
            this.btnXN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXN.ForeColor = System.Drawing.Color.Black;
            this.btnXN.ImageSize = new System.Drawing.Size(40, 40);
            this.btnXN.Location = new System.Drawing.Point(478, 520);
            this.btnXN.Name = "btnXN";
            this.btnXN.PressedColor = System.Drawing.Color.Gainsboro;
            this.btnXN.ShadowDecoration.BorderRadius = 20;
            this.btnXN.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.btnXN.ShadowDecoration.Depth = 100;
            this.btnXN.ShadowDecoration.Enabled = true;
            this.btnXN.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.btnXN.Size = new System.Drawing.Size(216, 53);
            this.btnXN.TabIndex = 69;
            this.btnXN.Text = "Xác nhận";
            this.btnXN.Visible = false;
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // DanhSachCT_HDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1108, 595);
            this.Controls.Add(this.btnXN);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DanhSachCT_HDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DanhSachCT_HDN";
            this.Load += new System.EventHandler(this.DanhSachCT_HDN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvct_hdn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTongTienNhap;
        private System.Windows.Forms.DateTimePicker dtNgayXuatHD;
        private System.Windows.Forms.TextBox txtMaHDN;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvct_hdn;
        private Guna.UI2.WinForms.Guna2GradientButton btnXN;
    }
}
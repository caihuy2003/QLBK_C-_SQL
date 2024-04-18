namespace QuanLyBangKeo
{
    partial class HoaDonBan
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
            System.Windows.Forms.Label tenNVNhapHangLabel;
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonBan));
            this.cbFind = new System.Windows.Forms.ComboBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSee = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.dgvhdb = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            tenNVNhapHangLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhdb)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tenNVNhapHangLabel
            // 
            tenNVNhapHangLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            tenNVNhapHangLabel.AutoSize = true;
            tenNVNhapHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenNVNhapHangLabel.Location = new System.Drawing.Point(155, 165);
            tenNVNhapHangLabel.Name = "tenNVNhapHangLabel";
            tenNVNhapHangLabel.Size = new System.Drawing.Size(125, 22);
            tenNVNhapHangLabel.TabIndex = 71;
            tenNVNhapHangLabel.Text = "Tên nhân viên";
            // 
            // maNVLabel
            // 
            maNVLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            maNVLabel.AutoSize = true;
            maNVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maNVLabel.Location = new System.Drawing.Point(162, 109);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(117, 22);
            maNVLabel.TabIndex = 70;
            maNVLabel.Text = "Mã nhân viên";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label3.Location = new System.Drawing.Point(624, 165);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(140, 22);
            label3.TabIndex = 75;
            label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label4.Location = new System.Drawing.Point(631, 109);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(137, 22);
            label4.TabIndex = 74;
            label4.Text = "Mã khách hàng ";
            // 
            // cbFind
            // 
            this.cbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbFind.FormattingEnabled = true;
            this.cbFind.Items.AddRange(new object[] {
            "Mã hóa đơn",
            "Mã nhân viên",
            "Mã khách hàng"});
            this.cbFind.Location = new System.Drawing.Point(266, 10);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(179, 33);
            this.cbFind.TabIndex = 2;
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFind.Location = new System.Drawing.Point(686, 6);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(299, 37);
            this.txtFind.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(481, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.CausesValidation = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(108, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(250, 64);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Tạo hóa đơn mới";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(651, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(217, 64);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Xóa hóa đơn";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSee
            // 
            this.btnSee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSee.BackColor = System.Drawing.Color.White;
            this.btnSee.CausesValidation = false;
            this.btnSee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSee.Location = new System.Drawing.Point(392, 14);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(223, 64);
            this.btnSee.TabIndex = 31;
            this.btnSee.Text = "Xem chi tiết hóa đơn";
            this.btnSee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSee.UseVisualStyleBackColor = false;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(1013, 6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(125, 37);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(890, 14);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(148, 64);
            this.btnExcel.TabIndex = 36;
            this.btnExcel.Text = "Xuất";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cbMaKH);
            this.panel2.Controls.Add(this.txtTenKH);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.cbMaNV);
            this.panel2.Controls.Add(this.txtTenNV);
            this.panel2.Controls.Add(tenNVNhapHangLabel);
            this.panel2.Controls.Add(maNVLabel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSee);
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Location = new System.Drawing.Point(18, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1195, 214);
            this.panel2.TabIndex = 65;
            // 
            // cbMaKH
            // 
            this.cbMaKH.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Items.AddRange(new object[] {
            "NV001",
            "NV002",
            "NV003",
            "NV004",
            "NV005",
            "NV006",
            "NV007 ",
            "NV008",
            "NV009",
            "NV010"});
            this.cbMaKH.Location = new System.Drawing.Point(771, 104);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(220, 33);
            this.cbMaKH.TabIndex = 76;
            this.cbMaKH.SelectedIndexChanged += new System.EventHandler(this.cbMaKH_SelectedIndexChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKH.Location = new System.Drawing.Point(771, 157);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(220, 30);
            this.txtTenKH.TabIndex = 77;
            // 
            // cbMaNV
            // 
            this.cbMaNV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Items.AddRange(new object[] {
            "NV001",
            "NV002",
            "NV003",
            "NV004",
            "NV005",
            "NV006",
            "NV007 ",
            "NV008",
            "NV009",
            "NV010"});
            this.cbMaNV.Location = new System.Drawing.Point(302, 104);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(220, 33);
            this.cbMaNV.TabIndex = 72;
            this.cbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbMaNV_SelectedIndexChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNV.Location = new System.Drawing.Point(302, 157);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(220, 30);
            this.txtTenNV.TabIndex = 73;
            // 
            // dgvhdb
            // 
            this.dgvhdb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvhdb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhdb.Location = new System.Drawing.Point(6, 36);
            this.dgvhdb.Name = "dgvhdb";
            this.dgvhdb.RowHeadersWidth = 51;
            this.dgvhdb.RowTemplate.Height = 24;
            this.dgvhdb.Size = new System.Drawing.Size(1195, 293);
            this.dgvhdb.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvhdb);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1207, 335);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hóa đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.cbFind);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 52);
            this.panel1.TabIndex = 63;
            // 
            // HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1231, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Name = "HoaDonBan";
            this.Text = "HoaDonBan";
            this.Load += new System.EventHandler(this.HoaDonBan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhdb)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvhdb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
    }
}
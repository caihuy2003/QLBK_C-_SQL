namespace QuanLyBangKeo
{
    partial class ChiTietHDN
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nCCNhapHangLabel;
            System.Windows.Forms.Label ngayXuatHDNLabel;
            System.Windows.Forms.Label tenNVNhapHangLabel;
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label maHDNLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label linhKienLabel;
            System.Windows.Forms.Label donGiaLinhKienLabel;
            System.Windows.Forms.Label soLuongLinhKienLabel;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label t;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietHDN));
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.cbMaNCC = new System.Windows.Forms.ComboBox();
            this.dtNgayXuatHD = new System.Windows.Forms.DateTimePicker();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.dgvCT_HDN = new System.Windows.Forms.DataGridView();
            this.maHDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QuanLyBangKeo.DataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txttongthanhtoan = new System.Windows.Forms.TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cbMaSP = new System.Windows.Forms.ComboBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDGNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chiTietNhap1TableAdapter = new QuanLyBangKeo.DataSet1TableAdapters.ChiTietNhap1TableAdapter();
            nCCNhapHangLabel = new System.Windows.Forms.Label();
            ngayXuatHDNLabel = new System.Windows.Forms.Label();
            tenNVNhapHangLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            maHDNLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            linhKienLabel = new System.Windows.Forms.Label();
            donGiaLinhKienLabel = new System.Windows.Forms.Label();
            soLuongLinhKienLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            t = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_HDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nCCNhapHangLabel
            // 
            nCCNhapHangLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            nCCNhapHangLabel.AutoSize = true;
            nCCNhapHangLabel.BackColor = System.Drawing.Color.Transparent;
            nCCNhapHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nCCNhapHangLabel.Location = new System.Drawing.Point(22, 301);
            nCCNhapHangLabel.Name = "nCCNhapHangLabel";
            nCCNhapHangLabel.Size = new System.Drawing.Size(121, 22);
            nCCNhapHangLabel.TabIndex = 21;
            nCCNhapHangLabel.Text = "Nhà cung cấp";
            // 
            // ngayXuatHDNLabel
            // 
            ngayXuatHDNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            ngayXuatHDNLabel.AutoSize = true;
            ngayXuatHDNLabel.BackColor = System.Drawing.Color.Transparent;
            ngayXuatHDNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            ngayXuatHDNLabel.Location = new System.Drawing.Point(22, 246);
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
            tenNVNhapHangLabel.BackColor = System.Drawing.Color.Transparent;
            tenNVNhapHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenNVNhapHangLabel.Location = new System.Drawing.Point(22, 183);
            tenNVNhapHangLabel.Name = "tenNVNhapHangLabel";
            tenNVNhapHangLabel.Size = new System.Drawing.Size(125, 22);
            tenNVNhapHangLabel.TabIndex = 19;
            tenNVNhapHangLabel.Text = "Tên nhân viên";
            // 
            // maNVLabel
            // 
            maNVLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            maNVLabel.AutoSize = true;
            maNVLabel.BackColor = System.Drawing.Color.Transparent;
            maNVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maNVLabel.Location = new System.Drawing.Point(22, 123);
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
            maHDNLabel.BackColor = System.Drawing.Color.Transparent;
            maHDNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maHDNLabel.Location = new System.Drawing.Point(22, 61);
            maHDNLabel.Name = "maHDNLabel";
            maHDNLabel.Size = new System.Drawing.Size(149, 22);
            maHDNLabel.TabIndex = 17;
            maHDNLabel.Text = "Mã hóa đơn nhập";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label4.Location = new System.Drawing.Point(7, 111);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(155, 25);
            label4.TabIndex = 9;
            label4.Text = "Tổng thanh toán";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label3.Location = new System.Drawing.Point(22, 364);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 22);
            label3.TabIndex = 32;
            label3.Text = "Tên nhà cung cấp";
            // 
            // linhKienLabel
            // 
            linhKienLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            linhKienLabel.AutoSize = true;
            linhKienLabel.BackColor = System.Drawing.Color.Transparent;
            linhKienLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            linhKienLabel.Location = new System.Drawing.Point(23, 121);
            linhKienLabel.Name = "linhKienLabel";
            linhKienLabel.Size = new System.Drawing.Size(102, 25);
            linhKienLabel.TabIndex = 13;
            linhKienLabel.Text = "Sản phẩm";
            // 
            // donGiaLinhKienLabel
            // 
            donGiaLinhKienLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            donGiaLinhKienLabel.AutoSize = true;
            donGiaLinhKienLabel.BackColor = System.Drawing.Color.Transparent;
            donGiaLinhKienLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            donGiaLinhKienLabel.Location = new System.Drawing.Point(23, 176);
            donGiaLinhKienLabel.Name = "donGiaLinhKienLabel";
            donGiaLinhKienLabel.Size = new System.Drawing.Size(79, 25);
            donGiaLinhKienLabel.TabIndex = 15;
            donGiaLinhKienLabel.Text = "Đơn giá";
            // 
            // soLuongLinhKienLabel
            // 
            soLuongLinhKienLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            soLuongLinhKienLabel.AutoSize = true;
            soLuongLinhKienLabel.BackColor = System.Drawing.Color.Transparent;
            soLuongLinhKienLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            soLuongLinhKienLabel.Location = new System.Drawing.Point(23, 237);
            soLuongLinhKienLabel.Name = "soLuongLinhKienLabel";
            soLuongLinhKienLabel.Size = new System.Drawing.Size(90, 25);
            soLuongLinhKienLabel.TabIndex = 17;
            soLuongLinhKienLabel.Text = "Số lượng";
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label7.Location = new System.Drawing.Point(23, 59);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(131, 25);
            label7.TabIndex = 19;
            label7.Text = "Mã sản phẩm";
            // 
            // label8
            // 
            label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label8.Location = new System.Drawing.Point(23, 299);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(105, 25);
            label8.TabIndex = 22;
            label8.Text = "Thành tiền";
            // 
            // t
            // 
            t.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            t.AutoSize = true;
            t.BackColor = System.Drawing.Color.Transparent;
            t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            t.Location = new System.Drawing.Point(23, 360);
            t.Name = "t";
            t.Size = new System.Drawing.Size(79, 25);
            t.TabIndex = 24;
            t.Text = "Ghi chú";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(205, 118);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(423, 30);
            this.txtMaNV.TabIndex = 34;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNCC.Location = new System.Drawing.Point(205, 362);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.ReadOnly = true;
            this.txtTenNCC.Size = new System.Drawing.Size(423, 30);
            this.txtTenNCC.TabIndex = 33;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNV.Location = new System.Drawing.Point(205, 181);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(423, 30);
            this.txtTenNV.TabIndex = 31;
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaNCC.FormattingEnabled = true;
            this.cbMaNCC.Items.AddRange(new object[] {
            "Nguyen Phi",
            "The Gioi Moi",
            "FPT Shop",
            "The Gioi Di Dong",
            "CellPhoneS",
            "Dien Thoai Vui",
            "Nguyen Nam",
            "Gearvn",
            "GIGABYTE",
            "GeForce"});
            this.cbMaNCC.Location = new System.Drawing.Point(205, 299);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.Size = new System.Drawing.Size(423, 33);
            this.cbMaNCC.TabIndex = 22;
            this.cbMaNCC.SelectedIndexChanged += new System.EventHandler(this.cbMaNCC_SelectedIndexChanged);
            // 
            // dtNgayXuatHD
            // 
            this.dtNgayXuatHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNgayXuatHD.Enabled = false;
            this.dtNgayXuatHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNgayXuatHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayXuatHD.Location = new System.Drawing.Point(205, 242);
            this.dtNgayXuatHD.Name = "dtNgayXuatHD";
            this.dtNgayXuatHD.Size = new System.Drawing.Size(423, 30);
            this.dtNgayXuatHD.TabIndex = 21;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHDN.Location = new System.Drawing.Point(205, 59);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.ReadOnly = true;
            this.txtMaHDN.Size = new System.Drawing.Size(423, 30);
            this.txtMaHDN.TabIndex = 18;
            // 
            // dgvCT_HDN
            // 
            this.dgvCT_HDN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCT_HDN.AutoGenerateColumns = false;
            this.dgvCT_HDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_HDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_HDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDNDataGridViewTextBoxColumn,
            this.maSPDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dVTDataGridViewTextBoxColumn,
            this.sLNhapDataGridViewTextBoxColumn,
            this.donGiaNhapDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dgvCT_HDN.DataSource = this.chiTietNhapBindingSource;
            this.dgvCT_HDN.Location = new System.Drawing.Point(3, 43);
            this.dgvCT_HDN.Name = "dgvCT_HDN";
            this.dgvCT_HDN.RowHeadersWidth = 51;
            this.dgvCT_HDN.RowTemplate.Height = 24;
            this.dgvCT_HDN.Size = new System.Drawing.Size(798, 237);
            this.dgvCT_HDN.TabIndex = 0;
            this.dgvCT_HDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCT_HDN_CellClick);
            this.dgvCT_HDN.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCT_HDN_RowsAdded);
            this.dgvCT_HDN.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvCT_HDN_RowsRemoved);
            // 
            // maHDNDataGridViewTextBoxColumn
            // 
            this.maHDNDataGridViewTextBoxColumn.DataPropertyName = "MaHDN";
            this.maHDNDataGridViewTextBoxColumn.HeaderText = "MaHDN";
            this.maHDNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHDNDataGridViewTextBoxColumn.Name = "maHDNDataGridViewTextBoxColumn";
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "MaSP";
            this.maSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenSP";
            this.dataGridViewTextBoxColumn1.HeaderText = "TenSP";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dVTDataGridViewTextBoxColumn
            // 
            this.dVTDataGridViewTextBoxColumn.DataPropertyName = "DVT";
            this.dVTDataGridViewTextBoxColumn.HeaderText = "DVT";
            this.dVTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dVTDataGridViewTextBoxColumn.Name = "dVTDataGridViewTextBoxColumn";
            // 
            // sLNhapDataGridViewTextBoxColumn
            // 
            this.sLNhapDataGridViewTextBoxColumn.DataPropertyName = "SLNhap";
            this.sLNhapDataGridViewTextBoxColumn.HeaderText = "SLNhap";
            this.sLNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sLNhapDataGridViewTextBoxColumn.Name = "sLNhapDataGridViewTextBoxColumn";
            // 
            // donGiaNhapDataGridViewTextBoxColumn
            // 
            this.donGiaNhapDataGridViewTextBoxColumn.DataPropertyName = "DonGiaNhap";
            this.donGiaNhapDataGridViewTextBoxColumn.HeaderText = "DonGiaNhap";
            this.donGiaNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaNhapDataGridViewTextBoxColumn.Name = "donGiaNhapDataGridViewTextBoxColumn";
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            // 
            // chiTietNhapBindingSource
            // 
            this.chiTietNhapBindingSource.DataMember = "ChiTietNhap1";
            this.chiTietNhapBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnCancle);
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Location = new System.Drawing.Point(201, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 84);
            this.panel2.TabIndex = 51;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.CausesValidation = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(101, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 64);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancle.BackColor = System.Drawing.Color.White;
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Image = ((System.Drawing.Image)(resources.GetObject("btnCancle.Image")));
            this.btnCancle.Location = new System.Drawing.Point(603, 13);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(148, 64);
            this.btnCancle.TabIndex = 30;
            this.btnCancle.Text = "Hủy";
            this.btnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(363, 13);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(148, 64);
            this.btnExcel.TabIndex = 36;
            this.btnExcel.Text = "Xuất";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.Color.White;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Red;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(152, 187);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(224, 59);
            this.btnThanhToan.TabIndex = 50;
            this.btnThanhToan.Text = "Xác nhận";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click_1);
            // 
            // txttongthanhtoan
            // 
            this.txttongthanhtoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttongthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttongthanhtoan.ForeColor = System.Drawing.Color.Red;
            this.txttongthanhtoan.Location = new System.Drawing.Point(183, 106);
            this.txttongthanhtoan.Multiline = true;
            this.txttongthanhtoan.Name = "txttongthanhtoan";
            this.txttongthanhtoan.ReadOnly = true;
            this.txttongthanhtoan.Size = new System.Drawing.Size(252, 32);
            this.txttongthanhtoan.TabIndex = 38;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.txtMaNV);
            this.guna2GroupBox1.Controls.Add(this.txtTenNV);
            this.guna2GroupBox1.Controls.Add(this.txtTenNCC);
            this.guna2GroupBox1.Controls.Add(this.txtMaHDN);
            this.guna2GroupBox1.Controls.Add(label3);
            this.guna2GroupBox1.Controls.Add(maHDNLabel);
            this.guna2GroupBox1.Controls.Add(maNVLabel);
            this.guna2GroupBox1.Controls.Add(nCCNhapHangLabel);
            this.guna2GroupBox1.Controls.Add(tenNVNhapHangLabel);
            this.guna2GroupBox1.Controls.Add(this.cbMaNCC);
            this.guna2GroupBox1.Controls.Add(this.dtNgayXuatHD);
            this.guna2GroupBox1.Controls.Add(ngayXuatHDNLabel);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkSalmon;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(9, 8);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(685, 402);
            this.guna2GroupBox1.TabIndex = 24;
            this.guna2GroupBox1.Text = "Thông tin chung";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.DarkSalmon;
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.Controls.Add(this.txtGhiChu);
            this.guna2GroupBox2.Controls.Add(t);
            this.guna2GroupBox2.Controls.Add(label8);
            this.guna2GroupBox2.Controls.Add(this.cbMaSP);
            this.guna2GroupBox2.Controls.Add(this.txtThanhTien);
            this.guna2GroupBox2.Controls.Add(linhKienLabel);
            this.guna2GroupBox2.Controls.Add(this.txtTenSP);
            this.guna2GroupBox2.Controls.Add(this.txtDGNhap);
            this.guna2GroupBox2.Controls.Add(label7);
            this.guna2GroupBox2.Controls.Add(donGiaLinhKienLabel);
            this.guna2GroupBox2.Controls.Add(this.txtSoLuong);
            this.guna2GroupBox2.Controls.Add(soLuongLinhKienLabel);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.LightSalmon;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(700, 8);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(569, 402);
            this.guna2GroupBox2.TabIndex = 53;
            this.guna2GroupBox2.Text = "Thông tin sản phẩm";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(163, 359);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(332, 31);
            this.txtGhiChu.TabIndex = 25;
            // 
            // cbMaSP
            // 
            this.cbMaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaSP.FormattingEnabled = true;
            this.cbMaSP.Items.AddRange(new object[] {
            "May Tinh Asus Vivobook 15",
            "May Tinh Acer 22",
            "Chuot logitech M331 ",
            "Chuot khong day asus 212",
            "Ban Phim Acer 111",
            "Ban Phim Dell Gaming 754",
            "Ram DDR3 4G",
            "Chuot Logitech 121 co day",
            "MSI GeForce RTX 4070 Ti SUPRIM X 12G",
            "ASUS ROG Strix GeForce RTX 3070 White V2 8GB GDDR6",
            "CPU core i3 6700U",
            "CPU core i7 11800H",
            "CPU core i9 12800K",
            "Loa Asuz z100 ",
            "Loa Dell 009",
            "Loa Kangaroo M331",
            "Man Hinh Dell 1616",
            "Man Hinh Acer happy 1928",
            "Man Hinh Chong Can Dell 1970",
            "Ram DDR5 8G",
            "May Tinh Dell 1650",
            "May Tinh Asus Vivobook 16"});
            this.cbMaSP.Location = new System.Drawing.Point(163, 59);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(332, 33);
            this.cbMaSP.TabIndex = 20;
            this.cbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbMaSP_SelectedIndexChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThanhTien.ForeColor = System.Drawing.Color.Red;
            this.txtThanhTien.Location = new System.Drawing.Point(163, 296);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(331, 31);
            this.txtThanhTien.TabIndex = 23;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSP.Location = new System.Drawing.Point(163, 112);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(332, 31);
            this.txtTenSP.TabIndex = 21;
            // 
            // txtDGNhap
            // 
            this.txtDGNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDGNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDGNhap.Location = new System.Drawing.Point(163, 175);
            this.txtDGNhap.Multiline = true;
            this.txtDGNhap.Name = "txtDGNhap";
            this.txtDGNhap.ReadOnly = true;
            this.txtDGNhap.Size = new System.Drawing.Size(332, 31);
            this.txtDGNhap.TabIndex = 16;
            this.txtDGNhap.Text = " ";
            this.txtDGNhap.TextChanged += new System.EventHandler(this.txtDGNhap_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuong.Location = new System.Drawing.Point(163, 236);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(332, 31);
            this.txtSoLuong.TabIndex = 18;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.txttongthanhtoan);
            this.guna2GroupBox3.Controls.Add(this.btnThanhToan);
            this.guna2GroupBox3.Controls.Add(label4);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(819, 506);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(457, 299);
            this.guna2GroupBox3.TabIndex = 54;
            this.guna2GroupBox3.Text = "Thông tin thanh toán";
            this.guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BorderRadius = 20;
            this.guna2GroupBox4.Controls.Add(this.dgvCT_HDN);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox4.Location = new System.Drawing.Point(9, 506);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(804, 299);
            this.guna2GroupBox4.TabIndex = 55;
            this.guna2GroupBox4.Text = "Danh sách sản phẩm được chọn";
            // 
            // chiTietNhap1TableAdapter
            // 
            this.chiTietNhap1TableAdapter.ClearBeforeFill = true;
            // 
            // ChiTietHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1281, 817);
            this.Controls.Add(this.guna2GroupBox4);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "ChiTietHDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapHang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChiTietHDN_FormClosed);
            this.Load += new System.EventHandler(this.NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_HDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.guna2GroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbMaNCC;
        private System.Windows.Forms.DateTimePicker dtNgayXuatHD;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TextBox txttongthanhtoan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dgvCT_HDN;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNV;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource chiTietNhapBindingSource;
  //      private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
  //      private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.ComboBox cbMaSP;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtDGNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGhiChu;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private DataSet1TableAdapters.ChiTietNhap1TableAdapter chiTietNhap1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
    }
}
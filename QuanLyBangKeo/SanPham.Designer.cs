namespace QuanLyBangKeo
{
    partial class SanPham
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
            System.Windows.Forms.Label donViTinhLabel;
            System.Windows.Forms.Label giaMTLabel;
            System.Windows.Forms.Label maMTLabel;
            System.Windows.Forms.Label maNCCLabel;
            System.Windows.Forms.Label maLMTLabel;
            System.Windows.Forms.Label soLuongMTLabel;
            System.Windows.Forms.Label tenMTLabel;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.cbFind = new System.Windows.Forms.ComboBox();
            this.cbMaLSP = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFInd = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDGBan = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cbMaNCC = new System.Windows.Forms.ComboBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtDGNhap = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hinhAnhPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            donViTinhLabel = new System.Windows.Forms.Label();
            giaMTLabel = new System.Windows.Forms.Label();
            maMTLabel = new System.Windows.Forms.Label();
            maNCCLabel = new System.Windows.Forms.Label();
            maLMTLabel = new System.Windows.Forms.Label();
            soLuongMTLabel = new System.Windows.Forms.Label();
            tenMTLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnhPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // donViTinhLabel
            // 
            donViTinhLabel.AutoSize = true;
            donViTinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            donViTinhLabel.Location = new System.Drawing.Point(363, 47);
            donViTinhLabel.Name = "donViTinhLabel";
            donViTinhLabel.Size = new System.Drawing.Size(88, 20);
            donViTinhLabel.TabIndex = 15;
            donViTinhLabel.Text = "Đơn vị tính";
            // 
            // giaMTLabel
            // 
            giaMTLabel.AutoSize = true;
            giaMTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            giaMTLabel.Location = new System.Drawing.Point(363, 124);
            giaMTLabel.Name = "giaMTLabel";
            giaMTLabel.Size = new System.Drawing.Size(107, 20);
            giaMTLabel.TabIndex = 9;
            giaMTLabel.Text = "Đơn giá nhập";
            // 
            // maMTLabel
            // 
            maMTLabel.AutoSize = true;
            maMTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maMTLabel.Location = new System.Drawing.Point(36, 47);
            maMTLabel.Name = "maMTLabel";
            maMTLabel.Size = new System.Drawing.Size(110, 20);
            maMTLabel.TabIndex = 1;
            maMTLabel.Text = "Mã sản phẩm";
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maNCCLabel.Location = new System.Drawing.Point(36, 284);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(137, 20);
            maNCCLabel.TabIndex = 24;
            maNCCLabel.Text = "Mã nhà cung cấp";
            // 
            // maLMTLabel
            // 
            maLMTLabel.AutoSize = true;
            maLMTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maLMTLabel.Location = new System.Drawing.Point(36, 202);
            maLMTLabel.Name = "maLMTLabel";
            maLMTLabel.Size = new System.Drawing.Size(141, 20);
            maLMTLabel.TabIndex = 22;
            maLMTLabel.Text = "Mã loại sản phẩm";
            // 
            // soLuongMTLabel
            // 
            soLuongMTLabel.AutoSize = true;
            soLuongMTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            soLuongMTLabel.Location = new System.Drawing.Point(363, 284);
            soLuongMTLabel.Name = "soLuongMTLabel";
            soLuongMTLabel.Size = new System.Drawing.Size(74, 20);
            soLuongMTLabel.TabIndex = 5;
            soLuongMTLabel.Text = "Số lượng";
            // 
            // tenMTLabel
            // 
            tenMTLabel.AutoSize = true;
            tenMTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenMTLabel.Location = new System.Drawing.Point(36, 124);
            tenMTLabel.Name = "tenMTLabel";
            tenMTLabel.Size = new System.Drawing.Size(115, 20);
            tenMTLabel.TabIndex = 3;
            tenMTLabel.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label3.Location = new System.Drawing.Point(363, 202);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 20);
            label3.TabIndex = 27;
            label3.Text = "Đơn giá bán";
            // 
            // cbFind
            // 
            this.cbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbFind.FormattingEnabled = true;
            this.cbFind.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Tên sản phẩm"});
            this.cbFind.Location = new System.Drawing.Point(266, 10);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(179, 33);
            this.cbFind.TabIndex = 2;
            // 
            // cbMaLSP
            // 
            this.cbMaLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaLSP.FormattingEnabled = true;
            this.cbMaLSP.Items.AddRange(new object[] {
            "LMT01",
            "LMT02",
            "LMT03",
            "LMT04",
            "LMT05",
            "LMT06",
            "LMT07",
            "LMT08",
            "LMT09 ",
            "LMT010"});
            this.cbMaLSP.Location = new System.Drawing.Point(40, 236);
            this.cbMaLSP.Name = "cbMaLSP";
            this.cbMaLSP.Size = new System.Drawing.Size(247, 28);
            this.cbMaLSP.TabIndex = 23;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuong.Location = new System.Drawing.Point(367, 318);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(237, 27);
            this.txtSoLuong.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnFInd);
            this.panel1.Controls.Add(this.cbFind);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1510, 52);
            this.panel1.TabIndex = 35;
            // 
            // btnFInd
            // 
            this.btnFInd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFInd.ForeColor = System.Drawing.Color.White;
            this.btnFInd.Location = new System.Drawing.Point(1013, 6);
            this.btnFInd.Name = "btnFInd";
            this.btnFInd.Size = new System.Drawing.Size(125, 37);
            this.btnFInd.TabIndex = 3;
            this.btnFInd.Text = "Tìm";
            this.btnFInd.UseVisualStyleBackColor = false;
            this.btnFInd.Click += new System.EventHandler(this.button1_Click);
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.txtDGBan);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(maNCCLabel);
            this.groupBox2.Controls.Add(this.cbMaNCC);
            this.groupBox2.Controls.Add(maLMTLabel);
            this.groupBox2.Controls.Add(this.cbMaLSP);
            this.groupBox2.Controls.Add(donViTinhLabel);
            this.groupBox2.Controls.Add(this.txtDVT);
            this.groupBox2.Controls.Add(giaMTLabel);
            this.groupBox2.Controls.Add(this.txtDGNhap);
            this.groupBox2.Controls.Add(soLuongMTLabel);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(tenMTLabel);
            this.groupBox2.Controls.Add(maMTLabel);
            this.groupBox2.Controls.Add(this.txtMaSP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(401, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 382);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // txtDGBan
            // 
            this.txtDGBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDGBan.Location = new System.Drawing.Point(367, 236);
            this.txtDGBan.Name = "txtDGBan";
            this.txtDGBan.Size = new System.Drawing.Size(237, 27);
            this.txtDGBan.TabIndex = 28;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSP.Location = new System.Drawing.Point(40, 157);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(250, 27);
            this.txtTenSP.TabIndex = 26;
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaNCC.FormattingEnabled = true;
            this.cbMaNCC.Items.AddRange(new object[] {
            "NCC01",
            "NCC02",
            "NCC03",
            "NCC04",
            "NCC05",
            "NCC06",
            "NCC07",
            "NCC08",
            "NCC09",
            "NCC010"});
            this.cbMaNCC.Location = new System.Drawing.Point(40, 317);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.Size = new System.Drawing.Size(247, 28);
            this.cbMaNCC.TabIndex = 25;
            // 
            // txtDVT
            // 
            this.txtDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDVT.Location = new System.Drawing.Point(367, 81);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(237, 27);
            this.txtDVT.TabIndex = 16;
            // 
            // txtDGNhap
            // 
            this.txtDGNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDGNhap.Location = new System.Drawing.Point(367, 158);
            this.txtDGNhap.Name = "txtDGNhap";
            this.txtDGNhap.Size = new System.Drawing.Size(237, 27);
            this.txtDGNhap.TabIndex = 10;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSP.Location = new System.Drawing.Point(40, 81);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(250, 27);
            this.txtMaSP.TabIndex = 2;
            // 
            // dgvSP
            // 
            this.dgvSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(6, 33);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSP.Size = new System.Drawing.Size(1450, 454);
            this.dgvSP.TabIndex = 32;
            this.dgvSP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSP_CellFormatting);
            this.dgvSP.SelectionChanged += new System.EventHandler(this.dgvSP_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // hinhAnhPictureBox
            // 
            this.hinhAnhPictureBox.ErrorImage = null;
            this.hinhAnhPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("hinhAnhPictureBox.Image")));
            this.hinhAnhPictureBox.Location = new System.Drawing.Point(15, 28);
            this.hinhAnhPictureBox.Name = "hinhAnhPictureBox";
            this.hinhAnhPictureBox.Size = new System.Drawing.Size(350, 250);
            this.hinhAnhPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hinhAnhPictureBox.TabIndex = 8;
            this.hinhAnhPictureBox.TabStop = false;
            this.hinhAnhPictureBox.Click += new System.EventHandler(this.hinhAnhPictureBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.hinhAnhPictureBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 382);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình ảnh";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnCancle);
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Location = new System.Drawing.Point(1039, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 373);
            this.panel2.TabIndex = 40;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.CausesValidation = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(45, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 70);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(45, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 70);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.CausesValidation = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(281, 73);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 70);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancle.BackColor = System.Drawing.Color.White;
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Image = ((System.Drawing.Image)(resources.GetObject("btnCancle.Image")));
            this.btnCancle.Location = new System.Drawing.Point(45, 300);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(180, 70);
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
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(281, 195);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(180, 70);
            this.btnExcel.TabIndex = 36;
            this.btnExcel.Text = "Xuất";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvSP);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 446);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1462, 493);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1510, 945);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnhPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbFind;
        private System.Windows.Forms.ComboBox cbMaLSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFInd;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cbMaNCC;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtDGNhap;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox hinhAnhPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDGBan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonBan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbFind = new System.Windows.Forms.ComboBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBoLoc = new Guna.UI2.WinForms.Guna2Button();
            this.checkbox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnLocTT = new Guna.UI2.WinForms.Guna2Button();
            this.btnLocNgay = new Guna.UI2.WinForms.Guna2Button();
            this.dtLoc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvhdb = new Guna.UI2.WinForms.Guna2DataGridView();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhdb)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label3.Location = new System.Drawing.Point(434, 78);
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
            label4.Location = new System.Drawing.Point(7, 75);
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.cbMaKH);
            this.panel2.Controls.Add(this.txtTenKH);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(label4);
            this.panel2.Location = new System.Drawing.Point(12, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1201, 170);
            this.panel2.TabIndex = 65;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.BorderRadius = 20;
            this.btnExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcel.FillColor2 = System.Drawing.Color.Gray;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExcel.Location = new System.Drawing.Point(882, 105);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(233, 62);
            this.btnExcel.TabIndex = 79;
            this.btnExcel.Text = "Xuất";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.FillColor2 = System.Drawing.Color.Gray;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdd.Location = new System.Drawing.Point(882, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Size = new System.Drawing.Size(233, 70);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.Text = "Tạo hóa đơn mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
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
            this.cbMaKH.Location = new System.Drawing.Point(167, 70);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(220, 33);
            this.cbMaKH.TabIndex = 76;
            this.cbMaKH.SelectedIndexChanged += new System.EventHandler(this.cbMaKH_SelectedIndexChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKH.Location = new System.Drawing.Point(601, 70);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(220, 30);
            this.txtTenKH.TabIndex = 77;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnBoLoc);
            this.panel1.Controls.Add(this.checkbox1);
            this.panel1.Controls.Add(this.btnLocTT);
            this.panel1.Controls.Add(this.btnLocNgay);
            this.panel1.Controls.Add(this.dtLoc);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.cbFind);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 123);
            this.panel1.TabIndex = 63;
            // 
            // btnBoLoc
            // 
            this.btnBoLoc.BorderRadius = 10;
            this.btnBoLoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBoLoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBoLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBoLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBoLoc.FillColor = System.Drawing.Color.Goldenrod;
            this.btnBoLoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoLoc.ForeColor = System.Drawing.Color.White;
            this.btnBoLoc.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnBoLoc.Location = new System.Drawing.Point(1018, 75);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.ShadowDecoration.BorderRadius = 20;
            this.btnBoLoc.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.btnBoLoc.Size = new System.Drawing.Size(129, 37);
            this.btnBoLoc.TabIndex = 20;
            this.btnBoLoc.Text = "Bỏ lọc";
            this.btnBoLoc.Click += new System.EventHandler(this.btnBoLoc_Click);
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkbox1.CheckedState.BorderRadius = 0;
            this.checkbox1.CheckedState.BorderThickness = 0;
            this.checkbox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox1.Location = new System.Drawing.Point(558, 75);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(181, 33);
            this.checkbox1.TabIndex = 19;
            this.checkbox1.Text = "Đã thanh toán";
            this.checkbox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbox1.UncheckedState.BorderRadius = 0;
            this.checkbox1.UncheckedState.BorderThickness = 0;
            this.checkbox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // btnLocTT
            // 
            this.btnLocTT.BorderRadius = 10;
            this.btnLocTT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLocTT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLocTT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLocTT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLocTT.FillColor = System.Drawing.Color.Green;
            this.btnLocTT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocTT.ForeColor = System.Drawing.Color.White;
            this.btnLocTT.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnLocTT.Location = new System.Drawing.Point(745, 72);
            this.btnLocTT.Name = "btnLocTT";
            this.btnLocTT.ShadowDecoration.BorderRadius = 20;
            this.btnLocTT.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.btnLocTT.Size = new System.Drawing.Size(181, 37);
            this.btnLocTT.TabIndex = 18;
            this.btnLocTT.Text = "Lọc trạng thái";
            this.btnLocTT.Click += new System.EventHandler(this.btnLocTT_Click);
            // 
            // btnLocNgay
            // 
            this.btnLocNgay.BorderRadius = 10;
            this.btnLocNgay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLocNgay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLocNgay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLocNgay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLocNgay.FillColor = System.Drawing.Color.Crimson;
            this.btnLocNgay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocNgay.ForeColor = System.Drawing.Color.White;
            this.btnLocNgay.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnLocNgay.Location = new System.Drawing.Point(373, 72);
            this.btnLocNgay.Name = "btnLocNgay";
            this.btnLocNgay.ShadowDecoration.BorderRadius = 20;
            this.btnLocNgay.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.btnLocNgay.Size = new System.Drawing.Size(115, 37);
            this.btnLocNgay.TabIndex = 17;
            this.btnLocNgay.Text = "Lọc ngày";
            this.btnLocNgay.Click += new System.EventHandler(this.btnLocNgay_Click);
            // 
            // dtLoc
            // 
            this.dtLoc.BackColor = System.Drawing.Color.Transparent;
            this.dtLoc.BorderRadius = 20;
            this.dtLoc.Checked = true;
            this.dtLoc.FillColor = System.Drawing.Color.White;
            this.dtLoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtLoc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtLoc.Location = new System.Drawing.Point(74, 72);
            this.dtLoc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtLoc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtLoc.Name = "dtLoc";
            this.dtLoc.Size = new System.Drawing.Size(293, 36);
            this.dtLoc.TabIndex = 16;
            this.dtLoc.Value = new System.DateTime(2024, 9, 3, 13, 52, 36, 966);
            // 
            // btnFind
            // 
            this.btnFind.BorderRadius = 10;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.Navy;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnFind.Location = new System.Drawing.Point(1001, 6);
            this.btnFind.Name = "btnFind";
            this.btnFind.ShadowDecoration.BorderRadius = 20;
            this.btnFind.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.btnFind.Size = new System.Drawing.Size(74, 37);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Tìm";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.dgvhdb);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 305);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1201, 338);
            this.guna2GroupBox1.TabIndex = 66;
            this.guna2GroupBox1.Text = "Danh sách hóa đơn";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvhdb
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvhdb.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvhdb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhdb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvhdb.ColumnHeadersHeight = 25;
            this.dgvhdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvhdb.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvhdb.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvhdb.Location = new System.Drawing.Point(3, 43);
            this.dgvhdb.Name = "dgvhdb";
            this.dgvhdb.RowHeadersVisible = false;
            this.dgvhdb.RowHeadersWidth = 51;
            this.dgvhdb.RowTemplate.Height = 24;
            this.dgvhdb.Size = new System.Drawing.Size(1195, 272);
            this.dgvhdb.TabIndex = 0;
            this.dgvhdb.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvhdb.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvhdb.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvhdb.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvhdb.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvhdb.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvhdb.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvhdb.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvhdb.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvhdb.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvhdb.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvhdb.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvhdb.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvhdb.ThemeStyle.ReadOnly = false;
            this.dgvhdb.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvhdb.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvhdb.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvhdb.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvhdb.ThemeStyle.RowsStyle.Height = 24;
            this.dgvhdb.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvhdb.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvhdb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhdb_CellClick);
            this.dgvhdb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhdb_CellContentClick);
            this.dgvhdb.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhdb_CellDoubleClick);
            this.dgvhdb.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvhdb_CellFormatting);
            // 
            // HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1231, 645);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HoaDonBan";
            this.Text = "HoaDonBan";
            this.Load += new System.EventHandler(this.HoaDonBan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhdb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvhdb;
        private Guna.UI2.WinForms.Guna2GradientButton btnExcel;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnBoLoc;
        private Guna.UI2.WinForms.Guna2CheckBox checkbox1;
        private Guna.UI2.WinForms.Guna2Button btnLocTT;
        private Guna.UI2.WinForms.Guna2Button btnLocNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtLoc;
    }
}
namespace QuanLyBangKeo
{
    partial class ReportHDB
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
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label maHDNLabel;
            System.Windows.Forms.Label label2;
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            maNVLabel = new System.Windows.Forms.Label();
            maHDNLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maNVLabel
            // 
            maNVLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            maNVLabel.AutoSize = true;
            maNVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maNVLabel.Location = new System.Drawing.Point(622, 84);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(154, 29);
            maNVLabel.TabIndex = 41;
            maNVLabel.Text = "Mã nhân viên";
            // 
            // maHDNLabel
            // 
            maHDNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            maHDNLabel.AutoSize = true;
            maHDNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maHDNLabel.Location = new System.Drawing.Point(72, 84);
            maHDNLabel.Name = "maHDNLabel";
            maHDNLabel.Size = new System.Drawing.Size(198, 29);
            maHDNLabel.TabIndex = 40;
            maHDNLabel.Text = "Mã hóa đơn nhập";
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 75;
            this.reportViewer1.Location = new System.Drawing.Point(0, 144);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1456, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(782, 84);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(212, 34);
            this.txtMaNV.TabIndex = 43;
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHDB.Location = new System.Drawing.Point(341, 84);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.ReadOnly = true;
            this.txtMaHDB.Size = new System.Drawing.Size(212, 34);
            this.txtMaHDB.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(717, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 36);
            this.label1.TabIndex = 39;
            this.label1.Text = "FORM IN ẤN";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKH.Location = new System.Drawing.Point(1234, 84);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(212, 34);
            this.txtMaKH.TabIndex = 45;
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label2.Location = new System.Drawing.Point(1054, 89);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(174, 29);
            label2.TabIndex = 44;
            label2.Text = "Mã khách hàng";
            // 
            // ReportHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1458, 754);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(maNVLabel);
            this.Controls.Add(maHDNLabel);
            this.Controls.Add(this.txtMaHDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportHDB";
            this.Text = "ReportHDB";
            this.Load += new System.EventHandler(this.ReportHDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
    }
}
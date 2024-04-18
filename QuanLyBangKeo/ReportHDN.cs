using BUS_QuanLyBK;
using DTO_QuanLyBK;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBangKeo
{
    public partial class ReportHDN : Form
    {
        BUS_ChiTietNhap busctn=new BUS_ChiTietNhap();
        public ReportHDN()
        {
            InitializeComponent();
        }
        private void ReportHDN_Load(object sender, EventArgs e)
        {
            DataSet ds = busctn.GetHoaDonNhapHangByMaHDN(txtMaHDN.Text,txtMaNV.Text);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                showReportNhap(ds);
            }
        }
        public void SetMaHoaDonValue(string maHoaDon, string maNV)
        {
            txtMaHDN.Text = maHoaDon;
            txtMaNV.Text = maNV;
        }
        public void showReportNhap(DataSet ds)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "ReportHDN.rdlc";
            ReportDataSource rds = new ReportDataSource("DSNhap", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}

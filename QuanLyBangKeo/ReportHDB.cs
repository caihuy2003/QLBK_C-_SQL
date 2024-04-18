using BUS_QuanLyBK;
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
    public partial class ReportHDB : Form
    {
        BUS_ChiTietHDB buscthdb=new BUS_ChiTietHDB();
        public ReportHDB()
        {
            InitializeComponent();
        }

        private void ReportHDB_Load(object sender, EventArgs e)
        {
            DataSet ds = buscthdb.GetHoaDonBanHangByMaHDB(txtMaHDB.Text,txtMaNV.Text,txtMaKH.Text);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                showReportBan(ds);
            }
        }
        public void SetMaHoaDonValue(string maHoaDon, string maNV,string maKH)
        {
            txtMaHDB.Text = maHoaDon;
            txtMaNV.Text = maNV;
            txtMaKH.Text = maKH;
        }
        public void showReportBan(DataSet ds)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "ReportHDB.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSetHDB", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}

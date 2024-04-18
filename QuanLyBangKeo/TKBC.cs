using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyBK;
using Microsoft.Reporting.WinForms;
namespace QuanLyBangKeo
{
    public partial class TKBC : Form
    {
        BUS_TKBC bustkbc=new BUS_TKBC();
        public TKBC()
        {
            InitializeComponent();
        }

        private void TKBC_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        public void showReportBan(DataSet ds)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "BCDoanhThuBan.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        public void showReportNhap(DataSet ds)
        {
            reportViewer2.ProcessingMode = ProcessingMode.Local;
            reportViewer2.LocalReport.ReportPath = "BCDoanhThuNhap.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet2", ds.Tables[0]);
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(rds);
            reportViewer2.RefreshReport();
        }
        private void btnDay_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtChoose.Value.Date; 
            DataSet ds1 = bustkbc.GetHoaDonBanHangByDay(selectedDate);
            DataSet ds2 = bustkbc.GetHoaDonNhapHangByDay(selectedDate);
            if (ds1 != null && ds1.Tables[0].Rows.Count > 0 )
            {
                showReportBan(ds1);
            }
            if (ds2 != null && ds2.Tables[0].Rows.Count > 0)
            {
                showReportNhap(ds2);
            }
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            DataSet ds1 = bustkbc.GetHoaDonBanHangByMonth(dtChoose.Value.Month,dtChoose.Value.Year);
            DataSet ds2 = bustkbc.GetHoaDonNhapHangByMonth(dtChoose.Value.Month, dtChoose.Value.Year);
            if (ds1 != null && ds1.Tables[0].Rows.Count > 0)
            {
                showReportBan(ds1);
            }
            if (ds2 != null && ds2.Tables[0].Rows.Count > 0)
            {
                showReportNhap(ds2);
            }
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            DataSet ds1 = bustkbc.GetHoaDonBanHangByYear(dtChoose.Value.Year);
            DataSet ds2 = bustkbc.GetHoaDonNhapHangByYear(dtChoose.Value.Year);
            if (ds1 != null && ds1.Tables[0].Rows.Count > 0)
            {
                showReportBan(ds1);
            }
            if (ds2 != null && ds2.Tables[0].Rows.Count > 0)
            {
                showReportNhap(ds2);
            }
        }

        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txtFrom.Focus();
            }
        }

        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txtTo.Focus();
            }
        }

        private void btnReportMoney_Click(object sender, EventArgs e)
        {
            int min=Convert.ToInt32(txtFrom.Text);
            int max=Convert.ToInt32(txtTo.Text);
            DataSet ds1 = bustkbc.GetHoaDonBanHangByTotalAmountRange(min,max);
            DataSet ds2 = bustkbc.GetHoaDonNhapHangByTotalAmountRange(min,max);
            if (ds1 != null && ds1.Tables[0].Rows.Count > 0)
            {
                showReportBan(ds1);
            }
            if (ds2 != null && ds2.Tables[0].Rows.Count > 0)
            {
                showReportNhap(ds2);
            }
           
        }
    }
}

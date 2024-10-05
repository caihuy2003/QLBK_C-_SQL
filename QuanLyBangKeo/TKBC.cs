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
using Guna.UI2.WinForms;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media;
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
            ReportDataSource rds = new ReportDataSource("DataSet2", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void rdThang_CheckedChanged(object sender, EventArgs e)
        {
            if(rdThang.Checked)
            {
                lbQui.Visible= false;
                cbQui.Visible= false;
                lbThang.Visible= true;
                cbThang.Visible= true;
            }
        }

        private void rdQui_CheckedChanged(object sender, EventArgs e)
        {
            if(rdQui.Checked)
            {
                lbThang.Visible= false;
                cbThang.Visible= false;
                lbQui.Visible = true;
                cbQui.Visible = true;
            }
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNam.Checked)
            {
                lbQui.Visible = false;
                cbQui.Visible = false;
                lbThang.Visible = false;
                cbThang.Visible = false;
            }
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txtNam.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (rdNam.Checked)
            {
                if(txtNam.Text !=" ")
                {
                    int nam=Convert.ToInt32(txtNam.Text);
                    DataSet ds1 = bustkbc.DoanhThuTheoNam(nam);
                    if (ds1 != null && ds1.Tables[0].Rows.Count > 0)
                    {
                        showReportBan(ds1);
                        int tienban=bustkbc.TongBanTrongNam(nam);
                        int tiennhap=bustkbc.TongNhapTrongNam(nam);
                        lbBan.Text=tienban.ToString("#,##0");
                        lbNhap.Text = tiennhap.ToString("#,##0");
                        TaoBieuDo();
                        // Gán DataSource từ DataSet vào Chart
                        chart1.DataSource = ds1.Tables[0];
                        chart1.DataBind();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập năm");
                }
            }
            else if (rdThang.Checked)
            { 
                    if (txtNam.Text != " " && cbThang.Text != "")
                    {
                        int nam = Convert.ToInt32(txtNam.Text);
                        int thang=Convert.ToInt32(cbThang.Text);
                        DataSet ds1 = bustkbc.DoanhThuTheoThang(thang,nam);
                        if (ds1 != null && ds1.Tables[0].Rows.Count > 0)
                        {
                            showReportBan(ds1);
                            int tienban = bustkbc.TongBanTrongThang(thang,nam);
                            int tiennhap = bustkbc.TongNhapTrongThang(thang,nam);
                            lbBan.Text = tienban.ToString("#,##0");
                            lbNhap.Text = tiennhap.ToString("#,##0");
                            TaoBieuDo() ;
                            // Gán DataSource từ DataSet vào Chart
                            chart1.DataSource = ds1.Tables[0];
                            chart1.DataBind();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập năm,chọn tháng");
                    }
            }
            
            else if (rdQui.Checked)
            {
                if (txtNam.Text != " " && cbQui.Text != "")
                {
                    int nam = Convert.ToInt32(txtNam.Text);
                    int qui = Convert.ToInt32(cbQui.Text);
                    DataSet ds1 = bustkbc.DoanhThuTheoQui(nam,qui);
                    if (ds1 != null && ds1.Tables[0].Rows.Count > 0)
                    {
                        showReportBan(ds1);
                        int tienban = bustkbc.TongBanTrongQui(nam,qui);
                        int tiennhap = bustkbc.TongNhapTrongQui(nam,qui);
                        lbBan.Text = tienban.ToString("#,##0");
                        lbNhap.Text = tiennhap.ToString("#,##0");
                        TaoBieuDo();
                        // Gán DataSource từ DataSet vào Chart
                        chart1.DataSource = ds1.Tables[0];
                        chart1.DataBind();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập năm,chọn quí");
                }
            }
            
        }
        private void TaoBieuDo()
        {
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);
            chart1.Titles.Add("Thống kê doanh thu");
            // Tạo Series cho TotalSales
            Series salesSeries = new Series("Tổng tiền bán");
            salesSeries.XValueMember = "ThoiGian"; // Dữ liệu cột X (Month)
            salesSeries.YValueMembers = "TongTienBan"; // Dữ liệu cột Y (TotalSales)
            salesSeries.ToolTip = "Tổng bán: #VALY vào tháng #VALX";
            salesSeries.ChartType = SeriesChartType.Line; // Loại biểu đồ (Column chart)
            salesSeries.BorderWidth = 3;
            // Tạo Series cho TotalPurchases
            Series purchasesSeries = new Series("Tổng tiền nhập");
            purchasesSeries.XValueMember = "ThoiGian"; // Dữ liệu cột X (Month)
            purchasesSeries.YValueMembers = "TongTienNhap"; // Dữ liệu cột Y (TotalPurchases)
            purchasesSeries.ToolTip = "Tổng nhập: #VALY vào tháng #VALX";
            purchasesSeries.ChartType = SeriesChartType.Line; // Loại biểu đồ (Line chart)
            purchasesSeries.BorderWidth = 3;
            salesSeries.Color = System.Drawing.Color.Blue;
            purchasesSeries.Color = System.Drawing.Color.Green;
            // Thêm các Series vào Chart
            chart1.Series.Add(salesSeries);
            chart1.Series.Add(purchasesSeries);

            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisY.ScaleView.Zoomable = true;
            purchasesSeries.MarkerStyle = MarkerStyle.Circle; // Dấu tròn
            purchasesSeries.MarkerSize = 8;
            purchasesSeries.MarkerColor = System.Drawing.Color.Green;
            purchasesSeries.MarkerBorderWidth = 2;
            purchasesSeries.MarkerBorderColor = System.Drawing.Color.Black;
            salesSeries.MarkerStyle = MarkerStyle.Circle; // Dấu tròn
            salesSeries.MarkerSize = 8;
            salesSeries.MarkerColor = System.Drawing.Color.Blue;
            salesSeries.MarkerBorderWidth = 2;
            salesSeries.MarkerBorderColor = System.Drawing.Color.Black;
            chartArea.CursorX.IsUserEnabled = true;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.CursorY.IsUserEnabled = true;
            chartArea.CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0:n0}";
            chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
        }
    }
}

using BUS_QuanLyBK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyBangKeo
{
    public partial class TKKH : Form
    {
        BUS_TKBC bustkbc = new BUS_TKBC();
        public TKKH()
        {
            InitializeComponent();
        }

        private void TKKH_Load(object sender, EventArgs e)
        {
            dgvSP.RowTemplate.Height = 30;
            dgvSP.RowsDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dgvSP.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateBlue;
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tự động điều chỉnh kích thước cột cuối cùng để vừa với chiều rộng DataGridView
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKH.RowTemplate.Height = 30;
            dgvKH.RowsDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dgvKH.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateBlue;
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tự động điều chỉnh kích thước cột cuối cùng để vừa với chiều rộng DataGridView
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void rdThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThang.Checked)
            {
                lbQui.Visible = false;
                cbQui.Visible = false;
                lbThang.Visible = true;
                cbThang.Visible = true;
            }
        }

        private void rdQui_CheckedChanged(object sender, EventArgs e)
        {
            if (rdQui.Checked)
            {
                lbThang.Visible = false;
                cbThang.Visible = false;
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
                if (txtNam.Text != " ")
                {
                    int nam = Convert.ToInt32(txtNam.Text);
                    DataSet ds1 = bustkbc.SanPhamTheoNam(nam);
                    DataSet ds2= bustkbc.KhachHangTheoNam(nam);
                    if (ds1 != null && ds1.Tables[0].Rows.Count > 0 && ds2 != null && ds2.Tables[0].Rows.Count > 0)
                    {
                        dgvSP.DataSource = ds1.Tables[0];
                        dgvKH.DataSource = ds2.Tables[0];
                        int tienban = bustkbc.TongBanTrongNam(nam);
                        int tongkh = bustkbc.TongKHTrongNam(nam);
                        int tongsp=bustkbc.TongSPTrongNam(nam);
                        lbBan.Text = tienban.ToString("#,##0");
                        lbSP.Text = tongsp.ToString();
                        lbKH.Text = tongkh.ToString();
                        Top5SanPham(ds1);
                        Top10KhachHang(ds2);
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
                    int thang = Convert.ToInt32(cbThang.Text);
                    DataSet ds1 = bustkbc.SanPhamTheoThang(thang, nam);
                    DataSet ds2 = bustkbc.KhachHangTheoThang(thang,nam);
                    if (ds1 != null && ds1.Tables[0].Rows.Count > 0 && ds2 != null && ds2.Tables[0].Rows.Count > 0)
                    {
                        dgvSP.DataSource = ds1.Tables[0];
                        dgvKH.DataSource = ds2.Tables[0];
                        int tienban = bustkbc.TongBanTrongThang(thang,nam);
                        int tongkh = bustkbc.TongKHTrongThang(thang,nam);
                        MessageBox.Show(tongkh.ToString());
                        int tongsp = bustkbc.TongSPTrongThang(thang,nam);
                        lbBan.Text = tienban.ToString("#,##0");
                        lbSP.Text = tongsp.ToString();
                        lbKH.Text = tongkh.ToString();
                        Top5SanPham(ds1);
                        Top10KhachHang(ds2);
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
                    DataSet ds1 = bustkbc.SanPhamTheoQui(nam, qui);
                    DataSet ds2 = bustkbc.KhachHangTheoQui(nam, qui);
                    if (ds1 != null && ds1.Tables[0].Rows.Count > 0 && ds2 != null && ds2.Tables[0].Rows.Count > 0)
                    {
                        dgvSP.DataSource = ds1.Tables[0];
                        dgvKH.DataSource = ds2.Tables[0];
                        int tienban = bustkbc.TongBanTrongQui(nam,qui);
                        int tongkh = bustkbc.TongKHTrongQui(nam,qui);
                        int tongsp = bustkbc.TongSPTrongQui(nam,qui);
                        lbBan.Text = tienban.ToString("#,##0");
                        lbSP.Text = tongsp.ToString();
                        lbKH.Text = tongkh.ToString();
                        Top5SanPham(ds1);
                        Top10KhachHang(ds2);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập năm,chọn quí");
                }
            }
        }
        public void Top5SanPham(DataSet ds)
        {

            // Lấy DataTable chứa danh sách sản phẩm và tổng tiền bán
            DataTable dt = ds.Tables[0];
            decimal totalRevenue = dt.AsEnumerable().Sum(row => row.Field<int>("TongTienBan"));
            // Sắp xếp DataTable theo cột "TongTienBan" giảm dần và lấy 10 sản phẩm đầu
            var top10Products = dt.AsEnumerable()
                                  .OrderByDescending(row => row.Field<int>("TongTienBan"))
                                  .Take(5)
                                  .CopyToDataTable();

            // Tính tổng tiền của các sản phẩm còn lại
            var otherProductsSum = dt.AsEnumerable()
                                     .OrderByDescending(row => row.Field<int>("TongTienBan"))
                                     .Skip(5)
                                     .Sum(row => row.Field<int>("TongTienBan"));

            // Thêm sản phẩm "Khác" vào top10Products
            DataRow othersRow = top10Products.NewRow();
            othersRow["TenSP"] = "Khác";
            othersRow["TongTienBan"] = otherProductsSum;
            top10Products.Rows.Add(othersRow);

            // Hiển thị dữ liệu trên biểu đồ tròn
            DisplayPieChart(top10Products,totalRevenue);
            
            chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
        }
        public void Top10KhachHang(DataSet ds)
        {

            // Lấy DataTable chứa danh sách khach hang và tổng tiền bán
            DataTable dt = ds.Tables[0];
            var top10KH = dt.AsEnumerable()
                                  .OrderByDescending(row => row.Field<int>("TongTien"))
                                  .Take(10)
                                  .CopyToDataTable();

            // Hiển thị dữ liệu trên biểu đồ tròn
            DisplayBarChart(top10KH);

            chart2.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart2.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
        }
        public void DisplayPieChart(DataTable dt, decimal totalRevenue)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();
            chart1.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            chartArea.Position = new ElementPosition(0, 10, 70, 90);
            chart1.ChartAreas.Add(chartArea);
            // Giả sử chart1 là Chart control trên form
            // Tạo Series biểu đồ tròn
            Series series = new Series
            {
                Name = "Top10Products",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };

            // Thêm dữ liệu vào Series
            foreach (DataRow row in dt.Rows)
            {
                decimal revenue = row.Field<int>("TongTienBan");
                double percentage = (double)(revenue / totalRevenue) * 100;
                DataPoint dp = new DataPoint();
                dp.SetValueXY(row["TenSP"], revenue);

                // Định dạng hiển thị phần trăm trên biểu đồ
                dp.Label = $"{percentage:0.00}%";
                dp.ToolTip = $"Sản phẩm: {row["TenSP"]}, Doanh thu: {revenue:C}, ({percentage:0.00}%)";

                series.Points.Add(dp);
            }
            // Thêm Legend (chú thích) và chỉ hiển thị tên sản phẩm trong phần chú thích
            Legend legend = new Legend("ProductLegend");
            legend.Position = new ElementPosition(70, 10, 30, 90);
            legend.AutoFitMinFontSize = 8;
            chart1.Legends.Add(legend);

            // Tùy chỉnh mỗi phần của biểu đồ có tên sản phẩm trong chú thích
            foreach (var point in series.Points)
            {
                point.LegendText = point.AxisLabel;  // Hiển thị tên sản phẩm trong Legend
            }
            chart1.Series.Add(series);
            // Tùy chỉnh hiển thị của biểu đồ
            chart1.Titles.Add("Top 5 sản phẩm");
            chart1.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
            chart1.Titles[0].ForeColor = Color.DarkBlue;
            chart1.Legends[0].Title = "Sản phẩm";
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisY.ScaleView.Zoomable = true;
        }
        public void DisplayBarChart(DataTable dt)
        {
            chart2.Series.Clear();
            chart2.Titles.Clear();
            chart2.Legends.Clear();
            chart2.ChartAreas.Clear(); // Cần xóa cả ChartAreas trước khi thêm mới

            // Tạo ChartArea
            ChartArea chartArea = new ChartArea();
            chart2.ChartAreas.Add(chartArea);

            // Tạo Series cho biểu đồ cột
            Series barSeries = new Series("Doanh Thu Khách Hàng");
            barSeries.ChartType = SeriesChartType.Bar; // Dạng biểu đồ cột
            barSeries.XValueType = ChartValueType.String; // Cột X là dạng chuỗi (Mã khách hàng)
            barSeries.YValueType = ChartValueType.Double; // Cột Y là dạng số (Số tiền)

            // Đổ dữ liệu từ DataTable vào Series
            foreach (DataRow row in dt.Rows)
            {
                barSeries.Points.AddXY(row["MaKH"].ToString(), Convert.ToDouble(row["TongTien"]));
            }

            // Thêm Series vào biểu đồ
            chart2.Series.Add(barSeries);

            // Tùy chỉnh giao diện biểu đồ
            barSeries.Color = Color.CornflowerBlue; // Đặt màu cho các cột
            barSeries.BorderWidth = 2; // Độ dày của cột

            // Thêm chú thích cho biểu đồ (Legend)
            Legend legend = new Legend("MainLegend");
            legend.Docking = Docking.Top; // Vị trí hiển thị chú thích
            chart2.Legends.Add(legend);

            // Định dạng trục X (Mã khách hàng)
            chartArea.AxisX.Title = "Mã Khách Hàng"; // Tiêu đề trục X
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 10); // Font cho trục X
            chartArea.AxisX.Interval = 1; // Hiển thị mỗi mã khách hàng một lần
            chartArea.AxisX.MajorGrid.Enabled = false; // Tắt đường lưới cho trục X

            // Định dạng trục Y (Số tiền)
            chartArea.AxisY.Title = "Số Tiền (VND)";
            chartArea.AxisY.LabelStyle.Font = new Font("Arial", 10);
            chartArea.AxisY.LabelStyle.Format = "{0:n0}"; // Hiển thị theo định dạng triệu VND
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray; // Đường lưới trục Y

            // Hiển thị giá trị trên mỗi cột
            barSeries.IsValueShownAsLabel = true;
            barSeries.LabelFormat = "{0:n0}"; // Hiển thị giá trị theo định dạng triệu VND

            // Đặt tiêu đề cho biểu đồ
            chart2.Titles.Add("Doanh Thu Theo Khách Hàng");
            chart2.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
            chart2.Titles[0].ForeColor = Color.DarkBlue;
        }
    }
}

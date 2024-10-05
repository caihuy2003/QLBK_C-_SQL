using BUS_QuanLyBK;
using DAL_QuanLyBK;
using DTO_QuanLyBK;
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
    public partial class HoaDonBan : Form
    {
        BUS_HoaDonBan bushdb=new BUS_HoaDonBan();
        BUS_ChiTietHDB busct_hdb=new BUS_ChiTietHDB();
        BUS_NhatKyHoatDong busnkhd=new BUS_NhatKyHoatDong();
        private string MaNV;
        public HoaDonBan(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            dgvhdb.DataSource = bushdb.getHoaDonBan();
            cbMaKH.DataSource = bushdb.GetMaKH();
            dgvhdb.RowTemplate.Height = 30;
            dgvhdb.RowsDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dgvhdb.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateBlue;

            dgvhdb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tự động điều chỉnh kích thước cột cuối cùng để vừa với chiều rộng DataGridView
            dgvhdb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvhdb.RowTemplate.Height = 50;
            Image trashIcon = Properties.Resources.icons8_delete_50;
            Image resizedIcon = new Bitmap(trashIcon, new Size(20, 20));
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "DeleteColumn";
            imgColumn.HeaderText = "";
            imgColumn.Image = resizedIcon;
            imgColumn.Width = 10;
            //imgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvhdb.Columns.Add(imgColumn);
        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makh = cbMaKH.SelectedItem.ToString(); // Lấy mã khách hàng từ ComboBox
            string[] thongTinKH = bushdb.LayThongTinKH(makh); 

            txtTenKH.Text = thongTinKH[0];
        }

        private void dgvhdb_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ReportHDB rphdb = new ReportHDB();
            //rphdb.Show();
            if (dgvhdb.SelectedRows.Count > 0)
            {
                string maHoaDon = dgvhdb.SelectedRows[0].Cells["MaHDB"].Value.ToString();
                DateTime ngay = (DateTime)dgvhdb.SelectedRows[0].Cells["NgayXuatHDB"].Value;
                int tongtien = (int)dgvhdb.SelectedRows[0].Cells["TongTienBan"].Value;
                bool daThanhToan = (bool)dgvhdb.SelectedRows[0].Cells["DaThanhToan"].Value;
                DanhSachCT_HDB ds = new DanhSachCT_HDB();
                ds.SetValue(maHoaDon, MaNV, cbMaKH.Text, ngay, tongtien,daThanhToan);
                ds.ShowDialog();
                DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xem chi tiết hóa đơn", "Xem chi tiết hóa đơn bán mã " + maHoaDon);
                busnkhd.AddNKHD(nkhd);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem.");
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            int sohoadon = dgvhdb.RowCount;
            string maHoaDon = "";
            bool found = true;
            while (found)
            {
                maHoaDon = "HDB" + sohoadon.ToString("D4") + "   ";
                found = false;

                // Kiểm tra xem mã hóa đơn có tồn tại trong datagridview hay không
                foreach (DataGridViewRow row in dgvhdb.Rows)
                {
                    if (row.Cells["MaHDB"].Value != null && row.Cells["MaHDB"].Value.ToString() == maHoaDon)
                    {
                        found = true;
                        sohoadon++; // Tăng số hóa đơn lên 1 nếu tìm thấy trùng mã
                        break;
                    }
                }
            }
            if (!found /*&& cbMaKH.Text !="" && cbMaNV.Text !=""*/)
            {
                DateTime dt = DateTime.Now;
                DTO_HoaDonBan hdb = new DTO_HoaDonBan(maHoaDon,MaNV, cbMaKH.Text, dt, 0, false);
                if (bushdb.addHDB(hdb))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvhdb.DataSource = bushdb.getHoaDonBan();
                    DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Tạo hóa đơn mới", "Tạo hóa đơn bán mới với mã " + maHoaDon);
                    busnkhd.AddNKHD(nkhd);
                    ChiTietHDB chiTietHDB = new ChiTietHDB();
                    chiTietHDB.SetMaHoaDonValue(maHoaDon, MaNV, cbMaKH.Text);
                    chiTietHDB.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên và mã khách hàng cần tạo hóa đơn");
            }
        }

        private void dgvhdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvhdb.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                // Hiện hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvhdb.SelectedRows[0];
                    string mahdb = row.Cells[1].Value.ToString();
                    if (bushdb.deleteHDB(mahdb))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvhdb.DataSource = bushdb.getHoaDonBan(); // refresh datagridview
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xóa hóa đơn bán", "Xóa hóa đơn bán mã " + mahdb);
                        busnkhd.AddNKHD(nkhd);
                    }
                    else
                    {
                        MessageBox.Show("Xóa ko thành công");
                    }
                }
            }
            
        }

        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            Funtion.ToExcel(dgvhdb, @"D:\LapTrinhCSDL\QLBK", "_QL_DanhSachHoaDon", " hoa don ban");
            MessageBox.Show("Xuất file Excel thành công");
            DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xuất file excel", "Xuất file hóa đơn bán");
            busnkhd.AddNKHD(nkhd);
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            if (bushdb.checkcbFind(cbFind.Text))
            {
                if (cbFind.Text != "" && txtFind.Text != "")
                {
                    dgvhdb.DataSource = bushdb.findHoaDon(cbFind.Text, txtFind.Text);
                    MessageBox.Show("Tìm kiếm thành công");
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập thông tin cần tìm");
                    dgvhdb.DataSource = bushdb.getHoaDonBan();
                }
            }
            else
            {
                MessageBox.Show("Giá trị loại cần tìm không hợp lệ");
            }
        }

        private void btnLocTT_Click(object sender, EventArgs e)
        {
            bool isPaid = checkbox1.Checked; // Kiểm tra giá trị của checkbox hoặc điều kiện trạng thái
            (dgvhdb.DataSource as DataTable).DefaultView.RowFilter = $"DaThanhToan = {isPaid}";
        }

        private void btnLocNgay_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtLoc.Value.Date;
            (dgvhdb.DataSource as DataTable).DefaultView.RowFilter = $"NgayXuatHDB = #{selectedDate:MM/dd/yyyy}#";
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            dgvhdb.DataSource = bushdb.getHoaDonBan();
        }

        private void dgvhdb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvhdb.Columns["DaThanhToan"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dgvhdb.Rows[e.RowIndex].Cells["DaThanhToan"];

                string maHoaDon = dgvhdb.SelectedRows[0].Cells["MaHDB"].Value.ToString();
                bool isChecked = (bool)checkBoxCell.EditedFormattedValue;
                int tongTien = Convert.ToInt32(dgvhdb.Rows[0].Cells["TongTienBan"].Value);
                string maKH = dgvhdb.SelectedRows[0].Cells["MaKH"].Value.ToString();

                bool trangThaiHienTai = bushdb.LayHoaDonHienTai(maHoaDon);

                if (!trangThaiHienTai && isChecked) // Chuyển từ chưa thanh toán sang đã thanh toán
                {
                    bushdb.CapNhatTrangThai(maHoaDon, true);
                    bushdb.CapNhatNoKhachHang(maKH, -tongTien);
                    checkBoxCell.Value = true;
                    DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Thanh toán", "Xác nhận khách hàng mã " + maKH+" đã thanh toán rồi");
                    busnkhd.AddNKHD(nkhd);
                }
                else if (trangThaiHienTai && !isChecked) // Cố gắng chuyển từ đã thanh toán sang chưa thanh toán
                {
                    MessageBox.Show("Hóa đơn đã thanh toán, không thể chuyển lại sang ghi nợ.");
                    checkBoxCell.Value = true;  // Giữ nguyên trạng thái đã thanh toán
                }
            }
        }

        private void dgvhdb_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra chỉ số hàng và cột phải hợp lệ
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvhdb.Columns[e.ColumnIndex].Name == "DaThanhToan")
                {
                    bool isPaid = Convert.ToBoolean(dgvhdb.Rows[e.RowIndex].Cells["DaThanhToan"].Value);

                    if (isPaid)
                    {
                        dgvhdb.Rows[e.RowIndex].Cells["DaThanhToan"].ReadOnly = true; // Không cho phép chỉnh sửa
                    }
                }
            }
        }
    }
}

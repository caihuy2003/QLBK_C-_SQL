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
    public partial class HoaDonNhap : Form
    {
        BUS_HoaDonNhap bushdn=new BUS_HoaDonNhap();
        BUS_ChiTietNhap buschitietnhap = new BUS_ChiTietNhap();
        BUS_NhatKyHoatDong busnkhd=new BUS_NhatKyHoatDong();
        private string MaNV;
        public HoaDonNhap(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            dgvhdn.DataSource = bushdn.getHoaDonNhap();
            dgvhdn.RowTemplate.Height = 30;
            dgvhdn.RowsDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dgvhdn.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateBlue;

            dgvhdn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tự động điều chỉnh kích thước cột cuối cùng để vừa với chiều rộng DataGridView
            dgvhdn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvhdn.RowTemplate.Height = 50;
            Image trashIcon = Properties.Resources.icons8_delete_50;
            Image resizedIcon = new Bitmap(trashIcon, new Size(20, 20));
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "DeleteColumn";
            imgColumn.HeaderText = "";
            imgColumn.Image = resizedIcon;
            imgColumn.Width = 10;
            //imgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvhdn.Columns.Add(imgColumn);
        }
   
        private void btnLocNgay_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtLoc.Value.Date;
            (dgvhdn.DataSource as DataTable).DefaultView.RowFilter = $"NgayXuatHDN = #{selectedDate:MM/dd/yyyy}#";
        }


        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            dgvhdn.DataSource = bushdn.getHoaDonNhap();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            int sohoadon = dgvhdn.RowCount;
            string maHoaDon = "";
            bool found = true;
            while (found)
            {
                maHoaDon = "HDN" + sohoadon.ToString("D4") + "   ";
                found = false;

                // Kiểm tra xem mã hóa đơn có tồn tại trong datagridview hay không
                foreach (DataGridViewRow row in dgvhdn.Rows)
                {
                    if (row.Cells["MaHDN"].Value != null && row.Cells["MaHDN"].Value.ToString() == maHoaDon)
                    {
                        found = true;
                        sohoadon++; // Tăng số hóa đơn lên 1 nếu tìm thấy trùng mã
                        break;
                    }
                }
            }
            if (!found)
            {
                DateTime dt = DateTime.Now;
                DTO_HoaDonNhap hdn = new DTO_HoaDonNhap(maHoaDon, MaNV, dt, 0);
                if (bushdn.addHDN(hdn))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvhdn.DataSource = bushdn.getHoaDonNhap();
                    DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Tạo hóa đơn mới", "Tạo hóa đơn nhập mới với mã " + maHoaDon);
                    busnkhd.AddNKHD(nkhd);
                    ChiTietHDN chiTietHDN = new ChiTietHDN();
                    chiTietHDN.SetMaHoaDonValue(maHoaDon, MaNV);
                    chiTietHDN.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
        }

        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            Funtion.ToExcel(dgvhdn, @"D:\LapTrinhCSDL\QLBK", "_QL_DanhSachHoaDon", " hoa don nhap");
            MessageBox.Show("Xuất file Excel thành công");
            DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xuất file excel", "Xuất file hóa đơn nhập");
            busnkhd.AddNKHD(nkhd);
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            if (bushdn.checkcbFind(cbFind.Text))
            {
                if (cbFind.Text != "" && txtFind.Text != "")
                {
                    dgvhdn.DataSource = bushdn.findHoaDon(cbFind.Text, txtFind.Text);
                    MessageBox.Show("Tìm kiếm thành công");
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập thông tin cần tìm");
                    dgvhdn.DataSource = bushdn.getHoaDonNhap();
                }
            }
            else
            {
                MessageBox.Show("Giá trị loại cần tìm không hợp lệ");
            }
        }

        private void dgvhdn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvhdn.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                // Hiện hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvhdn.SelectedRows[0];
                    string mahd = row.Cells[1].Value.ToString();
                    if (bushdn.deleteHDN(mahd))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvhdn.DataSource = bushdn.getHoaDonNhap(); // refresh datagridview
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xóa hóa đơn nhập", "Xóa hóa đơn nhập mã " + mahd);
                        busnkhd.AddNKHD(nkhd);
                    }
                    else
                    {
                        MessageBox.Show("Xóa ko thành công");
                    }
                }
            }
        }

        private void dgvhdn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvhdn.SelectedRows.Count > 0)
            {
                string maHoaDon = dgvhdn.SelectedRows[0].Cells["MaHDN"].Value.ToString();
                DateTime ngay = (DateTime)dgvhdn.SelectedRows[0].Cells["NgayXuatHDN"].Value;
                int tongtien = (int)dgvhdn.SelectedRows[0].Cells["TongTienNhap"].Value;
                DanhSachCT_HDN ds = new DanhSachCT_HDN();
                ds.SetValue(maHoaDon, MaNV, ngay, tongtien);
                ds.ShowDialog();
                DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xem chi tiết hóa đơn", "Xem chi tiết hóa đơn nhập mã " + maHoaDon);
                busnkhd.AddNKHD(nkhd);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem.");
            }
        }
    }
}

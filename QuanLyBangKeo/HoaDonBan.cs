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
        public HoaDonBan()
        {
            InitializeComponent();
        }

        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            dgvhdb.DataSource = bushdb.getHoaDonBan();
            cbMaNV.DataSource = bushdb.GetMaNV();
            cbMaKH.DataSource = bushdb.GetMaKH();
            int totalWidth = dgvhdb.Width - dgvhdb.RowHeadersWidth;
            int columnCount = dgvhdb.Columns.Count;
            int averageWidth = totalWidth / columnCount;

            // Gán kích thước trung bình cho mỗi cột
            foreach (DataGridViewColumn column in dgvhdb.Columns)
            {
                column.Width = averageWidth;
            }
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manv = cbMaNV.SelectedItem.ToString();
            string[] thongTinNV = bushdb.LayThongTinNV(manv); 

            txtTenNV.Text = thongTinNV[0];
        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makh = cbMaKH.SelectedItem.ToString(); // Lấy mã khách hàng từ ComboBox
            string[] thongTinKH = bushdb.LayThongTinKH(makh); 

            txtTenKH.Text = thongTinKH[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sohoadon = dgvhdb.RowCount;
            string maHoaDon = "";
            bool found = true;
            while (found)
            {
                maHoaDon = "HDB" + sohoadon.ToString("D3") + "    ";
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
                DTO_HoaDonBan hdb = new DTO_HoaDonBan(maHoaDon, cbMaNV.Text,cbMaKH.Text, dt, 0);
                if (bushdb.addHDB(hdb))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvhdb.DataSource = bushdb.getHoaDonBan();
                    ChiTietHDB chiTietHDB = new ChiTietHDB();
                    chiTietHDB.SetMaHoaDonValue(maHoaDon, cbMaNV.Text,cbMaKH.Text);
                    chiTietHDB.ShowDialog();
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

        private void btnSee_Click(object sender, EventArgs e)
        {
            ReportHDB rphdb = new ReportHDB();
            rphdb.Show();
            if (dgvhdb.SelectedRows.Count > 0)
            {
                string maHoaDon = dgvhdb.SelectedRows[0].Cells[0].Value.ToString();
                DateTime ngay = (DateTime)dgvhdb.SelectedRows[0].Cells[3].Value;
                int tongtien = (int)dgvhdb.SelectedRows[0].Cells[4].Value;
                DanhSachCT_HDB ds = new DanhSachCT_HDB();
                ds.SetValue(maHoaDon, cbMaNV.Text, cbMaKH.Text,ngay,tongtien);
                ds.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvhdb.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvhdb.SelectedRows[0];
                string maHoaDon = dgvhdb.SelectedRows[0].Cells["MaHDB"].Value.ToString();
                // Xóa
                busct_hdb.deleteChiTietHDB(maHoaDon);
                if (bushdb.deleteHDB(maHoaDon))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvhdb.DataSource = bushdb.getHoaDonBan();
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Funtion.ToExcel(dgvhdb, @"D:\LapTrinhCSDL\QLBK", "_QL_DanhSachHoaDon", " hoa don ban");
            MessageBox.Show("Xuất file Excel thành công");
        }

        private void btnFind_Click(object sender, EventArgs e)
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
    }
}

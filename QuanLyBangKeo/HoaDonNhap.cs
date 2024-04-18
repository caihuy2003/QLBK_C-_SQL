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

        public HoaDonNhap()
        {
            InitializeComponent();
        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            dgvhdn.DataSource = bushdn.getHoaDonNhap();
            cbMaNV.DataSource = bushdn.GetMaNV();
            int totalWidth = dgvhdn.Width - dgvhdn.RowHeadersWidth;
            int columnCount = dgvhdn.Columns.Count;
            int averageWidth = totalWidth / columnCount;

            // Gán kích thước trung bình cho mỗi cột
            foreach (DataGridViewColumn column in dgvhdn.Columns)
            {
                column.Width = averageWidth;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sohoadon=dgvhdn.RowCount;
            string maHoaDon="";
            bool found=true;
            while (found)
            {
                maHoaDon = "HDN" + sohoadon.ToString("D3")+"    ";
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
                DTO_HoaDonNhap hdn = new DTO_HoaDonNhap(maHoaDon, cbMaNV.Text, dt, 0);
                if (bushdn.addHDN(hdn))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvhdn.DataSource = bushdn.getHoaDonNhap();
                    ChiTietHDN chiTietHDN = new ChiTietHDN();
                    chiTietHDN.SetMaHoaDonValue(maHoaDon, cbMaNV.Text);
                    chiTietHDN.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manv = cbMaNV.SelectedItem.ToString(); // Lấy mã khách hàng từ ComboBox
            string[] thongTinNV = bushdn.LayThongTinNV(manv);

            txtTenNV.Text = thongTinNV[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvhdn.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvhdn.SelectedRows[0];
                string maHoaDon = dgvhdn.SelectedRows[0].Cells["MaHDN"].Value.ToString();
                // Xóa
                buschitietnhap.deleteChiTietNhap(maHoaDon);
                if (bushdn.deleteHDN(maHoaDon))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvhdn.DataSource = bushdn.getHoaDonNhap();
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

        private void btnEdit_Click(object sender, EventArgs e)//btn_Xem danh sach
        {
            if (dgvhdn.SelectedRows.Count > 0)
            {
                string maHoaDon = dgvhdn.SelectedRows[0].Cells[0].Value.ToString();
                DateTime ngay = (DateTime)dgvhdn.SelectedRows[0].Cells[2].Value;
                int tongtien= (int)dgvhdn.SelectedRows[0].Cells[3].Value;
                DanhSachCT_HDN ds=new DanhSachCT_HDN();
                ds.SetValue(maHoaDon, cbMaNV.Text,ngay,tongtien);
                ds.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem.");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Funtion.ToExcel(dgvhdn, @"D:\LapTrinhCSDL\QLBK", "_QL_DanhSachHoaDon", " hoa don nhap");
            MessageBox.Show("Xuất file Excel thành công");
        }

        private void btnFind_Click(object sender, EventArgs e)
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
    }
}

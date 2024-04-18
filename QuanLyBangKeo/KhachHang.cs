using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLyBK;
using BUS_QuanLyBK;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Xml.Linq;

namespace QuanLyBangKeo
{
    public partial class KhachHang : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();

        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = busKH.getKhachHang();

            int totalWidth = dgvKH.Width - dgvKH.RowHeadersWidth;
            int columnCount = dgvKH.Columns.Count;
            int averageWidth = totalWidth / columnCount;

            // Gán kích thước trung bình cho mỗi cột
            foreach (DataGridViewColumn column in dgvKH.Columns)
            {
                column.Width = averageWidth;
            }
        }

        private void dgvKH_Click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvKH.SelectedRows[0];
            txtMaKH.Text = row.Cells[1].Value.ToString();
            txtTenKH.Text = row.Cells[2].Value.ToString();
            txtSDT_KH.Text = row.Cells[3].Value.ToString();
            txtDiaChiKH.Text = row.Cells[4].Value.ToString();
            cbGioiTinh.Text = row.Cells[5].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!busKH.KiemTraTrungMaKhachHang(txtMaKH.Text))
            {
                if (busKH.IsComboBoxValueValid(cbGioiTinh.Text))
                {
                    if (txtMaKH.Text != "" && txtTenKH.Text != "" && txtDiaChiKH.Text != "")
                    {
                        // Tạo DTo
                        DTO_KhachHang KH = new DTO_KhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChiKH.Text, txtSDT_KH.Text, cbGioiTinh.Text);
                        if (busKH.addKhachHang(KH))
                        {
                            MessageBox.Show("Thêm thành công");
                            dgvKH.DataSource = busKH.getKhachHang(); // refresh datagridview
                        }
                        else
                        {
                            MessageBox.Show("Thêm ko thành công");
                        }
                        ResetValue();
                    }
                    else
                    {
                        MessageBox.Show("Xin hãy nhập đầy đủ");
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị giới tính không hợp lệ");
                }
            }
            else
            {
                MessageBox.Show("Mã khách hàng đã có");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0)
            {
                    if (busKH.IsComboBoxValueValid(cbGioiTinh.Text))
                    {
                        if (txtMaKH.Text != "" && txtTenKH.Text != "" && txtDiaChiKH.Text != "")
                        {
                            // Lấy row hiện tại
                            DataGridViewRow row = dgvKH.SelectedRows[0];
                            // Tạo DTo
                            DTO_KhachHang KH = new DTO_KhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChiKH.Text, txtSDT_KH.Text, cbGioiTinh.Text);
                            // Sửa
                            if (busKH.editKhachHang(KH))
                            {
                                MessageBox.Show("Sửa thành công");
                                dgvKH.DataSource = busKH.getKhachHang(); // refresh datagridview
                            }
                            else
                            {
                                MessageBox.Show("Sửa ko thành công");
                            }
                            ResetValue();
                        }
                        else
                        {
                            MessageBox.Show("Xin hãy nhập đầy đủ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá trị giới tính không hợp lệ");
                    }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvKH.SelectedRows[0];
                // Xóa
                if (busKH.deleteKhachHang(txtMaKH.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvKH.DataSource = busKH.getKhachHang();
                    txtMaKH.ReadOnly= false;
                    ResetValue();
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
            Funtion.ToExcel(dgvKH, @"D:\LapTrinhCSDL\QLBK", "_QL_KH", "KHách hàng");
            MessageBox.Show("Xuất file Excel thành công");
        }

        private void btnCanCle_Click(object sender, EventArgs e)
        {
            ResetValue();
            dgvKH.DataSource = busKH.getKhachHang();
            txtMaKH.ReadOnly = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (busKH.checkcbFind(cbFind.Text))
            {
                if (cbFind.Text != "" && txtFind.Text != "")
                {
                    dgvKH.DataSource = busKH.findKhachHang(cbFind.Text, txtFind.Text);
                    MessageBox.Show("Tìm kiếm thành công");
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập thông tin cần tìm");
                    ResetValue();
                    dgvKH.DataSource = busKH.getKhachHang();
                }
            }
            else
            {
                MessageBox.Show("Giá trị loại cần tìm không hợp lệ");
            }
        }
        private void ResetValue()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT_KH.Text = "";
            txtFind.Text = "";
            cbFind.SelectedIndex = -1;
            txtDiaChiKH.Text = "";
            cbGioiTinh.Text = "";
        }

        private void dgvKH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                DataGridViewRow selectedRow = dgvKH.SelectedRows[0];

                // Lấy dữ liệu từ các ô cột của dòng được chọn
                string maKH = selectedRow.Cells["MaKH"].Value.ToString();
                string tenKH = selectedRow.Cells["TenKH"].Value.ToString();
                string diaChi = selectedRow.Cells["DiaChiKH"].Value.ToString();
                string soDienThoai = selectedRow.Cells["SDT_KH"].Value.ToString();
                string gioiTinh = selectedRow.Cells["GioiTinhKH"].Value.ToString();

                // Gán dữ liệu lên các TextBox tương ứng
                txtMaKH.Text = maKH;
                txtMaKH.ReadOnly = true;
                txtTenKH.Text = tenKH;
                txtDiaChiKH.Text = diaChi;
                txtSDT_KH.Text = soDienThoai;
                cbGioiTinh.Text = gioiTinh;
            }
        }
    }
}

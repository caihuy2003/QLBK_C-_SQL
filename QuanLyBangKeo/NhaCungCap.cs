using BUS_QuanLyBK;
using DTO_QuanLyBK;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
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
    public partial class NhaCungCap : Form
    {
        BUS_NhaCungCap busNCC = new BUS_NhaCungCap();

        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = busNCC.getNhaCungCap();
            int totalWidth = dgvNCC.Width - dgvNCC.RowHeadersWidth;
            int columnCount = dgvNCC.Columns.Count;
            int averageWidth = totalWidth / columnCount;

            // Gán kích thước trung bình cho mỗi cột
            foreach (DataGridViewColumn column in dgvNCC.Columns)
            {
                column.Width = averageWidth;
            }
        }

        private void dgvNCC_Click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNCC.SelectedRows[0];
            txtMaNCC.Text = row.Cells[1].Value.ToString();
            txtTenNCC.Text = row.Cells[2].Value.ToString();
            txtSDT_NCC.Text = row.Cells[3].Value.ToString();
            txtDiaChiNCC.Text = row.Cells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!busNCC.KiemTraMaNhaCungCap(txtMaNCC.Text))
            {
                if (txtMaNCC.Text != "" && txtTenNCC.Text != "" && txtDiaChiNCC.Text != "")
                {
                    // Tạo DTo
                    DTO_NhaCungCap ncc = new DTO_NhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChiNCC.Text, txtSDT_NCC.Text);
                    if (busNCC.addNhaCungCap(ncc))
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvNCC.DataSource = busNCC.getNhaCungCap(); // refresh datagridview
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
                MessageBox.Show("Mã nhà cung cấp đã có rồi");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count > 0)
            {
                    if (txtTenNCC.Text != "" && txtDiaChiNCC.Text != "")
                    {
                        // Lấy row hiện tại
                        DataGridViewRow row = dgvNCC.SelectedRows[0];
                        // Tạo DTO
                        DTO_NhaCungCap ncc = new DTO_NhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChiNCC.Text, txtSDT_NCC.Text);
                        // Sửa
                        if (busNCC.editNhaCungCap(ncc))
                        {
                            MessageBox.Show("Sửa thành công");
                            dgvNCC.DataSource = busNCC.getNhaCungCap();
                        }
                        else
                        {
                            MessageBox.Show("Sửa ko thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xin hãy nhập đầy đủ");
                    }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvNCC.SelectedRows[0];
                // Xóa
                if (busNCC.deleteNhaCungCap(txtMaNCC.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvNCC.DataSource = busNCC.getNhaCungCap();
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
            Funtion.ToExcel(dgvNCC, @"D:\LapTrinhCSDL\QLBK", "_QL_NCC", "nhà cung cấp");
            MessageBox.Show("Xuất file Excel thành công");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            ResetValue();
            dgvNCC.DataSource = busNCC.getNhaCungCap();
            txtMaNCC.ReadOnly = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (busNCC.checkcbFind(cbFind.Text))
            {
                if (cbFind.Text != "" && txtFind.Text != "")
                {
                    dgvNCC.DataSource = busNCC.findNhaCungCap(cbFind.Text, txtFind.Text);
                    MessageBox.Show("Tìm kiếm thành công");
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập thông tin cần tìm");
                    ResetValue();
                    dgvNCC.DataSource = busNCC.getNhaCungCap();
                }
            }
            else
            {
                MessageBox.Show("Giá trị loại cần tìm không hợp lệ");
            }
        }
        private void ResetValue()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDT_NCC.Text = "";
            txtFind.Text = "";
            cbFind.SelectedIndex = -1;
            txtDiaChiNCC.Text = "";
        }

        private void dgvNCC_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                DataGridViewRow selectedRow = dgvNCC.SelectedRows[0];

                // Lấy dữ liệu từ các ô cột của dòng được chọn
                string maNCC = selectedRow.Cells["MaNCC"].Value.ToString();
                string tenNCC = selectedRow.Cells["TenNCC"].Value.ToString();
                string diaChi = selectedRow.Cells["DiaChiNCC"].Value.ToString();
                string soDienThoai = selectedRow.Cells["SDTNCC"].Value.ToString();

                // Gán dữ liệu lên các TextBox tương ứng
                txtMaNCC.Text = maNCC;
                txtMaNCC.ReadOnly = true;
                txtTenNCC.Text = tenNCC;
                txtDiaChiNCC.Text = diaChi;
                txtSDT_NCC.Text = soDienThoai;
            }
        }
    }
}

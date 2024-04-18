using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS_QuanLyBK;
using DTO_QuanLyBK;
using System.Xml.Linq;

namespace QuanLyBangKeo
{
    public partial class LoaiSanPham : Form
    {
        BUS_LoaiSanPham busLSP = new BUS_LoaiSanPham();
        public LoaiSanPham()
        {
            InitializeComponent();
        }
        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            dgvLoaiSanPham.DataSource = busLSP.getLoaiSanPham();

            int totalWidth = dgvLoaiSanPham.Width - dgvLoaiSanPham.RowHeadersWidth;
            int columnCount = dgvLoaiSanPham.Columns.Count;
            int averageWidth = totalWidth / columnCount;

            // Gán kích thước trung bình cho mỗi cột
            foreach (DataGridViewColumn column in dgvLoaiSanPham.Columns)
            {
                column.Width = averageWidth;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!busLSP.KiemTraMaLoaiSanPham(txtMaLSP.Text))
            {
                if (txtTenLSP.Text != "" && txtMoTa.Text != "" && txtMaLSP.Text != "")
                {
                    // Tạo DTo
                    DTO_LoaiSanPham lsp = new DTO_LoaiSanPham(txtMaLSP.Text, txtTenLSP.Text, txtMoTa.Text);
                    if (busLSP.addLoaiSanPham(lsp))
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvLoaiSanPham.DataSource = busLSP.getLoaiSanPham(); // refresh datagridview
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
                MessageBox.Show("Mã loại sản phẩm đã có rồi");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvLoaiSanPham.SelectedRows.Count > 0)
            {
                if (txtTenLSP.Text != "" && txtMoTa.Text != "" && txtMaLSP.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvLoaiSanPham.SelectedRows[0];
                    // Tạo DTo
                    DTO_LoaiSanPham lsp = new DTO_LoaiSanPham(txtMaLSP.Text, txtTenLSP.Text, txtMoTa.Text);
                    // Sửa
                    if (busLSP.editLoaiSanPham(lsp))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvLoaiSanPham.DataSource = busLSP.getLoaiSanPham(); // refresh datagridview
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

        private void btnCancle_Click(object sender, EventArgs e)
        {
            ResetValue();
            dgvLoaiSanPham.DataSource = busLSP.getLoaiSanPham();
            txtMaLSP.ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLoaiSanPham.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvLoaiSanPham.SelectedRows[0];
                if (busLSP.deleteLoaiSanPham(txtMaLSP.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvLoaiSanPham.DataSource = busLSP.getLoaiSanPham(); // refresh datagridview
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

        private void dgvLoaiSanPham_Click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvLoaiSanPham.SelectedRows[0];
            txtMaLSP.Text = row.Cells[1].Value.ToString();
            txtTenLSP.Text = row.Cells[2].Value.ToString();
            txtMoTa.Text = row.Cells[3].Value.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (busLSP.checkcbFind(cbFind.Text))
            {
                if (cbFind.Text != "" && txtFind.Text != "")
                {
                    dgvLoaiSanPham.DataSource = busLSP.findLoaiSanPham(cbFind.Text, txtFind.Text);
                    MessageBox.Show("Tìm kiếm thành công");
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập thông tin cần tìm");
                    ResetValue();
                    dgvLoaiSanPham.DataSource = busLSP.getLoaiSanPham();
                }
            }
           else
            {
                MessageBox.Show("Giá trị loại cần tìm không hợp lệ");
            }
        }
        private void ResetValue()
        {
            txtMaLSP.Text = "";
            txtTenLSP.Text = "";
            txtMoTa.Text = "";
            txtFind.Text = "";
            cbFind.SelectedIndex = -1;
        }

        private void dgvLoaiSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiSanPham.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                DataGridViewRow selectedRow = dgvLoaiSanPham.SelectedRows[0];

                // Lấy dữ liệu từ các ô cột của dòng được chọn
                string maLSP = selectedRow.Cells["MaLSP"].Value.ToString();
                string tenLSP = selectedRow.Cells["TenLSP"].Value.ToString();
                string Mota = selectedRow.Cells["MoTa"].Value.ToString();

                // Gán dữ liệu lên các TextBox tương ứng
                txtMaLSP.Text = maLSP;
                txtMaLSP.ReadOnly = true;
                txtTenLSP.Text = tenLSP;
                txtMoTa.Text = Mota;
            }
        }
    }
}

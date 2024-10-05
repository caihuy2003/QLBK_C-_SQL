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
        BUS_NhatKyHoatDong busnkhd=new BUS_NhatKyHoatDong();
        private string MaNV;
        public NhaCungCap(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = busNCC.getNhaCungCap();
            dgvNCC.RowTemplate.Height = 30;
            dgvNCC.RowsDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dgvNCC.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateBlue;
            dgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Tự động điều chỉnh kích thước cột cuối cùng để vừa với chiều rộng DataGridView
            dgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNCC.Columns["DiaChiNCC"].Width = 200;
            dgvNCC.Columns["MaNCC"].Width = 100;
            Image trashIcon = Properties.Resources.icons8_delete_50;
            Image resizedIcon = new Bitmap(trashIcon, new Size(20, 20));
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "DeleteColumn";
            imgColumn.HeaderText = "";
            imgColumn.Image = resizedIcon;
            imgColumn.Width = 10;
            //imgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNCC.Columns.Add(imgColumn);
        }

    
        private void ResetValue()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDT_NCC.Text = "";
            txtFind.Text = "";
            cbFind.SelectedIndex = -1;
            txtDiaChi_NCC.Text = "";
            txtGhiChu.Text = "";
        }

        private void dgvNCC_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNCC.SelectedRows[0];
            txtMaNCC.Text = row.Cells[1].Value.ToString();
            txtTenNCC.Text = row.Cells[2].Value.ToString();
            txtSDT_NCC.Text = row.Cells[3].Value.ToString();
            txtDiaChi_NCC.Text = row.Cells[4].Value.ToString();
            txtGhiChu.Text = row.Cells[5].Value.ToString();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!busNCC.KiemTraMaNhaCungCap(txtMaNCC.Text))
            {
                if (txtMaNCC.Text != "" && txtTenNCC.Text != "" && txtDiaChi_NCC.Text != "")
                {
                    // Tạo DTo
                    DTO_NhaCungCap ncc = new DTO_NhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi_NCC.Text, txtSDT_NCC.Text,txtGhiChu.Text);
                    if (busNCC.addNhaCungCap(ncc))
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvNCC.DataSource = busNCC.getNhaCungCap(); // refresh datagridview
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Thêm nhà cung cấp", "Thêm nhà cung cấp mã " + txtMaNCC.Text);
                        busnkhd.AddNKHD(nkhd);
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

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count > 0)
            {
                if (txtTenNCC.Text != "" && txtDiaChi_NCC.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvNCC.SelectedRows[0];
                    // Tạo DTO
                    DTO_NhaCungCap ncc = new DTO_NhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi_NCC.Text, txtSDT_NCC.Text,txtGhiChu.Text);
                    // Sửa
                    if (busNCC.editNhaCungCap(ncc))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvNCC.DataSource = busNCC.getNhaCungCap();
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Sửa nhà cung cấp", "Sửa thông tin nhà cung cấp mã " + txtMaNCC.Text);
                        busnkhd.AddNKHD(nkhd);
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

        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            Funtion.ToExcel(dgvNCC, @"E:\", "_QL_NCC", "nhà cung cấp");
            MessageBox.Show("Xuất file Excel thành công");
            DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xuất file excel", "Xuất file nhà cung cấp");
            busnkhd.AddNKHD(nkhd);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetValue();
            dgvNCC.DataSource = busNCC.getNhaCungCap();
            txtMaNCC.ReadOnly = false;
        }

        private void btnFind_Click_1(object sender, EventArgs e)
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

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvNCC.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                // Hiện hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvNCC.SelectedRows[0];
                    string maNCC = row.Cells[1].Value.ToString();
                    if (busNCC.deleteNhaCungCap(maNCC))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvNCC.DataSource = busNCC.getNhaCungCap(); // refresh datagridview
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xóa nhà cung cấp", "Xóa nhà cung cấp mã " + maNCC);
                        busnkhd.AddNKHD(nkhd);
                    }
                    else
                    {
                        MessageBox.Show("Xóa ko thành công");
                    }
                }
            }
        }

        private void txtSDT_NCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txtSDT_NCC.Focus();
            }
        }
    }
}

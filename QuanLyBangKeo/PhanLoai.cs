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
using Guna.UI2.WinForms;

namespace QuanLyBangKeo
{
    public partial class PhanLoai : Form
    {
        BUS_LoaiSanPham busLSP = new BUS_LoaiSanPham();
        BUS_LoaiKhachHang busLKH=new BUS_LoaiKhachHang();
        BUS_NhatKyHoatDong busnkhd=new BUS_NhatKyHoatDong();
        private string MaNV;
        public PhanLoai(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }
        private void ResetValue()
        {
            txtMaLKH.Text = "";
            txtTenLKH.Text = "";
            txtFind.Text = "";
            txtMaLSP.Text = "";
            txtTenLSP.Text = "";
            cbFind.SelectedIndex = -1;
        }
        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            dgvLoaiSanPham.DataSource = busLSP.getLoaiSanPham();
            dgvLoaiKhachHang.DataSource=busLKH.getLoaiKhachHang();
            int totalWidth = dgvLoaiSanPham.Width - dgvLoaiSanPham.RowHeadersWidth;
            int columnCount = dgvLoaiSanPham.Columns.Count;
            int averageWidth = totalWidth / columnCount;
            dgvLoaiSanPham.RowTemplate.Height = 30;
            dgvLoaiSanPham.RowsDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dgvLoaiSanPham.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateBlue;
            dgvLoaiKhachHang.RowTemplate.Height = 30;
            dgvLoaiKhachHang.RowsDefaultCellStyle.BackColor = Color.DarkGreen;
            dgvLoaiKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOliveGreen;
            // Gán kích thước trung bình cho mỗi cột
            foreach (DataGridViewColumn column in dgvLoaiSanPham.Columns)
            {
                column.Width = averageWidth;
            }
            foreach (DataGridViewColumn column in dgvLoaiKhachHang.Columns)
            {
                column.Width = averageWidth;
            }
            Image trashIcon =Properties.Resources.icons8_delete_50;
            Image resizedIcon = new Bitmap(trashIcon, new Size(20, 20));
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "DeleteColumn";
            imgColumn.HeaderText = "";
            imgColumn.Image = resizedIcon;
            imgColumn.Width = 10;
            //imgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLoaiSanPham.Columns.Add(imgColumn);
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "DeleteColumn";
            img.HeaderText = "";
            img.Image = resizedIcon;
            img.Width = 10;
            dgvLoaiKhachHang.Columns.Add(img);
        }
       


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!busLKH.KiemTraMaLoaiKhachHang(txtMaLKH.Text))
            {
                if (txtTenLKH.Text != "" && txtMaLKH.Text != "")
                {
                    // Tạo DTo
                    DTO_LoaiKhachHang lkh = new DTO_LoaiKhachHang(txtMaLKH.Text, txtTenLKH.Text);
                    if (busLKH.addLoaiKhachHang(lkh))
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvLoaiKhachHang.DataSource = busLKH.getLoaiKhachHang(); // refresh datagridview
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now,"Thêm loại khách hàng","Thêm loại khách hàng mã "+txtMaLKH.Text);
                        busnkhd.AddNKHD(nkhd);

                    }
                    else
                    {
                        MessageBox.Show("Thêm ko thành công");
                    }
                    txtMaLKH.Text = "";
                    txtTenLKH.Text = "";
                    txtFind.Text = "";
                    cbFind.SelectedIndex = -1;
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


        private void btnAdd_LSP_Click(object sender, EventArgs e)
        {
            if (!busLSP.KiemTraMaLoaiSanPham(txtMaLKH.Text))
            {
                if (txtTenLSP.Text != "" && txtMaLSP.Text != "")
                {
                    // Tạo DTo
                    DTO_LoaiSanPham lsp = new DTO_LoaiSanPham(txtMaLSP.Text, txtTenLSP.Text);
                    if (busLSP.addLoaiSanPham(lsp))
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvLoaiSanPham.DataSource = busLSP.getLoaiSanPham(); // refresh datagridview
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Thêm loại sản phẩm", "Thêm loại sản phẩm mã " + txtMaLSP.Text);
                        busnkhd.AddNKHD(nkhd);
                    }
                    else
                    {
                        MessageBox.Show("Thêm ko thành công");
                    }

                    txtFind.Text = "";
                    txtMaLSP.Text = "";
                    txtTenLSP.Text = "";
                    cbFind.SelectedIndex = -1;
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

        private void btnEdit_LSP_Click(object sender, EventArgs e)
        {
            if (dgvLoaiSanPham.SelectedRows.Count > 0)
            {
                if (txtTenLSP.Text != "" && txtMaLSP.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvLoaiSanPham.SelectedRows[0];
                    string TenCu= row.Cells["Tên loại sản phẩm"].Value.ToString();
                    // Tạo DTo
                    DTO_LoaiSanPham lsp = new DTO_LoaiSanPham(txtMaLSP.Text, txtTenLSP.Text);
                    // Sửa
                    if (busLSP.editLoaiSanPham(lsp))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvLoaiSanPham.DataSource = busLSP.getLoaiSanPham(); // refresh datagridview
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Sửa loại sản phẩm", "Sửa loại sản phẩm mã " + txtMaLSP.Text+"từ "+TenCu+" thành "+txtTenLSP.Text);
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

        private void btnCancel_LSP_Click(object sender, EventArgs e)
        {
            txtFind.Text = " ";
            txtMaLSP.Text = " ";
            txtTenLSP.Text = " ";
            cbFind.SelectedIndex = -1;
            dgvLoaiSanPham.DataSource = busLSP.getLoaiSanPham();
            txtMaLSP.ReadOnly = false;
        }


        private void dgvLoaiSanPham_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvLoaiSanPham.SelectedRows[0];
            txtMaLSP.Text = row.Cells[1].Value.ToString();
            txtTenLSP.Text = row.Cells[2].Value.ToString();
        }

        private void dgvLoaiSanPham_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLoaiSanPham.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                // Hiện hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvLoaiSanPham.SelectedRows[0];
                    string MaLSP = row.Cells[1].Value.ToString();
                    if (busLSP.deleteLoaiSanPham(MaLSP))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvLoaiSanPham.DataSource = busLSP.getLoaiSanPham(); // refresh datagridview
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xóa loại sản phẩm", "Xóa loại sản phẩm mã " + MaLSP);
                        busnkhd.AddNKHD(nkhd);
                    }
                    else
                    {
                        MessageBox.Show("Xóa ko thành công");
                    }
                }
            }
        }

        private void btnFind_Click_1(object sender, EventArgs e)
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
            else if (busLKH.checkcbFind(cbFind.Text))
            {
                if (cbFind.Text != "" && txtFind.Text != "")
                {
                    dgvLoaiKhachHang.DataSource = busLKH.findLoaiKhachHang(cbFind.Text, txtFind.Text);
                    MessageBox.Show("Tìm kiếm thành công");
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập thông tin cần tìm");
                    ResetValue();
                    dgvLoaiKhachHang.DataSource = busLKH.getLoaiKhachHang();
                }
            }
            else
            {
                MessageBox.Show("Giá trị loại cần tìm không hợp lệ");
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvLoaiKhachHang.SelectedRows.Count > 0)
            {
                if (txtTenLKH.Text != "" && txtMaLKH.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvLoaiKhachHang.SelectedRows[0];
                    string TenCu=row.Cells["Tên loại khách hàng"].Value.ToString();
                    // Tạo DTo
                    DTO_LoaiKhachHang lkh = new DTO_LoaiKhachHang(txtMaLKH.Text, txtTenLKH.Text);
                    // Sửa
                    if (busLKH.editLoaiKhachHang(lkh))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvLoaiKhachHang.DataSource = busLKH.getLoaiKhachHang(); // refresh datagridview
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Sửa loại khách hàng", "Sửa loại khách hàng mã " + txtMaLKH.Text + "từ " + TenCu + " thành " + txtTenLKH.Text);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaLKH.Text = " ";
            txtTenLKH.Text =  " ";
            txtFind.Text = " ";
            cbFind.SelectedIndex = -1;
            dgvLoaiKhachHang.DataSource = busLKH.getLoaiKhachHang();
            txtMaLKH.ReadOnly = false;
        }

        private void dgvLoaiKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLoaiKhachHang.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                // Hiện hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvLoaiKhachHang.SelectedRows[0];
                    string MaLKH = row.Cells[1].Value.ToString();
                    if (busLKH.deleteLoaiKhachHang(MaLKH))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvLoaiKhachHang.DataSource = busLKH.getLoaiKhachHang(); // refresh datagridview
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xóa loại khách hàng", "Xóa loại khách hàng mã " + MaLKH);
                        busnkhd.AddNKHD(nkhd);
                    }
                    else
                    {
                        MessageBox.Show("Xóa ko thành công");
                    }
                }
            }
        }

        private void dgvLoaiKhachHang_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvLoaiKhachHang.SelectedRows[0];
            txtMaLKH.Text = row.Cells[1].Value.ToString();
            txtTenLKH.Text = row.Cells[2].Value.ToString();
        }
    }
}

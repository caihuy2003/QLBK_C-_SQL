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
using System.IO;

namespace QuanLyBangKeo
{
    public partial class SanPham : Form
    {
        BUS_SanPham busSP = new BUS_SanPham();
        public SanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            dgvSP.DataSource = busSP.getSanPham();
            cbMaNCC.DataSource = busSP.GetMaNhaCungCap();
            cbMaLSP.DataSource = busSP.GetMaLoaiSanPham();
            int totalWidth = dgvSP.Width - dgvSP.RowHeadersWidth;
            int columnCount = dgvSP.Columns.Count;
            int averageWidth = totalWidth / columnCount;

            // Gán kích thước trung bình cho mỗi cột
            foreach (DataGridViewColumn column in dgvSP.Columns)
            {
                column.Width = averageWidth;
            }
            dgvSP.RowTemplate.Height = 50;

        }

        private void dgvSP_Click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvSP.SelectedRows[0];
            txtMaSP.Text = row.Cells[1].Value.ToString();
            cbMaNCC.Text = row.Cells[2].Value.ToString();
            cbMaLSP.Text = row.Cells[3].Value.ToString();
            txtTenSP.Text = row.Cells[4].Value.ToString();
            txtSoLuong.Text = row.Cells[5].Value.ToString();
            txtDVT.Text = row.Cells[6].Value.ToString();
            txtDGNhap.Text = row.Cells[7].Value.ToString();
            txtDGBan.Text = row.Cells[8].Value.ToString();
        }

        private void hinhAnhPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                hinhAnhPictureBox.Image = Image.FromFile(open.FileName);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            if (!busSP.KiemTraTrungMaSanPham(txtMaSP.Text))
            {
                if (txtMaSP.Text != "" && txtTenSP.Text != "")
                {
                    if (busSP.KiemTraTonTaiMaNCC(cbMaNCC.Text) && busSP.KiemTraTonTaiMaLSP(cbMaLSP.Text))
                    {
                        int soLuong, DGNhap, DGBan;

                        if (int.TryParse(txtSoLuong.Text, out soLuong) && int.TryParse(txtDGNhap.Text, out DGNhap) && int.TryParse(txtDGBan.Text, out DGBan))
                        {
                            soLuong = Convert.ToInt32(txtSoLuong.Text);
                            DGNhap = Convert.ToInt32(txtDGNhap.Text);
                            DGBan = Convert.ToInt32(txtDGBan.Text);
                            hinhAnhPictureBox.Image.Save(ms, hinhAnhPictureBox.Image.RawFormat);
                            byte[] img = ms.ToArray();
                            // Tạo DTo
                            DTO_SanPham sp = new DTO_SanPham(txtMaSP.Text, cbMaNCC.Text, cbMaLSP.Text, txtTenSP.Text, soLuong, txtDVT.Text, DGNhap, DGBan, img);
                            if (busSP.addSanPham(sp))
                            {
                                MessageBox.Show("Thêm thành công");
                                dgvSP.DataSource = busSP.getSanPham(); // refresh datagridview
                            }
                            else
                            {
                                MessageBox.Show("Thêm ko thành công");
                            }
                            ResetValue();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập số lượng,đơn giá nhập,đơn giá bán bằng số!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã loại sản phẩm hoặc mã nhà cung cấp không hợp lệ");
                        cbMaNCC.Text = cbMaNCC.Items[0].ToString();
                        cbMaLSP.Text = cbMaLSP.Items[0].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Mã sản phẩm đã có rồi");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();

            if (dgvSP.SelectedRows.Count > 0)
            {
                if (txtMaSP.Text != "" && txtTenSP.Text != "")
                {
                    if (busSP.KiemTraTonTaiMaNCC(cbMaNCC.Text) && busSP.KiemTraTonTaiMaLSP(cbMaLSP.Text))
                    {
                        int soLuong, DGNhap, DGBan;

                        if (int.TryParse(txtSoLuong.Text, out soLuong) && int.TryParse(txtDGNhap.Text, out DGNhap) && int.TryParse(txtDGBan.Text, out DGBan))
                        {
                            // Lấy row hiện tại
                            DataGridViewRow row = dgvSP.SelectedRows[0];
                            // Tạo DTo
                            soLuong = Convert.ToInt32(txtSoLuong.Text);
                            DGNhap = Convert.ToInt32(txtDGNhap.Text);
                            DGBan = Convert.ToInt32(txtDGBan.Text);
                            hinhAnhPictureBox.Image.Save(ms, hinhAnhPictureBox.Image.RawFormat);
                            byte[] img = ms.ToArray();
                            // Tạo DTo
                            DTO_SanPham sp = new DTO_SanPham(txtMaSP.Text, cbMaNCC.Text, cbMaLSP.Text, txtTenSP.Text, soLuong, txtDVT.Text, DGNhap, DGBan, img);
                            // Sửa
                            if (busSP.editSanPham(sp))
                            {
                                MessageBox.Show("Sửa thành công");
                                dgvSP.DataSource = busSP.getSanPham(); // refresh datagridview
                            }
                            else
                            {
                                MessageBox.Show("Sửa ko thành công");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập số lượng,đơn giá nhập,đơn giá bán bằng số!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã loại sản phẩm hoặc mã nhà cung cấp không hợp lệ");
                        cbMaNCC.Text = cbMaNCC.Items[0].ToString();
                        cbMaLSP.Text = cbMaLSP.Items[0].ToString();
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
            if (dgvSP.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvSP.SelectedRows[0];
                // Xóa
                if (busSP.deleteSanPham(txtMaSP.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvSP.DataSource = busSP.getSanPham();
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
            Funtion.ToExcel(dgvSP, @"D:\LapTrinhCSDL\QLBK", "_QL_SP", "sản phẩm");
            MessageBox.Show("Xuất file Excel thành công");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            ResetValue();
            dgvSP.DataSource = busSP.getSanPham();
            MessageBox.Show(dgvSP.Rows.Count.ToString());
            txtMaSP.ReadOnly=false;
        }
        private void ResetValue()
        {
            txtMaSP.Text = "";
            cbMaNCC.Text = "";
            cbMaLSP.Text = "";
            txtTenSP.Text = "";
            txtDGBan.Text = "";
            txtDVT.Text = "";
            txtDGNhap.Text = "";
            txtSoLuong.Text = "";
            hinhAnhPictureBox.Text = "";
            cbFind.Text = "";
            txtFind.Text = "";
        }

        private void dgvSP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSP.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                DataGridViewRow selectedRow = dgvSP.SelectedRows[0];

                // Lấy dữ liệu từ các ô cột của dòng được chọn
                string maSP = selectedRow.Cells["MaSP"].Value.ToString();
                string maNCC = selectedRow.Cells["MaNCC"].Value.ToString();
                string maLSP = selectedRow.Cells["MaLSP"].Value.ToString();
                string tenSP = selectedRow.Cells["TenSP"].Value.ToString();
                int soluong = (int)selectedRow.Cells["SoLuongSP"].Value;
                string dvt = selectedRow.Cells["DVT"].Value.ToString();
                int dgnhap = (int)selectedRow.Cells["DonGiaNhap"].Value;
                int dgban = (int)selectedRow.Cells["DonGiaBan"].Value;
                byte[] imageData = (byte[])selectedRow.Cells["HinhAnh"].Value;
                MemoryStream memoryStream = new MemoryStream(imageData);
                Image image = Image.FromStream(memoryStream);
                // Gán dữ liệu lên các TextBox tương ứng
                txtMaSP.Text = maSP;
                txtMaSP.ReadOnly = true;
                cbMaNCC.Text = maNCC;
                cbMaLSP.Text = maLSP;
                txtTenSP.Text = tenSP;
                txtSoLuong.Text = soluong.ToString();
                txtDVT.Text = dvt;
                txtDGNhap.Text = dgnhap.ToString();
                txtDGBan.Text = dgban.ToString();
                hinhAnhPictureBox.Image = image;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (busSP.checkcbFind(cbFind.Text))
            {
                if (cbFind.Text != "" && txtFind.Text != "")
                {
                    dgvSP.DataSource = busSP.findSanPham(cbFind.Text, txtFind.Text);
                    MessageBox.Show("Tìm kiếm thành công");
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập thông tin cần tìm");
                    ResetValue();
                    dgvSP.DataSource = busSP.getSanPham();
                }
            }
            else
            {
                MessageBox.Show("Giá trị loại cần tìm không hợp lệ");
            }
        }

        private void dgvSP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < dgvSP.ColumnCount) // Kiểm tra index hợp lệ
            {
                DataGridViewColumn column = dgvSP.Columns[e.ColumnIndex];
                if (column.Name == "SoLuongSP" || column.Name == "DonGiaNhap" || column.Name == "DonGiaBan")
                {
                    if (e.Value != null)
                    {
                        int value = Convert.ToInt32(e.Value);
                        e.Value = value.ToString("#,##0"); // Format lại dữ liệu với dấu phân cách hàng nghìn
                        e.FormattingApplied = true;
                    }
                }
            }
        }
    }
}

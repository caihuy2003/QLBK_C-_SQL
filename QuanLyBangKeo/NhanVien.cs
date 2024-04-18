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
using System.Collections;

namespace QuanLyBangKeo
{
    public partial class NhanVien : Form
    {
        BUS_NhanVien busNV=new BUS_NhanVien();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dgvNV.DataSource = busNV.getNhanVien();

            int totalWidth = dgvNV.Width - dgvNV.RowHeadersWidth;
            int columnCount = dgvNV.Columns.Count;
            int averageWidth = totalWidth / columnCount;

            // Gán kích thước trung bình cho mỗi cột
            foreach (DataGridViewColumn column in dgvNV.Columns)
            {
                column.Width = averageWidth;
            }
            dgvNV.RowTemplate.Height = 50;
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
        
        private void dgvNV_Click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNV.SelectedRows[0];
            txtMaNV.Text = row.Cells[1].Value.ToString();
            txtTenNV.Text = row.Cells[2].Value.ToString();
            dtNgaySinh.Text = row.Cells[3].Value.ToString();
            txtDiaChiNV.Text = row.Cells[4].Value.ToString();
            txtSDTNV.Text = row.Cells[5].Value.ToString();
            cbChucVu.Text = row.Cells[6].Value.ToString();
            dtNgayVaoLam.Text = row.Cells[7].Value.ToString();
            cbGioiTinh.Text = row.Cells[8].Value.ToString();
            txtMatKhau.Text = row.Cells[9].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            if (!busNV.KiemTraTrungMaNhanVien(txtMaNV.Text))
            {
                DateTime dateOfBirth = dtNgaySinh.Value;
                if (busNV.IsEmployeeAdult(dateOfBirth))
                {
                    DateTime selectedDate = dtNgayVaoLam.Value;
                    if (busNV.IsDateBeforeToday(selectedDate))
                    {
                        if (busNV.IsComboBoxValueValid(cbChucVu.Text, cbGioiTinh.Text))
                        {
                            if (txtMaNV.Text != "" && txtSDTNV.Text != "" && txtTenNV.Text != "" && txtDiaChiNV.Text != "" && cbGioiTinh.Text != "" && txtMatKhau.Text != "")
                            {
                                hinhAnhPictureBox.Image.Save(ms, hinhAnhPictureBox.Image.RawFormat);
                                byte[] img = ms.ToArray();
                                // Tạo DTo
                                DTO_NhanVien NV = new DTO_NhanVien(txtMaNV.Text, txtTenNV.Text, dtNgaySinh.Value, txtDiaChiNV.Text, txtSDTNV.Text, cbChucVu.Text, dtNgayVaoLam.Value, cbGioiTinh.Text, txtMatKhau.Text, img);
                                if (busNV.addNhanVien(NV))
                                {
                                    MessageBox.Show("Thêm thành công");
                                    dgvNV.DataSource = busNV.getNhanVien(); // refresh datagridview
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
                            MessageBox.Show("Giá trị trong Chức vụ hoặc Giới tính không hợp lệ");
                            cbChucVu.Text = cbChucVu.Items[0].ToString();
                            cbGioiTinh.Text = cbGioiTinh.Items[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn ngày vào làm lớn hơn ngày hiện tại");
                    }
                }
                else
                {
                    MessageBox.Show("Nhân viên chưa đủ 18 tuôi");
                }
            }
            else
            {
                MessageBox.Show("Mã nhân viên đã có");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            if (dgvNV.SelectedRows.Count > 0)
            {
                    DateTime dateOfBirth = dtNgaySinh.Value;
                    if (busNV.IsEmployeeAdult(dateOfBirth))
                    {
                        DateTime selectedDate = dtNgayVaoLam.Value;
                        if (busNV.IsDateBeforeToday(selectedDate))
                        {
                            if (busNV.IsComboBoxValueValid(cbChucVu.Text, cbGioiTinh.Text))
                            {
                                if (txtMaNV.Text != "" && txtSDTNV.Text != "" && txtTenNV.Text != "" && txtDiaChiNV.Text != "" && cbGioiTinh.Text != "" && txtMatKhau.Text != "")
                                {
                                    hinhAnhPictureBox.Image.Save(ms, hinhAnhPictureBox.Image.RawFormat);
                                    byte[] img = ms.ToArray();
                                    // Lấy row hiện tại
                                    DataGridViewRow row = dgvNV.SelectedRows[0];
                                    // Tạo DTo
                                    DTO_NhanVien NV = new DTO_NhanVien(txtMaNV.Text, txtTenNV.Text, dtNgaySinh.Value, txtDiaChiNV.Text, txtSDTNV.Text, cbChucVu.Text, dtNgayVaoLam.Value, cbGioiTinh.Text, txtMatKhau.Text, img);
                                    // Sửa
                                    if (busNV.editNhanVien(NV))
                                    {
                                        MessageBox.Show("Sửa thành công");
                                        dgvNV.DataSource = busNV.getNhanVien(); // refresh datagridview
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
                                MessageBox.Show("Giá trị trong Chức vụ hoặc Giới tính không hợp lệ");
                                cbChucVu.Text = cbChucVu.Items[0].ToString();
                                cbGioiTinh.Text = cbGioiTinh.Items[0].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn ngày vào làm lớn hơn ngày hiện tại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên chưa đủ 18 tuôi");
                    }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvNV.SelectedRows[0];
                // Xóa
                if (busNV.deleteNhanVien(txtMaNV.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvNV.DataSource = busNV.getNhanVien();
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
            Funtion.ToExcel(dgvNV, @"D:\LapTrinhCSDL\QLBK", "_QL_NV", "nhân viên");
            MessageBox.Show("Xuất file Excel thành công");
        }

        private void btnCanCle_Click(object sender, EventArgs e)
        {
            ResetValue();
            dgvNV.DataSource = busNV.getNhanVien();
            txtMaNV.ReadOnly = false;
        }

        
        private void ResetValue()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDTNV.Text = "";
            txtFind.Text = "";
            cbFind.SelectedIndex = -1;
            txtDiaChiNV.Text = "";
            cbChucVu.Text = "";
            dtNgayVaoLam.Text = "";
            cbGioiTinh.Text = "";
            txtMatKhau.Text = "";
            hinhAnhPictureBox.Text = "";
        }

        private void dgvNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                DataGridViewRow selectedRow = dgvNV.SelectedRows[0];

                // Lấy dữ liệu từ các ô cột của dòng được chọn
                string maNV = selectedRow.Cells["MaNV"].Value.ToString();
                string tenNV = selectedRow.Cells["TenNV"].Value.ToString();
                string diaChi = selectedRow.Cells["DiaChiNV"].Value.ToString();
                string soDienThoai = selectedRow.Cells["SDT_NV"].Value.ToString();
                string chucvu = selectedRow.Cells["ChucVu"].Value.ToString();
                string dateTime = selectedRow.Cells[columnName: "NgayVaoLam"].Value.ToString();
                string gioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString();
                string mk= selectedRow.Cells["MatKhau"].Value.ToString();
                byte[] imageData = (byte[])selectedRow.Cells["HinhAnh"].Value;
                MemoryStream memoryStream = new MemoryStream(imageData);
                Image image = Image.FromStream(memoryStream);
                // Gán dữ liệu lên các TextBox tương ứng
                txtMaNV.Text = maNV;
                txtMaNV.ReadOnly = true;
                txtTenNV.Text = tenNV;
                txtDiaChiNV.Text = diaChi;
                txtSDTNV.Text = soDienThoai;
                cbChucVu.Text= chucvu;
                dtNgayVaoLam.Text = dateTime;
                cbGioiTinh.Text = gioiTinh;
                txtMatKhau.Text = mk;
                hinhAnhPictureBox.Image = image;
            }
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            if (busNV.checkcbFind(cbFind.Text))
            {
                if (cbFind.Text != "" && txtFind.Text != "")
                {
                    dgvNV.DataSource = busNV.findNhanVien(cbFind.Text, txtFind.Text);
                    MessageBox.Show("Tìm kiếm thành công");
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập thông tin cần tìm");
                    ResetValue();
                    dgvNV.DataSource = busNV.getNhanVien();
                }
            }
            else
            {
                MessageBox.Show("Giá trị loại cần tìm không hợp lệ");
            }
        }
    }
}

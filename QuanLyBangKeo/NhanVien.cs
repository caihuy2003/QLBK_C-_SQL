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
using System.Data.SqlClient;

namespace QuanLyBangKeo
{
    public partial class NhanVien : Form
    {
        BUS_NhanVien busNV=new BUS_NhanVien();
        BUS_NhatKyHoatDong busnkhd=new BUS_NhatKyHoatDong();
        private string MaNV;
        public NhanVien(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dgvNV.DataSource = busNV.getNhanVien();
            dgvNV.RowTemplate.Height = 30;
            dgvNV.RowsDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dgvNV.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateBlue;
            
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tự động điều chỉnh kích thước cột cuối cùng để vừa với chiều rộng DataGridView
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNV.RowTemplate.Height = 50;
            Image trashIcon = Properties.Resources.icons8_delete_50;
            Image resizedIcon = new Bitmap(trashIcon, new Size(20, 20));
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "DeleteColumn";
            imgColumn.HeaderText = "";
            imgColumn.Image = resizedIcon;
            imgColumn.Width = 10;
            //imgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNV.Columns.Add(imgColumn);
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
            txtLuong.Text = "";
            hinhAnhPictureBox.Text = "";
            txtTK.Text = "";
            txtMK.Text = "";
            txtLuong.Text = "";
            hinhAnhPictureBox.Image=Properties.Resources.stop.ToBitmap();
        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            if (!busNV.KiemTraTrungMaNhanVien(txtMaNV.Text))
            {
                DateTime dateOfBirth = dtNgaySinh.Value;
                DateTime dateOfWork = dtNgayVaoLam.Value;
                if (busNV.IsEmployeeAdult(dateOfBirth) && dateOfWork > (dateOfBirth.AddYears(18)))
                {
                    DateTime selectedDate = dtNgayVaoLam.Value;
                    if (busNV.IsDateBeforeToday(selectedDate))
                    {
                        if (busNV.IsComboBoxValueValid(cbChucVu.Text, cbGioiTinh.Text))
                        {
                            if (txtMaNV.Text != "" && txtSDTNV.Text != "" && txtTenNV.Text != "" && txtDiaChiNV.Text != "" && cbGioiTinh.Text != "" && txtLuong.Text != "")
                            {
                                if(txtTK.Text.Length <= 10 && txtMK.Text.Length <=10)
                                {
                                    hinhAnhPictureBox.Image.Save(ms, hinhAnhPictureBox.Image.RawFormat);
                                    byte[] img = ms.ToArray();
                                    string fullName = txtTenNV.Text.Trim();
                                    int lastSpaceIndex = fullName.LastIndexOf(' ');
                                    if (lastSpaceIndex > 0)
                                    {
                                        int luong;
                                        if (int.TryParse(txtLuong.Text, out luong))
                                        {
                                            string ho = fullName.Substring(0, lastSpaceIndex).Trim(); // Lấy Họ và tên đệm
                                            string ten = fullName.Substring(lastSpaceIndex + 1).Trim(); // Lấy Tên
                                            luong = Convert.ToInt32(txtLuong.Text);                                                           // Tạo DTo
                                            DTO_NhanVien NV = new DTO_NhanVien(txtMaNV.Text, ho, ten, dtNgaySinh.Value, txtDiaChiNV.Text, txtSDTNV.Text, cbChucVu.Text, dtNgayVaoLam.Value, cbGioiTinh.Text, txtTK.Text, txtMK.Text, img, luong);
                                            if (busNV.addNhanVien(NV))
                                            {
                                                MessageBox.Show("Thêm thành công");
                                                dgvNV.DataSource = busNV.getNhanVien(); // refresh datagridview
                                                DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Thêm nhân viên", "Thêm nhân viên mã " + txtMaNV.Text);
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
                                            MessageBox.Show("Vui lòng nhập lương bằng số");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Vui lòng nhập họ và tên hợp lệ.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Tài khoản và mật khẩu không được vượt quá 10 kí tự.");
                                }
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

        private void hinhAnhPictureBox_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                hinhAnhPictureBox.Image = Image.FromFile(open.FileName);

            }
        }

        private void dgvNV_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNV.SelectedRows[0];
            txtMaNV.Text = row.Cells[1].Value.ToString();
            cbChucVu.Text = row.Cells[2].Value.ToString();
            txtTenNV.Text = row.Cells[3].Value.ToString() + " " + row.Cells[4].Value.ToString() ;
            dtNgaySinh.Text = row.Cells[5].Value.ToString();
            txtDiaChiNV.Text = row.Cells[6].Value.ToString();
            txtSDTNV.Text = row.Cells[7].Value.ToString();
            dtNgayVaoLam.Text = row.Cells[8].Value.ToString();
            cbGioiTinh.Text = row.Cells[9].Value.ToString();
            txtLuong.Text = row.Cells[10].Value.ToString();
            txtTK.Text = row.Cells[11].Value.ToString();
            txtMK.Text = row.Cells[12].Value.ToString();
            byte[] imageData = (byte[])row.Cells["HinhAnh"].Value;
            MemoryStream memoryStream = new MemoryStream(imageData);
            Image image = Image.FromStream(memoryStream);
            hinhAnhPictureBox.Image= image;
            txtMaNV.ReadOnly = true;
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
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
                            if (txtMaNV.Text != "" && txtSDTNV.Text != "" && txtTenNV.Text != "" && txtDiaChiNV.Text != "" && cbGioiTinh.Text != "" && txtLuong.Text != "")
                            {
             
                                    hinhAnhPictureBox.Image.Save(ms, hinhAnhPictureBox.Image.RawFormat);
                                    byte[] img = ms.ToArray();
                                    // Lấy row hiện tại
                                    DataGridViewRow row = dgvNV.SelectedRows[0];
                                    string fullName = txtTenNV.Text.Trim();
                                    int lastSpaceIndex = fullName.LastIndexOf(' ');
                                    if (lastSpaceIndex > 0)
                                    {
                                        int luong;
                                        if (int.TryParse(txtLuong.Text, out luong))
                                        {
                                            string ho = fullName.Substring(0, lastSpaceIndex).Trim(); // Lấy Họ và tên đệm
                                            string ten = fullName.Substring(lastSpaceIndex + 1).Trim(); // Lấy Tên
                                            luong = Convert.ToInt32(txtLuong.Text);
                                            
                                            DTO_NhanVien NV = new DTO_NhanVien(txtMaNV.Text, ho, ten, dtNgaySinh.Value, txtDiaChiNV.Text, txtSDTNV.Text, cbChucVu.Text, dtNgayVaoLam.Value, cbGioiTinh.Text, txtTK.Text, txtMK.Text, img, luong);
                                            // Sửa
                                            if (busNV.editNhanVien(NV))
                                            {
                                                MessageBox.Show("Sửa thành công");
                                                dgvNV.DataSource = busNV.getNhanVien(); // refresh datagridview
                                                DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Sửa nhân viên", "Sửa thông tin nhân viên mã " + txtMaNV.Text);
                                                busnkhd.AddNKHD(nkhd);

                                        }
                                            else
                                            {
                                                MessageBox.Show("Sửa ko thành công");
                                            }
                                            ResetValue();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Vui lòng nhập lương bằng số");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Vui lòng nhập họ và tên hợp lệ.");
                                    }
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

        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            Funtion.ToExcel(dgvNV, @"D:\LapTrinhCSDL\QLBK", "_QL_NV", "nhân viên");
            MessageBox.Show("Xuất file Excel thành công");
            DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xuất file excel", "Xuất file nhân viên" + txtMaNV.Text);
            busnkhd.AddNKHD(nkhd);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetValue();
            dgvNV.DataSource = busNV.getNhanVien();
            txtMaNV.ReadOnly = false;
        }


        private void btnFind_Click(object sender, EventArgs e)
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

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvNV.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                // Hiện hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvNV.SelectedRows[0];
                    string maNV = row.Cells[1].Value.ToString();
                    if (busNV.deleteNhanVien(maNV))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvNV.DataSource = busNV.getNhanVien(); // refresh datagridview
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xóa nhân viên", "Xóa nhân viên mã " + maNV);
                        busnkhd.AddNKHD(nkhd);
                    }
                    else
                    {
                        MessageBox.Show("Xóa ko thành công");
                    }
                }
            }
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string macv = cbChucVu.Text.ToString();
            if(macv =="NVK")
            {
                txtTK.ReadOnly = true;
                txtMK.ReadOnly = true;
            }
            else
            {
                txtTK.ReadOnly=false;
                txtMK.ReadOnly=false;
            }
        }

        private void txtSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txtSDTNV.Focus();
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txtLuong.Focus();
            }
        }
    }
}

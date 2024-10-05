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
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBangKeo
{
    public partial class KhachHang : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        BUS_NhatKyHoatDong busnkhd=new BUS_NhatKyHoatDong();
        private string MaNV;
        public KhachHang(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = busKH.getKhachHang();
            cbMaLKH.DataSource = busKH.GetMaLKH();
            dgvKH.Invalidate();
            dgvKH.RowTemplate.Height = 30;
            dgvKH.RowsDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dgvKH.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateBlue;
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Tự động điều chỉnh kích thước cột cuối cùng để vừa với chiều rộng DataGridView
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKH.Columns["DiaChiKH"].Width = 200;
            dgvKH.Columns["TenKH"].Width = 150;
            dgvKH.Columns["MaKH"].Width = 30;
            dgvKH.Columns["MaLKH"].Width = 50;
            Image trashIcon = Properties.Resources.icons8_delete_50;
            Image resizedIcon = new Bitmap(trashIcon, new Size(20, 20));
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "DeleteColumn";
            imgColumn.HeaderText = "";
            imgColumn.Image = resizedIcon;
            imgColumn.Width = 10;
            //imgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvKH.Columns.Add(imgColumn);
            dgvKH.Refresh();
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
            cbMaLKH.SelectedIndex = -1;
        }

        private void txtSDT_KH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txtSDT_KH.Focus();
            }
        }

        private void btnFind_Click_1(object sender, EventArgs e)
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

        private void dgvKH_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvKH.SelectedRows[0];
            txtMaKH.Text = row.Cells[1].Value.ToString();
            txtTenKH.Text = row.Cells[2].Value.ToString();
            txtSDT_KH.Text = row.Cells[4].Value.ToString();
            txtDiaChiKH.Text = row.Cells[3].Value.ToString();
            cbGioiTinh.Text = row.Cells[5].Value.ToString();
            cbMaLKH.Text = row.Cells[7].Value.ToString();
            int tienNo = Convert.ToInt32(row.Cells["TienNo"].Value);
            if (tienNo!=0)
            {
                txtNo.Visible = true;
                guna2GradientButton1.Visible = true;
            }
            else
            {
                txtNo.Visible = false;
                guna2GradientButton1.Visible = false;
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKH.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                // Hiện hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvKH.SelectedRows[0];
                    string MaKH = row.Cells[1].Value.ToString();
                    if (busKH.deleteKhachHang(MaKH))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvKH.DataSource = busKH.getKhachHang(); // refresh datagridview
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xóa khách hàng", "Xóa khách hàng mã " + MaKH);
                        busnkhd.AddNKHD(nkhd);
                    }
                    else
                    {
                        MessageBox.Show("Xóa ko thành công");
                    }
                }
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!busKH.KiemTraTrungMaKhachHang(txtMaKH.Text))
            {
                if (busKH.IsComboBoxValueValid(cbGioiTinh.Text) && cbMaLKH.Items.Contains(cbMaLKH.Text))
                {
                    if (txtMaKH.Text != "" && txtTenKH.Text != "" && txtDiaChiKH.Text != "")
                    {
                        // Tạo DTo
                        DTO_KhachHang KH = new DTO_KhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChiKH.Text, txtSDT_KH.Text, cbGioiTinh.Text,0,cbMaLKH.Text);
                        if (busKH.addKhachHang(KH))
                        {
                            MessageBox.Show("Thêm thành công");
                            dgvKH.DataSource = busKH.getKhachHang(); // refresh datagridview
                            DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Thêm khách hàng", "Thêm khách hàng mã " + txtMaKH.Text);
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
                    MessageBox.Show("Giá trị giới tính hoặc mã loại khách hàng không hợp lệ");
                    cbMaLKH.Text=string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Mã khách hàng đã có");
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
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
                        DTO_KhachHang KH = new DTO_KhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChiKH.Text, txtSDT_KH.Text, cbGioiTinh.Text,0, cbMaLKH.Text);
                        // Sửa
                        if (busKH.editKhachHang(KH))
                        {
                            MessageBox.Show("Sửa thành công");
                            dgvKH.DataSource = busKH.getKhachHang(); // refresh datagridview
                            DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Sửa khách hàng", "Sửa khách hàng mã " + txtMaKH.Text);
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

        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            Funtion.ToExcel(dgvKH, @"D:\LapTrinhCSDL\QLBK", "_QL_KH", "KHách hàng");
            MessageBox.Show("Xuất file Excel thành công");
            DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xuất file excel", "Xuất file khách hàng");
            busnkhd.AddNKHD(nkhd);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetValue();
            dgvKH.DataSource = busKH.getKhachHang();
            txtMaKH.ReadOnly = false;
        }

        private void txtSDT_KH_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txtSDT_KH.Focus();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvKH.SelectedRows[0];
            int tienNo = Convert.ToInt32(selectedRow.Cells["TienNo"].Value);  
            int tientra = 0;
            if (int.TryParse(txtNo.Text, out tientra))
            {
                if (tientra > 0)
                {
                    if (tientra > tienNo)
                    {
                        MessageBox.Show("Số tiền trả không được lớn hơn số tiền nợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Trừ số tiền trả vào tiền nợ
                        tienNo -= tientra;

                        // Cập nhật lại cột tiền nợ
                        selectedRow.Cells["TienNo"].Value = tienNo;
                        // Thực hiện cập nhật vào cơ sở dữ liệu
                        busKH.CapNhatNoKhachHang(txtMaKH.Text, tienNo);
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Sửa khách hàng",txtMaKH.Text+" trả nợ "+txtNo.Text+" tiền nợ còn "+tienNo);
                        busnkhd.AddNKHD(nkhd);
                        KhachHang_Load(sender,e);
                    }
                }
                else
                {
                    MessageBox.Show("Số tiền trả phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Số tiền trả không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
        BUS_NhatKyHoatDong busnkhd=new BUS_NhatKyHoatDong();
        private string MaNV;
        public SanPham(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            dgvSP.DataSource = busSP.getSanPham();
            cbMaNCC.DataSource = busSP.GetMaNhaCungCap();
            cbMaLSP.DataSource = busSP.GetMaLoaiSanPham();
          
            dgvSP.RowTemplate.Height = 30;
            dgvSP.RowsDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dgvSP.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateBlue;
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tự động điều chỉnh kích thước cột cuối cùng để vừa với chiều rộng DataGridView
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSP.RowTemplate.Height = 50;
            Image trashIcon = Properties.Resources.icons8_delete_50;
            Image resizedIcon = new Bitmap(trashIcon, new Size(20, 20));
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "DeleteColumn";
            imgColumn.HeaderText = "";
            imgColumn.Image = resizedIcon;
            imgColumn.Width = 10;
            //imgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSP.Columns.Add(imgColumn);
            dgvSP.CellFormatting += dgvSP_CellFormatting_1;
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
            txtBichTrenThung.Text = "";
            txtGhiChu.Text = "";
        }

        private void dgvSP_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvSP.SelectedRows[0];
            txtMaSP.Text = row.Cells[1].Value.ToString();
            cbMaNCC.Text = row.Cells[2].Value.ToString();
            cbMaLSP.Text = row.Cells[3].Value.ToString();
            txtTenSP.Text = row.Cells[4].Value.ToString();
            txtDGNhap.Text = row.Cells[5].Value.ToString();
            txtDGBan.Text = row.Cells[6].Value.ToString();
            txtDVT.Text = row.Cells[7].Value.ToString();
            txtSoLuong.Text = row.Cells[11].Value.ToString();
            txtBichTrenThung.Text = row.Cells[12].Value.ToString();
            txtGhiChu.Text = row.Cells[13].Value.ToString();
            if (row.Cells[14].Value != DBNull.Value)
            {
                byte[] imageBytes = (byte[])row.Cells[14].Value;
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        // Chuyển đổi byte[] sang Image và hiển thị trong PictureBox
                        hinhAnhPictureBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Nếu không có dữ liệu hình ảnh, hiển thị ảnh mặc định hoặc để trống
                    hinhAnhPictureBox.Image = null;
                }
            }
            else
            {
                // Nếu không có hình ảnh, có thể đặt hình mặc định hoặc xóa hình hiện có
                hinhAnhPictureBox.Image = null;  // Hoặc set hình mặc định
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            if (!busSP.KiemTraTrungMaSanPham(txtMaSP.Text))
            {
                if (txtMaSP.Text != "" && txtTenSP.Text != "")
                {
                    if (busSP.KiemTraTonTaiMaNCC(cbMaNCC.Text) && busSP.KiemTraTonTaiMaLSP(cbMaLSP.Text))
                    {
                        int soLuong, DGNhap, DGBan,bichtrenthung;

                        if (int.TryParse(txtSoLuong.Text, out soLuong) && int.TryParse(txtDGNhap.Text, out DGNhap) && int.TryParse(txtDGBan.Text, out DGBan) && int.TryParse(txtBichTrenThung.Text, out bichtrenthung))
                        {
                            soLuong = Convert.ToInt32(txtSoLuong.Text);
                            DGNhap = Convert.ToInt32(txtDGNhap.Text);
                            DGBan = Convert.ToInt32(txtDGBan.Text);
                            hinhAnhPictureBox.Image.Save(ms, hinhAnhPictureBox.Image.RawFormat);
                            byte[] img = ms.ToArray();
                            bichtrenthung=Convert.ToInt32(txtBichTrenThung.Text);
                            // Tạo DTo
                            DTO_SanPham sp = new DTO_SanPham(txtMaSP.Text, cbMaNCC.Text, cbMaLSP.Text, txtTenSP.Text, DGNhap, DGBan,txtDVT.Text,soLuong,soLuong,bichtrenthung,txtGhiChu.Text, img);
                            if (busSP.addSanPham(sp))
                            {
                                MessageBox.Show("Thêm thành công");
                                dgvSP.DataSource = busSP.getSanPham(); // refresh datagridview
                                DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Thêm sản phẩm", "Thêm sản phẩm mã " + txtMaSP.Text);
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
                            MessageBox.Show("Vui lòng nhập số lượng,đơn giá nhập,đơn giá bán, số bịch trên thùng bằng số!!!");
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

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();

            if (dgvSP.SelectedRows.Count > 0)
            {
                if (txtMaSP.Text != "" && txtTenSP.Text != "")
                {
                    if (busSP.KiemTraTonTaiMaNCC(cbMaNCC.Text) && busSP.KiemTraTonTaiMaLSP(cbMaLSP.Text))
                    {
                        int soLuong, DGNhap, DGBan,bichtrenthung;

                        if (int.TryParse(txtSoLuong.Text, out soLuong) && int.TryParse(txtDGNhap.Text, out DGNhap) && int.TryParse(txtDGBan.Text, out DGBan) && int.TryParse(txtBichTrenThung.Text, out bichtrenthung))
                        {
                            // Lấy row hiện tại
                            DataGridViewRow row = dgvSP.SelectedRows[0];
                            // Tạo DTo
                            soLuong = Convert.ToInt32(txtSoLuong.Text);
                            DGNhap = Convert.ToInt32(txtDGNhap.Text);
                            DGBan = Convert.ToInt32(txtDGBan.Text);
                            hinhAnhPictureBox.Image.Save(ms, hinhAnhPictureBox.Image.RawFormat);
                            byte[] img = ms.ToArray();
                            bichtrenthung= Convert.ToInt32(txtBichTrenThung.Text);
                            // Tạo DTo
                            DTO_SanPham sp = new DTO_SanPham(txtMaSP.Text, cbMaNCC.Text, cbMaLSP.Text, txtTenSP.Text, DGNhap, DGBan, txtDVT.Text, soLuong, soLuong, bichtrenthung, txtGhiChu.Text, img);
                            // Sửa
                            if (busSP.editSanPham(sp))
                            {
                                MessageBox.Show("Sửa thành công");
                                dgvSP.DataSource = busSP.getSanPham(); // refresh datagridview
                                DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Sửa sản phẩm", "Sửa sản phẩm mã " + txtMaSP.Text);
                                busnkhd.AddNKHD(nkhd);
                            }
                            else
                            {
                                MessageBox.Show("Sửa ko thành công");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập số lượng,đơn giá nhập,đơn giá bán, số bịch trên thùng bằng số!!!");
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

        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            Funtion.ToExcel(dgvSP, @"D:\LapTrinhCSDL\QLBK", "_QL_SP", "sản phẩm");
            MessageBox.Show("Xuất file Excel thành công");
            DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xuất file excel", "Xuất file sản phẩm");
            busnkhd.AddNKHD(nkhd);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetValue();
            dgvSP.DataSource = busSP.getSanPham();
            MessageBox.Show(dgvSP.Rows.Count.ToString());
            txtMaSP.ReadOnly = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
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


        private void dgvSP_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < dgvSP.ColumnCount) // Kiểm tra index hợp lệ
            {
                DataGridViewColumn column = dgvSP.Columns[e.ColumnIndex];
                if (column.Name == "TonCuoi" || column.Name == "DonGiaNhap" || column.Name == "DonGiaBan")
                {
                    if (e.Value != null && int.TryParse(e.Value.ToString(), out int value))
                    {
                        e.Value = value.ToString("#,##0"); // Format lại dữ liệu với dấu phân cách hàng nghìn
                        e.FormattingApplied = true;
                    }
                }
                if (column.Name == "Tồn cuối")
                {
                    // Lấy giá trị số lượng từ ô hiện tại
                    int soLuong = Convert.ToInt32(e.Value);

                    // Nếu số lượng < 10, tô màu nền là đỏ
                    if (soLuong < 10)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                    // Nếu số lượng < 20, tô màu nền là vàng
                    else if (soLuong < 20)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                    else
                    {
                        // Giữ nguyên màu mặc định
                        e.CellStyle.BackColor = Color.DarkBlue;
                    }
                }
            }
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSP.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                // Hiện hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvSP.SelectedRows[0];
                    string maSP = row.Cells[1].Value.ToString();
                    if (busSP.deleteSanPham(maSP))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvSP.DataSource = busSP.getSanPham(); // refresh datagridview
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Xóa sản phẩm", "Xóa sản phẩm mã " + maSP);
                        busnkhd.AddNKHD(nkhd);
                    }
                    else
                    {
                        MessageBox.Show("Xóa ko thành công");
                    }
                }
            }
        }
    }
}

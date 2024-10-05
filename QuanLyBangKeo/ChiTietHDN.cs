using BUS_QuanLyBK;
using CrystalDecisions.ReportAppServer.DataDefModel;
using DTO_QuanLyBK;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyBangKeo
{
    public partial class ChiTietHDN : Form
    {
        BUS_ChiTietNhap buschitietnhap = new BUS_ChiTietNhap();
        BUS_HoaDonNhap bushoadonnhap = new BUS_HoaDonNhap();
        BUS_NhatKyHoatDong busnkhd=new BUS_NhatKyHoatDong();
        int tong;
        public ChiTietHDN()
        {
            InitializeComponent();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ChiTietNhap1' table. You can move, or remove it, as needed.
            //this.chiTietNhap1TableAdapter.Fill(this.dataSet1.ChiTietNhap1);
         
            cbMaNCC.DataSource = buschitietnhap.GetMaNCC();
            cbMaSP.DataSource = buschitietnhap.GetMaSanPham(cbMaNCC.Text);
            dgvCT_HDN.DataSource = buschitietnhap.getChiTietNhap(txtMaHDN.Text);
            dgvCT_HDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tự động điều chỉnh kích thước cột cuối cùng để vừa với chiều rộng DataGridView
            dgvCT_HDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Image trashIcon = Properties.Resources.icons8_delete_50;
            Image resizedIcon = new Bitmap(trashIcon, new Size(20, 20));
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "DeleteColumn";
            imgColumn.HeaderText = "";
            imgColumn.Image = resizedIcon;
            imgColumn.Width = 10;
            //imgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCT_HDN.Columns.Add(imgColumn);
        }

        private void cbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mancc = cbMaNCC.SelectedItem.ToString(); // Lấy mã khách hàng từ ComboBox
            string[] thongTinNCC = buschitietnhap.LayThongTinNCC(mancc); // Lấy thông tin khách hàng từ BLL

            txtTenNCC.Text = thongTinNCC[0];
            cbMaSP.DataSource = buschitietnhap.GetMaSanPham(cbMaNCC.Text);
        }
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text.ToString(); // Lấy mã khách hàng từ ComboBox
            string[] thongTinNV = buschitietnhap.LayThongTinNV(manv); // Lấy thông tin khách hàng từ BLL

            txtTenNV.Text = thongTinNV[0];
        }

        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string masp = cbMaSP.SelectedItem.ToString(); // Lấy mã khách hàng từ ComboBox
            string[] thongTinSP = buschitietnhap.LayThongTinSP(masp); // Lấy thông tin khách hàng từ BLL

            txtTenSP.Text = thongTinSP[0];
            txtDGNhap.Text = thongTinSP[1];
            cbMaNCC.Text = thongTinSP[2];
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            int tt, sl, dg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToInt32(txtSoLuong.Text);
            if (txtDGNhap.Text == "")
                dg = 0;
            else
                dg = Convert.ToInt32(txtDGNhap.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
        }
        private void txtDGNhap_TextChanged(object sender, EventArgs e)
        {
            int tt, sl, dg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToInt32(txtSoLuong.Text);
            if (txtDGNhap.Text == "")
                dg = 0;
            else
                dg = Convert.ToInt32(txtDGNhap.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
        }
        public void SetMaHoaDonValue(string maHoaDon, string maNV)
        {
            txtMaHDN.Text = maHoaDon;
            txtMaNV.Text = maNV;
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!buschitietnhap.kiemtramaSP(cbMaSP.Text, dgvCT_HDN))
            {
                if (cbMaNCC.Text != "" && cbMaSP.Text != "" && txtSoLuong.Text != "")
                {
                    int soluong, dongianhap, thanhtien;
                    if (int.TryParse(txtSoLuong.Text, out soluong) && int.TryParse(txtDGNhap.Text, out dongianhap) && int.TryParse(txtThanhTien.Text, out thanhtien))
                    {
                        soluong = Convert.ToInt32(txtSoLuong.Text);
                        dongianhap = Convert.ToInt32(txtDGNhap.Text);
                        thanhtien = Convert.ToInt32(txtThanhTien.Text);
                        DTO_ChiTietNhap ctn = new DTO_ChiTietNhap(txtMaHDN.Text, cbMaSP.Text, soluong, thanhtien,txtGhiChu.Text);
                        buschitietnhap.addChiTietNhap(ctn, dataSet1);
                        dgvCT_HDN.DataSource=chiTietNhapBindingSource;
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập đày đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Mã sản phẩm đã có trong bảng");
            }

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Funtion.ToExcel(dgvCT_HDN, @"D:\LapTrinhCSDL\QLBK", "_QL_ChiTietHoaDon", "chi tiet hoa don");
            MessageBox.Show("Xuất file Excel thành công");
            DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(txtMaNV.Text, DateTime.Now, "Xuất file excel", "Xuất file chi tiết hóa đơn nhập mã " + txtMaHDN.Text);
            busnkhd.AddNKHD(nkhd);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            dataSet1.Tables["ChiTietNhap1"].Clear();
            this.Close();
        }

        private void dgvCT_HDN_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateTotal();   
        }
        private void dgvCT_HDN_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateTotal();
        }
        private void UpdateTotal()
        {
            tong = 0;
            for (int i = 1; i < dgvCT_HDN.Rows.Count; i++)
            {
                DataGridViewRow row1 = dgvCT_HDN.Rows[i - 1];

                if (row1.Cells[6].Value != null)
                {
                    tong += int.Parse(row1.Cells[6].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Coot khong co gia tri");
                }
            }
            txttongthanhtoan.Text = tong.ToString("#,##0");
        }
        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            if (cbMaNCC.Text != "" && cbMaSP.Text != "" && txtSoLuong.Text != "")
            {
                this.Validate();
                this.chiTietNhapBindingSource.EndEdit();
                this.chiTietNhap1TableAdapter.Update(this.dataSet1);
                int tongTienNhap = int.Parse(txttongthanhtoan.Text.Replace(",", ""));
                DTO_HoaDonNhap hdn=new DTO_HoaDonNhap(txtMaHDN.Text+"    ",txtMaNV.Text,dtNgayXuatHD.Value,tongTienNhap);
                if (bushoadonnhap.edithdn(hdn))
                {
                    buschitietnhap.CapNhatSoLuong(dataSet1);
                    MessageBox.Show("Cập nhật thành công");
                    DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(txtMaNV.Text, DateTime.Now, "Tạo hóa đơn thành công", "Xác nhận tạo hóa đơn mới thành công mã " + txtMaHDN.Text + ".\nTổng tiền:" + tongTienNhap);
                    busnkhd.AddNKHD(nkhd);
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
                dataSet1.Tables["ChiTietNhap1"].Clear();
                this.Close();
            }
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txtSoLuong.Focus();
            }
        }

        
        private void ChiTietHDN_FormClosed(object sender, FormClosedEventArgs e)
        {
 
        }


        private void dgvCT_HDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCT_HDN.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                // Hiện hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Lấy hàng hiện tại
                    DataGridViewRow row = dgvCT_HDN.Rows[e.RowIndex];

                    // Gọi phương thức xóa trong lớp bus
                    if (buschitietnhap.XoaChiTietHDNTamThoi(txtMaHDN.Text, dataSet1))
                    {
                        // Cập nhật lại DataSet sau khi xóa
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
        }
    }
}

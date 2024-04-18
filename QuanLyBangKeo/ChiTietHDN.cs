using BUS_QuanLyBK;
using CrystalDecisions.ReportAppServer.DataDefModel;
using DTO_QuanLyBK;
using System;
using System.IO;
using System.Windows.Forms;

namespace QuanLyBangKeo
{
    public partial class ChiTietHDN : Form
    {
        BUS_ChiTietNhap buschitietnhap = new BUS_ChiTietNhap();
        BUS_HoaDonNhap bushoadonnhap = new BUS_HoaDonNhap();
        int tong;
        public ChiTietHDN()
        {
            InitializeComponent();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            cbMaNCC.DataSource = buschitietnhap.GetMaNCC();
            cbMaSP.DataSource = buschitietnhap.GetMaSanPham();

        }

        private void dgvCT_HDN_Click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCT_HDN.SelectedRows[0];
            cbMaSP.Text = row.Cells[1].Value.ToString();
            txtSoLuong.Text = row.Cells[2].Value.ToString();
            txtDGNhap.Text = row.Cells[3].Value.ToString();
            txtThanhTien.Text = row.Cells[4].Value.ToString();
        }

        private void cbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mancc = cbMaNCC.SelectedItem.ToString(); // Lấy mã khách hàng từ ComboBox
            string[] thongTinNCC = buschitietnhap.LayThongTinNCC(mancc); // Lấy thông tin khách hàng từ BLL

            txtTenNCC.Text = thongTinNCC[0];
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
                        DTO_ChiTietNhap ctn = new DTO_ChiTietNhap(txtMaHDN.Text, cbMaSP.Text, txtTenSP.Text, soluong, dongianhap, thanhtien);
                        buschitietnhap.addChiTietNhap(ctn, dataSet1);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvCT_HDN.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvCT_HDN.SelectedRows[0];
                // Xóa
                if (buschitietnhap.XoaChiTietHDNTamThoi(txtMaHDN.Text, dataSet1))
                {
                    MessageBox.Show("Xóa thành công");
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


        private void btnEdit_Click(object sender, EventArgs e)
        {
            int soluong, dongianhap, thanhtien;
            if (int.TryParse(txtSoLuong.Text, out soluong) && int.TryParse(txtDGNhap.Text, out dongianhap) && int.TryParse(txtThanhTien.Text, out thanhtien))
            {
                soluong = Convert.ToInt32(txtSoLuong.Text);
                dongianhap = Convert.ToInt32(txtDGNhap.Text);
                thanhtien = Convert.ToInt32(txtThanhTien.Text);
                DTO_ChiTietNhap ctn = new DTO_ChiTietNhap(txtMaHDN.Text, cbMaSP.Text, txtTenSP.Text, soluong, dongianhap, thanhtien);
                buschitietnhap.editChiTietNhap(ctn, dataSet1);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Funtion.ToExcel(dgvCT_HDN, @"D:\LapTrinhCSDL\QLBK", "_QL_ChiTietHoaDon", "chi tiet hoa don");
            MessageBox.Show("Xuất file Excel thành công");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            dataSet1.Tables["ChiTietNhap"].Clear();
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

                if (row1.Cells[5].Value != null)
                {
                    tong += int.Parse(row1.Cells[5].Value.ToString());
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
                this.chiTietNhapTableAdapter.Update(this.dataSet1);
                int tongTienNhap = int.Parse(txttongthanhtoan.Text.Replace(",", ""));
                DTO_HoaDonNhap hdn=new DTO_HoaDonNhap(txtMaHDN.Text+"    ",txtMaNV.Text,dtNgayXuatHD.Value,tongTienNhap);
                if (bushoadonnhap.edithdn(hdn))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
                dataSet1.Tables["ChiTietNhap"].Clear();
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

        private void dgvCT_HDN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCT_HDN.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCT_HDN.SelectedRows[0];

                string maSP = selectedRow.Cells[1].Value.ToString();
                string tenSP = selectedRow.Cells[2].Value.ToString();
                int soluong = (int)selectedRow.Cells[3].Value;
                int dgnhap = (int)selectedRow.Cells[4].Value;
                int thanhtien = (int)selectedRow.Cells[5].Value;
                
                // Gán dữ liệu lên các TextBox tương ứng
                cbMaSP.Text = maSP;
                txtTenSP.Text = tenSP;
                txtSoLuong.Text = soluong.ToString();
                txtDGNhap.Text = dgnhap.ToString();
                txtThanhTien.Text = thanhtien.ToString();
            }
        }

        private void ChiTietHDN_FormClosed(object sender, FormClosedEventArgs e)
        {
            HoaDonNhap hdn= new HoaDonNhap();
            hdn.Show();
        }

        private void button3_Click(object sender, EventArgs e)//btn_InHoaDon
        {
            if (cbMaNCC.Text != "" && cbMaSP.Text != "" && txtSoLuong.Text != "")
            {
                this.Validate();
                this.chiTietNhapBindingSource.EndEdit();
                this.chiTietNhapTableAdapter.Update(this.dataSet1);
                int tongTienNhap = int.Parse(txttongthanhtoan.Text.Replace(",", ""));
                DTO_HoaDonNhap hdn = new DTO_HoaDonNhap(txtMaHDN.Text + "    ", txtMaNV.Text, dtNgayXuatHD.Value, tongTienNhap);
                if (bushoadonnhap.edithdn(hdn))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
                dataSet1.Tables["ChiTietNhap"].Clear();
                ReportHDN rphdn= new ReportHDN();
                rphdn.SetMaHoaDonValue(txtMaHDN.Text,txtMaNV.Text);
                rphdn.ShowDialog();
            }
        }
    }
}

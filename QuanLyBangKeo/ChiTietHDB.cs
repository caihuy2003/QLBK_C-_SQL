using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyBK;
using DTO_QuanLyBK;

namespace QuanLyBangKeo
{
    public partial class ChiTietHDB : Form
    {
        BUS_ChiTietHDB buscthdb=new BUS_ChiTietHDB();
        BUS_HoaDonBan bushoadonban = new BUS_HoaDonBan();
        public ChiTietHDB()
        {
            InitializeComponent();
        }

        private void ChiTietHDB_Load(object sender, EventArgs e)
        {
            cbMaSP.DataSource = buscthdb.GetMaSanPham();
            txtGiamGia.Text = Convert.ToDouble(0).ToString();
        }
        public void SetMaHoaDonValue(string maHoaDon, string maNV,string maKH)
        {
            txtMaHDB.Text = maHoaDon;
            txtMaNV.Text = maNV;
            txtMaKH.Text = maKH;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text.ToString(); // Lấy mã khách hàng từ ComboBox
            string[] thongTinNV = buscthdb.LayThongTinNV(manv); // Lấy thông tin khách hàng từ BLL

            txtTenNV.Text = thongTinNV[0];
        }
        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            string maKH=txtMaKH.Text.ToString();
            string[] thongtinKH = buscthdb.LayThongTinKhachHang(maKH);
            txtTenKH.Text= thongtinKH[0];
            txtDiaChiKH.Text = thongtinKH[2];
            txtSDTKH.Text = thongtinKH[1];
        }

        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string masp = cbMaSP.SelectedItem.ToString(); // Lấy mã khách hàng từ ComboBox
            string[] thongTinSP = buscthdb.LayThongTinSP(masp); // Lấy thông tin khách hàng từ BLL

            txtTenSP.Text = thongTinSP[0];
            txtDGBan.Text = thongTinSP[1];
        }
        int sl, dg;
        double gg, tt;

        private void txtDGBan_TextChanged(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

            ThanhTien();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!buscthdb.kiemTramaSP(cbMaSP.Text, dgvct_hdb))
            {
                if ( cbMaSP.Text != "" && txtSoLuong.Text != "")
                {
                    int soluong, dongiaban ,thanhtien;
                    double giamgia;
                    if (int.TryParse(txtSoLuong.Text, out soluong) && int.TryParse(txtDGBan.Text, out dongiaban) && double.TryParse(txtGiamGia.Text,out giamgia) && int.TryParse(txtThanhTien.Text, out thanhtien))
                    {
                        soluong = Convert.ToInt32(txtSoLuong.Text);
                        dongiaban = Convert.ToInt32(txtDGBan.Text);
                        giamgia= Convert.ToDouble(txtGiamGia.Text);
                        thanhtien = Convert.ToInt32(txtThanhTien.Text);
                        DTO_ChiTietHDB ctb = new DTO_ChiTietHDB(txtMaHDB.Text, cbMaSP.Text, txtTenSP.Text, soluong, dongiaban,giamgia, thanhtien);
                        buscthdb.addChiTietHDB(ctb, dataSet11);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int soluong, dongiaban, thanhtien;
            double giamgia;
            if (int.TryParse(txtSoLuong.Text, out soluong) && int.TryParse(txtDGBan.Text, out dongiaban) && double.TryParse(txtGiamGia.Text, out giamgia) && int.TryParse(txtThanhTien.Text, out thanhtien))
            {
                soluong = Convert.ToInt32(txtSoLuong.Text);
                dongiaban = Convert.ToInt32(txtDGBan.Text);
                giamgia = Convert.ToDouble(txtGiamGia.Text);
                thanhtien = Convert.ToInt32(txtThanhTien.Text);
                DTO_ChiTietHDB ctb = new DTO_ChiTietHDB(txtMaHDB.Text, cbMaSP.Text, txtTenSP.Text, soluong, dongiaban,giamgia, thanhtien);
                buscthdb.editChiTietHDB(ctb, dataSet11);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvct_hdb.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvct_hdb.SelectedRows[0];
                // Xóa
                if (buscthdb.XoaChiTietHDBTamThoi(txtMaHDB.Text, dataSet11))
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Funtion.ToExcel(dgvct_hdb, @"D:\LapTrinhCSDL\QLBK", "_QL_ChiTietHoaDon", "chi tiet hoa don");
            MessageBox.Show("Xuất file Excel thành công");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            dataSet11.Tables["ChiTietHDB"].Clear();
            this.Close();
        }

        private void dgvct_hdb_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateTotal();
        }

        private void dgvct_hdb_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateTotal();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if ( cbMaSP.Text != "" && txtSoLuong.Text != "")
            {
                this.Validate();
                this.bindingSource1.EndEdit();
                this.chiTietHDBTableAdapter.Update(this.dataSet11);
                int tongTienBan = int.Parse(txttongthanhtoan.Text.Replace(",", ""));
                DTO_HoaDonBan hdb = new DTO_HoaDonBan(txtMaHDB.Text + "    ", txtMaNV.Text,txtMaKH.Text,dtNgayLap.Value, tongTienBan);
                if (bushoadonban.editHDB(hdb))
                {
                    buscthdb.CapNhatSoLuong(dataSet11);
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
                dataSet11.Tables["ChiTietHDB"].Clear();
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

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txtGiamGia.Focus();
            }
        }

        private void dgvct_hdb_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvct_hdb.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvct_hdb.SelectedRows[0];

                string maSP = selectedRow.Cells[1].Value.ToString();
                string tenSP = selectedRow.Cells[2].Value.ToString();
                int soluong = (int)selectedRow.Cells[3].Value;
                int dgban = (int)selectedRow.Cells[4].Value;
                double giamgia = (double)selectedRow.Cells[5].Value;
                int thanhtien = (int)selectedRow.Cells[6].Value;

                // Gán dữ liệu lên các TextBox tương ứng
                cbMaSP.Text = maSP;
                txtTenSP.Text = tenSP;
                txtSoLuong.Text = soluong.ToString();
                txtDGBan.Text = dgban.ToString();
                txtGiamGia.Text=giamgia.ToString();
                txtThanhTien.Text = thanhtien.ToString();
            }
        }

        private void ChiTietHDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataSet11.Tables["ChiTietHDB"].Clear();
            HoaDonBan hdb =new HoaDonBan();
            hdb.Show();
        }
        private bool inputChanged = false;

        private void txttienkhachdua_TextChanged(object sender, EventArgs e)
        {
            if (!inputChanged)
            {
                inputChanged = true;
            }
        }

        private void txttienkhachdua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txttienkhachdua.Focus();
            }
        }

        private void txttienkhachdua_Leave(object sender, EventArgs e)
        {
            if (inputChanged)
            {
                if (!string.IsNullOrEmpty(txttienkhachdua.Text))
                {
                    if (int.TryParse(txttienkhachdua.Text, out int tienkhachdua))
                    {
                        int tt = int.Parse(txttongthanhtoan.Text.Replace(",", ""));
                        if (tienkhachdua >= tt)
                        {
                            int tienthoi = tienkhachdua - tt;
                            txtthoilaikhach.Text = tienthoi.ToString("#,##0");
                        }
                        else
                        {
                            MessageBox.Show("Khách chưa đưa đủ tiền");
                            txttienkhachdua.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chỉ nhập số.");
                        txttienkhachdua.Text = ""; // Xóa nội dung không hợp lệ
                        txttienkhachdua.Focus();
                    }
                }
            }
            inputChanged = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbMaSP.Text != "" && txtSoLuong.Text != "")
            {
                this.Validate();
                this.bindingSource1.EndEdit();
                this.chiTietHDBTableAdapter.Update(this.dataSet11);
                int tongTienBan = int.Parse(txttongthanhtoan.Text.Replace(",", ""));
                DTO_HoaDonBan hdb = new DTO_HoaDonBan(txtMaHDB.Text + "    ", txtMaNV.Text, txtMaKH.Text, dtNgayLap.Value, tongTienBan);
                if (bushoadonban.editHDB(hdb))
                {
                    buscthdb.CapNhatSoLuong(dataSet11);
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
                dataSet11.Tables["ChiTietHDB"].Clear();
                ReportHDB rphdb = new ReportHDB();
                rphdb.SetMaHoaDonValue(txtMaHDB.Text, txtMaNV.Text, txtMaKH.Text);
                rphdb.Show();
            }
        }

        private void ThanhTien()
        {
            if (txtSoLuong.Text == "")
                sl = 0;
            else sl = Convert.ToInt32(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else gg = Convert.ToDouble(txtGiamGia.Text);
            dg = Convert.ToInt32(txtDGBan.Text);
            tt = (sl * dg) - (sl * dg) * (gg / 100);
            txtThanhTien.Text = tt.ToString();
        }
        private void UpdateTotal()
        {
            int tong = 0;
            for (int i = 1; i < dgvct_hdb.Rows.Count; i++)
            {
                DataGridViewRow row1 = dgvct_hdb.Rows[i - 1];

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
    }
}

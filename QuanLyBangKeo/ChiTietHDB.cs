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
        BUS_NhatKyHoatDong busnkhd=new BUS_NhatKyHoatDong();
        public ChiTietHDB()
        {
            InitializeComponent();
        }

        private void ChiTietHDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.ChiTietHDB1' table. You can move, or remove it, as needed.
            //this.chiTietHDB1TableAdapter.Fill(this.dataSet11.ChiTietHDB1);
            cbMaSP.DataSource = buscthdb.GetMaSanPham();
            dgvct_hdb.DataSource = buscthdb.getChiTietHDB(txtMaHDB.Text);
            txtGiamGia.Text = Convert.ToDouble(0).ToString();
            dgvct_hdb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tự động điều chỉnh kích thước cột cuối cùng để vừa với chiều rộng DataGridView
            dgvct_hdb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Image trashIcon = Properties.Resources.icons8_delete_50;
            Image resizedIcon = new Bitmap(trashIcon, new Size(20, 20));
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "DeleteColumn";
            imgColumn.HeaderText = "";
            imgColumn.Image = resizedIcon;
            imgColumn.Width = 10;
            //imgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvct_hdb.Columns.Add(imgColumn);
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
                        if (buscthdb.KiemTraSoLuong(cbMaSP.Text, soluong))
                        {
                            dongiaban = Convert.ToInt32(txtDGBan.Text);
                            giamgia = Convert.ToDouble(txtGiamGia.Text);
                            thanhtien = Convert.ToInt32(txtThanhTien.Text);
                            DTO_ChiTietHDB ctb = new DTO_ChiTietHDB(txtMaHDB.Text, cbMaSP.Text, soluong, giamgia, thanhtien,txtGhiChu.Text);
                            buscthdb.addChiTietHDB(ctb, dataSet11);
                            dgvct_hdb.DataSource = bindingSource1;
                        }
                        else
                        {
                            MessageBox.Show("So luong khong du cung cap");
                        }
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
            Funtion.ToExcel(dgvct_hdb, @"D:\LapTrinhCSDL\QLBK", "_QL_ChiTietHoaDon", "chi tiet hoa don");
            MessageBox.Show("Xuất file Excel thành công");
            DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(txtMaNV.Text, DateTime.Now, "Xuất file excel", "Xuất file chi tiết hóa đơn bán mã "+txtMaHDB.Text);
            busnkhd.AddNKHD(nkhd);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            dataSet11.Tables["ChiTietHDB1"].Clear();
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

       
        private void ChiTietHDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataSet11.Tables["ChiTietHDB1"].Clear();
        }
        private bool inputChanged = false;

        private void txttienkhachdua_TextChanged(object sender, EventArgs e)
        {
            if (!inputChanged)
            {
                inputChanged = true;
            }
        }


        private void dgvct_hdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvct_hdb.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                // Hiện hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Lấy hàng hiện tại
                    DataGridViewRow row = dgvct_hdb.Rows[e.RowIndex];

                    // Gọi phương thức xóa trong lớp bus
                    if (buscthdb.XoaChiTietHDBTamThoi(txtMaHDB.Text, dataSet11))
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

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            if (dgvct_hdb.RowCount > 1)
            {
                if (cbMaSP.Text != "" && txtSoLuong.Text != "")
                {
                    this.Validate();
                    this.bindingSource1.EndEdit();
                    this.chiTietHDB1TableAdapter.Update(this.dataSet11);
                    int tongTienBan = int.Parse(txttongthanhtoan.Text.Replace(",", ""));
                    DTO_HoaDonBan hdb = new DTO_HoaDonBan(txtMaHDB.Text + "    ", txtMaNV.Text, txtMaKH.Text, dtNgayLap.Value, tongTienBan, false);
                    if (bushoadonban.editHDB(hdb))
                    {
                        buscthdb.CapNhatSoLuong(dataSet11);
                        bushoadonban.CapNhatNoKhachHang(txtMaKH.Text,tongTienBan);
                        MessageBox.Show("Cập nhật thành công");
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(txtMaNV.Text, DateTime.Now, "Tạo hóa đơn thành công", "Xác nhận tạo hóa đơn mới thành công mã "+txtMaHDB.Text+ " không in hóa đơn. Đơn chưa thanh toán!!!\nTổng tiền:" + tongTienBan);
                        busnkhd.AddNKHD(nkhd);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công");
                    }
                    dataSet11.Tables["ChiTietHDB1"].Clear();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Chua co san pham nao");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dgvct_hdb.RowCount > 1)
            {
                if (cbMaSP.Text != "" && txtSoLuong.Text != "")
                {
                    this.Validate();
                    this.bindingSource1.EndEdit();
                    this.chiTietHDB1TableAdapter.Update(this.dataSet11);
                    int tongTienBan = int.Parse(txttongthanhtoan.Text.Replace(",", ""));
                    DTO_HoaDonBan hdb = new DTO_HoaDonBan(txtMaHDB.Text + "    ", txtMaNV.Text, txtMaKH.Text, dtNgayLap.Value, tongTienBan, false);
                    if (bushoadonban.editHDB(hdb))
                    {
                        buscthdb.CapNhatSoLuong(dataSet11);
                        bushoadonban.CapNhatNoKhachHang(txtMaKH.Text, tongTienBan);
                        MessageBox.Show("Cập nhật thành công");
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(txtMaNV.Text, DateTime.Now, "Tạo hóa đơn thành công", "Xác nhận tạo hóa đơn mới thành công mã " + txtMaHDB.Text + " có in hóa đơn. Đơn chưa thanh toán!!!\nTổng tiền:"+tongTienBan);
                        busnkhd.AddNKHD(nkhd);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công");
                    }
                    dataSet11.Tables["ChiTietHDB1"].Clear();
                    ReportHDB rphdb = new ReportHDB();
                    rphdb.SetMaHoaDonValue(txtMaHDB.Text, txtMaNV.Text, txtMaKH.Text);
                    rphdb.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Chua co san pham nao");
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

                if (row1.Cells[7].Value != null)
                {
                    tong += int.Parse(row1.Cells[7].Value.ToString());
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

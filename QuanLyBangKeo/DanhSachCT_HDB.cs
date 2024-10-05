using BUS_QuanLyBK;
using DTO_QuanLyBK;
using QuanLyBangKeo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBangKeo
{
    public partial class DanhSachCT_HDB : Form
    {
        BUS_ChiTietHDB buschitiethdb=new BUS_ChiTietHDB();
        BUS_NhatKyHoatDong busnkhd=new BUS_NhatKyHoatDong();
        public DanhSachCT_HDB()
        {
            InitializeComponent();
        }

        private void DanhSachCT_HDB_Load(object sender, EventArgs e)
        {
            if (buschitiethdb.KiemTraTrungMaHDB(txtMaHDB.Text))
            {
                dgvct_hdb.DataSource = buschitiethdb.getChiTietHDB(txtMaHDB.Text);
                dgvct_hdb.RowTemplate.Height = 30;
                dgvct_hdb.RowsDefaultCellStyle.BackColor = Color.DarkSlateBlue;
                dgvct_hdb.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateBlue;
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
        }
        public void SetValue(string maHoaDon, string maNV,string maKH, DateTime ngay, int tongtienban,bool dathanhtoan)
        {
            txtMaHDB.Text = maHoaDon;
            txtMaNV.Text = maNV;
            txtMaKH.Text = maKH;
            txtTongTienBan.Text = tongtienban.ToString();
            dtNgayXuatHD.Text = ngay.ToString();
            if(dathanhtoan)
            {
                lbTrangThai.Text = "Đã thanh toán";
            }
            else
            {
                lbTrangThai.Text = "Chưa thanh toán";
            }
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvct_hdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvct_hdb.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                // Hiện hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvct_hdb.SelectedRows[0];
                    string MaHDB = txtMaHDB.Text;
                    string maSP = dgvct_hdb.SelectedRows[0].Cells["MaSP"].Value.ToString();
                    if (buschitiethdb.XoaChiTietBan(MaHDB, maSP))
                    {
                        btnXN.Visible = true;
                        MessageBox.Show("Xóa thành công");
                        dgvct_hdb.DataSource = buschitiethdb.getChiTietHDB(txtMaHDB.Text); // refresh datagridview
                        DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(txtMaNV.Text, DateTime.Now, "Xóa chi tiết hóa đơn", "Xóa chi tiết hóa đơn mã " + MaHDB + ",mã sản phẩm " + maSP);
                        busnkhd.AddNKHD(nkhd);
                    }
                    else
                    {
                        MessageBox.Show("Xóa ko thành công");
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ReportHDB rphdb = new ReportHDB();
            rphdb.SetMaHoaDonValue(txtMaHDB.Text, txtMaNV.Text, txtMaKH.Text);
            rphdb.ShowDialog();
            DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(txtMaNV.Text, DateTime.Now, "In hóa đơn", "In hóa đơn mã " + txtMaHDB.Text);
            busnkhd.AddNKHD(nkhd);
        }
    }
}

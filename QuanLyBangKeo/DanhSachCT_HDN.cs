using BUS_QuanLyBK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Guna.UI2.WinForms.Suite.Descriptions;
using CrystalDecisions.ReportAppServer.DataDefModel;
using QuanLyBangKeo.Properties;
using QuanLyBangKeo;

namespace DAL_QuanLyBK
{
    public partial class DanhSachCT_HDN : Form
    {
        BUS_ChiTietNhap buschitietnhap=new BUS_ChiTietNhap();
        public DanhSachCT_HDN()
        {
            InitializeComponent();
        }

        private void DanhSachCT_HDN_Load(object sender, EventArgs e)
        {
            if (buschitietnhap.KiemTraTrungMaHDN(txtMaHDN.Text))
            {
                dgvct_hdn.DataSource = buschitietnhap.getChiTietNhap(txtMaHDN.Text);
                dgvct_hdn.RowTemplate.Height = 30;
                dgvct_hdn.RowsDefaultCellStyle.BackColor = Color.DarkSlateBlue;
                dgvct_hdn.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateBlue;
                dgvct_hdn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Tự động điều chỉnh kích thước cột cuối cùng để vừa với chiều rộng DataGridView
                dgvct_hdn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Image trashIcon = Resources.icons8_delete_50;
                Image resizedIcon = new Bitmap(trashIcon, new Size(20, 20));
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "DeleteColumn";
                imgColumn.HeaderText = "";
                imgColumn.Image = resizedIcon;
                imgColumn.Width = 10;
                //imgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvct_hdn.Columns.Add(imgColumn);
            }
        }
        public void SetValue(string maHoaDon,string maNV,DateTime ngay,int tongtiennhap)
        {
            txtMaHDN.Text = maHoaDon;
            txtMaNV.Text = maNV;
            txtTongTienNhap.Text = tongtiennhap.ToString();
            dtNgayXuatHD.Text = ngay.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvct_hdn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvct_hdn.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                // Hiện hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvct_hdn.SelectedRows[0];
                    string MaHDN=txtMaHDN.Text;
                    string maSP = dgvct_hdn.SelectedRows[0].Cells["MaSP"].Value.ToString();
                    if (buschitietnhap.XoaChiTietNhap(MaHDN,maSP))
                    {
                        btnXN.Visible = true;
                        MessageBox.Show("Xóa thành công");
                        dgvct_hdn.DataSource = buschitietnhap.getChiTietNhap(txtMaHDN.Text); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Xóa ko thành công");
                    }
                }
            }
        }
        private bool isUserDeletingRow = false;
        private void dgvct_hdn_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            isUserDeletingRow = true;
        }
        private void dgvct_hdn_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if(isUserDeletingRow)
            {
                int tong = int.Parse(txtTongTienNhap.ToString());
                for (int i = 1; i < dgvct_hdn.Rows.Count; i++)
                {
                    DataGridViewRow row1 = dgvct_hdn.Rows[i - 1];

                    if (row1.Cells[6].Value != null)
                    {
                        tong += int.Parse(row1.Cells[6].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Coot khong co gia tri");
                    }
                }
                txtTongTienNhap.Text = tong.ToString("#,##0");
                isUserDeletingRow = false;
            }
            
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

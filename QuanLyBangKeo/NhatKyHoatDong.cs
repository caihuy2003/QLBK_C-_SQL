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
using DAL_QuanLyBK;
using DTO_QuanLyBK;
namespace QuanLyBangKeo
{
    public partial class NhatKyHoatDong : Form
    {
        BUS_NhatKyHoatDong busnkhd=new BUS_NhatKyHoatDong();
        private string MaNV;
        public NhatKyHoatDong(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        private void NhatKyHoatDong_Load(object sender, EventArgs e)
        {
            dgvnkhd.DataSource = busnkhd.getNKHD();
            cbNV.DataSource=busnkhd.GetMaNV();
            dgvnkhd.RowTemplate.Height = 30;
            dgvnkhd.RowsDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dgvnkhd.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateBlue;

            dgvnkhd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tự động điều chỉnh kích thước cột cuối cùng để vừa với chiều rộng DataGridView
            dgvnkhd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLocNgay_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtLoc.Value.Date;
            (dgvnkhd.DataSource as DataTable).DefaultView.RowFilter = $"ThoiGian = #{selectedDate:MM/dd/yyyy}#";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cbNV.Text != "")
            {
                dgvnkhd.DataSource = busnkhd.findNKHD(cbNV.Text);
                MessageBox.Show("Tìm kiếm thành công");
            }
            else
            {
                MessageBox.Show("Xin hãy nhập thông tin cần tìm");
                dgvnkhd.DataSource = busnkhd.getNKHD();
            }
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            dgvnkhd.DataSource = busnkhd.getNKHD();
        }
    }
}

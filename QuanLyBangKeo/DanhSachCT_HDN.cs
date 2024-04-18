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
                dataGridView1.DataSource = buschitietnhap.getChiTietNhap(txtMaHDN.Text);
            }
        }
        public void SetValue(string maHoaDon,string maNV,DateTime ngay,int tongtiennhap)
        {
            txtMaHDN.Text = maHoaDon;
            txtMaNV.Text = maNV;
            txtTongTienNhap.Text = tongtiennhap.ToString();
            dtNgayXuatHD.Text = ngay.ToString();
        }
    }
}

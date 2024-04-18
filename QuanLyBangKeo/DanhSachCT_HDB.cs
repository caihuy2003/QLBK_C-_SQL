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

namespace QuanLyBangKeo
{
    public partial class DanhSachCT_HDB : Form
    {
        BUS_ChiTietHDB buschitiethdb=new BUS_ChiTietHDB();
        public DanhSachCT_HDB()
        {
            InitializeComponent();
        }

        private void DanhSachCT_HDB_Load(object sender, EventArgs e)
        {

        }
        public void SetValue(string maHoaDon, string maNV,string maKH, DateTime ngay, int tongtienban)
        {
            txtMaHDB.Text = maHoaDon;
            txtMaNV.Text = maNV;
            txtMaKH.Text = maKH;
            txtTongTienBan.Text = tongtienban.ToString();
            dtNgayXuatHD.Text = ngay.ToString();
        }
    }
}

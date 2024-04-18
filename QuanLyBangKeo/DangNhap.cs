using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_QuanLyBK;
using System.Windows.Forms;
using DTO_QuanLyBK;
using System.IO;

namespace QuanLyBangKeo
{
    public partial class DangNhap : Form
    {
        BUS_DangNhap busdangnhap=new BUS_DangNhap();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            cbchucvu.Text = cbchucvu.Items[1].ToString();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (busdangnhap.KiemTraTonTaiChucVuNV(cbchucvu.Text))
            {
                if (busdangnhap.KiemTraTonTaiNV(cbchucvu.Text, txtpass.Text))
                {
                    if(cbchucvu.Text=="Quản lý")
                    {
                        TrangChu trangchu = new TrangChu(true);
                        trangchu.ShowDialog();
                    }
                    else if (cbchucvu.Text == "Nhân viên")
                    {
                        TrangChu trangchu = new TrangChu(false);
                        trangchu.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại tài khoản vừa nhập");
            }
        }
    }
}

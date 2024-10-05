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
            guna2PictureBox1.BringToFront();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                guna2PictureBox2.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if(txtPass.PasswordChar=='\0')
            {
                guna2PictureBox1.BringToFront();
                txtPass.PasswordChar = '*';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (busdangnhap.KiemTraTaiKhoan(txtUser.Text))
            {
                if (busdangnhap.KiemTraTonTaiNV(txtUser.Text, txtPass.Text))
                {
                    var result = busdangnhap.LayTenVaQuyen(txtUser.Text, txtPass.Text);
                    if (result.tenQuyen == "Quản lý")
                    {
                        TrangChu trangchu = new TrangChu(true,result.HoTenNV,result.tenQuyen,result.hinhanh,result.MaNV);
                        trangchu.ShowDialog();
                    }
                    else if (result.tenQuyen == "Nhân viên bán hàng")
                    {
                        TrangChu trangchu = new TrangChu(false,result.HoTenNV,result.tenQuyen,result.hinhanh,result.MaNV);
                        trangchu.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không đúng!!!!");
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}

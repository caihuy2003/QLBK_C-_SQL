using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyBK;
using DTO_QuanLyBK;
using QuanLyBangKeo;

namespace QuanLyBangKeo
{
    public partial class TrangChu : Form
    {
        private bool isAdmin;
        public TrangChu(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            if(!isAdmin )
            {
                btn_nv.Enabled = false;
            }
        }
        string username;
        
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.AutoScroll = true;
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
 
        private void TrangChu_Load_1(object sender, EventArgs e)
        {
        }

        private void btn_nv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
            label1.Text = btn_nv.Text;
        }

        private void btn_kh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang());
            label1.Text = btn_kh.Text;
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDonBan());
            label1.Text = btn_BanHang.Text;
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDonNhap());
            label1.Text = btn_NhapHang.Text;
        }

        private void btn_SP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SanPham());
            label1.Text = btn_SP.Text;
        }

        private void btn_NCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhaCungCap());
            label1.Text = btn_NCC.Text;
        }

        private void btn_LSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoaiSanPham());
            label1.Text = btn_LSP.Text;
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = "Trang Chủ";
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất tài khoản?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                DangNhap dangnhap=new DangNhap();
                dangnhap.ShowDialog();
            }
        }

        private void TrangChu_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TKBC());
            label1.Text = "Thống kê và báo cáo";
        }
    }
}

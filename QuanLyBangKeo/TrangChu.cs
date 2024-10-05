using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyBK;
using CrystalDecisions.ReportAppServer.ReportDefModel;
using DTO_QuanLyBK;
using QuanLyBangKeo;

namespace QuanLyBangKeo
{
    public partial class TrangChu : Form
    {
        private bool isAdmin;
        public string MaNV { get; set; }  // Mã nhân viên
        BUS_TKBC bus_tkbc=new BUS_TKBC();
        BUS_NhatKyHoatDong busnkhd=new BUS_NhatKyHoatDong();
        public TrangChu(bool isAdmin,string HoTenNV,string tenQuyen, byte[] hinhanh,string MaNV)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.MaNV= MaNV;
            if(!isAdmin )
            {
                btn_nv.Visible = false;
                btnNKHD.Visible = false;
                btn_nh.Visible = false;
                btn_kh.Location = new System.Drawing.Point(1, 64);
                btn_ncc.Location = new System.Drawing.Point(1, 128);
                btn_bh.Location = new System.Drawing.Point(1, 192);
                btn_sp.Location = new System.Drawing.Point(1, 256);
                btn_lsp.Location = new System.Drawing.Point(1, 320);
                menuContainer.Location = new System.Drawing.Point(1, 384);
            }
            lbTenNV.Text= HoTenNV;
            lbQuyen.Text= tenQuyen;
            lbMaNV.Text= MaNV;
            if (hinhanh != null && hinhanh.Length > 0)
            {
                Image img;
                using (var ms = new MemoryStream(hinhanh))
                {
                    img = Image.FromStream(ms);
                }

                picNV.Image = img;
                picNV.Refresh(); // Thử thêm dòng này để cập nhật giao diện
            }
            else
            {
                picNV.Image = null;
            }
            DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Đăng nhập", "Đăng nhập vào tài khoản");
            busnkhd.AddNKHD(nkhd);
            btn_bcnv.Text = "Khách hàng,sản phẩm";
        }        
        private Form currentFormChild=null;
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
            //ResetButtonColors();
            //btn.BackColor = Color.Gray;
        }
        private void ResetButtonColors()
        {
            btn_kh.BackColor = Color.Black;
            btn_lsp.BackColor = Color.Black;
            btn_ncc.BackColor = Color.Black;
            btn_nh.BackColor = Color.Black;
            btn_nv.BackColor = Color.Black;
            btn_sp.BackColor = Color.Black;
            btn_tkbc.BackColor = Color.Black;
            btn_dt.BackColor = Color.Black;
            btn_bcnv.BackColor = Color.Black;
            btn_bh.BackColor = Color.Black;

        }
        private void TrangChu_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            DateTime today= DateTime.Now.Date;
            int soluongKH= bus_tkbc.GetDistinctCustomerIdsByDate(today);
            int soluongDon=bus_tkbc.GetOrderIdsByDate(today);
            int tienban = bus_tkbc.TienBanTrongNgay(today);
            int tiennhap = bus_tkbc.TienNhapTrongNgay(today);
            lbKH.Text = soluongKH.ToString();
            lbHDB.Text = soluongDon.ToString();
            lbBan.Text = tienban.ToString("#,##0");
            lbNhap.Text = tiennhap.ToString("#,##0");
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất tài khoản?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Đăng xuất", "Đăng xuất khỏi tài khoản");
                busnkhd.AddNKHD(nkhd);
                DangNhap dangnhap=new DangNhap();
                dangnhap.ShowDialog();
                this.Close();
            }
        }

        bool menuExpend = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpend)
            {
                menuContainer.Height += 10;
                if(menuContainer.Height >=158)
                {
                    menuTransition.Stop();
                    menuExpend=true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if(menuContainer.Height <=64)
                {
                    menuTransition.Stop();
                    menuExpend = false;
                }
            }
        }
        bool sideBar = true;
        private void slideBarTransition_Tick(object sender, EventArgs e)
        {
            if(sideBar)
            {
                panel_left.Width -= 10;
                if(panel_left.Width <=65)
                {
                    panel_left.ShadowShift=0;
                    sideBar = false;
                    slideBarTransition.Stop();

                }
            }
            else
            {
                panel_left.Width += 10;
                if (panel_left.Width >=250)
                {
                    sideBar=true;
                    slideBarTransition.Stop();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            slideBarTransition.Start();
        }

        private void btn_nv_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien(lbMaNV.Text));
            label1.Text = btn_nv.Text;
        }

        private void btn_kh_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang(lbMaNV.Text));
            label1.Text = btn_kh.Text;
        }

        private void btn_ncc_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new NhaCungCap(lbMaNV.Text));
            label1.Text = btn_ncc.Text;
        }

        private void btn_bh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDonBan(lbMaNV.Text));
            label1.Text = btn_bh.Text;
        }

        private void btn_nh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDonNhap(lbMaNV.Text));
            label1.Text = btn_nh.Text;
        }

        private void btn_sp_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new SanPham(lbMaNV.Text));
            label1.Text = btn_sp.Text;
        }

        private void btn_lsp_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new PhanLoai(lbMaNV.Text));
            label1.Text = btn_lsp.Text;
        }

        private void btn_tkbc_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void btn_dt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TKBC());
            label1.Text = "Thống kê và báo cáo doanh thu";
        }

        private void btn_bcnv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TKKH());
            label1.Text = "Thống kê và báo cáo khách hàng và nhân viên";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                DTO_NhatKyHoatDong nkhd = new DTO_NhatKyHoatDong(MaNV, DateTime.Now, "Đăng xuất", "Đăng xuất khỏi tài khoản");
                busnkhd.AddNKHD(nkhd);
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = "Trang Chủ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void btnNKHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhatKyHoatDong(lbMaNV.Text));
            label1.Text = btnNKHD.Text;
        }

    }
}

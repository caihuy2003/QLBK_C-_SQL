using DAL_QuanLyBK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyBK
{
    public class BUS_DangNhap
    {
        DAL_DangNhap daldangnhap= new DAL_DangNhap();
        public bool KiemTraTaiKhoan(string taikhoan)
        {
            return daldangnhap.KiemTraTaiKhoan(taikhoan);
        }
        public bool KiemTraTonTaiNV(string taikhoan,string matkhau)
        {
            return daldangnhap.KiemTraTonTaiNV(taikhoan,matkhau);
        }
        public (string MaNV,string HoTenNV, string tenQuyen, byte[] hinhanh) LayTenVaQuyen(string taikhoan, string matkhau)
        {
            return daldangnhap.LayTenVaQuyen(taikhoan,matkhau);
        }
    }
}

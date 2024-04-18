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
        public bool KiemTraTonTaiChucVuNV(string chucvu)
        {
            return daldangnhap.KiemTraTonTaiChucVuNV(chucvu);
        }
        public bool KiemTraTonTaiNV(string chucvu,string matkhau)
        {
            return daldangnhap.KiemTraTonTaiNV(chucvu,matkhau);
        }
    }
}

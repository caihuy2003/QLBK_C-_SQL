using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBK
{
    public class DTO_LoaiKhachHang
    {
        private string _MA_LKH;
        private string _TEN_LKH;
        public string MA_LKH
        {
            get { return _MA_LKH; }
            set { _MA_LKH = value; }
        }
        public string TEN_LKH
        {
            get { return _TEN_LKH; }
            set { _TEN_LKH = value; }
        }
        public DTO_LoaiKhachHang() { }
        public DTO_LoaiKhachHang(string id, string name)
        {
            this.MA_LKH = id;
            this.TEN_LKH = name;
        }
    }
}

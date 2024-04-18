using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBK
{
    public class DTO_KhachHang
    {
        private string _MA_KH;
        private string _TEN_KH;
        private string _DIACHI_KH;
        private string _SDT_KH;
        private string _GIOITINH_KH;
        public string MA_KH
        {
            get { return _MA_KH; }
            set { _MA_KH = value; }
        }
        public string TEN_KH
        {
            get { return _TEN_KH; }
            set { _TEN_KH = value; }
        }
        public string DIACHI_KH
        {
            get { return _DIACHI_KH; }
            set { _DIACHI_KH = value; }
        }
        public string SDT_KH
        {
            get { return _SDT_KH; }
            set { _SDT_KH = value; }
        }
        public string GIOITINH_KH
        {
            get { return _GIOITINH_KH; }
            set { _GIOITINH_KH = value; }
        }
        public DTO_KhachHang() { }
        public DTO_KhachHang(string id, string name, string address, string phone, string sex)
        {
            this.MA_KH = id;
            this.TEN_KH = name;
            this.DIACHI_KH = address;
            this.SDT_KH = phone;
            this.GIOITINH_KH = sex;
        }
    }
}

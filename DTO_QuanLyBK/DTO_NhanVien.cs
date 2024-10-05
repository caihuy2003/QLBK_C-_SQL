using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBK
{
    public class DTO_NhanVien
    {
        private string _MA_NV;
        private string _TEN_NV;
        private string _DIACHI_NV;
        private string _SDT_NV;
        private string _CHUCVU;
        private DateTime _NGAYVAOLAM;
        private string _GIOITINH_NV;
        private string _MATKHAU;
        private byte[] _HINHANH;
        private DateTime _NGAYSINH;
        private int _LUONG;
        private string _TAIKHOAN;
        private string _HO_NV;
        public string MA_NV
        {
            get { return _MA_NV; }
            set { _MA_NV = value; }
        }
        public string TEN_NV
        {
            get { return _TEN_NV; }
            set { _TEN_NV = value; }
        }
        public string DIACHI_NV
        {
            get { return _DIACHI_NV; }
            set { _DIACHI_NV = value; }
        }
        public string SDT_NV
        {
            get { return _SDT_NV; }
            set { _SDT_NV = value; }
        }
        public string CHUCVU
        {
            get { return _CHUCVU; }
            set { _CHUCVU = value; }
        }
        public DateTime NGAYVAOLAM
        {
            get { return _NGAYVAOLAM; }
            set { _NGAYVAOLAM = value; }
        }
        public string GIOITINH_NV
        {
            get { return _GIOITINH_NV; }
            set { _GIOITINH_NV = value; }
        }
        public string MATKHAU
        {
            get { return _MATKHAU; }
            set { _MATKHAU = value; }
        }
        public byte[] HINHANH
        {
            get { return _HINHANH; }
            set { _HINHANH = value; }
        }
        public DateTime NGAYSINH
        {
            get { return _NGAYSINH; }
            set { _NGAYSINH = value; }
        }
        public string TAIKHOAN
        {
            get { return _TAIKHOAN; }
            set { _TAIKHOAN = value; }
        }
        public string HONV
        {
            get { return _HO_NV; }
            set { _HO_NV = value; }
        }
        public int LUONG
        {
            get { return _LUONG; }
            set { _LUONG = value; }
        }
        public DTO_NhanVien() { }
        public DTO_NhanVien(string id, string ho,string name,DateTime ngaysinh, string address, string phone,string position,DateTime StartDay, string sex,string tk,string password, byte[] image,int luong)
        {
            this.MA_NV = id;
            this.TEN_NV = name;
            this.NGAYSINH=ngaysinh;
            this.DIACHI_NV = address;
            this.SDT_NV = phone;
            this.CHUCVU = position;
            this.NGAYVAOLAM = StartDay;
            this.GIOITINH_NV = sex;
            this.MATKHAU = password;
            this.HINHANH = image;
            this.LUONG = luong;
            this.HONV = ho;
            this.TAIKHOAN = tk;
        }
    }
}

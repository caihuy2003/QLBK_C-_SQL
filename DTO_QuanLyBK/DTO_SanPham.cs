using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBK
{
    public class DTO_SanPham
    {
        private string _MA_SP;
        private string _MA_NCC;
        private string _MA_LSP;
        private string _TEN_SP;
        private int _SOLUONG_SP;
        private byte[] _HINHANH;
        private int _DONGIANHAP;
        private int _DONGIABAN;
        private string _DVT;
        public string MA_SP
        {
            get { return _MA_SP; }
            set { _MA_SP = value; }
        }
        public string MA_NCC
        {
            get { return _MA_NCC; }
            set { _MA_NCC = value; }
        }
        public string MA_LSP
        {
            get { return _MA_LSP; }
            set { _MA_LSP = value; }
        }
        public string TEN_SP
        {
            get { return _TEN_SP; }
            set { _TEN_SP = value; }
        }
        public int DONGIANHAP
        {
            get { return _DONGIANHAP; }
            set { _DONGIANHAP = value; }
        }
        public int DONGIABAN
        {
            get { return _DONGIABAN; }
            set { _DONGIABAN = value; }
        }
        public byte[] HINHANH
        {
            get { return _HINHANH; }
            set { _HINHANH = value; }
        }
        public int SOLUONG_SP
        {
            get { return _SOLUONG_SP; }
            set { _SOLUONG_SP = value; }
        }
        public string DVT
        {
            get { return _DVT; }
            set { _DVT = value; }
        }
        public DTO_SanPham() { }
        public DTO_SanPham(string id,string idNCC,string idLSP, string name,int Soluong, string dvt, int dongianhap,int dongiaban, byte[] image)
        {
            this.MA_SP = id;
            this.TEN_SP = name;
            this.MA_NCC = idNCC;
            this.MA_LSP = idLSP;
            this.SOLUONG_SP = Soluong;
            this.HINHANH = image;
            this.DONGIANHAP = dongianhap;
            this.DONGIABAN = dongiaban;
            this.DVT = dvt;
        }
    }
}

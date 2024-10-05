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
        private int _TONCUOI;
        private byte[] _HINHANH;
        private int _DONGIANHAP;
        private int _DONGIABAN;
        private string _DVT;
        private int _TONDAU;
        private int _NHAP;
        private int _XUAT;
        private int _BICHTRENTHUNG;
        private string _GHICHU;
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
        public int TONCUOI
        {
            get { return _TONCUOI; }
            set { _TONCUOI = value; }
        }
        public string DVT
        {
            get { return _DVT; }
            set { _DVT = value; }
        }
        public int TONDAU
        {
            get { return _TONDAU; }
            set { _TONDAU = value; }
        }
        public int NHAP
        {
            get { return _NHAP; }
            set { _NHAP = value; }
        }
        public int XUAT
        {
            get { return _XUAT; }
            set { _XUAT = value; }
        }
        public int BICHTRENTHUNG
        {
            get { return _BICHTRENTHUNG; }
            set { _BICHTRENTHUNG = value; }
        }
        public string GHICHU
        {
            get { return _GHICHU; }
            set { _GHICHU = value; }
        }
        public DTO_SanPham() { }
        public DTO_SanPham(string id,string idNCC,string idLSP, string name, int dongianhap,int dongiaban,  string dvt,int tondau, int toncuoi,int bichtrenthung,string ghichu, byte[] image)
        {
            this.MA_SP = id;
            this.TEN_SP = name;
            this.MA_NCC = idNCC;
            this.MA_LSP = idLSP;
            this.TONCUOI = toncuoi;
            this.HINHANH = image;
            this.DONGIANHAP = dongianhap;
            this.DONGIABAN = dongiaban;
            this.DVT = dvt;
            this.GHICHU = ghichu;
            this.TONDAU = tondau;
            this.BICHTRENTHUNG = bichtrenthung;
        }
    }
}

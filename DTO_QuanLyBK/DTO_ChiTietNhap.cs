using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBK
{
    public class DTO_ChiTietNhap
    {
        private string _MA_HDN;
        private string _MA_SP;
        private int _SLNHAP;
        private int _THANHTIEN;
        private string _GHICHU;
        private string _TEN_SP;
        private string _DVT;
        private int _DonGiaNhap;
        public string MA_HDN
        {
            get { return _MA_HDN; }
            set { _MA_HDN = value; }
        }
        public string MA_SP
        {
            get { return _MA_SP; }
            set { _MA_SP = value; }
        }
        public string GHICHU
        {
            get { return _GHICHU; }
            set { _GHICHU = value; }
        }
        public int SLNHAP
        {
            get { return _SLNHAP; }
            set { _SLNHAP = value; }
        }
 
        public int THANHTIEN
        {
            get { return _THANHTIEN; }
            set { _THANHTIEN = value; }
        }
        public string TENSP
        {
            get { return _TEN_SP; }
            set { _TEN_SP = value; }
        }
        public string DVT
        {
            get { return _DVT; }
            set { _DVT = value; }
        }
        public int DONGIANHAP
        {
            get { return _DonGiaNhap; }
            set { _DonGiaNhap = value; }
        }
        public DTO_ChiTietNhap() { }
        public DTO_ChiTietNhap(string idhdn, string idsp, int sl, int thanhtien,string ghichu)
        {
            this.MA_HDN = idhdn;
            this.MA_SP = idsp;
            this.GHICHU = ghichu;
            this.SLNHAP = sl;
            this.THANHTIEN = thanhtien;
        }
    }
}

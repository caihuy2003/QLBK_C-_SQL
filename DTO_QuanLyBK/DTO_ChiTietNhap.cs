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
        private string _TEN_SP;
        private int _SLNHAP;
        private int _GIANHAP;
        private int _THANHTIEN;
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
        public string TEN_SP
        {
            get { return _TEN_SP; }
            set { _TEN_SP = value; }
        }
        public int SLNHAP
        {
            get { return _SLNHAP; }
            set { _SLNHAP = value; }
        }
        public int GIANHAP
        {
            get { return _GIANHAP; }
            set { _GIANHAP = value; }
        }
     
        public int THANHTIEN
        {
            get { return _THANHTIEN; }
            set { _THANHTIEN = value; }
        }
        public DTO_ChiTietNhap() { }
        public DTO_ChiTietNhap(string idhdn, string idsp,string tensp, int sl, int giaban, int thanhtien)
        {
            this.MA_HDN = idhdn;
            this.MA_SP = idsp;
            this.TEN_SP = tensp;
            this.SLNHAP = sl;
            this.GIANHAP = giaban;
            this.THANHTIEN = thanhtien;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBK
{
    public class DTO_HoaDonNhap
    {
        private string _MA_HDN;
        private string _MA_NV;
        private DateTime _NGAYXUATHD;
        private int _TONGTIENNHAP;
        public string MA_HDN
        {
            get { return _MA_HDN; }
            set { _MA_HDN = value; }
        }
        public string MA_NV
        {
            get { return _MA_NV; }
            set { _MA_NV = value; }
        }
       
        public DateTime NGAYXUATHD
        {
            get { return _NGAYXUATHD; }
            set { _NGAYXUATHD = value; }
        }
        public int TONGTIENNHAP
        {
            get { return _TONGTIENNHAP; }
            set { _TONGTIENNHAP = value; }
        }
        public DTO_HoaDonNhap() { }
        public DTO_HoaDonNhap(string idhdn, string idnv, DateTime ngayxuat, int tongtien)
        {
            this.MA_HDN = idhdn;
            this.MA_NV = idnv;
            this.NGAYXUATHD = ngayxuat;
            this.TONGTIENNHAP = tongtien;
        }
    }
}

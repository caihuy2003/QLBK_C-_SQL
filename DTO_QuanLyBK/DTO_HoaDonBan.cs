using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBK
{
    public class DTO_HoaDonBan
    {
        private string _MA_HDB;
        private string _MA_NV;
        private string _MA_KH;
        private DateTime _NGAYXUATHD;
        private int _TONGTIENBAN;
        private bool _DATHANHTOAN;
        public string MA_HDB
        {
            get { return _MA_HDB; }
            set { _MA_HDB = value; }
        }
        public string MA_NV
        {
            get { return _MA_NV; }
            set { _MA_NV = value; }
        }
        public string MA_KH
        {
            get { return _MA_KH; }
            set { _MA_KH = value; }
        }
        public DateTime NGAYXUATHD
        {
            get { return _NGAYXUATHD; }
            set { _NGAYXUATHD = value; }
        }
        public int TONGTIENBAN
        {
            get { return _TONGTIENBAN; }
            set { _TONGTIENBAN = value; }
        }
        public bool DATHANHTOAN
        {
            get { return _DATHANHTOAN; }
            set { _DATHANHTOAN = value; }
        }
        public DTO_HoaDonBan() { }
        public DTO_HoaDonBan(string idhdb, string idnv, string idkh, DateTime ngayxuat,int tongtien,bool dathanhtoan)
        {
            this.MA_HDB = idhdb;
            this.MA_NV = idnv;
            this.MA_KH = idkh;
            this.NGAYXUATHD = ngayxuat;
            this.TONGTIENBAN = tongtien;
            this.DATHANHTOAN=dathanhtoan;
        }
    }
}

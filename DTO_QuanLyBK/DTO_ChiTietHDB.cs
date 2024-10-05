using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBK
{
    public class DTO_ChiTietHDB
    {
        private string _MA_HDB;
        private string _MA_SP;
        private int _SLBAN;
        private double _CHIETKHAU;
        private int _THANHTIEN;
        private string _GHICHU;
        private string _TEN_SP;
        private string _DVT;
        private int _DonGiaBan;
        public string MA_HDB
        {
            get { return _MA_HDB; }
            set { _MA_HDB = value; }
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
        public int SLBAN
        {
            get { return _SLBAN; }
            set { _SLBAN = value; }
        }
        public double CHIETKHAU
        {
            get { return _CHIETKHAU; }
            set { _CHIETKHAU = value; }
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
        public int DONGIANBAN
        {
            get { return _DonGiaBan; }
            set { _DonGiaBan = value; }
        }
        public DTO_ChiTietHDB() { }
        public DTO_ChiTietHDB(string idhdb, string idsp, int sl,double chietkhau,int thanhtien,string ghichu)
        {
            this.MA_HDB = idhdb;
            this.MA_SP = idsp;
            this.GHICHU= ghichu;
            this.SLBAN = sl;
            this.CHIETKHAU = chietkhau;
            this.THANHTIEN = thanhtien;
        }
    }
}

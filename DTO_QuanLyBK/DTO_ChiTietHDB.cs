using System;
using System.Collections.Generic;
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
        private int _GIABAN;
        private double _GIAMGIA;
        private int _THANHTIEN;
        private string _TEN_SP;
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
        public string TEN_SP
        {
            get { return _TEN_SP; }
            set { _TEN_SP = value; }
        }
        public int SLBAN
        {
            get { return _SLBAN; }
            set { _SLBAN = value; }
        }
        public int GIABAN
        {
            get { return _GIABAN; }
            set { _GIABAN = value; }
        }
        public double GIAMGIA
        {
            get { return _GIAMGIA; }
            set { _GIAMGIA = value; }
        }
        public int THANHTIEN
        {
            get { return _THANHTIEN; }
            set { _THANHTIEN = value; }
        }
        public DTO_ChiTietHDB() { }
        public DTO_ChiTietHDB(string idhdb, string idsp,string tensp, int sl,int giaban,double giamgia,int thanhtien)
        {
            this.MA_HDB = idhdb;
            this.MA_SP = idsp;
            this.TEN_SP= tensp;
            this.SLBAN = sl;
            this.GIABAN = giaban;
            this.GIAMGIA = giamgia;
            this.THANHTIEN = thanhtien;
        }
    }
}

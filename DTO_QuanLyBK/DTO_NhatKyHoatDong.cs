using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBK
{
    public class DTO_NhatKyHoatDong
    {
        private string _MA_NV;
        private DateTime _THOIGIAN;
        private string _HOATDONG;
        private string _CHITIET;
        public string MA_NV
        {
            get { return _MA_NV; }
            set { _MA_NV = value; }
        }
        public string HOATDONG
        {
            get { return _HOATDONG; }
            set { _HOATDONG = value; }
        }
        public string CHITIET
        {
            get { return _CHITIET; }
            set { _CHITIET = value; }
        }
        public DateTime THOIGIAN
        {
            get { return _THOIGIAN; }
            set { _THOIGIAN = value; }
        }
        public DTO_NhatKyHoatDong() { }
        public DTO_NhatKyHoatDong(string idnv, DateTime tg, string hoatdong, string chitiet)
        {
            this.MA_NV = idnv;
            this.THOIGIAN=tg;
            this.HOATDONG = hoatdong;
            this.CHITIET=chitiet;
        }
    }
}

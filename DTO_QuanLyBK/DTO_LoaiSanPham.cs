using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBK
{
    public class DTO_LoaiSanPham
    {
        private string _MA_LSP;
        private string _TEN_LSP;
        private string _MOTA;
        public string MA_LSP
        {
            get { return _MA_LSP; }
            set { _MA_LSP = value; }
        }
        public string TEN_LSP
        {
            get { return _TEN_LSP; }
            set { _TEN_LSP = value; }
        }
        public string MOTA
        {
            get { return _MOTA; }
            set { _MOTA = value; }
        }
        public DTO_LoaiSanPham() { }
        public DTO_LoaiSanPham(string id, string name, string mota)
        {
            this.MA_LSP = id;
            this.TEN_LSP = name;
            this.MOTA = mota;
        }
    }
}

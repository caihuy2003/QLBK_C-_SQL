using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyBK
{
    public class DTO_NhaCungCap
    {
        private string _MA_NCC;
        private string _TEN_NCC;
        private string _DIACHI_NCC;
        private string _SDT_NCC;
        public string MA_NCC
        {
            get { return _MA_NCC; }
            set { _MA_NCC = value; }
        }
        public string TEN_NCC
        {
            get { return _TEN_NCC; }
            set { _TEN_NCC = value; }
        }
        public string DIACHI_NCC
        {
            get { return _DIACHI_NCC; }
            set { _DIACHI_NCC = value; }
        }
        public string SDT_NCC
        {
            get { return _SDT_NCC; }
            set { _SDT_NCC = value; }
        }

        public DTO_NhaCungCap() { }
        public DTO_NhaCungCap(string id, string name, string address, string phone)
        {
            this.MA_NCC = id;
            this.TEN_NCC = name;
            this.DIACHI_NCC = address;
            this.SDT_NCC = phone;
        }
    }
}

using DAL_QuanLyBK;
using DTO_QuanLyBK;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyBK
{
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap dalNhaCungCap = new DAL_NhaCungCap();
        public DataTable getNhaCungCap()
        {
            return dalNhaCungCap.getNhaCungCap();
        }
        public bool addNhaCungCap(DTO_NhaCungCap KH)
        {
            return dalNhaCungCap.addNhaCungCap(KH);
        }
        public bool editNhaCungCap(DTO_NhaCungCap KH)
        {
            return dalNhaCungCap.editNhaCungCap(KH);
        }
        public bool deleteNhaCungCap(string MaKH)
        {
            return dalNhaCungCap.deleteNhaCungCap(MaKH);
        }
        public DataTable findNhaCungCap(string cbFind, string txtFind)
        {
            return dalNhaCungCap.findNhaCungCap(cbFind, txtFind);
        }
        public bool KiemTraMaNhaCungCap(string MaNCC)
        {
            return dalNhaCungCap.KiemTraTrungMaNhaCungCap(MaNCC);
        }
        public bool checkcbFind(string cbFind)
        {
            if (cbFind != "Mã nhà cung cấp" && cbFind != "Tên nhà cung cấp")
            {
                return false;
            }

            return true;
        }
    }
}

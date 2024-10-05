using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyBK;
using DTO_QuanLyBK;
namespace BUS_QuanLyBK
{
    public class BUS_NhatKyHoatDong
    {
        DAL_NhatKyHoatDong dalnkhd = new DAL_NhatKyHoatDong();
        public DataTable getNKHD()
        {
            return dalnkhd.getNKHD();
        }
        public void AddNKHD(DTO_NhatKyHoatDong nkhd)
        {
            dalnkhd.addNKHD(nkhd);
        }
        public DataTable findNKHD(string txtFind)
        {
            return dalnkhd.findHoatDong(txtFind);
        }
        public List<string> GetMaNV()
        {
            return dalnkhd.GetMaNV();
        }
    }
}

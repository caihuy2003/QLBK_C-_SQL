using DAL_QuanLyBK;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyBK
{
    public class BUS_TKBC
    {
        DAL_TKBC daltkbc=new DAL_TKBC();
        public DataSet GetHoaDonBanHangByDay(DateTime dt)
        {
            return daltkbc.GetHoaDonBanHangByDay(dt);
        }
        public DataSet GetHoaDonBanHangByMonth(int month, int year)
        {
            return daltkbc.GetHoaDonBanHangByMonth(month, year);
        }
        public DataSet GetHoaDonBanHangByYear(int year)
        {
            return daltkbc.GetHoaDonBanHangByYear(year);
        }
        public DataSet GetHoaDonNhapHangByDay(DateTime dt)
        {
            return daltkbc.GetHoaDonNhapHangByDay(dt);
        }
        public DataSet GetHoaDonNhapHangByMonth(int month, int year)
        {
            return daltkbc.GetHoaDonNhapHangByMonth(month, year);
        }
        public DataSet GetHoaDonNhapHangByYear(int year)
        {
            return daltkbc.GetHoaDonNhapHangByYear(year);
        }
        public DataSet GetHoaDonBanHangByTotalAmountRange(int min, int max)
        {
            return daltkbc.GetHoaDonBanHangByTotalAmountRange(min,max);
        }
        public DataSet GetHoaDonNhapHangByTotalAmountRange(int min, int max)
        {
            return daltkbc.GetHoaDonNhapHangByTotalAmountRange(min, max);
        }
    }
}

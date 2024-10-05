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
        public int GetDistinctCustomerIdsByDate(DateTime date)
        {
            var customerID=daltkbc.GetDistinctCustomerIdsByDate(date);
            return customerID.Count;
        }
        public int GetOrderIdsByDate(DateTime date)
        {
            var orderID = daltkbc.GetOrderIdsByDate(date);
            return orderID.Count;
        }
        public int TienBanTrongNgay(DateTime date)
        {
            return daltkbc.TienBanTrongNgay(date);
        }
        public int TienNhapTrongNgay(DateTime date)
        {
            return daltkbc.TienNhapTrongNgay(date);
        }
        public DataSet DoanhThuTheoThang(int month, int year)
        {
            return daltkbc.DoanhThuTheoThang(month, year);
        }
        public DataSet DoanhThuTheoNam(int year)
        {
            return daltkbc.DoanhThuTheoNam(year);
        }
        public DataSet DoanhThuTheoQui(int year,int qui)
        {
            return daltkbc.DoanhThuTheoQui(year,qui);
        }
        public int TongBanTrongThang(int thang,int nam)
        {
            return daltkbc.TienBanTrongThang(thang,nam);
        }
        public int TongNhapTrongThang(int thang, int nam)
        {
            return daltkbc.TienNhapTrongThang(thang, nam);
        }
        public int TongBanTrongNam(int nam)
        {
            return daltkbc.TienBanTrongNam(nam);
        }
        public int TongNhapTrongNam(int nam)
        {
            return daltkbc.TienNhapTrongNam(nam);
        }
        public int TongBanTrongQui(int nam,int qui)
        {
            return daltkbc.TienBanTrongQui(nam,qui);
        }
        public int TongNhapTrongQui(int nam, int qui)
        {
            return daltkbc.TienNhapTrongQui(nam,qui);
        }
        public DataSet SanPhamTheoThang(int month, int year)
        {
            return daltkbc.SanPhamTheoThang(month, year);
        }
        public DataSet SanPhamTheoNam(int year)
        {
            return daltkbc.SanPhamTheoNam(year);
        }
        public DataSet SanPhamTheoQui(int year, int qui)
        {
            return daltkbc.SanPhamTheoQui(year, qui);
        }
        public int TongSPTrongThang(int thang, int nam)
        {
            return daltkbc.TongSPTrongThang(thang, nam);
        }
        public int TongSPTrongQui(int nam, int qui)
        {
            return daltkbc.TongSPTrongQui(nam, qui);
        }
        public int TongSPTrongNam(int nam)
        {
            return daltkbc.TongSPTrongNam(nam);
        }
        public DataSet KhachHangTheoThang(int month, int year)
        {
            return daltkbc.KhachHangTheoThang(month, year);
        }
        public DataSet KhachHangTheoNam(int year)
        {
            return daltkbc.KhachHangTheoNam(year);
        }
        public DataSet KhachHangTheoQui(int year, int qui)
        {
            return daltkbc.KhachHangTheoQui(year, qui);
        }
        public int TongKHTrongThang(int thang, int nam)
        {
            return daltkbc.TongKhachTrongThang(thang, nam);
        }
        public int TongKHTrongQui(int nam, int qui)
        {
            return daltkbc.TongKhachTrongQui(nam, qui);
        }
        public int TongKHTrongNam(int nam)
        {
            return daltkbc.TongKhachTrongNam(nam);
        }
    }
}

using DAL_QuanLyBK;
using DTO_QuanLyBK;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_QuanLyBK
{
    public class BUS_ChiTietNhap
    {
        DAL_ChiTietNhap dalchitietnhap=new DAL_ChiTietNhap();
        public DataTable getChiTietNhap(string MaHDN)
        {
            return dalchitietnhap.getChiTietNhap(MaHDN);
        }
        public bool addChiTietNhap(DTO_ChiTietNhap ct_hdn,DataSet dataSet)
        {
            return dalchitietnhap.ThemChiTietHDNTamThoi(ct_hdn,dataSet);
        }
        public bool editChiTietNhap(DTO_ChiTietNhap ct_hdn,DataSet dataSet)
        {
            return dalchitietnhap.SuaChiTietHDNTamThoi(ct_hdn,dataSet);
        }
        public bool XoaChiTietHDNTamThoi(string maHDN, DataSet dataSet)
        {
            return dalchitietnhap.XoaChiTietHDNTamThoi(maHDN,dataSet);
        }
        public bool deleteChiTietNhap(string MaHDN)
        {
            return dalchitietnhap.deleteChiTietNhap(MaHDN);
        }
        public List<string> GetMaSanPham()
        {
            return dalchitietnhap.GetMaSP();
        }
        public List<string> GetMaNCC()
        {
            return dalchitietnhap.GetMaNCC();
        }
        public List<string> GetMaNV()
        {
            return dalchitietnhap.GetMaNV();
        }
        public bool KiemTraTrungMaHDN(string MaHDN)
        {
            return dalchitietnhap.KiemTraTrungMaHDN(MaHDN);
        }
        public bool KiemTraTonTaiMaNV(string MaNV)
        {
            return dalchitietnhap.KiemTraTonTaiMaNV(MaNV); ;
        }

        public bool KiemTraTonTaiMaSP(string MaSP)
        {
            return dalchitietnhap.KiemTraTonTaiMaSP(MaSP);
        }
        public bool kiemtramaSP(string productID, DataGridView dataGridView)
        {
            return dalchitietnhap.kiemtramaSP(productID, dataGridView);
        }

        public bool KiemTraTonTaiMaNCC(string MaNCC)
        {
            return dalchitietnhap.KiemTraTonTaiMaNCC(MaNCC);
        }
        public bool checkcbFind(string cbFind)
        {
            if (cbFind != "Sản phẩm")
            {
                return false;
            }

            return true;
        }
        public string[] LayThongTinNCC(string MaNCC)
        {
            return dalchitietnhap.LayThongTinNCC(MaNCC);
        }
        public string[] LayThongTinSP(string MaSP)
        {
            return dalchitietnhap.LayThongTinSP(MaSP);
        }
        public string[] LayThongTinNV(string MaNV)
        {
            return dalchitietnhap.LayThongTinNV(MaNV);
        }
        public bool IsDateBeforeToday(DateTime selectedDate)
        {
            DateTime today = DateTime.Today;
            return selectedDate < today;
        }
        public DataSet GetHoaDonNhapHangByMaHDN(string MaHDN, string MaNV)
        {
            return dalchitietnhap.GetHoaDonNhapHangByMaHDN(MaHDN, MaNV);
        }
    }
}

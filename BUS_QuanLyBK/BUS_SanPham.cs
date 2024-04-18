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
    public class BUS_SanPham
    {
        DAL_SanPham dalSanPham = new DAL_SanPham();
        public DataTable getSanPham()
        {
            return dalSanPham.getSanPham();
        }
        public bool addSanPham(DTO_SanPham sp)
        {
            return dalSanPham.addSanPham(sp);
        }
        public bool editSanPham(DTO_SanPham sp)
        {
            return dalSanPham.editSanPham(sp);
        }
        public bool deleteSanPham(string MaSP)
        {
            return dalSanPham.deleteSanPham(MaSP);
        }
        public DataTable findSanPham(string cbFind, string txtFind)
        {
            return dalSanPham.findSanPham(cbFind, txtFind);
        }
        public List<string> GetMaLoaiSanPham()
        {
            return dalSanPham.GetMaLoaiSanPham();
        }
        public List<string> GetMaNhaCungCap()
        {
            return dalSanPham.GetMaNhaCungCap();
        }
        public bool KiemTraTonTaiMaNCC(string maNCC)
        {
            return dalSanPham.KiemTraTonTaiMaNCC(maNCC);
        }

        public bool KiemTraTonTaiMaLSP(string maLSP)
        {
            return dalSanPham.KiemTraTonTaiMaLSP(maLSP);
        }
        public bool KiemTraTrungMaSanPham(string MaSP)
        {
            return dalSanPham.KiemTraTrungMaSanPham(MaSP);
        }
        public bool checkcbFind(string cbFind)
        {
            if (cbFind != "Mã sản phẩm" && cbFind != "Tên sản phẩm")
            {
                return false;
            }

            return true;
        }
    }
}

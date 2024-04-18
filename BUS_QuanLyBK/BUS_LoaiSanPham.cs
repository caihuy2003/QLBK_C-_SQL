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
    public class BUS_LoaiSanPham
    {
        DAL_LoaiSanPham dalLoaiSanPham = new DAL_LoaiSanPham();
        public DataTable getLoaiSanPham()
        {
            return dalLoaiSanPham.getLoaiSanPham();
        }
        public bool addLoaiSanPham(DTO_LoaiSanPham lsp)
        {
            return dalLoaiSanPham.addLoaiSanPham(lsp);
        }
        public bool editLoaiSanPham(DTO_LoaiSanPham lsp)
        {
            return dalLoaiSanPham.editLoaiSanPham(lsp);
        }
        public bool deleteLoaiSanPham(string MaLSP)
        {
            return dalLoaiSanPham.deleteLoaiSanPham(MaLSP);
        }
        public DataTable findLoaiSanPham(string cbFind, string txtFind)
        {
            return dalLoaiSanPham.findLoaiSanPham(cbFind, txtFind);
        }
        public bool KiemTraMaLoaiSanPham(string MaLSP)
        {
            return dalLoaiSanPham.KiemTraTrungMaLoaiSanPham(MaLSP) ;
        }
        public bool checkcbFind(string cbFind)
        {
            if (cbFind != "Mã loại sản phẩm" && cbFind != "Tên loại sản phẩm")
            {
                return false;
            }

            return true;
        }
    }
}

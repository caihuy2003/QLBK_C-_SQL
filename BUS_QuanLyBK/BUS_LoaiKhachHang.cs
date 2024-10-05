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
    public class BUS_LoaiKhachHang
    {
        DAL_LoaiKhachHang dalLKH = new DAL_LoaiKhachHang();
        public DataTable getLoaiKhachHang()
        {
            return dalLKH.getLoaiKhachHang();
        }
        public bool addLoaiKhachHang(DTO_LoaiKhachHang lkh)
        {
            return dalLKH.addLoaiKhachHang(lkh);
        }
        public bool editLoaiKhachHang(DTO_LoaiKhachHang lkh)
        {
            return dalLKH.editLoaiKhachHang(lkh);
        }
        public bool deleteLoaiKhachHang(string MaLKH)
        {
            return dalLKH.deleteLoaiKhachHang(MaLKH);
        }
        public DataTable findLoaiKhachHang(string cbFind, string txtFind)
        {
            return dalLKH.findLoaiKhachHang(cbFind, txtFind);
        }
        public bool KiemTraMaLoaiKhachHang(string MaLKH)
        {
            return dalLKH.KiemTraTrungMaLoaiKhachHang(MaLKH);
        }
        public bool checkcbFind(string cbFind)
        {
            if (cbFind != "Mã loại khách hàng" && cbFind != "Tên loại khách hàng")
            {
                return false;
            }

            return true;
        }
    }
}

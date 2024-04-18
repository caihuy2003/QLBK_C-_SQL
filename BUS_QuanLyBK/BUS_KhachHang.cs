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
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();
        public DataTable getKhachHang()
        {
            return dalKhachHang.getKhachHang();
        }
        public bool addKhachHang(DTO_KhachHang KH)
        {
            return dalKhachHang.addKhachHang(KH);
        }
        public bool editKhachHang(DTO_KhachHang KH)
        {
            return dalKhachHang.editKhachHang(KH);
        }
        public bool deleteKhachHang(string MaKH)
        {
            return dalKhachHang.deleteKhachHang(MaKH);
        }
        public DataTable findKhachHang(string cbFind, string txtFind)
        {
            return dalKhachHang.findKhachHang(cbFind, txtFind);
        }
        public bool KiemTraTrungMaKhachHang(string MaKH)
        {
            return dalKhachHang.KiemTraTrungMaKhachHang(MaKH);
        }
        public bool IsComboBoxValueValid(string cbGioiTinh)
        {
            if (cbGioiTinh != "Nam" && cbGioiTinh != "Nữ")
            {
                return false;
            }
            return true;
        }
        public bool checkcbFind(string cbFind)
        {
            if (cbFind != "Mã khách hàng" && cbFind != "Tên khách hàng")
            {
                return false;
            }

            return true;
        }
    }
}

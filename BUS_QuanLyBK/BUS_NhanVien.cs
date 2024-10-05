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
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        public DataTable getNhanVien()
        {
            return dalNhanVien.getNhanVien();
        }
        public bool addNhanVien(DTO_NhanVien NV)
        {
            return dalNhanVien.addNhanVien(NV);
        }
        public bool editNhanVien(DTO_NhanVien NV)
        {
            return dalNhanVien.editNhanVien(NV);
        }
        public bool deleteNhanVien(string MaNV)
        {
            return dalNhanVien.deleteNhanVien(MaNV);
        }
        public DataTable findNhanVien(string cbFind, string txtFind)
        {
            return dalNhanVien.findNhanVien(cbFind, txtFind);
        }
        public bool KiemTraTrungMaNhanVien(string MaNV)
        {
            return dalNhanVien.KiemTraTrungMaNhanVien(MaNV);
        }
        public bool IsEmployeeAdult(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            DateTime eighteenYearsAgo = today.AddYears(-18);
            return dateOfBirth <= eighteenYearsAgo;
        }
        public bool IsDateBeforeToday(DateTime selectedDate)
        {
            DateTime today = DateTime.Today;
            return selectedDate < today || selectedDate==today;
        }
        public bool IsComboBoxValueValid(string cbChucVu,string cbGioiTinh)
        {
            if (cbChucVu != "QL        " && cbChucVu != "NVBH      " && cbChucVu !="NVK       ")
            {
                return false;
            }
            if (cbGioiTinh != "Nam  " && cbGioiTinh != "Nữ   ")
            {
                return false;
            }
            return true;
        }
        public bool checkcbFind(string cbFind)
        {
            if (cbFind != "Mã nhân viên" && cbFind != "Tên nhân viên")
            {
                return false;
            }
            
            return true;
        }
    }
}

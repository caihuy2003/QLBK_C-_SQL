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
    public class BUS_ChiTietHDB
    {
        DAL_ChiTietHDB dalchitiethdb = new DAL_ChiTietHDB();
        public DataTable getChiTietHDB(string MaHDB)
        {
            return dalchitiethdb.getChiTietHDB(MaHDB);
        }
        public bool addChiTietHDB(DTO_ChiTietHDB ct_hdb, DataSet dataSet)
        {
            return dalchitiethdb.ThemChiTietHDBTamThoi(ct_hdb, dataSet);
        }
        public bool editChiTietHDB(DTO_ChiTietHDB ct_hdb, DataSet dataSet)
        {
            return dalchitiethdb.SuaChiTietHDBTamThoi(ct_hdb, dataSet);
        }
        public bool XoaChiTietHDBTamThoi(string maHDB, DataSet dataSet)
        {
            return dalchitiethdb.XoaChiTietHDBTamThoi(maHDB, dataSet);
        }
        public bool deleteChiTietHDB(string maHDB,string MaSP)
        {
            return dalchitiethdb.deleteChiTietHDB(maHDB,MaSP);
        }
        public void CapNhatSoLuong(DataSet ds)
        {
            foreach (DataRow row in ds.Tables["ChiTietHDB1"].Rows)
            {
                string MaSP = row["MaSP"].ToString();
                int soluong = Convert.ToInt32(row["SLBan"]);

                dalchitiethdb.CapNhatSoLuong(MaSP, soluong);
            }
        }
        public List<string> GetMaSanPham()
        {
            return dalchitiethdb.GetMaSP();
        }
        public bool KiemTraTonTaiMaSP(string MaSP)
        {
            return dalchitiethdb.KiemTraTonTaiMaSP(MaSP);
        }
        
        public bool kiemTramaSP(string productID, DataGridView dataGridView)
        {
            return dalchitiethdb.kiemtramaSP(productID, dataGridView);
        }
        public string[] LayThongTinSP(string MaSP)
        {
            return dalchitiethdb.LayThongTinSP(MaSP);
        }
        public string[] LayThongTinNV(string MaNV)
        {
            return dalchitiethdb.LayThongTinNV(MaNV);
        }
        public string[] LayThongTinKhachHang(string MaKH)
        {
            return dalchitiethdb.LayThongTinKhachHang(MaKH);
        }
        public DataSet GetHoaDonBanHangByMaHDB(string MaHDB, string MaNV,string MaKH)
        {
            return dalchitiethdb.GetHoaDonBanHangByMaHDB(MaHDB,MaNV,MaKH);
        }
        public bool KiemTraSoLuong(string MaSP, int soluong)
        {
            return dalchitiethdb.KiemTraSoLuong(MaSP, soluong);
        }
        public bool KiemTraTrungMaHDB(string MaHDB)
        {
            return dalchitiethdb.KiemTraTrungMaHDB(MaHDB);
        }
        public bool XoaChiTietBan(string MaHDB, string MaSP)
        {
            return dalchitiethdb.XoaChiTietBan(MaHDB, MaSP);
        }
    }
}

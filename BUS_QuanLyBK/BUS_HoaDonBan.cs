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
    public class BUS_HoaDonBan
    {
        DAL_HoaDonBan dalhoadonban=new DAL_HoaDonBan();
        public DataTable getHoaDonBan()
        {
            return dalhoadonban.getHoaDonBan();
        }
        public bool addHDB(DTO_HoaDonBan hdb)
        {
            return dalhoadonban.addHoaDonBan(hdb);
        }
        public bool editHDB(DTO_HoaDonBan hdb)
        {
            return dalhoadonban.editHDB(hdb);
        }
        public bool deleteHDB(string MaHDB)
        {
            return dalhoadonban.deleteHoaDonBan(MaHDB);
        }
        public List<string> GetMaNV()
        {
            return dalhoadonban.GetMaNV();
        }
        public bool KiemTraTonTaiMaNV(string MaNV)
        {
            return dalhoadonban.KiemTraTonTaiMaNV(MaNV);
        }
        public string[] LayThongTinNV(string MaNV)
        {
            return dalhoadonban.LayThongTinNV(MaNV);
        }
        public List<string> GetMaKH()
        {
            return dalhoadonban.GetMaKH();
        }
        public bool KiemTraTonTaiMaKH(string MaKH)
        {
            return dalhoadonban.KiemTraTonTaiMaKH(MaKH);
        }
        public string[] LayThongTinKH(string MaKH)
        {
            return dalhoadonban.LayThongTinKH(MaKH);
        }
        public DataTable findHoaDon(string cbFind, string txtFind)
        {
            return dalhoadonban.findHoaDon(cbFind, txtFind);
        }
        public bool checkcbFind(string cbFind)
        {
            if (cbFind != "Mã hóa đơn" && cbFind != "Mã nhân viên" && cbFind !="Mã khách hàng")
            {
                return false;
            }

            return true;
        }
    }
}

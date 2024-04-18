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
    public class BUS_HoaDonNhap
    {
        DAL_HoaDonNhap dalhoadonnhap=new DAL_HoaDonNhap();
        public DataTable getHoaDonNhap()
        {
            return dalhoadonnhap.getHoaDonNhap();
        }
        public bool addHDN(DTO_HoaDonNhap hdn)
        {
            return dalhoadonnhap.addHDN(hdn);
        }
        public bool edithdn(DTO_HoaDonNhap hdn)
        {
            return dalhoadonnhap.editHDN(hdn);
        }
        public bool deleteHDN(string MaHDN)
        {
            return dalhoadonnhap.deleteHDN(MaHDN);
        }
        public List<string> GetMaNV()
        {
            return dalhoadonnhap.GetMaNV();
        }
        public bool KiemTraTonTaiMaNV(string MaNV)
        {
            return dalhoadonnhap.KiemTraTonTaiMaNV(MaNV);
        }
        public string[] LayThongTinNV(string MaNV)
        {
            return dalhoadonnhap.LayThongTinNV(MaNV);
        }
        public DataTable findHoaDon(string cbFind, string txtFind)
        {
            return dalhoadonnhap.findHoaDon(cbFind, txtFind);
        }
        public bool checkcbFind(string cbFind)
        {
            if (cbFind != "Mã hóa đơn" && cbFind != "Mã nhân viên")
            {
                return false;
            }

            return true;
        }
    }
}

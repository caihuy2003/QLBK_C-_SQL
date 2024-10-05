using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyBK;

namespace DAL_QuanLyBK
{
    public class DAL_NhatKyHoatDong:DBConnect
    {
        public DataTable getNKHD()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaLog,a.MaNV,TenNV,ThoiGian as 'Thời gian',HoatDong as 'Hoạt động',ChiTiet as 'Chi tiết hoạt động' FROM NhatKyHoatDong a join NHANVIEN b on a.MaNV=b.MaNV order by MaLog", _conn);
            DataTable dtnkhd = new DataTable();
            da.Fill(dtnkhd);
            return dtnkhd;
        }
        public void addNKHD(DTO_NhatKyHoatDong nkhd)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO NhatKyHoatDong(MaNV,ThoiGian,HoatDong,ChiTiet) VALUES ('{0}','{1}',N'{2}',N'{3}')", nkhd.MA_NV, nkhd.THOIGIAN, nkhd.HOATDONG,nkhd.CHITIET);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable findHoatDong(string txtFind)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT MaLog,a.MaNV,TenNV,ThoiGian as 'Thời gian',HoatDong as 'Hoạt động',ChiTiet as 'Chi tiết hoạt động' FROM NhatKyHoatDong a join NHANVIEN b on a.MaNV=b.MaNV WHERE a.MaNV like '{0}' order by MaLog",txtFind);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
        }
        public List<string> GetMaNV()
        {
            try
            {
                _conn.Open();
                List<string> maNV_List = new List<string>();
                string SQL = string.Format("SELECT MaNV FROM NHANVIEN where MaQuyen='QL' or MaQuyen='NVBH'");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maNV_List.Add(reader["MaNV"].ToString());
                }
                return maNV_List;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}

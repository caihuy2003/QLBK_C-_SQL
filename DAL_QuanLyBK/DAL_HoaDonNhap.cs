using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyBK;

namespace DAL_QuanLyBK
{
    public class DAL_HoaDonNhap:DBConnect
    {
        public DataTable getHoaDonNhap()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOADONNHAPHANG", _conn);
            DataTable dthoadonnhap = new DataTable();
            da.Fill(dthoadonnhap);
            return dthoadonnhap;
        }
        public bool addHDN(DTO_HoaDonNhap hdn)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO HOADONNHAPHANG(MaHDN,MaNV) VALUES ('{0}','{1}')", hdn.MA_HDN,hdn.MA_NV);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool editHDN(DTO_HoaDonNhap hdn)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE HOADONNHAPHANG SET MaNV='{0}',NgayXuatHDN='{1}',TongTienNhap={2} where MaHDN='{3}'",hdn.MA_NV,hdn.NGAYXUATHD,hdn.TONGTIENNHAP,hdn.MA_HDN);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool deleteHDN(string MaHDN)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM HOADONNHAPHANG where MaHDN='{0}'",MaHDN);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public List<string> GetMaNV()
        {
            try
            {
                _conn.Open();
                List<string> maNV_List = new List<string>();
                string SQL = string.Format("SELECT MaNV FROM NHANVIEN where MaQuyen='QL'");
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
        public bool KiemTraTonTaiMaNV(string maNV)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT COUNT(*) FROM NHANVIEN WHERE MaNV = @MaNV");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
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
        public string[] LayThongTinNV(string MaNV)
        {
            try
            {
                _conn.Open();
                string[] thongTinNV = new string[1]; // Mảng để lưu thông tin của khách hàng
                string SQL = string.Format("SELECT TenNV FROM NHANVIEN WHERE MaNV = '{0}'", MaNV);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) // Đọc dữ liệu từ SqlDataReader
                {
                    thongTinNV[0] = reader["TenNV"].ToString(); // Tên khách hàng
                }

                reader.Close();
                return thongTinNV;
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
        public DataTable findHoaDon(string cbFind, string txtFind)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT * FROM HOADONNHAPHANG WHERE");
                if (cbFind == "Mã hóa đơn")
                {
                    SQL += string.Format(" MaHDN like N'%" + txtFind.Trim() + "%'");
                }
                else if (cbFind == "Mã nhân viên")
                {
                    SQL += string.Format(" MaNV like N'%" + txtFind.Trim() + "%'");

                }
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
    }
}

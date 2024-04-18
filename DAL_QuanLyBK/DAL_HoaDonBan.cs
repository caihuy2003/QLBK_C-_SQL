using DTO_QuanLyBK;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBK
{
    public class DAL_HoaDonBan:DBConnect
    {
        public DataTable getHoaDonBan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOADONBANHANG", _conn);
            DataTable dthoadonban = new DataTable();
            da.Fill(dthoadonban);
            return dthoadonban;
        }
        public bool addHoaDonBan(DTO_HoaDonBan hdb)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO HOADONBANHANG(MaHDB,MaNV,MaKH) VALUES ('{0}','{1}','{2}')", hdb.MA_HDB, hdb.MA_NV, hdb.MA_KH);
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
        public bool editHDB(DTO_HoaDonBan hdb)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE HOADONBANHANG SET MaNV='{0}',MaKH='{1}',NgayXuatHDB='{2}',TongTienBan={3} where MaHDB='{4}'", hdb.MA_NV,hdb.MA_KH, hdb.NGAYXUATHD, hdb.TONGTIENBAN, hdb.MA_HDB);
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
        public bool deleteHoaDonBan(string MaHDB)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM HOADONBANHANG WHERE MaHDB='{0}'", MaHDB);
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
        public DataTable findSanPham(string cbFind, string txtFind)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT MaSP,MaNCC,MaLSP,TenSP,SoLuongSP,DVT,DonGiaNhap,DonGiaBan,HinhAnh FROM SANPHAM WHERE");
                if (cbFind == "Mã sản phẩm")
                {
                    SQL += string.Format(" MaSP like N'%" + txtFind.Trim() + "%'");
                }
                else if (cbFind == "Tên sản phẩm")
                {
                    SQL += string.Format(" TenSP like N'%" + txtFind.Trim() + "%'");

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
        public List<string> GetMaNV()
        {
            try
            {
                _conn.Open();
                List<string> maNV_List = new List<string>();
                string SQL = string.Format("SELECT MaNV FROM NHANVIEN");
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

        public List<string> GetMaKH()
        {
            try
            {
                _conn.Open();
                List<string> maKHList = new List<string>();
                string SQL = string.Format("SELECT MaKH FROM KHACHHANG");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maKHList.Add(reader["MaKH"].ToString());
                }
                return maKHList;

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
        public bool KiemTraTonTaiMaKH(string maKH)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT COUNT(*) FROM KHACHHANG WHERE MaKH = @MaKH");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
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
        public string[] LayThongTinKH(string MaKH)
        {
            try
            {
                _conn.Open();
                string[] thongTinKH = new string[1]; // Mảng để lưu thông tin của khách hàng
                string SQL = string.Format("SELECT TenKH FROM KHACHHANG WHERE MaKH = '{0}'", MaKH);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) // Đọc dữ liệu từ SqlDataReader
                {
                    thongTinKH[0] = reader["TenKH"].ToString(); // Tên khách hàng
                }

                reader.Close();
                return thongTinKH;
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
                string SQL = string.Format("SELECT * FROM HOADONBANHANG WHERE");
                if (cbFind == "Mã hóa đơn")
                {
                    SQL += string.Format(" MaHDB like N'%" + txtFind.Trim() + "%'");
                }
                else if (cbFind == "Mã nhân viên")
                {
                    SQL += string.Format(" MaNV like N'%" + txtFind.Trim() + "%'");

                }
                else if (cbFind == "Mã khách hàng")
                {
                    SQL += string.Format(" MaKH like N'%" + txtFind.Trim() + "%'");

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

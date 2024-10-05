using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLyBK;
using System.Drawing;
using PagedList;

namespace DAL_QuanLyBK
{
    public class DAL_KhachHang : DBConnect
    {
        public DataTable getKhachHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaKH,TenKH,DiaChiKH,SDT_KH,GioiTinhKH,TienNo,MaLKH FROM dbo.KHACHHANG order by MaKH", _conn);
            DataTable dtKhachHang = new DataTable();
            da.Fill(dtKhachHang);
            return dtKhachHang;
        }
        public bool addKhachHang(DTO_KhachHang KH)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO KHACHHANG(MaKH,TenKH,DiaChiKH,SDT_KH,GioiTinhKH,TienNo,MaLKH) VALUES ('{0}',N'{1}',N'{2}','{3}',N'{4}',0,'{5}')", KH.MA_KH, KH.TEN_KH, KH.DIACHI_KH, KH.SDT_KH, KH.GIOITINH_KH,KH.MA_LKH);
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
        public bool editKhachHang(DTO_KhachHang KH)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE KHACHHANG SET TenKH=N'{0}' ,DiaChiKH=N'{1}',SDT_KH='{2}',GioiTinhKH=N'{3}',MaLKH='{5}' where MaKH='{4}'", KH.TEN_KH, KH.DIACHI_KH, KH.SDT_KH, KH.GIOITINH_KH, KH.MA_KH,KH.MA_LKH);
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
        public bool deleteKhachHang(string MaKH)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM KHACHHANG WHERE MaKH='{0}'", MaKH);
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
        public DataTable findKhachHang(string cbFind, string txtFind)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT * FROM KHACHHANG WHERE");
                if (cbFind == "Mã khách hàng")
                {
                    SQL += string.Format(" MaKH like '%" + txtFind.Trim() + "%' order by MaKH");
                }
                else if (cbFind == "Tên khách hàng")
                {
                    SQL += string.Format(" TenKH like '%" + txtFind.Trim() + "%' order by MaKH");

                }
                else if (cbFind == "Mã loại khách hàng")
                {
                    SQL += string.Format(" MaLKH like '%" + txtFind.Trim() + "%' order by MaKH");

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
        public bool KiemTraTrungMaKhachHang(string MaKH)
        {
            try
            {
                _conn.Open();
                string SQL = "SELECT COUNT(*) FROM KHACHHANG WHERE MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaKH", MaKH);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
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
        public List<string> GetMaLKH()
        {
            try
            {
                _conn.Open();
                List<string> maLKH_List = new List<string>();
                string SQL = string.Format("SELECT MaLKH FROM LOAIKHACHHANG");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maLKH_List.Add(reader["MaLKH"].ToString());
                }
                return maLKH_List;

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
        public void CapNhatNoKhachHang(string MaKH,int tienno)
        {
            try
            {
                _conn.Open();
                string query = "UPDATE KHACHHANG SET TienNo = @TienNo WHERE MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@TienNo", tienno);
                cmd.Parameters.AddWithValue("@MaKH", MaKH);
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
    }
}

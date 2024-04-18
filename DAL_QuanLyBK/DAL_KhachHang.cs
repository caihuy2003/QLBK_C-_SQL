using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLyBK;
using System.Drawing;

namespace DAL_QuanLyBK
{
    public class DAL_KhachHang : DBConnect
    {
        public DataTable getKhachHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.KHACHHANG", _conn);
            DataTable dtKhachHang = new DataTable();
            da.Fill(dtKhachHang);
            return dtKhachHang;
        }
        public bool addKhachHang(DTO_KhachHang KH)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO KHACHHANG(MaKH,TenKH,DiaChiKH,SDT_KH,GioiTinhKH) VALUES ('{0}',N'{1}',N'{2}','{3}',N'{4}')", KH.MA_KH, KH.TEN_KH, KH.DIACHI_KH, KH.SDT_KH, KH.GIOITINH_KH);
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
                string SQL = string.Format("UPDATE KHACHHANG SET TenKH=N'{0}' ,DiaChiKH=N'{1}',SDT_KH='{2}',GioiTinhKH=N'{3}' where MaKH='{4}'", KH.TEN_KH, KH.DIACHI_KH, KH.SDT_KH, KH.GIOITINH_KH, KH.MA_KH);
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
                    SQL += string.Format(" MaKH like '%" + txtFind.Trim() + "%'");
                }
                else if (cbFind == "Tên khách hàng")
                {
                    SQL += string.Format(" TenKH like '%" + txtFind.Trim() + "%'");

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
    }
}

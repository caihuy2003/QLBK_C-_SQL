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
    public class DAL_LoaiKhachHang:DBConnect
    {
        public DataTable getLoaiKhachHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaLKH as 'Mã loại khách hàng', TenLKH as 'Tên loại khách hàng' FROM LOAIKHACHHANG", _conn);
            DataTable dtLoaiKhachHang = new DataTable();
            da.Fill(dtLoaiKhachHang);
            return dtLoaiKhachHang;
        }
        public bool addLoaiKhachHang(DTO_LoaiKhachHang lkh)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO LOAIKHACHHANG(MaLKH,TenLKH) VALUES ('{0}',N'{1}')", lkh.MA_LKH, lkh.TEN_LKH);
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
        public bool editLoaiKhachHang(DTO_LoaiKhachHang lkh)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE LOAIKHACHHANG SET TenLKH=N'{0}' where MaLKH='{1}'", lkh.TEN_LKH, lkh.MA_LKH);
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
        public bool deleteLoaiKhachHang(string MaLKH)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM LOAIKHACHHANG WHERE MaLKH='{0}'", MaLKH);
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
        public DataTable findLoaiKhachHang(string cbFind, string txtFind)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT * FROM LOAIKHACHHANG WHERE");
                if (cbFind == "Mã loại khách hàng")
                {
                    SQL += string.Format(" MaLKH like '%" + txtFind.Trim() + "%'");
                }
                else if (cbFind == "Tên loại khách hàng")
                {
                    SQL += string.Format(" TenLKH like '%" + txtFind.Trim() + "%'");

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
        public bool KiemTraTrungMaLoaiKhachHang(string MaLKH)
        {
            try
            {
                _conn.Open();
                string SQL = "SELECT COUNT(*) FROM LOAIKHACHHANG WHERE MaLKH = @MaLKH";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaLKH", MaLKH);
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBK
{
    public class DAL_DangNhap:DBConnect
    {
        
        public bool KiemTraTonTaiChucVuNV(string chucvu)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT COUNT(*) FROM NHANVIEN WHERE ChucVu = @ChucVu");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@ChucVu", chucvu);
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
        public bool KiemTraTonTaiNV(string chucvu,string matkhau)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT COUNT(*) FROM NHANVIEN WHERE ChucVu = @ChucVu AND MatKhau=@MatKhau");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@ChucVu", chucvu);
                cmd.Parameters.AddWithValue("@MatKhau", matkhau);
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

    }
}

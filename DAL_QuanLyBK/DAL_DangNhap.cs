using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBK
{
    public class DAL_DangNhap:DBConnect
    {
        
        public bool KiemTraTaiKhoan(string taikhoan)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT COUNT(*) FROM NHANVIEN WHERE TaiKhoan = @taikhoan");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
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
        public bool KiemTraTonTaiNV(string taikhoan,string matkhau)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT COUNT(*) FROM NHANVIEN WHERE TaiKhoan = @taikhoan AND MatKhau=@MatKhau");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
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
        public (string MaNV,string HoTenNV,string tenQuyen, byte[] hinhanh) LayTenVaQuyen(string taikhoan, string matkhau)
        {
            string MaNV = null;
            string HoTenNV = null;
            string tenQuyen = null;
            byte[] hinhanh = null;
            try
            {
                _conn.Open();
                string SQL = @"SELECT NV.MaNV,(NV.HoNV+' '+NV.TenNV) as HoTenNV, PQ.TenQuyen,NV.HinhAnh FROM NHANVIEN NV INNER JOIN PHANQUYEN PQ ON NV.MaQuyen = PQ.MaQuyen WHERE NV.TaiKhoan = @TaiKhoan AND NV.MatKhau = @MatKhau";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@TaiKhoan", taikhoan);
                cmd.Parameters.AddWithValue("@MatKhau", matkhau);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MaNV = reader["MaNV"].ToString();
                    HoTenNV = reader["HoTenNV"].ToString();
                    tenQuyen = reader["TenQuyen"].ToString();
                    if (reader["HinhAnh"] != DBNull.Value)
                    {
                        hinhanh = (byte[])reader["HinhAnh"];
                    }
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
            return (MaNV,HoTenNV, tenQuyen,hinhanh);
        }
    }
}

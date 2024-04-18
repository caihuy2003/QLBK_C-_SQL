﻿using DTO_QuanLyBK;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBK
{
    public class DAL_NhanVien:DBConnect
    {
        public DataTable getNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaNV,TenNV,NgaySinh,DiaChiNV,SDT_NV,ChucVu,NgayVaoLam,GioiTinh,MatKhau,HinhAnh FROM dbo.NHANVIEN", _conn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            return dtNhanVien;
        }
        public bool addNhanVien(DTO_NhanVien NV)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO NHANVIEN(MaNV,TenNV,DiaChiNV,SDT_NV,ChucVu,NgayVaoLam,GioiTinh,MatKhau,HinhAnh,NgaySinh) VALUES ('{0}',N'{1}',N'{2}','{3}',N'{4}','{5}',N'{6}',N'{7}',@HinhAnh,'{8}')", NV.MA_NV, NV.TEN_NV, NV.DIACHI_NV, NV.SDT_NV,NV.CHUCVU,NV.NGAYVAOLAM, NV.GIOITINH_NV,NV.MATKHAU,NV.NGAYSINH);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@HinhAnh",NV.HINHANH);
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
        public bool editNhanVien(DTO_NhanVien NV)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE NHANVIEN SET TenNV=N'{0}' ,DiaChiNV=N'{1}',SDT_NV='{2}',ChucVu=N'{3}',NgayVaoLam='{4}',GioiTinh=N'{5}',MatKhau='{6}',HinhAnh= @HinhAnh, NgaySinh='{9}' where MaNV='{8}'",
                    NV.TEN_NV, NV.DIACHI_NV, NV.SDT_NV,NV.CHUCVU,NV.NGAYVAOLAM, NV.GIOITINH_NV,NV.MATKHAU,NV.HINHANH, NV.MA_NV,NV.NGAYSINH);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@HinhAnh", NV.HINHANH);
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
        public bool deleteNhanVien(string MaNV)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM NHANVIEN WHERE MaNV='{0}'", MaNV);
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
        public DataTable findNhanVien(string cbFind, string txtFind)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT MaNV,TenNV,NgaySinh,DiaChiNV,SDT_NV,ChucVu,NgayVaoLam,GioiTinh,MatKhau,HinhAnh FROM NHANVIEN WHERE");
                if (cbFind == "Mã nhân viên")
                {
                    SQL += string.Format(" MaNV like N'%" + txtFind.Trim() + "%'");
                }
                else if (cbFind == "Tên nhân viên")
                {
                    SQL += string.Format(" TenNV like N'%" + txtFind.Trim() + "%'");

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
        public bool KiemTraTrungMaNhanVien(string MaNV)
        {
            try
            {
                _conn.Open();
                string SQL = "SELECT COUNT(*) FROM NHANVIEN WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
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

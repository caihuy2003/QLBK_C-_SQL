using DTO_QuanLyBK;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyBK;
using System.Collections;
using System.Text.RegularExpressions;

namespace DAL_QuanLyBK
{
    public class DAL_SanPham:DBConnect
    {
        
        public DataTable getSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaSP,MaNCC,MaLSP,TenSP,DonGiaNhap,DonGiaBan,DVT,TonDau as 'Tồn đầu',Nhap,Xuat,TonCuoi as 'Tồn cuối',BichTrenThung as 'Bịch/Thùng',GhiChu as 'Ghi chú',HinhAnh FROM dbo.SANPHAM", _conn);
            DataTable dtsanpham = new DataTable();
            da.Fill(dtsanpham);
            return dtsanpham;
        }
        public bool addSanPham(DTO_SanPham sp)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO SANPHAM(MaSP,MaNCC,MaLSP,TenSP,DonGiaNhap,DonGiaBan,DVT,TonDau,Nhap,Xuat,TonCuoi,BichTrenThung,GhiChu,HinhAnh) VALUES ('{0}','{1}','{2}',N'{3}',{4},{5},N'{6}',{7},0,0,{7},{8},N'{9}',@HinhAnh)", sp.MA_SP,sp.MA_NCC,sp.MA_LSP, sp.TEN_SP,sp.DONGIANHAP,sp.DONGIABAN, sp.DVT,sp.TONCUOI,sp.BICHTRENTHUNG,sp.GHICHU);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@HinhAnh", sp.HINHANH);
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
        public bool editSanPham(DTO_SanPham sp)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE SANPHAM SET MaNCC='{0}',MaLSP='{1}', TenSP=N'{2}',TonCuoi={3},DVT=N'{4}',DonGiaNhap={5},DonGiaBan={6},BichTrenThung={8},GhiChu=N'{9}',HinhAnh= @HinhAnh where MaSP='{7}'",
                    sp.MA_NCC,sp.MA_LSP,sp.TEN_SP,sp.TONCUOI,sp.DVT,sp.DONGIANHAP,sp.DONGIABAN, sp.MA_SP,sp.BICHTRENTHUNG,sp.GHICHU);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@HinhAnh", sp.HINHANH);
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
        public bool deleteSanPham(string MaSP)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM SANPHAM WHERE MaSP='{0}'", MaSP);
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
                string SQL = string.Format("Select MaSP,MaNCC,MaLSP,TenSP,DonGiaNhap,DonGiaBan,DVT,TonDau as 'Tồn đầu',Nhap,Xuat,TonCuoi as 'Tồn cuối',BichTrenThung as 'Bịch/Thùng',GhiChu as 'Ghi chú',HinhAnh FROM SANPHAM WHERE");
                if (cbFind == "Mã sản phẩm")
                {
                    SQL += string.Format(" MaSP like N'%" + txtFind.Trim() + "%'");
                }
                else if (cbFind == "Mã nhà cung cấp")
                {
                    SQL += string.Format(" MaNCC like N'%" + txtFind.Trim() + "%'");

                }
                else if (cbFind == "Mã loại sản phẩm")
                {
                    SQL += string.Format(" MaLSP like N'%" + txtFind.Trim() + "%'");

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
        public List<string> GetMaLoaiSanPham()
        {
            try
            {
                _conn.Open();
                List<string> maLSP_List = new List<string>();
                string SQL = string.Format("SELECT MaLSP FROM LOAISANPHAM");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maLSP_List.Add(reader["MaLSP"].ToString());
                }
                return maLSP_List;

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

        public List<string> GetMaNhaCungCap()
        {
            try
            {
                _conn.Open();
                List<string> maNhaCungCapList = new List<string>();
                string SQL = string.Format("SELECT MaNCC FROM NHACUNGCAP");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maNhaCungCapList.Add(reader["MaNCC"].ToString());
                }
                return maNhaCungCapList;

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
        public bool KiemTraTonTaiMaNCC(string maNCC)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT COUNT(*) FROM NHACUNGCAP WHERE MaNCC = @MaNCC");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaNCC", maNCC);
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

        public bool KiemTraTonTaiMaLSP(string maLSP)
        {

            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT COUNT(*) FROM LOAISANPHAM WHERE MaLSP = @MaLSP");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaLSP", maLSP);
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
        public bool KiemTraTrungMaSanPham(string MaSP)
        {
            try
            {
                _conn.Open();
                string SQL = "SELECT COUNT(*) FROM SANPHAM WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaSP", MaSP);
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

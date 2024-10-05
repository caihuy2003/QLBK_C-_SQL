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
    public class DAL_LoaiSanPham : DBConnect
    {
        public DataTable getLoaiSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaLSP as 'Mã loại sản phẩm', TenLSP as 'Tên loại sản phẩm' FROM LOAISANPHAM", _conn);
            DataTable dtLoaiSanPham = new DataTable();
            da.Fill(dtLoaiSanPham);
            return dtLoaiSanPham;
        }
        public bool addLoaiSanPham(DTO_LoaiSanPham lsp)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO LOAISANPHAM(MaLSP,TenLSP) VALUES ('{0}',N'{1}')", lsp.MA_LSP, lsp.TEN_LSP);
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
        public bool editLoaiSanPham(DTO_LoaiSanPham lsp)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE LOAISANPHAM SET TenLSP=N'{0}' where MaLSP='{1}'", lsp.TEN_LSP, lsp.MA_LSP);
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
        public bool deleteLoaiSanPham(string MaLSP)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM LOAISANPHAM WHERE MaLSP='{0}'", MaLSP);
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
        public DataTable findLoaiSanPham(string cbFind, string txtFind)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT * FROM LOAISANPHAM WHERE");
                if (cbFind == "Mã loại sản phẩm")
                {
                    SQL += string.Format(" MaLSP like '%" + txtFind.Trim() + "%'");
                }
                else if (cbFind == "Tên loại sản phẩm")
                {
                    SQL += string.Format(" TenLSP like '%" + txtFind.Trim() + "%'");

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
        public bool KiemTraTrungMaLoaiSanPham(string MaLSP)
        {
            try
            {
                _conn.Open();
                string SQL = "SELECT COUNT(*) FROM LOAISANPHAM WHERE MaLSP = @MaLSP";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaLSP", MaLSP);
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

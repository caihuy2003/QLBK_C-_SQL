using DTO_QuanLyBK;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBK
{
    public class DAL_NhaCungCap : DBConnect
    {
        public DataTable getNhaCungCap()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.NHACUNGCAP", _conn);
            DataTable dtNhaCungCap = new DataTable();
            da.Fill(dtNhaCungCap);
            return dtNhaCungCap;
        }
        public bool addNhaCungCap(DTO_NhaCungCap ncc)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO NHACUNGCAP(MaNCC,TenNCC,DiaChiNCC,SDTNCC) VALUES ('{0}',N'{1}',N'{2}','{3}')", ncc.MA_NCC, ncc.TEN_NCC, ncc.DIACHI_NCC, ncc.SDT_NCC);
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
        public bool editNhaCungCap(DTO_NhaCungCap ncc)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE NHACUNGCAP SET TenNCC=N'{0}' ,DiaChiNCC=N'{1}',SDTNCC='{2}' where MaNCC='{3}'", ncc.TEN_NCC, ncc.DIACHI_NCC, ncc.SDT_NCC, ncc.MA_NCC);
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
        public bool deleteNhaCungCap(string MaNCC)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM NHACUNGCAP WHERE MaNCC='{0}'", MaNCC);
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
        public DataTable findNhaCungCap(string cbFind, string txtFind)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT * FROM NHACUNGCAP WHERE");
                if (cbFind == "Mã nhà cung cấp")
                {
                    SQL += string.Format(" MaNCC like '%" + txtFind.Trim() + "%'");
                }
                else if (cbFind == "Tên nhà cung cấp")
                {
                    SQL += string.Format(" TenNCC like '%" + txtFind.Trim() + "%'");

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
        public bool KiemTraTrungMaNhaCungCap(string MaNCC)
        {
            try
            {
                _conn.Open();
                string SQL = "SELECT COUNT(*) FROM NHACUNGCAP WHERE MaNCC = @MaNCC";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaNCC", MaNCC);
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

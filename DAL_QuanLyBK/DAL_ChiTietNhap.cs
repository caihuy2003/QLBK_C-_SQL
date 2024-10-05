using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyBK;
using System.Windows.Forms;

namespace DAL_QuanLyBK
{
    public class DAL_ChiTietNhap:DBConnect
    {
        public DataTable getChiTietNhap(string MaHDN)
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();

                string SQL = "SELECT a.MaHDN,a.MaSP, b.TenSP, b.DVT,a.SLNhap,b.DonGiaNhap, a.ThanhTien, a.GhiChu FROM dbo.ChiTietNhap a join dbo.SANPHAM b on a.MaSP=b.MaSP where MaHDN=@MaHDN";

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaHDN", MaHDN);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu chi tiết nhập: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return dt;

        }

        public bool ThemChiTietHDNTamThoi(DTO_ChiTietNhap ct_hdn, DataSet dataSet)
        {
            try
            {
                _conn.Open();
                string query = "SELECT TenSP, DVT,DonGiaNhap FROM SANPHAM WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@MaSP", ct_hdn.MA_SP);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ct_hdn.TENSP = reader["TenSP"].ToString();
                    ct_hdn.DVT = reader["DVT"].ToString();
                    ct_hdn.DONGIANHAP = Convert.ToInt32(reader["DonGiaNhap"]);
                }
                // Thêm dòng vào DataTable tạm thời
                DataRow newRow = dataSet.Tables["ChiTietNhap1"].NewRow();
                newRow["MaHDN"] = ct_hdn.MA_HDN;
                newRow["MaSP"] = ct_hdn.MA_SP;
                newRow["TenSP"]=ct_hdn.TENSP;
                newRow["DVT"] = ct_hdn.DVT;
                newRow["SLNhap"] = ct_hdn.SLNHAP;
                newRow["DonGiaNhap"] = ct_hdn.DONGIANHAP;
                newRow["ThanhTien"] = ct_hdn.THANHTIEN;
                newRow["GhiChu"] = ct_hdn.GHICHU;
                dataSet.Tables["ChiTietNhap1"].Rows.Add(newRow);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close ();
            }
        }
        public bool SuaChiTietHDNTamThoi(DTO_ChiTietNhap ct_hdn, DataSet dataSet)
        {
            try
            {
                // Tìm dòng cần sửa trong DataTable tạm thời
                DataRow[] rows = dataSet.Tables["ChiTietNhap1"].Select($"MaSP = '{ct_hdn.MA_SP}'");
                if (rows.Length > 0)
                {
                    rows[0]["MaHDN"] = ct_hdn.MA_HDN;
                    rows[0]["SLNhap"] = ct_hdn.SLNHAP;
                    rows[0]["ThanhTien"] = ct_hdn.THANHTIEN;
                    rows[0]["GhiChu"]=ct_hdn.GHICHU;
                    return true;
                }
                return false; // Không tìm thấy dòng cần sửa
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaChiTietHDNTamThoi(string maHDN, DataSet dataSet)
        {
            try
            {
                // Tìm dòng cần xóa trong DataTable tạm thời
                DataRow[] rows = dataSet.Tables["ChiTietNhap1"].Select($"MaHDN = '{maHDN}'");
                if (rows.Length > 0)
                {
                    rows[0].Delete();
                    return true;
                }
                return false; // Không tìm thấy dòng cần xóa
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        
        public bool deleteChiTietNhap(string MaHDN,string MaSP)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM CHITIETNHAP WHERE MaHDN='{0}' AND MaSP='{1}'",MaHDN,MaSP);
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

        public List<string> GetMaNCC()
        {
            try
            {
                _conn.Open();
                List<string> maNCC_List = new List<string>();
                string SQL = string.Format("SELECT MaNCC FROM NHACUNGCAP");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maNCC_List.Add(reader["MaNCC"].ToString());
                }
                return maNCC_List;

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
        public List<string> GetMaSP(string mancc)
        {
            try
            {
                _conn.Open();
                List<string> maSP_List = new List<string>();
                string SQL = string.Format("SELECT MaSP FROM SANPHAM where MaNCC=@MaNCC");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaNCC", mancc);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maSP_List.Add(reader["MaSP"].ToString());
                }
                return maSP_List;

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
        public bool KiemTraTrungMaHDN(string MaHDN)
        {
            try
            {
                _conn.Open();
                string SQL = "SELECT COUNT(*) FROM HOADONNHAPHANG WHERE MaHDN = @MaHDN";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaHDN", MaHDN);
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
        public bool KiemTraTonTaiMaSP(string maSP)
        {

            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT COUNT(*) FROM SANPHAM WHERE MaSP = @MaSP");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
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
        public bool kiemtramaSP(string productID, DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == productID)
                {
                    return true; 
                }
                else
                {
                    return false;
                }
            }
            
            return false; 
        }
        public string[] LayThongTinNCC(string MaNCC)
        {
            try
            {
                _conn.Open();
                string[] thongTinNCC = new string[1]; // Mảng để lưu thông tin của khách hàng
                string SQL = string.Format("SELECT TenNCC FROM NHACUNGCAP WHERE MaNCC = '{0}'", MaNCC);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) // Đọc dữ liệu từ SqlDataReader
                {
                    thongTinNCC[0] = reader["TenNCC"].ToString(); // Tên khách hàng
                }

                reader.Close();
                return thongTinNCC;
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
        public string[] LayThongTinSP(string MaSP)
        {
            try
            {
                _conn.Open();
                string[] thongTinSP = new string[3]; // Mảng để lưu thông tin của khách hàng
                string SQL = string.Format("SELECT MaNCC,TenSP,DonGiaNhap FROM SANPHAM WHERE MaSP = '{0}'", MaSP);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) // Đọc dữ liệu từ SqlDataReader
                {
                    thongTinSP[0] = reader["TenSP"].ToString();
                    thongTinSP[1] = reader["DonGiaNhap"].ToString();
                    thongTinSP[2] = reader["MaNCC"].ToString();
                }

                reader.Close();
                return thongTinSP;
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
        public DataSet GetHoaDonNhapHangByMaHDN(string MaHDN,string MaNV)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetHoaDonNhapHangByMaHDN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@MaHDN", MaHDN));
            cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public void CapNhatSoLuong(string MaSP, int soluong)
        {
            try
            {
                _conn.Open();
                string SQL = "UPDATE SANPHAM SET TonCuoi = TonCuoi + @SoLuong,Nhap=Nhap+@SoLuong WHERE MaSP = @MaSanPham";

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaSanPham", MaSP);
                cmd.Parameters.AddWithValue("@SoLuong", soluong);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    throw new Exception("Không tìm thấy sản phẩm cần cập nhật.");
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
        }
        public bool XoaChiTietNhap(string MaHDN,string MaSP)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("XoaChiTietNhap", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaHDN", MaHDN);
                cmd.Parameters.AddWithValue("@MaSP", MaSP);
                cmd.ExecuteNonQuery();
                return true;
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

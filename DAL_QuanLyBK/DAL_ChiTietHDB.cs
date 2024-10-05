using DTO_QuanLyBK;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_QuanLyBK
{
    public class DAL_ChiTietHDB:DBConnect
    {
        public DataTable getChiTietHDB(string MaHDB)
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();

                string SQL = "SELECT MaHDB, a.MaSP, TenSP,DVT, SLBan, DonGiaBan,ChietKhau, ThanhTien,a.GhiChu FROM CHITIETHDB a join SANPHAM b on a.MaSP=b.MaSP WHERE MaHDB = @MaHDB";

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaHDB", MaHDB);

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
        public bool ThemChiTietHDBTamThoi(DTO_ChiTietHDB ct_hdb, DataSet dataSet)
        {
            try
            {
                _conn.Open();
                string query = "SELECT TenSP, DVT,DonGiaBan FROM SANPHAM WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@MaSP", ct_hdb.MA_SP);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ct_hdb.TENSP = reader["TenSP"].ToString();
                    ct_hdb.DVT = reader["DVT"].ToString();
                    ct_hdb.DONGIANBAN = Convert.ToInt32(reader["DonGiaBan"]);
                }
                // Thêm dòng vào DataTable tạm thời
                DataRow newRow = dataSet.Tables["ChiTietHDB1"].NewRow();
                newRow["MaHDB"] = ct_hdb.MA_HDB;
                newRow["MaSP"] = ct_hdb.MA_SP;
                newRow["TenSP"] = ct_hdb.TENSP;
                newRow["DVT"]=ct_hdb.DVT;
                newRow["SLBan"] = ct_hdb.SLBAN;
                newRow["DonGiaBan"] = ct_hdb.DONGIANBAN;
                newRow["ChietKhau"] = ct_hdb.CHIETKHAU;
                newRow["ThanhTien"] = ct_hdb.THANHTIEN;
                newRow["GhiChu"] = ct_hdb.GHICHU;
                dataSet.Tables["ChiTietHDB1"].Rows.Add(newRow);
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
        public bool SuaChiTietHDBTamThoi(DTO_ChiTietHDB ct_hdb, DataSet dataSet)
        {
            try
            {
                // Tìm dòng cần sửa trong DataTable tạm thời
                DataRow[] rows = dataSet.Tables["ChiTietHDB1"].Select($"MaSP = '{ct_hdb.MA_SP}'");
                if (rows.Length > 0)
                {
                    rows[0]["MaHDB"] = ct_hdb.MA_HDB;
                    //rows[0]["TenSP"] = ct_hdb.TEN_SP;
                    rows[0]["SLBan"] = ct_hdb.SLBAN;
                    //rows[0]["GiaBan"] = ct_hdb.GIABAN; 
                    //rows[0]["GiamGia"] = ct_hdb.GIAMGIA;
                    rows[0]["ThanhTien"] = ct_hdb.THANHTIEN;
                    return true;
                }
                return false; // Không tìm thấy dòng cần sửa
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaChiTietHDBTamThoi(string maHDB, DataSet dataSet)
        {
            try
            {
                // Tìm dòng cần xóa trong DataTable tạm thời
                DataRow[] rows = dataSet.Tables["ChiTietHDB1"].Select($"MaHDB = '{maHDB}'");
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
        public bool deleteChiTietHDB(string MaHDB,string MaSP)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM CHITIETHDB WHERE MaHDB='{0}' AND MaSP='{1}'", MaHDB,MaSP);
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
        public void CapNhatSoLuong(string MaSP, int soluong)
        {
            try
            {
                _conn.Open();
                string SQL = "UPDATE SANPHAM SET TonCuoi = TonCuoi - @SoLuong,Xuat=Xuat+@SoLuong WHERE MaSP = @MaSanPham";

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
        public bool KiemTraSoLuong(string MaSP, int soluong)
        {
            try
            {
                _conn.Open();
                string SQL = "SELECT TonCuoi FROM SANPHAM WHERE MaSP = @MaSanPham";

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaSanPham", MaSP);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    int soluongsanpham = reader.GetInt32(0);
                    if (soluong < soluongsanpham)
                        return true;
                }
                return false;
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
        public List<string> GetMaSP()
        {
            try
            {
                _conn.Open();
                List<string> maSP_List = new List<string>();
                string SQL = string.Format("SELECT MaSP FROM SANPHAM");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
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
     
        public string[] LayThongTinKhachHang(string MaKH)
        {
            try
            {
                _conn.Open();
                string[] thongTinKhachHang = new string[3]; // Mảng để lưu thông tin của khách hàng
                string SQL = string.Format("SELECT TenKH, SDT_KH,DiaChiKH FROM KHACHHANG WHERE MaKH = '{0}'", MaKH);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) // Đọc dữ liệu từ SqlDataReader
                {
                    thongTinKhachHang[0] = reader["TenKH"].ToString(); // Tên khách hàng
                    thongTinKhachHang[1] = reader["SDT_KH"].ToString(); // Địa chỉ khách hàng
                    thongTinKhachHang[2] = reader["DiaChiKH"].ToString(); // Số điện thoại khách hàng
                }

                reader.Close();
                return thongTinKhachHang;
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
                string[] thongTinSP = new string[2]; // Mảng để lưu thông tin của khách hàng
                string SQL = string.Format("SELECT TenSP,DonGiaBan FROM SANPHAM WHERE MaSP = '{0}'", MaSP);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) // Đọc dữ liệu từ SqlDataReader
                {
                    thongTinSP[0] = reader["TenSP"].ToString();
                    thongTinSP[1] = reader["DonGiaBan"].ToString();
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
        public DataSet GetHoaDonBanHangByMaHDB(string MaHDB, string MaNV,string MaKH)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "HienDanhSachChiTietHoaDonBan";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@MaHDB", MaHDB));
            cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            cmd.Parameters.Add(new SqlParameter("@MaKH", MaKH));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public bool KiemTraTrungMaHDB(string MaHDB)
        {
            try
            {
                _conn.Open();
                string SQL = "SELECT COUNT(*) FROM HOADONBANHANG WHERE MaHDB = @MaHDB";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaHDB", MaHDB);
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
        public bool XoaChiTietBan(string MaHDB, string MaSP)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("XoaChiTietBan", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaHDB", MaHDB);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_QuanLyBK
{
    public class DAL_TKBC:DBConnect
    {
        public List<string> GetDistinctCustomerIdsByDate(DateTime date)
        {
            var customerIds = new List<string>();
            try
            {
                _conn.Open();
                string SQL = @"SELECT DISTINCT MaKH FROM HOADONBANHANG WHERE CONVERT(DATE,NgayXuatHDB) = @Date";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@Date", date.Date);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            string MaKH = reader.GetString(0);
                            customerIds.Add(MaKH.Trim());
                        }
                        catch (InvalidCastException ex)
                        {
                            // Xử lý lỗi kiểu dữ liệu
                            Console.WriteLine($"Error casting value: {ex.Message}");
                        }
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
            return customerIds;
        }
        public List<string> GetOrderIdsByDate(DateTime date)
        {
            var orderIds = new List<string>();
            try
            {
                _conn.Open();
                string SQL = @"SELECT MaHDB FROM HOADONBANHANG WHERE CONVERT(DATE,NgayXuatHDB) = @Date";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@Date", date.Date);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            string MaHDB = reader.GetString(0);
                            orderIds.Add(MaHDB.Trim());
                        }
                        catch (InvalidCastException ex)
                        {
                            // Xử lý lỗi kiểu dữ liệu
                            Console.WriteLine($"Error casting value: {ex.Message}");
                        }
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
            return orderIds;
        }
        public int TienBanTrongNgay(DateTime date)
        {
            int money = 0;
            try
            {
                _conn.Open();
                string SQL = @"SELECT sum(TongTienBan) FROM HOADONBANHANG WHERE CONVERT(DATE,NgayXuatHDB) = @Date";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@Date", date.Date);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    money = Convert.ToInt32(result);
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
            return money;
        }
        public int TienNhapTrongNgay(DateTime date)
        {
            int money = 0;
            try
            {
                _conn.Open();
                string SQL = @"SELECT sum(TongTienNhap) FROM HOADONNHAPHANG WHERE CONVERT(DATE,NgayXuatHDN) = @Date";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@Date", date.Date);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    money = Convert.ToInt32(result);
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
            return money;
        }

        public DataSet DoanhThuTheoThang(int month, int year)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ThongKeDoanhThu_TheoThang";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@thang", month));
            cmd.Parameters.Add(new SqlParameter("@nam", year));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public DataSet DoanhThuTheoNam(int year)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ThongKeDoanhThu_TheoNam";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@nam", year));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public DataSet DoanhThuTheoQui(int year,int qui)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ThongKeDoanhThu_TheoQuy";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@quy", qui));
            cmd.Parameters.Add(new SqlParameter("@nam", year));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public int TienBanTrongThang(int thang, int nam)
        {
            int money = 0;
            try
            {
                _conn.Open();
                string SQL = @"SELECT sum(TongTienBan) FROM HOADONBANHANG WHERE Month(NgayXuatHDB) = @thang and Year(NgayXuatHDB)=@nam";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@thang", thang);
                cmd.Parameters.AddWithValue("@nam", nam);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    money = Convert.ToInt32(result);
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
            return money;
        }
        public int TienNhapTrongThang(int thang, int nam)
        {
            int money = 0;
            try
            {
                _conn.Open();
                string SQL = @"SELECT sum(TongTienNhap) FROM HOADONNHAPHANG WHERE Month(NgayXuatHDN) = @thang and Year(NgayXuatHDN)=@nam";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@thang", thang);
                cmd.Parameters.AddWithValue("@nam", nam);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    money = Convert.ToInt32(result);
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
            return money;
        }
        public int TienBanTrongNam(int nam)
        {
            int money = 0;
            try
            {
                _conn.Open();
                string SQL = @"SELECT sum(TongTienBan) FROM HOADONBANHANG WHERE Year(NgayXuatHDB)=@nam";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@nam", nam);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    money = Convert.ToInt32(result);
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
            return money;
        }
        public int TienNhapTrongNam(int nam)
        {
            int money = 0;
            try
            {
                _conn.Open();
                string SQL = @"SELECT sum(TongTienNhap) FROM HOADONNHAPHANG WHERE Year(NgayXuatHDN)=@nam";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@nam", nam);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    money = Convert.ToInt32(result);
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
            return money;
        }
        public int TienBanTrongQui(int nam,int qui)
        {
            int money = 0;
            try
            {
                _conn.Open();
                string SQL = @"select sum(TongTienBan) from HOADONBANHANG where DATEPART(QUARTER,NgayXuatHDB)=@qui and Year(NgayXuatHDB)=@nam";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@nam", nam);
                cmd.Parameters.AddWithValue("@qui", qui);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    money = Convert.ToInt32(result);
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
            return money;
        }
        public int TienNhapTrongQui(int nam,int qui)
        {
            int money = 0;
            try
            {
                _conn.Open();
                string SQL = @"select sum(TongTienNhap) from HOADONNHAPHANG where DATEPART(QUARTER,NgayXuatHDN)=@qui and Year(NgayXuatHDN)=@nam";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@nam", nam);
                cmd.Parameters.AddWithValue("@qui", qui);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    money = Convert.ToInt32(result);
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
            return money;
        }
        public DataSet SanPhamTheoThang(int month, int year)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "LayThongTinSanPhamTheoThang";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@Thang", month));
            cmd.Parameters.Add(new SqlParameter("@Nam", year));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public DataSet SanPhamTheoNam(int year)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "LayThongTinSanPhamTheoNam";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@Nam", year));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public DataSet SanPhamTheoQui(int year, int qui)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "LayThongTinSanPhamTheoQui";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@Qui", qui));
            cmd.Parameters.Add(new SqlParameter("@Nam", year));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public DataSet KhachHangTheoThang(int month, int year)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "LayThongTinKhachHangTheoThang";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@Thang", month));
            cmd.Parameters.Add(new SqlParameter("@Nam", year));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public DataSet KhachHangTheoNam(int year)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "LayThongTinKhachHangTheoNam";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@Nam", year));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public DataSet KhachHangTheoQui(int year, int qui)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "LayThongTinKhachHangTheoQui";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@Qui", qui));
            cmd.Parameters.Add(new SqlParameter("@Nam", year));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public int TongKhachTrongNam(int nam)
        {
            int money = 0;
            try
            {
                _conn.Open();
                string SQL = @"SELECT  count(Distinct(MaKH)) FROM HOADONBANHANG WHERE Year(NgayXuatHDB)=@nam";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@nam", nam);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    money = Convert.ToInt32(result);
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
            return money;
        }
        public int TongKhachTrongThang(int nam, int thang)
        {
            int money = 0;
            try
            {
                _conn.Open();
                string SQL = @"SELECT  count(Distinct(MaKH)) FROM HOADONBANHANG WHERE Year(NgayXuatHDB)=@nam and Month(NgayXuatHDB)=@thang";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@nam", nam);
                cmd.Parameters.AddWithValue("@thang", thang);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    money = Convert.ToInt32(result);
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
            return money;
        }
        public int TongKhachTrongQui(int nam, int qui)
        {
            int money = 0;
            try
            {
                _conn.Open();
                string SQL = @"select count(Distinct(MaKH)) from HOADONBANHANG where DATEPART(QUARTER,NgayXuatHDB)=@qui and Year(NgayXuatHDB)=@nam";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@nam", nam);
                cmd.Parameters.AddWithValue("@qui", qui);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    money = Convert.ToInt32(result);
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
            return money;
        }
        public int TongSPTrongNam(int nam)
        {
            int money = 0;
            try
            {
                _conn.Open();
                string SQL = @"SELECT  count(Distinct(MaSP)) FROM HOADONBANHANG hd join ChiTietHDB ct on hd.MaHDB=ct.MaHDB WHERE Year(NgayXuatHDB)=@nam";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@nam", nam);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    money = Convert.ToInt32(result);
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
            return money;
        }
        public int TongSPTrongThang(int nam, int thang)
        {
            int money = 0;
            try
            {
                _conn.Open();
                string SQL = @"SELECT  count(Distinct(MaSP)) FROM HOADONBANHANG hd join ChiTietHDB ct on hd.MaHDB=ct.MaHDB WHERE Year(NgayXuatHDB)=@nam and Month(NgayXuatHDB)=@thang";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@nam", nam);
                cmd.Parameters.AddWithValue("@thang", thang);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    money = Convert.ToInt32(result);
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
            return money;
        }
        public int TongSPTrongQui(int nam, int qui)
        {
            int money = 0;
            try
            {
                _conn.Open();
                string SQL = @"SELECT  count(Distinct(MaSP)) FROM HOADONBANHANG hd join ChiTietHDB ct on hd.MaHDB=ct.MaHDB WHERE DATEPART(QUARTER,NgayXuatHDB)=@qui and Year(NgayXuatHDB)=@nam";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@nam", nam);
                cmd.Parameters.AddWithValue("@qui", qui);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    money = Convert.ToInt32(result);
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
            return money;
        }
    }
}

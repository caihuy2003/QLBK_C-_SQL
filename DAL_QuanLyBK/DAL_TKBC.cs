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
        public DataSet GetHoaDonBanHangByDay(DateTime dt)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetHoaDonBanHangByDay";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@Ngay", dt));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public DataSet GetHoaDonBanHangByMonth(int month,int year)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetHoaDonBanHangByMonth";
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
        public DataSet GetHoaDonBanHangByYear(int year)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetHoaDonBanHangByYear";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@Nam", year));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public DataSet GetHoaDonNhapHangByDay(DateTime dt)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetHoaDonNhapHangByDay";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@Ngay", dt));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public DataSet GetHoaDonNhapHangByMonth(int month, int year)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetHoaDonNhapHangByMonth";
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
        public DataSet GetHoaDonNhapHangByYear(int year)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetHoaDonNhapHangByYear";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@Nam", year));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public DataSet GetHoaDonBanHangByTotalAmountRange(int min, int max)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetHoaDonBanHangByTotalAmountRange";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@MinTotalMoney", min));
            cmd.Parameters.Add(new SqlParameter("@MaxTotalMoney", max));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
        public DataSet GetHoaDonNhapHangByTotalAmountRange(int min, int max)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetHoaDonNhapHangByTotalAmountRange";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@MinTotalMoney", min));
            cmd.Parameters.Add(new SqlParameter("@MaxTotalMoney", max));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
    }
}

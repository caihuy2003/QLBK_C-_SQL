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
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-9HH0UJ6;Initial Catalog=QLBangKeo;Integrated Security=True;Encrypt=false");
    }
}

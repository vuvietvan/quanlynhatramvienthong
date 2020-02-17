using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTramVienThong
{
    class ConnectionSQL
    {
        SqlConnection conn;
        public SqlConnection Connect()
        {
            conn = new SqlConnection(@"Data Source=VIET_VAN;Initial Catalog=QLNTVT;Integrated Security=True");
            return conn;
        }

        public void Open()
        {
            Connect();
            if (conn != null)
            {
                conn.Open();
            }
        }
        public void Close()
        {
            Connect();
            conn.Close();
            conn.Dispose();
            conn = null;
        }

        public void Excute(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

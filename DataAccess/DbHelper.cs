using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DbHelper
    {
        public static DataTable GetDataTableFromSQL(string sql)
        {
            var conn = new SqlConnection("Data Source=localhost;Initial Catalog=cars;Integrated Security=True");
            if (conn.State != ConnectionState.Closed)
                conn.Close();
            conn.Open();

            var cmd = new SqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            return dt;
        }

        public static void ExecuteQuery(string sql)
        {
            var conn = new SqlConnection("Data Source=localhost;Initial Catalog=cars;Integrated Security=True");
            if (conn.State != ConnectionState.Closed)
                conn.Close();
            conn.Open();

            var cmd = new SqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

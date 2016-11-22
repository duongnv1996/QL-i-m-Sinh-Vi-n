using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QLSV.Data
{
    public class SQLDataProvider
    {
        // ket noi Duong  : Data Source=MAYTINH-JRUTQDS;Initial Catalog=SinhVien;Persist Security Info=True;User ID=sa;Password=123456
        String strConnection = "Data Source=MAYTINH-JRUTQDS;Initial Catalog=SinhVien;Persist Security Info=True;User ID=sa;Password=123456";
       static SqlConnection conn;
        public SQLDataProvider() {
            if(conn ==null)
            conn = new SqlConnection(strConnection);
        }

        public static SqlConnection getConnection() {
            if (conn != null && conn.State == System.Data.ConnectionState.Closed) {
                conn.Open();
                return conn;
            } else {
                return conn;

            }

        }
    }
}

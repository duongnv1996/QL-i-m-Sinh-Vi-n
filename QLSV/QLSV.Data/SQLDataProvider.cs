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
        String strConnection = "Data Source=DESKTOP-5G4NPFD\\SQLEXPRESS;Initial Catalog=SinhVien;User ID=sa;Password=718295";
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

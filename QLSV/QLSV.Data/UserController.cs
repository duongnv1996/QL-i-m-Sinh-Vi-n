using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QLSV.Data
{
    class UserController : SQLDataProvider
    {
        public User getUser(String tenDangNhap, String matkhau) {
            User result = null;
            String query = " Select * from sinhvien where msv= " + tenDangNhap;
            SqlCommand cmd = new SqlCommand(query, getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                result.UserIDataReader(reader);
            }
            return result;

        }
    }
}

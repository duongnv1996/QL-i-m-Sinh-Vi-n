using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QLSV.Data
{
    public class UserController : SQLDataProvider
    {
        public User getUser(String tenDangNhap, String matkhau) {
            User result = null;
            String queryAccount = "Select * from ";
            String query = " Select sinhvien.*,lop.tenlop,account.quyen from account,sinhvien,lop where account.masv= '" + tenDangNhap + "' and password= '" + matkhau + "' and sinhvien.masv = account.masv and sinhvien.malop = lop.malop";
            SqlCommand cmd = new SqlCommand(query, getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read()) {
                result = new User();
                result.UserIDataReader(reader);
            }
            reader.Close();
            return result;
         
        }


    }
}

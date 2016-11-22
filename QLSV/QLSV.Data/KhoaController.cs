using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QLSV.Data
{
   public class KhoaController : SQLDataProvider
    {
       public List<khoa> getListKhoa() {
           List<khoa> list = new List<khoa>();
           String query = "Select * from khoa";
           try {
               SqlCommand cmd = new SqlCommand(query, getConnection());
               SqlDataReader reader = cmd.ExecuteReader();
               while (reader.Read()) {
                   khoa k = new khoa();
                   k.khoaIDataReader(reader);
                   list.Add(k);
               }

           } catch (Exception e) {
               
           }
           return list;
       }
    }
}

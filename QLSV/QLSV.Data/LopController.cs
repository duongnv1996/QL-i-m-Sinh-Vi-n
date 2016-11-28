using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QLSV.Data
{
    public class LopController : SQLDataProvider
    {
        public List<lop> getListLop()
        {
            List<lop> list = new List<lop>();
            String query = "Select * from lop";
            try
            {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lop l = new lop();
                    l.lopIDataReader(reader);
                    list.Add(l);
                }
                reader.Close();
            }
            catch (Exception e)
            {
            }
            return list;
        }
    }
}

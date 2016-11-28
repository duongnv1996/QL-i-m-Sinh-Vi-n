using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QLSV.Data
{
    public class SinhvienController : SQLDataProvider
    {
        public List<sinhvien> getListSinhvien()
        {
            List<sinhvien> list = new List<sinhvien>();
            String query = "Select * from sinhvien";
            try
            {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sinhvien s = new sinhvien();
                    s.sinhvienIDateReader(reader);
                    list.Add(s);
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

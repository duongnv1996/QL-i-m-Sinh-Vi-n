using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QLSV.Data
{
    public class BangDiemController : SQLDataProvider
    {
        public List<bangdiem> getListBangdiem()
        {
            List<bangdiem> list = new List<bangdiem>();
            String query = "Select * from bangdiem";
            try
            {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bangdiem b = new bangdiem();
                    b.bangdiemIDataReader(reader);
                    list.Add(b);
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

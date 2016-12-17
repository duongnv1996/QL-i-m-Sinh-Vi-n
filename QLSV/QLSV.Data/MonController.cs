using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Reflection;

namespace QLSV.Data
{
    public class MonController : SQLDataProvider
    {
        public List<monhoc> getListMon()
        {
            List<monhoc> list = new List<monhoc>();
            String query = "Select * from monhoc";
            try
            {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    monhoc m = new monhoc();
                    m.monIDataReader(reader);
                    list.Add(m);
                }
                reader.Close();
            }
            catch (Exception e)
            {

            }
            return list;
        }

        public List<monhoc> searchMon(String search) {
            List<monhoc> list = new List<monhoc>();

            String query = "Select * from monhoc where mamonhoc='"+search+"' or tenmonhoc='"
                + search + "'";
           
            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    monhoc m = new monhoc();
                    m.monIDataReader(reader);
                    list.Add(m);
                }
                reader.Close();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return list;
        }
    }
}

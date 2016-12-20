using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace QLSV.Data
{
    public class TongKetController : SQLDataProvider
    {
        public List<tongket> getDsTongKet() {
            List<tongket> list = new List<tongket>();
            String query;

            query = "Select * from tongket ";

            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    tongket l = new tongket();
                    l.tongKetIDataReader(reader);
                    list.Add(l);
                }
                reader.Close();
            } catch (Exception e) {

            }
            return list;
        }


        public List<tongket> searchTK(String search) {
            List<tongket> list = new List<tongket>();
            String query = "Select * from tongket where masv='" + search + "'";
            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    tongket b = new tongket();
                    b.tongKetIDataReader(reader);
                    list.Add(b);
                }
                reader.Close();
            } catch (Exception e) {

            }
            return list;
        }

    }

}

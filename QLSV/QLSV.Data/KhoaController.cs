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
        public List<khoa> getListKhoa()
        {
            List<khoa> list = new List<khoa>();
            String query = "Select * from khoa";
            try
            {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    khoa k = new khoa();
                    k.khoaIDataReader(reader);
                    list.Add(k);
                }
                reader.Close();


            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            return list;
        }

        public List<khoa> searchKhoa(String text) {
            List<khoa> list = new List<khoa>();
            String query = "Select * from khoa where makhoa='"+text+"' or tenkhoa='"+text+"'";
            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    khoa k = new khoa();
                    k.khoaIDataReader(reader);
                    list.Add(k);
                }
                reader.Close();


            } catch (Exception e) {
                System.Console.WriteLine(e.Message);
            }
            return list;
        }



        public bool insert(khoa item) {
            String query = "Insert into khoa values  ('" + item.makhoa + "' , N'" + item.tenkhoa + "');";
            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                cmd.ExecuteNonQuery();
                return true;
            } catch (Exception e) {
                return false;
            }
        }

        public bool delete(khoa l) {
        
            String query = "delete from lop where lop.malop in (select lop.malop from lop, khoa where "+
                "lop.makhoa=khoa.makhoa and khoa.makhoa='"+l.makhoa+"')";
            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                cmd.ExecuteNonQuery();
                cmd = null;
                //String queryKhoa = "delete from khoa where khoa.makhoa in ( select khoa.makhoa from khoa where khoa.makhoa='"+l.makhoa+"')";
                //cmd = new SqlCommand(queryKhoa, getConnection());
                //cmd.ExecuteNonQuery();
                return true;
            } catch (Exception e) {
                return false;
            }

        }
        public bool update(khoa l) {

            String query = "update khoa set tenkhoa =N'" + l.tenkhoa +  "' where makhoa='"+l.makhoa+"'";
            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                cmd.ExecuteNonQuery();
                return true;
            } catch (Exception e) {
                return false;
            }

        }
    }
}

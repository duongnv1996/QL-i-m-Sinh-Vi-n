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
              String query;
              
                  query = "Select * from lop ";
            
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

        public List<lop> searchListLop(String search) {
            List<lop> list = new List<lop>();
            String query;

            query = "Select * from lop where makhoa = '" + search + "' or lop.malop = '" + search + "' or lop.tenlop = '" + search + "'";

            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    lop l = new lop();
                    l.lopIDataReader(reader);
                    list.Add(l);
                }
                reader.Close();
            } catch (Exception e) {

            }
            return list;
        }


        public bool insertLop(lop lop) {
            String query = "Insert into lop values  ('" + lop.malop + "' , N'" + lop.tenlop + "' , '" + lop.makhoa + "');";
            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                cmd.ExecuteNonQuery();
                return true;
            } catch (Exception e) {
                return false;
            }
        }

        public bool deleteLop(lop l) {

            String query = "delete lop where malop = '" + l.malop + "'";
            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                cmd.ExecuteNonQuery();
                return true;
            } catch (Exception e) {
                return false;
            }

        }
        public bool UpdateLop(lop l) {

            String query = "update lop set tenlop =N'"+ l.tenlop +"' , makhoa ='"+l.makhoa+"' where malop = '"+l.malop+"'";
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

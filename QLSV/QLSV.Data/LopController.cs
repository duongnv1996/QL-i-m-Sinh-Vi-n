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
              
                  query = "Select *,tenkhoa from lop,khoa where lop.makhoa = khoa.makhoa";
            
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

        public List<lop> searchListLop(String where) {
            List<lop> list = new List<lop>();
            String query;

            query = "Select *,tenkhoa from lop,khoa where lop.makhoa = khoa.makhoa and lop.makhoa = '"+where+"'";

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
            String query = "Insert into lop values  ('" + lop.malop + "' , '" + lop.tenlop + "' , '" + lop.tenkhoa + "');";
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

            String query = "update lop set tenlop ='"+ l.tenlop +"' , makhoa ='"+l.tenkhoa+"' where malop = '"+l.malop+"'";
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

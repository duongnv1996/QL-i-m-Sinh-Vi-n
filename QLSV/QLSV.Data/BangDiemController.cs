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

        public List<bangdiem> searchDiem(String search) {
            List<bangdiem> list = new List<bangdiem>();
            String query = "Select * from bangdiem where masv='"+search+"' or mamonhoc='"+search+"' or trangthai='"+search+"'";
            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    bangdiem b = new bangdiem();
                    b.bangdiemIDataReader(reader);
                    list.Add(b);
                }
                reader.Close();
            } catch (Exception e) {

            }
            return list;
        }




        public bool insert(bangdiem item) {
            String query = "Insert into bangdiem values  ('" + item.masv + "' , N'" + item.mamonhoc + "', " + item.diemtp + " ,"
                + item.diemthilan1 + ", " + item.diemthilan2 + ", " + "0," + " 0 , 0, 0, 0, 0,0 ,"+item.sotietnghi+",0 " + ");";
            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                cmd.ExecuteNonQuery();
                List<bangdiem> listDiem = searchDiem(item.masv);
                foreach (bangdiem i in listDiem) {
                    update(i);
                }
                return true;
            } catch (Exception e) {
                return false;
            }
        }

        public bool delete(bangdiem l) {

            String query = "delete bangdiem where masv = '" + l.masv + "' and mamonhoc ='"+l.mamonhoc+"'";
            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                cmd.ExecuteNonQuery();
              List<bangdiem> listDiem=searchDiem(l.masv);
              foreach (bangdiem item in listDiem) {
                  update(item);
              }
                return true;
            } catch (Exception e) {
                return false;
            }

        }
        public bool update(bangdiem l) {

            String query = "update bangdiem set diemthilan1 =" + l.diemthilan1 + "," +
                "diemthilan2=" + l.diemthilan2 + "," + "sotietnghi=" + l.sotietnghi +", diemtp="+l.diemtp+" where masv ='"+l.masv+"' and mamonhoc ='"+l.mamonhoc+"'";
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

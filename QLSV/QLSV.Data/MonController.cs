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
        public List<monhoc> getListMon(String msv) {
            List<monhoc> list = new List<monhoc>();
            String query = "Select monhoc.* from monhoc,bangdiem where bangdiem.mamonhoc = monhoc.mamonhoc  and bangdiem.masv = '"+msv+"'"+
                "";
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




                public bool insert(monhoc item) {
            String query = "Insert into monhoc values  ('" + item.mamonhoc + "' , N'" + item.tenmonhoc +"', "+item.tongsotiet+ " ,"
                + item.sotinchi + ", " + item.hocky + ");";
            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                cmd.ExecuteNonQuery();
                return true;
            } catch (Exception e) {
                return false;
            }
        }

        public bool delete(monhoc l) {

            String query = "delete monhoc where mamonhoc = '" + l.mamonhoc + "'";
            try {
                SqlCommand cmd = new SqlCommand(query, getConnection());
                cmd.ExecuteNonQuery();
                BangDiemController bangdiemController = new BangDiemController();
                List<bangdiem> list = bangdiemController.getListBangdiem();
                foreach(bangdiem diem in list){
                    bangdiemController.update(diem);

                }
                return true;
            } catch (Exception e) {
                return false;
            }

        }
        public bool update(monhoc l) {

            String query = "update monhoc set tenmonhoc =N'" + l.tenmonhoc + "',"+
                "sotinchi="+l.sotinchi+","+"tongsotiet="+l.tongsotiet+","+"hocky="+l.hocky+" where mamonhoc='"+l.mamonhoc+"'";
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

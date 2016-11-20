using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace QLSV.Data
{
    class User
    {
        private String hoTen;

        public String HoTen {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private String tenDangNhap;

        public String TenDangNhap {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }
        private String password;

        public String Password {
            get { return password; }
            set { password = value; }
        }
        private String ngaySinh;

        public String NgaySinh {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        private String diaChi;

        public String DiaChi {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private String tenKhoa;

        public String TenKhoa {
            get { return tenKhoa; }
            set { tenKhoa = value; }
        }
        private String lop;

        public String Lop {
            get { return lop; }
            set { lop = value; }
        }


        public void UserIDataReader(SqlDataReader dr) {
            HoTen = dr["hoten"] is DBNull ? String.Empty : dr["hoten"].ToString();
            Lop = dr["malop"] is DBNull ? String.Empty : dr["malop"].ToString();
            TenKhoa = dr["tenkhoa"] is DBNull ? String.Empty : dr["tenkhoa"].ToString();
            DiaChi = dr["diachi"] is DBNull ? String.Empty : dr["diachi"].ToString();
            TenDangNhap = dr["msv"] is DBNull ? String.Empty : dr["msv"].ToString();
            NgaySinh = dr["ngaysinh"] is DBNull ? String.Empty : dr["ngaysinh"].ToString();
        }
        


    }
}

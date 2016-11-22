using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using QLSV.Data;

namespace QLSV.Bussiness
{
   public class MyService
    {
        public  User dangNhap(String tenDangNhap, String matKhau) {
            User result;
            UserController userController = new UserController();
            result = userController.getUser(tenDangNhap, matKhau);
            return result;

        }
    }
}

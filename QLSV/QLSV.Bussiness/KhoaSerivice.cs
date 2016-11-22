using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.Data;
namespace QLSV.Bussiness
{
   public class KhoaSerivice 
    {
       public List<khoa> getDsKhoa(){
        KhoaController khoaController = new KhoaController();
           return khoaController.getListKhoa();
       }
    }
}

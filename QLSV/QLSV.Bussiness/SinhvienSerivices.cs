using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.Data;

namespace QLSV.Bussiness
{
    public class SinhvienSerivices
    {
     static   SinhvienController sinhvienController = new SinhvienController();
        public List<sinhvien> getDsSinhvien()
        {
           
            return sinhvienController.getListSinhvien();
        }
        public List<sinhvien> searchSinhvien(String search) {
          
            return sinhvienController.searchSinhVien(search);
        }
    }
}

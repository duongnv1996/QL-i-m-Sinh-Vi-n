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
        public List<sinhvien> getDsSinhvien()
        {
            SinhvienController sinhvienController = new SinhvienController();
            return sinhvienController.getListSinhvien();
        }
    }
}

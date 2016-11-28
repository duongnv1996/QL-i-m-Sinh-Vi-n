using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.Data;

namespace QLSV.Bussiness
{
    public class LopSerivice
    {
        public List<lop> getDsLop()
        {
            LopController lopConTroller = new LopController();
            return lopConTroller.getListLop();
        }
    }
}

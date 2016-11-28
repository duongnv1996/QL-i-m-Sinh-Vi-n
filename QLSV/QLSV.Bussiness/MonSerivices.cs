using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.Data;

namespace QLSV.Bussiness
{
    public class MonSerivices
    {
        public List<monhoc> getDsMon()
        {
            MonController monController = new MonController();
            return monController.getListMon();
        }
    }
}

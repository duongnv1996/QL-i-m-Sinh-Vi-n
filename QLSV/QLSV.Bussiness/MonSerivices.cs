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
       static MonController monController = new MonController();
        public List<monhoc> getDsMon()
        {
        
            return monController.getListMon();
        }

        public List<monhoc> searchMonHoc(String search) {
           
            return monController.searchMon(search);
        }
    }
}

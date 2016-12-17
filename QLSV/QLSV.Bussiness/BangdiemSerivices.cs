using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.Data;

namespace QLSV.Bussiness
{
    public class BangdiemSerivices
    {
      static  BangDiemController bangdiemController = new BangDiemController();
        public List<bangdiem> getDsBangdiem()
        {
            
            return bangdiemController.getListBangdiem();
        }
        public List<bangdiem> searchBangdiem(String search) {
         
            return bangdiemController.searchDiem(search);
        }
    }
}

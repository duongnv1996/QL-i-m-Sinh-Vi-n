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
        public List<bangdiem> getDsBangdiem()
        {
            BangDiemController bangdiemController = new BangDiemController();
            return bangdiemController.getListBangdiem();
        }

    }
}

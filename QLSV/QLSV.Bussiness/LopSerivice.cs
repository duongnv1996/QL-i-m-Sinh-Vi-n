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
        public List<lop> getDsLop(String search) {
            LopController lopConTroller = new LopController();
            return lopConTroller.searchListLop(search);
        }
        public bool themLop(lop lop) {
            return new LopController().insertLop(lop);
        }

        public bool xoaLop(lop lop) {
            return new LopController().deleteLop(lop);
        }
        public bool suaLop(lop lop) {
            return new LopController().UpdateLop(lop);
        }
    }
}

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
        static KhoaController khoaController = new KhoaController();
        public List<khoa> getDsKhoa()
        {
           
            return khoaController.getListKhoa();
        }
        public List<khoa> searchKhoa(String text) {
           
            return khoaController.searchKhoa(text);
        }

        public bool add(khoa lop) {
            return khoaController.insert(lop);
        }

        public bool delete(khoa lop) {
            return khoaController.delete(lop);
        }
        public bool update(khoa lop) {
            return khoaController.update(lop);
        }
    }
}

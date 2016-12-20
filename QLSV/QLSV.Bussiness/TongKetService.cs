using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.Data;
namespace QLSV.Bussiness
{
   public class TongKetService
    {
        TongKetController controller = new TongKetController();
        public List<tongket> getDsTongKet() {

            return controller.getDsTongKet();
        }
        public List<tongket> searchTongKet(String search) {
            return controller.searchTK(search);
        }
    }
}

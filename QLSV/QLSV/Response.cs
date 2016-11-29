using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
 public   interface Response<T>
    {
        void onResponse(T t);
    }
}

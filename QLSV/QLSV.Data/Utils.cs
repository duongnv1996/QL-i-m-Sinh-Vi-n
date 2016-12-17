using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Data
{
    class Utils
    {
        public static List<PropertyInfo> GetPropertiesNameOfClass(object pObject) {
            List<PropertyInfo> propertyList = new List<PropertyInfo>();
            if (pObject != null) {
                foreach (var prop in pObject.GetType().GetProperties()) {
                    
                    propertyList.Add(prop);
                }
            }
            return propertyList;
        }
    }
}

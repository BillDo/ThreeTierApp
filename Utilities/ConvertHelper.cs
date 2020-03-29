using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class ConvertHelper
    {
        public static DateTime ToDateTime(object obj)
        {
            return ToDateTime(obj, DateTime.Now);
        }

        public static DateTime ToDateTime(object obj, DateTime defaultValue)
        {
            DateTime retVal;
            if (obj == null)
            {
                return defaultValue;
            }
            if (!DateTime.TryParse(obj.ToString(), out retVal))
            {
                retVal = defaultValue;
            }
            return retVal;
        }
    }
}

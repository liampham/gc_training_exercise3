using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCFamily.Utilities
{
    class Utils
    {
        /*Check If the given string is null or zero length.*/
        public static bool isEmptyString(string str)
        {
            return (str == null || str.Trim().Length == 0);
        }
    }
}

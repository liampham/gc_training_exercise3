﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCFamily.Utilities
{
    class Utils
    {
        public static bool isEmptyString(string str)
        {
            return (str == null || str.Trim().Length == 0);
        }
    }
}

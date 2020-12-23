using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFSoluzioniMVCFramework.Extensions
{
    public static class AFExtensions
    {
        public static bool IsNumeric(this string stringValue)
        {
            long retNum;
            return long.TryParse(stringValue, out retNum);
        }
    }
}
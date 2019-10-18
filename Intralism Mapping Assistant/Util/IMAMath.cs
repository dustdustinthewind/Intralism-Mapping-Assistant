using System;

namespace Intralism_Mapping_Utils.Util
{
    static public class IMAMath
    {
        static public decimal Lerp(decimal firstFloat, decimal secondFloat, decimal by)
        {
            return firstFloat + (secondFloat - firstFloat) * by;
        }
    }
}

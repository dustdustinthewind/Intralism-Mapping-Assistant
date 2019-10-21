using System;

namespace Intralism_Mapping_Assistant.Util
{
    static public class IMAMath
    {
        static public decimal Lerp(decimal firstFloat, decimal secondFloat, decimal by)
        {
            return firstFloat + (secondFloat - firstFloat) * by;
        }
    }
}

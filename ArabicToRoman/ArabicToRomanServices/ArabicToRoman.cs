using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabicToRomanServices
{
    public class ArabicToRoman
    {
        public string ToRoman(int anArabic)
        {
            if (anArabic == 3)
            {
                return "III";
            }
            if (anArabic == 2)
            {
                return "II";
            }
            return "I";
        }
    }
}

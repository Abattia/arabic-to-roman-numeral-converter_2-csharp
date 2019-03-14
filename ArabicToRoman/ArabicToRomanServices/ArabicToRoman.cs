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
            string result = string.Empty;

            do
            {
                result += "I";
                anArabic -= 1;
            } while (anArabic >= 1);

            return result;
        }
    }
}

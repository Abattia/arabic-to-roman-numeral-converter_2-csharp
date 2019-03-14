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

            var symbol = new Dictionary<int, string> {{1000, "M"},
                                                        {900, "CM"},
                                                        {500, "D"},
                                                        {400, "CD"},
                                                        {100, "C"},
                                                        {90, "XC"},
                                                        {50, "L"},
                                                        {40, "XL"},
                                                        {10, "X"},
                                                        {9, "IX"},
                                                        {5, "V"},
                                                        {4, "IV"},
                                                        {1, "I"}};
            foreach (int level in new List<int> {1000,
                                                    900,
                                                    500,
                                                    400,
                                                    100,
                                                    90,
                                                    50,
                                                    40,
                                                    10,
                                                    9,
                                                    5,
                                                    4,
                                                    1})
            {
                if (anArabic >= level)
                {
                    do
                    {
                        result += symbol[level];
                        anArabic -= level;
                    } while (anArabic >= level);
                }
            }

            return result;

        }
    }
}

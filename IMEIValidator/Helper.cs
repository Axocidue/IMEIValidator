using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace IMEIValidator
{
    public static class IMEIHelper
    {
        public static IEnumerable<int> GetDigits(this string str)
        {
            return
                from ch in str.ToCharArray()
                select Int32.Parse(ch.ToString());
        }

        public static int Double(this int digit)
        {
            return (digit*2).ToString().GetDigits().Sum();
        }

        public static IEnumerable<int> GetNewDigits(this IEnumerable<int> digits)
        {
            return 
                digits.Select( (digit, i) => 
                {
                    if (i % 2 == 0) return digit;
                    else return digit.Double();
                });
        }

        public static int GetIMEIChecksum(this IEnumerable<int> digits)
        {
            var sum = digits.Sum() % 10;
            if (sum == 0) return 0;
            else return 10 - sum;
        }

        public static string GetIMEI15(this string IMEI14)
        {
            return IMEI14 + IMEI14.GetDigits().GetNewDigits().GetIMEIChecksum().ToString();
        }
    }

    public static class ValidationHelper
    {
        public static bool IsDigits(this string str)
        {
            return Regex.IsMatch(str, @"^\d{15}$", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Multiline);
        }

        public static bool IsIMEI(this string str)
        {
            return str.Substring(0, 14).GetIMEI15() == str;
        }
    }
}

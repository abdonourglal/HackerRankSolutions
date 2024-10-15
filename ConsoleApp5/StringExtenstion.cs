using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public static class StringExtenstion
    {
        public static string RemoveWhiteSpaces(this string value)
        {
            return value.Replace(" ", "");
        }
        public static string Reverse(this string value)
        {
            var rev = value.ToCharArray();
            Array.Reverse(rev);
            return new string(rev);
        }
    }
}

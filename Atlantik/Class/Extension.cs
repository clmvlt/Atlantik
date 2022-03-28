using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Atlantik.Class
{
    public static class Extension
    {
        public static Boolean HasDigits(this string str)
        {
            Regex digits = new Regex("[0-9]");
            return digits.IsMatch(str);
        }

        public static Boolean HasLetters(this string str)
        {
            Regex letters = new Regex("[a-zA-Z]");
            return letters.IsMatch(str);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PoddApp.UI.Validation
{
    internal class InputValidator
    {

        public static bool IsNotEmpty(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            return true;

        }

        public static bool IsValidUrl(string url)
        {
            string pattern = @"^https?:\/\/";
            return Regex.IsMatch(url, pattern);
        }

    }
}

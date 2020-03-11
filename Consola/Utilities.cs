using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola
{
    public static class Utilities
    {
        public static string jumbledString(string s, long n)
        {
            string evenChars = string.Empty, oddChars = string.Empty, finalString = string.Empty;

            if (string.IsNullOrEmpty(s))
                return null;

            for (int i = 0; i < s.Length; i++)
                if (i % 2 == 0)
                    evenChars += s[i];
                else
                    oddChars += s[i];

            finalString = evenChars + oddChars;

            return finalString.repeatString(n);
        }

        public static string repeatString(this string theString, long n)
        {
            StringBuilder builtString = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                builtString.Append(theString);// += theString;
            }

            return builtString.ToString();
        }
    }
}

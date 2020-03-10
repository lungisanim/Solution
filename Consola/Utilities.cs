namespace Consola
{
    public class Utilities
    {
        public static string jumbledString(string s, long n)
        {
            string evenChars = string.Empty, oddChars = string.Empty;

            if (string.IsNullOrEmpty(s))
                return null;

            for (int i = 0; i < s.Length; i++)
                if (i % 2 == 0)
                    evenChars += s[i];
                else
                    oddChars += s[i];

            return evenChars + oddChars;
        }
    }
}

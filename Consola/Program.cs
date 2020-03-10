using System;

namespace Consola
{
    class Program { 
        static void Main(string[] args)
        {
            string s = "Wow Example!";
            long n = 3000000000;


            Console.WriteLine(Utilities.jumbledString(s, n));
        }
    }
}
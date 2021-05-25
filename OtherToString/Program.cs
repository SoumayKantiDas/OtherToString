//keyword_string.cs:

using System;

namespace OtherToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "\u0068ello ";
            string b = "world";
            Console.WriteLine(a + b);
            Console.WriteLine(a + b == "hello World");


        }
    }
}

using System;

namespace Coder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BCoder aCoder = new ();
            string str = "ABZ abz 90";
            Console.WriteLine($"string is: {str}");

            str = aCoder.Encode(str);
            Console.WriteLine($"coded string: {str}");

            str = aCoder.Decode(str);
            Console.WriteLine($"decoded string: {str}");
        }
    }
}

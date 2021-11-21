using System;

namespace Fractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RatioNumber number1 = new RatioNumber(5, 10);
            RatioNumber number2 = new RatioNumber(2, 10);

            Console.WriteLine(number1 == number2);
            Console.WriteLine(number1 != number2);
            Console.WriteLine(number1 < number2);
            Console.WriteLine(number1 <= number2);
            Console.WriteLine(number1 > number2);
            Console.WriteLine(number1 >= number2);
            Console.WriteLine($"{ number1}, {number2}");

            //Console.Clear();
            //float number3 = number1 * number2;
            Console.WriteLine((number1 / number2).ToString());
            Console.WriteLine((number1 % number2).ToString());
            

        }
    }
}

using System;

namespace ComplexNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var complexNumber = new ComplexNumber(3, "2i");
            var complexNumber2 = new ComplexNumber(Imaginary:-3);
            var complexNumber3 = new ComplexNumber();
            Console.WriteLine(complexNumber * complexNumber2);//
            Console.WriteLine(complexNumber2);
            Console.WriteLine(complexNumber3);
        }
    }
}

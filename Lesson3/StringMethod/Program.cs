using System;
using System.Text;

//TODO Реализовать метод, который в качестве входного параметра принимает строку string,
//возвращает строку типа string, буквы в которой идут в обратном порядке. Протестировать метод.

namespace StringMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("qasdfrRR 21"));
        }

        static string Reverse(string str)
        {
            var sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

    }
}

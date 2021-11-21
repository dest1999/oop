using System;

//TODO Для класса банковский счет переопределить операторы == и != для сравнения информации в двух счетах.
//Переопределить метод Equals аналогично оператору ==, не забыть переопределить метод GetHashCode().
//Переопределить метод ToString() для печати информации о счете. Протестировать функционирование переопределенных методов и операторов на простом примере.

namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account1 = new Account(100);
            var account2 = new Account(5000);

            Console.WriteLine(account1);
            Console.WriteLine(account2);

            Console.WriteLine($"Transaction success: {account1.Transfer(account2, 5000)}\n");

            Console.WriteLine(account1.Equals(account2));
            Console.WriteLine(account2.Equals(account2));

            Console.WriteLine(account1 == account2);
            Console.WriteLine(account1 != account2);
        }
    }
}
using System;

//TODO В класс банковский счет, созданный в упражнениях, добавить метод, который переводит деньги с одного счета на другой.
//У метода два параметра: ссылка на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account1 = new Account(100);
            var account2 = new Account(5000);

            Console.WriteLine(account1.GetInfo());
            Console.WriteLine(account2.GetInfo());

            Console.WriteLine($"Transaction success: {account1.Transfer(account2, 5000)}");

            Console.WriteLine(account1.GetInfo());
            Console.WriteLine(account2.GetInfo());
        }
    }
}

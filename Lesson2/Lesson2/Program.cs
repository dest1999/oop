using System;
//TODO 1. Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип).
//Предусмотреть методы для доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.

//TODO 2.Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным.
//Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.

//TODO 3. В классе банковский счет удалить методы заполнения полей. Вместо этих методов создать конструкторы.
//Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс,
//конструктор для заполнения поля тип банковского счета,
//конструктор для заполнения баланса и типа банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер счета.

//TODO 4. В классе все методы для заполнения и получения значений полей заменить на свойства. Написать тестовый пример.

//TODO 5. * Добавить в класс счет в банке два метода: снять со счета и положить на счет.
//Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае положительного результата изменяет баланс.
namespace Lesson2
{
    public enum AccountTypes
    {
        Дебетовый,
        Срочный,
        Кредитный,
        Привилегированный
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new(55);
            Account account2 = new(AccountTypes.Кредитный);
            Account account3 = new(1000, AccountTypes.Привилегированный);

            Console.WriteLine(account1.GetInfo());
            Console.WriteLine();
            Console.WriteLine(account2.GetInfo());
            Console.WriteLine();
            Console.WriteLine(account3.GetInfo());
            
            Console.WriteLine("\nДобавляем 1000\n");
            account1.PutToAccount(1000);
            Console.WriteLine($"Баланс\t{account1.Balance}");
            //снять отрицательную сумму -> добавить положительную и наоборот
            Console.WriteLine("\nДобавляем\t-10000\n");
            account1.PutToAccount(-10000);
            Console.WriteLine($"Баланс\t{account1.Balance}");

            Console.WriteLine("\nСнимаем\t1000\n");
            account1.WithdrawFromAccount(1000);
            Console.WriteLine($"Баланс\t{account1.Balance}");

            Console.WriteLine("\nСнимаем\t-1000\n");
            account1.WithdrawFromAccount(-1000);
            Console.WriteLine($"Баланс\t{account1.Balance}");

            Console.WriteLine("\nСнимаем\t10000\n");
            account1.WithdrawFromAccount(10000);
            Console.WriteLine($"Баланс\t{account1.Balance}");

        }
    }
}


﻿using System;
//TODO 1.Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип).
//Предусмотреть методы для доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.
//TODO 2. Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным.
//Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.
//TODO 3. В классе банковский счет удалить методы заполнения полей. Вместо этих методов создать конструкторы.
//Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс, конструктор для заполнения поля тип банковского счета,
//конструктор для заполнения баланса и типа банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер счета.
//TODO 4. В классе все методы для заполнения и получения значений полей заменить на свойства. Написать тестовый пример.
//TODO 5. * Добавить в класс счет в банке два метода: снять со счета и положить на счет.
//Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае положительного результата изменяет баланс.
namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account1 = new Account();

            Console.WriteLine(account1.GetInfo());

            Console.WriteLine("Completed: " + account1.DepositToAccount(-100));
            Console.WriteLine(account1.GetInfo());
            Console.WriteLine("Completed: " + account1.DepositToAccount(100));
            Console.WriteLine(account1.GetInfo());
            Console.WriteLine("Completed: " + account1.WithdrawFromAccount(-1000));
            Console.WriteLine(account1.GetInfo());
            Console.WriteLine("Completed: " + account1.WithdrawFromAccount(1000));
            Console.WriteLine(account1.GetInfo());
            Console.WriteLine("Completed: " + account1.WithdrawFromAccount(10));
            Console.WriteLine(account1.GetInfo());

        }
    }
}
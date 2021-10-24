using System;
using System.IO;
//TODO Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail адрес. Разделителем между ФИО и адресом электронной почты является символ &:
//Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич & Pasha@mail.ru
//Сформировать новый файл, содержащий список адресов электронной почты. Предусмотреть метод, выделяющий из строки адрес почты.
//Методу в качестве параметра передается символьная строка s, e-mail возвращается в той же строке s: public void SearchMail (ref string s).

namespace MailAddress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "list.txt";
            string outputFile = "mailingList.txt";

            var strings = File.ReadAllLines(inputFile);

            for (int i = 0; i < strings.Length; i++)
            {
                SearchMail(ref strings[i]);
            }
            
            File.WriteAllLines(outputFile, strings);
        }

        public static void SearchMail(ref string s)
        {
            var strings = s.Split('&');
            s = strings[^1].Trim();
        }

    }
}
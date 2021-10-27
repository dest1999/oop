using System;
using System.Collections;

namespace BuildingWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creator.CreateBuild(1, 1, 1, 1);
            Creator.CreateBuild(2, 2, 2, 2);
            Creator.CreateBuild(3, 3, 3, 3);
            Creator.CreateBuild();

            foreach (DictionaryEntry item in Creator.BuildingsStore)
            {
                Console.WriteLine(item.Value + "\n");
            }

            int id = 2;
            bool isSuccess = Creator.Delete(id);
            Console.WriteLine($"Deleting from table by id = {id}: {isSuccess}");

            foreach (DictionaryEntry item in Creator.BuildingsStore)
            {
                Console.WriteLine(item.Value + "\n");
            }
        }
    }
}

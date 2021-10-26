using System;

namespace BuildingWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var build1 = new Building
            {
                EntrancesQuantity = 1,
                FlatsQuantity = 1,
                FloorsQuantity = 1,
                Height = 10
            };

            var build2 = new Building
            {
                EntrancesQuantity = 2,
                FlatsQuantity = 2,
                FloorsQuantity = 2,
                Height = 20
            };

            Console.WriteLine(build1 + "\n");
            Console.WriteLine(build2);
        }
    }
}

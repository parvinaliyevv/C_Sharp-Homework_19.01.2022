using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new City[3] { new Azerbaijan.Baku(10_000_000), new Russia.Moscow(144_000_000), new Turkey.Ankara(84_000_000) };

            Console.WriteLine("Baku > Moscow: {0}", cities[0].CompareTo(cities[1]));
            Console.WriteLine("Moscow > Ankara: {0}", cities[1].CompareTo(cities[2]));
        }
    }
}

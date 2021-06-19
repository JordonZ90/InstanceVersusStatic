using System;

namespace InstanceVersusStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Pandas();
        }
        public static void Pandas()
        {
            Panda p1 = new Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");

            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);

            Console.WriteLine($"Total population of panda's: '{Panda.Population}'");
        }
    }
}

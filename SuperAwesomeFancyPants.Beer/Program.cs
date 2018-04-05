using System;

namespace SuperAwesomeFancyPants.Beer
{
    /// <summary>
    /// For inspiration.
    /// http://99-bottles-of-beer.net/language-csharp-1614.html
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to beer-time!");
            Console.WriteLine("Press the <anykey>");

            Console.ReadKey();

            BeerTime();
        }

        private static void BeerTime()
        {
            for (int i = 99; i > 1;)
            {
                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.");
                Console.WriteLine($"Take one down and pass it around, {i--} bottles of beer on the wall.");
            }

            Console.WriteLine($"1 bottle of beer on the wall, 1 bottles of beer.");
            Console.WriteLine($"Take 1 down and pass it around, no more bottles of beer on the wall.");

            Console.WriteLine($"No more bottles of beer on the wall, no more bottles of beer. ");
            Console.WriteLine($"Go to the store and buy some more, 99 bottles of beer on the wall.");

            Console.WriteLine("We are done!");
            Console.WriteLine("Press the <anykey>");
            Console.ReadKey();

            BeerTime();
        }

        private static void BeerTime2()
        {
            for (int i = 99; i >= 0;)
            {
                if (i > 1)
                {
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.");
                    Console.WriteLine($"Take one down and pass it around, {i--} bottles of beer on the wall.");
                }
                else if (i == 1)
                {
                    Console.WriteLine($"{i} bottle of beer on the wall, {i} bottles of beer.");
                    Console.WriteLine($"Take {i--} down and pass it around, no more bottles of beer on the wall.");
                }
                else
                {
                    Console.WriteLine($"No more bottles of beer on the wall, no more bottles of beer. ");
                    Console.WriteLine($"Go to the store and buy some more, 99 bottles of beer on the wall.");
                }
            }

            Console.WriteLine("We are done!");
            Console.WriteLine("Press the <anykey>");
            Console.ReadKey();
        }
    }
}

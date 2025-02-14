using System;

namespace RandomAsterisk
{
    internal class Program
    {
        static Random random = new Random();

        static void PrintAsterisks(int num)
        {
            Console.WriteLine(new string('*', num));
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 30; i++)
            {
                int randomNumber = random.Next(1, 20);
                PrintAsterisks(randomNumber);
            }




        }


    }
}
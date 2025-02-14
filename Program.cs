using System;

namespace ListMinSumMaxAvg

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = new int[5] { 10, 15, 16, 8, 6 };

            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Sum());

            Console.WriteLine("------------------------------");
            Array.Sort(numbers);
            Array.ForEach(numbers, x => Console.WriteLine(x));


            Console.WriteLine("------------------------------");
            Array.Reverse(numbers);
            Array.ForEach(numbers, x => Console.WriteLine(x));


            Console.WriteLine("------------------------------");

            Console.WriteLine(Array.BinarySearch(numbers, 15));

        }
    }
}

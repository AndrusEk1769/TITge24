// See https://aka.ms/new-console-template for more information
using System;

namespace ArraySOrtNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "cat", "alligator", "fox", "donkey", "bear", "elephant", "goat" };

            Array.Sort(animals);
            Array.ForEach(animals, animal => { Console.WriteLine(animal); });


            Console.WriteLine("------------------------------");

            int[] numbers = { 3, 2, 23, 4, 5, 4, 3, 55, 2 };
            Array.Sort(numbers);


            List<int> uniqueList = new List<int>();


            foreach (var num in numbers)
            {

                if (uniqueList.Count == 0 || uniqueList[uniqueList.Count - 1] != num)
                {
                    uniqueList.Add(num);
                }
            }


            int[] sortedUniqueArray = uniqueList.ToArray();


            Console.WriteLine("Sorted array with unique numbers:");

            foreach (var num in sortedUniqueArray)
            {
                Console.Write(num + " ");
            }
        }
    }

}




































































































  
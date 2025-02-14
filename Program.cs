using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string word = "#CD5C5C";
            string invalidHex = "#GGGDSAD";

            Console.WriteLine("Hex code:" + word);
            Console.WriteLine("Is Regex:" + RegExTest(word));

            Console.WriteLine("Hex code: " + invalidHex);
            Console.WriteLine("Is Regex: " + RegExTest(invalidHex)); 
        }

        public static bool RegExTest(string word)
        {
            
            return Regex.IsMatch(word, @"[#][0-9A-Fa-f]{6}\b");
        }
    }
}
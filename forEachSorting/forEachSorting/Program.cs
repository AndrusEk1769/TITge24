using System.Collections.Immutable;

namespace forEachSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] genders = { "m", "f", "m", "f", "m", "f", "m", "f", "m", "f", "f", "f", "m" };
            int maleCount = 0;
            int femaleCount = 0;

            foreach (string gender in genders)
            {
                maleCount = string.Compare(gender, "m", StringComparison.OrdinalIgnoreCase) == 0 ? maleCount + 1 : maleCount;
                
                femaleCount = string.Compare(gender, "f", StringComparison.OrdinalIgnoreCase) == 0 ? femaleCount + 1 : femaleCount;
            }
            Console.WriteLine("Number of females " + femaleCount);
            Console.WriteLine("Number of males " + maleCount);
        }
    }

}
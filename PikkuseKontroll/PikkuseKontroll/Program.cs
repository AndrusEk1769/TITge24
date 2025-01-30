namespace PikkuseKontroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            string[] animalName = { "Koer", "Kass", "janes", "Sipelgas", "Lendorav" };
            string longestName = "";
            int maxLength = 0;

            for (int i = 0; i < animalName.Length; i++) {
                int nameLength = animalName[i].Length;
                Console.WriteLine($"{animalName[i]} has {nameLength} letters.");


                if (nameLength > maxLength)
                {
                    maxLength = nameLength;
                    longestName = animalName[i];
                }
            }

            Console.WriteLine($"The longest name is {longestName} with {maxLength} letters.");
        }
    }
}

namespace Tunnitoo31jan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            Console.WriteLine();

            int rows = int.Parse(Console.ReadLine());
            int currentNumber = 1;

            

            for (int i = 1; i <= rows; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                  
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                   
                }
                Console.WriteLine();
            }

        }
    }
}

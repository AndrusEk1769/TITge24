namespace numbriteKolmnurk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage number");

            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j < rows; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

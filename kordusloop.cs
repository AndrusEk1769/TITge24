namespace loopFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta t'rnide arv");

            int n = Int16.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*");
            }


            Console.WriteLine("Kasutan selle jaoks for loopi");
          
        }
    }
}

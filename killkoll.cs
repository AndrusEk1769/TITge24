namespace loopInLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta korduste arv");
            string n = " kill-koll ";
            string a = " killadi-koll";

            int arv = int.Parse(Console.ReadLine());

           for (int i = 0; i <= arv; i++)
            {
                Console.WriteLine(a);
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine(n);
                }
            }   

       

        }

    }
}

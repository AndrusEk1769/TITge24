namespace switch31jan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage tagstatav summa");
            double summa = double.Parse(Console.ReadLine());
            double[] raha = { 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };
            Console.WriteLine("Tagastatav summa on: ");
            foreach (double r in raha)
            {
                int tagastus = (int)(summa / r);
                if (tagastus > 0)
                {
                    Console.WriteLine(tagastus + " x " + r);
                    summa -= tagastus * r;
                }
            }

        }
    }
}

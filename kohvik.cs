namespace kohvik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fantaasia kohvik");
            Console.WriteLine("\n\nMenüü (kohvi valik)");
            Console.WriteLine("1. Must kohv");
            Console.WriteLine("2. Mocha");
            Console.WriteLine("3. Cappucino");
            Console.WriteLine("4. Latte");
            Console.WriteLine("5. Espresso");
            Console.WriteLine("6. Flat White");
            Console.WriteLine("\n\nPalun tee valik numbriga: ");

            byte valik = byte.Parse(Console.ReadLine());

            double hind = 0;
            
            switch (valik)
            {
                case 1:
                    hind = 3.0;
                    break;
                case 2:
                    hind = 4;
                    break;
                case 3:
                    hind = 3.5;
                    break;
                case 4:
                    hind = 3.9;
                    break;
                case 5:
                    hind = 2.9;
                    break;
                case 6:
                    hind = 3.5;
                    break;
                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }
    }
}

namespace forLoopRing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double radius;
            double thickness = 0.4;
            char symbol = '*';


            do
            {
                Console.WriteLine("Enter radius: ");
                if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                {
                    Console.WriteLine("Radius has to be a positive number");
                }
            }
            while (radius <=0);
            Console.WriteLine();
            double rin = radius - thickness;
            double rout = radius + thickness;

            for (double y = radius; y >= -radius; y--)
            {
                for (double x = -radius; x < rout; x+= 0.5)
                {
                    double value =x*x + y*y;
                    if (value >= rin * rin && value <= rout * rout)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}

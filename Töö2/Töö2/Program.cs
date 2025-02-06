using System.Drawing;

namespace Töö2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();

                Console.WriteLine("Millist kujundit soovid?");
                string shapeType = Console.ReadLine().ToLower();
                {
                    switch (shapeType)
                    {
                        case "ruut":
                            CalculateSquare();
                            break;


                        case "kolmnurk":
                            CalculateTriangle();
                            break;
                        case "ristkylik":
                            CalculateRectangle();
                            break;
                        case "ring":
                            CalculateCircle();
                            break;
                    }
                    Console.WriteLine("Kas soovid sisestada uut kujundit?Jah/Ei");
                    string again = Console.ReadLine().ToLower();
                    if (again != "jah")
                        break;

                }
                static void CalculateSquare()
                {
                    Console.WriteLine("Sisestage külje pikkus");
                    double side = Convert.ToDouble(Console.ReadLine());
                    double perimeter = 4 * side;
                    double area = (side * side) * 2;

                    for (int row = 1; row <= side; row++)
                    {
                        for (int column = 1; column <= side; column++)
                        {
                            string mark;
                            if (row == column || row + column <= side + 1)
                            {
                                mark = "* ";
                            }
                            else
                            {
                                mark = "* ";
                            }
                            Console.Write(mark);
                        }
                        Console.WriteLine();



                    }
                    Console.WriteLine("Ruudu pindala on: " + perimeter + " ja ümbermõõt on: " + area);
                }




            }
            static void CalculateTriangle()
            {
                Console.WriteLine("Sisestage kolmnurga kolm külge: ");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                double perimeter = a + b + c;
                double s = perimeter / 2;
                double area = Math.Pow(s, 2) / Math.Sqrt(3);

                for (int i = 1; i <= perimeter; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("{0} ", j);
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("Kolmnurga pindala on: " + perimeter + " ja ümbermõõt on: " + area);
            }

            static void CalculateRectangle()
            {
                Console.WriteLine("Sisestage ristküliku pikkus ja laius: ");
                double length = Convert.ToDouble(Console.ReadLine());
                double width = Convert.ToDouble(Console.ReadLine());
                double perimeter = (length + width) * 2;
                double area = length * width;,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,

                for (int i = 1; i <= length; i++)
                {
                    for (int j = 1; j <= width; j++)
                    {

                        Console.Write("*");
                    }
                    Console.WriteLine();



                    
                }
                Console.WriteLine("Ristküliku pindala on: " + perimeter + " ja ümbermõõt on: " + area);
            }

            static void CalculateCircle()

            {

                Console.WriteLine("Sisestage ringi raadius: ");

                double radius = Convert.ToDouble(Console.ReadLine());
                double thickness = 0.4;
                char symbol = '*';
                double perimeter = Math.PI * (2 * radius);
                double area = Math.PI * (Math.Pow(radius, 2));
                Console.WriteLine();
                double rIn = radius - thickness, rOut = radius + thickness;

                for (double y = radius; y >= -radius; --y)
                {
                    for (double x = -radius; x < rOut; x += 0.5)
                    {
                        double value = x * x + y * y;
                        if (value >= rIn * rIn && value <= rOut * rOut)
                        {
                            Console.Write(symbol);
                        }
                        else0,
                            ,
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                }
                Console.WriteLine("Ringi pindala on: " + perimeter + " ja ümbermõõt on: " + area);


            }
        }
    }
}











                
            
        
    




    
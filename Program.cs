namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta Vokaal");
            char vokaal = Convert.ToChar(Console.ReadLine());

           
            switch (vokaal)
            {
                case 'a':
                    Console.WriteLine("Sisestasid a");
                    break;
                case 'e':
                    Console.WriteLine("Sisestasid e");
                    break;
                case 'i':
                    Console.WriteLine("Sisestasid i");
                    break;
                case 'o':
                    Console.WriteLine("Sisestasid o");
                    break;
                case 'u':
                    Console.WriteLine("Sisestasid u");
                    break;
                default:
                    Console.WriteLine("Ei sisestanud vokaali");
                    break;
            }

        }
    }
    }


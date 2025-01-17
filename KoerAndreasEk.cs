using System.Net.Http.Headers;

namespace MatemaatilineKoer
{
    internal class Program
    {

            static void Main(string[] args)
            {
                Console.WriteLine("Sisestage esimene arv: ");

                string number = Console.ReadLine();
                int nr1 = int.Parse(number);

                Console.WriteLine("Sisestage teine arv: ");

                  string number2 = Console.ReadLine();
                  int nr2 = int.Parse(number2);

            

                Console.WriteLine("Sisestage tehe: ");
               

            string ch = Console.ReadLine();
            switch (ch)

                {
                    case ("+"):
                    Console.WriteLine("Tulemus on: ");
                        Console.WriteLine(nr1 + nr2);
                        break;

                    case ("-"):
                    Console.WriteLine("Tulemus on: ");
                    Console.WriteLine(nr1 - nr2);
                        break;

                    case ("*"):
                    Console.WriteLine("Tulemus on: ");
                    Console.WriteLine(nr1 * nr2);
                        break;

                    case ("/"):
                    Console.WriteLine("Tulemus on: ");
                    Console.WriteLine(nr1 / nr2);
                        break;
                    default:
                    Console.WriteLine("Tulemus on: ");
                    Console.WriteLine("Ei ole korrektne tehe");
                        break;
                       
                }

            }
        }
    }

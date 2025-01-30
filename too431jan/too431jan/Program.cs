namespace too431jan
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Kas soovid ruutu teha?");
            string a = "ja";
            string b = "ei";
            string vastus = Console.ReadLine();

            switch (vastus)
            {
                case "ja":
                    Ruut();
                    break;
                case "ei":
                    Console.WriteLine("Otsustasite mitte ruutu teha");
                    break;
                default:
                    Console.WriteLine("Palun sisestage kas ja voi ei")
                    ; break;






            }
            static void Ruut()
            {

                int size = 5;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();

                }
                

            }


        }
    }
}

namespace MaaYmbermoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            double coinDiameter = 25.77; // mm

            double earthRadius = 6371000000; // mm

            double EarthCirumference = 2 * Math.PI * earthRadius;


            Console.WriteLine("Maa ymbermoot" + EarthCirumference);

            Console.WriteLine("maa ymber laheb " + EarthCirumference / coinDiameter + " 2 eurost mynti");
        }
    }
}

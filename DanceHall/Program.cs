namespace DanceHall
{
    using System;
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double woredrobe = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double woredrobeArea = Math.Pow(woredrobe, 2);
            double hallArea = length * width;
            double benchArea = hallArea / 10;
            double usableArea = hallArea - benchArea - woredrobeArea;
            double dancerArea = 7040 * 0.0001;

            double dancers = usableArea / dancerArea;
            Console.WriteLine(Math.Floor(dancers));
        }
    }
}

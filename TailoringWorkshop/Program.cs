namespace TailoringWorkshop
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double tableclothes = tables * (length + 0.6) * (width + 0.6);
            double squares = Math.Pow(length / 2, 2) * tables;

            double priceTableclothesUsd = tableclothes * 7;
            double priceSquaresUsd = squares * 9;

            double totalPriceUsd = priceTableclothesUsd + priceSquaresUsd;
            double totalPriceBgn = totalPriceUsd * 1.85;

            Console.WriteLine($"{totalPriceUsd:f2} USD");
            Console.WriteLine($"{totalPriceBgn:f2} BGN");
        }
    }
}

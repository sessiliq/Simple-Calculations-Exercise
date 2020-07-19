namespace AlchoholMarket
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            decimal whiskeyPricePerLiter = decimal.Parse(Console.ReadLine());
            decimal beer = decimal.Parse(Console.ReadLine());
            decimal wine = decimal.Parse(Console.ReadLine());
            decimal rakia = decimal.Parse(Console.ReadLine());
            decimal whiskey = decimal.Parse(Console.ReadLine());

            decimal rakiaPricePerLiter = whiskeyPricePerLiter / 2;
            decimal winePricePerLiter = rakiaPricePerLiter * 0.6m;
            decimal beerPricePerLiter = rakiaPricePerLiter * 0.2m;

            decimal totalPrice = (whiskey * whiskeyPricePerLiter) + (beer * beerPricePerLiter) + (wine * winePricePerLiter) + (rakia * rakiaPricePerLiter);

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}

namespace UsdToBgn
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double lv = usd * 1.79549;
            Console.WriteLine("{0:f2}", lv);
        }
    }
}

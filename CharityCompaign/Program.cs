namespace CharityCompaign
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cofectioners = int.Parse(Console.ReadLine());
            int cakePerDay = int.Parse(Console.ReadLine());
            int gofretsPerDay = int.Parse(Console.ReadLine());
            int pancakesPerDay = int.Parse(Console.ReadLine());

            double moneyPerDay = cofectioners * (cakePerDay * 45 + gofretsPerDay * 5.80 + pancakesPerDay * 3.20);
            double moneyPerCompaign = moneyPerDay * days;
            double allMoney = moneyPerCompaign * (1 - 0.125);

            Console.WriteLine("{0:f2}", allMoney);
        }
    }
}

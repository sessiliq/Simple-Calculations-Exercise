namespace RectangleArea2D
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double length = Math.Abs(x1 - x2);
            double width = Math.Abs(y1 - y2);
            
            Console.WriteLine("{0:f2}", length * width);
            Console.WriteLine("{0:f2}", 2 * length + 2 * width);
        }
    }
}

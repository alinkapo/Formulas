using System;

namespace Formulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = -0.5;
            double b = 1.7;
            double t = 0.44;

            double y = Math.Pow(2.7, (-b * t)) * Math.Sin(a * t + b) - Math.Sqrt(Math.Abs(b * t + a));
            double s = b * Math.Sin(Math.Pow((a * t), 2) * Math.Cos(a * t)) - 1;
            
            Console.WriteLine("y = {0}", y);
            Console.WriteLine("s = {0}", s);
            Console.ReadKey();
        }
    }
}
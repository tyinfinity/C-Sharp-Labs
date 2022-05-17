using System;

namespace Lab3
{
    internal class Program
    {
        static double Calculate(double x, double e)
        {
            double n = 1;
            double y = 0;
            double f = 0;

            do
            {
                double g = Math.Pow(x, n);
                y = f;
                f = y - g / n;
                n++;
            }
            while (Math.Abs(f - y) >= e);

            return y;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            double x = rnd.NextDouble() * 2 - 1;
            double e = 0.0001;

            Console.WriteLine($"{Math.Log(1 - x)} vs {Calculate(x, e)}");
        }
    }
}
using System;

namespace Task1
{
    internal class Program
    {
        static string convertDecToTer(int a)
        {
            int division = a / 3;
            int remainder = a % 3;
            string result = remainder.ToString();

            while (division > 0)
            {
                remainder = division % 3;
                division = division / 3;
                result += remainder.ToString();
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            int b = int.Parse(Console.ReadLine());

            for (; a <= b; a++)
            {
                int count = 0;
                foreach (char c in convertDecToTer(a))
                {
                    if (c == '2') count++;
                    if (count == 2)
                    {
                        Console.WriteLine(a);
                        break;
                    }
                }
            }
        }
    }
}

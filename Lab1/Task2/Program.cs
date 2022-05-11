using System;

namespace Task2
{
    internal class Program
    {
        static int Nod(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }

            return a + b;
        }

        static int Nok(int a, int b)
        {
            return a * b / Nod(a, b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"НОД равен {Nod(a, b)}. НОК равен {Nok(a, b)}.");
        }
    }
}

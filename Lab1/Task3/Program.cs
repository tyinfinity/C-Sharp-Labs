using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число: ");
            int a = int.Parse(Console.ReadLine());

            int number1 = a % 10;
            int number2 = a / 10 % 10;
            int number3 = a / 100;

            Console.WriteLine($"Сумма цифр числа равна: {number1 + number2 + number3}");
        }
    }
}
using System;

namespace Task2
{
    internal class Program : Fraction
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(1, 4);
            Fraction fraction2 = new Fraction(1, 3);
            
            var multiply = fraction1 * fraction2;
            var divide = fraction1 / fraction2;
            var sum = fraction1 + fraction2;
            var sub = fraction1 - fraction2;
            var more = fraction1 > fraction2;
            var less = fraction1 < fraction2;
            var equal = fraction1 == fraction2;

            Console.WriteLine($"Результат умножения: {multiply}. Результат деления: {divide}. \n" +
                              $"Результат сложения: {sum}. Результат вычитания: {sub}. \n" +
                              $"Первая дробь больше второй: {more}. Вторая дробь больше первой: {less}. \n" +
                              $"Дроби равны: {equal} и {fraction1.Equals(fraction2)}.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    internal class Program
    {

        static int Min(int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(min) > Math.Abs(arr[i]))
                {
                    min = arr[i];
                }

            }
            return min;
        }

        static int Sum(int[] arr)
        {
            int zero = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    zero = i;
                    break;
                }
            }

            int sum = 0;

            for (int i = zero; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        static List<int> Sort(int[] arr)
        {
            List<int> list = new List<int>();
            List<int> list1 = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    list.Add(arr[i]);
                }
                else
                {
                    list1.Add(arr[i]);
                }
            }
            list = list.Concat(list1).ToList();
            return list;
        }

        static int[] Sort2(int[] arr)
        {
            int saveI = 0;
            bool flag = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && flag)
                {
                    saveI = i;
                    flag = false;
                    continue;
                }
                if (arr[i] % 2 == 0)
                {
                    int z = arr[i];
                    arr[i] = arr[saveI];
                    arr[saveI] = z;
                    saveI += 1;
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа (одно из чисел должно быть нулём): ");
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(Sort(arr)[i] + " ");
            //}
            Console.WriteLine($"\nМинимальный по модулю элемент массива: {Min(arr)}");
            Console.WriteLine($"Сумма модулей элементов массива после нуля: {Sum(arr)}");
            var str = string.Join(" ", Sort2(arr));
            Console.WriteLine(str);
        }
    }
}
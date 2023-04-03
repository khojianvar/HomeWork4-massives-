﻿namespace Massives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            sumAndMultiply(n);
        }
        public static void sumAndMultiply(int n)
        {
            Random random = new Random();
            int[] array1 = new int[n];
            Console.WriteLine($"Before: ");
            for (int i = 0; i < n; i++)
            {
                array1[i] = random.Next(1, 10);
                Console.Write($"{array1[i]} ");
            }
            Console.WriteLine();
            int sum = 0;
            int multiply = 1;
            Console.WriteLine($"After: ");
            for (int i = 0; i < n; i++)
            {
                sum += array1[i];
                multiply *= array1[i];
            }
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Multiply: {multiply}");
        }
    }
}
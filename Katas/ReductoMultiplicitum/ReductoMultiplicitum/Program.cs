using System;
using System.Linq;

namespace ReductoMultiplicitum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SumDigProd(0, 0);
            SumDigProd(16, 28);
            SumDigProd(125, 52);
        }

        private static void SumDigProd(int v1, int v2)
        {
            // sum = numbers.sum()  | param: numbers[]
            int a = v1;
            int b = v2;
            int sum = a + b;

            Console.WriteLine(sum + $" ({v1} + {v2})\n");

            while (sum > 10)
            {
                var digits = sum.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();

                Console.WriteLine(sum);
                sum = digits[0];

                for (int i = 1; i < digits.Length; i++)
                {
                    Console.WriteLine($"({sum} * {digits[i]})");
                    sum *= digits[i];
                }
            }

            Console.WriteLine("\nSUM: " + sum + "\n");
        }
    }
}

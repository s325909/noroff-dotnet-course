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
            int a = v1;
            int b = v2;
            int sum = a + b;

            Console.WriteLine(sum + $" ({v1} + {v2})\n");

            while (sum > 10)
            {
                var s = sum.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();

                Console.WriteLine("SUM: " + sum);
                sum = s[0];

                for (int i = 1; i < s.Length; i++)
                {
                    Console.WriteLine($"({sum} * {s[i]})");
                    sum *= s[i];
                }
            }

            Console.WriteLine("\nSUM: " + sum + "\n");
        }
    }
}

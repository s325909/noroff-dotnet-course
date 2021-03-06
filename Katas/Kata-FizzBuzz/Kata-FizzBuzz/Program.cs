using System;

namespace Kata_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 1; i <=100; i++)
            {
                Console.WriteLine(ConvertFizzBuzz(i));
            }

            Console.ReadKey();
        }

        static string ConvertFizzBuzz(int i)
        {
            if (i % 15 == 0) return "FizzBuzz";
            else if (i % 3 == 0) return "Fizz";
            else if (i % 5 == 0) return "Buzz";
            else return i.ToString();
        }
    }
}

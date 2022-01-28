using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidCreditCard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            long cardNr = 123456789012345;

            bool cardCheck = ValidCreditCard(cardNr);
        }

        private static bool ValidCreditCard(long cardNr)
        {
            int[] digits = cardNr.ToString().Select(d => int.Parse(d.ToString())).ToArray();

            PrintArray(digits);

            Console.WriteLine(digits.Count());

            int[] reversedDigits = digits.Reverse().ToArray();

            if (digits.Contains(6))
            {
                for (int i = 1; i < reversedDigits.Count() - 1; i += 2)
                {
                    int doubled = 2 * reversedDigits[i];

                    // Console.WriteLine($"({i}) {doubled}");

                    if (doubled > 10)
                    {
                        var numbers = doubled.ToString().Select(d => int.Parse(d.ToString())).ToArray();
                        doubled = numbers[0] + numbers[1];
                        Console.WriteLine($"({i}) {numbers[0]} + {numbers[1]} = {doubled}");
                    }

                    Console.WriteLine("----------------------------------");

                    Console.WriteLine($"{reversedDigits[i]} | {doubled}");

                    reversedDigits[i] = doubled;

                    Console.WriteLine($"{reversedDigits[i]} | {doubled}");

                    Console.WriteLine("----------------------------------");

                    PrintArray(reversedDigits);
                }

                int sum = reversedDigits.Sum();

                Console.WriteLine("SUM: " + sum);



            }

            // PrintArray(digits.Reverse());

            return false;
        }

        private static void PrintArray(int[] digits)
        {
            StringBuilder sb = new();
            foreach (int digit in digits)
                sb.Append(digit);
            Console.WriteLine(sb.ToString()); 
        }


        //private void PrintArray(int[] digits)


    }
}

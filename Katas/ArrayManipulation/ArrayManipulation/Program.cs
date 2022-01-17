using System;

namespace ArrayManipulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = { 2, 3, 1, 7, 9, 5, 11, 3, 5 };

            int difference =  LargestDifferenceInArray(numbers);

            Console.WriteLine("Largest difference in array is: " + difference);

            int pairs = PairsOfNumbersInArray(numbers);
            Console.WriteLine("Pairs in array is: " + pairs);

        }

        public static int LargestDifferenceInArray(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int number = numbers[i];
                if (max < number) max = number;
                if (min > number) min = number;

                // Console.WriteLine($"Number: {number} | Min: {min} | Max: {max}");
            }
            int difference = max - min;

            return difference;
        }

        public static int PairsOfNumbersInArray(int[] numbers)
        {
            int difference = LargestDifferenceInArray(numbers);
            int pairs = 0;

            int size = numbers.Length - 1;

            for (int i = 0; i < size; i++)
            {
                for (int j = size; j >= 0; j--)
                {

                    int a = numbers[i];
                    int b = numbers[j];
                    if (a + b == difference)
                    {
                        Console.WriteLine($"{a} + {b} == {difference}");
                        pairs++;
                    }
                }

            }

            return pairs;

        }
    }
}

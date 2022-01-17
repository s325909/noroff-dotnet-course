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

        }

        public static int LargestDifferenceInArray(int[] numbers)
        {
            int size = numbers.Length;

            int max = numbers[0];
            int min = numbers[0];

            for (int i = 0; i < size - 1; i++)
            {
                int number = numbers[i];
                if (max < number) max = number;
                if (min > number) min = number;

                Console.WriteLine($"Number: {number} | Min: {min} | Max: {max}");
            }

            int difference = max - min;

            return difference;

        }
    }
}

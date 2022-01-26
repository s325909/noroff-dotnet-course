using System;
using System.Text;

namespace RomanNumeralConverter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Roman Numeral!");


            int value = 2006;
            Console.WriteLine("\nValue: " + value + " | " + RomanNumeralConverter(value));

            value = 1944;
            Console.WriteLine("\nValue: " + value + " | " + RomanNumeralConverter(value));

            value = 154;
            Console.WriteLine("\nValue: " + value + " | " + RomanNumeralConverter(value));

            value = 6;
            Console.WriteLine("\nValue: " + value + " | " + RomanNumeralConverter(value));


            /*
            string roman = RomanNumeralConverter(2006);
            Console.WriteLine(2006 + " == " + roman);
            Console.WriteLine();

            roman = RomanNumeralConverter(1944);
            Console.WriteLine(1944 + " == " + roman);
            Console.WriteLine();
            */


        }

        private static string RomanNumeralConverter(int value)
        {
            string[] romans = { "MMM", "MM", "M", "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C", "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X", "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };
            int[] numerals = { 3000, 2000, 1000, 900, 800, 700, 600, 500, 400, 300, 200, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            StringBuilder romanBulder = new();

            var index = 0;

            while (value > 0)
            {
                if (value >= numerals[index])
                {
                    value -= numerals[index];
                    romanBulder.Append(romans[index]);
                }
                else index++;
            }

            return romanBulder.ToString();
        }


        private static string RomanNumeralConverterRecursion(int value)
        {
            StringBuilder romanBuilder = new();

            while (value > 0)
            {
                Console.WriteLine("Value: " + value + " | RomanStringBuilder: " + romanBuilder.ToString());

                if (value >= 1000)
                    return romanBuilder.Append("M").ToString() + RomanNumeralConverter(value - 1000);
                if (value >= 500)
                    return romanBuilder.Append("D").ToString() + RomanNumeralConverter(value - 500);
                if (value >= 100)
                    return romanBuilder.Append("C").ToString() + RomanNumeralConverter(value - 100);
                if (value >= 50)
                    return romanBuilder.Append("L").ToString() + RomanNumeralConverter(value - 50);
                if (value >= 10)
                    return romanBuilder.Append("X").ToString() + RomanNumeralConverter(value - 10);
                if (value >= 5)
                    return romanBuilder.Append("V").ToString() + RomanNumeralConverter(value - 5);
                if (value >= 1)
                    return romanBuilder.Append("I").ToString() + RomanNumeralConverter(value - 1);

                Console.WriteLine("Value: " + value + " | RomanStringBuilder: " + romanBuilder.ToString());
            }

            return romanBuilder.ToString();
        }
    }
}

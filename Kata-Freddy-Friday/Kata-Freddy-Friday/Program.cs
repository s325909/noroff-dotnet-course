using System;
using System.Linq;

namespace Kata_Freddy_Friday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Freddy Friday!");

            var year = DateTime.Today.Year;

            while (year < 3000)
            {
                FreddyFriday(year);
                year++;
            }
            
            Console.ReadKey();
        }

        static void FreddyFriday(int year)
        {
            for (int i = 1; i <= 12; i++)
            {
                // DateTime date = new DateTime(DateTime.Today.Year, i, 13);
                DateTime date = new DateTime(year, i, 13);

                if (date.DayOfWeek == DayOfWeek.Friday)
                {
                    Console.WriteLine(date.ToString("dd\\t\\h MMMM yyyy") + " is a Friday");
                }
            }
        }
    }
}

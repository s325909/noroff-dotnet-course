using System;
using System.Linq;

namespace Kata_Freddy_Friday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var year = DateTime.Today.Year;

            while (year < 3000)
            {
                FreddyFriday(year);
                year++;
            }
            

            // int year = 2025;

            /**
            var month = DateTime.Today.Month;
            var day = DateTime.Today.Day;
            Console.WriteLine(year + " / " + month + " / " + day);
            **/

            /**
            for (int i = 1; i <= 12; i++)
            {
                DateTime date = new DateTime(DateTime.Today.Year, i, 13);
                if (date.DayOfWeek == DayOfWeek.Friday)
                {
                    Console.WriteLine(date.ToString("dd\\t\\h MMMM yyyy") + " is a Friday");
                }
            }
            **/


            // FreddyFriday(year);


            FreddyFridayThisYear(year);


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

        static void FreddyFridayThisYear(int year)
        {
            foreach (var month in Enumerable.Range(1, 12))
            {
                foreach (var day in Enumerable.Range(1, DateTime.DaysInMonth(year, month))
                          .Select(day => new DateTime(year, month, day).ToString("dddd MMM d")))
                {
                    // Console.WriteLine(day);

                    if (day.Contains("fredag mai") && day.Contains("13")) Console.WriteLine(day + " " + year);

                }
                // Console.WriteLine("Press a key to continue...");
                // Console.ReadKey(true);
            }
        }
    }
}

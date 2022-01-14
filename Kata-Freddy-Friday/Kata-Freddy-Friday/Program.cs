using System;
using System.Linq;

namespace Kata_Freddy_Friday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var year = DateTime.Today.Year + 1;

            // int year = 2025;

            /**
            var month = DateTime.Today.Month;
            var day = DateTime.Today.Day;
            Console.WriteLine(year + " / " + month + " / " + day);
            **/

            foreach (var month in Enumerable.Range(1, 12))
            {
                foreach (var day in Enumerable.Range(1, DateTime.DaysInMonth(year, month))
                          .Select(day => new DateTime(year, month, day).ToString("dddd MMM d")))
                {
                    // Console.WriteLine(day);

                    // if (day.Contains("fredag mai") && day.Contains("13")) Console.WriteLine("FREDDY FRIDAY!");

                    if (day.Contains("fredag mai") && day.Contains("13")) Console.WriteLine(day);

                }
                // Console.WriteLine("Press a key to continue...");
                // Console.ReadKey(true);
            }




            Console.ReadKey();
        }
    }
}

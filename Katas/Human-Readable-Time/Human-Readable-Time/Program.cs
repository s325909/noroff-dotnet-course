using System;

namespace Human_Readable_Time
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a non-negative integer < 360 000");
            int seconds = 1;
            while (seconds > 0)
            {
                seconds = Int32.Parse(Console.ReadLine());

                GetReadableTime(seconds);
            }


        }

        public static void GetReadableTime(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            Console.WriteLine(time.ToString());
        }
    }
}

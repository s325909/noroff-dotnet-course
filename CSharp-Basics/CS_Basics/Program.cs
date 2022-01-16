using System;
using System.Collections.Generic;

namespace CS_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> intList = new List<int>() { 1, 2, 3, 4 };
            ForLoop(intList);

            Console.ReadKey();
        }

        private static void ForLoop(List<int> intList)
        {
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(i + " " + intList[i]);
            }
        }
    }
}

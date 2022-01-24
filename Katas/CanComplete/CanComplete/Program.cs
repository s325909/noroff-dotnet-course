using System;
using System.Collections.Generic;

namespace CanComplete
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(CanComplete("butl", "beautiful"));

            Console.WriteLine(CanComplete("butlz", "beautiful"));

            Console.WriteLine(CanComplete("tulb", "beautiful"));

            Console.WriteLine(CanComplete("bbutl", "beautiful"));

        }

        private static bool CanComplete(string str, string word) 
        {
            char[] letters = str.ToCharArray();
            char[] words = word.ToCharArray();

            var occurrences = new Dictionary<char, int>();
            foreach (char c in word.ToCharArray())
            {
                if (occurrences.ContainsKey(c))
                    occurrences[c]++;
                else
                    occurrences.Add(c, 1);
            }

            var occurrences2 = new Dictionary<char, int>();
            foreach (char c in str.ToCharArray())
            {
                if (occurrences2.ContainsKey(c)) 
                    occurrences2[c]++; 
                else
                    occurrences2.Add(c, 1);
            }

            string s = "";
            foreach (char k in occurrences.Keys)
            {
                s += $"{k}: {occurrences[k]} | ";
            }
            Console.WriteLine(s);

            string s2 = "";
            foreach (char k in occurrences2.Keys) 
            {
                s2 += $"{k}: {occurrences2[k]} | ";
            }
            Console.WriteLine(s2);

            foreach (char k in occurrences2.Keys)
            {
                if (word.Contains(k) == false)
                    return false;

                Console.WriteLine(occurrences[k] + " < " + occurrences2[k]);

                if (occurrences[k] < occurrences2[k])
                    return false;

                // if (occurrences2[k] <= occurrences[k])
                // return true;
                Console.WriteLine("Return TRUE");
            }
            // Console.WriteLine(s2);

            

            return true;
        }
    }
}

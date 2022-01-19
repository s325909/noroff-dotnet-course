using System;
using System.Text;
using System.Text.RegularExpressions;

namespace PascalCase_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string str = "The quick brown fox jumped over the lazy dog";
            // ConvertPascalCase(str);

            string str2 = "pineapple on pizza";
            // ConvertPascalCase(str2);

            string str3 = "the quick   brown FOX! jUmpED   OVER the   lazy. dog";
            ConvertPascalCase(str3);
        }

        private static void ConvertPascalCase(string str)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");

            // string s = Regex.Replace(str, @"\s+", " ");
            string[] words = rgx.Replace(str, " ").ToLower().Split(" ");

            StringBuilder sb = new();

            foreach (string word in words)
            {
                // string s = Regex.Replace(word, @"\s+", String.Empty);
                if (word.Length > 0) sb.Append(char.ToUpper(word[0]) + word[1..].ToLower());
                // Console.WriteLine(s.Length);
            }
            
            Console.WriteLine(sb.ToString());
        }
    }
}

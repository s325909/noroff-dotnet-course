using System;
using System.Text;
using System.Text.RegularExpressions;

namespace PascalCase_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumped over the lazy dog";
            ConvertPascalCase(str);

            string str2 = "the <quick>   brown FOX! jUmpED   OVER the   lazy. dog";
            ConvertPascalCase(str2);
        }

        private static void ConvertPascalCase(string str)
        {
            StringBuilder sb = new();
            Regex rgx = new("[^a-zA-Z0-9 -]");
            string[] words = rgx.Replace(str, " ").ToLower().Split(" ");

            foreach (string word in words)
            {
                if (word.Length > 0) sb.Append(char.ToUpper(word[0]) + word[1..].ToLower());
            }
            
            Console.WriteLine(sb.ToString());
        }
    }
}

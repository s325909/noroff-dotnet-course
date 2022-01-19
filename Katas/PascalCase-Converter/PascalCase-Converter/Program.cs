using System;
using System.Text;

namespace PascalCase_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string str = "The quick brown fox jumped over the lazy dog";
            ConvertPascalCase(str);
        }

        private static void ConvertPascalCase(string str)
        {
            // string s = str.ToLower();
            string[] words = str.ToLower().Split(" ");

            StringBuilder sb = new();

            foreach (string word in words) 
            {
                sb.Append(char.ToUpper(word[0]) + word[1..].ToLower());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

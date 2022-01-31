using System;
using System.Linq;

namespace English2PigLatinTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "have";
            Console.WriteLine(str + " --> " + Eng2PigLatin(str));
            str = "cram";
            Console.WriteLine(str + " --> " + Eng2PigLatin(str));
            str = "take";
            Console.WriteLine(str + " --> " + Eng2PigLatin(str));
            str = "cat";
            Console.WriteLine(str + " --> " + Eng2PigLatin(str));
            str = "shrimp";
            Console.WriteLine(str + " --> " + Eng2PigLatin(str));
            str = "trebuchet";
            Console.WriteLine(str + " --> " + Eng2PigLatin(str));

            Console.WriteLine();

            str = "ate";
            Console.WriteLine(str + " --> " + Eng2PigLatin(str));
            str = "apple";
            Console.WriteLine(str + " --> " + Eng2PigLatin(str));
            str = "oaken";
            Console.WriteLine(str + " --> " + Eng2PigLatin(str));
            str = "eagle";
            Console.WriteLine(str + " --> " + Eng2PigLatin(str));
        }

        private static string Eng2PigLatin(string a)
        {
            bool isVowel = false;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'w' };
            string consonants = "";
            string latin = "";
            string pig = "ay";
            
            var chars = a.ToLower().ToCharArray(0, a.Length);

            if (vowels.Contains(chars[0]))
            {
                isVowel = true;
                pig = "yay";
            }

            foreach (char c in chars)
            {
                if (!isVowel && !vowels.Contains(c))
                {
                    consonants += c;
                } 
                else
                {
                    isVowel = true;
                    latin += c;
                }
            }

            string pigLatin = latin + consonants + pig;

            return pigLatin ;
        }
    }
}

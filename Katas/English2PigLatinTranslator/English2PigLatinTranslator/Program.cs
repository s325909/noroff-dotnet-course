using System;
using System.Linq;

namespace English2PigLatinTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "have";
            Console.WriteLine(str + " --> " + TranslateWord2PigLatin(str));
            str = "cram";
            Console.WriteLine(str + " --> " + TranslateWord2PigLatin(str));
            str = "take";
            Console.WriteLine(str + " --> " + TranslateWord2PigLatin(str));
            str = "cat";
            Console.WriteLine(str + " --> " + TranslateWord2PigLatin(str));
            str = "shrimp";
            Console.WriteLine(str + " --> " + TranslateWord2PigLatin(str));
            str = "trebuchet";
            Console.WriteLine(str + " --> " + TranslateWord2PigLatin(str));

            Console.WriteLine();

            str = "ate";
            Console.WriteLine(str + " --> " + TranslateWord2PigLatin(str));
            str = "apple";
            Console.WriteLine(str + " --> " + TranslateWord2PigLatin(str));
            str = "oaken";
            Console.WriteLine(str + " --> " + TranslateWord2PigLatin(str));
            str = "eagle";
            Console.WriteLine(str + " --> " + TranslateWord2PigLatin(str));


            str = "flag";
            Console.WriteLine(str + " --> " + TranslateWord2PigLatin(str));
            str = "button";
            Console.WriteLine(str + " --> " + TranslateWord2PigLatin(str));

            str = "I like to eat honey waffles.";
            Console.WriteLine(str + " --> " + TranslateSentence2PigLatin(str));
            str = "Do you think it is going to rain today?";
            Console.WriteLine(str + " --> " + TranslateSentence2PigLatin(str));
        }

        private static string TranslateWord2PigLatin(string a)
        {
            var chars = a.ToLower().ToCharArray(0, a.Length);
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            bool isVowel = false;
            string pig = "ay";
            string latin = "";
            string consonants = "";
            
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

            return latin + consonants + pig; ;
        }

        private static string TranslateSentence2PigLatin(string str) 
        {
            var words = str.Split();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            bool isVowel = false;
            string pig = "ay";
            string latin = "";
            string consonants = "";

            string pigLatin = "";


            foreach (string word in words)
            {
                var chars = word.ToLower().ToCharArray(0, word.Length);


                if (vowels.Contains(chars[0]))
                {
                    isVowel = true;
                    pig = "yay";
                }

                foreach (char c in chars)
                {
                    if (char.IsLetter(c))
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
                }

                pigLatin += (latin + consonants + pig) + " ";

                isVowel = false;
                pig = "ay";
                latin = "";
                consonants = "";

            }



            return pigLatin;
        }
    }
}

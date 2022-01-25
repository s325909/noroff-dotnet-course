using System;

namespace Parseltongue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ssspoken by a parssseltongue?");

            string a = "Sshe ssselects to eat that apple.";
            Console.WriteLine(a + " --> " + IsParselTounge(a));

            string b = "She ssselects to eat that apple.";
            Console.WriteLine(b + " --> " + IsParselTounge(b));

            string c = "You ssseldom sssspeak sso boldly, ssso messmerizingly.";
            Console.WriteLine(c + " --> " + IsParselTounge(c));

            string d = "Steve likes to eat pancakes";
            Console.WriteLine(d + " --> " + IsParselTounge(d));

            string e = "Sssteve likess to eat pancakess";
            Console.WriteLine(e + " --> " + IsParselTounge(e));

            string f = "Beatrice samples lemonade";
            Console.WriteLine(f + " --> " + IsParselTounge(f));

            string g = "Beatrice enjoysss lemonade";
            Console.WriteLine(g + " --> " + IsParselTounge(g));
        }

        private static bool IsParselTounge(string v)
        {
            string[] words = v.Split(' ');

            foreach (string word in words)
            {
                char[] letters = word.ToCharArray();

                for (int i = 0; i < letters.Length - 1; i++)
                {
                    // Console.WriteLine(letters[i] + " | " + letters[i+1]);

                    if (letters[i].ToString().ToLower().Equals("s"))
                    {
                        if (letters[i + 1].ToString().ToLower().Equals("s"))
                            return true;
                        else return false;
                    }

                    // if (letters[i].ToString().ToLower().Equals("s") && letters[i + 1].ToString().ToLower().Equals("s"))
                       // return true;
                }
            }

            return false;
        }
    }
}

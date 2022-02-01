using System;
using System.Globalization;

namespace SnakeAndCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello_edabit";
            Console.WriteLine(str + " --> " + ToCamelCase(str));

            str = "helloEdabit";
            Console.WriteLine(str + " --> " + ToSnakeCase(str));

            str = "is_modal_open";
            Console.WriteLine(str + " --> " + ToCamelCase(str));

            str = "getColor";
            Console.WriteLine(str + " --> " + ToSnakeCase(str));
        }

        private static string ToCamelCase(string str)
        {
            var words = str.ToLower().Split("_");
            string camelCase = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                var titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words[i]);
                camelCase += titleCase;
            }
            return camelCase;
        }

        private static string ToSnakeCase(string str)
        {
            var chars = str.ToCharArray(0, str.Length);
            string snake_case = "";
            
            foreach (char c in chars)
            {
                if (char.IsUpper(c))
                    snake_case += ("_" + c.ToString().ToLower());
                else
                    snake_case += c;
            }
            return snake_case;
        }
    }
}

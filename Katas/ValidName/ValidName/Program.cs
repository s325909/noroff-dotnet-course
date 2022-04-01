using System;
using System.Linq;

namespace ValidName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string name = "H. Wells"; 
            Console.WriteLine(ValidateName(name));
            name = "H. G. Wells";
            Console.WriteLine(ValidateName(name));
            name = "Herbert G. Wells";
            Console.WriteLine(ValidateName(name));
            name = "Herbert George Wells";
            Console.WriteLine(ValidateName(name));
            name = "Herbert George Wells";
            Console.WriteLine(ValidateName(name));

            Console.WriteLine("----------------");

            name = "Herbert";
            Console.WriteLine(ValidateName(name));
            name = "H Wells";
            Console.WriteLine(ValidateName(name));
            name = "H. G Wells";
            Console.WriteLine(ValidateName(name));
            name = "H. wells";
            Console.WriteLine(ValidateName(name));
            name = "H. George Wells";
            Console.WriteLine(ValidateName(name));
            name = "H. G. W. ";
            Console.WriteLine(ValidateName(name));
            name = "Herb. G.";
            Console.WriteLine(ValidateName(name));
        }

        private static bool ValidateName(string name)
        {
            bool validInitialName = false;
            bool validName = false;
            bool validInitial = false;

            var names = name.Split();

            if (names.Length < 2)
                return false;

            foreach (string str in names)
            {
                if (str.Length < 2)
                    return false;

                var initals = name.ToCharArray();
                // Console.WriteLine($"({str.Length}) {initals[0]} | {initals[1]}");

                if (char.IsLower(initals[0]))
                    return false;

                


                if (str.Length == 2 && Char.IsUpper(initals[0]) && str.EndsWith("."))
                {
                    // if (names[0] )
                    validInitial = true;
                }
                    
                
                if (Char.IsUpper(initals[0]) && !str.EndsWith("."))
                {
                    validName = true;
                }
            }

            if (!validName)
                return false;

            if (validInitial && validName)
                validInitialName = true;

            if (validName || validInitialName)
                return true;
                
            return false;
        }
    }
}

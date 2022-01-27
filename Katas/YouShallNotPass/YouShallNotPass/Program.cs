using System;

namespace YouShallNotPass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string invalid = "stonk";
            string invalid2 = "pass word";
            Console.WriteLine(invalid + " --> " + ValidatePasswordStrength(invalid));
            Console.WriteLine(invalid2 + " --> " + ValidatePasswordStrength(invalid2));

            string weak = "password";
            string weak2 = "11081992";
            Console.WriteLine(weak + " --> " + ValidatePasswordStrength(weak));
            Console.WriteLine(weak2 + " --> " + ValidatePasswordStrength(weak2));

            string moderate = "mySecurePass123";
            string moderate2 = "!@!pass1";
            Console.WriteLine(moderate + " --> " + ValidatePasswordStrength(moderate));
            Console.WriteLine(moderate2 + " --> " + ValidatePasswordStrength(moderate2));

            string strong = "@S3cur1ty";
            string password = "pas5Word!";
            Console.WriteLine(strong + " --> " + ValidatePasswordStrength(strong));
            Console.WriteLine(password + " --> " + ValidatePasswordStrength(password));
        }

        private static string ValidatePasswordStrength(string password)
        {
            int creiteriaCheck = 0;

            if (password.Length < 6 || String.IsNullOrWhiteSpace(password))
                return "Invalid";

            if (password.Length >= 8)
                creiteriaCheck++;
            

            var chars = password.ToCharArray(0, password.Length);

            bool isLower = false;
            bool isUpper = false;
            bool isDigit = false;
            bool isSpecial = false;

            for (int i = 0; i < chars.Length; i++)
            {
                char ch = chars[i];

                if (!isLower && char.IsLower(ch))
                {
                    isLower = true;
                    creiteriaCheck++;
                }
                    
                if (!isUpper && char.IsUpper(ch))
                {
                    isUpper = true;
                    creiteriaCheck++;
                }

                if (!isDigit && char.IsDigit(ch))
                {
                    isDigit = true;
                    creiteriaCheck++;
                }
                    
                if (!isSpecial && !char.IsLetterOrDigit(ch))
                {
                    isSpecial = true;
                    creiteriaCheck++;
                }

                // Console.WriteLine($"({creiteriaCheck} / 5) {ch}: {isLower} | {isUpper} | {isDigit} | {isSpecial}");
            }


               

            
            if (creiteriaCheck > 4) return "Strong";
            else if (creiteriaCheck >= 3) return "Moderate";
            else if (creiteriaCheck >= 2)return "Weak";
            else return "Invalid";
        }
    }
}

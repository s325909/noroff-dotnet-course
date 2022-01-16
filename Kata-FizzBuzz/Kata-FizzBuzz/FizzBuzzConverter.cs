using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_FizzBuzz
{
    public class FizzBuzzConverter
    {
        public string Convert(int input)
        {
            if (input % 15 == 0)
                return "FizzBuzz";
            if (input % 3 == 0)
                return "Fizz";
            if (input % 5 == 0)
                return "Buzz";

            return input.ToString();
        }

    }
}

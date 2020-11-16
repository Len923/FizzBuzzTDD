using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzApp
{
    public class FizzBuzz
    {
        private int length;

        public FizzBuzz(int length)
        {
            this.length = length;
        }

        public string check(int input)
        {
            string output = "";
            if ((input % 3)==0)
            {
                output += "fizz";
            }
            if((input % 5) == 0)
            {
                output += "buzz";
            }
            if (output.Equals(""))
            {
                return input.ToString();
            }
            else
            {
                return output;
            }
        }
    }
}

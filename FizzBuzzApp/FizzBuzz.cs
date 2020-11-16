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
            if ((input % 3)==0)
            {
                return "fizz";
            }
            return input.ToString();
        }
    }
}

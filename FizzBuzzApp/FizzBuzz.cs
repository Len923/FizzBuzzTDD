using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzApp
{
    public class FizzBuzz
    {
        public int length;

        public FizzBuzz(int length)
        {
            this.length = length;
        }

        public string CheckFizzBuzz(int input)
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

        public string[] StartFizzBuzz()
        {
            List<string> output = new List<string>();
            for(int i = 1; i <= length; i++)
            {
                output.Add(CheckFizzBuzz(i));
            }
            return output.ToArray();
        }
    }
}

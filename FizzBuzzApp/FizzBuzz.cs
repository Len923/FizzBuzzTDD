using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzApp
{
    public class FizzBuzz
    {
        public int length;
        public int startValue;
        public static readonly List<KeyValuePair<int, string>> FIZZBUZZ = new List<KeyValuePair<int, string>>()
        {
            new KeyValuePair<int, string>(3,"fizz"),
            new KeyValuePair<int,string>(5,"buzz")
        };
        public List<KeyValuePair<int, string>> format = new List<KeyValuePair<int, string>>(FIZZBUZZ);

        public FizzBuzz(int length = 100, int startValue = 1)
        {
            this.length = length;
            this.startValue = startValue;
        }

        public string CheckFizzBuzz(int input)
        {
            string output = "";

            foreach(KeyValuePair<int,string> option in format)
            {
                if ((input % option.Key) == 0)
                {
                    output += option.Value;
                }
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
            format.Sort((x,y) => x.Key.CompareTo(y.Key));
            List<string> output = new List<string>();
            for(int i = startValue; i < startValue + length; i++)
            {
                output.Add(CheckFizzBuzz(i));
            }
            return output.ToArray();
        }
    }
}

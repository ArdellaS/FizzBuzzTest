using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzBaz
{
    public class FBB
    {
        public static string FizzBuzz(int a)
        {
            string num;
            string fbb = "";

            for (int i = 0; i < 101; i++)
            {
                num = i.ToString();

                if (i%3 ==0 || num.Contains("3"))
                {
                    fbb += "fizz";   
                }
                if (i % 5 == 0 || num.Contains("5"))
                {
                    fbb += "buzz";
                }
                if (i % 7 == 0 || num.Contains("7"))
                {
                    fbb += "baz";
                }
                else
                {
                    return num;
                }
            }
            return fbb;
        }

        public static string Fizz2(int a)
        {
            string fbb = String.Empty;
            string num = a.ToString();
            if (a % 3 == 0 || num.Contains("3"))
            {
                fbb += "fizz";
            }
            if (a % 5 == 0 || num.Contains("5"))
            {
                fbb += "buzz";
            }
            if (a % 7 == 0 || num.Contains("7"))
            {
                fbb += "baz";
            }
            else
            {
                return fbb;
            }
            return fbb;
        }
    }
}

using System;
using System.Collections.Generic;

namespace BinaryRep
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "1111011110000011100000110001011011110010111001010111110001";
            Console.WriteLine(NumSteps(s));
        }

        public static int NumSteps(string s)
        {
            int step = 0;
            int carry = 0;
            for (int i = s.Length - 1; i > 0; i--)
            {
                if (s[i] - '0' + carry == 1)
                {
                    step++;
                    carry = 1;
                }
                step++;
            }

            return step + carry;
        }
    }
}

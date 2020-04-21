using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 20; i++)
            {

                if (i % 3 == 0)  // the output keeps changing through out the loop
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode1395
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rating = { 2, 5, 3, 4, 1 };
            Console.WriteLine(NumTeams(rating));
        }

        public static int NumTeams(int[] rating)
        {
            int i, j, k;
            int numberOfteams = 0;
           
            for (i=0; i<rating.Length; i++)
            {
                for (j = 1; j<rating.Length; j++)
                {

                    for (k = 2; k < rating.Length; k++)
                    {
                        
                        if (rating[i] < rating[j] && rating[j] < rating[k] && i < j && j < k)
                        {
                            numberOfteams++;
                        }
                        if (rating[i] > rating[j] && rating[j] > rating[k] && i < j && j < k)
                        {
                            numberOfteams++;
                        }                  
                    }
                }
            }
            return numberOfteams;
        }
    }
}

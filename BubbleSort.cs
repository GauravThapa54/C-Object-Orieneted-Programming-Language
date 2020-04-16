using System;

namespace AlgorithemPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 9, 7, 1, 3, 6, 5 };

            BubbleSort(arr);
        }


        static void BubbleSort(int[] lst)
        {
            int i, j, temp;

            for (i = 0; i < lst.Length; i++)
            {
                for (j = 0; j < lst.Length - 1; j++)
                {
                    if (lst[j] > lst[j + 1]) // if current is bigger then next
                    {
                        temp = lst[j]; // fill temp with current
                        lst[j] = lst[j + 1]; // fill current with next
                        lst[j + 1] = temp; // fill next with current
                    }
                }
            }
            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}

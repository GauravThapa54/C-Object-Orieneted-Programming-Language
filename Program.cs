using System;
using System.Collections.Generic;

namespace Arrays.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>{ "<name of friends>", "Ana", "felipe" };

            names.Add("Johnny");
            names.Add("Phil");
            names.Add("Jenny");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(names[0]);

            //The other method of Array 


            //var names = new List<string>{ "<name>", "Ana", "felipe" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine($"Hello {name.ToUpper()}!");
            //}
            //for ( int i = 0; i < names.Count; i ++)
            //{
            //    Console.WriteLine($"hello {names[i].ToUpper()}!"); ;
            //}

        }
    }
}

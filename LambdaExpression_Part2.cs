using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> myList = new List<Student>();

            myList.Add(new Student("Mystique", "Human Anatomy", "3.2"));
            myList.Add(new Student("Charles", "Phsyschology", "4.0"));
            myList.Add(new Student("Logan", "Biology", "2.5"));

            myList.Sort((x, y) => { return x.Major.CompareTo(y.Major); });

            foreach (Student st in myList)
                Console.WriteLine(st.Name + " : "+st.Major + " Scoring a Total of " + st.GPAScore);
        }

        class Student
        {
            public string Name { get; set; }
            public string Major { get; set; }
            public string GPAScore { get; set; }

            public Student(string nm, string mj, string gpsc)
            {
                Name = nm;
                Major = mj;
                GPAScore = gpsc; 
            }
        }
    }
}

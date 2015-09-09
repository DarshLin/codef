using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectThree
{
    class P3
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\Users\Darsh\Documents\Visual Studio 2013\Projects\ProjectThree\ProjectThree\input.txt");
            Student student;
            Heap<Student> theHeap = new Heap<Student>();
            

            string sr = reader.ReadLine();//raid

            Student[] records = new Student[sr.Length];

            while (sr != null)// while there is still text
            {
                string[] delimiter = { ",", " " };
                string[] info = sr.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                student = new Student(Convert.ToInt32(info[0]), Convert.ToDouble(info[1]));
                double gpa = student.GPA; 
                theHeap.Insert(student);
                sr = reader.ReadLine();
            }
            //theHeap.HeapSort();
            theHeap.Print();

                Console.ReadKey();
        }
    }
}

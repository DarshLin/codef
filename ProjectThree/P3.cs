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
        //static void ReadFile(string filename)
        //{

        //    StreamReader reader = new StreamReader(filename);
        //    Student student;
        //    Heap<Student> theHeap = new Heap<Student>();//this line is wrong, fix it
            

        //    string sr = reader.ReadLine();//raid
           
        //    while (sr != null)// while there is still text
        //    {
        //        string[] delimiter = { ",", " ", " " };
        //        string[] info = sr.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
        //        student = new Student(Convert.ToInt32(info[0]), Convert.ToDouble(info[1]));
        //        sr = reader.ReadLine();

        //        theHeap.Insert(student);

        //        Console.WriteLine(student);
        //    }
        //}
        static void Main(string[] args)
        {
            //ReadFile(@"C:\Users\Darsh\Documents\Visual Studio 2013\Projects\ProjectThree\ProjectThree\input.txt");



            StreamReader reader = new StreamReader(@"C:\Users\Darsh\Documents\Visual Studio 2013\Projects\ProjectThree\ProjectThree\input.txt");
            Heap<Student> theHeap = new Heap<Student>();
            Student student;
            

            string sr = reader.ReadLine();//raid

            Student[] records = new Student[sr.Length];

            while (sr != null)// while there is still text
            {
                string[] delimiter = { ",", " " };
                string[] info = sr.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                student = new Student(Convert.ToInt32(info[0]), Convert.ToDouble(info[1]));
                Console.WriteLine(student.ID);
                theHeap.Insert(student);
                sr = reader.ReadLine();
            }

                //theHeap.Insert(student);

           

                Console.ReadKey();
        }
    }
}

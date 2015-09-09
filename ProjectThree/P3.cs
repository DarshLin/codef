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
                
                theHeap.Insert(student);//insert all data into the Heap
                sr = reader.ReadLine();
            }
            Console.WriteLine("Empty? {0}",theHeap.IsEmpty()); //false
            Console.WriteLine("Root: {0}",theHeap.GetRoot());

            theHeap.RemoveRoot();
            theHeap.Print(); //Prints out student id and gpa as min heap

            
            Console.WriteLine();
            Console.WriteLine("HEAPSORT!!");
            theHeap.HeapSort();//prints out the heap sort going from high to low
            
            
            
            
            
            
            Console.ReadKey();
        }
    }
}

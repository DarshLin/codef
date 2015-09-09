using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectThree
{
    class Student : IComparable
    {
        private int id;
        private double gpa;

        public int ID { get { return id; } }

        public double GPA { get { return gpa; } }

        public Student(int id, double gpa)
        {
            this.id = id;
            this.gpa = gpa;
        }
        public void Print() 
        {
            Console.WriteLine("{0}, {1}", id, GPA);
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

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
        public Student()
        {
            this.id = ID;
            this.gpa = GPA;
        }

        public Student(int id, double gpa)
        {
            this.id = id;
            this.gpa = gpa;
        }

        public int CompareTo(object obj)
        {
            Student p = obj as Student;
            if (this.GPA > p.GPA)
                return 1;
            else if (this.GPA == p.GPA)
                return 0;
            else
                return -1;
        }
        public override string ToString()
        {
            return String.Format("ID: {0}, GPA: {1}", this.ID, this.GPA);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFourteen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Sort<int> sorter = new Sort<int>();

            list.Add(55);
            list.Add(45);
            list.Add(32);
            list.Add(61);
            list.Add(88);
            list.Add(92);
            list.Add(4);
            list.Add(74);
            list.Add(123);
            list.Add(16);
            list.Add(861);
            list.Add(64);
            list.Add(49);
            list.Add(34);
            list.Add(67);
            list.Add(478);
            list.Add(58);
            list.Add(12);

            sorter.MergeSort(list);
            //sorter.Print(list);

                Console.ReadKey();
        }
    }
}

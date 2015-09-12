using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        class Sorts<T> where T : IComparable
        {
            //private List<T> Merge(List<T> Left, List<T> Right)
            //{


            //}

            public void MergeSort(List<int> list)
            {
                int length = list.Count;
                if (length < 2)
                {
                    return;
                }
                int mid = length / 2;
                List<int> left = new List<int>();
                List<int> right = new List<int>();

                for (int i = 0; i < mid; i++)
                {
                    left.Add(list[i]);
                }
                for (int i = mid; i < length; i++)
                {
                    right.Add(list[i]);
                }
                MergeSort(left);
                MergeSort(right);
                Merge(left, right);

            }
            public void Merge(List<int> left, List<int> right)
            {
                List<int> list = new List<int>();

                int lc = left.Count;
                int rc = right.Count;
                int l = 0;
                int r = 0;

                while (l < left.Count && r < right.Count)
                {
                    if (left[l] <= right[r])
                    {
                        list.Add(left[l]);
                        l = l + 1;
                    }
                    else
                    {
                        list.Add(right[r]);
                        r = r + 1;
                    }
                if (l < lc)
                    list.Add(left[l]);
                else if (r < rc)
                    list.Add(right[r]);
                
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
                }
            }
            public void Print(List<int> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
          
            static void Main(string[] args)
            {
                Sorts<int> sort = new Sorts<int>();

                List<int> list = new List<int>();
                List<int> list2 = new List<int>();

                list.Add(3);
                list.Add(9);
                list.Add(12);
                list.Add(16);
               

                list2.Add(4);
                list2.Add(8);
                list2.Add(13);
                list2.Add(20);
                

               sort.Merge(list, list2);
                


                Console.ReadKey();
            }
        }
    }


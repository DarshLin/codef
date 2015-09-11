using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFourteen
{
    class Sort<T> where T : IComparable
    {
        //List<T> list = new List<T>();
        public void InsertionSort(List<T> list)
        {
            //list = new List<T>();
            T data;
            int j;
            for (int i = 1; i < list.Count; i++)
            {
                data = list[i];
                j = i;
                while (j > 0 && list[j-1].CompareTo(data) >0)
                {
                    list[j] = list[j - 1];
                    j = j - 1;
                    list[j] = data;
                }
            }
        }
        private List<T> Merge(List<T> Left, List<T> Right)
        {
            List<T> list = new List<T>();
            int l = Left.Count;
            int r = Right.Count;

            int x = 0; //Left indexer
            int y = 0; //Right indexer
            int z = 0; //list indexer

            while (x < l && y < r)
            {
                if (Left[x].CompareTo(Right[y]) < 0)
                {
                    list.Add(Left[x]);
                    Left.RemoveAt(x);
                    x = x + 1;
                }
                else
                {
                    list.Add(Right[y]);
                    Right.RemoveAt(y);
                    y = y + 1;

                }
                z = z + 1;
                while (x < l) //get the rest on left
                {
                    list.Add(Left[x]);
                    z = z + 1;
                    x = x + 1;
                }
                while (y < r) //get rest on right
                {
                    list.Add(Right[y]);
                    z = z + 1;
                    y = y + 1;
                }
            }
            return list;
        }
        public List<T> MergeSort(List<T> line)
        {
            List<T> list = new List<T>(line);

            //T data;
            int length = list.Count;
            
            if (length < 2)
            {
                return list;
            }

            int mid = length / 2;
            List<T> Left = new List<T>(mid);
            List<T> Right = new List<T>(length - mid);

            for (int i = 0; i < mid; i++)
            {
                Left.Add(list[i]);
                Console.WriteLine(Left[i]);
            }
            for (int i = mid; i < length; i++)
            {
                Right.Add(list[i]);

            }
            List<T> msLeft = MergeSort(Left);
            List<T> msRight = MergeSort(Right);
            return Merge(msLeft, msRight);

        }
        
        public void HeapSort()
        {

        }
        public void QuickSort()
        {

        }
        public void ListSort()
        {

        }
        public void Print(List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}

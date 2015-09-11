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
        public void InsertionSort(List<T> line)
        {
            List<T> list = new List<T>(line);
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

            for(int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine(list[i]);
            }
        }
        private void Merge(List<T> Left, List<T> Right, List<T> list)
        {
            int l = Left.Count;
            int r = Right.Count;

            int x = 0;
            int y = 0;
            int z = 0;

            while (x < l && y < r)
            {
                if (Left[x].CompareTo(Right[y]) < 0)
                {
                    list[z] = Left[x];
                    z++;
                    x++;
                }
                else
                {
                    list[z] = Right[y];
                    z++;
                    y++;
                }
            }

        }
        public void MergeSort(List<T> line)
        {
            List<T> list = new List<T>(line);

            T data;
            int length = list.Count;
            if (length < 2)
            {
                return;
            }

            int mid = length / 2;
            List<T> Left = new List<T>(mid);
            List<T> Right = new List<T>(length - mid);

            for (int i = 0; i < mid; i++)
            {
                Left.Add(list[i]);
               
            }
            for (int i = mid; i < length; i++)
            {
                data = list[i];
                Right.Add(data);
            }

            MergeSort(Left);
            MergeSort(Right);
            Merge(Left, Right, list);
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
    }
}

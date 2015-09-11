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
        private void Merge(List<T> Left, List<T> Right, List<T> list)
        {
            int l = Left.Count;
            int r = Right.Count;

            int x = 0; //Left indexer
            int y = 0; //Right indexer
            int z = 0; //list indexer

            while (x < l && y < r)
            {
                if (Left[x].CompareTo(Right[y]) < 0)
                {
                    list[z] = Left[x];
                    x = x + 1;

                }
                else
                {
                    list[z] = Right[y];
                    y = y + 1;

                }
                z = z + 1;
                while (x < l) //get the rest on left
                {
                    list[z] = Left[x];
                    z = z +1;
                    x = x + 1;
                }
                while(y < r) //get rest on right
                {
                    list[z] = Right[y];
                    z = z + 1;
                    y = y + 1;
                }
            }
        }
        public void MergeSort(List<T> list)
        {
            T[] nList = new T[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                nList[i] = list[i];
            //Console.WriteLine(nList[i]);
            }

            int length = nList.Length;
            if (length < 2)
            {
                return;
            }


            int mid = length / 2;
            T[] left = new T[mid];
            T[] right = new T[length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = nList[i];
            }
            for (int i = mid; i < length; i++)
            {
                right[i] = nList[i];
            }

            //MergeSort(Left);
            //MergeSort(Right);
            //Merge(Left, Right, list);
            
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

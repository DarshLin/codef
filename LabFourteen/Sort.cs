using System;
using System.Collections;
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
        private void Merge(T[] list, int st, int mi, int en) //could probbly make comparer somewhere else
        {
            T[] mList = new T[en- st];

            int l = 0; //Left indexer
            int r = 0; //Right indexer
            int i = 0; //list indexer
            //T data;
            
            while (l < mi - st && r < (en - mi))
            {
                mList[i++] = list[st + 1].CompareTo(list[mi + r]) < 0 
                    ? list[st + l++] : list[mi + r++];
            }

            while (r < en - mi)
            {
                mList[i++] = list[mi + r++];
            }
            while (l < mi - st)
            {
                mList[i++] = list[st + l++];
            }
            Array.Copy(mList, 0, list, st, mList.Length);

        }
        public T[] MergeSort(List<T> line)
        {
            T[] list = new T[line.Count];
            for (int i = 0; i < line.Count; i++)
            {
                list[i] = line[i];
            }

            int length = list.Length;
            int mid = length / 2;
            for (int i = 0; i < mid + 1; i = i * 2)
            {
                for (int j = i; j < length; j = j + 2 * i)
                {
                    Merge(list, j - i, j, Math.Min(j + i, length));
                }
            }
            return list;
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

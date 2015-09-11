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
                mList[i++] = list[mi + r++];
            while (l < mi - st)
                mList[i++] = list[st + l++];
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

        private void Heapify(List<T> list, int count, int pos) //Helper for Heapsort
        {
            int l = (pos + 1) * 2 - 1;
            int r = (pos + 1) * 2;
            int min = 0;

            if (l < count && list[l].CompareTo(list[pos]) > 0)
            {
                min = l;
            }
            else
                min = pos;

            if (r < count && list[r].CompareTo(list[min]) > 0)
                min = r;
            if (min != pos)
            {
                T temp = list[pos];
                list[pos] = list[min];
                list[min] = temp;

                Heapify(list, count, min);
            }
        }
        public void HeapSort(List<T> list)
        {

            List<T> nList = new List<T>(list);

            int size = nList.Count;
            for (int p = (size - 1) / 2; p >= 0; p--)
            {
                Heapify(nList, size, p);

            }
            for (int i = nList.Count - 1; i > 0; i--)
            {
                T temp = nList[i];
                nList[i] = nList[0];
                nList[0] = temp;

                size--;
                Heapify(nList, size, 0);
            }

            for (int i = 0; i < nList.Count; i++)
            {
                Console.WriteLine(nList[i]);
            }
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

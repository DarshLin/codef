using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectThree
{
    class Heap<T> where T :IComparable
    {
        private List<T> theHeap; 
        private bool isMinHeap;
        //private Student student;
        //private int index;
        
        public Heap()
        {
            theHeap = new List<T>();
        }

        public Heap(bool isMinHeap)
        {
            
        }
        //constructors
        public bool IsEmpty()
        {
            return theHeap.Count == 0;
        }
        public void Insert(T item)//the problem is that it keeps looping through and the update to index doesnt work
        {

            if (theHeap.Count == 0)
            {
                theHeap = new List<T>();
                theHeap.Add(item);
            }
            else
            {
                theHeap.Add(item);
                PercolateUp(theHeap.Count - 1);
            }
            
        }
        public T GetRoot()
        {
            if (theHeap.Count == 0)
            {
                return default(T);
            }
            else
            {
                T item = theHeap[0];
                return item;
            }
        }

        public void RemoveRoot()
        {
            if (theHeap.Count == 0)
            {
                return;
            }
            else
            {
                theHeap[0] = theHeap[theHeap.Count - 1]; //swapping the first and last

                if (theHeap.Count > 0)
                {
                    PercolateDown(0);
                }
            }

        }
        public void Print()
        {
            foreach (T i in theHeap)
            {
                Console.WriteLine(i);
            }
        }
        public void HeapSort()
        {
            if (theHeap.Count == 0)
            {
                return;
            }
            else
            {
                List<T> nList = new List<T>(theHeap);
                int p = (nList.Count - 1) / 2;

                for (int i = p; p >= 0; p--)
                    Heapify(nList, nList.Count, i);
                for (int j = nList.Count - 1; j > 0; j--) // swap
                {
                    T temp = nList[j];
                    nList[j] = nList[0];
                    nList[0] = temp;

                    Heapify(nList, nList.Count, 0);
                }
                for (int i = 0; i < nList.Count; i++)
                {
                    Console.WriteLine(nList[i]);
                }
            }
        }
        private void PercolateUp(int pos) //int pos to implement recursively
        {
            int parent;
            T temp;

            if (pos != 0 && pos % 2 != 0)
            {
                parent = (pos - 1) / 2;
                if(theHeap[parent].CompareTo(theHeap[pos]) < 0)
                {
                    temp = theHeap[parent];
                    theHeap[parent] = theHeap[pos];
                    theHeap[pos] = temp;
                    PercolateUp(parent);
                }
            }
            else if (pos != 0 && pos % 2 == 0)
            {
                parent = (pos - 2) / 2;
                if (theHeap[parent].CompareTo(theHeap[pos]) < 0)
                {
                    temp = theHeap[parent];
                    theHeap[parent] = theHeap[pos];
                    theHeap[pos] = temp;
                    PercolateUp(parent);
                }
            }

        }
        private void PercolateDown(int pos) //int pos to implement recursively
        {
            int minDex;
            int lChildDex;
            int rChildDex;
            T temp;

            lChildDex = 2 * pos + 1;
            rChildDex = 2 * pos + 2;

            if (rChildDex >= theHeap.Count) 
            {
                if (lChildDex >= theHeap.Count) 
                {
                    return;
                }
                else 
                {
                    minDex = lChildDex;
                }
            }
            else 
            {
                if (theHeap[lChildDex].CompareTo(theHeap[rChildDex]) <= 0)
                {
                    minDex = lChildDex;
                }
                else
                {
                    minDex = rChildDex;
                }
            }
            if (theHeap[pos].CompareTo(theHeap[minDex]) > 0)
            {
                temp = theHeap[minDex];
                theHeap[minDex] = theHeap[pos];
                theHeap[pos] = temp;
                PercolateDown(minDex);
            }
            }

        private void Heapify(List<T> list, int count, int pos) 
        {
            int left = 2 * pos + 1;
            int right = 2 * pos + 2;
            int min = 0;

            if (left < list.Count && list[left].CompareTo(list[pos]) < 0)
            {
                min = left;
            }
            else
            {
                min = pos;
            }

            if (right < list.Count && list[right].CompareTo(list[min]) < 0)
            {
                min = right;
            }
            if (min != pos)
            {
                T temp = list[pos];
                list[pos] = list[min];
                list[min] = temp;

                Heapify(list, list.Count, min);
            }
        }
        }
    }



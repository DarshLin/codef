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
        
        public Heap()
        {
            theHeap = new List<T>();
        }

        public Heap(bool isMinHeap)
        {
            int root = 0;
            int left = 2 * root + 1;
            int right = 2 * root + 2;
            if (theHeap.Count == 0)
            {
                isMinHeap = false;
            }
            for (int i = 0; i < theHeap.Count; i++)
            {
                root = i;
                if (theHeap[root].CompareTo(theHeap[left]) < 0 && theHeap[root].CompareTo(theHeap[right]) < 0)
                {
                    isMinHeap = true;
                }
                else
                    isMinHeap = false;
            }
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
                int size = theHeap.Count;
                theHeap[0] = theHeap[size - 1];
                theHeap.RemoveAt(size - 1);
                if (theHeap.Count > 0) 
                {
                    PercolateDown(0);
                }
            } 

        }
        public void Print()
        {
            for (int i = 0; i < theHeap.Count; i++)
            {
                Console.WriteLine(theHeap[i]);
            }
        }
        //public void copytest()
        //{
        //    List<T> nList = new List<T>(theHeap);
        //    for (int i = 0; i < nList.Count; i++)
        //    {
        //        Console.WriteLine(nList[i]);
        //    }
        //}
        public void HeapSort()
        {
                List<T> nList = new List<T>(theHeap);

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
        private void PercolateUp(int pos) //int pos to implement recursively
        {
            int parent;
            T temp;
            if (pos > 0)
            {
                parent = pos / 2;
                if (theHeap[parent].CompareTo(theHeap[pos]) > 0)
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

            lChildDex = 2 * pos;
            rChildDex = 2 * pos + 1;

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

        private void Heapify(List<T> list,int count, int pos) 
        {
            int l = (pos + 1) * 2 - 1;
            int r = (pos + 1) * 2;
            int min = 0;

            if (l < count && list[l].CompareTo(list[pos]) < 0)
            {
                min = l;
            }
            else
                min = pos;

            if (r < count && list[r].CompareTo(list[min]) < 0)
                min = r;
            if (min != pos)
            {
                T temp = list[pos];
                list[pos] = list[min];
                list[min] = temp;

                Heapify(list, count, min);
            }
        }
        }
    }



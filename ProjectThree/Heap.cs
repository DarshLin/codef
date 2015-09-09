using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectThree
{
    class Heap<T> where T :IComparable
    {
        private List<T> theHeap; //= new List<T>();//all T were changed to Student
        private bool isMinHeap;
        
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
        public string GetRoot()
        {
            if (theHeap.Count == 0)
            {
                return null;
            }
            else
            return theHeap[0].ToString();
        }

        public T RemoveRoot()
        {
            if (theHeap.Count == 0)
            {
                return default(T);
            }
            if (theHeap.Count == 1)
            {
                T root = theHeap.First(); //use percolate up and down as well as heapify to sort the inserted remember to copy
                theHeap.RemoveAt(0);
                return root;
            }
            else
            {
                T temp = theHeap[0];
                theHeap[0] = theHeap[theHeap.Count - 1];
                theHeap.RemoveAt(theHeap.Count - 1);
                return temp;
            }

        }
        public string Print()
        {
            string heapWrite = theHeap.ToString();
            return heapWrite;
        }
        public void HeapSort()
        {
            int p = 0;
            int l = (2 * p) + 1;
            int r = (2 * p) + 1;

            List<T> cList = new List<T>();
            for (int i = 0; i < theHeap.Count; i++)
            {
                cList[i] = theHeap[i];
            }


            while (theHeap[p].CompareTo(theHeap[l]) > 0 || theHeap[p].CompareTo(theHeap[r]) > 0)
            {
                PercolateDown();
            }
        }

        private void PercolateUp(int pos) //int pos to implement recursively
        {
            int parent;
            T temp;

            if (pos != 0 && pos % 2 != 0)
            {
                parent = (pos - 1) / 2;
                if (theHeap[parent].CompareTo(theHeap[pos]) < 0)
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
        private void PercolateDown() //int pos to implement recursively
        {
            //child = 2 * child + 1 || 2
            int pos = 0;
            int childL = (2 * pos) + 1;
            int childR = (2 * pos) + 2;

            while (theHeap[childL].CompareTo(theHeap[theHeap.Count]) < 0)//might need a compareTo depending on outcome
            {
                int min = 1;
                if (childR < theHeap.Count)//if a right child exists
                {
                    min++;
                    if (theHeap[pos].CompareTo(theHeap[min]) < 0) //if the position number is smaller
                    {
                        //swapping lower items
                        T temp = theHeap[pos];
                        theHeap[pos] = theHeap[min];
                        int place = theHeap.IndexOf(temp);
                        theHeap[min] = theHeap[place];
                        pos = min;
                        childL = (2 * pos + 1);

                    }
                    else return;
                }
            }

        }
    }

}

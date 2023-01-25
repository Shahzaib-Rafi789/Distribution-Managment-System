using DevExpress.Diagram.Core.Layout.Native;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribution_Managment_System.Data_Structure
{
    public class Min_Queue<T>
    {
        List<Node<T>> minQueue = new List<Node<T>>();
        int HeapSize = -1;


        internal List<Node<T>> MinQueue { get => minQueue; set => minQueue = value; }

        public int GetCount()
        { 
            return HeapSize + 1;
        }

        private int LeftChild(int vPriority)
        {
            return vPriority * 2 + 1;
        }

        private int RightChild(int vPriority)
        {
            return vPriority * 2 + 2;
        }

        private void MinHeapify(int i)
        {
            int left = LeftChild(i);
            int right = RightChild(i);

            int lowest = i;

            if (left <= HeapSize && minQueue[lowest].Priority > minQueue[left].Priority)
                lowest = left;
            if (right <= HeapSize && minQueue[lowest].Priority > minQueue[right].Priority)
                lowest = right;

            if (lowest != i)
            {
                var t = minQueue[i];
                minQueue[i] = minQueue[lowest];
                minQueue[lowest] = t;
                MinHeapify(lowest);
            }
        }

        private void BuildHeapMin(int i)
        {
            while (i >= 0 && minQueue[(i - 1) / 2].Priority > minQueue[i].Priority)
            {
                var t = minQueue[i];
                minQueue[i] = minQueue[(i - 1) / 2];
                minQueue[(i - 1) / 2] = t;

                i = (i - 1) / 2;
            }
        }

        public void Enqueue(double priority, T obj)
        {
            Node<T> temp = new Node<T>(priority, obj);
            HeapSize += 1;
            minQueue.Add(temp);
            BuildHeapMin(HeapSize);
        }

        public T Dequeue()
        {
            if (HeapSize > -1)
            {
                T vertix = minQueue[0].Value;
                minQueue[0] = minQueue[HeapSize];
                minQueue.RemoveAt(HeapSize);
                HeapSize--;

                MinHeapify(0);
                return vertix;
            }
            else
                return default(T);

        }

        public void UpdatePriority(T obj, double priority)
        {
            for (int i = 0; i <= HeapSize; i++)
            {
                Node<T> temp = minQueue[i];
                if (object.ReferenceEquals(temp.Value, obj))
                {
                    temp.Priority = priority;
                    BuildHeapMin(i);
                    MinHeapify(i);
                }
            }
        }

        internal class Node<T>
        {
            double priority;
            T value;

            public Node(double priority, T value)
            {
                Priority = priority;
                Value = value;
            }

            public double Priority { get => priority; set => priority = value; }
            public T Value { get => value; set => this.value = value; }
        }
    }
}

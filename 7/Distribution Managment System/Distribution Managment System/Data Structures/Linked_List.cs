using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Distribution_Managment_System.BL;

namespace Distribution_Managment_System.Data_Structures
{
    public class Node<M> where M : class 
   {
       M data;
       Node<M> next;

       public M Data { get => data; set => data = value; }
       public Node<M> Next { get => next; set => next = value; }

       public Node(M data)
       {
           Data = data;
           Next = null;
       }

       public M getData()
       {
           return Data;
       }

       public void setData(M data)
       {
           Data = data;
       }

       public Node<M> getNext()
       {
           return Next;
       }

       public void setNext(Node<M> next)
       {
           Next = next;
       }
   }

    public class Linked_List<T> where T : class
    {

        Node<T> head;
        public Linked_List()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public bool Find(T x)
        {
            Node<T> p = head;
            while (p != null)
            {
                if (p.getData() == x)
                {
                    return true;
                }
                p = p.getNext();
            }

            return false;
        }

        private void DisplayList()
        {
            Node<T> p = head;
            while (p != null)
            {
                Console.WriteLine(p.getData());
                p = p.getNext();
            }
        }

        public void InsertAthead(T Obj)
        {
            Node<T> N = new Node<T>(Obj);

            if (head != null)
            {
                N.setNext(head);
            }
            head = N;
        }

        public void InsertAtTail(T Obj)
        {
            Node<T> N = new Node<T>(Obj);
            Node<T> p = head;

            if (head != null)
            {
                while (p.getNext() != null)
                {
                    p = p.getNext();
                }

                p.setNext(N);
            }
            else
            {
                head = N;
            }
        }

        public void InsertNode(int index, T Obj)
        {
            Node<T> N = new Node<T>(Obj);
            Node<T> Current = head;
            Node<T> Prev = null;

            int lstLength = Length();
            if (index <= lstLength)
            {
                int count = 0;
                while (count < index)
                {
                    Prev = Current;
                    Current = Current.getNext();
                    count++;
                }

                if (index != 0)
                    Prev.setNext(N);
                else
                    head = N;

                N.setNext(Current);
            }
        }

        //bool Update(T NewKey, int Location)
        //{
        //    int lstLength = Length();
        //    if (lstLength > 0 && Location < lstLength)
        //    {
        //        Node<T>* P = head;
        //        int count = 0;
        //        while (count < Location)
        //        {
        //            P = P->getNext();
        //            count++;
        //        }

        //        P->setData(NewKey);
        //        return true;
        //    }
        //    return false;
        //}

        public int Length()
        {
            Node<T> p = head;
            int count = 0;
            while (p != null)
            {
                p = p.getNext();
                count++;
            }

            return count;
        }

        public bool Delete(T x)
        {
            Node<T> P = head, Prev = null;
            bool flag = false;
            while (P != null)
            {
                if (x == P.getData())
                {
                    flag = true;
                    if (Prev != null)
                    {
                        Prev.setNext(P.getNext());
                    }
                    else
                    {
                        head = head.getNext();
                    }
                }
                Prev = P;
                P = P.getNext();
            }

            return flag;
        }

        private bool DeleteFromStart()
        {
            if (head != null)
            {
                head = head.getNext();
                return true;
            }

            return false;
        }

        private bool DeleteFromEnd()
        {
            if (head == null) { return false; }
            else if (head.getNext() == null)
            {
                head = null;
                return true;
            }

            Node<T> P = head;
            while (P != null)
            {
                if (P.getNext().getNext() == null)
                {
                    P.setNext(null);
                    return true;
                }
                P = P.getNext();
            }
            return false;
        }

        private void reverseList()
        {
            Node<T> Current = head.getNext(), P = head;
            Node<T> Prev = head;
            while (Current != null)
            {
                Node<T> temp = Current.getNext();
                Prev.setNext(Current.getNext());
                Current.setNext(head);
                head = Current;

                Current = temp;
            }
        }
    }
}

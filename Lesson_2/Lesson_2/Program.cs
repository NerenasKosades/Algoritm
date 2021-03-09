using System;
using System.Collections.Generic;
using System.Collections;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleList<string> linkedList = new DoubleList<string>();
            // добавление элементов
            linkedList.Add("Bob");
            linkedList.Add("Bill");
            linkedList.Add("Tom");
            linkedList.AddFirst("Kate");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
           
            linkedList.Remove("Bill");

            
            foreach (var t in linkedList.BackEnumerator())
            {
                Console.WriteLine(t);
            }
        }
    }

    public class DoubleNode<T>
    {
        public DoubleNode(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public DoubleNode<T> Previos { get; set; }
        public DoubleNode<T> Next { get; set; }
        public DoubleNode<T> Previous { get; internal set; }
    }

    public class DoubleList<T> : IEnumerable<T>
    {
        DoubleNode<T> head;
        DoubleNode<T> tail;
        int count;

        public void Add(T data)
        {
            DoubleNode<T> node = new DoubleNode<T>(data);

            if(head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Previos = tail;
            }
            tail = node;
            count++;
        }

        public bool Remove(T data)
        {
            DoubleNode<T> current = head;


            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {

                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {

                    tail = current.Previous;
                }


                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {

                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }
            public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            DoubleNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoubleNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<T> BackEnumerator()
        {
            DoubleNode<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }

        internal void AddFirst(string v)
        {
            throw new NotImplementedException();
        }
    }
}

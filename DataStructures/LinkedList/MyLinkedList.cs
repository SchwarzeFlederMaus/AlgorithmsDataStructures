using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    internal class MyLinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; private set; }
        public MyLinkedList() => Clear();
        public MyLinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        private void SetHeadAndTail(T data)
        {
            Head = new Node<T>(data);
            Tail = Head;
            Count++;
        }

        public void AppendFirst(T data)
        {
            var newHead = new Node<T>(data);
            newHead.Next = Head;
            Head = newHead;
            Count++;
        }
        public void Add(T data)
        {
            if (Head is null) SetHeadAndTail(data);
            else
            {
                Tail.Next = new Node<T>(data);
                Tail = Tail.Next;
                Count++;
            }
        }
        public void Remove(T data)
        {
            if (Head is null) return;
            if (Head.Data.Equals(data))
            {
                Head = Head.Next;
                Count--;
                return;
            }

            var previous = Head;
            var current = Head.Next;
            while (current is not null)
            {
                if (current.Data.Equals(data))
                {
                    previous.Next = current.Next;
                    Count--;
                    return;
                }
                previous = current;
                current = current.Next;
            }
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public bool Contains(T data)
        {
            var current = Head;
            while (current is not null)
            {   
                if (current.Data.Equals(data)) return true;
                current = current.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current is not null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

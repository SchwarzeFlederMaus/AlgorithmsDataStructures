using System.Collections;
using System.Security.Cryptography;

namespace DataStructures.LinkedList
{
    public class DoblyLinkedList<T> : IEnumerable<T>
    {
        private DoublyNode<T> _head;
        private DoublyNode<T> _tail;

        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public DoblyLinkedList() => Clear();
        public DoblyLinkedList(T data) => InitializeComponent(data);
        public DoblyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                Add(item);
        }

        public void Add(T data)
        {
            if (IsEmpty)
            {
                InitializeComponent(data);
                return;
            }

            var newNode = new DoublyNode<T>(data);
            _tail.Next = newNode;
            newNode.Previous = _tail;
            _tail = newNode;
            Count++;
        }
        public void Delete(T data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            var current = _head;
            while (current != null)
            {
                if (!current.Data.Equals(data))
                {
                    current = current.Next;
                    continue;
                }

                if (current.Previous != null) current.Previous.Next = current.Next;
                else _head = current.Next;

                if (current.Next != null) current.Next.Previous = current.Previous;
                else _tail = current.Previous;

                Count--;
                return;
            }
        }
        public void AddFirst(T data)
        {
            if (IsEmpty)
            {
                InitializeComponent(data);
                return;
            }
            var newNode = new DoublyNode<T>(data);
            newNode.Next = _head;
            _head.Previous = newNode;
            _head = newNode;
            Count++;
        }
        public void AddLast(T data) => Add(data);
        public void DeleteFirst()
        {
            if (IsEmpty) return;
            _head = _head.Next;
            _head.Previous = null;
            Count--;
        }
        public void DeleteLast()
        {
            if (IsEmpty) return;
            _tail = _tail.Previous;
            _tail.Next = null;
            Count--;
        }
        public DoblyLinkedList<T> Reverse()
        {
            var reversed = new DoblyLinkedList<T>();
            var current = _tail;
            while (current != null)
            {
                reversed.Add(current.Data);
                current = current.Previous;
            }
            return reversed;
        }
        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        private void InitializeComponent(T data)
        {
            _head = new DoublyNode<T>(data);
            _tail = _head;
            Count = 1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

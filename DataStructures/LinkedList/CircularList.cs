using System.Collections;

namespace DataStructures.LinkedList
{
    public class CircularList<T> : IEnumerable<T>
    {
        private DoublyNode<T> _head;
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public CircularList() => Clear();
        public CircularList(T data) => InitializeComponent(data);
        public CircularList(IEnumerable<T> collection)
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
            newNode.Next = _head;
            newNode.Previous = _head.Previous;
            _head.Previous.Next = newNode;
            _head.Previous = newNode;
            Count++;
        }
        public void Remove(T data)
        {
            if (_head == null) return;
            if (_head.Data.Equals(data))
            {
                RemoveFirst();
                return;
            }

            var current = _head.Next;
            do
            {
                if (!current.Data.Equals(data))
                {
                    current = current.Next;
                    continue;
                }
                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;
                Count--;
                return;
            } 
            while (current != _head);
        }
        public void RemoveFirst()
        {
            if (_head == null) return;
            if (_head.Next == _head)
            {
                Clear();
                return;
            }
            _head.Next.Previous = _head.Previous;
            _head.Previous.Next = _head.Next;
            _head = _head.Next;
            Count--;
        }
        private void InitializeComponent(T data)
        {
            _head = new DoublyNode<T>(data);
            _head.Next = _head;
            _head.Previous = _head;
            Count = 1;
        }
        public void Clear()
        {
            _head = null;
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
                if (current == _head) break;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

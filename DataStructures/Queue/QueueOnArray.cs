
using System.Drawing;

namespace DataStructures.Queue
{
    public class QueueOnArray<T>
    {
        private T[] _items;
        private int _size;
        private int _tail;
        private int Count => _tail + 1;
        public int Capacity => _size;
        public bool IsEmpty => Count == 0;

        public QueueOnArray(int size) => InitializeQueue(size);
        public QueueOnArray(int size, T data)
        {
            InitializeQueue(size);
            Enqueue(data);
        }
        public QueueOnArray(IEnumerable<T> items)
        {
            InitializeQueue(items.Count());
            foreach (var item in items) Enqueue(item);
        }

        private void InitializeQueue(int size)
        {
            _size = size;
            _items = new T[_size];
            _tail = -1;
        }
        public void Enqueue(T item)
        {
            if (_tail == _size - 1) throw new InvalidOperationException("Queue is full");
            _items[++_tail] = item;
        }
        public T Dequeue()
        {
            var item = Peek();
            Array.Copy(_items, 1, _items, 0, Count - 1);
            _tail--;
            return item;
        }
        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("Queue is empty");
            return _items[0];
        }
    }
}

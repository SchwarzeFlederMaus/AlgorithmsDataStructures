namespace DataStructures.Queue
{
    public class MyQueue<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public MyQueue() => Clear();
        public MyQueue(T data) => Initialize(data);
        public MyQueue(IEnumerable<T> collection)
        {
            foreach (var item in collection) Enqueue(item);
        }

        public void Enqueue(T data)
        {
            if (IsEmpty)
            {
                Initialize(data);
                return;
            }
            var node = new Node<T>(data);
            _tail.Next = node;
            _tail = node;
            Count++;
        }
        public T Dequeue()
        {
            var data = Peek();
            _head = _head.Next;
            Count--;
            return data;
        }
        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("Queue is empty");
            return _head.Data;
        }
        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }
        private void Initialize(T data)
        {
            var node = new Node<T>(data);
            _head = node;
            _tail = node;
            Count++;
        }
    }
}

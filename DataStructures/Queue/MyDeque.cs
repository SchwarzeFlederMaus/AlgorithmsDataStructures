
namespace DataStructures.Queue
{
    public class MyDeque<T>
    {
        private DoublyNode<T> _head;
        private DoublyNode<T> _tail;
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public MyDeque() => Clear();
        public MyDeque(T data) => InitializeMyDeque(data);
        public MyDeque(IEnumerable<T> collection)
        {
            foreach (var item in collection) EnqueueTail(item);
        }

        public void EnqueueTail(T data)
        {
            if (IsEmpty)
            {
                InitializeMyDeque(data);
                return;
            }
            var newNode = new DoublyNode<T>(data);
            _tail.Next = newNode;
            newNode.Previous = _tail;
            _tail = newNode;
            Count++;
        }
        public void EnqueueHead(T data)
        {
            if (IsEmpty)
            {
                InitializeMyDeque(data);
                return;
            }
            var newNode = new DoublyNode<T>(data);
            _head.Previous = newNode;
            newNode.Next = _head;
            _head = newNode;
            Count++;
        }
        public T DequeueTail()
        {
            var data = PeekTail();
            if (_head == _tail)
            {
                Clear();
                return data;
            }
            _tail = _tail.Previous;
            _tail.Next = null;
            Count--;
            return data;
        }
        public T DequeueHead()
        {
            var data = PeekHead();
            if (_head == _tail)
            {
                Clear();
                return data;
            }
            _head = _head.Next;
            _head.Previous = null;
            Count--;
            return data;
        }
        public T PeekTail()
        {
            if (IsEmpty) throw new InvalidOperationException("The deque is empty.");
            return _tail.Data;
        }
        public T PeekHead()
        {
            if (IsEmpty) throw new InvalidOperationException("The deque is empty.");
            return _head.Data;
        }
        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }
        private void InitializeMyDeque(T data)
        {
            _head = new DoublyNode<T>(data);
            _tail = _head;
            Count = 1;
        }
    }
}

namespace DataStructures.Stack
{
    public class MyStack<T>
    {
        private Node<T> _head;
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public MyStack() => Clear();
        public MyStack(T data) => Push(data);
        public MyStack(IEnumerable<T> collection)
        {
            foreach (var item in collection) Push(item);
        }

        public void Push(T data)
        {
            var newHead = new Node<T>(data);
            newHead.Previous = _head;
            _head = newHead;
            Count++;
        }
        public T Pop()
        {
            var data = Peek();
            _head = _head.Previous;
            Count--;
            return data;
        }
        public T Peek()
        {
            if (IsEmpty) throw new StackOverflowException("Stack is empty");
            return _head.Data;
        }
        private void Clear() => _head = null;
    }
}

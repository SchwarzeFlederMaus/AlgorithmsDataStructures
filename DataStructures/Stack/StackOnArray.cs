namespace DataStructures.Stack
{
    public class StackOnArray<T>
    {
        private T[] _items;
        private int _size;
        private int _top;

        public int Count => _top + 1;
        public int Capacity => _size;
        public bool IsEmpty => Count == 0;

        public StackOnArray(int size)
        {
            _size = size;
            _items = new T[_size];
            _top = -1;
        }
        public void Push(T item)
        {
            if (_top == _size - 1) throw new StackOverflowException();
            _items[++_top] = item;
        }
        public T Pop()
        {
            if (Count == 0) throw new StackOverflowException();
            return _items[_top--];
        }
        public T Peek()
        {
            if (Count == 0) throw new StackOverflowException();
            return _items[_top];
        }
    }
}

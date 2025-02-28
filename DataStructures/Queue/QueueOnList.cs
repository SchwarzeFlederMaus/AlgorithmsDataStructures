namespace DataStructures.Queue
{
    public class QueueOnList<T>
    {
        private readonly List<T> _items = new();

        private T Head => _items.First();
        public int Count => _items.Count;
        public bool IsEmpty => Count == 0;

        public QueueOnList() => Clear();
        public QueueOnList(T data) => Enqueue(data);
        public QueueOnList(IEnumerable<T> items) => _items.AddRange(items);

        public void Enqueue(T item) => _items.Add(item);
        public T Dequeue()
        {
            var item = Peek();
            _items.Remove(item);
            return item;
        }
        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("Queue is empty");
            return Head;
        }
        public void Clear() => _items.Clear();
    }
}

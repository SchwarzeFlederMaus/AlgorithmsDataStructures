
namespace DataStructures.Stack
{
    public class StackOnList<T>
    {
        private readonly List<T> _dataList;
        public int Count => _dataList.Count;
        public bool IsEmpty => _dataList.Count == 0;

        public StackOnList() => _dataList = new List<T>();
        public StackOnList(T data) => _dataList = new List<T> { data };
        public StackOnList(IEnumerable<T> collection) => _dataList = new List<T>(collection);

        public void Push(T data) => _dataList.Add(data);
        public T Pop()
        {
            var data = Peek();
            _dataList.Remove(data);
            return data;
        }
        public T Peek()
        {
            if (IsEmpty) throw new StackOverflowException("Stack is empty");
            return _dataList[_dataList.Count - 1];
        }
        public void Clear() => _dataList.Clear();
    }
}



namespace DataStructures.HashTable
{
    public class MyHashTable <TKey, TValue>
    {
        private readonly Node<TKey, TValue>[] _items;
        private readonly int _size;
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;
        public int Capacity => _size;

        public MyHashTable(int size)
        {
            _size = size;
            _items = new Node<TKey, TValue>[_size];
        }
        public MyHashTable(int size, TKey key, TValue value)
        {
            _size = size;
            _items = new Node<TKey, TValue>[_size];
            Add(key, value);
        }

        public void Add(TKey key, TValue value)
        {
            var pos = GetPosition(key);
            if (_items[pos] == null) _items[pos] = new Node<TKey, TValue>(key, new List<TValue>() { value });
            else if (_items[pos].Key.Equals(key)) _items[pos].Values.Add(value);
            else _items[pos] = new Node<TKey, TValue>(key, new List<TValue>() { value });
            Count++;
        }
        public void Remove(TKey key)
        {
            var pos = GetPosition(key);
            if (_items[pos].Key.Equals(key))
            {
                _items[pos] = null;
                Count--;
            }
        }
        public void Remove(TKey key, TValue value)
        {
            var pos = GetPosition(key);
            if (_items[pos].Key.Equals(key))
            {
                _items[pos].Values.Remove(value);
                Count--;
            }
        }
        public List<TValue> Get(TKey key)
        {
            var pos = GetPosition(key);
            return _items[pos].Key.Equals(key) ? _items[pos].Values : null;
        }
        public TValue Get(TKey key, int index)
        {
            var pos = GetPosition(key);
            return _items[pos].Key.Equals(key) ? _items[pos].Values[index] : default;
        }
        public bool Contains(TKey key, TValue value)
        {
            var pos = GetPosition(key);
            return _items[pos].Key.Equals(key) && _items[pos].Values.Contains(value);
        }
        public bool ContainsKey(TKey key)
        {
            var pos = GetPosition(key);
            return _items[pos] != null && _items[pos].Key.Equals(key);
        }
        public bool ContainsValue(TValue value)
        {
            foreach (var item in _items)
            {
                if (item != null && item.Values.Contains(value)) return true;
            }
            return false;
        }
        public void Clear()
        {
            Array.Clear(_items, 0, _size);
            Count = 0;
        }

        private int GetPosition(TKey key) => Math.Abs(key.GetHashCode() % _size);
    }
}

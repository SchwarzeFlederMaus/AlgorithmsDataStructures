using System.Collections;

namespace DataStructures.Dictionary
{
    public class MyDictionary<TKey, TValue> : IEnumerable<Node<TKey, TValue>>
    {
        private const int INITIAL_SIZE = 5;
        private readonly List<TKey> _keys;
        private int _size;
        private Node<TKey, TValue>[] _items;
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public MyDictionary()
        {
            _size = INITIAL_SIZE;
            _items = new Node<TKey, TValue>[_size];
            _keys = new List<TKey>();
        }
        public MyDictionary(int size)
        {
            _size = size;
            _items = new Node<TKey, TValue>[_size];
            _keys = new List<TKey>();
        }
        public MyDictionary(TKey key, TValue value)
        {
            _size = INITIAL_SIZE;
            _items = new Node<TKey, TValue>[_size];
            _keys = new List<TKey>();
            Add(key, value);
        }
        public MyDictionary(IDictionary<TKey, TValue> dictionary)
        {
            _size = dictionary.Count;
            _items = new Node<TKey, TValue>[_size];
            _keys = new List<TKey>();
            foreach (var item in dictionary)
            {
                Add(item.Key, item.Value);
            }
        }

        public void Add(TKey key, TValue value)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (_keys.Contains(key)) throw new ArgumentException("Key already exists");

            var startPosition = GetHash(key);
            if (TryToAddInDictionary(key, value, startPosition)) return;

            var node = _items[startPosition].Next;
            while (node != null) node = node.Next;

            var position = startPosition;
            do
            {
                position = (position + 1) % _size;
                if (TryToAddInDictionary(key, value, position)) return;
            } while (startPosition != position);

            Resize();
            Add(key, value);
        }
        public void Remove(TKey key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (!_keys.Contains(key)) throw new ArgumentException("Key not found");

            var position = GetHash(key);
            if (_items[position].Key.Equals(key))
            {
                _items[position] = null;
                _keys.Remove(key);
                Count--;
                return;
            }
            var node = _items[position];
            while (node.Next != null)
            {
                if (node.Next.Key.Equals(key))
                {
                    node.Next = node.Next.Next;
                    _keys.Remove(key);
                    Count--;
                    return;
                }
                node = node.Next;
            }
        }
        public TValue GetValue(TKey key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (!_keys.Contains(key)) throw new ArgumentException("Key not found");

            var position = GetHash(key);
            if (_items[position].Key.Equals(key)) return _items[position].Value;

            var node = _items[position];
            while (node.Next != null)
            {
                if (node.Next.Key.Equals(key)) return node.Next.Value;
                node = node.Next;
            }
            throw new ArgumentException("Key not found");
        }
        public void Clear()
        {
            Array.Clear(_items, 0, _items.Length);
            _keys.Clear();
            Count = 0;
        }
        public bool ContainsKey(TKey key) => _keys.Contains(key);
        public bool ContainsValue(TValue value)
        {
            foreach (var item in _items)
            {
                if (item != null && item.Value.Equals(value)) return true;
            }
            return false;
        }

        private int GetHash(TKey key) => key.GetHashCode() % _size;
        private bool TryToAddInDictionary(TKey key, TValue value, int position)
        {
            if (_items[position] != null) return false; 

            _items[position] = new Node<TKey, TValue>(key, value);
            _keys.Add(key);
            Count++;
            return true; 
        }
        private void Resize()
        {
            _size *= 2;
            var temp = _items;
            _items = new Node<TKey, TValue>[_size];
            Array.Copy(temp, _items, temp.Length);
        }

        public TValue this[TKey key] => GetValue(key);
        public IEnumerator<Node<TKey, TValue>> GetEnumerator()
        {
            foreach (var item in _items)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();       
    }
}

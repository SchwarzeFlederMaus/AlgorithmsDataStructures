using System.Collections;

namespace DataStructures.Set
{
    public class MySet<T> : IEnumerable<T>, ICollection
    {
        private readonly Hashtable _items = new();
        public int Count => _items.Count;
        public bool IsEmpty => Count == 0;

        public bool IsSynchronized => _items.IsSynchronized;
        public object SyncRoot => _items.SyncRoot;

        public MySet() => Clear();
        public MySet(T item) => Add(item);
        public MySet(IEnumerable<T> collection)
        {
            foreach (var item in collection) Add(item);
        }

        public void Add(T item)
        {
            if (_items.ContainsKey(item)) return;
            _items.Add(item, null);
        }
        public void Remove(T item) => _items.Remove(item);
        public void Clear() => _items.Clear();
        public MySet<T> UnionWith(MySet<T> other)
        {
            var result = new MySet<T>();
            foreach (var item in this) result.Add(item);
            foreach (var item in other) result.Add(item);
            return result;
        }
        public MySet<T> IntersectWith(MySet<T> other)
        {
            var result = new MySet<T>();
            foreach (var item in this)
            {
                if (other.Contains(item)) result.Add(item);
            }
            return result;
        }
        public MySet<T> DifferenceWith(MySet<T> other)
        {
            var result = new MySet<T>();
            foreach (var item in this)
            {
                if (!other.Contains(item)) result.Add(item);
            }
            return result;
        }
        public bool IsSubset(MySet<T> other)
        {
            foreach (var item in this)
            {
                if (!other.Contains(item)) return false;
            }
            return true;
        }
        public MySet<T> SymmetricDifferenceWith(MySet<T> other)
        {
            var result = new MySet<T>();
            foreach (var item in this)
            {
                if (!other.Contains(item)) result.Add(item);
            }
            foreach (var item in other)
            {
                if (!this.Contains(item)) result.Add(item);
            }
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (DictionaryEntry entry in _items)
                yield return (T)entry.Key;
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public void CopyTo(Array array, int index) => _items.CopyTo(array, index);
    }
}

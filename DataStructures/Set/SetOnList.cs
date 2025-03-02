using System.Collections;

namespace DataStructures.Set
{
    public class SetOnList<T> : IEnumerable<T>, ICollection
    {
        private readonly List<T> _items = new();
        public int Count => _items.Count;
        public bool IsEmpty => Count == 0;

        public bool IsReadOnly => false;
        public bool IsSynchronized => false;
        public object SyncRoot => _items;


        public SetOnList() => Clear();
        public SetOnList(T item) => Add(item);
        public SetOnList(IEnumerable<T> collection)
        {
            foreach (var item in collection) Add(item);
        }

        public void Add(T item)
        {
            if (_items.Contains(item)) return;
            _items.Add(item);
        }
        public void Remove(T item) => _items.Remove(item);
        public void Clear() => _items.Clear();
        public SetOnList<T> UnionWith(SetOnList<T> other)
        {
            var result = new SetOnList<T>(_items);
            foreach (var item in other) result.Add(item);
            return result;

            //LINQ Alternative:
            //return new SetOnList<T>(this.Union(other));
        }
        public SetOnList<T> IntersectWith(SetOnList<T> other)
        {
            var result = new SetOnList<T>();
            foreach (var item in _items)
            {
                if (other.Contains(item)) result.Add(item);
            }
            return result;

            //LINQ Alternative:
            //return new SetOnList<T>(this.Intersect(other));
        }
        public SetOnList<T> DifferenceWith(SetOnList<T> other)
        {
            var result = new SetOnList<T>(_items);
            foreach (var item in other) result.Remove(item);
            return result;

            //LINQ Alternative:
            //return new SetOnList<T>(this.Except(other));
        }
        public bool IsSubset(SetOnList<T> other)
        {
            foreach (var item in _items)
            {
                if (!other.Contains(item)) return false;
            }
            return true;

            //LINQ Alternative:
            //return this.All(other.Contains);
        }
        public SetOnList<T> SymmetricDifferenceWith(SetOnList<T> other)
        {
            var result = new SetOnList<T>(_items);
            foreach (var item in other)
            {
                if (result.Contains(item)) result.Remove(item);
                else result.Add(item);
            }
            return result;

            //LINQ Alternative:
            //return new SetOnList<T>(this.Except(other).Union(other.Except(this)));
        }

        public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void CopyTo(Array array, int index) => _items.CopyTo((T[])array, index);
    }
}

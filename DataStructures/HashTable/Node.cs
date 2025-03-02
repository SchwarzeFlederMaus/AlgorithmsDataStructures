namespace DataStructures.HashTable
{
    public class Node <TKey, TValue>
    {
        public TKey Key { get; set; }
        public List<TValue> Values { get; set; }
        public Node(TKey key, List<TValue> values)
        {
            Key = key;
            Values = values;
        }
        public Node(TKey key, TValue value)
        {
            Key = key;
            Values = new List<TValue>() { value };
        }
    }
}
